using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationMusic
{
    public partial class MusicForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ADOLayer al = new ADOLayer();
            string name = TextBox2.Text;
            DateTime date = Convert.ToDateTime(Calendar1.SelectedDate.ToShortDateString());
            al.InsertAlbum(name, date);
        }
    }
}