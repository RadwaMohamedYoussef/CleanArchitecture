using CleanArch.Appliction.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Appliction.Interfaces
{
   public interface ICourseService
    {
        IEquatable<CourseViewModel> GetCourses(); 
    }
}
