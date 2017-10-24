using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace jpsale
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
            textbox_password.PasswordChar = '*';
            textbox_username.Text = "bolero";
            
        }


        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

      


        private void button_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textbox_username.Text))
            {
                MessageBox.Show("请输入用户名.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textbox_username.Focus();
                return;
            }
            try
            {
                using (JPsaleEntities test = new JPsaleEntities())
                {
                    var query = from o in test.AdminInfoes
                                where o.Username == textbox_username.Text && o.Password == textbox_password.Text
                                select o;
                    if (query.SingleOrDefault() != null)
                    {
                        //MessageBox.Show("登陆成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Form2 fm2 = new Form2();
                        fm2.Show();

                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textbox_username_OnTextChange(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("/微笑/微笑/微笑 我还能怎样？","mmp", MessageBoxButtons.OK);
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            this.label3.BackColor = Color.Salmon;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            this.label3.BackColor = Color.PeachPuff;
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            this.label4.BackColor = Color.SeaShell;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            this.label4.BackColor = Color.PeachPuff;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textbox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_login_MouseHover(object sender, EventArgs e)
        {
            this.button_login.BackColor = Color.Firebrick;
        }

        private void button_login_MouseLeave(object sender, EventArgs e)
        {
            this.button_login.BackColor = Color.Silver;
        }

        private void textbox_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                e.Handled = true;
                button_login_Click(sender, e);
                
            }
        }
    }
}
