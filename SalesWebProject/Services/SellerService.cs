using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebProject.Models;



namespace SalesWebProject.Services
{
    public class SellerService
    {
        private readonly SalesWebProjectContext _context;

        public SellerService(SalesWebProjectContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            
            _context.Add(obj);
            _context.SaveChanges();
        }




    }
}
