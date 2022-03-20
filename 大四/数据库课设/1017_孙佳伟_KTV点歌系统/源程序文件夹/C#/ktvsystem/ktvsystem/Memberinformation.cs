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
    public partial class Memberinformation : Form
    {
        public Memberinformation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1_numbermember.Text == "" && textBox2_numbermembername.Text == "" && idnumber.Text == "")
            {

                // Build connection string
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "8.135.57.27";   // update me
                builder.UserID = "sa";              // update me
                builder.Password = "sun@5211314";      // update me
                builder.InitialCatalog = "KTV";
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    String sql = "SELECT * FROM 用户";
                    SqlDataAdapter myadapter = new SqlDataAdapter(sql, connection);
                    DataSet mydataset = new DataSet();
                    myadapter.Fill(mydataset, "用户");
                    dataGridView1.DataSource = mydataset.Tables["用户"];
                }
            }
            else {
                // Build connection string
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "8.135.57.27";   // update me
                builder.UserID = "sa";              // update me
                builder.Password = "sun@5211314";      // update me
                builder.InitialCatalog = "KTV";
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    String sql = "SELECT * FROM 用户 where 会员编号='" + textBox1_numbermember.Text + "'or 会员用户名='" +textBox2_numbermembername.Text + "'or 身份证号='" +idnumber.Text + "'";

                    SqlDataAdapter myadapter = new SqlDataAdapter(sql, connection);
                    DataSet mydataset = new DataSet();
                    myadapter.Fill(mydataset, "用户");
                    dataGridView1.DataSource = mydataset.Tables["用户"];
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            AdministratorSystem administratorSystem = new AdministratorSystem();
            administratorSystem.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Build connection string
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "8.135.57.27";   // update me
            builder.UserID = "sa";              // update me
            builder.Password = "sun@5211314";      // update me
            builder.InitialCatalog = "KTV";
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                String sql = "SELECT * FROM 用户";
                SqlDataAdapter myadapter = new SqlDataAdapter(sql, connection);
                DataSet mydataset = new DataSet();
                myadapter.Fill(mydataset, "用户");
                DataRow _row =mydataset.Tables["用户"].NewRow();
                _row[0] = dataGridView1.CurrentRow.Cells[0].Value;
                _row[1] = dataGridView1.CurrentRow.Cells[1].Value;
                _row[2] = dataGridView1.CurrentRow.Cells[2].Value;
                _row[3] = dataGridView1.CurrentRow.Cells[3].Value;
                _row[4] = dataGridView1.CurrentRow.Cells[4].Value;
                _row[5] = dataGridView1.CurrentRow.Cells[5].Value;
                _row[6] = dataGridView1.CurrentRow.Cells[6].Value;
                _row[7] = dataGridView1.CurrentRow.Cells[7].Value;
                string sql1 = "select * from 用户 where 会员用户名='" + dataGridView1.CurrentRow.Cells[1] + "'";
                SqlDataAdapter myadapt1 = new SqlDataAdapter(sql1,connection);
                DataSet mydataset1 = new DataSet();
                myadapt1.Fill(mydataset1,"用户重复");
                if (mydataset1.Tables["用户重复"].Rows.Count <= 0)
                {
                    if (dataGridView1.CurrentRow.Cells[1].Value == null && dataGridView1.CurrentRow.Cells[0].Value == null||true)
                    {
                        MessageBox.Show("add mumeber succeed");
                        mydataset.Tables["用户"].Rows.Add(_row);
                        SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(myadapter);
                        myadapter.Update(mydataset, "用户");
                    }
                    else
                    {
                        MessageBox.Show("The number and user name cannot be empty");
                    }                
                }
                else {
                    MessageBox.Show("Failed to add repeatedly");
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
                String sql = "delete from 用户 where 会员编号='" + dataGridView1.CurrentRow.Cells[0].Value + "'";
                SqlCommand sqlCommand = new SqlCommand(sql,connection);
                connection.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("delete succeed");
                connection.Close();
                sql = "select * from 用户";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql,connection);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "用户");
                dataGridView1.DataSource = dataSet.Tables["用户"];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "8.135.57.27";   // update me
            builder.UserID = "sa";              // update me
            builder.Password = "sun@5211314";      // update me
            builder.InitialCatalog = "KTV";
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                String sql = "update 用户 set 会员用户名='" + dataGridView1.CurrentRow.Cells[1].Value  + "',会员性别='" + dataGridView1.CurrentRow.Cells[2].Value + "',出生日期='" + dataGridView1.CurrentRow.Cells[3].Value + "',身份证号='" + dataGridView1.CurrentRow.Cells[4].Value + "',注册时间='"  + dataGridView1.CurrentRow.Cells[5].Value + "',积分='" + dataGridView1.CurrentRow.Cells[6].Value + "',密码='" + dataGridView1.CurrentRow.Cells[7].Value + "'where 会员编号='" + dataGridView1.CurrentRow.Cells[0].Value + "'";
                SqlCommand sqlCommand = new SqlCommand(sql, connection);
                connection.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("modify succeed");
                connection.Close();
                sql = "select * from 用户";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, connection);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "用户");
                dataGridView1.DataSource = dataSet.Tables["用户"];
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
