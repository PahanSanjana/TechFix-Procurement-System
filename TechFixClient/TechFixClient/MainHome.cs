using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechFixClient
{
    public partial class MainHome : Form
    {
        public MainHome()
        {
            InitializeComponent();
        }

        private void MainHome_Load(object sender, EventArgs e)
        {

        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
           

        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show(); 
           


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
