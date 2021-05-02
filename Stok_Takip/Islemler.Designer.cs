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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.updateTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.seriCheck = new System.Windows.Forms.CheckBox();
            this.tipCheck = new System.Windows.Forms.CheckBox();
            this.markaCheck = new System.Windows.Forms.CheckBox();
            this.modelCheck = new System.Windows.Forms.CheckBox();
            this.adetCheck = new System.Windows.Forms.CheckBox();
            this.Search = new FontAwesome.Sharp.IconButton();
            this.Update = new FontAwesome.Sharp.IconButton();
            this.DecBtn = new FontAwesome.Sharp.IconButton();
            this.Add = new FontAwesome.Sharp.IconButton();
            this.aciklama_exit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.aciklama_add = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.personelExitCmb = new System.Windows.Forms.ComboBox();
            this.projeExitCmb = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.personelAddCmb = new System.Windows.Forms.ComboBox();
            this.projeAddCmb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.UrunDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // seriNoTxt
            // 
            this.seriNoTxt.Location = new System.Drawing.Point(499, 411);
            this.seriNoTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.seriNoTxt.Name = "seriNoTxt";
            this.seriNoTxt.Size = new System.Drawing.Size(120, 20);
            this.seriNoTxt.TabIndex = 13;
            // 
            // SeriNoLB
            // 
            this.SeriNoLB.AutoSize = true;
            this.SeriNoLB.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeriNoLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.SeriNoLB.Location = new System.Drawing.Point(350, 411);
            this.SeriNoLB.Name = "SeriNoLB";
            this.SeriNoLB.Size = new System.Drawing.Size(65, 21);
            this.SeriNoLB.TabIndex = 12;
            this.SeriNoLB.Text = "Seri No";
            // 
            // adetTxt
            // 
            this.adetTxt.Location = new System.Drawing.Point(499, 602);
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
            this.Adet.Location = new System.Drawing.Point(350, 601);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UrunDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.UrunDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UrunDataGrid.GridColor = System.Drawing.SystemColors.Desktop;
            this.UrunDataGrid.Location = new System.Drawing.Point(488, 82);
            this.UrunDataGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UrunDataGrid.Name = "UrunDataGrid";
            this.UrunDataGrid.ReadOnly = true;
            this.UrunDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UrunDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.UrunDataGrid.Size = new System.Drawing.Size(673, 264);
            this.UrunDataGrid.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(350, 369);
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
            this.label3.Location = new System.Drawing.Point(760, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "Ürün Çıkış";
            // 
            // exitAdetText
            // 
            this.exitAdetText.Location = new System.Drawing.Point(850, 465);
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
            this.label4.Location = new System.Drawing.Point(760, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "Adet";
            // 
            // exitSeriText
            // 
            this.exitSeriText.Location = new System.Drawing.Point(850, 420);
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
            this.label5.Location = new System.Drawing.Point(760, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Seri No";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // modelComboBox
            // 
            this.modelComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.modelComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(499, 554);
            this.modelComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(120, 22);
            this.modelComboBox.TabIndex = 33;
            // 
            // tipComboBox
            // 
            this.tipComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tipComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tipComboBox.FormattingEnabled = true;
            this.tipComboBox.Location = new System.Drawing.Point(499, 460);
            this.tipComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tipComboBox.Name = "tipComboBox";
            this.tipComboBox.Size = new System.Drawing.Size(120, 22);
            this.tipComboBox.TabIndex = 34;
            // 
            // markaComboBox
            // 
            this.markaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.markaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.markaComboBox.FormattingEnabled = true;
            this.markaComboBox.Location = new System.Drawing.Point(499, 505);
            this.markaComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.markaComboBox.Name = "markaComboBox";
            this.markaComboBox.Size = new System.Drawing.Size(120, 22);
            this.markaComboBox.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.label8.Location = new System.Drawing.Point(350, 460);
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
            this.label9.Location = new System.Drawing.Point(350, 554);
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
            this.label10.Location = new System.Drawing.Point(350, 505);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 21);
            this.label10.TabIndex = 38;
            this.label10.Text = "Marka Seçimi";
            // 
            // updateTxt
            // 
            this.updateTxt.Location = new System.Drawing.Point(1146, 422);
            this.updateTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updateTxt.Name = "updateTxt";
            this.updateTxt.Size = new System.Drawing.Size(125, 20);
            this.updateTxt.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.label1.Location = new System.Drawing.Point(1048, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 39;
            this.label1.Text = "Seri No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.label6.Location = new System.Drawing.Point(1048, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 21);
            this.label6.TabIndex = 46;
            this.label6.Text = "Ürün Seri No Güncelleme";
            // 
            // seriCheck
            // 
            this.seriCheck.AutoSize = true;
            this.seriCheck.Location = new System.Drawing.Point(650, 415);
            this.seriCheck.Name = "seriCheck";
            this.seriCheck.Size = new System.Drawing.Size(15, 14);
            this.seriCheck.TabIndex = 48;
            this.seriCheck.UseVisualStyleBackColor = true;
            // 
            // tipCheck
            // 
            this.tipCheck.AutoSize = true;
            this.tipCheck.Location = new System.Drawing.Point(650, 464);
            this.tipCheck.Name = "tipCheck";
            this.tipCheck.Size = new System.Drawing.Size(15, 14);
            this.tipCheck.TabIndex = 49;
            this.tipCheck.UseVisualStyleBackColor = true;
            // 
            // markaCheck
            // 
            this.markaCheck.AutoSize = true;
            this.markaCheck.Location = new System.Drawing.Point(650, 509);
            this.markaCheck.Name = "markaCheck";
            this.markaCheck.Size = new System.Drawing.Size(15, 14);
            this.markaCheck.TabIndex = 50;
            this.markaCheck.UseVisualStyleBackColor = true;
            // 
            // modelCheck
            // 
            this.modelCheck.AutoSize = true;
            this.modelCheck.Location = new System.Drawing.Point(650, 558);
            this.modelCheck.Name = "modelCheck";
            this.modelCheck.Size = new System.Drawing.Size(15, 14);
            this.modelCheck.TabIndex = 51;
            this.modelCheck.UseVisualStyleBackColor = true;
            // 
            // adetCheck
            // 
            this.adetCheck.AutoSize = true;
            this.adetCheck.Location = new System.Drawing.Point(650, 606);
            this.adetCheck.Name = "adetCheck";
            this.adetCheck.Size = new System.Drawing.Size(15, 14);
            this.adetCheck.TabIndex = 52;
            this.adetCheck.UseVisualStyleBackColor = true;
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
            this.Search.Location = new System.Drawing.Point(499, 363);
            this.Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Search.Name = "Search";
            this.Search.Rotation = 0D;
            this.Search.Size = new System.Drawing.Size(120, 32);
            this.Search.TabIndex = 47;
            this.Search.Text = "Ara";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.White;
            this.Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Update.FlatAppearance.BorderSize = 0;
            this.Update.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Update.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.Update.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.Update.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.Update.IconSize = 30;
            this.Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Update.Location = new System.Drawing.Point(1146, 467);
            this.Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Update.Name = "Update";
            this.Update.Rotation = 0D;
            this.Update.Size = new System.Drawing.Size(125, 32);
            this.Update.TabIndex = 45;
            this.Update.Text = "Güncelle";
            this.Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // DecBtn
            // 
            this.DecBtn.BackColor = System.Drawing.Color.White;
            this.DecBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DecBtn.FlatAppearance.BorderSize = 0;
            this.DecBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.DecBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.DecBtn.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.DecBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.DecBtn.IconSize = 25;
            this.DecBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DecBtn.Location = new System.Drawing.Point(850, 646);
            this.DecBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DecBtn.Name = "DecBtn";
            this.DecBtn.Rotation = 0D;
            this.DecBtn.Size = new System.Drawing.Size(119, 32);
            this.DecBtn.TabIndex = 44;
            this.DecBtn.Text = "Çıkar";
            this.DecBtn.UseVisualStyleBackColor = false;
            this.DecBtn.Click += new System.EventHandler(this.DecBtn_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.White;
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Add.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.Add.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.Add.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.Add.IconSize = 25;
            this.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.Location = new System.Drawing.Point(498, 771);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add.Name = "Add";
            this.Add.Rotation = 0D;
            this.Add.Size = new System.Drawing.Size(120, 32);
            this.Add.TabIndex = 44;
            this.Add.Text = "Ekleme";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // aciklama_exit
            // 
            this.aciklama_exit.Location = new System.Drawing.Point(850, 507);
            this.aciklama_exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aciklama_exit.Name = "aciklama_exit";
            this.aciklama_exit.Size = new System.Drawing.Size(119, 20);
            this.aciklama_exit.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.label7.Location = new System.Drawing.Point(760, 509);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 21);
            this.label7.TabIndex = 53;
            this.label7.Text = "Açıklama";
            // 
            // aciklama_add
            // 
            this.aciklama_add.Location = new System.Drawing.Point(500, 646);
            this.aciklama_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aciklama_add.Name = "aciklama_add";
            this.aciklama_add.Size = new System.Drawing.Size(119, 20);
            this.aciklama_add.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.label11.Location = new System.Drawing.Point(350, 646);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 21);
            this.label11.TabIndex = 55;
            this.label11.Text = "Açıklama";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.label12.Location = new System.Drawing.Point(760, 551);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 21);
            this.label12.TabIndex = 60;
            this.label12.Text = "Personel";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.label13.Location = new System.Drawing.Point(760, 592);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 21);
            this.label13.TabIndex = 59;
            this.label13.Text = "Proje";
            // 
            // personelExitCmb
            // 
            this.personelExitCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.personelExitCmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.personelExitCmb.FormattingEnabled = true;
            this.personelExitCmb.Location = new System.Drawing.Point(850, 550);
            this.personelExitCmb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.personelExitCmb.Name = "personelExitCmb";
            this.personelExitCmb.Size = new System.Drawing.Size(120, 22);
            this.personelExitCmb.TabIndex = 58;
            // 
            // projeExitCmb
            // 
            this.projeExitCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.projeExitCmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.projeExitCmb.FormattingEnabled = true;
            this.projeExitCmb.Location = new System.Drawing.Point(850, 591);
            this.projeExitCmb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.projeExitCmb.Name = "projeExitCmb";
            this.projeExitCmb.Size = new System.Drawing.Size(120, 22);
            this.projeExitCmb.TabIndex = 57;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.label14.Location = new System.Drawing.Point(350, 690);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 21);
            this.label14.TabIndex = 64;
            this.label14.Text = "Personel";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(178)))));
            this.label15.Location = new System.Drawing.Point(350, 731);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 21);
            this.label15.TabIndex = 63;
            this.label15.Text = "Proje";
            // 
            // personelAddCmb
            // 
            this.personelAddCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.personelAddCmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.personelAddCmb.FormattingEnabled = true;
            this.personelAddCmb.Location = new System.Drawing.Point(499, 689);
            this.personelAddCmb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.personelAddCmb.Name = "personelAddCmb";
            this.personelAddCmb.Size = new System.Drawing.Size(120, 22);
            this.personelAddCmb.TabIndex = 62;
            this.personelAddCmb.DropDown += new System.EventHandler(this.personelAddCmb_DropDown);
            // 
            // projeAddCmb
            // 
            this.projeAddCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.projeAddCmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.projeAddCmb.FormattingEnabled = true;
            this.projeAddCmb.Location = new System.Drawing.Point(499, 730);
            this.projeAddCmb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.projeAddCmb.Name = "projeAddCmb";
            this.projeAddCmb.Size = new System.Drawing.Size(120, 22);
            this.projeAddCmb.TabIndex = 61;
            this.projeAddCmb.DropDown += new System.EventHandler(this.projeAddCmb_DropDown);
            // 
            // Islemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1520, 810);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.personelAddCmb);
            this.Controls.Add(this.projeAddCmb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.personelExitCmb);
            this.Controls.Add(this.projeExitCmb);
            this.Controls.Add(this.aciklama_add);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.aciklama_exit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.adetCheck);
            this.Controls.Add(this.modelCheck);
            this.Controls.Add(this.markaCheck);
            this.Controls.Add(this.tipCheck);
            this.Controls.Add(this.seriCheck);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.DecBtn);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.updateTxt);
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
        private System.Windows.Forms.TextBox updateTxt;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton Add;
        private FontAwesome.Sharp.IconButton DecBtn;
        private FontAwesome.Sharp.IconButton Update;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton Search;
        private System.Windows.Forms.CheckBox seriCheck;
        private System.Windows.Forms.CheckBox tipCheck;
        private System.Windows.Forms.CheckBox markaCheck;
        private System.Windows.Forms.CheckBox modelCheck;
        private System.Windows.Forms.CheckBox adetCheck;
        private System.Windows.Forms.TextBox aciklama_exit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox aciklama_add;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox personelExitCmb;
        private System.Windows.Forms.ComboBox projeExitCmb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox personelAddCmb;
        private System.Windows.Forms.ComboBox projeAddCmb;
    }
}