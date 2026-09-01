using System;

namespace Practical_5
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // User must login first
            if (Session["Username"] == null)
            {
                Response.Redirect("login.aspx");
            }

            if (!IsPostBack)
            {
                lblUsername.Text = Session["Username"].ToString();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtStudentName.Text == "")
            {
                lblMessage.Text = "Please enter student name";
                return;
            }

            if (calLeaveDate.SelectedDate == DateTime.MinValue)
            {
                lblMessage.Text = "Please select leave date";                 return;
            }

            if (ddlLeaveType.SelectedIndex == 0)
            {
                lblMessage.Text = "Please select leave type";                 return;
            }

            // Store leave details in Session
            Session["StudentName"] = txtStudentName.Text;             Session["LeaveDate"] =                 calLeaveDate.SelectedDate.ToShortDateString();
            Session["LeaveType"] = ddlLeaveType.SelectedValue;
            Session["Reason"] = txtReason.Text;

            Response.Redirect("leave.aspx");
        }
    }
}
