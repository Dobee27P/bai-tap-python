using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

namespace demo_api_57kmt
{
    public partial class api : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Chuỗi kết nối tới cơ sở dữ liệu
            string connectionString = "Data Source=127.0.0.1,49259;Initial Catalog=DEMO_IOT;User Id=sa;Password=123;";

            // Tạo kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Tạo đối tượng SqlCommand để thực thi stored procedure
                using (SqlCommand command = new SqlCommand("SP_Chart", connection))
                {
                    // Thiết lập CommandType là StoredProcedure
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@sid", SqlDbType.Int).Value = this.Request["sid"];

                    try
                    {
                        // Mở kết nối đến cơ sở dữ liệu
                        connection.Open();

                        // Thực thi stored procedure
                        object kq = command.ExecuteScalar();

                        string json = (string)kq;
                        this.Response.Write(json);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Đã có lỗi xảy ra: " + ex.Message);
                    }
                }
            }
        }
    }
}