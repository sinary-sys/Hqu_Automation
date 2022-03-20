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
    public partial class usermanagement : Form
    {
        public usermanagement()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void usermanagement_Load(object sender, EventArgs e)
        {
            signin signin = new signin();

            textBox1.Text= signin.TextBox_username.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            RequestSong requestSong = new RequestSong();
            requestSong.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "8.135.57.27";   // update me
            builder.UserID = "sa";              // update me
            builder.Password = "sun@5211314";      // update me
            builder.InitialCatalog = "KTV";
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {


                String sql = "select 积分 from 用户 where 会员用户名='" + textBox1.Text + "'" ;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, connection);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "积分表");
                if (dataSet.Tables["积分表"].Rows.Count == 0) { MessageBox.Show("The user score is 0"); }
                else {
                    MessageBox.Show("The user score" + dataSet.Tables["积分表"].Rows[0].ItemArray[0]); 
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            userchangepassage userchangepassage = new userchangepassage();
            userchangepassage.Show();
        }
    }
}
