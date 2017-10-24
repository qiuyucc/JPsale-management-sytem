using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jpsale
{
    public partial class Form_addpt : Form
    {
        JPsaleEntities db;
        public Form_addpt(ProductInfo obj)
        {
            InitializeComponent();
            db = new JPsaleEntities();
            //ProductInfobindingSource.DataSource = obj;

            if (obj == null)
            {
                ProductInfobindingSource.DataSource = new ProductInfo();
                db.ProductInfoes.Add(ProductInfobindingSource.Current as ProductInfo);
            }
            else
            {
                ProductInfobindingSource.DataSource = obj;
                db.ProductInfoes.Attach(ProductInfobindingSource.Current as ProductInfo);
            }
            
        }

        public ProductInfo productInfo { get { return ProductInfobindingSource.Current as ProductInfo; } }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void Form_addpt_Load(object sender, EventArgs e)
        {

        }

        private void Form_addpt_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text)|| string.IsNullOrEmpty(textBox5.Text))
                {
                    MessageBox.Show("输入完整商品信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Focus();
                    e.Cancel = true;
                    return;
                }
                db.SaveChanges();
                e.Cancel = false;

            }
            e.Cancel = false;
        }
    }
}
