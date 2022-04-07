using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repository
{
	public class CourseRepository : ICourseRepository
	{
		private UniversityDbContext _context;


		public CourseRepository(UniversityDbContext context)
		{
			 _context = context;
		}
		public IEnumerable<Course> GetCourses 
		 {
			get => throw new NotImplementedException(); set => throw new NotImplementedException(); 
		}
	}
}
