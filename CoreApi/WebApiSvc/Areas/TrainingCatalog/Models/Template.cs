using System.Collections.Generic;
using WebApiSvc.Areas.TrainingCatalog.Models;

namespace WebApiSvc.Areas.TrainingCatalog.Models
{
    public class Template
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; }


    }
}