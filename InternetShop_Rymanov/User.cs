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
    public partial class User : Form
    {
        private string Phone;
        public User(string Phone)
        {
            InitializeComponent();
            this.Phone = Phone;
        }

        private void User_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Rymanov03_01_InternetShopDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this._Rymanov03_01_InternetShopDataSet.User);

            phoneToolStripTextBox.Text = Phone;

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.selectPhoneTableAdapter.Fill(this._Rymanov03_01_InternetShopDataSet.SelectPhone, new System.Nullable<long>(((long)(System.Convert.ChangeType(phoneToolStripTextBox.Text, typeof(long))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void phoneToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            this.selectPhoneTableAdapter.Fill(this._Rymanov03_01_InternetShopDataSet.SelectPhone, new System.Nullable<long>(((long)(System.Convert.ChangeType(phoneToolStripTextBox.Text, typeof(long))))));

        }
    }
}
