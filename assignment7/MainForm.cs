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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrderEdit orderEdit = new OrderEdit();
            orderEdit.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) {
                MessageBox.Show("请先选择一个条件！");
                return;
            }
            string search = comboBox1.SelectedItem.ToString();
            if (search == "订单号")
            {
                var string1 = textBox1.Text.ToString();
                var orders = Program.orderService.QueryByOrderId(string1);
                var displayData = orders
                    .SelectMany(order =>
                        order.Details.Select(detail => new OrderDisplayItem
                        {
                            OrderId = order.OrderId,
                            Customer = order.Customer,
                            ProductName = detail.ProductName,
                            Quantity = detail.Quantity,
                            UnitPrice = detail.UnitPrice
                        })
                    )
                    .ToList();
                dataGridView1.DataSource = displayData;
            }
            else if (search == "顾客名")
            {
                var string1 = textBox1.Text.ToString();
                var orders = Program.orderService.QueryByCustomer(string1);
                var displayData = orders
                    .SelectMany(order =>
                        order.Details.Select(detail => new OrderDisplayItem
                        {
                            OrderId = order.OrderId,
                            Customer = order.Customer,
                            ProductName = detail.ProductName,
                            Quantity = detail.Quantity,
                            UnitPrice = detail.UnitPrice
                        })
                    )
                    .ToList();
                dataGridView1.DataSource = displayData;
            }
            else if (search == "产品名")
            {
                var string1 = textBox1.Text.ToString();
                var orders = Program.orderService.QueryByProductName(string1);
                var displayData = orders
                    .SelectMany(order =>
                        order.Details.Select(detail => new OrderDisplayItem
                        {
                            OrderId = order.OrderId,
                            Customer = order.Customer,
                            ProductName = detail.ProductName,
                            Quantity = detail.Quantity,
                            UnitPrice = detail.UnitPrice
                        })
                    )
                    .ToList();
                dataGridView1.DataSource = displayData;
            }
            else if (search == "全部")
            {
                var orders = Program.orderService.QueryAll(); 
                var displayData = orders
                    .SelectMany(order =>
                        order.Details.Select(detail => new OrderDisplayItem
                        {
                            OrderId = order.OrderId,
                            Customer = order.Customer,
                            ProductName = detail.ProductName,
                            Quantity = detail.Quantity,
                            UnitPrice = detail.UnitPrice
                        })
                    )
                    .ToList();
                dataGridView1.DataSource = displayData;
            }
            else {
                MessageBox.Show("请选择正确的条件！");
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("请先选择一个条件！");
                return;
            }
            string search = comboBox1.SelectedItem.ToString();
            string string1 = textBox1.Text.ToString();
            if (search == "订单号")
            {
                if(!int.TryParse(string1 , out int Id))
                {
                    MessageBox.Show("请输入正确的数据形式！");
                    return;
                }
                Program.orderService.RemoveOrder(string1);
                MessageBox.Show("订单删除成功！");
            }
            else if (search == "顾客名")
            {
                var orders = Program.orderService.QueryByCustomer(string1);
                if (orders.Count == 0) return;
                for(int i = orders.Count - 1; i  >=  0; i--)
                {
                    Program.orderService.RemoveOrder(orders[i].OrderId);
                }
                MessageBox.Show("订单删除成功！");
            }
            else if (search == "产品名")
            {
                var orders = Program.orderService.QueryByProductName(string1);
                if (orders.Count == 0) return;
                for (int i = orders.Count - 1; i >= 0; i--)
                {
                    Program.orderService.RemoveOrder(orders[i].OrderId);
                }
                MessageBox.Show("订单删除成功！");
            }
            else if (search == "全部")
            {
                var orders = Program.orderService.QueryAll();
                if (orders.Count == 0) return;
                for (int i = orders.Count - 1; i >= 0; i--)
                {
                    Program.orderService.RemoveOrder(orders[i].OrderId);
                }
                MessageBox.Show("订单删除成功！");
            }
            else
            {
                MessageBox.Show("请选择正确的条件！");
                return;
            }

        }

        private void orderBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
