using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiSvc.Areas.TrainingCatalog.ViewModels
{
    public class UserCourseDetail
    {
        public int CourseTakingId { get; set; }
        public int CourseTeachingId { get; set; }
        public string CourseTaking { get; set; }
        public string CourseTeaching { get; set; }
        public string Teacher { get; set; }
        public string Note { get; set; }
        public bool CourseCompleted { get; set; }
        public string DateCourseCompleted { get; set; }
    }
}