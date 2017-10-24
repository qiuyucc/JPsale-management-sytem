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
    public partial class Form_editOrder : Form
    {

        JPsaleEntities db;
        public Form_editOrder(OrderInfo obj)
        {
            InitializeComponent();
            db = new JPsaleEntities();
            dateTimePicker1.Value = DateTime.Today;
            if (obj == null)
            {
               orderInfoBindingSource.DataSource = new OrderInfo();
                db.OrderInfoes.Add(orderInfoBindingSource.Current as OrderInfo);
            }
            else
            {
                orderInfoBindingSource.DataSource = obj;
                db.OrderInfoes.Attach(orderInfoBindingSource.Current as OrderInfo);
            }
        }

        private void textBox_lastprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void Form_editOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(textBox_name.Text) || string.IsNullOrEmpty(textBox_address.Text) || string.IsNullOrEmpty(textBox_mn.Text) || string.IsNullOrEmpty(textBox_lastprice.Text) || string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox_quantity.Text) || string.IsNullOrEmpty(dateTimePicker1.Text))
                {
                    MessageBox.Show("输入完整订单信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_name.Focus();
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
