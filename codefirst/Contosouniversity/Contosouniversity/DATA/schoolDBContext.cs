using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
namespace Contosouniversity.DATA
{
//dbfirst
    public class schoolDBContext : DbContext
    {
        public schoolDBContext() : base("name=schoolDBContext")
        {
        }
 public System.Data.Entity.DbSet<Contosouniversity.Models.Student> Hastalars { get; set; }
    }
}
/*DB ile verileri ekranda gösterme işlemi*/
