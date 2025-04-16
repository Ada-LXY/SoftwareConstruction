namespace WinFormsApp1
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            groupBox2 = new GroupBox();
            btnEdit = new Button();
            btnDelete = new Button();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            btnSearch = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            orderDisplayItemBindingSource = new BindingSource(components);
            OrderId = new DataGridViewTextBoxColumn();
            Customer = new DataGridViewTextBoxColumn();
            Product = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderDisplayItemBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnEdit);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 378);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(794, 69);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(309, 26);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 5;
            btnEdit.Text = " 编辑订单";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += button2_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(672, 27);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "删除订单";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(794, 69);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "订单号", "顾客名", "产品名", "全部" });
            comboBox1.Location = new Point(9, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(198, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(325, 27);
            textBox1.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(557, 27);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "查询订单";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 2);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 74F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { OrderId, Customer, Product, Quantity, Price, UnitPrice });
            dataGridView1.DataSource = orderDisplayItemBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(794, 294);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // orderDisplayItemBindingSource
            // 
            orderDisplayItemBindingSource.DataSource = typeof(ClassLibrary.OrderDisplayItem);
            // 
            // OrderId
            // 
            OrderId.DataPropertyName = "OrderId";
            OrderId.HeaderText = "订单号";
            OrderId.MinimumWidth = 6;
            OrderId.Name = "OrderId";
            OrderId.Width = 83;
            // 
            // Customer
            // 
            Customer.DataPropertyName = "Customer";
            Customer.HeaderText = "顾客名";
            Customer.MinimumWidth = 6;
            Customer.Name = "Customer";
            Customer.Width = 83;
            // 
            // Product
            // 
            Product.DataPropertyName = "ProductName";
            Product.HeaderText = "产品名";
            Product.MinimumWidth = 6;
            Product.Name = "Product";
            Product.Width = 83;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "数量";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 83;
            // 
            // Price
            // 
            Price.DataPropertyName = "UnitPrice";
            Price.HeaderText = "单价";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 83;
            // 
            // UnitPrice
            // 
            UnitPrice.DataPropertyName = "TotalPrice";
            UnitPrice.HeaderText = "总价";
            UnitPrice.MinimumWidth = 6;
            UnitPrice.Name = "UnitPrice";
            UnitPrice.ReadOnly = true;
            UnitPrice.Width = 83;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "MainForm";
            Text = "Form1";
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderDisplayItemBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private Button btnEdit;
        private Button btnDelete;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button btnSearch;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn OrderId;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn UnitPrice;
        private BindingSource orderDisplayItemBindingSource;
    }
}