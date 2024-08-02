using Microsoft.AspNetCore.Identity;

namespace Hospital_Management.Models
{
    public class AppUsers : IdentityUser
    {
        public string fName { get; set; } = "";
        public string lName { get; set; } = "";
        public DateTime CreatedAt { get; set; }
    }
}
