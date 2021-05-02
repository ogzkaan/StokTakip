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

    public partial class Personel_Form : Form
    {
        List<Personel> personel = new List<Personel>();

        DataAccessPersonel dap = new DataAccessPersonel();
        DataAccessPersonelTakip dapt = new DataAccessPersonelTakip();

        public Personel_Form()
        {
            InitializeComponent();
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            String kullaniciAdi = adTxt.Text + " " + soyadTxt.Text;
            if (String.Equals(sifreTekrarTxt.Text, sifreTxt.Text))
            {
                try
                {
                    dap.InsertPersonel(adTxt.Text, soyadTxt.Text, sifreTxt.Text, kullaniciAdi, Int32.Parse(yetkiTxt.Text));
                    MessageBox.Show("Personel Eklendi");
                    adTxt.Text = "";
                    soyadTxt.Text = "";
                    sifreTxt.Text = "";
                    yetkiTxt.Text = "";

                }
                catch (Exception)
                {
                    MessageBox.Show("Geçersiz Yetki Seviyesi");
                }
                
            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmamaktadır");
            }
            loadComboBoxes();
        }

        public void loadComboBoxes()
        {
            personel = dap.ShowPersonel();
            foreach (Personel add_urun in personel)
            {
                if (!personelComboBox.Items.Contains(add_urun.Isim))
                {
                    personelComboBox.Items.Add(add_urun.Isim);
                }
                
            }
           
        }

        private void Search_Click(object sender, EventArgs e)
        {
            String Isim = personelComboBox.Text;
            int ID_Personel=dap.personelID(Isim);
            personelDataGrid.DataSource=dapt.GetUrunTakip(ID_Personel);
        }

        private void Personel_Form_Load(object sender, EventArgs e)
        {
            loadComboBoxes();
        }

    }
}
