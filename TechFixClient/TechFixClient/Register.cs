using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace TechFixClient
{
    public partial class Register : Form
    {
        public object Users { get; private set; }
        public Register()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblRLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }

        private void btnRrgister_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:7088/api/User";
            HttpClient client = new HttpClient();
            MyUsers myUsers = new MyUsers();


            myUsers.Type=txtUsername.Text;
            myUsers.Location = txtLocation.Text;
            
             myUsers.Password=txtPassword.Text;
            myUsers.ConfirmPassword = txtConfirmPassword.Text;

            string info = (new JavaScriptSerializer()).Serialize(myUsers);
            var content = new StringContent(info,
                                           UnicodeEncoding.UTF8,
                                            "application/json");
            var response = client.PostAsync(url, content).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Registered successfully, log in through log in page or Click Log In");
                

            }
            else
                MessageBox.Show("Registration failed,Check your details");


        }
    }
    public class MyUsers
    {
        
        public int Id { get; set; }
       
        public string Type { get; set; }
        
        public string Location { get; set; }
        
        

        
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
