using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;

namespace TutorialProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-UBENDUC\\SQLEXPRESS;Initial Catalog=SENSORSYSTEM;Integrated Security=True;TrustServerCertificate=True";
            string sqlQuery = "INSERT INTO SENSOR (SensorId, SensorName, SensorType) VALUES (" + "'" + SensorID.Text + "'" + "," + "'" + SensorName.Text + "'" + "," + "'" + SensorType.Text + "'" + ")";
            SqlConnection con = new SqlConnection(connectionString);

            con.Open();
            SqlCommand sc = new SqlCommand(sqlQuery, con);
            sc.ExecuteNonQuery();
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BindGrid();
        }

        private void DBView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
        public void BindGrid()
        {
            string connectionString = "Data Source=DESKTOP-UBENDUC\\SQLEXPRESS;Initial Catalog=SENSORSYSTEM;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM SENSOR", con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            DBView.DataSource = dt;
                        }
                    }
                }
            }
        }
    }
}
