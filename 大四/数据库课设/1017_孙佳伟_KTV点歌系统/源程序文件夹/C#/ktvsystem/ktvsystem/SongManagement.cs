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
    public partial class SongManagement : Form
    {
        DataSet ds = new DataSet();
        public BindingManagerBase mybind;
        int bianshi = 0;
        int qx = 0;

        public SongManagement()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            AdministratorSystem administratorSystem = new AdministratorSystem();
            administratorSystem.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1_songnumber.Text == "")
            {
                MessageBox.Show("Fill in the song number first");
            }
            else {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "8.135.57.27";   // update me
                builder.UserID = "sa";              // update me
                builder.Password = "sun@5211314";      // update me
                builder.InitialCatalog = "KTV";
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    String sql = "SELECT * FROM 歌曲";
                    SqlDataAdapter mysqlcommand = new SqlDataAdapter(sql, connection);
                    DataSet dataSet = new DataSet();
                    mysqlcommand.Fill(dataSet, "歌曲信息表");
                    DataRow _row = dataSet.Tables["歌曲信息表"].NewRow();
                    _row[0] = textBox1_songnumber.Text.ToString() ;
                    _row[1] = textBox2_songname.Text.ToString();
                    _row[2] = textBox3_songernumber.Text;
                    _row[3] = textBox4_1.Text.ToString();
                    _row[4] = textBox5_language1.Text;
                    _row[5] = textBox6_renring1.Text;

                    dataSet.Tables["歌曲信息表"].Rows.Add(_row);
                    SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(mysqlcommand);
                    mysqlcommand.Update(dataSet,"歌曲信息表");

                    /* String sql1 = "SELECT * FROM 歌曲排行榜";
                     SqlDataAdapter mysqlcommand1 = new SqlDataAdapter(sql1, connection);
                     DataSet dataSet1 = new DataSet();
                     mysqlcommand.Fill(dataSet1, "歌曲信息表");
                     DataRow _row1 = dataSet1.Tables["歌曲信息表"].NewRow();
                     _row1[0] = textBox1_songnumber.Text;
                     _row1[1] = textBox2_songname.Text.ToString();
                    _row1[2] = 0;
                     _row1[3] = 0;
                     _row1[4] = 0;
                     _row1[5] = 0;
                     dataSet1.Tables["歌曲信息表"].Rows.Add(_row1);
                     SqlCommandBuilder cmd = new SqlCommandBuilder(mysqlcommand1);
                     mysqlcommand1.Update(dataSet1, "歌曲信息表");*/
                    MessageBox.Show("add succeed");
                    textBox1_songnumber.Text = "";
                    textBox2_songname.Text="";
                     textBox3_songernumber.Text="";
                     textBox4_1.Text="";
                     textBox5_language1.Text="";
                     textBox6_renring1.Text="";


                }


            }

        }

        private void SongManagement_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "8.135.57.27";   // update me
            builder.UserID = "sa";              // update me
            builder.Password = "sun@5211314";      // update me
            builder.InitialCatalog = "KTV";
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                String sql = "SELECT * FROM 歌曲";
                SqlDataAdapter mysqlcommand = new SqlDataAdapter(sql, connection);
                DataSet dataSet = new DataSet();
                mysqlcommand.Fill(dataSet, "歌曲排行榜");
                dataGridView1.DataSource = dataSet.Tables["歌曲排行榜"];

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1_songnumber.Text == "" && textBox2_songname.Text == "")
            {
                MessageBox.Show("First fill in the number or name of the song to be deleted!");

            }
            else if (MessageBox.Show("Do you want to delete the song information?", "Tips", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (textBox1_songnumber.Text != "" && textBox2_songname.Text == "")
                {
                    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                    builder.DataSource = "8.135.57.27";   // update me
                    builder.UserID = "sa";              // update me
                    builder.Password = "sun@5211314";      // update me
                    builder.InitialCatalog = "KTV";
                    using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                    {

                        String sql = "DELETE FROM 歌曲 WHERE 歌曲编号 ='" + textBox1_songnumber.Text + "' ";
                        SqlDataAdapter mysqlcommand = new SqlDataAdapter(sql, connection);
                        DataSet dataSet = new DataSet();
                        mysqlcommand.Fill(dataSet, "数字点歌");

                        String sql1 = "DELETE FROM 歌曲排行榜 WHERE 歌曲编号 ='" + textBox1_songnumber.Text + "'";
                        SqlDataAdapter mysqlcommand1 = new SqlDataAdapter(sql1, connection);
                        DataSet dataSet1 = new DataSet();
                        mysqlcommand1.Fill(dataSet1, "数字点歌");

                        MessageBox.Show("delete succeed");

                        String sql2 = "SELECT * FROM 歌曲";
                        SqlDataAdapter mysqlcommand2 = new SqlDataAdapter(sql2, connection);
                        DataSet dataSet2 = new DataSet();
                        mysqlcommand2.Fill(dataSet2, "数字点歌");
                        dataGridView1.DataSource = dataSet.Tables["数字点歌"];




                    }
                }
                else if (textBox1_songnumber.Text == "" && textBox2_songname.Text != "")
                {
                    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                    builder.DataSource = "8.135.57.27";   // update me
                    builder.UserID = "sa";              // update me
                    builder.Password = "sun@5211314";      // update me
                    builder.InitialCatalog = "KTV";
                    using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                    {

                        String sql = "DELETE FROM 歌曲 WHERE 歌曲编号 ='" + textBox1_songnumber.Text + "'or 名称 ='" + textBox2_songname.Text + "' ";
                        SqlDataAdapter mysqlcommand = new SqlDataAdapter(sql, connection);
                        DataSet dataSet = new DataSet();
                        mysqlcommand.Fill(dataSet, "数字点歌");

                        String sql1 = "DELETE FROM 歌曲排行榜 WHERE 歌曲编号 ='" + textBox1_songnumber.Text + "'or 名称 ='" + textBox2_songname.Text + "' "; ;
                        SqlDataAdapter mysqlcommand1 = new SqlDataAdapter(sql1, connection);
                        DataSet dataSet1 = new DataSet();
                        mysqlcommand1.Fill(dataSet1, "数字点歌");

                        MessageBox.Show("delete succeed");

                        String sql2 = "SELECT * FROM 歌曲";
                        SqlDataAdapter mysqlcommand2 = new SqlDataAdapter(sql2, connection);
                        DataSet dataSet2 = new DataSet();
                        mysqlcommand2.Fill(dataSet2, "数字点歌");
                        dataGridView1.DataSource = dataSet1.Tables["数字点歌"];

                    }
                }
                else if (textBox1_songnumber.Text != "" && textBox2_songname.Text != "")
                {
                    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                    builder.DataSource = "8.135.57.27";   // update me
                    builder.UserID = "sa";              // update me
                    builder.Password = "sun@5211314";      // update me
                    builder.InitialCatalog = "KTV";
                    using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                    {

                        String sql = "DELETE FROM 歌曲 WHERE 歌曲编号 ='" + textBox1_songnumber.Text + "'and 名称 ='" + textBox2_songname.Text + "' ";
                        SqlDataAdapter mysqlcommand = new SqlDataAdapter(sql, connection);
                        DataSet dataSet = new DataSet();
                        mysqlcommand.Fill(dataSet, "数字点歌");

                        String sql1 = "DELETE FROM 歌曲排行榜 WHERE 歌曲编号 ='" + textBox1_songnumber.Text + "'and 名称 ='" + textBox2_songname.Text + "' ";
                        SqlDataAdapter mysqlcommand1 = new SqlDataAdapter(sql1, connection);
                        DataSet dataSet1 = new DataSet();
                        mysqlcommand1.Fill(dataSet1, "数字点歌");

                        MessageBox.Show("delete succeed");

                        String sql2 = "SELECT * FROM 歌曲";
                        SqlDataAdapter mysqlcommand2 = new SqlDataAdapter(sql2, connection);
                        DataSet dataSet2 = new DataSet();
                        mysqlcommand2.Fill(dataSet2, "数字点歌");
                        dataGridView1.DataSource = dataSet2.Tables["数字点歌"];

                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "8.135.57.27";   // update me
            builder.UserID = "sa";              // update me
            builder.Password = "sun@5211314";      // update me
            builder.InitialCatalog = "KTV";
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                String sql = "SELECT * FROM 歌曲";
                SqlDataAdapter mysqlcommand = new SqlDataAdapter(sql, connection);
                DataSet dataSet = new DataSet();
                mysqlcommand.Fill(dataSet, "歌曲排行榜");
                dataGridView1.DataSource = dataSet.Tables["歌曲排行榜"];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mybind.EndCurrentEdit();
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "8.135.57.27";   // update me
            builder.UserID = "sa";              // update me
            builder.Password = "sun@5211314";      // update me
            builder.InitialCatalog = "KTV";
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                String sql = "SELECT 歌曲编号,名称,歌手编号,歌手姓名,语种,歌曲拼写 FROM 歌曲";
                SqlDataAdapter mysqlcommand = new SqlDataAdapter(sql, connection);
                SqlCommandBuilder sb = new SqlCommandBuilder(mysqlcommand);
                mysqlcommand.Update(ds, "歌曲");
                if (bianshi == 7) MessageBox.Show("add succeed");
                else if (bianshi == 8) MessageBox.Show("delete succeed");
                else MessageBox.Show("update succeed");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            mybind.Position = 0;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (mybind.Position>0) { mybind.Position -= 1; }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (mybind.Position < this.mybind.Count - 1) { mybind.Position += 1; }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            mybind.Position = mybind.Count - 1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "8.135.57.27";   // update me
            builder.UserID = "sa";              // update me
            builder.Password = "sun@5211314";      // update me
            builder.InitialCatalog = "KTV";
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                String sql = "update 歌曲 set 名称='"  + dataGridView1.CurrentRow.Cells[1].Value + "',歌手编号='" + dataGridView1.CurrentRow.Cells[2].Value + "',歌手姓名='" + dataGridView1 .CurrentRow.Cells[3].Value + "',语种='" + dataGridView1 .CurrentRow.Cells[4].Value +"',歌曲拼写='" + dataGridView1.CurrentRow.Cells[5].Value +"'where 歌曲编号='" + dataGridView1.CurrentRow.Cells[0].Value + "'";
                SqlCommand sqlCommand = new SqlCommand(sql, connection);
                connection.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("moedify succeed");
                connection.Close();

                String sql2 = "SELECT * FROM 歌曲";
                SqlDataAdapter mysqlcommand2 = new SqlDataAdapter(sql2, connection);
                DataSet dataSet2 = new DataSet();
                mysqlcommand2.Fill(dataSet2, "数字点歌");
                dataGridView1.DataSource = dataSet2.Tables["数字点歌"];

            }
        }
    }
}
