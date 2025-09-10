namespace Portfolio.Web.Entities
{
	public class Experiance
	{
		public int ExperianceId { get; set; }
		public int	StartYear { get; set; }
		public string?	EndYear { get; set; }
		public string	Company { get; set; }
		public string   City { get; set; }
		public string	Description { get; set; }
	}
}
