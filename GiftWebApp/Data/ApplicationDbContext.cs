using GiftApp.Data.Enteties;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace GiftWebApp.Data
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public ApplicationUser employyeUser { get; set; }
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
		public DbSet<Gift> Gifts { get; set; }
		public DbSet<Vote> Votes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            string[] firstName = {"Ivan","Georgi", "Misho", "Dimitar", "Svetlin", "Raq", "Mariq", "Gabriela", "Cvetelina", "Vanesa" };
            string[] lastName = { "Stoikov", "Minkov", "Vasilev", "Georgiev", "Simeonov", "Angelova", "Krusteva", "Cvetanova", "Ivanova", "Nikolova" };
            DateTime[] burthdays =
                { 
                new DateTime(1994, 11, 21),
                new DateTime(1990, 11, 22),
                new DateTime(1993, 10, 30),
                new DateTime(1991, 11, 01),
                new DateTime(2001, 01, 01),
                new DateTime(1995, 08, 07),
                new DateTime(1992, 04, 22),
                new DateTime(1997, 09, 13),
                new DateTime(1991, 04, 11),
                new DateTime(1999, 03, 11),
                };
            string[] emails = { "ivan@gmail.com", "georgi@gmail.com", "misho@gmail.com", "dimitar@gmail.com", "svetlin@gmail.com" , "raq@gmail.com", "mariq@gmail.com", "gabriela@gmail.com", "cvetelina@gmail.com", "vanesa@gmail.com" };
            string[] passwords = { "ivan123", "georgi123", "misho123","dimitar123","svetlin123","raq123","mariq123","gabriela123","cvetelina123","vanesa123"};

            var hasher = new PasswordHasher<ApplicationUser>();

            for (int i = 0; i < firstName.Length; i++)
            {
                employyeUser = new ApplicationUser()
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = firstName[i],
                    LastName = lastName[i],
                    Burthday = burthdays[i],
                    Email = emails[i],
                };
                employyeUser.PasswordHash = hasher.HashPassword(employyeUser, passwords[i]);
                modelBuilder.Entity<ApplicationUser>()
                    .HasData(employyeUser);
            }
                modelBuilder.Entity<Vote>()
                .HasOne(v => v.Gift);
          
            modelBuilder
                .Entity<Gift>()
                .HasData(new Gift()
                {
                    Id = 1,
                    Name = "Iphone 12 Pro",
                });
            modelBuilder
                .Entity<Gift>()
                .HasData(new Gift()
                {
                    Id = 2,
                    Name = "Samsung Galaxy Z Flip",
                });
            modelBuilder
                .Entity<Gift>()
                .HasData(new Gift()
                {
                    Id = 3,
                    Name = "Smart watch",
                }); modelBuilder
                .Entity<Gift>()
                .HasData(new Gift()
                {
                    Id = 4,
                    Name = "Vacantion",
                }); modelBuilder
                .Entity<Gift>()
                .HasData(new Gift()
                {
                    Id = 5,
                    Name = "Store voucher",
                }); modelBuilder
                .Entity<Gift>()
                .HasData(new Gift()
                {
                    Id = 6,
                    Name = "Money",
                });



            base.OnModelCreating(modelBuilder);
		}
		
	}
}