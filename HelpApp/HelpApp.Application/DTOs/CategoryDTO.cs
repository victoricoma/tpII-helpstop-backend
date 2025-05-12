using System.ComponentModel.DataAnnotations;

namespace HelpApp.Application.DTOs
{
	public class CategoryDTO
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "Invalid name, name is required.")]
		[MinLength(3)]
		[MaxLength(100)]
		public string Name { get; set; }
		[Required(ErrorMessage = "Invalid name, too short, minimum 3 characters.")]

	}
}
