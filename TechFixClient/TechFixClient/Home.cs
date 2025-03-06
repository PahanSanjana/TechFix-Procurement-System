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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manageStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockManagement stockManagement= new StockManagement();
            stockManagement.Show();
            
        }

        private void manageSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesManagement salesManagement= new SalesManagement();
            salesManagement.Show();
            
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order order= new Order();   
            order.Show();
            
        }
    }
}
