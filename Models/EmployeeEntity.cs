using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using WebApplication5.Models;
using System.Configuration;
namespace WebApplication5.Models
{
    public class EmployeeEntity
    {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
        public string InsertRecord(EmployeeDb employeeDb)
        {
            try
            { 
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
          
            cmd.CommandText = "insert into emp (Firstname,Lastname) values (@Firstname,@Lastname)";
            cmd.Parameters.AddWithValue("@Firstname", employeeDb.Firstname);
            cmd.Parameters.AddWithValue("@Lastname", employeeDb .Lastname);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return ("Record Inserted");
            }catch(Exception ex)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return (ex.Message.ToString());
            }
        }
    }
}