using Newtonsoft.Json;
using System;

namespace HauGiangAPI.Models
{
    public class UsersModel
    {
        public string Fullname { get; set; }
        public string Cccd { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Nation { get; set; }
        public string Education { get; set; }
        public int Numpeople { get; set; }
        public int Numfemale { get; set; }
        public string Job { get; set; }
        public int Income { get; set; }
        public string Usedservice { get; set; }

        // Phương thức từ JSON để chuyển đối tượng thành UsersModel
        public static UsersModel FromJson(string json)
        {
            return JsonConvert.DeserializeObject<UsersModel>(json);
        }

        // Phương thức ToJson để chuyển đối tượng thành chuỗi JSON
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

}
