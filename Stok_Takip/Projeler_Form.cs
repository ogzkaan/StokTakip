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
    public partial class Projeler_Form : Form
    {
        DataAccessProjeler dapj = new DataAccessProjeler();
        List<Projeler> projeler = new List<Projeler>();
        public String AdTxt 
        {
            get { return adTxt.Text; }
            set { adTxt.Text = value; }
        }
        public String DetayTxt {
            get { return detayTxt.Text; }
            set { detayTxt.Text = value; }
        }

        public Projeler_Form()
        {
            InitializeComponent();
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            
            try
            {
                String Ad = AdTxt;
                String Detay = DetayTxt;
                dapj.InsertProje(Ad, Detay);
                MessageBox.Show("Proje EKleme İşlemi Başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            LoadComboBox();
        }
        private void bitirBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dapj.ProjeBitir(projeBitirCmb.Text);
                MessageBox.Show("Proje Bitirme İşlemi Başarılı");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
          
        }

        private void Projeler_Form_Load(object sender, EventArgs e)
        {
            LoadComboBox();   
        }
        private void LoadComboBox()
        {
            projeler = dapj.ShowProje();
            foreach (Projeler prj in projeler)
            {
                projeBitirCmb.Items.Add(prj.Proje_Adi);
            }

        }

    }
}
