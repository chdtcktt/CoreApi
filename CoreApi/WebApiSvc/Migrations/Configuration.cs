using System.Collections.Generic;
using WebApiSvc.Models;

namespace WebApiSvc.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApiSvc.Areas.TrainingCatalog.Models.DbTrainingContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebApiSvc.Areas.TrainingCatalog.Models.DbTrainingContext context)
        {
           




            ////----------------Course/Template
            //var course1 = new Course { Name = "First Course", Notes = "FC Note", Templates = new List<Template>() };
            //var course2 = new Course { Name = "Second Course", Notes = "Sec Note", Templates = new List<Template>() };
            //var template1 = new Template { Name = "Template1" };
            //var template2 = new Template { Name = "Template2" };
            //course1.Templates.Add(template1);
            //course1.Templates.Add(template2);
            //course2.Templates.Add(template2);
            //course2.Templates.Add(template2);
            //context.Courses.Add(course1);
            //context.Courses.Add(course2);
            //context.Templates.Add(template1);
            //context.Templates.Add(template2);
            //base.Seed(context);
            //context.SaveChanges();
            ////-------------Teachers/Students
            //var teacher1 = new Teacher { Name = "JoJo", IsActive = true, CoursesTeachings = new List<CoursesTeaching>() };
            //var teacher2 = new Teacher { Name = "Jon", IsActive = true, CoursesTeachings = new List<CoursesTeaching>() };
            //var student1 = new Student { Name = "Jimmy", IsActive = true, CoursesTakings = new List<CoursesTaking>() };
            //var student2 = new Student { Name = "Jody", IsActive = true, CoursesTakings = new List<CoursesTaking>() };
            //var courseTaking1 = new CoursesTaking
            //{
            //    Course = course1,
            //    Student = student1,
            //    DateComplete = DateTime.Now,
            //    IsComplete = false
            //};
            //var courseTaking2 = new CoursesTaking
            //{
            //    Course = course2,
            //    Student = student2,
            //    DateComplete = DateTime.Now,
            //    IsComplete = false
            //};
            //student1.CoursesTakings.Add(courseTaking1);
            //student1.CoursesTakings.Add(courseTaking2);
            //student2.CoursesTakings.Add(courseTaking1);
            //student2.CoursesTakings.Add(courseTaking2);
            //context.Students.Add(student1);
            //context.Students.Add(student2);
            //base.Seed(context);
            //context.SaveChanges();
            //var courseTeaching1 = new CoursesTeaching
            //{
            //    Course = course1,
            //    Teacher = teacher1,
            //};
            //var courseTeaching2 = new CoursesTeaching
            //{
            //    Course = course2,
            //    Teacher = teacher2,
            //};
            //teacher1.CoursesTeachings.Add(courseTeaching1);
            //teacher1.CoursesTeachings.Add(courseTeaching2);
            //teacher2.CoursesTeachings.Add(courseTeaching2);
            //teacher2.CoursesTeachings.Add(courseTeaching1);
            //context.Teachers.Add(teacher1);
            //context.Teachers.Add(teacher2);
            //base.Seed(context);
            //context.SaveChanges();
        }
    }
}
