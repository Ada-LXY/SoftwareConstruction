namespace WinFormsApp1
{
    partial class OrderEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            Customer = new TextBox();
            Product = new TextBox();
            btnEdit = new Button();
            btnFalse = new Button();
            btnAdd = new Button();
            Price = new TextBox();
            Quantity = new TextBox();
            OrderId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Customer);
            groupBox1.Controls.Add(Product);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnFalse);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(Price);
            groupBox1.Controls.Add(Quantity);
            groupBox1.Controls.Add(OrderId);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(794, 444);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Customer
            // 
            Customer.Location = new Point(201, 83);
            Customer.Name = "Customer";
            Customer.Size = new Size(247, 27);
            Customer.TabIndex = 16;
            // 
            // Product
            // 
            Product.Location = new Point(201, 146);
            Product.Name = "Product";
            Product.Size = new Size(247, 27);
            Product.TabIndex = 15;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(277, 395);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "修改订单";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnFalse
            // 
            btnFalse.Location = new Point(497, 395);
            btnFalse.Name = "btnFalse";
            btnFalse.Size = new Size(94, 29);
            btnFalse.TabIndex = 13;
            btnFalse.Text = "取消";
            btnFalse.UseVisualStyleBackColor = true;
            btnFalse.Click += btnFalse_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(61, 395);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "添加订单";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Price
            // 
            Price.Location = new Point(201, 281);
            Price.Name = "Price";
            Price.Size = new Size(247, 27);
            Price.TabIndex = 9;
            // 
            // Quantity
            // 
            Quantity.Location = new Point(201, 213);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(247, 27);
            Quantity.TabIndex = 8;
            // 
            // OrderId
            // 
            OrderId.Location = new Point(201, 20);
            OrderId.Name = "OrderId";
            OrderId.Size = new Size(247, 27);
            OrderId.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 281);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 4;
            label5.Text = "单价：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 213);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 3;
            label4.Text = "数量：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 146);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "产品名：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 83);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 1;
            label2.Text = "顾客姓名：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 23);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "订单号：";
            // 
            // OrderEdit
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "OrderEdit";
            Text = "EditOrder";
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox Price;
        private TextBox Quantity;
        private TextBox OrderId;
        private Label label5;
        private Label label4;
        private Button btnFalse;
        private Button btnAdd;
        private Button btnEdit;
        private TextBox Product;
        private TextBox Customer;
    }
}