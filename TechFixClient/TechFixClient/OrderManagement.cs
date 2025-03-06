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
    public partial class OrderManagement : Form
    {
        public object Orders { get; private set; }
        public OrderManagement()
        {
            InitializeComponent();
        }

        private void OrderManagement_Load(object sender, EventArgs e)
        {

        }

       

        private void LoadOrders()
        {
            string url = "https://localhost:7088/api/Order";
            HttpClient httpClient = new HttpClient();
            var resTask = httpClient.GetAsync(url);
            resTask.Wait();
            var results = resTask.Result;
            if (results.IsSuccessStatusCode)
            {
                var readTask = results.Content.ReadAsStringAsync();
                resTask.Wait();
                var orders = readTask.Result;
                dgvOrder.DataSource = null;
                dgvOrder.DataSource = (new
                                           JavaScriptSerializer()).
                                           Deserialize<List<MyOrders>>
                                           (orders);

            }
        }


        private void btnOUpdate_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:7088/api/Order";
            HttpClient httpClient = new HttpClient();
            MyOrders myOrders = new MyOrders();
            myOrders.Id = Convert.ToInt32(txtOId.Text);
            myOrders.ProductName=txtOProductName.Text;
            myOrders.Quantity = Convert.ToInt32(txtOQuantity.Text);
            myOrders.CustomerName = txtOCustomerName.Text;
            myOrders.DateOfOrder = txtODateOfOrder.Text;
            myOrders.DateOfDelivery = txtODeliveryOn.Text;
            myOrders.OrderStatus = txtOrderStatus.Text;
            myOrders.DeliveryLocation = txtODeliveryLocation.Text;

            string info = (new JavaScriptSerializer()).Serialize(myOrders);
            var content = new StringContent(info,
                                           UnicodeEncoding.UTF8,
                                            "application/json");
            var response = httpClient.PutAsync(url, content).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Order status successfull updated");
                LoadOrders();

            }
            else
                MessageBox.Show("Order status update failed");

        }

        private void OrderManagement_Load_1(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadOrders();
           

        }

        private void btnHOSearch_Click(object sender, EventArgs e)
        {
            string code = txtOId.Text;
            string url = "https://localhost:7088/api/Order/id?id=" + code;
            HttpClient httpClient = new HttpClient();
            var resTask = httpClient.GetAsync(url);
            resTask.Wait();
            var results = resTask.Result;
            if (results.IsSuccessStatusCode)
            {
                var readTask = results.Content.ReadAsStringAsync();
                resTask.Wait();
                var order = readTask.Result;

                MyOrders orders = (new
                                           JavaScriptSerializer()).
                                           Deserialize<MyOrders>
                                           (order);
                txtOId.Text = orders.Id.ToString();
                txtOProductName.Text = orders.ProductName;
                txtOQuantity.Text = orders.Quantity.ToString();
                txtOCustomerName.Text= orders.CustomerName;
                txtODateOfOrder.Text = orders.DateOfOrder;
                txtODeliveryOn.Text = orders.DateOfDelivery;
                txtOrderStatus.Text = orders.OrderStatus;
                txtODeliveryLocation.Text = orders.DeliveryLocation;

            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Close();
        }
    }
}
