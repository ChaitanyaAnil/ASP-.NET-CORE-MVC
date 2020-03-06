using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplicationMusic
{
    public class ADOLayer
    {

        DataSet ds = new DataSet();
        string constring = "";
        public ADOLayer()
        {
            constring = ConfigurationManager.ConnectionStrings["mystring"].ConnectionString;
        }
        public void InsertAlbum(string name, DateTime date)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();

                    cmd.Parameters.AddWithValue("@AlbumName", name);
                    cmd.Parameters.AddWithValue("@ReleaseDate", date);
                  
                    cmd.CommandText = "add_album";
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
                string QuerySelect = "select * from Album";
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

    }
}