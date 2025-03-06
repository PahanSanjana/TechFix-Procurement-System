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
    public partial class Order : Form
    {
        public object Orders { get; private set; }

        public Order()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOAdd_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:7088/api/Order";
            HttpClient client = new HttpClient();
            MyOrders myOrders = new MyOrders();


            myOrders.ProductName = txtOProductName.Text;
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
            var response = client.PostAsync(url, content).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Ordered successfully");
                

            }
            else
                MessageBox.Show("order failed");

        }

        private void btnOSearch_Click(object sender, EventArgs e)
        {
            string code = txtOId.Text;
            string url = "https://localhost:7088/api/Order/id?id="+code;
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
                txtOrderStatus.Text = orders.OrderStatus;

            }
            
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Close();

        }
    }
    public class MyOrders
    {
        
        public int Id { get; set; }
        
        public string ProductName { get; set; }
        
        public int Quantity { get; set; }
        
        public string CustomerName { get; set; }
        
        public string DateOfOrder { get; set; }
        
        public string DateOfDelivery { get; set; }
        
        public string OrderStatus { get; set; }
        
        public string DeliveryLocation { get; set; }


    }

}
