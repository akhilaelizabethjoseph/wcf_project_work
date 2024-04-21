using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for cls1
/// </summary>
public class cls1
{
    SqlConnection con;
    SqlCommand cmd;
    public cls1()
    {
        con = new SqlConnection(@"server=HP\SQLEXPRESS;database=aspproject;Integrated Security=True");

    }
    public SqlDataReader fn_reader(string sql)
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
        cmd = new SqlCommand(sql, con);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        return dr;
    }
}