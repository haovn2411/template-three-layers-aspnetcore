using AutoMapper;
using HaoVN.Teamplate_3_layers.Infrastructure.Entities;
using HaoVN.Teamplate_3_layers.Infrastructure.Interfaces;
using HaoVN.Template_3_layers.Service.DTO.Student;
using HaoVN.Template_3_layers.Service.Interfaces;

namespace HaoVN.Template_3_layers.Service.Service
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public StudentService(
            IUnitOfWork unitOfWork,
            IMapper mapper
            )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<bool> AddStudent(RequestStudentModel model)
        {
            var newStudent = _mapper.Map<Student>(model);

            _unitOfWork.Students.Add(newStudent);
            _unitOfWork.CompletedAsync();
            return true;
        }
    }
}