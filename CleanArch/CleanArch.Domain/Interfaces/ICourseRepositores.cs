using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Domain.Model;

namespace CleanArch.Domain.Interfaces
{
    public interface ICourseRepositores
    {
        IEnumerable<Course> GetCourse();
    }
}
