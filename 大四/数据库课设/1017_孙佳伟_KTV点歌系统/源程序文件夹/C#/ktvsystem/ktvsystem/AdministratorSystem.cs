using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ktvsystem
{
    public partial class AdministratorSystem : Form
    {
        public AdministratorSystem()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            signin signin = new signin();
            signin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SongManagement songManagement = new SongManagement();
            songManagement.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Memberinformation memberinformation = new Memberinformation();
            memberinformation.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administratorchangespassword administratorchangespassword = new Administratorchangespassword();
            administratorchangespassword.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            membermanagement membermanagement = new membermanagement();
            membermanagement.Show();
        }

        private void AdministratorSystem_Load(object sender, EventArgs e)
        {

        }
    }
}
