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
    public partial class Orders : Form
    {
        private string Phone;
        public Orders(string Phone)
        {
            InitializeComponent();
            this.Phone = Phone;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.selectOrdersMyTableAdapter.Fill(this._Rymanov03_01_InternetShopDataSet.selectOrdersMy, new System.Nullable<long>(((long)(System.Convert.ChangeType(phoneToolStripTextBox.Text, typeof(long))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void phoneToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            this.selectOrdersMyTableAdapter.Fill(this._Rymanov03_01_InternetShopDataSet.selectOrdersMy, new System.Nullable<long>(((long)(System.Convert.ChangeType(phoneToolStripTextBox.Text, typeof(long))))));

        }

        private void Orders_Load(object sender, EventArgs e)
        {
            phoneToolStripTextBox.Text = Phone;
        }
    }
}
