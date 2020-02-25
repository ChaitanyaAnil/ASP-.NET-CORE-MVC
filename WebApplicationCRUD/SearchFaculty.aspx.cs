using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationCRUD
{
    public partial class SearchFaculty : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            ADOlayer adl = new ADOlayer();
            int id = int.Parse(TextBox1.Text);
            var fac = adl.SearchFaculty(id);
            GridView1.DataSource = fac;
            GridView1.DataBind();

        }
    }
}