using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationCRUD
{
    public partial class FindFaculty : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ADOlayer adl = new ADOlayer();
            int id = int.Parse(TextBox1.Text);
            var stu = adl.SearchFaculty(id);
            GridView1.DataSource = stu;
            GridView1.DataBind();
        }
    }
}