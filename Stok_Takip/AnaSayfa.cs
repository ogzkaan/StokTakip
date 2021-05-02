using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using NLog.LayoutRenderers;

namespace Stok_Takip
{
    public partial class AnaSayfa : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        List<Personel> personel = new List<Personel>();
        DataAccessPersonel dap = new DataAccessPersonel();

        Islemler Islem = new Islemler();

        public static String kullaniciAdi;
        public static int yetkiSeviyesi;

        private IconButton crntBtn;
        private Panel lefBorderBtn;
        private Form CurrentForm;
       
        bool LogInCheck=false;

        public AnaSayfa()
        {
            MainProg.logger.Error("Ana form constructor is strating.."); 
            InitializeComponent();
            lefBorderBtn = new Panel();
            lefBorderBtn.Size = new Size(7, 84);
            SideMenu.Controls.Add(lefBorderBtn);
            
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            SifreTxt.PasswordChar = '*';
            MainProg.logger.Error("Ana form constructor is started.");
        }

        //-------------------------------------Arayüz işlemleri
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableBtn();
                crntBtn = (IconButton)senderBtn;
                crntBtn.BackColor = Color.FromArgb(156, 195, 213);
                crntBtn.ForeColor = color;
                crntBtn.TextAlign = ContentAlignment.MiddleCenter;
                crntBtn.IconColor = color;
                crntBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                crntBtn.ImageAlign = ContentAlignment.MiddleRight;

                lefBorderBtn.BackColor = color;
                lefBorderBtn.Location = new Point(0, crntBtn.Location.Y);
                lefBorderBtn.Visible = true;
                lefBorderBtn.BringToFront();
                childForm.IconChar = crntBtn.IconChar;
                childTitle.Text = crntBtn.Text;
            }
        }
        private void DisableBtn()
        {
             if (crntBtn != null)
            {
                crntBtn.BackColor = Color.FromArgb(0, 99, 178);
                crntBtn.ForeColor = Color.White;
                crntBtn.TextAlign = ContentAlignment.MiddleCenter;
                crntBtn.IconColor = Color.White;
                crntBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                crntBtn.ImageAlign = ContentAlignment.MiddleLeft;
                
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (CurrentForm!=null &&CurrentForm !=Islem)
            {
                CurrentForm.Close();
            }
            Islem.Hide();
            CurrentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            desktopPanel.Controls.Add(childForm);
            desktopPanel.Tag = childForm;
            childForm.BringToFront();
            shadowPanel.BackColor = Color.FromArgb(156, 195, 213);
            shadowPanel.Visible = true;
            
            
            childForm.Show();
            
            

        }
        private void islemButton_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (LogInCheck)
            {
               
                if (button == islemButton&& yetkiSeviyesi<2)
                {
                    ActivateButton(sender, Color.White);
                    OpenChildForm(Islem);
                }
                else if (button == personelButton && yetkiSeviyesi < 1)
                {
                    ActivateButton(sender, Color.White);
                    OpenChildForm(new Personel_Form());
                }
                else if (button == urunlerbtn) 
                {
                    ActivateButton(sender, Color.White);
                    OpenChildForm(new Urunler_Form());
                }
                else if(button== projeBtn && yetkiSeviyesi < 2)
                {
                    ActivateButton(sender, Color.White);
                    OpenChildForm(new Projeler_Form());
                }
                else 
                {
                    MessageBox.Show("Yetki Seviyesi Yetersiz");
                }
            }
            else
            {
                MessageBox.Show("Lütfen giriş yapınız");
            }
        }
        private void homeBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            DisableBtn();
            childForm.IconChar = IconChar.Home;
            childTitle.Text = "Ana Sayfa";
            lefBorderBtn.Visible = false;
            shadowPanel.Visible = false;
            if (CurrentForm!=null&& CurrentForm != Islem)
            {
                CurrentForm.Close();
            }
            else
            {
                CurrentForm.Hide();
            }
           
        }
        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //-------------------------------------Arayüz işlemleri
        //Ana Menü Saat Tarih
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToLongTimeString();
            lbDate.Text = DateTime.Now.ToLongDateString();
        }

        //Uygulama ve thread kapatma
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Islem.Dispose();
            if (ReadSerialPort.thread.IsAlive)
            {
                ReadSerialPort.thread.Abort();
            }
           
        }
        //Program alta alma
        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void SignIn_Click(object sender, EventArgs e)
        {
            kullaniciAdi = KullaniciAdiTxt.Text;
            String sifre = SifreTxt.Text;
            personel = dap.GetSifreYetki(kullaniciAdi);
            String realSifre= personel[0].Sifre;
            //realSifre=personel.Select(x => x.Sifre).ToString();
            if (sifre == realSifre&& !String.IsNullOrEmpty(realSifre))
            {
                yetkiSeviyesi = personel[0].Yetki_Seviyesi;
                MessageBox.Show("Giriş Başarılı");
                LogInCheck = true;
                label3.Text = "Kullanıcı Adı: " + kullaniciAdi;
                SignIn.Hide();
                SignOut.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış");
            }
           
        }
        private void OturumKapat_Click(object sender, EventArgs e)
        {
            SignIn.Show();
            SignOut.Hide();
            KullaniciAdiTxt.Text = "";
            SifreTxt.Text = "";
            label3.Text = "";
            LogInCheck = false;
        }
    }
}
