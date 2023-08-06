using System.ComponentModel.DataAnnotations;

namespace SuperHeroAPI.Models
{
	public class User
	{
		[Key]
		public int Id { get; set; }


		[Required]
		[MaxLength(50)]
		public string UserName { get; set; }

		[Required]
		[MaxLength(50)]
		public string Password { get; set; }

		public string Email { get; set; }
		public string Name { get; set; }
	}
}
