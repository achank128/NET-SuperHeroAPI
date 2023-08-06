using System.ComponentModel.DataAnnotations;

namespace SuperHeroAPI.Dto
{
	public class SuperHeroDto
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;
		public string Place { get; set; } = string.Empty;
	}
}
