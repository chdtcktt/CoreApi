using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiSvc.Areas.TrainingCatalog.Models;

namespace WebApiSvc.Areas.TrainingCatalog.Models
{
    public class CoursesTaking
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }

        public bool IsComplete { get; set; }
        public DateTime DateComplete { get; set; }

    }
}