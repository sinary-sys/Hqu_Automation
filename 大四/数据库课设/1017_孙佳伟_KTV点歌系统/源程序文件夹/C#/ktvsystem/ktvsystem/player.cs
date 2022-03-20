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
    public partial class player : Form
    {
        public player()
        {
            InitializeComponent();
        }

        private void player_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "8.135.57.27";   // update me
            builder.UserID = "sa";              // update me
            builder.Password = "sun@5211314";      // update me
            builder.InitialCatalog = "KTV";
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {

                String sql = "select * from 我的歌单";
                SqlDataAdapter mysqlcommand = new SqlDataAdapter(sql, connection);
                DataSet dataSet = new DataSet();
                mysqlcommand.Fill(dataSet, "数字点歌");
                dataGridView1.DataSource = dataSet.Tables["数字点歌"];



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            RequestSong requestSong = new RequestSong();
            requestSong.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            musicplayer musicplayer = new musicplayer();
            musicplayer.Show();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }

}
