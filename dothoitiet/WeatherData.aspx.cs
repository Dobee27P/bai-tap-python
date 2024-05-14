using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace WeatherMonitoring
{
    public partial class WeatherData : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindWeatherData();
            }
        }

        private void BindWeatherData()
        {
            string connectionString = "Server=desktop-p86b7r4\\sqlexpress;Database=WeatherMonitoring;User Id=sa;Password=123;"; // Replace with your connection string
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM WeatherData", con))
                {
                    con.Open();
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }
            }
        }
    }
}
