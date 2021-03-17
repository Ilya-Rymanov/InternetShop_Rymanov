
namespace InternetShop_Rymanov
{
    partial class City
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.shoppDataGridView = new System.Windows.Forms.DataGridView();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Rymanov03_01_InternetShopDataSet = new InternetShop_Rymanov._Rymanov03_01_InternetShopDataSet();
            this.shoppBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.shoppTableAdapter = new InternetShop_Rymanov._Rymanov03_01_InternetShopDataSetTableAdapters.ShoppTableAdapter();
            this.tableAdapterManager = new InternetShop_Rymanov._Rymanov03_01_InternetShopDataSetTableAdapters.TableAdapterManager();
            this.cityTableAdapter = new InternetShop_Rymanov._Rymanov03_01_InternetShopDataSetTableAdapters.CityTableAdapter();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shoppDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Rymanov03_01_InternetShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.shoppDataGridView);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(-1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(940, 513);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Адреса наших магазинов";
            // 
            // shoppDataGridView
            // 
            this.shoppDataGridView.AllowUserToAddRows = false;
            this.shoppDataGridView.AllowUserToDeleteRows = false;
            this.shoppDataGridView.AutoGenerateColumns = false;
            this.shoppDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.shoppDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shoppDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2});
            this.shoppDataGridView.DataSource = this.shoppBindingSource;
            this.shoppDataGridView.Location = new System.Drawing.Point(142, 85);
            this.shoppDataGridView.Name = "shoppDataGridView";
            this.shoppDataGridView.ReadOnly = true;
            this.shoppDataGridView.Size = new System.Drawing.Size(644, 359);
            this.shoppDataGridView.TabIndex = 5;
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "City";
            this.cityBindingSource.DataSource = this._Rymanov03_01_InternetShopDataSet;
            // 
            // _Rymanov03_01_InternetShopDataSet
            // 
            this._Rymanov03_01_InternetShopDataSet.DataSetName = "_Rymanov03_01_InternetShopDataSet";
            this._Rymanov03_01_InternetShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shoppBindingSource
            // 
            this.shoppBindingSource.DataMember = "Shopp";
            this.shoppBindingSource.DataSource = this._Rymanov03_01_InternetShopDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // shoppTableAdapter
            // 
            this.shoppTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.ArcticleTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CityTableAdapter = this.cityTableAdapter;
            this.tableAdapterManager.DeliveriesTableAdapter = null;
            this.tableAdapterManager.GuaranteeTableAdapter = null;
            this.tableAdapterManager.ModelTableAdapter = null;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.ShoppTableAdapter = this.shoppTableAdapter;
            this.tableAdapterManager.StampTableAdapter = null;
            this.tableAdapterManager.TypePaymentTableAdapter = null;
            this.tableAdapterManager.TypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = InternetShop_Rymanov._Rymanov03_01_InternetShopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_City";
            this.dataGridViewTextBoxColumn4.DataSource = this.cityBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Город";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "id_City";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn3.HeaderText = "Адресс";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn2.HeaderText = "Почта";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // City
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.groupBox1);
            this.Name = "City";
            this.Text = "Инернет магазин";
            this.Load += new System.EventHandler(this.City_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shoppDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Rymanov03_01_InternetShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private _Rymanov03_01_InternetShopDataSet _Rymanov03_01_InternetShopDataSet;
        private System.Windows.Forms.BindingSource shoppBindingSource;
        private _Rymanov03_01_InternetShopDataSetTableAdapters.ShoppTableAdapter shoppTableAdapter;
        private _Rymanov03_01_InternetShopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView shoppDataGridView;
        private _Rymanov03_01_InternetShopDataSetTableAdapters.CityTableAdapter cityTableAdapter;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}