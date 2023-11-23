using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System;
using HauGiangAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HauGiangAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        // GET: api/<LoginController>
        [HttpGet]
        public dynamic Get()
        {
            // Khai báo chuỗi kết nối:
            string connectionString = "Server=api.ctu-it.com;Database=KhaoSat;User=sa;Password=Nolove@@123;Encrypt=True;TrustServerCertificate=True;";
            // Khai báo đối tượng SQL Connection:
            SqlConnection connection = new SqlConnection(connectionString);
            // Khai báo đối tượng SQL Command cho phép thao tác với CSDL:
            SqlCommand command = connection.CreateCommand();
            // Khai báo câu truy vấn:
            command.CommandText = "SELECT * FROM usedService";
            // Mở kết nối tới Database:
            List<User> result = new List<User>();
            try
            {
                connection.Open();
                // Thực thi công việc với Database:
                SqlDataReader reader = command.ExecuteReader();
                // Xử lý dữ liệu trả về:
                while (reader.Read())
                {
                    User user = new User
                    {
                        IdUser = (Guid)reader["idUser"],
                        FullName = reader["fullname"].ToString(),
                        // Thêm các trường dữ liệu khác của users tại đây
                    };
                    result.Add(user);
                }
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi, in thông báo
                return StatusCode(500, "Database connection error!");
            }
            finally
            {
                // Đảm bảo luôn đóng kết nối, dù có lỗi hay không
                connection.Close();
            }
            return Ok(result);
        }
    }
}
