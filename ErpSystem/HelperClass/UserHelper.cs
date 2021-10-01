using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpSystem.HelperClass
{
    public static class UserHelper
    {
        private static ErpSystemContext _context = new ErpSystemContext();
        public static employees_info GetEmployeeEmail(string email)
        {
            var employee = _context.employees_business_emails.FirstOrDefault(emp => emp.email == email);

            
            return employee==null?null:employee.employees_info;
        }
        public static string GetEmployeePassword(int id)
        {
            var password = _context.employees_passwords.Find(id);
            return password==null?null:password.password;
        }
        public static void SignUp(employees_passwords newPassword)
        {
            _context.employees_passwords.Add(newPassword);
            _context.SaveChanges();
        }
    }
}
