using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiSvc.Models;

namespace WebApiSvc.Areas.TrainingCatalog.ViewModels
{
    public class GetStudentDetailsViewModel
    {
        public GetStudentDetailsViewModel()
        {
            CoursesTaking = new List<UserCourseDetail>();
            CoursesTeaching = new List<UserCourseDetail>();
        }
        public string StudentName { get; set; }
        public bool IsTeacher { get; set; }
        public List<UserCourseDetail> CoursesTaking { get; set; }
        public List<UserCourseDetail> CoursesTeaching { get; set; }

        
    }
}