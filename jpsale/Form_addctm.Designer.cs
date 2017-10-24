namespace jpsale
{
    partial class Form_addctm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_addctm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_mn = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.customerInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "名字";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "地址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "电话";
            // 
            // textBox_name
            // 
            this.textBox_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerInfoBindingSource, "CustomerName", true));
            this.textBox_name.Location = new System.Drawing.Point(63, 24);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(155, 20);
            this.textBox_name.TabIndex = 0;
            // 
            // textBox_address
            // 
            this.textBox_address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerInfoBindingSource, "Address", true));
            this.textBox_address.Location = new System.Drawing.Point(63, 99);
            this.textBox_address.Multiline = true;
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(247, 72);
            this.textBox_address.TabIndex = 2;
            this.textBox_address.TextChanged += new System.EventHandler(this.textBox_address_TextChanged);
            // 
            // textBox_mn
            // 
            this.textBox_mn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerInfoBindingSource, "MobileNumber", true));
            this.textBox_mn.Location = new System.Drawing.Point(63, 61);
            this.textBox_mn.Name = "textBox_mn";
            this.textBox_mn.Size = new System.Drawing.Size(155, 20);
            this.textBox_mn.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_save.Location = new System.Drawing.Point(235, 203);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "储存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // customerInfoBindingSource
            // 
            this.customerInfoBindingSource.DataSource = typeof(jpsale.CustomerInfo);
            // 
            // Form_addctm
            // 
            this.AcceptButton = this.btn_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 238);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.textBox_mn);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_addctm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_addctm_FormClosing);
            this.Load += new System.EventHandler(this.Form_addctm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_mn;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.BindingSource customerInfoBindingSource;
    }
}