using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Collections;

namespace ErpSystem.HelperClass
{
    public static class CompanyHelper
    {
        private static ErpSystemContext _context = new ErpSystemContext();
        public static IEnumerable GetAllCompanies()
        {
            return _context.company_name
                .Include(c => c.company_field_of_work.specific_work_fields)
                .Select(c => new
                {
                   serialId = c.company_serial,
                   Name = c.company_name1,
                   fieldOfWork = c.company_field_of_work.specific_work_fields.specific_work_field
                }).ToList();
        }

        public static IEnumerable GetAllCompanies(int id)
        {
            return _context.company_name
                .Where(c => c.added_by == id)
                .Include(c => c.company_field_of_work.specific_work_fields)
                .Select(c => new
                {
                    Serial = c.company_serial,
                    Name = c.company_name1,
                    Field = c.company_field_of_work.specific_work_fields.specific_work_field
                }).ToList();

        }
        
        public static IEnumerable GetAllAddresses(int id)
        {
            return _context.company_address
                           .Where(c => c.added_by == id)
                           .Select(c => new { 
                              Name = c.company_name.company_name1,
                              Adress = c.address,
                              District = c.district.district1,
                              City = c.district.city1.city1
                           })
                           .ToList();

        }

        public static IEnumerable GetAllAddresses()
        {
            return _context.company_address
                           .Select(c => new {
                               Name = c.company_name.company_name1,
                               Adress = c.address,
                               District = c.district.district1,
                               City = c.district.city1.city1
                           })
                           .ToList();

        }

        public static IEnumerable GetAllTelphones(int id)
        {
            return _context.company_telephone
                           .Where(c => c.added_by == id)
                           .Select(c => new
                           {
                               Name = c.company_address.company_name.company_name1,
                               Telphone = c.telephone_number,
                               Adress = c.company_address.address

                           })
                           .ToList();
        }
        public static IEnumerable GetAllTelphones()
        {
            return _context.company_telephone
                           .Select(c => new
                           {
                               Name = c.company_address.company_name.company_name1,
                               Telphone = c.telephone_number,
                               Adress = c.company_address.address

                           })
                           .ToList();
        }
    }
}
