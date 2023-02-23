using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mobile.panel;
using mobile.panel.Admin_Area;
using System.Runtime.InteropServices;

namespace mobile
{
    public partial class theme : Form
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
        public theme()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Main_panel.Controls.Add(childForm);
            Main_panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new panel.HomePage());
        }

        private void theme_Load(object sender, EventArgs e)
        {
            openChildFormInPanel(new panel.HomePage());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new panel.mobile());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminLogin h1 = new AdminLogin();
            h1.Show();
            this.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            
            access a = new access();
            a.TopLevel = false;
            Main_panel.Controls.Add(a);
            a.BringToFront();
            a.Show();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }

    
}
