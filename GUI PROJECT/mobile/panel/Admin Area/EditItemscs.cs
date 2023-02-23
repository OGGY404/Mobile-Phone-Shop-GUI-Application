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
    public partial class EditItemscs : Form
    {
        SqlConnection connection;
        string imgLoc = "";
        public EditItemscs()
        {
            InitializeComponent();
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
                    string sql = "Update Apple_Table set Mobile_Name = '" + in_name.Text + "', Price = '" + in_price.Text + "', Description = '" + description.Text + "', Image = @img WHERE Mobile_ID = ('" + in_id.Text + "')";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
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
            else if (in_category.SelectedIndex == 1)
            {



                try
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);


                    connection = connection_class.GetSqlConnection();
                    string sql = "Update Samsung_Table set Mobile_Name = '" + in_name.Text + "', Price = '" + in_price.Text + "', Description = '" + description.Text + "', Image = @img WHERE Mobile_ID = ('" + in_id.Text + "')";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
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
                    string sql = "Update Huawei_Table set Mobile_Name = '" + in_name.Text + "', Price = '" + in_price.Text + "', Description = '" + description.Text + "', Image = @img WHERE Mobile_ID = ('" + in_id.Text + "')";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
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
            else if (in_category.SelectedIndex == 3)
            {


                try
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);


                    connection = connection_class.GetSqlConnection();
                    string sql = "Update Xiaomi_Table set Mobile_Name = '" + in_name.Text + "', Price = '" + in_price.Text + "', Description = '" + description.Text + "', Image = @img WHERE Mobile_ID = ('" + in_id.Text + "')";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
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
                    string sql = "Update Accessory_Table set Accessory_Name = '" + in_name.Text + "', Price = '" + in_price.Text + "', Description = '" + description.Text + "', Image = @img WHERE Accessory_ID = ('" + in_id.Text + "')";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
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

        private void in_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (in_category.SelectedIndex == 0)
            {
                EditdataGridView.DataSource = null;
                EditdataGridView.Rows.Clear();
                EditdataGridView.Refresh();

                EditdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



                try
                {
                    connection = connection_class.GetSqlConnection();
                    string sql = "SELECT * FROM Apple_Table";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    EditdataGridView.DataSource = dt;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("connection fail!!");
                }
            }
            else if (in_category.SelectedIndex == 1)
            {
                EditdataGridView.DataSource = null;
                EditdataGridView.Rows.Clear();
                EditdataGridView.Refresh();

                EditdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



                try
                {
                    connection = connection_class.GetSqlConnection();
                    string sql = "SELECT * FROM Samsung_Table";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    EditdataGridView.DataSource = dt;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("connection fail!!");
                }
            }
            else if (in_category.SelectedIndex == 2)
            {
                EditdataGridView.DataSource = null;
                EditdataGridView.Rows.Clear();
                EditdataGridView.Refresh();

                EditdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



                try
                {
                    connection = connection_class.GetSqlConnection();
                    string sql = "SELECT * FROM Huawei_Table";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    EditdataGridView.DataSource = dt;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("connection fail!!");
                }
            }
            else if (in_category.SelectedIndex == 3)
            {
                EditdataGridView.DataSource = null;
                EditdataGridView.Rows.Clear();
                EditdataGridView.Refresh();

                EditdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



                try
                {
                    connection = connection_class.GetSqlConnection();
                    string sql = "SELECT * FROM Xiaomi_Table";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    EditdataGridView.DataSource = dt;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("connection fail!!");
                }
            }
            else if (in_category.SelectedIndex == 4)
            {
                EditdataGridView.DataSource = null;
                EditdataGridView.Rows.Clear();
                EditdataGridView.Refresh();

                EditdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



                try
                {
                    connection = connection_class.GetSqlConnection();
                    string sql = "SELECT * FROM Accessory_Table";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    EditdataGridView.DataSource = dt;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("connection fail!!");
                }
            }
        }
    }
}
