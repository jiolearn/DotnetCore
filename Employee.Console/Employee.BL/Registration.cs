using System;
using Employee.DA;

namespace Employee.BL
{
    public class Registration
    {
         Data da = new Data();

        public bool SaveEmployee(string EmployeeName, string Role, int Age)
        {
            Empolyee empolyee = new Empolyee();

            empolyee.EmployeeName = EmployeeName;
            empolyee.Role = Role;
            empolyee.Age = Age;

            if (Age>40)
            {
                return da.SaveSeniorEmployee(empolyee);
            }
            else
            {
                return da.SaveJuniorEmployee(empolyee);
            }
            
        }
    }
}
