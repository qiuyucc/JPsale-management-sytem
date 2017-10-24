using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace jpsale
{

    
    public partial class Form_purchase : Form
    {
        JPsaleEntities db;
       
        public Form_purchase()
        {
            InitializeComponent();

            db = new JPsaleEntities();
            productInfoBindingSource.DataSource = db.ProductInfoes.ToList();
            customerInfoBindingSource.DataSource = db.CustomerInfoes.ToList();
            // orderInfobindingSource.DataSource = db.OrderInfoes.ToList();
            dateTimePicker1.Value = DateTime.Today;
        }


        public Form_purchase(OrderInfo odj)
        {
            if (odj == null)
            {
                orderInfobindingSource.DataSource = new ProductInfo();
                db.ProductInfoes.Add(orderInfobindingSource.Current as ProductInfo);
            }
            else
            {
                orderInfobindingSource.DataSource = odj;
                db.ProductInfoes.Attach(orderInfobindingSource.Current as ProductInfo);
            }

        }


        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }


        private void panel6_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pictureBox1_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_min_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox3_min.BackColor = Color.SeaShell;
        }

        private void pictureBox3_min_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox3_min.BackColor = Color.PeachPuff;
        }

        private void pictureBox1_close_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox1_close.BackColor = Color.Salmon;
        }

        private void pictureBox1_close_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox1_close.BackColor = Color.PeachPuff;
        }

        private void Form_purchase_Load(object sender, EventArgs e)
        {
            
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 fm = new Form2();
            fm.Show();
        }

        private void btn_newpt_Click(object sender, EventArgs e)
        {
            if (productInfoBindingSource.Current == null)
                return;
            using (Form_addpt frm = new Form_addpt(null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    productInfoBindingSource.DataSource = db.ProductInfoes.ToList();
                    dataGridView2.Refresh();
            }
        }

        private void btn_newctm_Click(object sender, EventArgs e)
        {
            if (customerInfoBindingSource.Current == null)
                return;
            using (Form_addctm frm = new Form_addctm(null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    customerInfoBindingSource.DataSource = db.CustomerInfoes.ToList();
                dataGridView1.Refresh();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.CustomerInfoes.Where(x => x.MobileNumber.Contains(textBox1.Text)).ToList();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = db.ProductInfoes.Where(x => x.ProductName.Contains(textBox2.Text)).ToList();
        }

        private void groupBox_price_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                textBox_ctmname.Text = row.Cells[0].Value.ToString();
                textBox_address.Text = row.Cells[1].Value.ToString();
                textBox_mobile.Text = row.Cells[2].Value.ToString();
                
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                textBox_ptname.Text = row.Cells[0].Value.ToString();
                label_rawprice.Text = row.Cells[1].Value.ToString();
                label_saleprice.Text = row.Cells[2].Value.ToString();
                label_promotionprice.Text = row.Cells[3].Value.ToString();
                label_agentprice.Text = row.Cells[4].Value.ToString();


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox_quantity.Text))
            {
                MessageBox.Show("请自行添加数量", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int x = Convert.ToInt32(this.textBox_quantity.Text);
                x = x + 1;
                textBox_quantity.Text = x.ToString();
            }
            
                
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_quantity.Text))
            {
                MessageBox.Show("请自行添加数量", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {  
               
                int x = Convert.ToInt32(this.textBox_quantity.Text);
                x = x - 1;
                if (x < 0)
                {
                    MessageBox.Show("别减了，别减了，ヾ(￣▽￣)", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                textBox_quantity.Text = x.ToString();
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = checkedListBox1.SelectedIndex;

            switch (selected)
            {

                case 0:

                    textBox_lastprice.Text = label_saleprice.Text;
                    break;

                case 1:

                    textBox_lastprice.Text = label_promotionprice.Text;
                    break;

                case 2:

                    textBox_lastprice.Text = label_agentprice.Text;
                    break;

                case 3:

                    textBox_lastprice.Text = textBox_ctm.Text;
                    break;
               
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                for (int ix = 0; ix < checkedListBox1.Items.Count; ++ix)
                    if (e.Index != ix) checkedListBox1.SetItemChecked(ix, false);
        }

        private void textBox_ctm_TextChanged(object sender, EventArgs e)
        {
            textBox_lastprice.Text = textBox_ctm.Text;
        }

        private void btn_transaction_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    OrderInfo order = new OrderInfo();
            //    db.OrderInfoes.Add(order);
            //    orderInfobindingSource.Add(order);
            //    orderInfobindingSource.MoveLast();

            //    orderInfobindingSource.EndEdit();
            //    db.SaveChangesAsync();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    orderInfobindingSource.ResetBindings(false);
            //}
            try
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["JPsaleSql"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();

                    SqlCommand cmd = new SqlCommand("insert into [OrderInfo] (CustomerName,Address,MobileNumber,ProductName,TranscationPrice,Quantity,DeliverDate) values(@CustomerName,@Address,@MobileNumber,@ProductName,@TranscationPrice,@Quantity,@DeliverDate)", cn);
                    
                    cmd.Parameters.AddWithValue("@CustomerName", textBox_ctmname.Text);
                    cmd.Parameters.AddWithValue("@Address", textBox_address.Text);
                    cmd.Parameters.AddWithValue("@MobileNumber", textBox_mobile.Text);
                    cmd.Parameters.AddWithValue("@ProductName", textBox_ptname.Text);
                    cmd.Parameters.AddWithValue("@TranscationPrice", textBox_lastprice.Text);
                    cmd.Parameters.AddWithValue("@Quantity", textBox_quantity.Text);
                    cmd.Parameters.AddWithValue("@DeliverDate", dateTimePicker1.Text);

                    if (string.IsNullOrEmpty(textBox_quantity.Text) || string.IsNullOrEmpty(textBox_lastprice.Text)||string.IsNullOrEmpty(dateTimePicker1.Text) || string.IsNullOrEmpty(textBox_ptname.Text) || string.IsNullOrEmpty(textBox_mobile.Text) || string.IsNullOrEmpty(textBox_ctmname.Text) || string.IsNullOrEmpty(textBox_address.Text))
                    {
                        MessageBox.Show("好像遗漏了什么","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        int i = cmd.ExecuteNonQuery();

                        cn.Close();

                        if (i != 0)
                        {
                            MessageBox.Show("订单生成成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    //con.Open();



                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


    }
}
