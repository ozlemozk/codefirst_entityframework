﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using Contosouniversity.Models;

namespace Contosouniversity.DATA
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        
            protected override void Seed(SchoolContext context)
            {
                var students = new List<Student>
            {
            new Student{AD="ÖZLEM",Soyad="ÖZKAYA",Tarih=DateTime.Parse("2000-01-17")},
            new Student{AD="Mert",Soyad="Albay",Tarih=DateTime.Parse("2002-09-01")},
            new Student{AD="Artemis",Soyad="Anadut",Tarih=DateTime.Parse("2003-09-01")},
            new Student{AD="Gamze",Soyad="Barduz",Tarih=DateTime.Parse("2002-09-01")},
            new Student{AD="Yağmur",Soyad="Leylak",Tarih=DateTime.Parse("2002-09-01")},
            new Student{AD="Pelin",Soyad="Yılmaz",Tarih=DateTime.Parse("2001-09-01")},
            new Student{AD="Leyla",Soyad="Norman",Tarih=DateTime.Parse("2003-09-01")},
            new Student{AD="Nami",Soyad="Olta",Tarih=DateTime.Parse("2005-09-01")}
            };

                students.ForEach(s => context.Students.Add(s));
                context.SaveChanges();
                var courses = new List<Course>
            {
            new Course{CourseID=1050,Title="Chemistry",Credits=3,},
            new Course{CourseID=4022,Title="Microeconomics",Credits=3,},
            new Course{CourseID=4041,Title="Macroeconomics",Credits=3,},
            new Course{CourseID=1045,Title="Calculus",Credits=4,},
            new Course{CourseID=3141,Title="Trigonometry",Credits=4,},
            new Course{CourseID=2021,Title="Composition",Credits=3,},
            new Course{CourseID=2042,Title="Literature",Credits=4,}
            };
                courses.ForEach(s => context.Courses.Add(s));
                context.SaveChanges();
                var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,CourseID=1050,Sınıf=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Sınıf=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Sınıf=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Sınıf=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Sınıf=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Sınıf=Grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050,},
            new Enrollment{StudentID=4,CourseID=4022,Sınıf=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Sınıf=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Sınıf=Grade.A},
            };
                enrollments.ForEach(s => context.Enrollments.Add(s));
                context.SaveChanges();
            }
        }
}

