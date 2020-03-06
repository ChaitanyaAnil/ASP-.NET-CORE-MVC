using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationFunctionHall
{
    public partial class InsertFhall : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ADOLayer al = new ADOLayer();
            string name = TextBox1.Text;
            string loc = TextBox2.Text;
            string managername = TextBox3.Text;
            al.InsertHall(name, loc, managername);

        }
    }
}