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
    public partial class HeadOfficeHome : Form
    {
        public HeadOfficeHome()
        {
            InitializeComponent();
        }

        private void HeadOfficeHome_Load(object sender, EventArgs e)
        {

        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderManagement orderManagement= new OrderManagement();
            orderManagement.Show();
            
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockManagement stockManagement= new StockManagement();
            stockManagement.Show();
            
            
        }

        private void salesDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesDetails salesDetails= new SalesDetails();
            salesDetails.Show();
           
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
