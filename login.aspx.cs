using System;
using System.Web;

namespace Practical_5
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Check Remember Me cookie
                if (Request.Cookies["UserCookie"] != null)
                {
                    txtUsername.Text =
                        Request.Cookies["UserCookie"]["Username"];

                    chkRemember.Checked = true;
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            // Simple username and password             if (txtUsername.Text == "student" &&
                txtPassword.Text == "1234")
            {
                // Store username in session
                Session["Username"] = txtUsername.Text;

                // Remember Me
                if (chkRemember.Checked)
                {
                    HttpCookie cookie = new HttpCookie("UserCookie");

                    cookie["Username"] = txtUsername.Text;
                    cookie.Expires = DateTime.Now.AddDays(7);

                    Response.Cookies.Add(cookie);
                }                 else
                {
                    if (Request.Cookies["UserCookie"] != null)
                    {
                        HttpCookie cookie = new HttpCookie("UserCookie");                         cookie.Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies.Add(cookie);
                    }
                }

                Response.Redirect("default.aspx");
            }             else
            {
                lblMessage.Text = "Invalid username or password";
            }
        }
    }
}
