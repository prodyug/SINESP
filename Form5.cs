using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace SINESP
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string connStr = "Server=localhost;Database=sinesp;Uid=root;Pwd=123456";
            const string sql = "select * from pessoa";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {

                    lista.Clear();
                    conn.Open();
                    var r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        lista.Text += "\r\n" + r["cpf"] +r["crime"];




                    }



                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
