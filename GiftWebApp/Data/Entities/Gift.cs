using System.ComponentModel.DataAnnotations;

namespace GiftApp.Data.Enteties
{
	public class Gift
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; } = null!;
	}

}
