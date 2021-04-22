
namespace OrderForm
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.newOrderDetailDgv = new System.Windows.Forms.DataGridView();
            this.storeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newOrderDetail = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailGrp = new System.Windows.Forms.GroupBox();
            this.baseInfoGrp = new System.Windows.Forms.GroupBox();
            this.orderNumtxt = new System.Windows.Forms.TextBox();
            this.orderNumLab = new System.Windows.Forms.Label();
            this.NameLab = new System.Windows.Forms.Label();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.Otherpnl = new System.Windows.Forms.Panel();
            this.ChangeDetailBtn = new System.Windows.Forms.Button();
            this.DeleteDetailBtn = new System.Windows.Forms.Button();
            this.AddDetailBtn = new System.Windows.Forms.Button();
            this.SaveOrderBtn = new System.Windows.Forms.Button();
            this.SaveDetailBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.newOrderDetailDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newOrderDetail)).BeginInit();
            this.orderDetailGrp.SuspendLayout();
            this.baseInfoGrp.SuspendLayout();
            this.Otherpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // newOrderDetailDgv
            // 
            this.newOrderDetailDgv.AllowUserToAddRows = false;
            this.newOrderDetailDgv.AllowUserToDeleteRows = false;
            this.newOrderDetailDgv.AllowUserToResizeColumns = false;
            this.newOrderDetailDgv.AllowUserToResizeRows = false;
            this.newOrderDetailDgv.AutoGenerateColumns = false;
            this.newOrderDetailDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.newOrderDetailDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.storeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.itemNumDataGridViewTextBoxColumn});
            this.newOrderDetailDgv.DataSource = this.newOrderDetail;
            this.newOrderDetailDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newOrderDetailDgv.Location = new System.Drawing.Point(3, 21);
            this.newOrderDetailDgv.Name = "newOrderDetailDgv";
            this.newOrderDetailDgv.RowHeadersWidth = 51;
            this.newOrderDetailDgv.RowTemplate.Height = 27;
            this.newOrderDetailDgv.Size = new System.Drawing.Size(897, 336);
            this.newOrderDetailDgv.TabIndex = 0;
            // 
            // storeDataGridViewTextBoxColumn
            // 
            this.storeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.storeDataGridViewTextBoxColumn.DataPropertyName = "store";
            this.storeDataGridViewTextBoxColumn.HeaderText = "店家";
            this.storeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.storeDataGridViewTextBoxColumn.Name = "storeDataGridViewTextBoxColumn";
            this.storeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "商品名";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "单价";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // itemNumDataGridViewTextBoxColumn
            // 
            this.itemNumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemNumDataGridViewTextBoxColumn.DataPropertyName = "itemNum";
            this.itemNumDataGridViewTextBoxColumn.HeaderText = "数量";
            this.itemNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemNumDataGridViewTextBoxColumn.Name = "itemNumDataGridViewTextBoxColumn";
            this.itemNumDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // newOrderDetail
            // 
            this.newOrderDetail.DataSource = typeof(Sale.OrderDetail);
            // 
            // orderDetailGrp
            // 
            this.orderDetailGrp.Controls.Add(this.newOrderDetailDgv);
            this.orderDetailGrp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderDetailGrp.Location = new System.Drawing.Point(0, 115);
            this.orderDetailGrp.Name = "orderDetailGrp";
            this.orderDetailGrp.Size = new System.Drawing.Size(903, 360);
            this.orderDetailGrp.TabIndex = 1;
            this.orderDetailGrp.TabStop = false;
            this.orderDetailGrp.Text = "订单明细";
            // 
            // baseInfoGrp
            // 
            this.baseInfoGrp.Controls.Add(this.orderNumtxt);
            this.baseInfoGrp.Controls.Add(this.orderNumLab);
            this.baseInfoGrp.Controls.Add(this.NameLab);
            this.baseInfoGrp.Controls.Add(this.Nametxt);
            this.baseInfoGrp.Dock = System.Windows.Forms.DockStyle.Top;
            this.baseInfoGrp.Location = new System.Drawing.Point(0, 0);
            this.baseInfoGrp.Name = "baseInfoGrp";
            this.baseInfoGrp.Size = new System.Drawing.Size(903, 115);
            this.baseInfoGrp.TabIndex = 2;
            this.baseInfoGrp.TabStop = false;
            this.baseInfoGrp.Text = "基本信息";
            // 
            // orderNumtxt
            // 
            this.orderNumtxt.Location = new System.Drawing.Point(290, 32);
            this.orderNumtxt.Name = "orderNumtxt";
            this.orderNumtxt.Size = new System.Drawing.Size(324, 25);
            this.orderNumtxt.TabIndex = 3;
            // 
            // orderNumLab
            // 
            this.orderNumLab.AutoSize = true;
            this.orderNumLab.Location = new System.Drawing.Point(202, 43);
            this.orderNumLab.Name = "orderNumLab";
            this.orderNumLab.Size = new System.Drawing.Size(52, 15);
            this.orderNumLab.TabIndex = 2;
            this.orderNumLab.Text = "订单号";
            // 
            // NameLab
            // 
            this.NameLab.AutoSize = true;
            this.NameLab.Location = new System.Drawing.Point(202, 78);
            this.NameLab.Name = "NameLab";
            this.NameLab.Size = new System.Drawing.Size(52, 15);
            this.NameLab.TabIndex = 1;
            this.NameLab.Text = "客户名";
            // 
            // Nametxt
            // 
            this.Nametxt.BackColor = System.Drawing.SystemColors.Window;
            this.Nametxt.Location = new System.Drawing.Point(290, 75);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(324, 25);
            this.Nametxt.TabIndex = 0;
            // 
            // Otherpnl
            // 
            this.Otherpnl.Controls.Add(this.SaveDetailBtn);
            this.Otherpnl.Controls.Add(this.ChangeDetailBtn);
            this.Otherpnl.Controls.Add(this.DeleteDetailBtn);
            this.Otherpnl.Controls.Add(this.AddDetailBtn);
            this.Otherpnl.Controls.Add(this.SaveOrderBtn);
            this.Otherpnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Otherpnl.Location = new System.Drawing.Point(0, 475);
            this.Otherpnl.Name = "Otherpnl";
            this.Otherpnl.Size = new System.Drawing.Size(903, 60);
            this.Otherpnl.TabIndex = 3;
            // 
            // ChangeDetailBtn
            // 
            this.ChangeDetailBtn.AutoSize = true;
            this.ChangeDetailBtn.Location = new System.Drawing.Point(195, 10);
            this.ChangeDetailBtn.Name = "ChangeDetailBtn";
            this.ChangeDetailBtn.Size = new System.Drawing.Size(77, 25);
            this.ChangeDetailBtn.TabIndex = 3;
            this.ChangeDetailBtn.Text = "修改明细";
            this.ChangeDetailBtn.UseVisualStyleBackColor = true;
            this.ChangeDetailBtn.Click += new System.EventHandler(this.ChangeDetailBtn_Click);
            // 
            // DeleteDetailBtn
            // 
            this.DeleteDetailBtn.AutoSize = true;
            this.DeleteDetailBtn.Location = new System.Drawing.Point(105, 10);
            this.DeleteDetailBtn.Name = "DeleteDetailBtn";
            this.DeleteDetailBtn.Size = new System.Drawing.Size(77, 25);
            this.DeleteDetailBtn.TabIndex = 2;
            this.DeleteDetailBtn.Text = "删除明细";
            this.DeleteDetailBtn.UseVisualStyleBackColor = true;
            this.DeleteDetailBtn.Click += new System.EventHandler(this.DeleteDetailBtn_Click);
            // 
            // AddDetailBtn
            // 
            this.AddDetailBtn.AutoSize = true;
            this.AddDetailBtn.Location = new System.Drawing.Point(15, 10);
            this.AddDetailBtn.Name = "AddDetailBtn";
            this.AddDetailBtn.Size = new System.Drawing.Size(77, 25);
            this.AddDetailBtn.TabIndex = 1;
            this.AddDetailBtn.Text = "添加明细";
            this.AddDetailBtn.UseVisualStyleBackColor = true;
            this.AddDetailBtn.Click += new System.EventHandler(this.AddDetailBtn_Click);
            // 
            // SaveOrderBtn
            // 
            this.SaveOrderBtn.Location = new System.Drawing.Point(795, 10);
            this.SaveOrderBtn.Name = "SaveOrderBtn";
            this.SaveOrderBtn.Size = new System.Drawing.Size(96, 38);
            this.SaveOrderBtn.TabIndex = 0;
            this.SaveOrderBtn.Text = "保存订单";
            this.SaveOrderBtn.UseVisualStyleBackColor = true;
            this.SaveOrderBtn.Click += new System.EventHandler(this.SaveOrderBtn_Click);
            // 
            // SaveDetailBtn
            // 
            this.SaveDetailBtn.AutoSize = true;
            this.SaveDetailBtn.Location = new System.Drawing.Point(285, 10);
            this.SaveDetailBtn.Name = "SaveDetailBtn";
            this.SaveDetailBtn.Size = new System.Drawing.Size(77, 25);
            this.SaveDetailBtn.TabIndex = 4;
            this.SaveDetailBtn.Text = "保存明细";
            this.SaveDetailBtn.UseVisualStyleBackColor = true;
            this.SaveDetailBtn.Click += new System.EventHandler(this.SaveDetailBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 535);
            this.Controls.Add(this.orderDetailGrp);
            this.Controls.Add(this.Otherpnl);
            this.Controls.Add(this.baseInfoGrp);
            this.MaximumSize = new System.Drawing.Size(921, 582);
            this.MinimumSize = new System.Drawing.Size(921, 582);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newOrderDetailDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newOrderDetail)).EndInit();
            this.orderDetailGrp.ResumeLayout(false);
            this.baseInfoGrp.ResumeLayout(false);
            this.baseInfoGrp.PerformLayout();
            this.Otherpnl.ResumeLayout(false);
            this.Otherpnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView newOrderDetailDgv;
        private System.Windows.Forms.BindingSource newOrderDetail;
        private System.Windows.Forms.GroupBox orderDetailGrp;
        private System.Windows.Forms.GroupBox baseInfoGrp;
        private System.Windows.Forms.Panel Otherpnl;
        private System.Windows.Forms.Button ChangeDetailBtn;
        private System.Windows.Forms.Button DeleteDetailBtn;
        private System.Windows.Forms.Button AddDetailBtn;
        private System.Windows.Forms.Button SaveOrderBtn;
        private System.Windows.Forms.Label NameLab;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.Label orderNumLab;
        private System.Windows.Forms.TextBox orderNumtxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn princeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button SaveDetailBtn;
    }
}