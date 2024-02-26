using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaoVN.Teamplate_3_layers.Infrastructure.Entities
{
    [Table("Student")]
    public class Student : Entity
    {
        public string name { get; set; }
        public int age { get; set; }
    }
}
