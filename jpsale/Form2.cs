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
    public partial class Form2 : System.Windows.Forms.Form
    {

       // Point lastPoint;
        public Form2()
        {
            InitializeComponent();
        }

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox1_close.BackColor = Color.Salmon;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox1_close.BackColor = Color.PeachPuff;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {   
            WindowState = FormWindowState.Minimized;
        }

        //private void pictureBox2_Click(object sender, EventArgs e)
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

        /// <summary>
        /// movement
        /// </summary>
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form_ctmgt cm = new Form_ctmgt();
            cm.Show();
            
        }

        private void pictureBox1_MouseHover_1(object sender, EventArgs e)
        {
            this.pictureBox1.BackColor = Color.AliceBlue;
        }

        private void pictureBox1_MouseLeave_1(object sender, EventArgs e)
        {
            this.pictureBox1.BackColor = Color.Snow;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox2.BackColor = Color.Beige;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox2.BackColor = Color.Snow;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ptmgt fm = new Form_ptmgt();
            fm.Show();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox3.BackColor = Color.PaleGoldenrod;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox3.BackColor = Color.Snow;
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form_purchase fm = new Form_purchase();
            fm.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_trademgt fm = new Form_trademgt();
            fm.Show();
            
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox4.BackColor = Color.Azure;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox4.BackColor = Color.Snow;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox5.BackColor = Color.Azure;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox5.BackColor = Color.Snow;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Ordermgt fm = new Form_Ordermgt();
            fm.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
