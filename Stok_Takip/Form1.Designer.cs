namespace Stok_Takip
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.UrunID = new System.Windows.Forms.Label();
            this.AdTxt = new System.Windows.Forms.TextBox();
            this.UrunAdi = new System.Windows.Forms.Label();
            this.EklemeTarihi = new System.Windows.Forms.Label();
            this.CikisTarihi = new System.Windows.Forms.Label();
            this.SeriTxt = new System.Windows.Forms.TextBox();
            this.SeriNo = new System.Windows.Forms.Label();
            this.AdetTxt = new System.Windows.Forms.TextBox();
            this.Adet = new System.Windows.Forms.Label();
            this.Insert = new System.Windows.Forms.Button();
            this.Ekleme = new System.Windows.Forms.DateTimePicker();
            this.Cikis = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Urun Adi";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(215, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // IDtxt
            // 
            this.IDtxt.Location = new System.Drawing.Point(215, 301);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(100, 20);
            this.IDtxt.TabIndex = 5;
            // 
            // UrunID
            // 
            this.UrunID.AutoSize = true;
            this.UrunID.Location = new System.Drawing.Point(85, 304);
            this.UrunID.Name = "UrunID";
            this.UrunID.Size = new System.Drawing.Size(44, 13);
            this.UrunID.TabIndex = 4;
            this.UrunID.Text = "Urun ID";
            // 
            // AdTxt
            // 
            this.AdTxt.Location = new System.Drawing.Point(215, 354);
            this.AdTxt.Name = "AdTxt";
            this.AdTxt.Size = new System.Drawing.Size(100, 20);
            this.AdTxt.TabIndex = 7;
            // 
            // UrunAdi
            // 
            this.UrunAdi.AutoSize = true;
            this.UrunAdi.Location = new System.Drawing.Point(85, 357);
            this.UrunAdi.Name = "UrunAdi";
            this.UrunAdi.Size = new System.Drawing.Size(48, 13);
            this.UrunAdi.TabIndex = 6;
            this.UrunAdi.Text = "Urun Adi";
            // 
            // EklemeTarihi
            // 
            this.EklemeTarihi.AutoSize = true;
            this.EklemeTarihi.Location = new System.Drawing.Point(85, 417);
            this.EklemeTarihi.Name = "EklemeTarihi";
            this.EklemeTarihi.Size = new System.Drawing.Size(71, 13);
            this.EklemeTarihi.TabIndex = 8;
            this.EklemeTarihi.Text = "Ekleme Tarihi";
            // 
            // CikisTarihi
            // 
            this.CikisTarihi.AutoSize = true;
            this.CikisTarihi.Location = new System.Drawing.Point(85, 477);
            this.CikisTarihi.Name = "CikisTarihi";
            this.CikisTarihi.Size = new System.Drawing.Size(58, 13);
            this.CikisTarihi.TabIndex = 10;
            this.CikisTarihi.Text = "Cikis Tarihi";
            // 
            // SeriTxt
            // 
            this.SeriTxt.Location = new System.Drawing.Point(215, 536);
            this.SeriTxt.Name = "SeriTxt";
            this.SeriTxt.Size = new System.Drawing.Size(100, 20);
            this.SeriTxt.TabIndex = 13;
            // 
            // SeriNo
            // 
            this.SeriNo.AutoSize = true;
            this.SeriNo.Location = new System.Drawing.Point(85, 539);
            this.SeriNo.Name = "SeriNo";
            this.SeriNo.Size = new System.Drawing.Size(42, 13);
            this.SeriNo.TabIndex = 12;
            this.SeriNo.Text = "Seri No";
            // 
            // AdetTxt
            // 
            this.AdetTxt.Location = new System.Drawing.Point(215, 595);
            this.AdetTxt.Name = "AdetTxt";
            this.AdetTxt.Size = new System.Drawing.Size(100, 20);
            this.AdetTxt.TabIndex = 15;
            // 
            // Adet
            // 
            this.Adet.AutoSize = true;
            this.Adet.Location = new System.Drawing.Point(85, 598);
            this.Adet.Name = "Adet";
            this.Adet.Size = new System.Drawing.Size(29, 13);
            this.Adet.TabIndex = 14;
            this.Adet.Text = "Adet";
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(559, 417);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 23);
            this.Insert.TabIndex = 16;
            this.Insert.Text = "Ekleme";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Ekleme
            // 
            this.Ekleme.CustomFormat = "MM/dd/yyyy h:mm tt";
            this.Ekleme.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Ekleme.Location = new System.Drawing.Point(215, 410);
            this.Ekleme.Name = "Ekleme";
            this.Ekleme.Size = new System.Drawing.Size(200, 20);
            this.Ekleme.TabIndex = 17;
            // 
            // Cikis
            // 
            this.Cikis.CustomFormat = "MM/dd/yyyy h:mm tt";
            this.Cikis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Cikis.Location = new System.Drawing.Point(215, 470);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(200, 20);
            this.Cikis.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(622, 150);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 666);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cikis);
            this.Controls.Add(this.Ekleme);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.AdetTxt);
            this.Controls.Add(this.Adet);
            this.Controls.Add(this.SeriTxt);
            this.Controls.Add(this.SeriNo);
            this.Controls.Add(this.CikisTarihi);
            this.Controls.Add(this.EklemeTarihi);
            this.Controls.Add(this.AdTxt);
            this.Controls.Add(this.UrunAdi);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.UrunID);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.Label UrunID;
        private System.Windows.Forms.TextBox AdTxt;
        private System.Windows.Forms.Label UrunAdi;
        private System.Windows.Forms.Label EklemeTarihi;
        private System.Windows.Forms.Label CikisTarihi;
        private System.Windows.Forms.TextBox SeriTxt;
        private System.Windows.Forms.Label SeriNo;
        private System.Windows.Forms.TextBox AdetTxt;
        private System.Windows.Forms.Label Adet;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.DateTimePicker Ekleme;
        private System.Windows.Forms.DateTimePicker Cikis;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}