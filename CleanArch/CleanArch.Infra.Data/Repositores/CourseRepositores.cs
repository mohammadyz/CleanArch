using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Model;
using CleanArch.Infra.Data.Context;

namespace CleanArch.Infra.Data.Repositores
{
    public class CourseRepositores : ICourseRepositores
    {
        private CleanArchDbContext db;

        public CourseRepositores(CleanArchDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Course> GetCourse()
        {
            return db.Courses.ToList();
        }
    }
}
