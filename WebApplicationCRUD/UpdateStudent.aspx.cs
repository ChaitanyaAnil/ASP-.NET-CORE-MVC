using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationCRUD
{
    public partial class UpdateStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ADOlayer adl = new ADOlayer();
            int id = int.Parse(TextBox1.Text);
            string name = TextBox2.Text;
            adl.UpdateStudent(id, name);

        }
    }
}