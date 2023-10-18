using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GiftApp.Data.Enteties
{
	public class Vote
	{
		[Key]
		public int Id { get; set; }

		[ForeignKey("GiftId")]
		public int GiftId { get; set; }
		public Gift Gift { get; set; } = null!;

		public DateTime VoteTime { get; set; }
	}
}