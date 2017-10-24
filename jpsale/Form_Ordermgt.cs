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
    public partial class Form_Ordermgt : Form
    {
        JPsaleEntities db;
        public Form_Ordermgt()
        {
            InitializeComponent();
            db = new JPsaleEntities();
            orderInfoBindingSource.DataSource = db.OrderInfoes.ToList();
        }

        private void pictureBox3_min_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox3_min.BackColor = Color.Snow;
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

        private void pictureBox3_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_close_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.OrderInfoes.Where(x => x.MobileNumber.Contains(textBox1.Text)).ToList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_Ordermgt_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 fm = new Form2();
            fm.Show();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (orderInfoBindingSource.Current == null)
                return;
            using (Form_editOrder frm = new Form_editOrder(orderInfoBindingSource.Current as OrderInfo))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    orderInfoBindingSource.DataSource = db.OrderInfoes.ToList();
                dataGridView1.Refresh();
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (orderInfoBindingSource.Current != null)
            {
                if (MessageBox.Show("确定要删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.OrderInfoes.Remove(orderInfoBindingSource.Current as OrderInfo);
                    orderInfoBindingSource.RemoveCurrent();
                    
                    db.SaveChanges();

                }
            }
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "订单";
            // storing header part in Excel  
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
        }

        private void panel6_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
