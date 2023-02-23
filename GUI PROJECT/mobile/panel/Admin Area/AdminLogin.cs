using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace mobile.panel.Admin_Area
{
    public partial class AdminLogin : Form
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
        public AdminLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (admin_username.Text == "admin")
            {
                if (admin_password.Text == "admin" )
                {
                    AdminDashboard h1 = new AdminDashboard();
                    h1.Show();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Please Enter Correct Password...");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Correct Username...");
            }
            
            /*AdminDashboard l = new AdminDashboard();
            l.Show();*/
            

        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            theme h1 = new theme();
            h1.Show();
            this.Close();
        }
    }
}
