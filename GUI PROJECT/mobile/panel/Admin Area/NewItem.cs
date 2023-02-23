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

namespace mobile.panel.Admin_Area
{
    public partial class NewItem : Form
    {
        SqlConnection connection;
        
        string imgLoc = "";
        public NewItem()
        {
            InitializeComponent();
        }

        private void browse_Click(object sender, EventArgs e)
        {
            

            
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*";
                dlg.Title = "Select Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    ItemImage.ImageLocation = imgLoc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void upload_Click(object sender, EventArgs e)
        {

            if (in_category.SelectedIndex == 0)
            {
             
                    try
                    {
                        byte[] img = null;
                        FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        img = br.ReadBytes((int)fs.Length);


                        connection = connection_class.GetSqlConnection();
                        string sql = "Insert into Apple_Table(Mobile_ID,Mobile_Name,Price,Description,Image) VALUES ('" + in_id.Text + "','" + in_name.Text + "',@input_price, '" + description.Text + "',  @img)";
                        connection.Open();
                        SqlCommand command = new SqlCommand(sql, connection);
                        command.Parameters.Add(new SqlParameter("@input_price",double.Parse(in_price.Text)));
                        command.Parameters.Add(new SqlParameter("@img", img));
                        command.ExecuteNonQuery();
                        connection.Close();

                        ItemImage.Image = null;
                        in_id.Text = "";
                        in_name.Text = "";
                        in_price.Text = "";
                        //double input_price = double.Parse(in_price.Text);
                        description.Text = "";


                        MessageBox.Show("Upload successfully!!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                
                
               
            }
            else if (in_category.SelectedIndex == 1)
            {


                
                try
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);


                    connection = connection_class.GetSqlConnection();
                    string sql = "Insert into Samsung_Table(Mobile_ID,Mobile_Name,Price,Description,Image) VALUES ('" + in_id.Text + "','" + in_name.Text + "',@input_price, '" + description.Text + "',  @img)";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.Add(new SqlParameter("@input_price", double.Parse(in_price.Text)));
                    command.Parameters.Add(new SqlParameter("@img", img));
                    command.ExecuteNonQuery();
                    connection.Close();

                    ItemImage.Image = null;
                    in_id.Text = "";
                    in_name.Text = "";
                    in_price.Text = "";
                    description.Text = "";


                    MessageBox.Show("Upload successfully!!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (in_category.SelectedIndex == 2)
            {
               

                try
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);


                    connection = connection_class.GetSqlConnection();
                    string sql = "Insert into Huawei_Table(Mobile_ID,Mobile_Name,Price,Description,Image) VALUES ('" + in_id.Text + "','" + in_name.Text + "',@input_price, '" + description.Text + "',  @img)";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.Add(new SqlParameter("@input_price", double.Parse(in_price.Text)));
                    command.Parameters.Add(new SqlParameter("@img", img));
                    command.ExecuteNonQuery();
                    connection.Close();

                    ItemImage.Image = null;
                    in_id.Text = "";
                    in_name.Text = "";
                    in_price.Text = "";
                    description.Text = "";


                    MessageBox.Show("Upload successfully!!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if(in_category.SelectedIndex == 3)
            {
                

                try
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);


                    connection = connection_class.GetSqlConnection();
                    string sql = "Insert into Xiaomi_Table(Mobile_ID,Mobile_Name,Price,Description,Image) VALUES ('" + in_id.Text + "','" + in_name.Text + "',@input_price, '" + description.Text + "',  @img)";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.Add(new SqlParameter("@input_price", double.Parse(in_price.Text)));
                    command.Parameters.Add(new SqlParameter("@img", img));
                    command.ExecuteNonQuery();
                    connection.Close();

                    ItemImage.Image = null;
                    in_id.Text = "";
                    in_name.Text = "";
                    in_price.Text = "";
                    description.Text = "";


                    MessageBox.Show("Upload successfully!!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (in_category.SelectedIndex == 4)
            {
                

                try
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);


                    connection = connection_class.GetSqlConnection();
                    string sql = "Insert into Accessory_Table(Accessory_ID,Accessory_Name,Price,Description,Image) VALUES ('" + in_id.Text + "','" + in_name.Text + "',@input_price, '" + description.Text + "',  @img)";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.Add(new SqlParameter("@input_price", double.Parse(in_price.Text)));
                    command.Parameters.Add(new SqlParameter("@img", img));
                    command.ExecuteNonQuery();
                    connection.Close();

                    ItemImage.Image = null;
                    in_id.Text = "";
                    in_name.Text = "";
                    in_price.Text = "";
                    description.Text = "";


                    MessageBox.Show("Upload successfully!!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
               
            }
            else if (in_category.SelectedItem == null)
            {
                MessageBox.Show("Please Select Category First");
            }
        }

        private void in_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (in_category.SelectedIndex == 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



                try
                {
                    connection = connection_class.GetSqlConnection();
                    string sql = "SELECT * FROM Apple_Table";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("connection fail!!");
                }
            }
            else if (in_category.SelectedIndex == 1)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



                try
                {
                    connection = connection_class.GetSqlConnection();
                    string sql = "SELECT * FROM Samsung_Table";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("connection fail!!");
                }
            }
            else if (in_category.SelectedIndex == 2)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



                try
                {
                    connection = connection_class.GetSqlConnection();
                    string sql = "SELECT * FROM Huawei_Table";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("connection fail!!");
                }
            }
            else if (in_category.SelectedIndex == 3)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



                try
                {
                    connection = connection_class.GetSqlConnection();
                    string sql = "SELECT * FROM Xiaomi_Table";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("connection fail!!");
                }
            }
            else if (in_category.SelectedIndex == 4)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



                try
                {
                    connection = connection_class.GetSqlConnection();
                    string sql = "SELECT * FROM Accessory_Table";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("connection fail!!");
                }
            }
        }

        private void NewItem_Load(object sender, EventArgs e)
        {

        }

        private void in_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void ItemImage_Click(object sender, EventArgs e)
        {

        }
    }
}
