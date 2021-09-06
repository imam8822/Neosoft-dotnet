using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Customer_Register(string conString)
        {
            string Name = TextBox1.Text;
            string Email = TextBox2.Text;
            string Zipcode = TextBox3.Text;
            string query = "Add_customer";
            using (SqlConnection cons = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(query, cons))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter parameter;
                    parameter = cmd.Parameters.Add("@Name", SqlDbType.VarChar);
                    parameter.Value = Name;
                    parameter = cmd.Parameters.Add("@zipcode", SqlDbType.VarChar);
                    parameter.Value = Email;
                    parameter = cmd.Parameters.Add("@email", SqlDbType.VarChar);
                    parameter.Value = Zipcode;
                    cmd.Connection = cons;
                    cons.Open();
                    cmd.ExecuteNonQuery();
                    cons.Close();
                }

            }
        }
        protected void Customer_Login(string conString)
        {
            string Name = TextBox1.Text;
            string Zipcode = TextBox3.Text;
            string Email = TextBox2.Text;
            string UserName = TextBox4.Text;
            string Password = TextBox5.Text;
            string CustomerId = "";

            DataSet ds = new DataSet();
            string query = "Login_customer";
            string query1 = $"select * from customer";
            SqlDataAdapter da = new SqlDataAdapter(query1, conString);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.Fill(ds, "customer");
            var data = ds.Tables["customer"].Rows;
            foreach (DataRow row in data)
            {
                if (row["Name"].ToString() == Name && row["zipcode"].ToString() == Zipcode)
                {
                    CustomerId = row["id"].ToString();
                }
            }
            //
            using (SqlConnection cons = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(query, cons))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter parameter;
                    parameter = cmd.Parameters.Add("@customer_id", SqlDbType.Int);
                    parameter.Value = CustomerId;
                    parameter = cmd.Parameters.Add("@username", SqlDbType.VarChar);
                    parameter.Value = UserName;
                    parameter = cmd.Parameters.Add("@password", SqlDbType.VarChar);
                    parameter.Value = Password;
                    cmd.Connection = cons;
                    cons.Open();
                    cmd.ExecuteNonQuery();
                    cons.Close();
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string Constring = ConfigurationManager.ConnectionStrings["PetDbConnectionString"].ConnectionString;
            Customer_Register(Constring);
            Customer_Login(Constring);

        }

    }


}