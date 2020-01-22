using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZylxCheats
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Side_Panel.Height = Home_btn.Height;
            Side_Panel.Top = Home_btn.Top;
            home_Page1.BringToFront();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Banner_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            Side_Panel.Height = Home_btn.Height;
            Side_Panel.Top = Home_btn.Top;
            home_Page1.BringToFront();
        }

        private void cheat_btn_Click(object sender, EventArgs e)
        {
            Side_Panel.Height = cheat_btn.Height;
            Side_Panel.Top = cheat_btn.Top;
            cheat_Page1.BringToFront();
        }

        private void Features_btn_Click(object sender, EventArgs e)
        {
            Side_Panel.Height = Features_btn.Height;
            Side_Panel.Top = Features_btn.Top;
            feature_Page1.BringToFront();
        }

        private void Settings_btn_Click(object sender, EventArgs e)
        {
            Side_Panel.Height = Settings_btn.Height;
            Side_Panel.Top = Settings_btn.Top;
            setting_Page1.BringToFront();

        }
    }
}
