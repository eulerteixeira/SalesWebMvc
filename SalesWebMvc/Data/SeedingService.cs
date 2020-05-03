using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;
        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if (_context.Departament.Any() ||
                _context.Sellers.Any() ||
                _context.SalesRecord.Any())
            {
                return; //banco ja foi populado
            }

            Departament d1 = new Departament(1, "Computers");
            Departament d2 = new Departament(2, "Electronics");
            Departament d3 = new Departament(3, "Fashion");
            Departament d4 = new Departament(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 100.00, d1);
            Seller s2 = new Seller(2, "Maria Brown", "maria@gmail.com", new DateTime(1990, 4, 21), 200.00, d2);
            Seller s3 = new Seller(3, "Angela Brown", "bob@gmail.com", new DateTime(1993, 4, 21), 300.00, d3);
            Seller s4 = new Seller(4, "Karl Brown", "bob@gmail.com", new DateTime(1994, 4, 21), 400.00, d4);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 9, 25), 11.000, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 9, 20), 10.000, SaleStatus.Billed, s2);

            _context.Departament.AddRange(d1, d2, d3, d4);
            _context.Sellers.AddRange(s1, s2, s3, s4);
            _context.SalesRecord.AddRange(r1, r2);
            _context.SaveChanges();
        }
    }
}
