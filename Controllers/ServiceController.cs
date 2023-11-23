using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System.Collections;
using Newtonsoft.Json.Linq;
using System;
using HauGiangAPI.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HauGiangAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        // GET: api/<ServiceController>
        // Khai báo chuỗi kết nối:
        string connectionString = "Server=api.ctu-it.com;Database=KhaoSat;User=sa;Password=Nolove@@123;Encrypt=True;TrustServerCertificate=True;";
        [HttpGet]
        public dynamic Get()
        {
            // Khai báo đối tượng SQL Connection:
            SqlConnection connection = new SqlConnection(connectionString);
            // Khai báo đối tượng SQL Command cho phép thao tác với CSDL:
            SqlCommand command = connection.CreateCommand();
            // Khai báo câu truy vấn:
            command.CommandText = "select * from usedService";
            // Mở kết nối tới Database:
            List<string> result = new List<string>();
            try
            {
                connection.Open();
                // Thực thi công việc với Database:
                SqlDataReader reader = command.ExecuteReader();
                // Xử lý dữ liệu trả về:
                while (reader.Read())
                {
                    string serVice;
                    serVice = reader.GetString(1);
                    result.Add(serVice.Trim());
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
            return Ok(JsonConvert.SerializeObject(result));
        }
        [HttpPost]
        public dynamic Post([FromBody] UsersModel data)
        {
            // sử dụng dữ liệu từ đối tượng UsersModel
            // ví dụ: return data.fullname;

            // hoặc nếu bạn muốn trả về một giá trị cụ thể:
            return Ok("acffaa5f-5873-4c6e-b60b-221f4ed6f647");
        }

    }
}
