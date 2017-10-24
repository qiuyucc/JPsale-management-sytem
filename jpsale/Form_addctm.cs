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
    public partial class Form_addctm : Form
    {
        JPsaleEntities db;
        public Form_addctm(CustomerInfo obj)
        {
            InitializeComponent();
            db = new JPsaleEntities();
            if (obj == null)
            {
                customerInfoBindingSource.DataSource = new CustomerInfo();
                db.CustomerInfoes.Add(customerInfoBindingSource.Current as CustomerInfo);
            }
            else
            {
                customerInfoBindingSource.DataSource = obj;
                db.CustomerInfoes.Attach(customerInfoBindingSource.Current as CustomerInfo);
            }
        }

        private void Form_addctm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(textBox_name.Text)||string.IsNullOrEmpty(textBox_address.Text)||string.IsNullOrEmpty(textBox_mn.Text))
                {
                    MessageBox.Show("输入客户信息","提示",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_name.Focus();
                    e.Cancel = true;
                    return;
                }
                db.SaveChanges();
                e.Cancel = false;

            }
            e.Cancel = false;
        }

        private void Form_addctm_Load(object sender, EventArgs e)
        {

        }

        private void textBox_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }
    }
}
