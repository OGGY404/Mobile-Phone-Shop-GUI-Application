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
using System.Runtime.InteropServices;

namespace mobile
{

    public partial class ViewMobilecs : Form
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



        SqlConnection connection;
        

        public ViewMobilecs(string id,string got)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            get_id.Text = id;
            get_unique.Text = got;
            

            buttoncall(id, got);
        }


        private void ViewMobilecs_Load(object sender, EventArgs e)
        { 
            connection = connection_class.GetSqlConnection();
            if (get_unique.Text == "samsung")
            {
                try
                {
                    string sql = "select * from Samsung_Table WHERE Mobile_ID = ('" + get_id.Text + "')";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader show = command.ExecuteReader(CommandBehavior.SingleResult);

                    show.Read();
                   byte[] image = (byte[])(show["Image"]);
                    MemoryStream ms = new MemoryStream(image);
                    get_image.Image = Image.FromStream(ms);

                    get_name.Text = show["Mobile_Name"].ToString();
                    get_description.Text = show["Description"].ToString();
                    itemprice.Text = show["Price"].ToString();
                    //buy_button.Text = "BUY";




                    connection.Close();
                }

                catch (Exception ex)
                {
                    //MessageBox.Show("invalid username or password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (get_unique.Text == "huawei")
            {

                try
                {
                    string sql = "select * from Huawei_Table WHERE Mobile_ID = ('" + get_id.Text + "')";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader show = command.ExecuteReader(CommandBehavior.SingleResult);

                    show.Read();
                    byte[] image = (byte[])(show["Image"]);
                    MemoryStream ms = new MemoryStream(image);
                    get_image.Image = Image.FromStream(ms);

                    get_name.Text = show["Mobile_Name"].ToString();
                    get_description.Text = show["Description"].ToString();
                    itemprice.Text = show["Price"].ToString();
                    




                    connection.Close();
                }

                catch (Exception ex)
                {
                    //MessageBox.Show("invalid username or password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (get_unique.Text == "xiaomi")
            {

                try
                {
                    string sql = "select * from Xiaomi_Table WHERE Mobile_ID = ('" + get_id.Text + "')";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader show = command.ExecuteReader(CommandBehavior.SingleResult);

                    show.Read();
                    byte[] image = (byte[])(show["Image"]);
                    MemoryStream ms = new MemoryStream(image);
                    get_image.Image = Image.FromStream(ms);

                    get_name.Text = show["Mobile_Name"].ToString();
                    get_description.Text = show["Description"].ToString();
                    itemprice.Text = show["Price"].ToString();
                    //buy_button.Text = "BUY";




                    connection.Close();
                }

                catch (Exception ex)
                {
                    //MessageBox.Show("invalid username or password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (get_unique.Text == "apple")
            {

                try
                {
                    string sql = "select * from Apple_Table WHERE Mobile_ID = ('" + get_id.Text + "')";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader show = command.ExecuteReader(CommandBehavior.SingleResult);

                    show.Read();
                    byte[] image = (byte[])(show["Image"]);
                    MemoryStream ms = new MemoryStream(image);
                    get_image.Image = Image.FromStream(ms);

                    get_name.Text = show["Mobile_Name"].ToString();
                    get_description.Text = show["Description"].ToString();
                    itemprice.Text = show["Price"].ToString();
                    //buttoncall = "BUY";




                    connection.Close();
                }

                catch (Exception ex)
                {
                    //MessageBox.Show("invalid username or password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (get_unique.Text == "accessory")
            {

                try
                {
                    string sql = "select * from Accessory_Table WHERE Accessory_ID = ('" + get_id.Text + "')";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader show = command.ExecuteReader(CommandBehavior.SingleResult);

                    show.Read();
                    byte[] image = (byte[])(show["Image"]);
                    MemoryStream ms = new MemoryStream(image);
                    get_image.Image = Image.FromStream(ms);

                    get_name.Text = show["Accessory_Name"].ToString();
                    get_description.Text = show["Description"].ToString();
                    itemprice.Text = show["Price"].ToString();
                   // buy_button.Text = "BUY";




                    connection.Close();
                }

                catch (Exception ex)
                {
                    //MessageBox.Show("invalid username or password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public System.Windows.Forms.Button buttoncall(string id, string got)
        {
            System.Windows.Forms.Button button_here = new System.Windows.Forms.Button();
            this.Controls.Add(button_here);
            button_here.Top =  405;
            button_here.Left = 33;
            button_here.Name = this.ToString();
            button_here.Text = "BUY";

            button_here.Click += new EventHandler(ItemClicked);


            void ItemClicked(Object sender, EventArgs e)
            {

                PlaceOrder view = new PlaceOrder(id, got);
                view.Show();
                
            }

            button_here.BackColor = Color.FromArgb(136, 19, 71);
            button_here.ForeColor = Color.FromArgb(255, 255, 255);
            button_here.Size = new Size(281, 50);
            button_here.Font = new Font("Nirmala UI", 12f);

         
            return button_here;
        }

        
    } 

}