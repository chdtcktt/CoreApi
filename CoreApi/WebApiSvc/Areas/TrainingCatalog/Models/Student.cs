using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiSvc.Areas.TrainingCatalog.Models;

namespace WebApiSvc.Areas.TrainingCatalog.Models
{
    public class Student : Person
    {
        public virtual ICollection<CoursesTaking> CoursesTakings { get; set; }

    }
}