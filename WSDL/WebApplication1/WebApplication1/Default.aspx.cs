using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            mywebref.WebService w1 = new mywebref.WebService();
  //          remmywebref.WebService w1 = new remmywebref.WebService();
            w1.Credentials = System.Net.CredentialCache.DefaultCredentials;
            int z;
            z = w1.add(x_box.Text,y_box.Text);
            z_box.Text = "add=" + z.ToString();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

//            remmywebref.WebService w1 = new remmywebref.WebService();
            mywebref.WebService w1 = new mywebref.WebService();
            w1.Credentials = System.Net.CredentialCache.DefaultCredentials;
            int z;
            z = w1.sub(x_box.Text, y_box.Text);
            z_box.Text = "sub=" + z.ToString();
        }

        protected void mul_button_Click(object sender, EventArgs e)
        {
            mywebref.WebService w1 = new mywebref.WebService();

//            remmywebref.WebService w1 = new remmywebref.WebService();
            w1.Credentials = System.Net.CredentialCache.DefaultCredentials;
            int z;
            z = w1.mul(x_box.Text, y_box.Text);
            z_box.Text = "mul=" + z.ToString();
        }

        protected void div_button_Click(object sender, EventArgs e)
        {

          //  remmywebref.WebService w1 = new remmywebref.WebService();
  mywebref.WebService w1 = new mywebref.WebService();
            w1.Credentials = System.Net.CredentialCache.DefaultCredentials;
            int z;
            z = w1.div(x_box.Text, y_box.Text);
            z_box.Text = "div=" + z.ToString();
        }
    }
}
