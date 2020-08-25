namespace Stok_Takip
{
    partial class Islemler
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.seriNoTxt = new System.Windows.Forms.TextBox();
            this.SeriNoLB = new System.Windows.Forms.Label();
            this.adetTxt = new System.Windows.Forms.TextBox();
            this.Adet = new System.Windows.Forms.Label();
            this.UrunDataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exitAdetText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.exitSeriText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.tipComboBox = new System.Windows.Forms.ComboBox();
            this.markaComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.silmeTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Add = new FontAwesome.Sharp.IconButton();
            this.DecBtn = new FontAwesome.Sharp.IconButton();
            this.Delete = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UrunDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // seriNoTxt
            // 
            this.seriNoTxt.Location = new System.Drawing.Point(426, 382);
            this.seriNoTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.seriNoTxt.Name = "seriNoTxt";
            this.seriNoTxt.Size = new System.Drawing.Size(120, 20);
            this.seriNoTxt.TabIndex = 13;
            this.seriNoTxt.TextChanged += new System.EventHandler(this.seriNoTxt_TextChanged);
            // 
            // SeriNoLB
            // 
            this.SeriNoLB.AutoSize = true;
            this.SeriNoLB.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeriNoLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.SeriNoLB.Location = new System.Drawing.Point(296, 382);
            this.SeriNoLB.Name = "SeriNoLB";
            this.SeriNoLB.Size = new System.Drawing.Size(65, 21);
            this.SeriNoLB.TabIndex = 12;
            this.SeriNoLB.Text = "Seri No";
            // 
            // adetTxt
            // 
            this.adetTxt.Location = new System.Drawing.Point(426, 573);
            this.adetTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adetTxt.Name = "adetTxt";
            this.adetTxt.Size = new System.Drawing.Size(120, 20);
            this.adetTxt.TabIndex = 15;
            // 
            // Adet
            // 
            this.Adet.AutoSize = true;
            this.Adet.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.Adet.Location = new System.Drawing.Point(296, 573);
            this.Adet.Name = "Adet";
            this.Adet.Size = new System.Drawing.Size(46, 21);
            this.Adet.TabIndex = 14;
            this.Adet.Text = "Adet";
            // 
            // UrunDataGrid
            // 
            this.UrunDataGrid.AllowUserToAddRows = false;
            this.UrunDataGrid.AllowUserToDeleteRows = false;
            this.UrunDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.UrunDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.UrunDataGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UrunDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.UrunDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UrunDataGrid.GridColor = System.Drawing.SystemColors.Desktop;
            this.UrunDataGrid.Location = new System.Drawing.Point(300, 49);
            this.UrunDataGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UrunDataGrid.Name = "UrunDataGrid";
            this.UrunDataGrid.ReadOnly = true;
            this.UrunDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UrunDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UrunDataGrid.Size = new System.Drawing.Size(805, 264);
            this.UrunDataGrid.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(296, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ürün Ekleme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.label3.Location = new System.Drawing.Point(615, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "Ürün Çıkış";
            // 
            // exitAdetText
            // 
            this.exitAdetText.Location = new System.Drawing.Point(697, 427);
            this.exitAdetText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitAdetText.Name = "exitAdetText";
            this.exitAdetText.Size = new System.Drawing.Size(119, 20);
            this.exitAdetText.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.label4.Location = new System.Drawing.Point(615, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "Adet";
            // 
            // exitSeriText
            // 
            this.exitSeriText.Location = new System.Drawing.Point(697, 382);
            this.exitSeriText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitSeriText.Name = "exitSeriText";
            this.exitSeriText.Size = new System.Drawing.Size(119, 20);
            this.exitSeriText.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.label5.Location = new System.Drawing.Point(615, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Seri No";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            // 
            // modelComboBox
            // 
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(426, 525);
            this.modelComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(120, 22);
            this.modelComboBox.TabIndex = 33;
            this.modelComboBox.SelectedIndexChanged += new System.EventHandler(this.modelComboBox_SelectedIndexChanged);
            // 
            // tipComboBox
            // 
            this.tipComboBox.FormattingEnabled = true;
            this.tipComboBox.Location = new System.Drawing.Point(426, 431);
            this.tipComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tipComboBox.Name = "tipComboBox";
            this.tipComboBox.Size = new System.Drawing.Size(120, 22);
            this.tipComboBox.TabIndex = 34;
            this.tipComboBox.TextChanged += new System.EventHandler(this.tipComboBox_TextChanged);
            // 
            // markaComboBox
            // 
            this.markaComboBox.FormattingEnabled = true;
            this.markaComboBox.Location = new System.Drawing.Point(426, 476);
            this.markaComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.markaComboBox.Name = "markaComboBox";
            this.markaComboBox.Size = new System.Drawing.Size(120, 22);
            this.markaComboBox.TabIndex = 35;
            this.markaComboBox.TextChanged += new System.EventHandler(this.MarkaComboBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.label8.Location = new System.Drawing.Point(296, 431);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 21);
            this.label8.TabIndex = 36;
            this.label8.Text = "Tip Seçimi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.label9.Location = new System.Drawing.Point(296, 525);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 21);
            this.label9.TabIndex = 37;
            this.label9.Text = "Model Seçimi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.label10.Location = new System.Drawing.Point(296, 476);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 21);
            this.label10.TabIndex = 38;
            this.label10.Text = "Marka Seçimi";
            // 
            // silmeTxt
            // 
            this.silmeTxt.Location = new System.Drawing.Point(1001, 382);
            this.silmeTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.silmeTxt.Name = "silmeTxt";
            this.silmeTxt.Size = new System.Drawing.Size(125, 20);
            this.silmeTxt.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.label1.Location = new System.Drawing.Point(903, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 39;
            this.label1.Text = "Seri No";
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.White;
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Add.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.Add.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.Add.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.Add.IconSize = 25;
            this.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.Location = new System.Drawing.Point(300, 617);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add.Name = "Add";
            this.Add.Rotation = 0D;
            this.Add.Size = new System.Drawing.Size(120, 32);
            this.Add.TabIndex = 44;
            this.Add.Text = "Ekleme";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // DecBtn
            // 
            this.DecBtn.BackColor = System.Drawing.Color.White;
            this.DecBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DecBtn.FlatAppearance.BorderSize = 0;
            this.DecBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.DecBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.DecBtn.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.DecBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.DecBtn.IconSize = 25;
            this.DecBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DecBtn.Location = new System.Drawing.Point(697, 455);
            this.DecBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DecBtn.Name = "DecBtn";
            this.DecBtn.Rotation = 0D;
            this.DecBtn.Size = new System.Drawing.Size(119, 32);
            this.DecBtn.TabIndex = 44;
            this.DecBtn.Text = "Çıkar";
            this.DecBtn.UseVisualStyleBackColor = false;
            this.DecBtn.Click += new System.EventHandler(this.DecBtn_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.White;
            this.Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Delete.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.Delete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.Delete.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.Delete.IconSize = 25;
            this.Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete.Location = new System.Drawing.Point(1001, 427);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Delete.Name = "Delete";
            this.Delete.Rotation = 0D;
            this.Delete.Size = new System.Drawing.Size(125, 32);
            this.Delete.TabIndex = 45;
            this.Delete.Text = "Sil";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.label6.Location = new System.Drawing.Point(903, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 21);
            this.label6.TabIndex = 46;
            this.label6.Text = "Ürün Silme";
            // 
            // Islemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1254, 701);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.DecBtn);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.silmeTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.markaComboBox);
            this.Controls.Add(this.tipComboBox);
            this.Controls.Add(this.modelComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitAdetText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exitSeriText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UrunDataGrid);
            this.Controls.Add(this.adetTxt);
            this.Controls.Add(this.Adet);
            this.Controls.Add(this.seriNoTxt);
            this.Controls.Add(this.SeriNoLB);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Islemler";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Islemler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UrunDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox seriNoTxt;
        private System.Windows.Forms.Label SeriNoLB;
        private System.Windows.Forms.TextBox adetTxt;
        private System.Windows.Forms.Label Adet;
        private System.Windows.Forms.DataGridView UrunDataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox exitAdetText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.TextBox exitSeriText;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.ComboBox tipComboBox;
        private System.Windows.Forms.ComboBox markaComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox silmeTxt;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton Add;
        private FontAwesome.Sharp.IconButton DecBtn;
        private FontAwesome.Sharp.IconButton Delete;
        private System.Windows.Forms.Label label6;
    }
}