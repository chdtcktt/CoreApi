using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiSvc.Areas.TrainingCatalog.Models;

namespace WebApiSvc.Areas.TrainingCatalog.Models
{
    public class Teacher :Person
    {
        public virtual ICollection<CoursesTeaching> CoursesTeachings { get; set; }

    }
}