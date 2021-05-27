using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebProject.Models;
using SalesWebProject.Models.Enums;

namespace SalesWebProject.Data
{
    public class SeedingService
    {
        private SalesWebProjectContext _context;

        public SeedingService(SalesWebProjectContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; //DB has been seeded
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");
            Department d5 = new Department(5, "Peppers");

            Seller s1 = new Seller(1, "Gustavo", "gustavo@okea.com", new DateTime(1988, 6, 25), 1.800, d1);
            Seller s2 = new Seller(2, "Vilmar", "vilmar@okea.com", new DateTime(2001, 2, 25), 1.800, d2);
            Seller s3 = new Seller(3, "Máx", "max@okea.com", new DateTime(1980, 7, 23), 2.800, d3);
            Seller s4 = new Seller(4, "Natan", "natan@okea.com", new DateTime(2002, 3, 21), 1.100, d4);
            Seller s5 = new Seller(5, "Zé", "ze@okea.com", new DateTime(1985, 2, 5), 1800.00, d5);
            Seller s6 = new Seller(6, "Iuri", "iuri@okea.com", new DateTime(1958, 4, 15), 1800.00, d1);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2021, 05, 27), 11.000, SaleStatus.Billed, s4);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2021, 05, 28), 4.000, SaleStatus.Billed, s1);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2021, 05, 28), 12.000, SaleStatus.Billed, s2);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2021, 05, 28), 3.000, SaleStatus.Billed, s3);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2021, 05, 28), 5.000, SaleStatus.Billed, s5);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2021, 05, 28), 4.000, SaleStatus.Billed, s6);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2021, 05, 29), 6.000, SaleStatus.Billed, s6);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2021, 05, 29), 5.000, SaleStatus.Billed, s4);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2021, 05, 29), 1.000, SaleStatus.Billed, s4);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2021, 05, 30), 4.000, SaleStatus.Billed, s2);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2021, 05, 30), 3.000, SaleStatus.Billed, s2);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2021, 05, 1), 7.000, SaleStatus.Billed, s1);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2021, 05, 1), 14.000, SaleStatus.Billed, s3);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2021, 05, 1), 5.000, SaleStatus.Billed, s3);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2021, 05, 2), 26.000, SaleStatus.Billed, s5);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2021, 05, 2), 3.000, SaleStatus.Billed, s5);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2021, 05, 3), 9.000, SaleStatus.Billed, s6);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2021, 05, 3), 10.000, SaleStatus.Billed, s4);

            _context.Department.AddRange(d1, d2, d3, d4, d5);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6,
                r7, r8, r9, r10, r11, r12,
                r13, r14, r15, r16, r17, r18
                );

            _context.SaveChanges();

        }









    }
}
