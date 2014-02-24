using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSvc.Areas.TrainingCatalog.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        

        public virtual ICollection<Template> Templates { get; set; }        
        

    }
}