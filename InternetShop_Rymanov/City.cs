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
    public partial class City : Form
    {
        public City()
        {
            InitializeComponent();
        }

        private void shoppBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.shoppBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Rymanov03_01_InternetShopDataSet);

        }

        private void City_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Rymanov03_01_InternetShopDataSet.City". При необходимости она может быть перемещена или удалена.
            this.cityTableAdapter.Fill(this._Rymanov03_01_InternetShopDataSet.City);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Rymanov03_01_InternetShopDataSet.Shopp". При необходимости она может быть перемещена или удалена.
            this.shoppTableAdapter.Fill(this._Rymanov03_01_InternetShopDataSet.Shopp);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
