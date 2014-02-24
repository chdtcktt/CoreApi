using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiSvc.Areas.TrainingCatalog.ViewModels.Get
{
    public class GetCourseOptionsViewModel
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseNote { get; set; }
        public bool IsActive { get; set; }
    }
}