using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using WebFormWithADO.BusinessLogic;
using WebFormWithADO.Model;

namespace WebFormWithADO
{
    public partial class register : System.Web.UI.Page
    {
        string strconn = ConfigurationManager.ConnectionStrings["info_practice_connection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack)

            {
                try
                {
                    
                    SqlConnection sqlConnection = new SqlConnection(strconn);
                    SqlCommand cmd = new SqlCommand("select * from course",sqlConnection);

                    sqlConnection.Open();
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    ddlCourse.DataSource = dataReader;
                    ddlCourse.DataTextField = "coursename";
                    ddlCourse.DataValueField = "id";
                    ddlCourse.DataBind();
                }
                catch( Exception xe)
                {
                    Response.Write(xe);

                }
            }
                

        }
        protected void clickBtnSubmit(object sender, EventArgs e)
        {
            Response.Write("button clicked");
            RegistrationModel rg = new RegistrationModel();
            rg.FirstName = txtFirstName.Text;
            rg.LastName = txtLastName.Text;
            rg.password = txtpassword.Text;
            rg.Email = txtEmail.Text;
            //rg.DOB = txtDOB.date;
            rg.courseID =ddlCourse.SelectedValue;

           
            

            try
            {
               
                SqlConnection sqlConnection = new SqlConnection(strconn);
                SqlCommand cmd = new SqlCommand("insert into registerWebform (firstName,lastName,email,[password],courseID) values(' "+ txtFirstName.Text + " '  ,  '"+ txtLastName.Text + "'  ,  '"+ txtEmail.Text + " ',' "+ txtpassword.Text + " ' ,  '"+ ddlCourse.SelectedValue + " ')", sqlConnection);

                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            //'" + TextBox1.Text + "',
            catch (Exception ex)
            {
                Response.Write(ex + "exception error");
            }
            lbl1.Visible = true;
            lbl1.Text = "register successfull";

            txtFirstName.Text = string.Empty;
            txtpassword.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtLastName.Text = string.Empty;

            Response.Redirect("default.aspx");
        }

        protected void txtdob_TextChanged(object sender, EventArgs e)
        {

        }
    }
}