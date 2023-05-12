using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MS3_DB
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LOGINCLICK(object sender, EventArgs e)
        {

            string connstr = WebConfigurationManager.ConnectionStrings["CONNECTION"].ToString();
            SqlConnection connection = new SqlConnection(connstr);
            try { 
            String id = USERNAME.Text;
            String pass = PASSWORD.Text;

            if (string.IsNullOrWhiteSpace(id))
            {
                throw new Exception();
            }
            if (string.IsNullOrWhiteSpace(pass))
            {
                throw new Exception();
            }
                SqlCommand loginproc = new SqlCommand("userLogin", connection);
                loginproc.CommandType = CommandType.StoredProcedure;
                loginproc.Parameters.Add(new SqlParameter("@id", id));
                loginproc.Parameters.Add(new SqlParameter("@password", pass));

                SqlParameter success = loginproc.Parameters.Add("@success", SqlDbType.Int);
                SqlParameter type = loginproc.Parameters.Add("@type", SqlDbType.Int);

                success.Direction = ParameterDirection.Output;
                type.Direction = ParameterDirection.Output;

                connection.Open();
                loginproc.ExecuteNonQuery();
                connection.Close();

                if (success.Value.ToString() == "1")
                {
                    if (type.Value.ToString() == "1")
                    {
                        Session["SAM"] = USERNAME.Text;
                        Response.Redirect("SportsAssociationManager.aspx");

                    }
                    if (type.Value.ToString() == "2")
                    {
                        Session["SAM"] = USERNAME.Text;
                        Response.Redirect("Club Representative.aspx");
                    }
                    if (type.Value.ToString() == "3")
                    {
                        Session["SAM"] = USERNAME.Text;
                        Response.Redirect("StadiumManager.aspx");
                    }
                    if (type.Value.ToString() == "4")
                    {
                        try
                        {
                            SqlCommand checkstatus = new SqlCommand("SELECT count(*) FROM Fan WHERE ((username = '" + Session["SAM"] + "') and (status = 1))", connection);
                            checkstatus.Connection = connection;
                            connection.Open();
                            int statusint = (int)checkstatus.ExecuteScalar();
                            if (statusint == 0)
                            {
                                throw new Exception();
                            }
                            connection.Close();

                            Session["SAM"] = USERNAME.Text;
                            Response.Redirect("FAN.aspx");
                        }
                        catch(Exception ex)
                        {
                            Response.Redirect("Invalid data entered. (your account may be blocked by the system admin)");
                        }
                    }
                    if (type.Value.ToString() == "5")
                    {
                        Session["SAM"] = USERNAME.Text;
                        Response.Redirect("SYSTEMADMIN.aspx");
                    }
                }
                else
                {
                    Response.Write("Username or password incorrect");
                }
            }
            catch (Exception ex)
            {
                Response.Write("Invalid data entered, please retry entering the data.");
            }



            }

        protected void REGISTERCLICK(object sender, EventArgs e)
        {
            Response.Redirect("registrationpage.aspx");
        }

        protected void SYSTEMADMIN_Click(object sender, EventArgs e)
        {
            Response.Redirect("SYSTEMADMIN.aspx");
        }
    }
}