using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Contosouniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string AD { get; set; }
        public string Soyad { get; set; }
        public DateTime Tarih { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}