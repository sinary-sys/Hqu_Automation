using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ktvsystem
{
    public partial class membermanagement : Form
    {
        public membermanagement()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            AdministratorSystem administratorSystem = new AdministratorSystem();
            administratorSystem.Show();

        }

        private void membermanagement_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "8.135.57.27";   // update me
            builder.UserID = "sa";              // update me
            builder.Password = "sun@5211314";      // update me
            builder.InitialCatalog = "KTV";
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {


                String sql = "select 编号,管理名 from 管理员";              
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, connection);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "管理员");
                dataGridView1.DataSource = dataSet.Tables["管理员"];
            }
        }
    }
}
