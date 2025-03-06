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
    public partial class SalesDetails : Form
    {
        public object Sales { get; private set; }
        public SalesDetails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LoadSales()
        {
            string url = "https://localhost:7088/api/Sale";
            HttpClient httpClient = new HttpClient();
            var resTask = httpClient.GetAsync(url);
            resTask.Wait();
            var results = resTask.Result;
            if (results.IsSuccessStatusCode)
            {
                var readTask = results.Content.ReadAsStringAsync();
                resTask.Wait();
                var sales = readTask.Result;
                dgvHSale.DataSource = null;
                dgvHSale.DataSource = (new
                                           JavaScriptSerializer()).
                                           Deserialize<List<MySales>>
                                           (sales);

            }
        }
        private void dgvHSale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadSales();
        }

        private void SalesDetails_Load(object sender, EventArgs e)
        {
            LoadSales();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
