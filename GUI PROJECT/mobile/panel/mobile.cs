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
using System.IO;

namespace mobile.panel
{
    public partial class mobile : Form
    {
        public mobile()
        {
            InitializeComponent();
        }

       public void loadform(object Form)
        {
            if (this.show_all_mobile.Controls.Count > 0)
                this.show_all_mobile.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.show_all_mobile.Controls.Add(f);
            this.show_all_mobile.Tag = f;
            f.Show();

        }

        private void samsung_Click(object sender, EventArgs e)
        {
            
            loadform(new samsung());
        }

        private void huawie_Click(object sender, EventArgs e)
        {
            loadform(new Huawei());
        }

        private void xiaomi_Click(object sender, EventArgs e)
        {
            loadform(new Xiaomi());
        }

        private void Apple_Click(object sender, EventArgs e)
        {
            loadform(new Apple());
        }
    }
}
