using AutoMapper;
using HaoVN.Teamplate_3_layers.Infrastructure.Entities;
using HaoVN.Template_3_layers.Service.DTO.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaoVN.Template_3_layers.Service.AutoMapperProfile
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //Student
            CreateMap<Student, RequestStudentModel>().ReverseMap();
        }
    }
}
