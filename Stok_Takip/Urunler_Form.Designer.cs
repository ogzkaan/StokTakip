namespace Stok_Takip
{
    partial class Urunler_Form
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
            this.UrunDataGrid = new System.Windows.Forms.DataGridView();
            this.adetCheck = new System.Windows.Forms.CheckBox();
            this.modelCheck = new System.Windows.Forms.CheckBox();
            this.markaCheck = new System.Windows.Forms.CheckBox();
            this.tipCheck = new System.Windows.Forms.CheckBox();
            this.seriCheck = new System.Windows.Forms.CheckBox();
            this.Search = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.markaComboBox = new System.Windows.Forms.ComboBox();
            this.tipComboBox = new System.Windows.Forms.ComboBox();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.adetTxt = new System.Windows.Forms.TextBox();
            this.Adet = new System.Windows.Forms.Label();
            this.seriNoTxt = new System.Windows.Forms.TextBox();
            this.SeriNoLB = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.idNoGC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.giris_cikisDG = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Change = new FontAwesome.Sharp.IconButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UrunDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giris_cikisDG)).BeginInit();
            this.SuspendLayout();
            // 
            // UrunDataGrid
            // 
            this.UrunDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UrunDataGrid.Location = new System.Drawing.Point(12, 12);
            this.UrunDataGrid.Name = "UrunDataGrid";
            this.UrunDataGrid.Size = new System.Drawing.Size(651, 239);
            this.UrunDataGrid.TabIndex = 0;
            // 
            // adetCheck
            // 
            this.adetCheck.AutoSize = true;
            this.adetCheck.Location = new System.Drawing.Point(449, 515);
            this.adetCheck.Name = "adetCheck";
            this.adetCheck.Size = new System.Drawing.Size(15, 14);
            this.adetCheck.TabIndex = 70;
            this.adetCheck.UseVisualStyleBackColor = true;
            // 
            // modelCheck
            // 
            this.modelCheck.AutoSize = true;
            this.modelCheck.Location = new System.Drawing.Point(449, 467);
            this.modelCheck.Name = "modelCheck";
            this.modelCheck.Size = new System.Drawing.Size(15, 14);
            this.modelCheck.TabIndex = 69;
            this.modelCheck.UseVisualStyleBackColor = true;
            // 
            // markaCheck
            // 
            this.markaCheck.AutoSize = true;
            this.markaCheck.Location = new System.Drawing.Point(449, 418);
            this.markaCheck.Name = "markaCheck";
            this.markaCheck.Size = new System.Drawing.Size(15, 14);
            this.markaCheck.TabIndex = 68;
            this.markaCheck.UseVisualStyleBackColor = true;
            // 
            // tipCheck
            // 
            this.tipCheck.AutoSize = true;
            this.tipCheck.Location = new System.Drawing.Point(449, 373);
            this.tipCheck.Name = "tipCheck";
            this.tipCheck.Size = new System.Drawing.Size(15, 14);
            this.tipCheck.TabIndex = 67;
            this.tipCheck.UseVisualStyleBackColor = true;
            // 
            // seriCheck
            // 
            this.seriCheck.AutoSize = true;
            this.seriCheck.Location = new System.Drawing.Point(449, 324);
            this.seriCheck.Name = "seriCheck";
            this.seriCheck.Size = new System.Drawing.Size(15, 14);
            this.seriCheck.TabIndex = 66;
            this.seriCheck.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.White;
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Search.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.Search.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.Search.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.Search.IconSize = 25;
            this.Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Search.Location = new System.Drawing.Point(298, 554);
            this.Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Search.Name = "Search";
            this.Search.Rotation = 0D;
            this.Search.Size = new System.Drawing.Size(120, 32);
            this.Search.TabIndex = 65;
            this.Search.Text = "Ara";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.label10.Location = new System.Drawing.Point(149, 414);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 21);
            this.label10.TabIndex = 63;
            this.label10.Text = "Marka Seçimi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.label9.Location = new System.Drawing.Point(149, 463);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 21);
            this.label9.TabIndex = 62;
            this.label9.Text = "Model Seçimi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.label8.Location = new System.Drawing.Point(149, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 21);
            this.label8.TabIndex = 61;
            this.label8.Text = "Tip Seçimi";
            // 
            // markaComboBox
            // 
            this.markaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.markaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.markaComboBox.FormattingEnabled = true;
            this.markaComboBox.Location = new System.Drawing.Point(298, 414);
            this.markaComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.markaComboBox.Name = "markaComboBox";
            this.markaComboBox.Size = new System.Drawing.Size(120, 21);
            this.markaComboBox.TabIndex = 60;
            // 
            // tipComboBox
            // 
            this.tipComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tipComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tipComboBox.FormattingEnabled = true;
            this.tipComboBox.Location = new System.Drawing.Point(298, 369);
            this.tipComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tipComboBox.Name = "tipComboBox";
            this.tipComboBox.Size = new System.Drawing.Size(120, 21);
            this.tipComboBox.TabIndex = 59;
            // 
            // modelComboBox
            // 
            this.modelComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.modelComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(298, 463);
            this.modelComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(120, 21);
            this.modelComboBox.TabIndex = 58;
            // 
            // adetTxt
            // 
            this.adetTxt.Location = new System.Drawing.Point(298, 511);
            this.adetTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adetTxt.Name = "adetTxt";
            this.adetTxt.Size = new System.Drawing.Size(120, 20);
            this.adetTxt.TabIndex = 56;
            // 
            // Adet
            // 
            this.Adet.AutoSize = true;
            this.Adet.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.Adet.Location = new System.Drawing.Point(149, 511);
            this.Adet.Name = "Adet";
            this.Adet.Size = new System.Drawing.Size(46, 21);
            this.Adet.TabIndex = 55;
            this.Adet.Text = "Adet";
            // 
            // seriNoTxt
            // 
            this.seriNoTxt.Location = new System.Drawing.Point(298, 320);
            this.seriNoTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.seriNoTxt.Name = "seriNoTxt";
            this.seriNoTxt.Size = new System.Drawing.Size(120, 20);
            this.seriNoTxt.TabIndex = 54;
            // 
            // SeriNoLB
            // 
            this.SeriNoLB.AutoSize = true;
            this.SeriNoLB.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeriNoLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.SeriNoLB.Location = new System.Drawing.Point(149, 320);
            this.SeriNoLB.Name = "SeriNoLB";
            this.SeriNoLB.Size = new System.Drawing.Size(65, 21);
            this.SeriNoLB.TabIndex = 53;
            this.SeriNoLB.Text = "Seri No";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.iconButton1.IconSize = 25;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(1028, 355);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(120, 32);
            this.iconButton1.TabIndex = 82;
            this.iconButton1.Text = " Ara";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // idNoGC
            // 
            this.idNoGC.Location = new System.Drawing.Point(1028, 318);
            this.idNoGC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idNoGC.Name = "idNoGC";
            this.idNoGC.Size = new System.Drawing.Size(120, 20);
            this.idNoGC.TabIndex = 73;
            this.idNoGC.TextChanged += new System.EventHandler(this.idNoGC_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.label5.Location = new System.Drawing.Point(954, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 72;
            this.label5.Text = "ID No";
            // 
            // giris_cikisDG
            // 
            this.giris_cikisDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.giris_cikisDG.Location = new System.Drawing.Point(748, 12);
            this.giris_cikisDG.Name = "giris_cikisDG";
            this.giris_cikisDG.Size = new System.Drawing.Size(590, 239);
            this.giris_cikisDG.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.label1.Location = new System.Drawing.Point(238, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 83;
            this.label1.Text = "Ürün Arama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(954, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 21);
            this.label2.TabIndex = 84;
            this.label2.Text = "Ürün Giriş Tarihi Arama";
            // 
            // Change
            // 
            this.Change.BackColor = System.Drawing.Color.White;
            this.Change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Change.FlatAppearance.BorderSize = 0;
            this.Change.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Change.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.Change.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            this.Change.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.Change.IconSize = 25;
            this.Change.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Change.Location = new System.Drawing.Point(907, 269);
            this.Change.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Change.Name = "Change";
            this.Change.Rotation = 0D;
            this.Change.Size = new System.Drawing.Size(41, 28);
            this.Change.TabIndex = 85;
            this.Change.UseVisualStyleBackColor = false;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Urunler_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1404, 626);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.idNoGC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.giris_cikisDG);
            this.Controls.Add(this.adetCheck);
            this.Controls.Add(this.modelCheck);
            this.Controls.Add(this.markaCheck);
            this.Controls.Add(this.tipCheck);
            this.Controls.Add(this.seriCheck);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.markaComboBox);
            this.Controls.Add(this.tipComboBox);
            this.Controls.Add(this.modelComboBox);
            this.Controls.Add(this.adetTxt);
            this.Controls.Add(this.Adet);
            this.Controls.Add(this.seriNoTxt);
            this.Controls.Add(this.SeriNoLB);
            this.Controls.Add(this.UrunDataGrid);
            this.Name = "Urunler_Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Urunler_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UrunDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giris_cikisDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UrunDataGrid;
        private System.Windows.Forms.CheckBox adetCheck;
        private System.Windows.Forms.CheckBox modelCheck;
        private System.Windows.Forms.CheckBox markaCheck;
        private System.Windows.Forms.CheckBox tipCheck;
        private System.Windows.Forms.CheckBox seriCheck;
        private FontAwesome.Sharp.IconButton Search;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox markaComboBox;
        private System.Windows.Forms.ComboBox tipComboBox;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.TextBox adetTxt;
        private System.Windows.Forms.Label Adet;
        private System.Windows.Forms.TextBox seriNoTxt;
        private System.Windows.Forms.Label SeriNoLB;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox idNoGC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView giris_cikisDG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton Change;
        private System.Windows.Forms.Timer timer1;
    }
}