using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Collections;

namespace ErpSystem.HelperClass
{
    public static class ContactHelper
    {
        private static ErpSystemContext _context = new ErpSystemContext();

        public static List<contact_person_info> GetAllContacts()
        {
            return _context.contact_person_info
                           .ToList();
        }
        public static List<contact_person_info> GetAllContacts(int id)
        {
            return _context.contact_person_info
                           .Where(c=>c.sales_person_id==id)
                           .ToList();
        }
        public static IEnumerable GetContactMobils(contact_person_info contactPersonInfo)
        {
            return _context.contact_person_mobile
                           .Where(c => c.contact_id == contactPersonInfo.contact_id &&
                                     c.branch_serial == contactPersonInfo.branch_serial &&
                                     c.sales_person_id == contactPersonInfo.sales_person_id)
                           .Select(c => new { Mobile = c.mobile })
                           .ToList();
            
        }
    }
}
