namespace jpsale
{
    partial class Form_ptmgt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ptmgt));
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox3_min = new System.Windows.Forms.PictureBox();
            this.pictureBox1_close = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_excel = new System.Windows.Forms.Button();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rawPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promotionPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingSource)).BeginInit();
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
            this.panel6.Size = new System.Drawing.Size(660, 35);
            this.panel6.TabIndex = 13;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseDown);
            this.panel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseMove);
            this.panel6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseUp_1);
            // 
            // pictureBox3_min
            // 
            this.pictureBox3_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3_min.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3_min.Image")));
            this.pictureBox3_min.Location = new System.Drawing.Point(590, 5);
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
            this.pictureBox1_close.Location = new System.Drawing.Point(623, 5);
            this.pictureBox1_close.Name = "pictureBox1_close";
            this.pictureBox1_close.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1_close.TabIndex = 12;
            this.pictureBox1_close.TabStop = false;
            this.pictureBox1_close.Click += new System.EventHandler(this.pictureBox1_close_Click);
            this.pictureBox1_close.MouseLeave += new System.EventHandler(this.pictureBox1_close_MouseLeave);
            this.pictureBox1_close.MouseHover += new System.EventHandler(this.pictureBox1_close_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "查找(商品名)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(267, 445);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 17;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(359, 445);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 18;
            this.btn_edit.Text = "修改";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(450, 445);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 19;
            this.btn_del.Text = "删除";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(559, 445);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 20;
            this.btn_back.Text = "返回";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.rawPriceDataGridViewTextBoxColumn,
            this.salePriceDataGridViewTextBoxColumn,
            this.promotionPriceDataGridViewTextBoxColumn,
            this.agentPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(608, 334);
            this.dataGridView1.TabIndex = 21;
            // 
            // btn_excel
            // 
            this.btn_excel.Location = new System.Drawing.Point(26, 425);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(128, 43);
            this.btn_excel.TabIndex = 22;
            this.btn_excel.Text = "Excel";
            this.btn_excel.UseVisualStyleBackColor = true;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // rawPriceDataGridViewTextBoxColumn
            // 
            this.rawPriceDataGridViewTextBoxColumn.DataPropertyName = "RawPrice";
            this.rawPriceDataGridViewTextBoxColumn.HeaderText = "RawPrice";
            this.rawPriceDataGridViewTextBoxColumn.Name = "rawPriceDataGridViewTextBoxColumn";
            // 
            // salePriceDataGridViewTextBoxColumn
            // 
            this.salePriceDataGridViewTextBoxColumn.DataPropertyName = "SalePrice";
            this.salePriceDataGridViewTextBoxColumn.HeaderText = "SalePrice";
            this.salePriceDataGridViewTextBoxColumn.Name = "salePriceDataGridViewTextBoxColumn";
            // 
            // promotionPriceDataGridViewTextBoxColumn
            // 
            this.promotionPriceDataGridViewTextBoxColumn.DataPropertyName = "PromotionPrice";
            this.promotionPriceDataGridViewTextBoxColumn.HeaderText = "PromotionPrice";
            this.promotionPriceDataGridViewTextBoxColumn.Name = "promotionPriceDataGridViewTextBoxColumn";
            // 
            // agentPriceDataGridViewTextBoxColumn
            // 
            this.agentPriceDataGridViewTextBoxColumn.DataPropertyName = "AgentPrice";
            this.agentPriceDataGridViewTextBoxColumn.HeaderText = "AgentPrice";
            this.agentPriceDataGridViewTextBoxColumn.Name = "agentPriceDataGridViewTextBoxColumn";
            // 
            // productInfoBindingSource
            // 
            this.productInfoBindingSource.DataSource = typeof(jpsale.ProductInfo);
            // 
            // Form_ptmgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(660, 480);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_ptmgt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ptmgt";
            this.Load += new System.EventHandler(this.Form_ptmgt_Load);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox3_min;
        private System.Windows.Forms.PictureBox pictureBox1_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.BindingSource productInfoBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rawPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn promotionPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_excel;
    }
}