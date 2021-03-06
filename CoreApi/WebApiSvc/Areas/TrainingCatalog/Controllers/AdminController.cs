﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Filters;
using WebApiSvc.Areas.TrainingCatalog.Controllers;
using WebApiSvc.Areas.TrainingCatalog.ViewModels;
using WebApiSvc.Areas.TrainingCatalog.ViewModels.Get;
using WebApiSvc.Models;
using WebApiSvc.ViewModels.Admin.EditTemplates;
using WebApiSvc.ViewModels.Admin.EditUser;

namespace WebApiSvc.Areas.TrainingCatalog.Controllers
{
    [AllowCrossSiteJsonAttribute]
    [EnableCors(origins: "http://thatcodeguy.net/", headers: "*", methods: "*")]
    public class AdminController : ApiController
    {
        #region Get EditUser

        // GET api/admin
        public IEnumerable<GetPersonNamesViewModel> GetPersonList()
        {
            var vm = new List<GetPersonNamesViewModel>
                {
                    new GetPersonNamesViewModel
                        {
                            PersonId = 1,
                            PersonName = "Jimmy McJimmers"
                        },
                    new GetPersonNamesViewModel
                        {
                            PersonId = 2,
                            PersonName = "Rickey McRickerton"
                        },
                        new GetPersonNamesViewModel
                        {
                            PersonId = 3,
                            PersonName = "Jilly JoJohnson"
                        }

                };

            return vm;
        }

        public GetPersonAttributesViewModel GetPersonAttributes(int id)
        {
            if (id == 1)
            {
                var vm = new GetPersonAttributesViewModel
                {
                    IsActive = true,
                    Courses = new List<_PersonAttributesCourses>
                            {
                                new _PersonAttributesCourses
                                    {
                                        CourseName="Linux Kernal",
                                        CourseId = 1,
                                        IsTaking = true,
                                        IsTeaching = false
                                    },
                                new _PersonAttributesCourses
                                    {
                                        CourseName="Objective C",
                                        CourseId = 2,
                                        IsTaking = false,
                                        IsTeaching = true
                                    },
                                new _PersonAttributesCourses
                                    {
                                        CourseName="Social Networking",
                                        CourseId = 3,
                                        IsTeaching = true,
                                        IsTaking = false
                                    },
                            
                            }

                };
                return vm;
            }

            if (id == 2)
            {
                var vm = new GetPersonAttributesViewModel
                {
                    IsActive = true,
                    Courses = new List<_PersonAttributesCourses>
                            {
                                new _PersonAttributesCourses
                                    {
                                        CourseName="Mopping",
                                        CourseId = 1,
                                        IsTaking = true,
                                        IsTeaching = true
                                    },
                                new _PersonAttributesCourses
                                    {
                                        CourseName="Fishin",
                                        CourseId = 2,
                                        IsTaking = true,
                                        IsTeaching = true
                                    },
                                new _PersonAttributesCourses
                                    {
                                        CourseName="Random Course Title",
                                        CourseId = 3,
                                        IsTeaching = false,
                                        IsTaking = false
                                    },
                            
                            }

                };

                return vm;
            }
            else
            {
                var vm = new GetPersonAttributesViewModel
                {
                    IsActive = true,
                    Courses = new List<_PersonAttributesCourses>
                            {
                                new _PersonAttributesCourses
                                    {
                                        CourseName="Waffle Cooking ",
                                        CourseId = 1,
                                        IsTaking = true,
                                        IsTeaching = true
                                    },
                                new _PersonAttributesCourses
                                    {
                                        CourseName="How to annoy your wife",
                                        CourseId = 2,
                                        IsTaking = true,
                                        IsTeaching = true
                                    },
                                new _PersonAttributesCourses
                                    {
                                        CourseName="Other Class",
                                        CourseId = 3,
                                        IsTeaching = false,
                                        IsTaking = false
                                    },
                            
                            }

                };

                return vm;
            }
        }

   
        

        /// <summary>
        /// this method will return only what the current user is not taking or teaching
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public GetAddCoursesViewModel GetAddCourses(int id)
        {

            if (id == 1)
            {
                var vm = new GetAddCoursesViewModel
                {
                    PersonId = 1,
                    SelectedPersonName = "Chad",
                    Courses = new List<_CourseToAdd>
                        {
                            new _CourseToAdd
                                {
                                    CourseId = 5,
                                    CourseName = "New Course 5",
                                    IsSelected = false
                                },
                                new _CourseToAdd
                                    {
                                        CourseId = 6,
                                        CourseName = "New Course 6",
                                        IsSelected = false
                                    },
                                    new _CourseToAdd
                                        {
                                            
                                            CourseId = 7,
                                            CourseName = "New Course 7",
                                            IsSelected = false
                                        }    
                        }
                };
                return vm;
            }
            else
            {
                var vm = new GetAddCoursesViewModel
                {
                    PersonId = 2,
                    SelectedPersonName = "Mike",
                    Courses = new List<_CourseToAdd>
                        {
                            new _CourseToAdd
                                {
                                    CourseId = 5,
                                    CourseName = "New Course 5",
                                    IsSelected = false
                                },
                                new _CourseToAdd
                                    {
                                        CourseId = 6,
                                        CourseName = "New Course 6",
                                        IsSelected = false
                                    },
                                    new _CourseToAdd
                                        {
                                            
                                            CourseId = 7,
                                            CourseName = "New Course 7",
                                            IsSelected = false
                                        }    
                        }
                };
                return vm;
            }


        }

        public GetCreatePersonAttributesViewModel GetCreatePersonAttributes()
        {

            var vm = new GetCreatePersonAttributesViewModel
                {
                    Courses = new List<_CreatePersonCourses>
                        {
                            new _CreatePersonCourses {CourseId = 1, CourseName = "Math"},
                            new _CreatePersonCourses {CourseId = 2, CourseName = "Science"},
                            new _CreatePersonCourses {CourseId = 3, CourseName = "English"},
                            new _CreatePersonCourses {CourseId = 4, CourseName = "PE"}
                        },

                    Templates = new List<_CreatePersonTemplates>
                        {
                            new _CreatePersonTemplates {TemplateId = 1, TemplateName = "Template1"},
                            new _CreatePersonTemplates {TemplateId = 2, TemplateName = "Template2"}
                        }
                };

            return vm;
        }

        public GetTemplateCoursesViewModel GetTemplateCourses(int id)
        {
            if (id == 1)
            {
                var vm = new GetTemplateCoursesViewModel
                    {
                        CoursesTaking = new List<string> { "1", "3", "2" },
                        CoursesTeaching = new List<string> { "2", "3", "4" }
                    };



                return vm;
            }
            else
            {
                var vm = new GetTemplateCoursesViewModel
                    {
                        CoursesTaking = new List<string> { "1", "2" },
                        CoursesTeaching = new List<string> { "3", "4" }
                    };

                return vm;
            }

        }

        #endregion

        #region GetEditCourse

        //Get EditCourse
        public IEnumerable<GetCourseOptionsViewModel> GetCourseOptions()
        {
            var vm = new List<GetCourseOptionsViewModel>
                {
                    new GetCourseOptionsViewModel
                        {
                            CourseId = 1,
                            CourseName = "Linux Kernal",
                            CourseNote = "Any program is only as good as it is useful.",
                            IsActive = true
                        },
                    new GetCourseOptionsViewModel
                        {
                            CourseId = 2,
                            CourseName = "Objective C",
                            CourseNote = "Simplicity is not the absence of clutter, that's a consequence of simplicity. Simplicity is somehow essentially describing the purpose and place of an object and product. The absence of clutter is just a clutter-free product. That's not simple.",
                            IsActive = true

                        },
                    new GetCourseOptionsViewModel
                        {
                            CourseId = 3,
                            CourseName = "Social Networking",
                            CourseNote = "The biggest risk is not taking any risk... In a world that changing really quickly, the only strategy that is guaranteed to fail is not taking risks.",
                            IsActive = false
                        }
               
                };

            return vm;

        }

        #endregion

        #region GetEditTemplate

        public GetTemplateListViewModel GetTemplateList()
        {
            var vm = new GetTemplateListViewModel
                {
                    TemplateLists = new List<CourseTemplateList>
                        {
                            new CourseTemplateList {CourseName = "CourseTemp1", CourseTemplateId = 1},
                            new CourseTemplateList {CourseName = "CourseTemp2", CourseTemplateId = 2},
                            new CourseTemplateList {CourseName = "CourseTemp3", CourseTemplateId = 3}
                        }

                };
            return vm;
        }

        public GetTemplateAttributesViewModel GetTemplateAttributes(int id)
        {
            if (id == 1)
            {
                var vm = new GetTemplateAttributesViewModel
                    {
                        Courses = new List<TemplateCourse>
                            {
                                new TemplateCourse
                                    {
                                        CourseId = 1,
                                        CourseName = "Math",
                                        IsTaking = false,
                                        IsTeaching = true
                                    },
                                new TemplateCourse
                                    {
                                        CourseId = 2,
                                        CourseName = "Science",
                                        IsTaking = true,
                                        IsTeaching = true
                                    },
                                new TemplateCourse
                                    {
                                        CourseId = 3,
                                        CourseName = "English",
                                        IsTaking = false,
                                        IsTeaching = false
                                    },
                                new TemplateCourse
                                    {
                                        CourseId = 4,
                                        CourseName = "PE",
                                        IsTaking = true,
                                        IsTeaching = false
                                    }
                            }

                    };
                return vm;

            }
            else
            {
                var vm = new GetTemplateAttributesViewModel
                {
                    Courses = new List<TemplateCourse>
                            {
                                new TemplateCourse
                                    {
                                        CourseId = 1,
                                        CourseName = "Math",
                                        IsTaking = true,
                                        IsTeaching = false
                                    },
                                new TemplateCourse
                                    {
                                        CourseId = 2,
                                        CourseName = "Science",
                                        IsTaking = false,
                                        IsTeaching = false
                                    },
                                new TemplateCourse
                                    {
                                        CourseId = 3,
                                        CourseName = "English",
                                        IsTaking = false,
                                        IsTeaching = true
                                    },
                                new TemplateCourse
                                    {
                                        CourseId = 4,
                                        CourseName = "PE",
                                        IsTaking = true,
                                        IsTeaching = true
                                    }
                            }

                };
                return vm;
            }
        }

        public GetAddNewTemplateViewModel GetAddNewTemplate()
        {
            var vm = new GetAddNewTemplateViewModel
                {
                    AddTemplateCourses = new List<AddTemplateCourse>
                        {
                            new AddTemplateCourse {CourseId = "1", CourseName = "Math"},
                            new AddTemplateCourse {CourseId = "2", CourseName = "Science"},
                            new AddTemplateCourse {CourseId = "3", CourseName = "English"},
                            new AddTemplateCourse {CourseId = "4", CourseName = "PE"}
                        }
                };
            return vm;
        }





        #endregion



        #region POST EditUser

        // POST api/admin
        public void PostPersonAttributes([FromBody] string postData)
        {
            Debug.WriteLine(postData);
        }

        public void PostNewPersonAttributes([FromBody] string postData)
        {
            Debug.WriteLine(postData);
        } 
        
        public void PostAddedCourses([FromBody] string postData)
        {
            Debug.WriteLine(postData);
        }

        #endregion

        #region POST EditCourse

        public void PostCourseOptions([FromBody] string postData)
        {
            Debug.WriteLine(postData);
        }

        public void PostNewCourseOptions([FromBody] string postData)
        {
            Debug.WriteLine(postData);
        }

        #endregion

        #region Post EditTemplate

        public void PostNewTemplate([FromBody] string postData)
        {
            Debug.WriteLine(postData);
        }

        #endregion



        #region PutEditUser
        public void PutRemoveCourseFromUser([FromBody] string postData)
        {
            Debug.WriteLine(postData);

        }



        #endregion

        #region PutEditTemplate

        public void PutRemoveCourseFromTemplate([FromBody] string postData)
        {
            Debug.WriteLine(postData);

        }

        #endregion



        #region DeleteEditUser
        public void DeleteUser([FromBody] string postData)
        {
            Debug.WriteLine(postData);

        }

        #endregion

        #region DeleteEditCourse
        public void DeleteCourse([FromBody] string postData)
        {
            Debug.WriteLine(postData);

        }


        #endregion

        #region DeleteEditTemplate

        public void DeleteTemplate([FromBody] string postData)
        {
            Debug.WriteLine(postData);

        }

        #endregion


   


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
