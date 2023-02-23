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

namespace mobile
{
    public partial class Xiaomi : Form
    {
        SqlConnection connection;
        public Xiaomi()
        {
            InitializeComponent();
        }
         private void Xiaomi_Load(object sender, EventArgs e)
        {
            try
            {
                connection = connection_class.GetSqlConnection();
                string sql = "select * from Xiaomi_Table ORDER BY Mobile_ID DESC;";
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader show = command.ExecuteReader(CommandBehavior.SingleResult);
                while (show.Read())
                {
                    string id = show["Mobile_ID"].ToString();
                    string price = show["Price"].ToString();
                    byte[] image = (byte[])(show["Image"]);
                    string name = show["Mobile_Name"].ToString();
                    string got = "xiaomi";


                    imagecall(image);
                    lablecall(name);
                    buttoncall(id,got);
                }

                connection.Close();
            }

            catch (Exception ex)
            {
                /*panel1.Visible = false;*/
            }



        }

        int a = 1;
        public System.Windows.Forms.PictureBox imagecall(byte[] image)
        {
            System.Windows.Forms.PictureBox img_here = new System.Windows.Forms.PictureBox();
            this.Controls.Add(img_here);
            img_here.Top = a * 150;
            img_here.Left = 20;
            img_here.Name = this.a.ToString();
            MemoryStream ms = new MemoryStream(image);
            img_here.Image = Image.FromStream(ms);
            img_here.SizeMode = PictureBoxSizeMode.StretchImage;
            img_here.Size = new Size(150, 150);

            a = a + 1;
            return img_here;
        }


        int b = 1;
        public System.Windows.Forms.Label lablecall(string name)
        {
            System.Windows.Forms.Label lable_here = new System.Windows.Forms.Label();
            this.Controls.Add(lable_here);
            lable_here.Top = b * 150;
            lable_here.Left = 170;
            lable_here.Name = this.a.ToString();
            lable_here.Size = new Size(400, 35);
            lable_here.Font = new Font("Bebas Neue", 21f);
            lable_here.ForeColor = Color.White;
            lable_here.Text = name;
            b = b + 1;
            return lable_here;
        }

        int c = 1;
        public System.Windows.Forms.Button buttoncall(string id,string got)
        {
            System.Windows.Forms.Button button_here = new System.Windows.Forms.Button();
            this.Controls.Add(button_here);
            button_here.Top = c * 150;
            button_here.Left = 600;
            button_here.Name = this.a.ToString();
            button_here.Text = "View";

            button_here.Click += new EventHandler(ItemClicked);


            void ItemClicked(Object sender, EventArgs e)
            {

                ViewMobilecs view = new ViewMobilecs(id,got);
                view.Show();
            }

            button_here.BackColor = Color.FromArgb(17, 103, 177);
            button_here.ForeColor = Color.FromArgb(208, 239, 255);
            //button_here.Font = new Font(FontFamily.GenericSansSerif, 50);
            //button_here.Anchor = (AnchorStyles.Right | AnchorStyles.Top);
            button_here.Size = new Size(86, 33);
            button_here.Font = new Font("Bebas Neue", 12f);

            c = c + 1;
            return button_here;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            /*details_panel.Visible = false;*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
