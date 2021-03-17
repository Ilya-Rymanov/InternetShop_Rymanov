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
    public partial class Zakaz : Form
    {
        public Zakaz()
        {
            InitializeComponent();
        }

        private void Zakaz_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Rymanov03_01_InternetShopDataSet.TypePayment". При необходимости она может быть перемещена или удалена.
            this.typePaymentTableAdapter.Fill(this._Rymanov03_01_InternetShopDataSet.TypePayment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Rymanov03_01_InternetShopDataSet.Account". При необходимости она может быть перемещена или удалена.
            this.accountTableAdapter.Fill(this._Rymanov03_01_InternetShopDataSet.Account);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Rymanov03_01_InternetShopDataSet.Arcticle". При необходимости она может быть перемещена или удалена.
            this.arcticleTableAdapter.Fill(this._Rymanov03_01_InternetShopDataSet.Arcticle);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Rymanov03_01_InternetShopDataSet.Guarantee". При необходимости она может быть перемещена или удалена.
            this.guaranteeTableAdapter.Fill(this._Rymanov03_01_InternetShopDataSet.Guarantee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Rymanov03_01_InternetShopDataSet.Model". При необходимости она может быть перемещена или удалена.
            this.modelTableAdapter.Fill(this._Rymanov03_01_InternetShopDataSet.Model);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Rymanov03_01_InternetShopDataSet.Stamp". При необходимости она может быть перемещена или удалена.
            this.stampTableAdapter.Fill(this._Rymanov03_01_InternetShopDataSet.Stamp);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Rymanov03_01_InternetShopDataSet.Type". При необходимости она может быть перемещена или удалена.
            this.typeTableAdapter.Fill(this._Rymanov03_01_InternetShopDataSet.Type);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Rymanov03_01_InternetShopDataSet.Deliveries". При необходимости она может быть перемещена или удалена.
            this.deliveriesTableAdapter.Fill(this._Rymanov03_01_InternetShopDataSet.Deliveries);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Rymanov03_01_InternetShopDataSet.Tovary". При необходимости она может быть перемещена или удалена.
            deliveriesBindingSource.AddNew();
            typeBindingSource.AddNew();
            stampBindingSource.AddNew();
            modelBindingSource.AddNew();
            guaranteeBindingSource.AddNew();
            //arcticleBindingSource.AddNew();
            accountBindingSource.AddNew();

        }

        private void deliveriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.deliveriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Rymanov03_01_InternetShopDataSet);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
