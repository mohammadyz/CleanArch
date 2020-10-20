using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;

namespace CleanArch.Application.Services
{
    public class CourseServices : ICourseServices
    {
        private ICourseRepositores _courseRepositores;

        public CourseServices(ICourseRepositores courseRepositores)
        {
            _courseRepositores = courseRepositores;
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = _courseRepositores.GetCourses()
            };
        }
    }
}
