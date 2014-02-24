using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    [EnableCors(origins: "http://localhost:41029", headers: "*", methods: "*")]
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
                    new StudentListViewModel {StudentId = 2, Name = "Rickey McRickerton", CoursesCompleted = 8, TotalCourses = 10}
                };


            return vm;
        }
 
        public GetStudentDetailsViewModel GetStudentDetails(int id)
        {

            var vm = new GetStudentDetailsViewModel
                {
                    StudentName = "THIS PERSON",
                    IsTeacher = true,


                    CoursesTaking = new List<UserCourseDetail>
                        {
                            new UserCourseDetail
                                {
                                    CourseCompleted = true,
                                    DateCourseCompleted = DateTime.Now.ToShortDateString(),
                                    Note = "learn to Mop",
                                    Teacher = "Chad",
                                    CourseTaking = "Stuff"
                                },
                                new UserCourseDetail
                                    {
                                        CourseCompleted = false,
                                        DateCourseCompleted = DateTime.Now.ToShortDateString(),
                                        Note = "We will take you through the basics of Networking",
                                        Teacher = "Ur Mama",
                                        CourseTaking = "Networking 101"


                                    }
                        },
                    CoursesTeaching = new List<UserCourseDetail>
                        {
                            new UserCourseDetail
                                {
                                    CourseTeaching = "Teach Stuff",
                                    Note = "I am a teacher",
                                },
                                new UserCourseDetail
                                    {
                                        CourseTeaching = "Fly Fishin",
                                        Note = "Lets git ur fishin on cowboy!"
                                    }

                        }

                };

                


            return vm;

        }

        // POST api/students
        [HttpPost]
        public string PostCourseDetailsStatus(CourseStatusList data)
        {
          
            var studentQuery = db.Students.Find(data.StudentId);
            db.Entry(studentQuery)
             .Collection(c => c.CoursesTakings)
             .Query()
             .Load();
            
            DateTime dateTime = DateTime.Now;
            foreach (var item in studentQuery.CoursesTakings.Where(x=>x.CourseId == data.CourseId))
            {
                item.DateComplete = dateTime;


                if (item.IsComplete == false)
                    item.IsComplete = true;
                else
                {
                    item.IsComplete = false;
                }
            }


            db.SaveChanges();
          
            return dateTime.ToShortDateString();
        }

        // PUT api/students/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/students/5
        public void Delete(int id)
        {
        }





        public class AllowCrossSiteJsonAttribute : ActionFilterAttribute
        {
            public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
            {
                if (actionExecutedContext.Response != null)
                    actionExecutedContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");

                base.OnActionExecuted(actionExecutedContext);
            }
        }
    }
}
