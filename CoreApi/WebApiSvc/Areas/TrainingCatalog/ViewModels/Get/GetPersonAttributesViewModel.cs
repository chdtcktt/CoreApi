using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiSvc.Areas.TrainingCatalog.ViewModels.Get
{
    public class GetPersonAttributesViewModel
    {
        public bool IsActive { get; set; }
        public List<_PersonAttributesCourses> Courses { get; set; }
    }
}