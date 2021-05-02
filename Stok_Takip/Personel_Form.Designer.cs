namespace Stok_Takip
{
    partial class Personel_Form
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
            this.yetkiTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Ekle = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.soyadTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sifreTekrarTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.personelDataGrid = new System.Windows.Forms.DataGridView();
            this.SeriNoLB = new System.Windows.Forms.Label();
            this.Search = new FontAwesome.Sharp.IconButton();
            this.personelComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // yetkiTxt
            // 
            this.yetkiTxt.Location = new System.Drawing.Point(1106, 170);
            this.yetkiTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yetkiTxt.Name = "yetkiTxt";
            this.yetkiTxt.Size = new System.Drawing.Size(119, 20);
            this.yetkiTxt.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.label7.Location = new System.Drawing.Point(983, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 21);
            this.label7.TabIndex = 61;
            this.label7.Text = "Yetki Seviyesi";
            // 
            // Ekle
            // 
            this.Ekle.BackColor = System.Drawing.Color.White;
            this.Ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ekle.FlatAppearance.BorderSize = 0;
            this.Ekle.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Ekle.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ekle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.Ekle.IconChar = FontAwesome.Sharp.IconChar.User;
            this.Ekle.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.Ekle.IconSize = 25;
            this.Ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ekle.Location = new System.Drawing.Point(1106, 306);
            this.Ekle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Ekle.Name = "Ekle";
            this.Ekle.Rotation = 0D;
            this.Ekle.Size = new System.Drawing.Size(119, 32);
            this.Ekle.TabIndex = 60;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = false;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.label3.Location = new System.Drawing.Point(983, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 21);
            this.label3.TabIndex = 59;
            this.label3.Text = "Personel Ekleme";
            // 
            // soyadTxt
            // 
            this.soyadTxt.Location = new System.Drawing.Point(1106, 128);
            this.soyadTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.soyadTxt.Name = "soyadTxt";
            this.soyadTxt.Size = new System.Drawing.Size(119, 20);
            this.soyadTxt.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.label4.Location = new System.Drawing.Point(983, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 57;
            this.label4.Text = "Soyad";
            // 
            // adTxt
            // 
            this.adTxt.Location = new System.Drawing.Point(1106, 83);
            this.adTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adTxt.Name = "adTxt";
            this.adTxt.Size = new System.Drawing.Size(119, 20);
            this.adTxt.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.label5.Location = new System.Drawing.Point(983, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 21);
            this.label5.TabIndex = 55;
            this.label5.Text = "Ad";
            // 
            // sifreTxt
            // 
            this.sifreTxt.Location = new System.Drawing.Point(1106, 214);
            this.sifreTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.PasswordChar = '*';
            this.sifreTxt.Size = new System.Drawing.Size(119, 20);
            this.sifreTxt.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.label1.Location = new System.Drawing.Point(983, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 63;
            this.label1.Text = "Şifre";
            // 
            // sifreTekrarTxt
            // 
            this.sifreTekrarTxt.Location = new System.Drawing.Point(1106, 258);
            this.sifreTekrarTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sifreTekrarTxt.Name = "sifreTekrarTxt";
            this.sifreTekrarTxt.PasswordChar = '*';
            this.sifreTekrarTxt.Size = new System.Drawing.Size(119, 20);
            this.sifreTekrarTxt.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(983, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 65;
            this.label2.Text = "Şifre Tekrar";
            // 
            // personelDataGrid
            // 
            this.personelDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personelDataGrid.Location = new System.Drawing.Point(266, 41);
            this.personelDataGrid.Name = "personelDataGrid";
            this.personelDataGrid.Size = new System.Drawing.Size(396, 182);
            this.personelDataGrid.TabIndex = 67;
           
            // 
            // SeriNoLB
            // 
            this.SeriNoLB.AutoSize = true;
            this.SeriNoLB.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeriNoLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.SeriNoLB.Location = new System.Drawing.Point(262, 256);
            this.SeriNoLB.Name = "SeriNoLB";
            this.SeriNoLB.Size = new System.Drawing.Size(115, 21);
            this.SeriNoLB.TabIndex = 68;
            this.SeriNoLB.Text = "Personel İsim";
            
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
            this.Search.Location = new System.Drawing.Point(423, 306);
            this.Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Search.Name = "Search";
            this.Search.Rotation = 0D;
            this.Search.Size = new System.Drawing.Size(121, 32);
            this.Search.TabIndex = 70;
            this.Search.Text = "Ara";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // personelComboBox
            // 
            this.personelComboBox.FormattingEnabled = true;
            this.personelComboBox.Location = new System.Drawing.Point(423, 256);
            this.personelComboBox.Name = "personelComboBox";
            this.personelComboBox.Size = new System.Drawing.Size(121, 21);
            this.personelComboBox.TabIndex = 71;
           
            // 
            // Personel_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1245, 657);
            this.Controls.Add(this.personelComboBox);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SeriNoLB);
            this.Controls.Add(this.personelDataGrid);
            this.Controls.Add(this.sifreTekrarTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yetkiTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.soyadTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adTxt);
            this.Controls.Add(this.label5);
            this.Name = "Personel_Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Personel_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personelDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox yetkiTxt;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton Ekle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox soyadTxt;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox adTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sifreTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sifreTekrarTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView personelDataGrid;
        private System.Windows.Forms.Label SeriNoLB;
        private FontAwesome.Sharp.IconButton Search;
        private System.Windows.Forms.ComboBox personelComboBox;
    }
}