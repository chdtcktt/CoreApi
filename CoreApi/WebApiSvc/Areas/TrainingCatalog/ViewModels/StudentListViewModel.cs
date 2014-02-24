using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiSvc.Areas.TrainingCatalog.ViewModels
{
    public class StudentListViewModel
    {
        public int StudentId { get; set; }
        public string Name { get; set; }        
        public int TotalCourses { get; set; }
        public int CoursesCompleted { get; set; }
    }
}