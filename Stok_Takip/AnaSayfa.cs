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

namespace Stok_Takip
{
    public partial class AnaSayfa : Form
    {
        private IconButton crntBtn;
        private Panel lefBorderBtn;
        private Form CurrentForm;
        Islemler Islem = new Islemler();
        DataAccessPersonel dap = new DataAccessPersonel();
        bool LogInCheck=false;

        public AnaSayfa()
        {
            
            InitializeComponent();
            lefBorderBtn = new Panel();
            lefBorderBtn.Size = new Size(7, 84);
            SideMenu.Controls.Add(lefBorderBtn);
            
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            SifreTxt.PasswordChar = '*';
            
        }
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
            if(CurrentForm!= Islem && CurrentForm != null)
            {
                CurrentForm.Close();
            }
            else
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
            childForm.Visible = true;
            childForm.Show();
        }
        private void islemButton_Click(object sender, EventArgs e)
        {
           
            if (LogInCheck)
            {
                ActivateButton(sender, Color.White);
                OpenChildForm(Islem);
            }
            else
            {
                MessageBox.Show("Lütfen Giriş Yapınız");
            }
        }
        private void personelButton_Click(object sender, EventArgs e)
        {
           
            if (LogInCheck)
            {
                ActivateButton(sender, Color.White);
                OpenChildForm(new Personel_Form());
            }
            else
            {
                MessageBox.Show("Lütfen Giriş Yapınız");
            }

        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
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
            if (CurrentForm == Islem)
            {
                CurrentForm.Hide();
            }
            else
            {
                CurrentForm.Close();
            }
           
        }
        //title bar 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd,int wMsg,int wParam,int lParam);

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToLongTimeString();
            lbDate.Text = DateTime.Now.ToLongDateString();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Islem.Dispose();
            //Islem.thread.Abort();
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState=FormWindowState.Normal;
        }
        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void SignIn_Click(object sender, EventArgs e)
        {
            String kullaniciAdi = KullaniciAdiTxt.Text;
            String sifre = SifreTxt.Text;
            String realSifre = dap.GetSifre(kullaniciAdi);
            if (sifre == realSifre)
            {
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

        /*private void AnaSayfa_Load(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(new Bitmap(@"C:\Users\oguzk\Downloads\d.jpeg"), 48, 48);
            this.Cursor = new Cursor(bmp.GetHicon());
        }*/
    }
}
