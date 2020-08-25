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



namespace Stok_Takip
{

    public partial class Islemler : Form
    {
        
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
        public String Barcode { get; set; }
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
        public String SilmeTxt 
        {
            get { return silmeTxt.Text; }
            set { silmeTxt.Text = value; }
        }

        public List<Kategori> kategori = new List<Kategori>();

        DataAccessUrun dau = new DataAccessUrun();
        public Thread thread;
        bool exceptionFlag = false;

        public Islemler()
        {
            kategori = dau.Show_Urun();
            InitializeComponent();
            UrunDataGrid.DataSource = kategori;
        }
        private void Insert_Click(object sender, EventArgs e)
        {
           
        }
        //urun arama
        private void cikis_Click(object sender, EventArgs e)
        {
           
        }
        private void Islemler_Load(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(readSerial));
            thread.Start();
            loadComboBoxes();
        }
        private void AramaSonucuYazma()
        {
            if (!String.IsNullOrEmpty(SeriNoTxt))
            {

                kategori = dau.GetUrun(SeriNoTxt);
                if (kategori.Count() != 0 && SeriNoTxt!=null)
                {
                    tipComboBox.SelectedIndex = tipComboBox.FindStringExact(kategori[0].Urun_Tip);
                    MarkaComboBoxUpdate();

                    markaComboBox.SelectedIndex = markaComboBox.FindStringExact(kategori[0].Urun_Marka);
                    ModelComboBoxUpdate();

                    modelComboBox.SelectedIndex = modelComboBox.FindStringExact(kategori[0].Urun_Model);
                }
                else
                {
                    kategori = dau.GetUrun("");
                    UrunDataGrid.DataSource = kategori;
                    tipComboBox.SelectedIndex = -1;
                    markaComboBox.SelectedIndex = -1;
                    modelComboBox.SelectedIndex = -1;
                }
            }
        }
        public void readSerial()
        {
            while (true)
            {
                using (SerialPort port = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One))
                {
                    try
                    {
                        port.Open();
                        if (port.IsOpen)
                        {
                            Barcode = port.ReadLine();
                            changeText();
                        }
                        else
                        {
                            Thread.Sleep(100);
                        }

                    }
                    catch (Exception ex)
                    {
                        if (exceptionFlag == false)
                        {
                            MessageBox.Show(ex.Message);
                            exceptionFlag = true;
                        }
                        Thread.Sleep(200);
                    }

                }

            }
        }
        private void changeText()
        {
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(changeText));
                }
                else
                {
                    try
                    {
                        SeriNoTxt = Barcode;
                        ExitSeriText = Barcode;
                        SilmeTxt = Barcode;
                        
                        AramaSonucuYazma();
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {
                        clearReasultTexts();
                       
                    }

                }
            }
        }
        private void clearReasultTexts()
        {
            SeriNoTxt = "";
            AdetTxt = "";
            Barcode = "";
            ExitSeriText = "";
            ExitAdetText = "";
            tipComboBox.SelectedIndex = -1;
            markaComboBox.SelectedIndex = -1;
            modelComboBox.SelectedIndex = -1;
            SilmeTxt = "";
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
        private void MarkaComboBoxUpdate()
        {
            String tip = tipComboBox.Text;
            foreach (Kategori add_urun in kategori)
            {
                if (tip == add_urun.Urun_Tip && !markaComboBox.Items.Contains(add_urun.Urun_Marka))
                {
                    markaComboBox.Items.Add(add_urun.Urun_Marka);
                }
            }
        }
        private void tipComboBox_TextChanged(object sender, EventArgs e)
        {
            markaComboBox.Items.Clear();
            markaComboBox.Text = "";
            modelComboBox.Items.Clear();
            modelComboBox.Text = "";
            MarkaComboBoxUpdate();
           
        }
        private void MarkaComboBox_TextChanged(object sender, EventArgs e)
        {
            modelComboBox.Items.Clear();
            modelComboBox.Text = "";
            ModelComboBoxUpdate();
        }
        private void ModelComboBoxUpdate()
        {
            String tip = tipComboBox.Text;
            String marka = markaComboBox.Text;
            foreach (Kategori add_urun in kategori)
            {
                if (tip==add_urun.Urun_Tip&&marka == add_urun.Urun_Marka && !modelComboBox.Items.Contains(add_urun.Urun_Model))
                {
                    modelComboBox.Items.Add(add_urun.Urun_Model);
                }
            }
        }
        private void seriNoTxt_TextChanged(object sender, EventArgs e)
        {
            String Serachtxt = SeriNoTxt;
            kategori = dau.GetUrun(Serachtxt);
            UrunDataGrid.DataSource = kategori;

            SilmeTxt = Serachtxt;
            ExitSeriText = Serachtxt;
            AramaSonucuYazma();
        }
        private void Silme_Click(object sender, EventArgs e)
        {
           
        }
        private void modelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SeriNoTxt=="")
            {
                SeriNoTxt = dau.GetSeriFromModel(modelComboBox.Text);
            }
           
        }

        private void Add_Click(object sender, EventArgs e)
        {
            String model = modelComboBox.Text;
            String seriNo = SeriNoTxt;
            int eklemeAdeti = Int32.Parse(AdetTxt);
            String marka = markaComboBox.Text;
            String tip = tipComboBox.Text;
            String dau_urunAdi = dau.GetUrunModelFromSeri(seriNo);

            //ürün kayıtlı ise
            if (!String.IsNullOrEmpty(dau_urunAdi))
            {
                int adet = dau.GetUrunAdet(seriNo);
                adet += eklemeAdeti;
                dau.UpdateUrun(adet, seriNo);

                kategori = dau.GetUrun(seriNoTxt.Text);
                UrunDataGrid.DataSource = kategori;
            }
            //kayıtlı değil ise
            else
            {
                dau.InsertUrun(model, seriNo, eklemeAdeti, tip, marka);
                kategori = dau.GetUrun(seriNoTxt.Text);
                UrunDataGrid.DataSource = kategori;
            }
            clearReasultTexts();
            MessageBox.Show("Ekleme İşlemi Gerçekleştirilmiştir");
        }

        private void DecBtn_Click(object sender, EventArgs e)
        {
            String SeriNo = ExitSeriText;
            int exit_adet = Int32.Parse(ExitAdetText);

            int Adet = dau.GetUrunAdet(SeriNo);
            Adet -= exit_adet;
            dau.UpdateUrun(Adet, SeriNo);
            kategori = dau.GetUrun(SeriNoTxt);
            UrunDataGrid.DataSource = kategori;

            clearReasultTexts();
            MessageBox.Show("Çıkarma İşlemi Gerçekleştirilmiştir");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            dau.DeleteRow(SeriNoTxt);
            clearReasultTexts();
            MessageBox.Show("Silme İşlemi Gerçekleştirilmiştir");
        }
    }   

}
   

