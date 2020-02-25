using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplicationCRUD
{
    public class ADOlayer
    {
        DataSet ds = new DataSet();
        string constring = "";
        public ADOlayer()
        {
            constring = ConfigurationManager.ConnectionStrings["mystring"].ConnectionString;
        }
        public void InsertStudent(string name,string email,string address)
        {
            using(SqlConnection con =new SqlConnection(constring))
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                   // cmd = new SqlCommand("add_student",con);

                    cmd.Parameters.AddWithValue("@Student_Name", name);
                    cmd.Parameters.AddWithValue("@Student_Email", email);
                    cmd.Parameters.AddWithValue("@Student_Address", address);
                    cmd.CommandText = "add_student";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    sda.Update(ds);
                    
                }
                catch(Exception e)
                {
                   
                }
            }
        }
        public void InsertCourse(string name,decimal fee)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
   

                    cmd.Parameters.AddWithValue("@Course_Name", name);
                    cmd.Parameters.AddWithValue("@Course_Fee", fee);
                   
                    cmd.CommandText = "sp_insert_course";
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
        public void InsertFaculty(string name, string  desg)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
               

                    cmd.Parameters.AddWithValue("@Faculty_Name", name);
                    cmd.Parameters.AddWithValue("@Faculty_Designation", desg);

                    cmd.CommandText = "sp_add_faculty";
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
                string QuerySelect = "select * from Student";
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
        public DataSet getallCourses()
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                string QuerySelect = "select * from Course";
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
        public DataSet getallFaculty()
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                string QuerySelect = "select * from Faculty";
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
        public void UpdateStudent(int id,string name)
           {
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_update_stu", con);
        cmd.Parameters.AddWithValue("@Student_id", id);
                cmd.Parameters.AddWithValue("@Student_Name", name);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
        sda.Fill(ds);
                

            }
        }
        public void UpdateCourse(int id, string name)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_update_cou", con);
                cmd.Parameters.AddWithValue("@Course_id", id);
                cmd.Parameters.AddWithValue("@Course_name", name);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);


            }
        }
        public void UpdateFaculty(int id, string name)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_update_fac", con);
                cmd.Parameters.AddWithValue("@Faculty_id", id);
                cmd.Parameters.AddWithValue("@Faculty_Name", name);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);


            }
        }

        public DataSet SearchStudent(int id)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                try
                {


                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_search_stu", con);
                    cmd.Parameters.AddWithValue("@Student_id", id);

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


        public DataSet SearchCourse(int id)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                try
                {


                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_search_cou", con);
                    cmd.Parameters.AddWithValue("@Course_id", id);

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

        public DataSet SearchFaculty(int id)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                try
                {


                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_search_fac", con);
                    cmd.Parameters.AddWithValue("@Faculty_id", id);

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

        public DataSet DeleteStudent(int id)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                try
                {


                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_delete_stu", con);
                    cmd.Parameters.AddWithValue("@Student_id", id);

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
        public DataSet DeleteCourse(int id)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                try
                {


                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_delete_cou", con);
                    cmd.Parameters.AddWithValue("@Course_id", id);

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

        public DataSet DeleteFaculty(int id)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                try
                {


                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_delete_fac", con);
                    cmd.Parameters.AddWithValue("@Faculty_id", id);

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