
using System;

namespace Practical_5
{
    public partial class leave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Prevent access without login
            if (Session["Username"] == null)
            {
                Response.Redirect("login.aspx");                 return;
            }

            if (!IsPostBack)
            {
                lblUsername.Text = Session["Username"].ToString();

                if (Session["StudentName"] != null)                     lblStudentName.Text =
                        Session["StudentName"].ToString();

                if (Session["LeaveDate"] != null)                     lblLeaveDate.Text =
                        Session["LeaveDate"].ToString();

                if (Session["LeaveType"] != null)                     lblLeaveType.Text =
                        Session["LeaveType"].ToString();

                if (Session["Reason"] != null)                     lblReason.Text =
                        Session["Reason"].ToString();
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            // Remove session data
            Session.Clear();
            Session.Abandon();

            Response.Redirect("login.aspx");
        }
    }
}
