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
    public partial class Regestration : Form
    {
        public Regestration()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Rymanov03_01_InternetShopDataSet);

        }

        private void Regestration_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Rymanov03_01_InternetShopDataSet.Role". При необходимости она может быть перемещена или удалена.
            this.roleTableAdapter.Fill(this._Rymanov03_01_InternetShopDataSet.Role);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Rymanov03_01_InternetShopDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this._Rymanov03_01_InternetShopDataSet.Users);
            usersBindingSource.AddNew();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.roleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Rymanov03_01_InternetShopDataSet);
            Close();
        }
    }
}
