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
    
    public partial class signin : Form
    {   
        int n = 0;
        public string user = "";

        public signin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                //弹出消息框，并获取消息框的返回值
                DialogResult dr = MessageBox.Show("Whether to close the KTVsystem or not", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //如果消息框返回值是Yes，显示新窗体
                if (dr == DialogResult.Yes)
                {//关闭当前窗体
                    this.Close();
                RequestSong requestSong = new RequestSong();
                requestSong.Close();
                AdministratorSystem administratorSystem = new AdministratorSystem();
                administratorSystem.Close();
                signup signup = new signup();
                signup.Close();
                SongManagement songManagement = new SongManagement();
                songManagement.Close();
                }
                //如果消息框返回值是No，关闭当前窗体
                else if (dr == DialogResult.No)
                {
                    //关闭当前窗体

                }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {           
            try
            {
                // Build connection string
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "8.135.57.27";   // update me
                builder.UserID = "sa";              // update me
                builder.Password = "sun@5211314";      // update me
                builder.InitialCatalog = "KTV";
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {                    
                    String sql = "select * from 用户 where 会员用户名='" + TextBox_username.Text + "'and 密码='" + textBox2_passage.Text + "'";                    
                    SqlDataAdapter mydatapter = new SqlDataAdapter(sql, connection);
                    DataSet mydataset = new DataSet();
                    mydatapter.Fill(mydataset,"用户");
                    if (mydataset.Tables["用户"].Rows.Count == 0)
                    {
                        n += 1;
                        if (n < 3)
                        {
                            MessageBox.Show("用户名或密码错误！");
                            TextBox_username.Text = "";
                            textBox2_passage.Text = "";
                            TextBox_username.Focus();
                        }
                        else
                        {
                            MessageBox.Show("已登入失败3次！退出系统");
                            this.Close();

                        }
                    }
                    else {
                        user = TextBox_username.Text;
                        MessageBox.Show("欢迎光临！");
                        this.Hide();
                       
                        n = 0;
                        RequestSong requestSong = new RequestSong();
                        requestSong.Show();
                    }                                                                              
                }                   
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库连接失败！" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            signup signup = new signup();
            signup.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Build connection string
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "8.135.57.27";   // update me
                builder.UserID = "sa";              // update me
                builder.Password = "sun@5211314";      // update me
                builder.InitialCatalog = "KTV";
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {

                    String sql = "select * from 管理员 where 管理名='" + textBox_account.Text + "'and 密码='" + textBox4_passage.Text + "'";

                    SqlDataAdapter mydatapter = new SqlDataAdapter(sql, connection);
                    DataSet mydataset = new DataSet();
                    mydatapter.Fill(mydataset, "管理员登录表");
                    if (mydataset.Tables["管理员登录表"].Rows.Count == 0)
                    {
                        n += 1;
                        if (n < 3)
                        {
                            MessageBox.Show("用户名或密码错误！");
                            textBox_account.Text = "";
                            textBox4_passage.Text = "";
                            textBox_account.Focus();
                        }
                        else
                        {
                            MessageBox.Show("已登入失败3次！退出系统");
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("欢迎光临！");
                        this.Hide();
                       
                        n = 0;
                        AdministratorSystem administratorSystem = new AdministratorSystem();
                        administratorSystem.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库连接失败！" + ex.Message);
            }
        }

        private void signin_Load(object sender, EventArgs e)
        {
            
        }

        private void TextBox_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
