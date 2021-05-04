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
    public partial class AddItems : Form
    {
        public AddItems()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }

        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            string iname = "";
            string iprice = "";
            string ErrMsg = null;
            if (tb_itemname.Text.Equals(""))
            {
                ErrMsg += "\nInsert Item name!!!";
            }
            else
            {
                iname = tb_itemname.Text;
            }
            if (tb_Itemprice.Text.Equals(""))
            {
                ErrMsg += "\nInsert Item Price!!!";
            }
            else
            {
                iprice = tb_Itemprice.Text;
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
                string query = string.Format("insert into Add_Items values('{0}','{1}')", iname, iprice);
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int r = cmd.ExecuteNonQuery();
                    if (r > 0)
                    {
                        MessageBox.Show("Item Inserted!!!");
                    }
                    else
                    {
                        MessageBox.Show("Item cannot be Inserted!!!");
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

        private void button1_Click(object sender, EventArgs e) //Items Load
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
    }
}
