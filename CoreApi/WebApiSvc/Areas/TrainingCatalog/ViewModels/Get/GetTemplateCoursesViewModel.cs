using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiSvc.ViewModels.Admin.EditUser
{
    public class GetTemplateCoursesViewModel
    {
        public List<string> CoursesTaking { get; set; }
        public List<string> CoursesTeaching { get; set; }

    }
}