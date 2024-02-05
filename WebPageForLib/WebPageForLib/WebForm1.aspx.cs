using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library_1;
using Library_2;
using Library_3;
using Library_4;

namespace WebPageForLib
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Library_3.KI3_Class_3 a = new KI3_Class_3();
            int x = Convert.ToInt32(TextBox1.Text);
            int y = Convert.ToInt32(TextBox2.Text);
            Label1.Text = (a.F3(x,y) + 3*Library_4.KI3_Class_4.F4(x,y)).ToString();
        }
    }
}