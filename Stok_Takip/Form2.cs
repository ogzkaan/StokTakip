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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            customDesing();
        }
        private void customDesing() 
        {
            SubMenu.Visible = false;
            SubMenu2.Visible = false;
        }
        private void hideSub()
        {
            if (SubMenu.Visible == true)
                SubMenu.Visible = false;
            if (SubMenu2.Visible == true)
                SubMenu2.Visible = false;      
        }
        private void showSub(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSub();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            showSub(SubMenu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSub(SubMenu2);
        }

       
    }
}
