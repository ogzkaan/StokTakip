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
            this.PersonelDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonelDataGrid
            // 
            this.PersonelDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonelDataGrid.Location = new System.Drawing.Point(349, 12);
            this.PersonelDataGrid.Name = "PersonelDataGrid";
            this.PersonelDataGrid.Size = new System.Drawing.Size(627, 183);
            this.PersonelDataGrid.TabIndex = 0;
            // 
            // Personel_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 657);
            this.Controls.Add(this.PersonelDataGrid);
            this.Name = "Personel_Form";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PersonelDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PersonelDataGrid;
    }
}