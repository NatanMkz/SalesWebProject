using SalesWebProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebProject.Services
{
    public class DepartmentService
    {
        private readonly SalesWebProjectContext _context;

        public DepartmentService(SalesWebProjectContext context)
        {
            _context = context;
        }

        public async Task <List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }



    }
}
