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
    public partial class SportsAssociationManager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Session["SAM"]);
        }

       

        protected void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

      

        protected void Addmatchbutton(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["CONNECTION"].ToString();
            SqlConnection connection = new SqlConnection(connstr);

            String host = DropDownList1.SelectedItem.Text;
            String guest = DropDownList2.SelectedItem.Text;
            DateTime starttime = DateTime.Parse(TextBox3.Text);
            DateTime endttime = DateTime.Parse(TextBox4.Text);

            SqlCommand loginproc = new SqlCommand("addNewMatch", connection);
            loginproc.CommandType = CommandType.StoredProcedure;
            loginproc.Parameters.Add(new SqlParameter("@club1", host));
            loginproc.Parameters.Add(new SqlParameter("@club2", guest));
            loginproc.Parameters.Add(new SqlParameter("@date", starttime));
            loginproc.Parameters.Add(new SqlParameter("@date2", endttime));
            connection.Open();
            loginproc.ExecuteNonQuery();
            connection.Close();
        }

        protected void deletematch_Click(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["CONNECTION"].ToString();
            SqlConnection connection = new SqlConnection(connstr);

            String host = DropDownList3.SelectedItem.Text;
            String guest = DropDownList4.SelectedItem.Text;
            DateTime starttime = DateTime.Parse(TextBox7.Text);
            DateTime endttime = DateTime.Parse(TextBox8.Text);

            SqlCommand loginproc = new SqlCommand("deleteMatch", connection);
            loginproc.CommandType = CommandType.StoredProcedure;
            loginproc.Parameters.Add(new SqlParameter("@club1", host));
            loginproc.Parameters.Add(new SqlParameter("@club2", guest));
            /*loginproc.Parameters.Add(new SqlParameter("@date", starttime));
            loginproc.Parameters.Add(new SqlParameter("@date2", endttime));*/
            connection.Open();
            loginproc.ExecuteNonQuery();
            connection.Close();
        }

        protected void View_All_upcoming_matches_Click(object sender, EventArgs e)
        {
            Response.Redirect("View All upcoming matches.aspx");
        }

        protected void View_already_played_matches_Click(object sender, EventArgs e)
        {
            Response.Redirect("View already played matches.aspx");
        }

        protected void View_pair_of_club_names_who_never_scheduled_to_play_with_each_other_Click(object sender, EventArgs e)
        {
            Response.Redirect("View pair of club names who never scheduled to play with each other.aspx");
        }
    }
}