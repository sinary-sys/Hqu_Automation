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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            signin signin = new signin();
            signin.Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        { // Build connection string
            int num = 0;
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "8.135.57.27";   // update me
            builder.UserID = "sa";              // update me
            builder.Password = "sun@5211314";      // update me
            builder.InitialCatalog = "KTV";
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {

                String sql = "select max(会员编号) from 用户";

                SqlDataAdapter mydatapter = new SqlDataAdapter(sql, connection);
                DataSet mydataset = new DataSet();
                mydatapter.Fill(mydataset, "最大编号");
                if (mydataset.Tables["最大编号"].Rows[0].IsNull(0))
                {
                    num = 10000;
                    
                }
                else
                {
                    num = mydataset.Tables["最大编号"].Rows[0].ItemArray.Length+ 1;
                }
                if (textBox1_username.Text == "" || textBox2_passage.Text == "" || textBox3_birthday.Text == "" ||
                    idnumber.Text == "")
                {
                    textBox1_username.Text = "";
                    textBox2_passage.Text = "";
                    textBox3_birthday.Text = "";
                    idnumber.Text = "";
                    MessageBox.Show("login has failed");
                }
                else if (textBox1_username.Text.Length > 10) { MessageBox.Show("The user name cannot be more than ten digits"); }
                else if (textBox2_passage.Text.Length > 15) { MessageBox.Show("The passage cannot be more than fifteen digits"); }
                else if (textBox3_birthday.Text.Length != 8) { MessageBox.Show("The date of birth should be 8 digits"); }
                else if (idnumber.Text.Length != 18) { MessageBox.Show("The ID card number should be 18."); }
                else {

                    String sql1 = "insert into 用户 (会员用户名,密码,会员性别,出生日期,身份证号,注册时间,会员编号,积分) values ('" + textBox1_username.Text + "','" + textBox2_passage.Text + "','" + comboBox1_sex.SelectedItem + "','" + textBox3_birthday.Text + "','" + idnumber.Text + "',GETDATE(),'"+ num +" ','0')";
                    SqlCommand sqlCommand = new SqlCommand(sql1,connection);
                    connection.Open();
                    sqlCommand.ExecuteNonQuery();
                    textBox1_username.Text = "";
                    textBox2_passage.Text = "";
                    textBox3_birthday.Text = "";
                    idnumber.Text = "";
                    connection.Close();
                    MessageBox.Show("login was successful");


                }


            }





        }
    }
}
