using System;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace Employee.DA
{
    public class Data
    {
        public string strConnectionString = "Server=JIOSANIHP;Database=EmployeeReg;Trusted_Connection=true;";

        public bool SaveSeniorEmployee(Empolyee empolyee)
        {

            try
            {
                using (IDbConnection con = new SqlConnection(strConnectionString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    DynamicParameters parameters = new DynamicParameters();

                    parameters.Add("@EmployeeName", empolyee.EmployeeName);
                    parameters.Add("@Role", empolyee.Role);
                    parameters.Add("@Age", empolyee.Age);

                    //int rows= con.Execute("SaveSeniorEmployee",)

                    SqlMapper.Execute(con, "SaveSeniorEmployee", parameters, null, null, CommandType.StoredProcedure);
                    return true;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
            
        }

        public bool SaveJuniorEmployee(Empolyee empolyee)
        {
            try
            {
                using (IDbConnection con = new SqlConnection(strConnectionString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    DynamicParameters parameters = new DynamicParameters();

                    parameters.Add("@EmployeeName", empolyee.EmployeeName);
                    parameters.Add("@Role", empolyee.Role);
                    parameters.Add("@Age", empolyee.Age);

                    //int rows= con.Execute("SaveSeniorEmployee",)

                    SqlMapper.Execute(con, "SaveJuniorEmployee", parameters, null, null, CommandType.StoredProcedure);
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }
        

}
        
}
public class Empolyee
{
    public string EmployeeName { get; set; }
    public string Role { get; set; }
    public int Age { get; set; }
}

