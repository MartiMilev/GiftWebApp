using GiftWebApp.Models;

namespace GiftWebApp.Contracts
{
	public interface IEmployyeService
	{
		Task<IEnumerable<EmployyeIndexServiceModel>> AllEmployyes();
	}
}
