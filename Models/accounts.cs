using System;

namespace HauGiangAPI.Models
{
    public class accounts
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public int? PermissionId { get; set; }
        public int? Status { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public int? Gender { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
