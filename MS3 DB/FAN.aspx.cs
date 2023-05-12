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
    public partial class FAN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Session["SAM"]);
        }

        protected void View_all_matches_that_have_available_tickets_Click(object sender, EventArgs e)
        {
            this.BindGrid1();
        }

        private void BindGrid1()
        {
            string constr = WebConfigurationManager.ConnectionStrings["CONNECTION"].ToString();
            using (SqlConnection con = new SqlConnection(constr))
            {
                DateTime date = DateTime.Parse(TextBox1.Text); 
                using (SqlCommand cmd = new SqlCommand(" select distinct c1.name as host , c2.name as guest , m.start_time , s.name as stadium , s.location from club c1 , club c2 , match m , stadium s , tickets t where m.start_time >=' "+ date+"'  AND m.host_id = c1.id AND m.guest_id =c2.id AND m.stadium_id = s.ID AND t.match_id = m.id AND t.status = 1"))
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connstr = WebConfigurationManager.ConnectionStrings["CONNECTION"].ToString();
                SqlConnection connection = new SqlConnection(connstr);


                SqlCommand getnationalid = new SqlCommand("select c.national_id from fan c where c.username = '" + Session["SAM"] + "' ");
                getnationalid.Connection = connection;
                connection.Open();
                String nationalid = getnationalid.ExecuteScalar().ToString();
                connection.Close();

                String host = DropDownList1.SelectedItem.Text;
                String guest = DropDownList2.SelectedItem.Text;
                DateTime date = DateTime.Parse(TextBox4.Text);
                if (string.IsNullOrWhiteSpace(host))
                {
                    throw new Exception();
                }
                if (string.IsNullOrWhiteSpace(guest))
                {
                    throw new Exception();
                }


                SqlCommand loginproc = new SqlCommand("purchaseTicket", connection);
                loginproc.CommandType = CommandType.StoredProcedure;
                loginproc.Parameters.Add(new SqlParameter("@fan_nid", nationalid));
                loginproc.Parameters.Add(new SqlParameter("@host_name", host));
                loginproc.Parameters.Add(new SqlParameter("@guest_name", guest));
                loginproc.Parameters.Add(new SqlParameter("@date", date));

                connection.Open();
                loginproc.ExecuteNonQuery();
                connection.Close();
            }
            catch(Exception ex)
            {
                Response.Write("Invalid data entered, please retry entering the data.");
            }
        }
    }
    }
    