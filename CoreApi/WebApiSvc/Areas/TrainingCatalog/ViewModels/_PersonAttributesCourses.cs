using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiSvc.Areas.TrainingCatalog.ViewModels
{
    public class _PersonAttributesCourses
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public bool IsTeaching { get; set; }
        public bool IsTaking { get; set; }
    }
}