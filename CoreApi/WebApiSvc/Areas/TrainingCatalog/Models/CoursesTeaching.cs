using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiSvc.Areas.TrainingCatalog.Models;

namespace WebApiSvc.Areas.TrainingCatalog.Models
{
    public class CoursesTeaching
    {
        public int CourseId { get; set; }
        public int TeacherId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}