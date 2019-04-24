using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using  System.Data;
using System.Data.SqlClient;

namespace AdoEx
{
    public partial class Default : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Sravani_Training;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetDetails();
            }
        }

        protected void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Customer(Id,Firstname,Lastname,City) values(@id,@fname,@lname,@city)", conn);
                
                cmd.Parameters.AddWithValue("@id",txtid.Text);
                cmd.Parameters.AddWithValue("@fname",txtfname.Text);
                cmd.Parameters.AddWithValue("@lname", txtlname.Text);
                cmd.Parameters.AddWithValue("@city", txtcity.Text);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)

                {
                    lblmsg.Text = "Record Added";
                }
                else
                {
                    lblmsg.Text = "Record not Added";
                }
            }
            catch (Exception ex)
            {
                lblmsg.Text = "error" + ex.Message;

            }
            finally
            {
                conn.Close();
            }
            
            
           
            

        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {

        }

        protected void btndelete_Click(object sender, EventArgs e)
        {

        }

        protected void GetDetails()
        {

            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Sravani_Training;Integrated Security=True");
            conn.Open();
            SqlCommand cmd=new SqlCommand("select * from Customer ", conn);
            SqlDataAdapter da=new SqlDataAdapter(cmd);
            DataSet ds=new DataSet();
            da.Fill(ds,"newcustomer");
            grdcustomer.DataSource = ds.Tables["newcustomer"];
            conn.Close();
            

        }
    }
}