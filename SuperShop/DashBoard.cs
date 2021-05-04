using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShop
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e) //Add Items
        {
            this.Hide();
            new AddItems().Show();
        }

        private void button4_Click(object sender, EventArgs e) //Delete Items
        {
            this.Hide();
            new Delete().Show();
        }

        private void button3_Click(object sender, EventArgs e) //Search and update
        {
            this.Hide();
            new Search_Update().Show();
        }

        private void bt_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
    }
}
