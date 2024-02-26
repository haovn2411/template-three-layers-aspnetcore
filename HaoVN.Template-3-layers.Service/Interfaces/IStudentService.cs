using HaoVN.Template_3_layers.Service.DTO.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaoVN.Template_3_layers.Service.Interfaces
{
    public interface IStudentService
    {
        public Task<bool> AddStudent(RequestStudentModel model);
    }
}
