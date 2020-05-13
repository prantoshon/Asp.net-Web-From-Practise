using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Registration
{
    public partial class Registration : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HM3JBK0\\SQLEXPRESS;Initial Catalog=PPL;Integrated Security=True");
       
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (rbtnMale.Checked == true)
            //{
            //    rbtnFeMale.Checked = false;
            //    rbtnMale.Checked = true;
            //}
            //else
            //{
            //    
            //}
            if (!IsPostBack)
            {
                rbtnFeMale.Checked = true;
                txtName.Focus();
             
            }
          


        }
        private int Validation()
        {
            if (txtName.Text == "")
            {
                
                Response.Write("<script>alert('Full Name Required');</script>");
                txtName.Focus();
                return 2;
            }
            if (drpBloodGroup.SelectedItem.Value == "Select Please")
            {
           
                Response.Write("<script>alert('Blood Group Required');</script>");
                drpBloodGroup.Focus();
                return 2;
            }
            if (txtPhone.Text== "")
            {
           
                Response.Write("<script>alert('Phone Number Required');</script>");
                txtPhone.Focus();
                return 2;
            }
            if (txtPassword.Text == "")
            {
      
                Response.Write("<script>alert('Password Required');</script>");
                txtPassword.Focus();
                return 2;
            }
            return 1;
        }

        private void Clear()
        {
            txtName.Text = String.Empty;
            txtPassword.Attributes["value"] = txtPassword.Text = String.Empty;
            txtPhone.Text = String.Empty;
            drpBloodGroup.Text = "Select Please";
            rbtnFeMale.Checked = true;
            rbtnMale.Checked = false;

        }
        protected void btnSubmint_Click(object sender, EventArgs e)
        {
            if (Validation() == 2)
            {
                return;
            }
            string gender;
           string password = txtPassword.Attributes["value"] = txtPassword.Text;

            using (SqlCommand command = con.CreateCommand())
            {
                command.CommandText = "INSERT INTO  dbo.Registration (FullName, BloodGroup, Phone, Password, Gender) VALUES (@FullName,@BloodGroup,@Phone,@Password,@Gender)";

                command.Parameters.AddWithValue("@FullName", txtName.Text.Trim());
                command.Parameters.AddWithValue("@BloodGroup", drpBloodGroup.Text);
                command.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                command.Parameters.AddWithValue("@Password", password);
                if (rbtnFeMale.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "FeMale";
                }
                command.Parameters.AddWithValue("@Gender", gender);


                con.Open();
                int i = command.ExecuteNonQuery();
                if (i > 0)
                {
                  
                    Response.Write("<script>alert('Save Successfully');</script>");
                    Clear();
                    Response.Redirect("Serach.aspx");

                }
                con.Close();
                
            }
        }

        protected void rbtnMale_CheckedChanged(object sender, EventArgs e)
        {


            //else
            //{
            //    
            //    
            //}

            //string myStringVariable = "m";
            //ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + myStringVariable + "');", true);
            rbtnMale.Checked = true;
            rbtnFeMale.Checked = false;
        }

        protected void rbtnFeMale_CheckedChanged(object sender, EventArgs e)
        {
            //string myStringVariable = "f";
            //ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + myStringVariable + "');", true);
            rbtnMale.Checked = false;
            rbtnFeMale.Checked = true;
            //else
            //{
            //    rbtnMale.Checked = true;
            //    rbtnFeMale.Checked = false;

            //}

            //else
            //{
            //    rbtnFeMale.Checked = false;
            //    rbtnMale.Checked = false;
            //}
        }
    }
}