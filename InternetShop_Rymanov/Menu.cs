using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetShop_Rymanov
{
    public partial class Menu : Form
    {
        private string Phone;
        public Menu(string Phone)
        {
            InitializeComponent();
            this.Phone = Phone;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tovar tovar = new Tovar();
            tovar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Firm firm = new Firm();
            firm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            User user = new User(Phone);
            user.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders(Phone);
            orders.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            City city = new City();
            city.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Zakaz zakaz = new Zakaz();
            zakaz.Show();
        }
    }
}
