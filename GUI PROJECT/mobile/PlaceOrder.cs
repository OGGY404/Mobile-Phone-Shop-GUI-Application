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
    public partial class PlaceOrder : Form
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

        public PlaceOrder(string id,string got)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            label3.Text = id;
            label15.Text = got;
            buttoncall(id, got);
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {

            this.Close();
        }







        private void PlaceOrder_Load(object sender, EventArgs e)
        {

        }

        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        string sql;

        public void invoiceno()
        {
            connection = connection_class.GetSqlConnection();
            try
            {
                sql = "select MAX(Invoice_num) from Invoice_Table";
                cmd = new SqlCommand(sql, connection);

                connection.Open();

                var maxid = cmd.ExecuteScalar() as string;

                if (maxid == null)
                {

                    label17.Text = "I-000001";
                }
                else
                {
                    int intval = int.Parse(maxid.Substring(2, 6));
                    intval++;
                    label17.Text = string.Format("I-{0:000000}", intval);



                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public System.Windows.Forms.Button buttoncall(string id, string got)
        {
            System.Windows.Forms.Button button_here = new System.Windows.Forms.Button();
            this.Controls.Add(button_here);
            button_here.Top = 497;
            button_here.Left =561;
            button_here.Name = this.ToString();
            button_here.Text = "BUY";

            button_here.Click += new EventHandler(ItemClicked);


            void ItemClicked(Object sender, EventArgs e)
            {
                try
                {

                    string no = label17.Text;
                    string iname = it_name.Text;
                    string price = total.Text;
                    string day = date.Text;
                    string cid = cus_nic.Text;

                    sql = "Insert into Invoice_Table(Cus_id,Invoice_num,Item_Name,price,Invoice_date) VALUES (@nic,@Invoice_num,@Item_Name,@price,@Invoice_date)";
                    connection.Open();
                    cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@Invoice_num", no);
                    cmd.Parameters.AddWithValue("@Item_Name", iname);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@Invoice_date", day);
                    cmd.Parameters.AddWithValue("@nic",cid);
                    MessageBox.Show("Updated.....");
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    invoiceno();
                    //get_invice.Text;
                   
                    
                    

                    connection.Close();
                
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                try
                {

                    

                    connection = connection_class.GetSqlConnection();
                    string sql = "Insert into Customer_Table(Customer_id,Customer_Name,Customer_address,Customer_mobile,Customer_email) VALUES (@nic,'" + cus_firstname.Text + "','" + cus_adresss.Text + "',@cus_mobile,'" + cus_email.Text + "')";

                  
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    //SqlCommand command1 = new SqlCommand(sq, connection);
                    command.Parameters.Add(new SqlParameter("@nic", long.Parse(cus_nic.Text)));
                    command.Parameters.Add(new SqlParameter("@cus_mobile", long.Parse(cus_mobile.Text)));
                    //command1.ExecuteNonQuery();
                    command.ExecuteNonQuery();
                    connection.Close();

                    string cusid = cus_nic.Text;

                    //null
                    cus_firstname.Text = "";
                    cus_nic.Text = "";
                    cus_mobile.Text = "";
                    cus_adresss.Text = "";
                    cus_email.Text = "";


                    MessageBox.Show("Upload successfully!!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    billPrint view = new billPrint(id, got, cusid);
                    view.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            button_here.BackColor = Color.FromArgb(136, 19, 71);
            button_here.ForeColor = Color.FromArgb(255, 255, 255);
            button_here.Size = new Size(569, 33);
            button_here.Font = new Font("Nirmala UI", 12f);


            return button_here;
        }

       


       

       


        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

            connection = connection_class.GetSqlConnection();


            if (label15.Text == "samsung")
            {
                try
                {
                    string sql = "select * from Samsung_Table WHERE Mobile_ID = ('" + label3.Text + "')";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader show = command.ExecuteReader(CommandBehavior.SingleResult);

                    show.Read();

                    it_name.Text = show["Mobile_Name"].ToString();
                    it_price.Text = show["Price"].ToString();
                    delivery.Text = "250";
                    double total = (double.Parse(it_price.Text) + double.Parse(delivery.Text));
                    this.total.Text = Convert.ToString(total);


                    connection.Close();
                }

                catch (Exception ex)
                {
                    //MessageBox.Show("invalid username or password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (label15.Text == "huawei")
            {

                try
                {
                    string sql = "select * from Huawei_Table WHERE Mobile_ID = ('" + label3.Text + "')";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader show = command.ExecuteReader(CommandBehavior.SingleResult);

                    show.Read();

                    it_name.Text = show["Mobile_Name"].ToString();
                    it_price.Text = show["Price"].ToString();
                    delivery.Text = "250";
                    double total = (double.Parse(it_price.Text) + double.Parse(delivery.Text));
                    this.total.Text = Convert.ToString(total);

                    connection.Close();
                }

                catch (Exception ex)
                {
                    //MessageBox.Show("invalid username or password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (label15.Text == "xiaomi")
            {

                try
                {
                    string sql = "select * from Xiaomi_Table WHERE Mobile_ID = ('" + label3.Text + "')";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader show = command.ExecuteReader(CommandBehavior.SingleResult);

                    show.Read();

                    it_name.Text = show["Mobile_Name"].ToString();
                    it_price.Text = show["Price"].ToString();
                    delivery.Text = "250";
                    double total = (double.Parse(it_price.Text) + double.Parse(delivery.Text));
                    this.total.Text = Convert.ToString(total);



                    connection.Close();
                }

                catch (Exception ex)
                {
                    //MessageBox.Show("invalid username or password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (label15.Text == "apple")
            {

                try
                {
                    string sql = "select * from Apple_Table WHERE Mobile_ID = ('" + label3.Text + "')";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader show = command.ExecuteReader(CommandBehavior.SingleResult);

                    show.Read();



                    it_name.Text = show["Mobile_Name"].ToString();
                    it_price.Text = show["Price"].ToString();
                    delivery.Text = "250";
                    double total = (double.Parse(it_price.Text) + double.Parse(delivery.Text));
                    this.total.Text = Convert.ToString(total);




                    connection.Close();
                }

                catch (Exception ex)
                {
                    //MessageBox.Show(
                }

            }
            else if (label15.Text == "accessory")
            {

                try
                {
                    string sql = "select * from Accessory_Table WHERE Accessory_ID = ('" + label3.Text + "')";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader show = command.ExecuteReader(CommandBehavior.SingleResult);

                    show.Read();


                    it_name.Text = show["Accessory_Name"].ToString();
                    it_price.Text = show["Price"].ToString();
                    delivery.Text = "250";
                    double total = (double.Parse(it_price.Text) + double.Parse(delivery.Text));
                    this.total.Text = Convert.ToString(total);



                    connection.Close();
                }

                catch (Exception ex)
                {
                    //MessageBox.Show
                }

            }
        }

        private void PlaceOrder_Load_1(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToShortDateString();
            invoiceno();
           

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }

       
    }
