using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiSvc.Areas.TrainingCatalog.ViewModels.Get
{
    public class GetPersonNamesViewModel
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
    }
}