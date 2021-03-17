using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetShop_Rymanov
{
    public partial class Autorization : Form
    {
        private string Phone;
        public Autorization()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Regestration reg = new Regestration();
            reg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=sbd\mssql;Initial Catalog=Rymanov03.01-InternetShop;Integrated Security=True");
                SqlDataAdapter sda1 = new SqlDataAdapter("Select Count(*) from Users where Phone='" + textBox1.Text + "' and Password='" + textBox2.Text + "'", con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                if (textBox2.Text != "" || textBox1.Text != "" || textBox2.Text == "" || textBox1.Text == "")
                {
                    if (dt1.Rows[0][0].ToString() == "1")
                    {
                        Phone = (textBox1.Text);
                        Menu menu = new Menu(Phone);
                        this.Hide();
                        menu.Show();

                    }
                    else MessageBox.Show("Неверный логин или пароль");
                }

            }
            catch
            {

            }
        }

        
    }
}
