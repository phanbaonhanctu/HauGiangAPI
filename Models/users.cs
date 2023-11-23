namespace HauGiangAPI.Models
{
    using System;

    public class User
    {
        public Guid IdUser { get; set; }
        public string CCCD { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Nation { get; set; }
        public string Education { get; set; }
        public int NumPeople { get; set; }
        public int NumFemale { get; set; }
        public string Job { get; set; }
        public string Income { get; set; }
        public string UsedService { get; set; }
        public string Token { get; set; }
    }

}
