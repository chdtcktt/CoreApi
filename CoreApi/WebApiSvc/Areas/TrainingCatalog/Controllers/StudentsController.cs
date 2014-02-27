using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Filters;
using Newtonsoft.Json;
using WebApiSvc.Areas.TrainingCatalog.Models;
using WebApiSvc.Areas.TrainingCatalog.ViewModels;
using System.Data.Entity;

namespace WebApiSvc.Areas.TrainingCatalog.Controllers
{
    [AllowCrossSiteJsonAttribute]
    [EnableCors(origins: "http://thatcodeguy.net/", headers: "*", methods: "*")]
    public class StudentsController : ApiController
    {
        private DbTrainingContext db;

        public StudentsController()
        {
            db = new DbTrainingContext();
        }
       
         //GET api/students
        public IEnumerable<StudentListViewModel> GetAllStudents()
        {
            var vm = new List<StudentListViewModel>
                {
                    new StudentListViewModel {StudentId = 1, Name = "Jimmy McJimmers", CoursesCompleted = 3, TotalCourses = 6},
                    new StudentListViewModel {StudentId = 2, Name = "Rickey McRickerton", CoursesCompleted = 8, TotalCourses = 10},
                    new StudentListViewModel{ StudentId = 3, Name = "Jilly JoJohnson", CoursesCompleted = 10, TotalCourses = 10 }
                };


            return vm;
        }
 
        public GetStudentDetailsViewModel GetStudentDetails(int id)
        {
           
                var vm = new GetStudentDetailsViewModel
                {
                  
                    IsTeacher = true,


                    CoursesTaking = new List<UserCourseDetail>
                        {
                            new UserCourseDetail
                                {
                                    CourseCompleted = true,
                                    DateCourseCompleted = DateTime.Now.ToShortDateString(),
                                    Note = "Any program is only as good as it is useful.",
                                    Teacher = "Linus Torvalds",
                                    CourseTaking = "Linux Kernal"
                                },
                                new UserCourseDetail
                                    {
                                        CourseCompleted = false,
                                        DateCourseCompleted = DateTime.Now.ToShortDateString(),
                                        Note = "Simplicity is not the absence of clutter, that's a consequence of simplicity. Simplicity is somehow essentially describing the purpose and place of an object and product. The absence of clutter is just a clutter-free product. That's not simple.",
                                        Teacher = "Jony Ive",
                                        CourseTaking = "Objective C"
                                    },

                                    new UserCourseDetail
                                    {
                                        CourseCompleted = false,
                                        DateCourseCompleted = DateTime.Now.ToShortDateString(),
                                        Note= "The biggest risk is not taking any risk... In a world that changing really quickly, the only strategy that is guaranteed to fail is not taking risks.",
                                        Teacher="Mark Zuckerberg",
                                        CourseTaking="Social Networking"
                                    }
                        },
                    CoursesTeaching = new List<UserCourseDetail>
                        {
                            new UserCourseDetail
                                {
                                    CourseTeaching = "Underwater Basket Weaving",
                                    Note = "I am a teacher",
                                },
                                new UserCourseDetail
                                    {
                                        CourseTeaching = "Fly Fishin",
                                        Note = "Lets git ur fishin on cowboy!"
                                    }

                        }

                };

                if (id == 1)
                    vm.StudentName = "Jimmy McJimmers";
                if (id == 2)
                    vm.StudentName = "Rickey McRickerton";
                if (id == 3)
                    vm.StudentName = "Jilly JoJohnson";
                return vm;

         
            

                



        }

        // POST api/students
        [HttpPost]
        public string PostCourseDetailsStatus(CourseStatusList data)
        {
            return Convert.ToString(DateTime.Now.ToShortDateString());
        
          
        }

        // PUT api/students/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/students/5
        public void Delete(int id)
        {
        }





   
    }


    //public class AllowCrossSiteJsonAttribute : ActionFilterAttribute
    //{
    //    public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
    //    {
    //        if (actionExecutedContext.Response != null)
    //            actionExecutedContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");

    //        base.OnActionExecuted(actionExecutedContext);
    //    }
    //}
}
