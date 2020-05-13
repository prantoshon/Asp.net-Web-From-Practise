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
    public partial class Serach : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HM3JBK0\\SQLEXPRESS;Initial Catalog=PPL;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
          
            if (!IsPostBack)
            {
                Panel1.Visible = true;
                DisplayData();
            }
        }
        private void DisplayData()
        {
            
            SqlDataAdapter Adp = new SqlDataAdapter("SELECT  * FROM   hrd.Department", con);
            DataTable Dt = new DataTable();
            Adp.Fill(Dt);
            GridView1.DataSource = Dt;
            GridView1.DataBind();
           //  return Dt;
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            String str = "select * from hrd.Department where (Code like '%' + @search + '%')";
            SqlCommand xp = new SqlCommand(str, con);
            xp.Parameters.Add("@search", SqlDbType.NVarChar).Value = TextBox1.Text;
            con.Open();
            xp.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = xp;
            DataSet ds = new DataSet();
            da.Fill(ds, "Code");
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
            if (GridView1.Rows.Count == 0)
            {
                Response.Write("<script>alert('Record Not Founded');</script>");
                TextBox1.Focus();
                DisplayData();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String str = "select * from hrd.Department where (Code like '%' + @search + '%')";
            SqlCommand xp = new SqlCommand(str, con);
            xp.Parameters.Add("@search", SqlDbType.NVarChar).Value = TextBox1.Text;
            con.Open();
            xp.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = xp;
            DataSet ds = new DataSet();
            da.Fill(ds, "Code");
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
          
        }
    }
}