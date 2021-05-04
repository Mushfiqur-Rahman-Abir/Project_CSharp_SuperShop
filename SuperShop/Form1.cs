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

namespace SuperShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e) //btn_register
        {
            new Registration().Show();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string ErrMsg = null;
            string uname = "";
            string password = "";

            if(tb_uname.Text.Equals(""))
            {
                ErrMsg += "\nUsername Required!!!";
            }
            else
            {
                uname = tb_uname.Text;
            }
            if(tb_pass.Text.Equals(""))
            {
                ErrMsg += "\nPassword Required!!!";
            }
            else
            {
                password = tb_pass.Text;
            }
            
            
            if(ErrMsg == null)
            {
                var conn = Database.ConnectDB();
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                string query = string.Format("select * from LogIn where username='{0}' and password='{1}'", uname, password);
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Login Successful!!!");
                        this.Hide();
                        new DashBoard().Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid user!!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                conn.Close();
            }
            else
            {
                MessageBox.Show(ErrMsg);
            }

            
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
