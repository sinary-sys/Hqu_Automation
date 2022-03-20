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
    public partial class RequestSong : Form
    {
        public RequestSong()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "8.135.57.27";   // update me
                builder.UserID = "sa";              // update me
                builder.Password = "sun@5211314";      // update me
                builder.InitialCatalog = "KTV";
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    String sql = " select * From 歌曲 Where 歌曲编号 like '" + textBox1.Text + "%'" + " ";
                    SqlDataAdapter mysqlcommand = new SqlDataAdapter(sql, connection);
                    DataSet dataSet = new DataSet();
                    mysqlcommand.Fill(dataSet, "数字点歌");
                    dataGridView1.DataSource = dataSet.Tables["数字点歌"];
                }
            }
            else if (radioButton2.Checked == true)
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "8.135.57.27";   // update me
                builder.UserID = "sa";              // update me
                builder.Password = "sun@5211314";      // update me
                builder.InitialCatalog = "KTV";
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {

                    String sql = " select * From 歌曲 Where 名称 like '" + textBox1.Text + "%'" + " ";
                    SqlDataAdapter mysqlcommand = new SqlDataAdapter(sql, connection);
                    DataSet dataSet = new DataSet();
                    mysqlcommand.Fill(dataSet, "数字点歌");
                    dataGridView1.DataSource = dataSet.Tables["数字点歌"];
                }
            }
            else if (radioButton3.Checked == true)
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "8.135.57.27";   // update me
                builder.UserID = "sa";              // update me
                builder.Password = "sun@5211314";      // update me
                builder.InitialCatalog = "KTV";
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {

                    String sql = " select * From 歌曲 Where 歌手姓名 like '" + textBox1.Text + "%'" + " ";
                    SqlDataAdapter mysqlcommand = new SqlDataAdapter(sql, connection);
                    DataSet dataSet = new DataSet();
                    mysqlcommand.Fill(dataSet, "数字点歌");
                    dataGridView1.DataSource = dataSet.Tables["数字点歌"];



                }

            }
            else if (radioButton4.Checked == true)
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "8.135.57.27";   // update me
                builder.UserID = "sa";              // update me
                builder.Password = "sun@5211314";      // update me
                builder.InitialCatalog = "KTV";
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    String sql = " select * From 歌曲 Where 歌曲拼写 like '" + textBox1.Text + "%'" + " ";
                    SqlDataAdapter mysqlcommand = new SqlDataAdapter(sql, connection);
                    DataSet dataSet = new DataSet();
                    mysqlcommand.Fill(dataSet, "数字点歌");
                    dataGridView1.DataSource = dataSet.Tables["数字点歌"];
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            signin signin = new signin();
            signin.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int count = 0;
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "8.135.57.27";   // update me
            builder.UserID = "sa";              // update me
            builder.Password = "sun@5211314";      // update me
            builder.InitialCatalog = "KTV";
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                if (e.RowIndex < dataGridView1.RowCount - 1)
                {
                    count += 1;
                    String sql = "INSERT INTO 我的歌单 SELECT 歌曲编号,名称 FROM 歌曲 WHERE 歌曲编号 = '" + dataGridView1.Rows[e.RowIndex].Cells[0].Value + "'";
                    SqlDataAdapter mysqlcommand = new SqlDataAdapter(sql, connection);
                    DataSet dataSet = new DataSet();
                    if (MessageBox.Show("Do you want to join my song list?", "Tips", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        mysqlcommand.Fill(dataSet, "歌曲信息表");
                        MessageBox.Show("Added to my song list");
                    }
                    string sql1 = "UPDATE 歌曲排行榜 SET 总点击率 += " + count + " WHERE 歌曲编号 = '" + dataGridView1.Rows[e.RowIndex].Cells[0].Value + "'";
                    SqlDataAdapter mysqlcommand1 = new SqlDataAdapter(sql1, connection);
                    DataSet dataSet1 = new DataSet();
                    mysqlcommand1.Fill(dataSet1, "歌曲排行榜");
                    signin signin = new signin();
                    string sql2 = "UPDATE 用户 SET 积分 += " + count + " WHERE 会员用户名 = '" + signin.user + "'";
                    SqlDataAdapter mysqlcommand2 = new SqlDataAdapter(sql2, connection);
                    DataSet dataSet2 = new DataSet();
                    mysqlcommand2.Fill(dataSet2, "歌曲排行榜");


                }




            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            player player = new player();
            player.Show();
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
                String sql = "select * from 歌曲排行榜";
                SqlDataAdapter mysqlcommand = new SqlDataAdapter(sql, connection);
                DataSet dataSet = new DataSet();
                mysqlcommand.Fill(dataSet,"歌曲排行榜");
                dataGridView1.DataSource = dataSet.Tables["歌曲排行榜"];

            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            usermanagement usermanagement = new usermanagement();
            usermanagement.Show();
        }

        private void RequestSong_Load(object sender, EventArgs e)
        {

        }
    }
}
