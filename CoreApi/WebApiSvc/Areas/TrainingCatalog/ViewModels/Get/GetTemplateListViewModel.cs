using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiSvc.Areas.TrainingCatalog.ViewModels;

namespace WebApiSvc.Areas.TrainingCatalog.ViewModels.Get
{
    public class GetTemplateListViewModel
    {
        public List<CourseTemplateList> TemplateLists { get; set; }
    }
}