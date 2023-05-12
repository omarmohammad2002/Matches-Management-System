using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MS3_DB
{
    public partial class registrationpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void CreateClick(object sender, EventArgs e)
        {
            try
            {
                if (DropDownList1.SelectedValue.ToString() == "1")
                {
                    string connstr = WebConfigurationManager.ConnectionStrings["CONNECTION"].ToString();
                    SqlConnection connection = new SqlConnection(connstr);

                    String name = namereg.Text;
                    String username = usernamereg.Text;
                    String password = passwordreg.Text;

                    if (string.IsNullOrWhiteSpace(name))
                    {
                        throw new Exception();
                    }
                    if (string.IsNullOrWhiteSpace(username))
                    {
                        throw new Exception();
                    }
                    if (string.IsNullOrWhiteSpace(password))
                    {
                        throw new Exception();
                    }

                    SqlCommand loginproc = new SqlCommand("addAssociationManager", connection);
                    loginproc.CommandType = CommandType.StoredProcedure;
                    loginproc.Parameters.Add(new SqlParameter("@name", name));
                    loginproc.Parameters.Add(new SqlParameter("@username", username));
                    loginproc.Parameters.Add(new SqlParameter("@password", password));

                    connection.Open();
                    loginproc.ExecuteNonQuery();
                    connection.Close();

                    Response.Redirect("Login.aspx");
                }
                if (DropDownList1.SelectedValue.ToString() == "2")
                {
                    string connstr = WebConfigurationManager.ConnectionStrings["CONNECTION"].ToString();
                    SqlConnection connection = new SqlConnection(connstr);

                    String name = namereg.Text;
                    String Clubname = DropDownList4.SelectedItem.Text;
                    String username = usernamereg.Text;
                    String password = passwordreg.Text;

                    if (string.IsNullOrWhiteSpace(name))
                    {
                        throw new Exception();
                    }
                    if (string.IsNullOrWhiteSpace(username))
                    {
                        throw new Exception();
                    }
                    if (string.IsNullOrWhiteSpace(password))
                    {
                        throw new Exception();
                    }
                    if (string.IsNullOrWhiteSpace(Clubname))
                    {
                        throw new Exception();
                    }

                    //SqlCommand checkclubname = new SqlCommand("SELECT count(*) FROM club WHERE (name = '" + Clubname + "')", connection);
                    //checkclubname.Connection = connection;
                    //connection.Open();
                    //int ClubExists = (int)checkclubname.ExecuteScalar();
                    //connection.Close();


                    SqlCommand loginproc = new SqlCommand("addRepresentative", connection);
                    loginproc.CommandType = CommandType.StoredProcedure;
                    loginproc.Parameters.Add(new SqlParameter("@RepName", name));
                    loginproc.Parameters.Add(new SqlParameter("@ClubName", Clubname));
                    loginproc.Parameters.Add(new SqlParameter("@UserName", username));
                    loginproc.Parameters.Add(new SqlParameter("@password", password));

                    connection.Open();
                    loginproc.ExecuteNonQuery();
                    connection.Close();

                    Response.Redirect("Login.aspx");
                }
                if (DropDownList1.SelectedValue.ToString() == "3")
                {
                    string connstr = WebConfigurationManager.ConnectionStrings["CONNECTION"].ToString();
                    SqlConnection connection = new SqlConnection(connstr);

                    String name = namereg.Text;
                    String Stadiumname = DropDownList5.SelectedItem.Text;
                    String username = usernamereg.Text;
                    String password = passwordreg.Text;

                    if (string.IsNullOrWhiteSpace(name))
                    {
                        throw new Exception();
                    }
                    if (string.IsNullOrWhiteSpace(username))
                    {
                        throw new Exception();
                    }
                    if (string.IsNullOrWhiteSpace(password))
                    {
                        throw new Exception();
                    }
                    if (string.IsNullOrWhiteSpace(Stadiumname))
                    {
                        throw new Exception();
                    }


                    SqlCommand loginproc = new SqlCommand("addStadiumManager", connection);
                    loginproc.CommandType = CommandType.StoredProcedure;
                    loginproc.Parameters.Add(new SqlParameter("@Name", name));
                    loginproc.Parameters.Add(new SqlParameter("@stad_name", Stadiumname));
                    loginproc.Parameters.Add(new SqlParameter("@User_Name", username));
                    loginproc.Parameters.Add(new SqlParameter("@password", password));

                    connection.Open();
                    loginproc.ExecuteNonQuery();
                    connection.Close();

                    Response.Redirect("Login.aspx");
                }
                if (DropDownList1.SelectedValue.ToString() == "4")
                {
                    string connstr = WebConfigurationManager.ConnectionStrings["CONNECTION"].ToString();
                    SqlConnection connection = new SqlConnection(connstr);

                    String name = namereg.Text;
                    String username = usernamereg.Text;
                    String password = passwordreg.Text;
                    String nationalid = nationalidreg.Text;
                    DateTime birthdate = DateTime.Parse(birthdatereg.Text);
                    String address = addressreg.Text;
                    String phonenumber = numberreg.Text;

                    
                    if (string.IsNullOrWhiteSpace(name))
                    {
                        throw new Exception();
                    }
                    if (string.IsNullOrWhiteSpace(username))
                    {
                        throw new Exception();
                    }
                    if (string.IsNullOrWhiteSpace(password))
                    {
                        throw new Exception();
                    }
                    if (string.IsNullOrWhiteSpace(nationalid))
                    {
                        throw new Exception();
                    }
                    if (string.IsNullOrWhiteSpace(address))
                    {
                        throw new Exception();
                    }
                    if (string.IsNullOrWhiteSpace(phonenumber))
                    {
                        throw new Exception();
                    }

                    SqlCommand loginproc = new SqlCommand("addFan", connection);
                    loginproc.CommandType = CommandType.StoredProcedure;
                    loginproc.Parameters.Add(new SqlParameter("@name", name));
                    loginproc.Parameters.Add(new SqlParameter("@username", username));
                    loginproc.Parameters.Add(new SqlParameter("@password", password));
                    loginproc.Parameters.Add(new SqlParameter("@national_id", nationalid));
                    loginproc.Parameters.Add(new SqlParameter("@birth_date", birthdate));
                    loginproc.Parameters.Add(new SqlParameter("@address", address));
                    loginproc.Parameters.Add(new SqlParameter("@phone_number", phonenumber));

                    connection.Open();
                    loginproc.ExecuteNonQuery();
                    connection.Close();

                    Response.Redirect("Login.aspx");
                }
            }
            catch(Exception ex)
            {
                Response.Write("Invalid data entered, please retry entering the data.");
            }
        }
    }
}