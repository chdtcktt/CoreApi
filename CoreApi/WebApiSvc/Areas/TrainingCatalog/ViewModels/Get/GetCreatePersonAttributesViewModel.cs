using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiSvc.Areas.TrainingCatalog.ViewModels.Get
{
    public class GetCreatePersonAttributesViewModel
    {
        public List<_CreatePersonCourses> Courses { get; set; }
        public List<_CreatePersonTemplates> Templates { get; set; }
    }
}