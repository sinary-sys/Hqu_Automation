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
    public partial class Administratorchangespassword : Form
    {
        int n = 0;
        public Administratorchangespassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "8.135.57.27";   // update me
            builder.UserID = "sa";              // update me
            builder.Password = "sun@5211314";      // update me
            builder.InitialCatalog = "KTV";
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                String sql = "select * from 管理员 where 管理名='" + textBox1_account.Text + "'and 密码='" + textBox2_old.Text + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, connection);
                DataSet mydataset = new DataSet();
                sqlDataAdapter.Fill(mydataset, "密码更改1");
                if (mydataset.Tables["密码更改1"].Rows.Count == 0)
                {
                    n += 1;
                    if (n < 3)
                    {
                        MessageBox.Show("Wrong user name or password！");
                        textBox1_account.Text = "";
                        textBox2_old.Text = "";
                        textBox3_new.Text = "";
                        textBox1_account.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Login failed 3 times! Exit the system");
                        this.Close();

                    }
                }
                else
                {
                    sql = "update 管理员 set 密码='" + textBox3_new.Text + "'where 管理名='" + textBox1_account.Text + "'";
                    SqlCommand sqlCommand = new SqlCommand(sql, connection);
                    connection.Open();
                    sqlCommand.ExecuteNonQuery();
                    
                    connection.Close();
                    
                    MessageBox.Show("modification succeed");
                }


            }
        }
    

    private void button2_Click(object sender, EventArgs e)
    {
        this.Close();
        AdministratorSystem administratorSystem = new AdministratorSystem();
        administratorSystem.Show();
    }
}
   
}
