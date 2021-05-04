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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }

        private void bt_Load_Click(object sender, EventArgs e)
        {
            var conn = Database.ConnectDB();
            List<Items> Add_Items = new List<Items>();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            try
            {
                string query = "select * from Add_Items";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Items a = new Items();
                    a.id = reader.GetInt32(reader.GetOrdinal("id"));
                    a.name = reader.GetString(reader.GetOrdinal("name"));
                    a.price = reader.GetString(reader.GetOrdinal("price"));
                    Add_Items.Add(a);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            dtItems.DataSource = Add_Items;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DashBoard().Show();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            var conn = Database.ConnectDB();

            conn.Open();
            int id = Int32.Parse(tb_SrchId.Text);
            string query = "select * from Add_Items where id=" + id;
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Items i = new Items();
            while (reader.Read())
            {
                i.id = reader.GetInt32(reader.GetOrdinal("id"));
                i.name = reader.GetString(reader.GetOrdinal("name"));
                i.price = reader.GetString(reader.GetOrdinal("price"));
            }


            tb_InameUpdate.Text = i.name;
            tb_IpriceUpdate.Text = i.price;
            conn.Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(tb_SrchId.Text);
            string iname = tb_InameUpdate.Text;
            string iprice = tb_IpriceUpdate.Text;

            var conn = Database.ConnectDB();
            conn.Open();
            string query = string.Format("delete from Add_Items where id='{0}'", id);
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                if(r > 0)
                {
                    MessageBox.Show("Item Deleted!!!");
                }
                else
                {
                    MessageBox.Show("Fail to Delete Item!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
    }
}

