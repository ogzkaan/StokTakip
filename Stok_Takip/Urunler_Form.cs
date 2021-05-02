using Dapper;
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
    public partial class Urunler_Form : Form
    {

        public Urunler_Form()
        {
            InitializeComponent();
        }
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


        String seri;
        String tip;
        String model;
        String marka;
        String adet;
        String currentBarcode;

        List<Urun_Takip_Data> giris;
        List<Urun_Takip_Data> cikis;


        public List<Kategori> kategori = new List<Kategori>();
        List<Urun_Takip> ut = new List<Urun_Takip>();
        List<Urun_Takip_Data> utd = new List<Urun_Takip_Data>();
        DataAccessUrun dau = new DataAccessUrun();
        DataAccessUrunTakip daut = new DataAccessUrunTakip();
        
        bool changePress = false;
      

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
                String SQL1 = "Urun_Seri_No= " + "\'" + seri + "\'";
                SQL += SQL1;
                AramaSonucuYazma(seri);
            }
            else
            {
                if (tipCheck.Checked)
                {
                    tip = tipComboBox.Text;
                    String SQL2 = "Urun_Tip=" + '\'' + tip + '\'' + " and ";
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
                    String SQL4 = "Urun_Marka=" + '\'' + marka + '\'' + " and ";
                    SQL += SQL4;
                }
                if (adetCheck.Checked)
                {
                    adet = AdetTxt;
                    String SQL5 = "Urun_Adet=" + adet + " and ";
                    SQL += SQL5;
                }
                SQL += "1=1";
            }
            UrunDataGrid.DataSource = connection.Query<Kategori>(SQL).ToList();
        }
        private void AramaSonucuYazma(String seri)
        {
            currentBarcode = seri;
            SeriNoTxt = seri;
            idNoGC.Text = daut.UrunID(seri).ToString();
            tipComboBox.SelectedIndex = -1;
            markaComboBox.SelectedIndex = -1;
            modelComboBox.SelectedIndex = -1;
            if (!String.IsNullOrEmpty(SeriNoTxt))
            {
                kategori = dau.GetUrun(SeriNoTxt);
                UrunDataGrid.DataSource = kategori;
                if (kategori.Count() != 0 && SeriNoTxt != null)
                {
                    tipComboBox.SelectedIndex = tipComboBox.FindStringExact(kategori[0].Urun_Tip);
                    //MarkaComboBoxUpdate();

                    markaComboBox.SelectedIndex = markaComboBox.FindStringExact(kategori[0].Urun_Marka);
                    //ModelComboBoxUpdate();

                    modelComboBox.SelectedIndex = modelComboBox.FindStringExact(kategori[0].Urun_Model);
                }
            }
        }
        private void loadComboBoxes()
        {
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

        private void Urunler_Form_Load(object sender, EventArgs e)
        {
            MainProg.Barcode = "";
            kategori = dau.Show_Urun();
            UrunDataGrid.DataSource = kategori;
            loadComboBoxes();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            GC_Ara();

        }
        private void idNoGC_TextChanged(object sender, EventArgs e)
        {
            GC_Ara();
        }
        private void GC_Ara()
        {

            utd = daut.GetUrunTakip(idNoGC.Text);
     
            giris = utd.Where(x => x.State ==1).ToList();


            cikis = utd.Where(x => x.State == 2).ToList();
   
            if (!changePress)
            {
                giris_cikisDG.DataSource = giris;
               
            }
            else
            {
                giris_cikisDG.DataSource = cikis;
            }
            giris_cikisDG.Columns[6].Visible = false;
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (changePress)
            {
                label2.Text = "Ürün Giriş Tarihi Arama";
                changePress = false;
               
            }
            else
            {
                label2.Text = "Ürün Çıkış Tarihi Arama";
                changePress = true;
                
            }
            GC_Ara();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MainProg.Barcode != "")
            {
                AramaSonucuYazma(MainProg.Barcode);
                MainProg.Barcode = "";
            }
        }


    }
}
