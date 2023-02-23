using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;


namespace mobile.panel.Admin_Area
{
    public partial class AdminDashboard : Form
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

        public AdminDashboard()
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
            admin_panel.Controls.Add(childForm);
            admin_panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


       

        private void add_item_Click(object sender, EventArgs e)
        {
            NewItem n = new NewItem();
            n.TopLevel = false;
            admin_panel.Controls.Add(n);
            n.BringToFront();
            n.Show();
        }

        private void log_out_Click(object sender, EventArgs e)
        {
            theme h1 = new theme();
            h1.Show();
            this.Dispose();
        }

        private void edit_item_Click(object sender, EventArgs e)
        {
            EditItemscs edit = new EditItemscs();
            edit.TopLevel = false;
            admin_panel.Controls.Add(edit);
            edit.BringToFront();
            edit.Show();
        }

        private void delete_item_Click(object sender, EventArgs e)
        {
            DeleteItems delete = new DeleteItems();
            delete.TopLevel = false;
            admin_panel.Controls.Add(delete);
            delete.BringToFront();
            delete.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
