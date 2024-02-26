using HaoVN.Teamplate_3_layers.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaoVN.Teamplate_3_layers.Infrastructure.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext()
        {
            
        }

        public StudentContext(DbContextOptions<StudentContext> opt) : base(opt)
        {

        }

        #region
        public DbSet<Student> students { get; set; }
        #endregion

    }
}
