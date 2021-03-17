
namespace InternetShop_Rymanov
{
    partial class Firm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.stampBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Rymanov03_01_InternetShopDataSet = new InternetShop_Rymanov._Rymanov03_01_InternetShopDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stampTableAdapter = new InternetShop_Rymanov._Rymanov03_01_InternetShopDataSetTableAdapters.StampTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.stampBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Rymanov03_01_InternetShopDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBox1.DataSource = this.stampBindingSource;
            this.listBox1.DisplayMember = "Name";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 26;
            this.listBox1.Location = new System.Drawing.Point(316, 99);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(258, 342);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "id_Stamp";
            // 
            // stampBindingSource
            // 
            this.stampBindingSource.DataMember = "Stamp";
            this.stampBindingSource.DataSource = this._Rymanov03_01_InternetShopDataSet;
            // 
            // _Rymanov03_01_InternetShopDataSet
            // 
            this._Rymanov03_01_InternetShopDataSet.DataSetName = "_Rymanov03_01_InternetShopDataSet";
            this._Rymanov03_01_InternetShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(-3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(942, 516);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фирмы с которыми мы работаем";
            // 
            // stampTableAdapter
            // 
            this.stampTableAdapter.ClearBeforeFill = true;
            // 
            // Firm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.groupBox1);
            this.Name = "Firm";
            this.Text = "Инернет магазин";
            this.Load += new System.EventHandler(this.Firm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stampBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Rymanov03_01_InternetShopDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private _Rymanov03_01_InternetShopDataSet _Rymanov03_01_InternetShopDataSet;
        private System.Windows.Forms.BindingSource stampBindingSource;
        private _Rymanov03_01_InternetShopDataSetTableAdapters.StampTableAdapter stampTableAdapter;
    }
}