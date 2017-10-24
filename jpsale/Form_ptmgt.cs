using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jpsale
{
    public partial class Form_ptmgt : Form
    {

        JPsaleEntities db;
        public Form_ptmgt()
        {
            InitializeComponent();
            db = new JPsaleEntities();
            productInfoBindingSource.DataSource = db.ProductInfoes.ToList();


            dataGridView1.Columns[0].HeaderText = "商品号";
            dataGridView1.Columns[1].HeaderText = "商品名";
            dataGridView1.Columns[2].HeaderText = "原价";
            dataGridView1.Columns[3].HeaderText = "售价";
            dataGridView1.Columns[4].HeaderText = "活动价";
            dataGridView1.Columns[5].HeaderText = "代理价";
            DataGridViewColumn column0 = dataGridView1.Columns[0];
            column0.Width = 70;
            DataGridViewColumn column1 = dataGridView1.Columns[1];
            column1.Width = 235;
            DataGridViewColumn column2 = dataGridView1.Columns[2];
            column2.Width = 60;
            DataGridViewColumn column3 = dataGridView1.Columns[3];
            column3.Width = 60;
            DataGridViewColumn column4 = dataGridView1.Columns[4];
            column4.Width = 70;
            DataGridViewColumn column5 = dataGridView1.Columns[5];
            column5.Width = 70;

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

        private void pictureBox3_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //DataTable dt = new DataTable("ProductInfo");
        // DataTable product = new DataTable();
        //string filterField = "ProductName";
        // Bindingsource bs = new Bindingsource();

      
       
         
        private void Form_ptmgt_Load(object sender, EventArgs e)
        {

            
           
            //try
            //{

            //    using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["JPsaleSql"].ConnectionString))
            //    {

            //        if (cn.State == ConnectionState.Closed)
            //            cn.Open();
            //        using (SqlDataAdapter da = new SqlDataAdapter("select * from ProductInfo", cn))
            //        {

            //            da.Fill(dt);
            //            dataGridView1.DataSource = dt;
            //            dataGridView1.Columns[0].HeaderText = "商品号";
            //            dataGridView1.Columns[1].HeaderText = "商品名";
            //            dataGridView1.Columns[2].HeaderText = "原价";
            //            dataGridView1.Columns[3].HeaderText = "售价";
            //            dataGridView1.Columns[4].HeaderText = "活动价";
            //            dataGridView1.Columns[5].HeaderText = "代理价";
            //            DataGridViewColumn column0 = dataGridView1.Columns[0];
            //            column0.Width = 70;
            //            DataGridViewColumn column1 = dataGridView1.Columns[1];
            //            column1.Width = 235;
            //            DataGridViewColumn column2 = dataGridView1.Columns[2];
            //            column2.Width = 60;
            //            DataGridViewColumn column3 = dataGridView1.Columns[3];
            //            column3.Width = 60;
            //            DataGridViewColumn column4 = dataGridView1.Columns[4];
            //            column4.Width = 70;
            //            DataGridViewColumn column5 = dataGridView1.Columns[5];
            //            column5.Width = 70;

            //        }

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //DataSet set1 = new DataSet();
            //ProductInfobindingSource.DataSource = set1;
            //DataTableCollection tables = set1.Tables;
            //DataView view1 = new DataView(tables[0]);
            //BindingSource source1 = new BindingSource();
            //source1.DataSource = view1;
            //dataGridView1.DataSource = source1;

           

            //BindingSource bs = new BindingSource();
            //bs.DataSource = dataGridView1.DataSource;
            //DataTable dat = (DataTable)(bs.DataSource);

            //if (e.KeyChar == (char)13)
            //{
            //    DataTable dt = new DataTable();
            //    dt = (DataTable)dataGridView1.DataSource;
            //    e.Handled = true;
            //    DataView dv = dt.DefaultView;
            //    dv.RowFilter = string.Format("ProdudctName like '%{0}%'", textBox1.Text);
            //    dataGridView1.DataSource = dv.ToTable();
            //}

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.ProductInfoes.Where(x => x.ProductName.Contains(textBox1.Text)).ToList();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 fm = new Form2();
            fm.Show();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (productInfoBindingSource.Current == null)
                return;
            using (Form_addpt frm = new Form_addpt(null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    productInfoBindingSource.DataSource = db.ProductInfoes.ToList();
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (productInfoBindingSource.Current != null)
            {
                if (MessageBox.Show("确定要删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.ProductInfoes.Remove(productInfoBindingSource.Current as ProductInfo);
                    productInfoBindingSource.RemoveCurrent();
                    db.SaveChanges();

                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (productInfoBindingSource.Current == null)
                return;
            using (Form_addpt frm = new Form_addpt(productInfoBindingSource.Current as ProductInfo))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    productInfoBindingSource.DataSource = db.ProductInfoes.ToList();
            }
        }

     

        private void ProductInfobindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {

        }

        private void searchToolBar1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel6_MouseUp_1(object sender, MouseEventArgs e)
        {
            mouseDown = false;
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
            worksheet.Name = "商品清单";
            // storing header part in Excel  
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView1.Rows.Count ; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
        }

        private void pictureBox1_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }



       
    }
}
