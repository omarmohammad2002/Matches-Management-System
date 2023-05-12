using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace MS3_DB
{
    public partial class SYSTEMADMIN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addnewclubbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string connstr = WebConfigurationManager.ConnectionStrings["CONNECTION"].ToString();
                SqlConnection connection = new SqlConnection(connstr);

                String clubname = newclubname.Text;
                String clubloc = newclublocname.Text;
                if (string.IsNullOrWhiteSpace(clubname))
                {
                    throw new Exception();
                }
                if (string.IsNullOrWhiteSpace(clubloc))
                {
                    throw new Exception();
                }

                SqlCommand loginproc = new SqlCommand("addClub", connection);
                loginproc.CommandType = CommandType.StoredProcedure;
                loginproc.Parameters.Add(new SqlParameter("@clubname", clubname));
                loginproc.Parameters.Add(new SqlParameter("@location", clubloc));

                connection.Open();
                loginproc.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Invalid data entered, please retry entering the data.");
            }
        }

        protected void deleteclubbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string connstr = WebConfigurationManager.ConnectionStrings["CONNECTION"].ToString();
                SqlConnection connection = new SqlConnection(connstr);

                String delclubname = deleteclubname.Text;
                if (string.IsNullOrWhiteSpace(delclubname))
                {
                    throw new Exception();
                }
                

                SqlCommand loginproc = new SqlCommand("deleteClub", connection);
                loginproc.CommandType = CommandType.StoredProcedure;
                loginproc.Parameters.Add(new SqlParameter("@clubname", delclubname));


                connection.Open();
                loginproc.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Invalid data entered, please retry entering the data.");
            }
        }

        protected void addstadiumbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string connstr = WebConfigurationManager.ConnectionStrings["CONNECTION"].ToString();
                SqlConnection connection = new SqlConnection(connstr);

                String stadname = newstadiumname.Text;
                String stadloc = newstadiumloc.Text;
                String stadcapacity = newstadiumcapacity.Text;
                if (string.IsNullOrWhiteSpace(stadname))
                {
                    throw new Exception();
                }
                if (string.IsNullOrWhiteSpace(stadloc))
                {
                    throw new Exception();
                }
                if (string.IsNullOrWhiteSpace(stadcapacity))
                {
                    throw new Exception();
                }


                SqlCommand loginproc = new SqlCommand("addStadium", connection);
                loginproc.CommandType = CommandType.StoredProcedure;
                loginproc.Parameters.Add(new SqlParameter("@StadiumName", stadname));
                loginproc.Parameters.Add(new SqlParameter("@StadiumLocation", stadloc));
                loginproc.Parameters.Add(new SqlParameter("@StadiumCapacity", stadcapacity));

                connection.Open();
                loginproc.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Invalid data entered, please retry entering the data.");
            }
        }

        protected void deletestadiumbutton_Click(object sender, EventArgs e)
        {
            try
            {


                string connstr = WebConfigurationManager.ConnectionStrings["CONNECTION"].ToString();
                SqlConnection connection = new SqlConnection(connstr);

                String stadname = deletestadiumname.Text;
                if (string.IsNullOrWhiteSpace(stadname))
                {
                    throw new Exception();
                }


                SqlCommand loginproc = new SqlCommand("deleteStadium", connection);
                loginproc.CommandType = CommandType.StoredProcedure;
                loginproc.Parameters.Add(new SqlParameter("@StadiumName", stadname));


                connection.Open();
                loginproc.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Invalid data entered, please retry entering the data.");
            }
        }

        protected void blockfanbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string connstr = WebConfigurationManager.ConnectionStrings["CONNECTION"].ToString();
                SqlConnection connection = new SqlConnection(connstr);

                String nationalIDnumber = nationalidnumber.Text;
                if (string.IsNullOrWhiteSpace(nationalIDnumber))
                {
                    throw new Exception();
                }

                SqlCommand loginproc = new SqlCommand("blockFan", connection);
                loginproc.CommandType = CommandType.StoredProcedure;
                loginproc.Parameters.Add(new SqlParameter("@nationIDno", nationalIDnumber));


                connection.Open();
                loginproc.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Invalid data entered, please retry entering the data.");
            }
        }
    }
}