using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationFunctionHall
{
    public partial class DisplayHall : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!this.IsPostBack)
            {
                ADOLayer adl = new ADOLayer();
                var data = adl.getallrecords();
                GridView1.DataSource = data;
                GridView1.DataBind();


            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}