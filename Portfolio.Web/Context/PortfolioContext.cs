using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Context
{
	public class PortfolioContext:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=GE-ABALLI15\\MSSQLSERVER2022;database=MyAcademyPortfolioDb;user id=sa;password=Btnsft1958;TrustServerCertificate=True;");
		}
		public DbSet<Entities.Education> Educations { get; set; }
		public DbSet<Entities.Experiance> Experiances { get; set; }
		public DbSet<Entities.Category> Categories { get; set; }
		public DbSet<Entities.Project> Projects { get; set; }
		public DbSet<Entities.About> Abouts { get; set; }
		public DbSet<Entities.Banner> Banners { get; set; }
		public DbSet<Entities.Skill> Skillls { get; set; }
		public DbSet<Entities.UserMessage> UserMessages { get; set; }
		public DbSet<Entities.ContactInfo> ContactInfos { get; set; }
		public DbSet<Entities.Testimonial> Testimonials { get; set; }
		public DbSet<Entities.User> Users { get; set; }

		public DbSet<Entities.SocialMedia> SocialMedias { get; set; }
		public DbSet<Entities.UserLogin> UserLogins { get; set; }	


	}
}
