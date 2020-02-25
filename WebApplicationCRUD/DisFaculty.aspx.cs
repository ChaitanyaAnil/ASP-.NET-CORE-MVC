using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationCRUD
{
    public partial class DisFaculty : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



            if (!this.IsPostBack)
            {
                ADOlayer adl = new ADOlayer();
                var data = adl.getallFaculty();
                GridView1.DataSource = data;
                GridView1.DataBind();


            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}