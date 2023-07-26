using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BulkyWebRazor_Temp.Models
{
	[Table("CategoryMovies")]
	public class Category
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[DisplayName("Display Order")]
		[Range(1, 100, ErrorMessage = "Display Order must be between 1-100.")]
		public int DisplayOrder { get; set; }
	}
}
