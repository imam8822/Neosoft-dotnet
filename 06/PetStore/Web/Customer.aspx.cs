using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Web
{
    public partial class Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_add_Click1(object sender, EventArgs e)
        {
            string query1 = "SP_AddCustomerDetails";
            string query2 = "SP_AddCustomerLogin";
            string conString = ConfigurationManager.ConnectionStrings["PetDbConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                int customerId = 0;
                try
                {
                    using (SqlCommand command = new SqlCommand(query1, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        string name = tb_Name.Text;
                        string email = tb_email.Text;
                        string zipcode = tb_zipcode.Text;
                        SqlParameter parameter;

                        parameter = command.Parameters.Add("@customer_name", SqlDbType.VarChar);
                        parameter.Value = name;
                        parameter = command.Parameters.Add("@email", SqlDbType.VarChar);
                        parameter.Value = email;
                        parameter = command.Parameters.Add("@zipcode", SqlDbType.VarChar);
                        parameter.Value = zipcode;
                        connection.Open();
                        int v = command.ExecuteNonQuery();

                        connection.Close();

                    }
                    using (SqlCommand command = new SqlCommand(query1, connection))
                    {
                        SqlDataReader dr = null;
                        command.CommandText = "select top(1) Id from customer order by Id desc ";
                        connection.Open();
                        int v = command.ExecuteNonQuery();
                        dr = command.ExecuteReader();
                        if (dr.Read())
                        {
                            customerId = int.Parse(dr.GetValue(0).ToString());
                        }
                        connection.Close();
                    }

                    using (SqlCommand command = new SqlCommand(query2, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        string username = tb_username.Text;
                        string password = tb_pass.Text;

                        SqlParameter parameter;
                        parameter = command.Parameters.Add("@CustomerId", SqlDbType.Int);
                        parameter.Value = customerId;
                        parameter = command.Parameters.Add("@username", SqlDbType.VarChar);
                        parameter.Value = username;
                        parameter = command.Parameters.Add("@password", SqlDbType.VarChar);
                        parameter.Value = password;
                        connection.Open();
                        command.ExecuteNonQuery();

                    }
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}