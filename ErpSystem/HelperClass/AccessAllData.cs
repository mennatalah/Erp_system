using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpSystem.HelperClass
{
    public static class AccessAllData
    {
        public static string Department = "Marketing & Sales";
        public static List<string> Position = new List<string>() 
        { 
         "Team Lead",
         "Department Manager"
        };

        public static bool CanAccessAllData(employees_info _user)
        {
            ErpSystemContext _context=new ErpSystemContext();
            var employeeDepartment = _context.departments_type
                                             .Where(d => d.id == _user.employee_department)
                                             .Select(d => d.department).FirstOrDefault();
            if (employeeDepartment != null && employeeDepartment.Trim() == AccessAllData.Department)
            {
                var employeePosition = _context.positions_type
                    .Where(p => p.id == _user.employee_position)
                    .Select(p => p.position).FirstOrDefault();
                if (AccessAllData.Position.Contains(employeePosition))
                    return true;

            }
            return false;
        }

        

    }
}
