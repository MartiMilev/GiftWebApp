using GiftWebApp.Contracts;
using GiftWebApp.Data;
using GiftWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GiftWebApp.Services
{
	public class EmployyeService : IEmployyeService
	{
		private readonly ApplicationDbContext data;

        public EmployyeService(ApplicationDbContext data)
        {
            this.data = data;
        }

		public async Task<IEnumerable<EmployyeIndexServiceModel>> AllEmployyes()
		{
			return await data
				.Users
				.Select(c => new EmployyeIndexServiceModel
				{
					Id = c.Id,
					FirstName = c.FirstName,
					LastName = c.LastName,
					Burthday = c.Burthday
				}).ToListAsync();
		}
	}
}
