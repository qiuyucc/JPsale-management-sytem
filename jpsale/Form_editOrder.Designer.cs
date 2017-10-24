namespace jpsale
{
    partial class Form_editOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_editOrder));
            this.btn_save = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_mn = new System.Windows.Forms.TextBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_lastprice = new System.Windows.Forms.Label();
            this.label_quantity = new System.Windows.Forms.Label();
            this.textBox_lastprice = new System.Windows.Forms.TextBox();
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_deliverdate = new System.Windows.Forms.Label();
            this.orderInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.orderInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_save.Location = new System.Drawing.Point(271, 301);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "储存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderInfoBindingSource, "ProductName", true));
            this.textBox1.Location = new System.Drawing.Point(88, 125);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 50);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "商品名";
            // 
            // textBox_mn
            // 
            this.textBox_mn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderInfoBindingSource, "MobileNumber", true));
            this.textBox_mn.Location = new System.Drawing.Point(88, 43);
            this.textBox_mn.Name = "textBox_mn";
            this.textBox_mn.Size = new System.Drawing.Size(166, 20);
            this.textBox_mn.TabIndex = 11;
            // 
            // textBox_address
            // 
            this.textBox_address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderInfoBindingSource, "Address", true));
            this.textBox_address.Location = new System.Drawing.Point(88, 69);
            this.textBox_address.Multiline = true;
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(258, 50);
            this.textBox_address.TabIndex = 13;
            // 
            // textBox_name
            // 
            this.textBox_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderInfoBindingSource, "CustomerName", true));
            this.textBox_name.Location = new System.Drawing.Point(88, 12);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(166, 20);
            this.textBox_name.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "电话";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "地址";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "名字";
            // 
            // label_lastprice
            // 
            this.label_lastprice.AutoSize = true;
            this.label_lastprice.Location = new System.Drawing.Point(23, 225);
            this.label_lastprice.Name = "label_lastprice";
            this.label_lastprice.Size = new System.Drawing.Size(31, 13);
            this.label_lastprice.TabIndex = 15;
            this.label_lastprice.Text = "价格";
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Location = new System.Drawing.Point(23, 261);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(31, 13);
            this.label_quantity.TabIndex = 16;
            this.label_quantity.Text = "数量";
            // 
            // textBox_lastprice
            // 
            this.textBox_lastprice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderInfoBindingSource, "TranscationPrice", true));
            this.textBox_lastprice.Location = new System.Drawing.Point(88, 225);
            this.textBox_lastprice.Name = "textBox_lastprice";
            this.textBox_lastprice.Size = new System.Drawing.Size(61, 20);
            this.textBox_lastprice.TabIndex = 18;
            this.textBox_lastprice.TextChanged += new System.EventHandler(this.textBox_lastprice_TextChanged);
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderInfoBindingSource, "Quantity", true));
            this.textBox_quantity.Location = new System.Drawing.Point(88, 261);
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.Size = new System.Drawing.Size(61, 20);
            this.textBox_quantity.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderInfoBindingSource, "DeliverDate", true));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 184);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker1.TabIndex = 24;
            this.dateTimePicker1.Value = new System.DateTime(2017, 10, 22, 19, 11, 29, 0);
            // 
            // label_deliverdate
            // 
            this.label_deliverdate.AutoSize = true;
            this.label_deliverdate.Location = new System.Drawing.Point(23, 184);
            this.label_deliverdate.Name = "label_deliverdate";
            this.label_deliverdate.Size = new System.Drawing.Size(55, 13);
            this.label_deliverdate.TabIndex = 23;
            this.label_deliverdate.Text = "发货时间";
            // 
            // orderInfoBindingSource
            // 
            this.orderInfoBindingSource.DataSource = typeof(jpsale.OrderInfo);
            // 
            // Form_editOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 336);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label_deliverdate);
            this.Controls.Add(this.textBox_quantity);
            this.Controls.Add(this.textBox_lastprice);
            this.Controls.Add(this.label_quantity);
            this.Controls.Add(this.label_lastprice);
            this.Controls.Add(this.textBox_mn);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_editOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_editOrder_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.orderInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_mn;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_lastprice;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.TextBox textBox_lastprice;
        private System.Windows.Forms.TextBox textBox_quantity;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_deliverdate;
        private System.Windows.Forms.BindingSource orderInfoBindingSource;
    }
}