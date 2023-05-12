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
    public partial class StadiumManager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Session["SAM"]);
        }

        protected void View_all_related_information_of_the_Stadium_Click(object sender, EventArgs e)
        {
            this.BindGrid1();
        }

        private void BindGrid1()
        {
            string constr = WebConfigurationManager.ConnectionStrings["CONNECTION"].ToString();
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select s.name, s.id, s.capacity from stadium s , stadiummanager sm where sm.username = '" + Session["SAM"] + "' and sm.stadium_id = s.id "))
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

        protected void View_all_requests_he_already_received_Click(object sender, EventArgs e)
        {
            this.BindGrid2();
        }

        private void BindGrid2()
        {
            string constr = WebConfigurationManager.ConnectionStrings["CONNECTION"].ToString();
            using (SqlConnection con = new SqlConnection(constr))
            { using (SqlCommand cmd = new SqlCommand("select cr.name, c1.name, c2.name, m.start_time, m.end_time, hr.status from club c1, club c2, match m , clubrepresentative cr, host_request hr where hr.match_id = m.id and c1.id = m.host_id and c2.id= m.guest_id and hr.club_representative_username = cr.username and hr.stadium_manager_username= '" + Session["SAM"] + "' "))
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        GridView2.DataSource = dt;
                        GridView2.DataBind();
                    }
                }
            }
        }
    
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["CONNECTION"].ToString();
            SqlConnection connection = new SqlConnection(connstr);

            String host = DropDownList2.SelectedItem.Text;
            String guest = DropDownList1.SelectedItem.Text;
            DateTime time = DateTime.Parse(TextBox3.Text);
            String s = Session["SAM"].ToString();

            SqlCommand loginproc = new SqlCommand("rejectRequest", connection);
            loginproc.CommandType = CommandType.StoredProcedure;
            loginproc.Parameters.Add(new SqlParameter("@host_club_name", host));
            loginproc.Parameters.Add(new SqlParameter("@guest_club_name", guest));
            loginproc.Parameters.Add(new SqlParameter("@start_time", time));
            loginproc.Parameters.Add(new SqlParameter("@Username", s));

            connection.Open();
            loginproc.ExecuteNonQuery();
            connection.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["CONNECTION"].ToString();
            SqlConnection connection = new SqlConnection(connstr);

            String host = DropDownList3.SelectedItem.Text;
            String guest = DropDownList4.SelectedItem.Text;
            DateTime time = DateTime.Parse(TextBox3.Text);
            String s = Session["SAM"].ToString(); 

            SqlCommand loginproc = new SqlCommand("acceptRequest", connection);
            loginproc.CommandType = CommandType.StoredProcedure;
            loginproc.Parameters.Add(new SqlParameter("@host_club_name", host));
            loginproc.Parameters.Add(new SqlParameter("@guest_club_name", guest));
            loginproc.Parameters.Add(new SqlParameter("@start_time", time));
            loginproc.Parameters.Add(new SqlParameter("@Username", s));

            connection.Open();
            loginproc.ExecuteNonQuery();
            connection.Close();
        }
    }
}