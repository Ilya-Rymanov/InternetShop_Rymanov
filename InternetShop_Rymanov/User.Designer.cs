
namespace InternetShop_Rymanov
{
    partial class User
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
            this.selectPhoneDataGridView = new System.Windows.Forms.DataGridView();
            this.selectPhoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Rymanov03_01_InternetShopDataSet = new InternetShop_Rymanov._Rymanov03_01_InternetShopDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new InternetShop_Rymanov._Rymanov03_01_InternetShopDataSetTableAdapters.UserTableAdapter();
            this.tableAdapterManager = new InternetShop_Rymanov._Rymanov03_01_InternetShopDataSetTableAdapters.TableAdapterManager();
            this.selectUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectUserBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.selectUserBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.selectPhoneTableAdapter = new InternetShop_Rymanov._Rymanov03_01_InternetShopDataSetTableAdapters.SelectPhoneTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.phoneToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.phoneToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectPhoneDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectPhoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Rymanov03_01_InternetShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectUserBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectUserBindingSource2)).BeginInit();
            this.fillToolStrip.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.selectPhoneDataGridView);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(2, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(936, 528);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Мой аккаунт";
            // 
            // selectPhoneDataGridView
            // 
            this.selectPhoneDataGridView.AllowUserToAddRows = false;
            this.selectPhoneDataGridView.AllowUserToDeleteRows = false;
            this.selectPhoneDataGridView.AutoGenerateColumns = false;
            this.selectPhoneDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.selectPhoneDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectPhoneDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.selectPhoneDataGridView.DataSource = this.selectPhoneBindingSource;
            this.selectPhoneDataGridView.Location = new System.Drawing.Point(88, 140);
            this.selectPhoneDataGridView.Name = "selectPhoneDataGridView";
            this.selectPhoneDataGridView.ReadOnly = true;
            this.selectPhoneDataGridView.Size = new System.Drawing.Size(744, 230);
            this.selectPhoneDataGridView.TabIndex = 6;
            // 
            // selectPhoneBindingSource
            // 
            this.selectPhoneBindingSource.DataMember = "SelectPhone";
            this.selectPhoneBindingSource.DataSource = this._Rymanov03_01_InternetShopDataSet;
            // 
            // _Rymanov03_01_InternetShopDataSet
            // 
            this._Rymanov03_01_InternetShopDataSet.DataSetName = "_Rymanov03_01_InternetShopDataSet";
            this._Rymanov03_01_InternetShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this._Rymanov03_01_InternetShopDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
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
            // selectUserBindingSource
            // 
            this.selectUserBindingSource.DataSource = this._Rymanov03_01_InternetShopDataSet;
            this.selectUserBindingSource.Position = 0;
            // 
            // selectUserBindingSource1
            // 
            this.selectUserBindingSource1.DataSource = this._Rymanov03_01_InternetShopDataSet;
            this.selectUserBindingSource1.Position = 0;
            // 
            // selectUserBindingSource2
            // 
            this.selectUserBindingSource2.DataSource = this._Rymanov03_01_InternetShopDataSet;
            this.selectUserBindingSource2.Position = 0;
            // 
            // selectPhoneTableAdapter
            // 
            this.selectPhoneTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phoneToolStripLabel,
            this.phoneToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(938, 25);
            this.fillToolStrip.TabIndex = 10;
            this.fillToolStrip.Text = "fillToolStrip";
            this.fillToolStrip.Visible = false;
            // 
            // phoneToolStripLabel
            // 
            this.phoneToolStripLabel.Name = "phoneToolStripLabel";
            this.phoneToolStripLabel.Size = new System.Drawing.Size(44, 22);
            this.phoneToolStripLabel.Text = "Phone:";
            // 
            // phoneToolStripTextBox
            // 
            this.phoneToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phoneToolStripTextBox.Name = "phoneToolStripTextBox";
            this.phoneToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.phoneToolStripTextBox.TextChanged += new System.EventHandler(this.phoneToolStripTextBox_TextChanged);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn1.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn2.HeaderText = "Пароль";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Firstname";
            this.dataGridViewTextBoxColumn4.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Lastname";
            this.dataGridViewTextBoxColumn5.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn6.HeaderText = "Email";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Expr1";
            this.dataGridViewTextBoxColumn7.HeaderText = "Роль";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.groupBox1);
            this.Name = "User";
            this.Text = "Инернет магазин";
            this.Load += new System.EventHandler(this.User_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selectPhoneDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectPhoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Rymanov03_01_InternetShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectUserBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectUserBindingSource2)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private _Rymanov03_01_InternetShopDataSet _Rymanov03_01_InternetShopDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private _Rymanov03_01_InternetShopDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private _Rymanov03_01_InternetShopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource selectUserBindingSource;
        private System.Windows.Forms.BindingSource selectUserBindingSource1;
        private System.Windows.Forms.BindingSource selectUserBindingSource2;
        private System.Windows.Forms.BindingSource selectPhoneBindingSource;
        private _Rymanov03_01_InternetShopDataSetTableAdapters.SelectPhoneTableAdapter selectPhoneTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel phoneToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox phoneToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView selectPhoneDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}