using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechFixClient
{
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblLRegister_Click(object sender, EventArgs e)
        {
            Register register= new Register();
            register.Show();    
            this.Close();   
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "HeadOffice" && password == "sanjana")
            {
                HeadOfficeHome headOfficeHome = new HeadOfficeHome();
                headOfficeHome.Show();
                this.Close();
            }
            else
            {
                using (SqlConnection connection = new SqlConnection("Server=Lenovo\\SQLEXPRESS;Database=TechFix_Database;Integrated Security=True;TrustServerCertificate=Yes"))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT COUNT(*) FROM Users WHERE Type = @type AND Password = @password";

                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@type", username);
                            cmd.Parameters.AddWithValue("@password", password);

                            int count = (int)cmd.ExecuteScalar();
                            if (count > 0)
                            {
                                Home home = new Home();
                                home.Show();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Database connection error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


        }




    }

}
