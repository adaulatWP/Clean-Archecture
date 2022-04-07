using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
	public class CourseService : ICourseService
	{
		private ICourseRepository _icourseRepository;

		public CourseService(ICourseRepository icourseRepository)
		{
			 _icourseRepository = icourseRepository;
		}
		public IEnumerable<CourseViewModel> GetCourses()
		{
			throw new NotImplementedException();
		}
	}
}
