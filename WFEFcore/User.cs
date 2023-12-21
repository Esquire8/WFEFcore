using System.ComponentModel.DataAnnotations;

namespace WFEFcore
{
    internal class User
    {
        [Key] public int id { get; set; }
        public string user_login { get; set; }
        public string user_password { get; set; }
    }
}
