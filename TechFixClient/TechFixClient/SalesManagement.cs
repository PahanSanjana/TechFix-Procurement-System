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
using static TechFixClient.SalesManagement;

namespace TechFixClient
{
    public partial class SalesManagement : Form
    {
        public object Sales { get; private set; }
        public SalesManagement()
        {
            InitializeComponent();
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
                dgvSale.DataSource = null;
                dgvSale.DataSource = (new
                                           JavaScriptSerializer()).
                                           Deserialize<List<MySales>>
                                           (sales);

            }
        }

        private void SalesManagement_Load(object sender, EventArgs e)
        {
            LoadSales();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:7088/api/Sale";
            HttpClient client = new HttpClient();
            MySales mySales = new MySales();

            mySales.SaleBy = txtSaleBy.Text;
            mySales.Date = txtDate.Text;
            mySales.Time = txtTime.Text;
            mySales.CustomerName = txtCustomerName.Text;
            mySales.ProductId = Convert.ToInt32(txtProductId.Text);
            mySales.ProductName = txtProductName.Text;
            mySales.Quantity = Convert.ToInt32(txtQuantity.Text);
            mySales.Price = Convert.ToDecimal(txtPrice.Text);
            mySales.Amount = Convert.ToDecimal(txtAmount.Text);
            mySales.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
            mySales.PaymentMethod = txtPaymentMethod.Text;

            string info = (new JavaScriptSerializer()).Serialize(mySales);
            var content = new StringContent(info,
                                           UnicodeEncoding.UTF8,
                                            "application/json");
            var response = client.PostAsync(url, content).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Successfull sale");
                LoadSales();

            }
            else
                MessageBox.Show("sale failed");
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:7088/api/Sale";
            HttpClient httpClient = new HttpClient();
            MySales mySales = new MySales();
            mySales.Id = Convert.ToInt32(txtId.Text);
            mySales.SaleBy = txtSaleBy.Text;
            mySales.Date = txtDate.Text;
            mySales.Time = txtTime.Text;
            mySales.CustomerName = txtCustomerName.Text;
            mySales.ProductId = Convert.ToInt32(txtProductId.Text);
            mySales.ProductName = txtProductName.Text;
            mySales.Quantity = Convert.ToInt32(txtQuantity.Text);
            mySales.Price = Convert.ToDecimal(txtPrice.Text);
            mySales.Amount = Convert.ToDecimal(txtAmount.Text);
            mySales.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
            mySales.PaymentMethod = txtPaymentMethod.Text;

            string info = (new JavaScriptSerializer()).Serialize(mySales);
            var content = new StringContent(info,
                                           UnicodeEncoding.UTF8,
                                            "application/json");
            var response = httpClient.PutAsync(url, content).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Successfull sale update");
                LoadSales();

            }
            else
                MessageBox.Show("sale update failed");


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string code = txtId.Text;
            string url = "https://localhost:7088/api/Sale/id?id="+code;
            HttpClient httpClient = new HttpClient();
            var resTask = httpClient.GetAsync(url);
            resTask.Wait();
            var results = resTask.Result;
            if (results.IsSuccessStatusCode)
            {
                var readTask = results.Content.ReadAsStringAsync();
                resTask.Wait();
                var sale = readTask.Result;

                MySales sales = (new
                                           JavaScriptSerializer()).
                                           Deserialize<MySales>
                                           (sale);
                txtId.Text = sales.Id.ToString();
                txtSaleBy.Text = sales.SaleBy;
                txtDate.Text = sales.Date;
                txtTime.Text = sales.Time;
                txtCustomerName.Text = sales.CustomerName;
                txtProductId.Text = sales.ProductId.ToString();
                txtProductName.Text = sales.ProductName;
                txtQuantity.Text = sales.Quantity.ToString();
                txtPrice.Text = sales.Price.ToString();
                txtAmount.Text = sales.Amount.ToString();
                txtTotalAmount.Text = sales.TotalAmount.ToString();
                txtPaymentMethod.Text = sales.PaymentMethod;



            }
        }

        private void dgvSale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                txtId.Text = dgvSale.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSaleBy.Text = dgvSale.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDate.Text = dgvSale.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtTime.Text = dgvSale.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtCustomerName.Text = dgvSale.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtProductId.Text = dgvSale.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtProductName.Text = dgvSale.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtQuantity.Text = dgvSale.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtPrice.Text = dgvSale.Rows[e.RowIndex].Cells[10].Value.ToString();
                txtAmount.Text = dgvSale.Rows[e.RowIndex].Cells[11].Value.ToString();
                txtTotalAmount.Text = dgvSale.Rows[e.RowIndex].Cells[12].Value.ToString();
                txtPaymentMethod.Text = dgvSale.Rows[e.RowIndex].Cells[13].Value.ToString();
            }
            else if (e.ColumnIndex == 1)
            {
                string code= txtId.Text = dgvSale.Rows[e.RowIndex].Cells[2].Value.ToString();
                string url = "https://localhost:7088/api/Sale/"+code;
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
                        LoadSales();
                    }
                }

            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    public class MySales
    {

        public int Id { get; set; }

        public string SaleBy { get; set; }

        public string Date { get; set; }

        public string Time { get; set; }

        public string CustomerName { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal Amount { get; set; }

        public decimal TotalAmount { get; set; }

        public string PaymentMethod { get; set; }
    }
}
