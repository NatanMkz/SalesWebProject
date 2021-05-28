using SalesWebProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebProject.Services
{
    public class DepartmentService
    {
        private readonly SalesWebProjectContext _context;

        public DepartmentService(SalesWebProjectContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }



    }
}
