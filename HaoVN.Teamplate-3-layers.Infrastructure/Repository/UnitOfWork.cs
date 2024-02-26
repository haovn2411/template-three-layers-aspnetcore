using HaoVN.Teamplate_3_layers.Infrastructure.Data;
using HaoVN.Teamplate_3_layers.Infrastructure.Entities;
using HaoVN.Teamplate_3_layers.Infrastructure.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaoVN.Teamplate_3_layers.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StudentContext _context;
        private readonly ILogger _logger;
        public IStudentRepository Students { get; private set; }


        public UnitOfWork(StudentContext context, ILoggerFactory logger)
        {
            _context = context;
            _logger = logger.CreateLogger("logs");

            Students = new StudentRepository(_context, _logger);

        }

        public async Task<int> CompletedAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
