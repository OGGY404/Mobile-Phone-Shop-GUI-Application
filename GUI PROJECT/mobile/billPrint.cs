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
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Printing;

namespace mobile
{
    public partial class billPrint : Form
    {

        SqlConnection connection;


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

        public billPrint(string id, string got, string cusid)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //invoiceno();
            get_id.Text = id;
            get_unique.Text = got;
            getcusid.Text = cusid;

            connection = connection_class.GetSqlConnection();

            string sql = "select * from Invoice_Table WHERE Cus_id = ('" + getcusid.Text + "')";
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader show = command.ExecuteReader(CommandBehavior.SingleResult);
            show.Read();
            get_invice.Text = show["Invoice_num"].ToString();





        }



        private void billPrint_Load(object sender, EventArgs e)
        {
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
                    get_date.Text = DateTime.Now.ToShortDateString();
                    bill_item_name.Text = show["Mobile_Name"].ToString();
                    bill_item_price.Text = show["Price"].ToString();
                    del_charge.Text = "250";
                    double total = (double.Parse(bill_item_price.Text) + double.Parse(del_charge.Text));
                    get_bill_price.Text = Convert.ToString(total);
                    connection.Close();

                }

                catch (Exception ex)
                {
                    //MessageBox.Show("invalid username or password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {
                    string sq = "select* from Customer_Table WHERE Customer_id = ('" + getcusid.Text + "')";
                    connection.Open();
                    SqlCommand command1 = new SqlCommand(sq, connection);
                    SqlDataReader show1 = command1.ExecuteReader(CommandBehavior.SingleResult);

                    show1.Read();

                    cus_name.Text = show1["Customer_name"].ToString();
                    cus_add.Text = show1["Customer_address"].ToString();
                    cus_email.Text = show1["Customer_email"].ToString();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
                    get_date.Text = DateTime.Now.ToShortDateString();
                    bill_item_name.Text = show["Mobile_Name"].ToString();
                    bill_item_price.Text = show["Price"].ToString();
                    del_charge.Text = "250";
                    double total = (double.Parse(bill_item_price.Text) + double.Parse(del_charge.Text));
                    get_bill_price.Text = Convert.ToString(total);

                    connection.Close();
                }

                catch (Exception ex)
                {
                    //MessageBox.Show("invalid username or password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                try
                {
                    string sq = "select* from Customer_Table WHERE Customer_id = ('" + getcusid.Text + "')";
                    connection.Open();
                    SqlCommand command1 = new SqlCommand(sq, connection);
                    SqlDataReader show1 = command1.ExecuteReader(CommandBehavior.SingleResult);

                    show1.Read();

                    cus_name.Text = show1["Customer_name"].ToString();
                    cus_add.Text = show1["Customer_address"].ToString();
                    cus_email.Text = show1["Customer_email"].ToString();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
                    get_date.Text = DateTime.Now.ToShortDateString();
                    bill_item_name.Text = show["Mobile_Name"].ToString();
                    bill_item_price.Text = show["Price"].ToString();
                    del_charge.Text = "250";
                    double total = (double.Parse(bill_item_price.Text) + double.Parse(del_charge.Text));
                    get_bill_price.Text = Convert.ToString(total);



                    connection.Close();
                }

                catch (Exception ex)
                {
                    //MessageBox.Show("invalid username or password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    string sq = "select* from Customer_Table WHERE Customer_id = ('" + getcusid.Text + "')";
                    connection.Open();
                    SqlCommand command1 = new SqlCommand(sq, connection);
                    SqlDataReader show1 = command1.ExecuteReader(CommandBehavior.SingleResult);

                    show1.Read();

                    cus_name.Text = show1["Customer_name"].ToString();
                    cus_add.Text = show1["Customer_address"].ToString();
                    cus_email.Text = show1["Customer_email"].ToString();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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

                    get_date.Text = DateTime.Now.ToShortDateString();
                    bill_item_name.Text = show["Mobile_Name"].ToString();
                    bill_item_price.Text = show["Price"].ToString();
                    del_charge.Text = "250";
                    double total = (double.Parse(bill_item_price.Text) + double.Parse(del_charge.Text));
                    get_bill_price.Text = Convert.ToString(total);




                    connection.Close();
                }

                catch (Exception ex)
                {
                    //MessageBox.Show("invalid username or password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    string sq = "select* from Customer_Table WHERE Customer_id = ('" + getcusid.Text + "')";
                    connection.Open();
                    SqlCommand command1 = new SqlCommand(sq, connection);
                    SqlDataReader show1 = command1.ExecuteReader(CommandBehavior.SingleResult);

                    show1.Read();

                    cus_name.Text = show1["Customer_name"].ToString();
                    cus_add.Text = show1["Customer_address"].ToString();
                    cus_email.Text = show1["Customer_email"].ToString();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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

                    get_date.Text = DateTime.Now.ToShortDateString();
                    bill_item_name.Text = show["Accessory_Name"].ToString();
                    bill_item_price.Text = show["Price"].ToString();
                    del_charge.Text = "250";
                    double total = (double.Parse(bill_item_price.Text) + double.Parse(del_charge.Text));
                    get_bill_price.Text = Convert.ToString(total);


                    connection.Close();
                }

                catch (Exception ex)
                {
                    //MessageBox.Show("invalid username or password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    string sq = "select* from Customer_Table WHERE Customer_id = ('" + getcusid.Text + "')";
                    connection.Open();
                    SqlCommand command1 = new SqlCommand(sq, connection);
                    SqlDataReader show1 = command1.ExecuteReader(CommandBehavior.SingleResult);

                    show1.Read();

                    cus_name.Text = show1["Customer_name"].ToString();
                    cus_add.Text = show1["Customer_address"].ToString();
                    cus_email.Text = show1["Customer_email"].ToString();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(printbill, "Print");
        }

        private void print(Panel pn1)
        {
            PrinterSettings ps = new PrinterSettings();
            printbill = pn1;
            getprintarea(pn1);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

        private void getprintarea(Panel pn1)
        {
            memorying = new Bitmap(pn1.Width, pn1.Height);
            pn1.DrawToBitmap(memorying, new Rectangle(0, 0, pn1.Width, pn1.Height));
        }
           

        private Bitmap memorying;

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memorying, (pagearea.Width / 2) - (this.printbill.Width / 2), this.printbill.Location.Y);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            print(this.printbill);
        }
    }
}
