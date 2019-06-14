using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework;
using System.Runtime.InteropServices;

namespace LuggageManagementSystem
{
    public partial class Home : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public Home()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));



        }

        private void hide_panel()
        {
            Booking_panel.Visible = false;
            City_Panel.Visible = false;

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            bunifuTransition1.ShowSync(Booking_panel, false, BunifuAnimatorNS.Animation.Transparent);
            
            Booking_panel.Visible = true;
            Booking_panel.BringToFront();

        }

        private void Home_Load(object sender, EventArgs e)
        {
            hide_panel();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Booking_panel.Visible = false;

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            bunifuTransition1.ShowSync(City_Panel, false, BunifuAnimatorNS.Animation.Transparent);
            City_Panel.Visible = true;
                City_Panel.BringToFront();

        }
    }
}
