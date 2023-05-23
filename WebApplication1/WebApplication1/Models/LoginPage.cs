
using MessagePack;
using System.ComponentModel.DataAnnotations;
using WebApplication1.Models;

namespace WebApplication1.Models
{
    public class LoginPage
    {
        [System.ComponentModel.DataAnnotations.Key]
        public string username { get; set; }

        public string password { get; set; }
    }
}
