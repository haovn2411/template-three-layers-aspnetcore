using HaoVN.Teamplate_3_layers.Infrastructure.Data;
using HaoVN.Teamplate_3_layers.Infrastructure.Entities;
using HaoVN.Teamplate_3_layers.Infrastructure.Interfaces;
using Microsoft.Extensions.Logging;

namespace HaoVN.Teamplate_3_layers.Infrastructure.Repository
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(StudentContext context, ILogger logger) : base(context, logger)
        {
        }
    }
}