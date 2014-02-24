using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiSvc.Areas.TrainingCatalog.ViewModels
{
    public class _CourseToAdd
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public bool IsSelected { get; set; }
        public bool IsVisible { get; set; }
    }
}