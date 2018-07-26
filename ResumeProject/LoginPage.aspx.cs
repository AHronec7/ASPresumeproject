using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace ResumeProject
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (Session["username"] != null)
            {
                UsernameLabel.Visible = true;
                Response.Write("you logged in as : " + Session["username"]);
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection();
            string sqlconnstring = WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            sqlcon = new SqlConnection(sqlconnstring);
            SqlDataAdapter sqlda = new SqlDataAdapter("passwordproc", sqlcon);
            DataTable DTpassword = new DataTable();
            sqlda.Fill(DTpassword);

            DataRow[] passwordDR = DTpassword.Select("username = '" + TextBox1.Text + "'");
            if (passwordDR[0].ItemArray[1].ToString() == TextBox2.Text)
            {
                Response.Write("Logged in");
            }
            else 
            {
                // if the user does not put in the right passwordf
                Response.Write("incorrect password");
            }
  
            }

        }

    }

   




