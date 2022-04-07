using CleanArch.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace CleanArch.Infra.Data
{
	public class UniversityDbContext : DbContext
	{
		UniversityDbContext(DbContextOptions options) : base(options)	
		{

		}
		public DbSet<Course> Courses { get; set; }
	}
}//SAS2016
