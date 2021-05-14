
namespace OrderForm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FunctionGrp = new System.Windows.Forms.GroupBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.ExportBtn = new System.Windows.Forms.Button();
            this.queryDetail = new System.Windows.Forms.Button();
            this.ImportBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.changeBtn = new System.Windows.Forms.Button();
            this.QueryGrp = new System.Windows.Forms.GroupBox();
            this.queryStrlab = new System.Windows.Forms.Label();
            this.queryStrtextBox = new System.Windows.Forms.TextBox();
            this.queryTypelab = new System.Windows.Forms.Label();
            this.queryBtn = new System.Windows.Forms.Button();
            this.queryTypeCombox = new System.Windows.Forms.ComboBox();
            this.OrderDetailGrp = new System.Windows.Forms.GroupBox();
            this.orderDetailDataGridView = new System.Windows.Forms.DataGridView();
            this.itemStoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDetails = new System.Windows.Forms.BindingSource(this.components);
            this.OrderGrp = new System.Windows.Forms.GroupBox();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orders = new System.Windows.Forms.BindingSource(this.components);
            this.ExportOrdersSDLG = new System.Windows.Forms.SaveFileDialog();
            this.ImportOrdersODLG = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.FunctionGrp.SuspendLayout();
            this.QueryGrp.SuspendLayout();
            this.OrderDetailGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetails)).BeginInit();
            this.OrderGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orders)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FunctionGrp);
            this.panel1.Controls.Add(this.QueryGrp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1219, 201);
            this.panel1.TabIndex = 0;
            // 
            // FunctionGrp
            // 
            this.FunctionGrp.Controls.Add(this.Addbtn);
            this.FunctionGrp.Controls.Add(this.ExportBtn);
            this.FunctionGrp.Controls.Add(this.queryDetail);
            this.FunctionGrp.Controls.Add(this.ImportBtn);
            this.FunctionGrp.Controls.Add(this.deleteBtn);
            this.FunctionGrp.Controls.Add(this.changeBtn);
            this.FunctionGrp.Location = new System.Drawing.Point(322, 19);
            this.FunctionGrp.Name = "FunctionGrp";
            this.FunctionGrp.Size = new System.Drawing.Size(257, 176);
            this.FunctionGrp.TabIndex = 11;
            this.FunctionGrp.TabStop = false;
            this.FunctionGrp.Text = "功能按钮";
            // 
            // Addbtn
            // 
            this.Addbtn.AutoSize = true;
            this.Addbtn.Location = new System.Drawing.Point(6, 18);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(81, 35);
            this.Addbtn.TabIndex = 6;
            this.Addbtn.Text = "添加订单";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // ExportBtn
            // 
            this.ExportBtn.AutoSize = true;
            this.ExportBtn.Location = new System.Drawing.Point(112, 18);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(80, 35);
            this.ExportBtn.TabIndex = 9;
            this.ExportBtn.Text = "导出订单";
            this.ExportBtn.UseVisualStyleBackColor = true;
            this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // queryDetail
            // 
            this.queryDetail.Location = new System.Drawing.Point(112, 118);
            this.queryDetail.Name = "queryDetail";
            this.queryDetail.Size = new System.Drawing.Size(124, 35);
            this.queryDetail.TabIndex = 3;
            this.queryDetail.Text = "查看订单详情";
            this.queryDetail.UseVisualStyleBackColor = true;
            this.queryDetail.Click += new System.EventHandler(this.queryDetail_Click);
            // 
            // ImportBtn
            // 
            this.ImportBtn.AutoSize = true;
            this.ImportBtn.Location = new System.Drawing.Point(112, 66);
            this.ImportBtn.Name = "ImportBtn";
            this.ImportBtn.Size = new System.Drawing.Size(81, 35);
            this.ImportBtn.TabIndex = 10;
            this.ImportBtn.Text = "导入订单";
            this.ImportBtn.UseVisualStyleBackColor = true;
            this.ImportBtn.Click += new System.EventHandler(this.ImportBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.AutoSize = true;
            this.deleteBtn.Location = new System.Drawing.Point(6, 66);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(80, 35);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "删除订单";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // changeBtn
            // 
            this.changeBtn.AutoSize = true;
            this.changeBtn.Location = new System.Drawing.Point(6, 118);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(80, 35);
            this.changeBtn.TabIndex = 8;
            this.changeBtn.Text = "修改订单";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // QueryGrp
            // 
            this.QueryGrp.Controls.Add(this.queryStrlab);
            this.QueryGrp.Controls.Add(this.queryStrtextBox);
            this.QueryGrp.Controls.Add(this.queryTypelab);
            this.QueryGrp.Controls.Add(this.queryBtn);
            this.QueryGrp.Controls.Add(this.queryTypeCombox);
            this.QueryGrp.Location = new System.Drawing.Point(12, 19);
            this.QueryGrp.Name = "QueryGrp";
            this.QueryGrp.Size = new System.Drawing.Size(284, 176);
            this.QueryGrp.TabIndex = 5;
            this.QueryGrp.TabStop = false;
            this.QueryGrp.Text = "查询订单";
            // 
            // queryStrlab
            // 
            this.queryStrlab.AutoSize = true;
            this.queryStrlab.Location = new System.Drawing.Point(29, 88);
            this.queryStrlab.Name = "queryStrlab";
            this.queryStrlab.Size = new System.Drawing.Size(67, 15);
            this.queryStrlab.TabIndex = 5;
            this.queryStrlab.Text = "查询内容";
            // 
            // queryStrtextBox
            // 
            this.queryStrtextBox.Location = new System.Drawing.Point(114, 85);
            this.queryStrtextBox.Name = "queryStrtextBox";
            this.queryStrtextBox.Size = new System.Drawing.Size(155, 25);
            this.queryStrtextBox.TabIndex = 4;
            // 
            // queryTypelab
            // 
            this.queryTypelab.AutoSize = true;
            this.queryTypelab.Location = new System.Drawing.Point(29, 38);
            this.queryTypelab.Name = "queryTypelab";
            this.queryTypelab.Size = new System.Drawing.Size(67, 15);
            this.queryTypelab.TabIndex = 3;
            this.queryTypelab.Text = "查询方式";
            // 
            // queryBtn
            // 
            this.queryBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.queryBtn.Location = new System.Drawing.Point(194, 125);
            this.queryBtn.Name = "queryBtn";
            this.queryBtn.Size = new System.Drawing.Size(75, 28);
            this.queryBtn.TabIndex = 2;
            this.queryBtn.Text = "查询";
            this.queryBtn.UseVisualStyleBackColor = false;
            this.queryBtn.Click += new System.EventHandler(this.queryBtn_Click);
            // 
            // queryTypeCombox
            // 
            this.queryTypeCombox.BackColor = System.Drawing.SystemColors.Window;
            this.queryTypeCombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.queryTypeCombox.FormattingEnabled = true;
            this.queryTypeCombox.Items.AddRange(new object[] {
            "全部订单",
            "订单号",
            "客户名",
            "商品名",
            "总价"});
            this.queryTypeCombox.Location = new System.Drawing.Point(114, 30);
            this.queryTypeCombox.Name = "queryTypeCombox";
            this.queryTypeCombox.Size = new System.Drawing.Size(104, 23);
            this.queryTypeCombox.TabIndex = 1;
            this.queryTypeCombox.SelectedIndexChanged += new System.EventHandler(this.queryTypeCombox_SelectedIndexChanged);
            // 
            // OrderDetailGrp
            // 
            this.OrderDetailGrp.Controls.Add(this.orderDetailDataGridView);
            this.OrderDetailGrp.Dock = System.Windows.Forms.DockStyle.Right;
            this.OrderDetailGrp.Location = new System.Drawing.Point(535, 201);
            this.OrderDetailGrp.Name = "OrderDetailGrp";
            this.OrderDetailGrp.Padding = new System.Windows.Forms.Padding(0);
            this.OrderDetailGrp.Size = new System.Drawing.Size(684, 501);
            this.OrderDetailGrp.TabIndex = 4;
            this.OrderDetailGrp.TabStop = false;
            this.OrderDetailGrp.Text = "订单详情";
            // 
            // orderDetailDataGridView
            // 
            this.orderDetailDataGridView.AllowUserToAddRows = false;
            this.orderDetailDataGridView.AllowUserToDeleteRows = false;
            this.orderDetailDataGridView.AllowUserToResizeColumns = false;
            this.orderDetailDataGridView.AllowUserToResizeRows = false;
            this.orderDetailDataGridView.AutoGenerateColumns = false;
            this.orderDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDetailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemStoreDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemPriceDataGridViewTextBoxColumn,
            this.itemNumDataGridViewTextBoxColumn});
            this.orderDetailDataGridView.DataSource = this.OrderDetails;
            this.orderDetailDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderDetailDataGridView.Location = new System.Drawing.Point(0, 18);
            this.orderDetailDataGridView.Name = "orderDetailDataGridView";
            this.orderDetailDataGridView.ReadOnly = true;
            this.orderDetailDataGridView.RowHeadersWidth = 51;
            this.orderDetailDataGridView.RowTemplate.Height = 27;
            this.orderDetailDataGridView.Size = new System.Drawing.Size(684, 483);
            this.orderDetailDataGridView.TabIndex = 0;
            // 
            // itemStoreDataGridViewTextBoxColumn
            // 
            this.itemStoreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemStoreDataGridViewTextBoxColumn.DataPropertyName = "itemStore";
            this.itemStoreDataGridViewTextBoxColumn.HeaderText = "店家";
            this.itemStoreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemStoreDataGridViewTextBoxColumn.Name = "itemStoreDataGridViewTextBoxColumn";
            this.itemStoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "itemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "商品名";
            this.itemNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemPriceDataGridViewTextBoxColumn
            // 
            this.itemPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemPriceDataGridViewTextBoxColumn.DataPropertyName = "itemPrice";
            this.itemPriceDataGridViewTextBoxColumn.HeaderText = "单价";
            this.itemPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemPriceDataGridViewTextBoxColumn.Name = "itemPriceDataGridViewTextBoxColumn";
            this.itemPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemNumDataGridViewTextBoxColumn
            // 
            this.itemNumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemNumDataGridViewTextBoxColumn.DataPropertyName = "itemNum";
            this.itemNumDataGridViewTextBoxColumn.HeaderText = "数量";
            this.itemNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemNumDataGridViewTextBoxColumn.Name = "itemNumDataGridViewTextBoxColumn";
            this.itemNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OrderDetails
            // 
            this.OrderDetails.DataSource = typeof(OrderForm.OrderDetail);
            // 
            // OrderGrp
            // 
            this.OrderGrp.Controls.Add(this.orderDataGridView);
            this.OrderGrp.Dock = System.Windows.Forms.DockStyle.Left;
            this.OrderGrp.Location = new System.Drawing.Point(0, 201);
            this.OrderGrp.Name = "OrderGrp";
            this.OrderGrp.Size = new System.Drawing.Size(514, 501);
            this.OrderGrp.TabIndex = 3;
            this.OrderGrp.TabStop = false;
            this.OrderGrp.Text = "订单";
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.AllowUserToAddRows = false;
            this.orderDataGridView.AllowUserToDeleteRows = false;
            this.orderDataGridView.AllowUserToResizeColumns = false;
            this.orderDataGridView.AllowUserToResizeRows = false;
            this.orderDataGridView.AutoGenerateColumns = false;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.priceSumDataGridViewTextBoxColumn});
            this.orderDataGridView.DataSource = this.Orders;
            this.orderDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderDataGridView.Location = new System.Drawing.Point(3, 21);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.ReadOnly = true;
            this.orderDataGridView.RowHeadersWidth = 51;
            this.orderDataGridView.RowTemplate.Height = 27;
            this.orderDataGridView.Size = new System.Drawing.Size(508, 477);
            this.orderDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "customerName";
            this.dataGridViewTextBoxColumn1.HeaderText = "买家";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // priceSumDataGridViewTextBoxColumn
            // 
            this.priceSumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceSumDataGridViewTextBoxColumn.DataPropertyName = "priceSum";
            this.priceSumDataGridViewTextBoxColumn.HeaderText = "总价";
            this.priceSumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceSumDataGridViewTextBoxColumn.Name = "priceSumDataGridViewTextBoxColumn";
            this.priceSumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Orders
            // 
            this.Orders.DataSource = typeof(OrderForm.Order);
            // 
            // ExportOrdersSDLG
            // 
            this.ExportOrdersSDLG.CreatePrompt = true;
            this.ExportOrdersSDLG.DefaultExt = "xml";
            this.ExportOrdersSDLG.FileName = "Orders";
            this.ExportOrdersSDLG.Filter = "xml文件|*.xml";
            this.ExportOrdersSDLG.InitialDirectory = "./";
            // 
            // ImportOrdersODLG
            // 
            this.ImportOrdersODLG.DefaultExt = "xml";
            this.ImportOrdersODLG.FileName = "ImportOrders";
            this.ImportOrdersODLG.Filter = "xml文件|*.xml";
            this.ImportOrdersODLG.InitialDirectory = "./";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1219, 702);
            this.Controls.Add(this.OrderDetailGrp);
            this.Controls.Add(this.OrderGrp);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1237, 749);
            this.MinimumSize = new System.Drawing.Size(1237, 749);
            this.Name = "Form1";
            this.Text = "订单管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            this.FunctionGrp.ResumeLayout(false);
            this.FunctionGrp.PerformLayout();
            this.QueryGrp.ResumeLayout(false);
            this.QueryGrp.PerformLayout();
            this.OrderDetailGrp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetails)).EndInit();
            this.OrderGrp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource OrderDetails;
        private System.Windows.Forms.BindingSource Orders;
        private System.Windows.Forms.ComboBox queryTypeCombox;
        private System.Windows.Forms.Button queryDetail;
        private System.Windows.Forms.GroupBox QueryGrp;
        private System.Windows.Forms.Label queryTypelab;
        private System.Windows.Forms.Button queryBtn;
        private System.Windows.Forms.Label queryStrlab;
        private System.Windows.Forms.TextBox queryStrtextBox;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.GroupBox OrderDetailGrp;
        private System.Windows.Forms.DataGridView orderDetailDataGridView;
        private System.Windows.Forms.GroupBox OrderGrp;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox FunctionGrp;
        private System.Windows.Forms.Button ExportBtn;
        private System.Windows.Forms.Button ImportBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemStoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.SaveFileDialog ExportOrdersSDLG;
        private System.Windows.Forms.OpenFileDialog ImportOrdersODLG;
    }
}

