namespace jpsale
{
    partial class Form_trademgt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_trademgt));
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox3_min = new System.Windows.Forms.PictureBox();
            this.pictureBox1_close = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TranscationPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliverDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_excel = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.panel6.TabIndex = 13;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(622, 284);
            this.dataGridView1.TabIndex = 14;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(463, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 20);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.Value = new System.DateTime(2017, 10, 23, 18, 49, 51, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "发货时间";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 50);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询方式";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_excel
            // 
            this.btn_excel.Location = new System.Drawing.Point(12, 387);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(128, 43);
            this.btn_excel.TabIndex = 27;
            this.btn_excel.Text = "Excel";
            this.btn_excel.UseVisualStyleBackColor = true;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(557, 406);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 30;
            this.btn_back.Text = "返回";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
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
            // Form_trademgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(644, 441);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_trademgt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_trademgt";
            this.Load += new System.EventHandler(this.Form_trademgt_Load);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox3_min;
        private System.Windows.Forms.PictureBox pictureBox1_close;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource orderInfoBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TranscationPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliverDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTime;
        private System.Windows.Forms.Button btn_excel;
        private System.Windows.Forms.Button btn_back;
    }
}