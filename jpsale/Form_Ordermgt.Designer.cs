namespace jpsale
{
    partial class Form_Ordermgt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ordermgt));
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox3_min = new System.Windows.Forms.PictureBox();
            this.pictureBox1_close = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TranscationPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliverDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_excel = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.PeachPuff;
            this.panel6.Controls.Add(this.pictureBox3_min);
            this.panel6.Controls.Add(this.pictureBox1_close);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(644, 35);
            this.panel6.TabIndex = 12;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseDown);
            this.panel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseMove);
            this.panel6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseUp);
            // 
            // pictureBox3_min
            // 
            this.pictureBox3_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3_min.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3_min.Image")));
            this.pictureBox3_min.Location = new System.Drawing.Point(574, 5);
            this.pictureBox3_min.Name = "pictureBox3_min";
            this.pictureBox3_min.Size = new System.Drawing.Size(27, 27);
            this.pictureBox3_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3_min.TabIndex = 14;
            this.pictureBox3_min.TabStop = false;
            this.pictureBox3_min.Click += new System.EventHandler(this.pictureBox3_min_Click);
            this.pictureBox3_min.MouseLeave += new System.EventHandler(this.pictureBox3_min_MouseLeave);
            this.pictureBox3_min.MouseHover += new System.EventHandler(this.pictureBox3_min_MouseHover);
            // 
            // pictureBox1_close
            // 
            this.pictureBox1_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1_close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1_close.Image")));
            this.pictureBox1_close.Location = new System.Drawing.Point(607, 5);
            this.pictureBox1_close.Name = "pictureBox1_close";
            this.pictureBox1_close.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1_close.TabIndex = 12;
            this.pictureBox1_close.TabStop = false;
            this.pictureBox1_close.Click += new System.EventHandler(this.pictureBox1_close_Click);
            this.pictureBox1_close.MouseLeave += new System.EventHandler(this.pictureBox1_close_MouseLeave);
            this.pictureBox1_close.MouseHover += new System.EventHandler(this.pictureBox1_close_MouseHover);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "查找(商品名)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerName,
            this.Address,
            this.MobileNumber,
            this.productNameDataGridViewTextBoxColumn,
            this.TranscationPrice,
            this.Quantity,
            this.DeliverDate,
            this.PurchaseTime});
            this.dataGridView1.DataSource = this.orderInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(622, 295);
            this.dataGridView1.TabIndex = 18;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "客户名";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 70;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "地址";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 60;
            // 
            // MobileNumber
            // 
            this.MobileNumber.DataPropertyName = "MobileNumber";
            this.MobileNumber.HeaderText = "电话";
            this.MobileNumber.Name = "MobileNumber";
            this.MobileNumber.ReadOnly = true;
            this.MobileNumber.Width = 60;
            // 
            // TranscationPrice
            // 
            this.TranscationPrice.DataPropertyName = "TranscationPrice";
            this.TranscationPrice.HeaderText = "成交价";
            this.TranscationPrice.Name = "TranscationPrice";
            this.TranscationPrice.ReadOnly = true;
            this.TranscationPrice.Width = 70;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "数量";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 60;
            // 
            // DeliverDate
            // 
            this.DeliverDate.DataPropertyName = "DeliverDate";
            this.DeliverDate.HeaderText = "发货时间";
            this.DeliverDate.Name = "DeliverDate";
            this.DeliverDate.ReadOnly = true;
            this.DeliverDate.Width = 90;
            // 
            // PurchaseTime
            // 
            this.PurchaseTime.DataPropertyName = "PurchaseTime";
            this.PurchaseTime.HeaderText = "购买时间";
            this.PurchaseTime.Name = "PurchaseTime";
            this.PurchaseTime.ReadOnly = true;
            this.PurchaseTime.Width = 90;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(558, 406);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 23;
            this.btn_back.Text = "返回";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(449, 406);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 22;
            this.btn_del.Text = "删除";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(358, 406);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 21;
            this.btn_edit.Text = "修改";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "商品名";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNameDataGridViewTextBoxColumn.Width = 70;
            // 
            // orderInfoBindingSource
            // 
            this.orderInfoBindingSource.DataSource = typeof(jpsale.OrderInfo);
            // 
            // btn_excel
            // 
            this.btn_excel.Location = new System.Drawing.Point(12, 396);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(128, 43);
            this.btn_excel.TabIndex = 28;
            this.btn_excel.Text = "Excel";
            this.btn_excel.UseVisualStyleBackColor = true;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // Form_Ordermgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(644, 441);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Ordermgt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_Ordermgt_Load);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox3_min;
        private System.Windows.Forms.PictureBox pictureBox1_close;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource orderInfoBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TranscationPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliverDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTime;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_excel;
    }
}