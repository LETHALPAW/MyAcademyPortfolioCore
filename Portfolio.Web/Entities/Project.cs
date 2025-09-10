using System.ComponentModel.DataAnnotations;

namespace Portfolio.Web.Entities
{
	public class Project
	{
		public int ProjectId { get; set; }
		[MinLength(5,ErrorMessage ="En az 5 karakter gerekli.")]
		[MaxLength(50, ErrorMessage = "En fazla 50 karakter gerekli.")]
		[Required(ErrorMessage ="Boş bırakılamaz")]
		public string ProjectName { get; set; }

		[Required(ErrorMessage = "Boş bırakılamaz")]
		public string Description { get; set; }

		[Required(ErrorMessage = "Boş bırakılamaz")]
		public string ImageUrl { get; set; }

		
		public string GithubUrl { get; set; }

		
		public int CategoryId { get; set; }

		public Category? Category { get; set; }
	}
}
