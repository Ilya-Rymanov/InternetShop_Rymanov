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
    public partial class Tovar : Form
    {
        
        public Tovar()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Tovar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Rymanov03_01_InternetShopDataSet.Tovary". При необходимости она может быть перемещена или удалена.
            this.tovaryTableAdapter.Fill(this._Rymanov03_01_InternetShopDataSet.Tovary);

        }

        private void ZAKAZ_Muve_Click(object sender, EventArgs e)
        {
            Zakaz orders = new Zakaz();
            orders.Show();
        }

        private void tovaryDataGridView_DoubleClick(object sender, EventArgs e)
        {
            Zakaz orders = new Zakaz();
            orders.Show();
        }
    }
}
