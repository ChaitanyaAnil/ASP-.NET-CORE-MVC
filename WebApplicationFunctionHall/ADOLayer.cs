using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplicationFunctionHall
{
    public class ADOLayer
    {

        DataSet ds = new DataSet();
        string constring = "";
        public ADOLayer()
        {
            constring = ConfigurationManager.ConnectionStrings["mystring"].ConnectionString;
        }
        public void InsertHall(string name, string loc, string mname)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();

                    cmd.Parameters.AddWithValue("@Fhname", name);
                    cmd.Parameters.AddWithValue("@Fhlocation", loc);
                    cmd.Parameters.AddWithValue("@Fhmanager", mname);
                    cmd.CommandText = "add_hall";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    sda.Update(ds);

                }
                catch (Exception e)
                {


                }
            }
        }


        public DataSet getallrecords()
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                string QuerySelect = "select * from FunctionHall";
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(QuerySelect, con);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    adp.Update(ds);
                }
                catch
                {

                }


                return ds;

            }

        }



        public DataSet SearchHall(int id)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                try
                {


                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_search_hall", con);
                    cmd.Parameters.AddWithValue("@Hallid", id);

                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                }
                catch
                {

                }
                return ds;

            }
        }
    }
}