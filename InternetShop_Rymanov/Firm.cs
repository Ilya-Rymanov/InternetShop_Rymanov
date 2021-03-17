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
    public partial class Firm : Form
    {
        public Firm()
        {
            InitializeComponent();
        }

        private void Firm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Rymanov03_01_InternetShopDataSet.Stamp". При необходимости она может быть перемещена или удалена.
            this.stampTableAdapter.Fill(this._Rymanov03_01_InternetShopDataSet.Stamp);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
