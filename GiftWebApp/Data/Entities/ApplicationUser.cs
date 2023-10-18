using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace GiftApp.Data.Enteties
{
	public class ApplicationUser : IdentityUser
	{
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime Burthday { get; set; }

    }
}
