using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takip
{
    public partial class Form1 : Form
    {
        List<Urun> urun = new List<Urun>();
        Form2 fr2 = new Form2();
        public Form1()
        {
            DataAccess da = new DataAccess();
            urun = da.Show_Urun();
            InitializeComponent();
            dataGridView1.DataSource = urun;
            fr2.Show();
        }


        private void Insert_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            da.InsertUrun(Int32.Parse(IDtxt.Text), AdTxt.Text, Ekleme.Value, Cikis.Value, Int32.Parse(SeriTxt.Text), Int32.Parse(AdetTxt.Text));

            IDtxt.Text = "";
            AdTxt.Text = "";
            SeriTxt.Text = "";
            AdetTxt.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            urun = da.GetUrun(textBox1.Text);
            dataGridView1.DataSource = urun;
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
