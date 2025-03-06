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
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace TechFixClient
{
    public partial class StockManagement : Form
    {
        public object Products { get; private set; }
        public StockManagement()
        {
            InitializeComponent();
        }



        private void LoadProducts()
        {
            string url = "https://localhost:7088/api/Product";
            HttpClient httpClient = new HttpClient();
            var resTask = httpClient.GetAsync(url);
            resTask.Wait();
            var results = resTask.Result;
            if (results.IsSuccessStatusCode)
            {
                var readTask = results.Content.ReadAsStringAsync();
                resTask.Wait();
                var products = readTask.Result;
                dgvProducts.DataSource = null;
                dgvProducts.DataSource = (new
                                           JavaScriptSerializer()).
                                           Deserialize<List<MyProducts>>
                                           (products);

            }
        }

        private void btnHSAdd_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:7088/api/Product";
            HttpClient client = new HttpClient();
            MyProducts myProducts = new MyProducts();
            
            myProducts.Name = txtHSName.Text;
            myProducts.Price = Convert.ToDecimal(txtHSPrice.Text);
            myProducts.Category = txtHSCategory.Text;
            myProducts.Description = txtHSDescription.Text;
            myProducts.Stock = Convert.ToInt32(txtHSStock.Text);

            string info = (new JavaScriptSerializer()).Serialize(myProducts);
            var content = new StringContent(info,
                                           UnicodeEncoding.UTF8,
                                            "application/json");
            var response = client.PostAsync(url, content).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Product Added");
                LoadProducts();

            }
            else
                MessageBox.Show("Fail to add product");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:7088/api/Product";
            HttpClient httpClient = new HttpClient();
            MyProducts myProducts = new MyProducts();
            myProducts.Code = Convert.ToInt32(txtHSId.Text);
            myProducts.Name = txtHSName.Text;
            myProducts.Price = Convert.ToDecimal(txtHSPrice.Text);
            myProducts.Category = txtHSCategory.Text;
            myProducts.Description = txtHSDescription.Text;
            myProducts.Stock = Convert.ToInt32(txtHSStock.Text);

            string info = (new JavaScriptSerializer()).Serialize(myProducts);
            var content = new StringContent(info,
                                           UnicodeEncoding.UTF8,
                                            "application/json");
            var response = httpClient.PutAsync(url, content).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Product Updated");
                LoadProducts();
            }
            else
                MessageBox.Show("Fail to update product");
        }

        private void StockManagement_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnHSSearch_Click(object sender, EventArgs e)
        {
            string code = txtHSId.Text;
            string url = "https://localhost:7088/api/Product/code?code=" + code;

            HttpClient httpClient = new HttpClient();
            var resTask = httpClient.GetAsync(url);
            resTask.Wait();
            var results = resTask.Result;
            if (results.IsSuccessStatusCode)
            {
                var readTask = results.Content.ReadAsStringAsync();
                resTask.Wait();
                var product = readTask.Result;

                MyProducts products = (new
                                           JavaScriptSerializer()).
                                           Deserialize<MyProducts>
                                           (product);
                txtHSId.Text = products.Code.ToString();
                txtHSName.Text = products.Name;
                txtHSPrice.Text = products.Price.ToString();
                txtHSCategory.Text = products.Category;
                txtHSDescription.Text = products.Description;
                txtHSStock.Text = products.Stock.ToString();
            }
        }

        private void dgvProducts_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0)
            {
                txtHSId.Text = dgvProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtHSName.Text = dgvProducts.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtHSPrice.Text = dgvProducts.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtHSCategory.Text = dgvProducts.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtHSDescription.Text = dgvProducts.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtHSStock.Text = dgvProducts.Rows[e.RowIndex].Cells[7].Value.ToString();

            }
            else if (e.ColumnIndex == 1)
            {
                string code = txtHSId.Text = dgvProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
                string url = "https://localhost:7088/api/Product/" + code;
                HttpClient httpClient = new HttpClient();
                DialogResult result = MessageBox.Show("Are you sure, you want to dealete?",
                                                        "Confirm Delete!",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var res = httpClient.DeleteAsync(url).Result;
                    if (res.IsSuccessStatusCode)
                    {
                        LoadProducts();
                    }
                }
            }
        }

        private void StockManagement_Load_1(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    public class MyProducts
        {
            public int Code { get; set; }

            public string Name { get; set; }

            public decimal Price { get; set; }

            public string Category { get; set; }
            public string Description { get; set; }

            public int Stock { get; set; }
        }
    
}
