using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace WinFormsApp1
{
    public partial class OrderEdit : Form
    {
        public OrderEdit()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var string1 = OrderId.Text;
            var string2 = Customer.Text;
            var string3 = Product.Text;
            var string4 = Quantity.Text;
            var string5 = Price.Text;
            if(!int.TryParse(string1, out int orderid) || !int.TryParse(string4, out int quantity) || !decimal.TryParse(string5, out decimal price))
            {
                MessageBox.Show("请输入正确的数据形式！");
                return;
            }
            var order = new Order();
            order.OrderId = string1;
            order.Customer = string2;
            var details = new OrderDetails();
            details.ProductName = string3;
            details.Quantity = quantity;
            details.UnitPrice = price;
            order.Details.Add(details);
            Program.orderService.AddOrder(order);
            MessageBox.Show("订单添加成功！");
            OrderId.Clear();    
            Customer.Clear();
            Product.Clear();    
            Quantity.Clear();
            Price.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var string1 = OrderId.Text;
            var string2 = Customer.Text;
            var string3 = Product.Text;
            var string4 = Quantity.Text;
            var string5 = Price.Text;
            if (!int.TryParse(string1, out int orderid) || !int.TryParse(string4, out int quantity) || !decimal.TryParse(string5, out decimal price))
            {
                MessageBox.Show("请输入正确的数据形式！");
                return;
            }
            var order = new Order();
            order.OrderId = string1;
            order.Customer = string2;
            var details = new OrderDetails();
            details.ProductName = string3;
            details.Quantity = quantity;
            details.UnitPrice = price;
            order.Details.Add(details);
            Program.orderService.UpdateOrder(order);
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
