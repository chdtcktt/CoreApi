using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiSvc.Areas.TrainingCatalog.ViewModels.Get
{
    public class GetAddCoursesViewModel
    {
        public int PersonId { get; set; }
        public string SelectedPersonName { get; set; }
        public List<_CourseToAdd> Courses { get; set; }
    }
}