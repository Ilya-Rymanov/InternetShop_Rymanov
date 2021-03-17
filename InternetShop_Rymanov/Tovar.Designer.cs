
namespace InternetShop_Rymanov
{
    partial class Tovar
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ZAKAZ_Muve = new System.Windows.Forms.Button();
            this.tovaryDataGridView = new System.Windows.Forms.DataGridView();
            this.tovaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Rymanov03_01_InternetShopDataSet = new InternetShop_Rymanov._Rymanov03_01_InternetShopDataSet();
            this.tovaryTableAdapter = new InternetShop_Rymanov._Rymanov03_01_InternetShopDataSetTableAdapters.TovaryTableAdapter();
            this.tableAdapterManager = new InternetShop_Rymanov._Rymanov03_01_InternetShopDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tovaryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Rymanov03_01_InternetShopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ZAKAZ_Muve);
            this.groupBox1.Controls.Add(this.tovaryDataGridView);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(-4, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(947, 529);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список товаров";
            // 
            // ZAKAZ_Muve
            // 
            this.ZAKAZ_Muve.Location = new System.Drawing.Point(595, 457);
            this.ZAKAZ_Muve.Name = "ZAKAZ_Muve";
            this.ZAKAZ_Muve.Size = new System.Drawing.Size(321, 43);
            this.ZAKAZ_Muve.TabIndex = 7;
            this.ZAKAZ_Muve.Text = "Перейти к офрмлению заказа";
            this.ZAKAZ_Muve.UseVisualStyleBackColor = true;
            this.ZAKAZ_Muve.Click += new System.EventHandler(this.ZAKAZ_Muve_Click);
            // 
            // tovaryDataGridView
            // 
            this.tovaryDataGridView.AllowUserToAddRows = false;
            this.tovaryDataGridView.AllowUserToDeleteRows = false;
            this.tovaryDataGridView.AutoGenerateColumns = false;
            this.tovaryDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tovaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tovaryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewImageColumn1});
            this.tovaryDataGridView.DataSource = this.tovaryBindingSource;
            this.tovaryDataGridView.Location = new System.Drawing.Point(12, 101);
            this.tovaryDataGridView.Name = "tovaryDataGridView";
            this.tovaryDataGridView.ReadOnly = true;
            this.tovaryDataGridView.Size = new System.Drawing.Size(904, 310);
            this.tovaryDataGridView.TabIndex = 6;
            this.tovaryDataGridView.DoubleClick += new System.EventHandler(this.tovaryDataGridView_DoubleClick);
            // 
            // tovaryBindingSource
            // 
            this.tovaryBindingSource.DataMember = "Tovary";
            this.tovaryBindingSource.DataSource = this._Rymanov03_01_InternetShopDataSet;
            // 
            // _Rymanov03_01_InternetShopDataSet
            // 
            this._Rymanov03_01_InternetShopDataSet.DataSetName = "_Rymanov03_01_InternetShopDataSet";
            this._Rymanov03_01_InternetShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tovaryTableAdapter
            // 
            this.tovaryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.ArcticleTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CityTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DeliveriesTableAdapter = null;
            this.tableAdapterManager.GuaranteeTableAdapter = null;
            this.tableAdapterManager.ModelTableAdapter = null;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.ShoppTableAdapter = null;
            this.tableAdapterManager.StampTableAdapter = null;
            this.tableAdapterManager.TypePaymentTableAdapter = null;
            this.tableAdapterManager.TypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = InternetShop_Rymanov._Rymanov03_01_InternetShopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Категория";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 130;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Expr2";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фирма";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Expr1";
            this.dataGridViewTextBoxColumn3.HeaderText = "Модель";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn4.HeaderText = "Гарантия";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn5.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn7.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "image";
            this.dataGridViewImageColumn1.HeaderText = "Изображение";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 130;
            // 
            // Tovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.groupBox1);
            this.Name = "Tovar";
            this.Text = "Инернет магазин";
            this.Load += new System.EventHandler(this.Tovar_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tovaryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Rymanov03_01_InternetShopDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private _Rymanov03_01_InternetShopDataSet _Rymanov03_01_InternetShopDataSet;
        private System.Windows.Forms.BindingSource tovaryBindingSource;
        private _Rymanov03_01_InternetShopDataSetTableAdapters.TovaryTableAdapter tovaryTableAdapter;
        private _Rymanov03_01_InternetShopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tovaryDataGridView;
        private System.Windows.Forms.Button ZAKAZ_Muve;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}