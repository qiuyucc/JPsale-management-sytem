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
    public partial class Form_ctmgt : System.Windows.Forms.Form
    {
        JPsaleEntities db;
      
        public Form_ctmgt()
        {
            InitializeComponent();

            db = new JPsaleEntities();
            customerInfoBindingSource.DataSource = db.CustomerInfoes.ToList();

            dataGridView1.Columns[0].HeaderText = "客户号";
            dataGridView1.Columns[1].HeaderText = "名字";
            dataGridView1.Columns[2].HeaderText = "地址";
            dataGridView1.Columns[3].HeaderText = "电话号码";

            DataGridViewColumn column = dataGridView1.Columns[2];
            column.Width = 250;
        }

        private void pictureBox3_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //private void pictureBox2_Max_Click(object sender, EventArgs e)
        //{
        //    if (this.WindowState == FormWindowState.Maximized)
        //    {
        //        this.WindowState = FormWindowState.Normal;
        //        int CurActForX = 0, CurCloPicLock = 0, CurMaxPicLock = 0, CurMinPicLock = 0;

        //        CurActForX = ActiveForm.Width;
        //        CurCloPicLock = (CurActForX - 32);
        //        CurMaxPicLock = (CurActForX - 64);
        //        CurMinPicLock = (CurActForX - 96);

        //        this.pictureBox1_close.Location = new Point(CurCloPicLock, 0);
        //        this.pictureBox2_Max.Location = new Point(CurMaxPicLock, 0);
        //        this.pictureBox3_min.Location = new Point(CurMinPicLock, 0);

        //    }
        //    else
        //    {
        //        this.WindowState = FormWindowState.Maximized;

        //        int ActForX = 0, CloPicLocX = 0, MaxPicLocX = 0, MinPicLocX = 0;

        //        ActForX = ActiveForm.Width;
        //        CloPicLocX = (ActForX - 32);
        //        MaxPicLocX = (ActForX - 64);
        //        MinPicLocX = (ActForX - 96);

        //        this.pictureBox1_close.Location = new Point(CloPicLocX, 0);
        //        this.pictureBox2_Max.Location = new Point(MaxPicLocX, 0);
        //        this.pictureBox3_min.Location = new Point(MinPicLocX, 0);

        //    }
        //}

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

        private void panel6_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        //private void pictureBox2_Max_MouseHover(object sender, EventArgs e)
        //{
        //    this.pictureBox2_Max.BackColor = Color.SeaShell;
        //}

        //private void pictureBox2_Max_MouseLeave(object sender, EventArgs e)
        //{
        //    this.pictureBox2_Max.BackColor = Color.PeachPuff;
        //}

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

        private void Form_ctmgt_Load(object sender, EventArgs e)
        {
            
           
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (customerInfoBindingSource.Current == null)
                return;
            using (Form_addctm frm = new Form_addctm(null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    customerInfoBindingSource.DataSource = db.CustomerInfoes.ToList();
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (customerInfoBindingSource.Current != null)
            {
                if (MessageBox.Show("确定要删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.CustomerInfoes.Remove(customerInfoBindingSource.Current as CustomerInfo);
                    customerInfoBindingSource.RemoveCurrent();
                    db.SaveChanges();
                        
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (customerInfoBindingSource.Current == null)
                return;
            using (Form_addctm frm = new Form_addctm(customerInfoBindingSource.Current as CustomerInfo))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    customerInfoBindingSource.DataSource = db.CustomerInfoes.ToList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //DataTable dt = new DataTable("CustomerInfo");
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)  //search textbox
        {


            ////DataTable dt = new DataTable("CustomerInfo");
            //if (e.KeyChar == (char)13)
            //{
            //    DataView dv ;
            //    DataTable dt1 = new DataView(dv);
            //    var filtertext = textBox1.Text;

            //    dv.RowFilter = string.Format("CustomerName like %'{0}'%", filtertext);
            //    //customerInfoBindingSource.Filter = string.Format("CustomerName like %'{0}'%", filtertext);
            //    dataGridView1.DataSource = dv.ToTable();
            //}

            //var customerlist = (List<CustomerInfo>)customerInfoBindingSource.DataSource;
            //var searchText = textBox1.Text;
            //var firstMatchIndex = customerlist.FindIndex(c => c.MobileNumber.Contains(searchText));
            //if (firstMatchIndex >= 0)
            //    customerInfoBindingSource.Position = firstMatchIndex;
                 //dataGridView1.DataSource = firstMatchIndex;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                customerInfoBindingSource.DataSource = db.CustomerInfoes.ToList();
            }
            else
            {
                customerInfoBindingSource.DataSource = db.CustomerInfoes.Where(x => x.MobileNumber.Contains(textBox1.Text)).ToList();
            }
            
           // dataGridView1.DataSource = customerInfoBindingSource.DataSource;

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 fm = new Form2();
            fm.Show();
              
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
            worksheet.Name = "客户清单";
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
            //// save the application  
            //workbook.SaveAs("c:\\Customer.xls");
            //// Exit from the application  
            //app.Quit();
        }

     

      
    }
}
