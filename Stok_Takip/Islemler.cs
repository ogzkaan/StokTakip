using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using Dapper;
using NLog.Layouts;
using System.IO;
using System.Data.SqlClient;

namespace Stok_Takip
{

    public partial class Islemler : Form
    {
        String seri;
        String tip;
        String model;
        String marka;
        String adet;
        bool personelEmptyCheck = true;
        //-------------------Form üzerindeki textboxların get set metodları
        public String SeriNoTxt
        {
            get { return seriNoTxt.Text; }
            set { seriNoTxt.Text = value; }
        }
        public String AdetTxt
        {
            get { return adetTxt.Text; }
            set { adetTxt.Text = value; }
        }
        public String ExitSeriText
        {
            get { return exitSeriText.Text; }
            set { exitSeriText.Text = value; }
        }
        public String ExitAdetText
        {
            get { return exitAdetText.Text; }
            set { exitAdetText.Text = value; }
        }
        public String UpdateTxt 
        {
            get { return updateTxt.Text; }
            set { updateTxt.Text = value; }
        }
        public String Aciklama_add
        {
            get { return aciklama_add.Text; }
            set { aciklama_add.Text = value; }
        }
        public String Aciklama_exit
        {
            get { return aciklama_exit.Text; }
            set { aciklama_exit.Text = value; }
        }
        public String PersonelTxt
        {
            get { return personelExitCmb.Text; }
            set { personelExitCmb.Text = value; }
        }
        public String ProjeTxt 
        {
            get { return projeExitCmb.Text; }
            set { projeExitCmb.Text = value; }
        }
        //-------------------Form üzerindeki textboxların get set metodları

        ReadSerialPort RSP = new ReadSerialPort();

        List<Kategori> kategori = new List<Kategori>();
        List<Personel> personel = new List<Personel>();
        List<Projeler> projeler = new List<Projeler>();

        DataAccessUrun dau = new DataAccessUrun();
        DataAccessUrunTakip daut = new DataAccessUrunTakip();
        DataAccessPersonel dap = new DataAccessPersonel();
        DataAccessProjeler dapj = new DataAccessProjeler();
        DataAccessPersonelTakip dapt = new DataAccessPersonelTakip();

        public Islemler()
        {
            MainProg.logger.Error("islemler constructor");
            kategori = dau.Show_Urun();
            MainProg.logger.Error("islemler constructor show urun");
            projeler = dapj.ShowProje();
            personel = dap.ShowPersonel();
            InitializeComponent();
            UrunDataGrid.DataSource = kategori;

        }
        private void Islemler_Load(object sender, EventArgs e)
        {
            loadAllComboBoxes();
            MainProg.Barcode="";
        }
        private void AramaSonucuYazma()
        {
            tipComboBox.SelectedIndex = -1;
            markaComboBox.SelectedIndex = -1;
            modelComboBox.SelectedIndex = -1;
            if (!String.IsNullOrEmpty(SeriNoTxt))
            {
                kategori = dau.GetUrun(SeriNoTxt);
                UrunDataGrid.DataSource = kategori;
                if (kategori.Count() != 0 && SeriNoTxt!=null)
                {
                    tipComboBox.SelectedIndex = tipComboBox.FindStringExact(kategori[0].Urun_Tip);
                  
                    markaComboBox.SelectedIndex = markaComboBox.FindStringExact(kategori[0].Urun_Marka);
                    
                    modelComboBox.SelectedIndex = modelComboBox.FindStringExact(kategori[0].Urun_Model);
                }
            }  
        }
        private void changeText()
         {
            SeriNoTxt = MainProg.Barcode;
            ExitSeriText = MainProg.Barcode;
            UpdateTxt = MainProg.Barcode;
            AramaSonucuYazma();
         }
        private void clearReasultTexts()
        {
            SeriNoTxt = "";
            AdetTxt = "";
            ExitSeriText = "";
            ExitAdetText = "";
            UpdateTxt = "";
            Aciklama_add = "";
            Aciklama_exit = "";
            tipComboBox.SelectedIndex = -1;
            markaComboBox.SelectedIndex = -1;
            modelComboBox.SelectedIndex = -1;
            projeAddCmb.SelectedIndex = -1;
            projeExitCmb.SelectedIndex = -1;
            personelAddCmb.SelectedIndex = -1;
            personelExitCmb.SelectedIndex = -1;
        }
        public void loadAllComboBoxes()
        {
            loadKategoriCombo();
            loadProje();
            loadPersonel();
        }
        public void loadKategoriCombo()
        {
            kategori = dau.Show_Urun();
            foreach (Kategori add_urun in kategori)
            {
                if (!tipComboBox.Items.Contains(add_urun.Urun_Tip))
                {
                    tipComboBox.Items.Add(add_urun.Urun_Tip);
                }
                if (!markaComboBox.Items.Contains(add_urun.Urun_Marka))
                {
                    markaComboBox.Items.Add(add_urun.Urun_Marka);
                }
                if (!modelComboBox.Items.Contains(add_urun.Urun_Model))
                {
                    modelComboBox.Items.Add(add_urun.Urun_Model);
                }
            }
        }
        public void loadProje()
        {
            projeler = dapj.ShowProje();
            foreach (Projeler prj in projeler)
            {
                if (!projeAddCmb.Items.Contains(prj.Proje_Adi))
                {
                    projeAddCmb.Items.Add(prj.Proje_Adi);
                    projeExitCmb.Items.Add(prj.Proje_Adi);
                }
            }

        }
        public void loadPersonel() 
        {
            personel = dap.ShowPersonel();
            foreach (Personel prs in personel)
            {
                if (!personelAddCmb.Items.Contains(prs.Isim))
                {
                    personelAddCmb.Items.Add(prs.Isim);
                    personelExitCmb.Items.Add(prs.Isim);

                }
            }
        }
        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                String model = modelComboBox.Text;
                String seriNo = SeriNoTxt;
                int eklemeAdeti = Int32.Parse(AdetTxt);
                String marka = markaComboBox.Text;
                String tip = tipComboBox.Text;
                String dau_urunAdi = dau.GetUrunModelFromSeri(seriNo);
                String aciklama = Aciklama_add;
                String projeAdi = projeAddCmb.Text;
                String personelAdi = personelAddCmb.Text;
                if (String.IsNullOrEmpty(personelAdi))
                {
                    personelEmptyCheck = false;
                }
                //ürün kayıtlı ise
                if (!String.IsNullOrEmpty(dau_urunAdi))
                {
                    int adet = dau.GetUrunAdet(seriNo);
                    adet += eklemeAdeti;
                    dau.UpdateUrun(adet, seriNo);

                    kategori = dau.GetUrun(seriNoTxt.Text);  //Listenin datagride atılması
                    UrunDataGrid.DataSource = kategori;
                    MainProg.logger.Error(seriNo + " Barkod numaralı ürün " + AnaSayfa.kullaniciAdi + " tarafından " + eklemeAdeti + " adet arttırılıdı");

                }
                //kayıtlı değil ise
                else
                {
                    dau.InsertUrun(model, seriNo, eklemeAdeti, tip, marka);

                    kategori = dau.GetUrun(seriNoTxt.Text);
                    UrunDataGrid.DataSource = kategori;
                    MainProg.logger.Error(seriNo + " Barkod numaralı ürün " + AnaSayfa.kullaniciAdi + " tarafından " + eklemeAdeti + " adet eklendi");
                }
                //Ürün Takip ekleme
                int UrunID = daut.UrunID(seriNo);
                int projeID = dapj.ProjeID(projeAdi);
                int personelID = dap.personelID(personelAdi);

                daut.InsertUrunTakip(eklemeAdeti, UrunID, projeID, personelID, Aciklama_add, 1);

                loadKategoriCombo();
                clearReasultTexts();
                //personel kutusu boş değil ise personele eleman ekle
                if (personelEmptyCheck)
                {
                   
                    dapt.DeletePersonelUrun(UrunID, personelID,projeID);
                }
                MessageBox.Show("Ekleme İşlemi Gerçekleştirilmiştir");
            }
            catch (System.FormatException )
            {
                MessageBox.Show("LÜtfen Doğru Değerler Giriniz" );
            }
        }
        private void DecBtn_Click(object sender, EventArgs e)
        {
            String SeriNo = ExitSeriText;
            int exit_adet = Int32.Parse(ExitAdetText);
            String projeAdi = projeExitCmb.Text;
            String personelAdi = personelExitCmb.Text;
            String Acilklama = aciklama_exit.Text;


            int Adet = dau.GetUrunAdet(SeriNo);
            Adet -= exit_adet;
            dau.UpdateUrun(Adet, SeriNo);
            kategori = dau.GetUrun(SeriNoTxt);
            UrunDataGrid.DataSource = kategori;

            int UrunID = daut.UrunID(SeriNo);
            int projeID = dapj.ProjeID(projeAdi);
            int personelID = dap.personelID(personelAdi);

            daut.InsertUrunTakip(exit_adet, UrunID, projeID, personelID, Acilklama, 2);

            dapt.InsertPersonelTakip(UrunID, projeID, personelID);

            clearReasultTexts();
            MessageBox.Show("Çıkarma İşlemi Gerçekleştirilmiştir");
            MainProg.logger.Error(SeriNo + " Barkod numaralı ürün "+ AnaSayfa.kullaniciAdi + " tarafından " + exit_adet + " adet çıkartıldı");

            UrunDataGrid.DataSource = dau.Show_Urun();
        }
        private void Search_Click(object sender, EventArgs e)
        {
            //kategori = dau.Show_Urun();
            IDbConnection connection = new System.Data.SqlClient.SqlConnection(Controller.cnnVal("DB1"));
            seri = "";
            tip = "";
            model = "";
            marka = "";
            adet = "";
            String SQL = "Select * from Urun where ";
            if (seriCheck.Checked)
            {

                kategori = dau.Show_Urun();
                UrunDataGrid.DataSource = kategori;
                seri = SeriNoTxt;
                String SQL1 = "Urun_Seri_No= "+"\'"+ seri+ "\'";
                SQL +=SQL1;
                AramaSonucuYazma();
            }
            else
            {
                if (tipCheck.Checked)
                {
                    tip = tipComboBox.Text;
                    String SQL2 = "Urun_Tip=" +'\''+tip+'\''+" and ";
                    SQL += SQL2;
                     
                }
                if (modelCheck.Checked)
                {
                    model = modelComboBox.Text;
                    String SQL3 = "Urun_Model=" + '\'' + model + '\'' + " and ";
                    SQL += SQL3;

                }
                if (markaCheck.Checked)
                {
                    marka = markaComboBox.Text;
                    String SQL4 = "Urun_Marka=" + '\'' + marka + '\''+" and ";
                    SQL += SQL4;
                }
                if (adetCheck.Checked)
                {
                    adet = AdetTxt;
                    String SQL5 = "Urun_Adet="  + adet  + " and ";
                    SQL += SQL5;
                }
                SQL += "1=1";
            }
            UrunDataGrid.DataSource = connection.Query<Kategori>(SQL).ToList();
        }
        private void timer2_Tick(object sender, EventArgs e)
            {
            if (MainProg.Barcode!=""&& this.Visible!=false)
            {
                changeText();
                MainProg.Barcode="";
            }
        }
        private void Update_Click(object sender, EventArgs e)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Controller.cnnVal("DB1")))
            {
                String SQL = "Update Urun set " + "Urun_Seri_No = " + UpdateTxt + " where " + "Urun_Seri_No = " + '\''+SeriNoTxt +'\'';
                connection.Query(SQL);
            }
            MessageBox.Show("Seri Numarası Güncellenmiştir");

        }

        private void personelAddCmb_DropDown(object sender, EventArgs e)
        {
            loadPersonel();
        }

        private void projeAddCmb_DropDown(object sender, EventArgs e)
        {
            loadProje();
        }
    }   

}
   

