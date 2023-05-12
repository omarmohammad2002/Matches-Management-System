using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace MS3_DB
{
    public partial class Club_Representative : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Session["SAM"]);

        }

        protected void View_pair_of_club_names_who_never_scheduled_to_play_with_each_other_Click(object sender, EventArgs e)
        {
            this.BindGrid2();
        }

        private void BindGrid2()
        {
            string constr = WebConfigurationManager.ConnectionStrings["CONNECTION"].ToString();
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select c.name, c.id, c.location from club c , clubrepresentative cr where cr.username = '" + Session["SAM"] + "' and cr.club_id = c.id "))
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

        protected void View_all_upcoming_matches_for_the_club_Click(object sender, EventArgs e)
        {

            this.BindGrid1();
        }

        private void BindGrid1()
        {
            string constr = WebConfigurationManager.ConnectionStrings["CONNECTION"].ToString();
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select c.name as club1, c2.name as club2, m.start_time, s.name from Club c , club c2, match m, stadium s, clubrepresentative cr where((m.guest_id = c2.id and m.host_id = c.id) or(m.host_id = c2.id and m.guest_id = c.id)) and m.stadium_id = s.ID  and m.start_time > CURRENT_TIMESTAMP and c.id = cr.club_id and cr.username = '" + Session["SAM"] + "'"))
                {
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
        }


        protected void View_all_available_stadiums_Click(object sender, EventArgs e)
        {
            String s = TextBox1.Text;
            this.BindGrid3();
        }

        private void BindGrid3()
        {
            
            string constr = WebConfigurationManager.ConnectionStrings["CONNECTION"].ToString();
            DateTime starttime = DateTime.Parse(TextBox1.Text);
            using (SqlConnection con = new SqlConnection(constr))

            {
                  
                using (SqlCommand cmd = new SqlCommand(" select s.name, s.Location,s.Capacity  from stadium s where s.Status=1 and s.id not in(select m.Stadium_id from  match m where s.id=m.Stadium_id and '" + starttime + "'=m.Start_time)"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView3.DataSource = dt;
                            GridView3.DataBind();
                        }
                    }
                }
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["CONNECTION"].ToString();
            SqlConnection connection = new SqlConnection(connstr);
          
            
            SqlCommand getclubname = new SqlCommand("select c.name from club c , clubrepresentative cr where c.id = cr.club_id and cr.username = '" + Session["SAM"] + "' ");
            getclubname.Connection = connection; 
            connection.Open();
            String host = getclubname.ExecuteScalar().ToString();
            connection.Close();

            String stadium = DropDownList1.SelectedItem.Text;
            DateTime starttime = DateTime.Parse(TextBox3.Text);
        

            SqlCommand loginproc = new SqlCommand("addHostRequest", connection);
            loginproc.CommandType = CommandType.StoredProcedure;
            loginproc.Parameters.Add(new SqlParameter("@clubname", host));
            loginproc.Parameters.Add(new SqlParameter("@stadiumname", stadium));
            loginproc.Parameters.Add(new SqlParameter("@starttime", starttime));
            connection.Open();
            loginproc.ExecuteNonQuery();
            connection.Close();
        }
    }
}
                                                                                                             