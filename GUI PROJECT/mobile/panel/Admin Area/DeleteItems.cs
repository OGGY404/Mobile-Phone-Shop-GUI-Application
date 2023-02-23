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
    public partial class DeleteItems : Form
    {
        SqlConnection connection;
        SqlCommand command;
        public DeleteItems()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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

       
        

        private void delete_Click_1(object sender, EventArgs e)
        {
            if (in_category.SelectedItem == null)
            {
                MessageBox.Show("Please Select Category First...");
            }
            else
            {

                try

                {   if (in_category.SelectedIndex == 0)
                    {
                        try
                        {
                            connection = connection_class.GetSqlConnection();
                            string sql = "Delete from Apple_Table WHERE Mobile_ID = ('" + in_id.Text + "')";
                            connection.Open();
                            SqlCommand command = new SqlCommand(sql, connection);
                            command.ExecuteNonQuery();
                            in_id.Text = "";
                            MessageBox.Show("Delete Successfully!!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Invalid ID");
                        }
                    }
                    else if (in_category.SelectedIndex == 1)
                    {
                        try
                        {
                            connection = connection_class.GetSqlConnection();
                            string sql = "Delete from Samsung_Table WHERE Mobile_ID = ('" + in_id.Text + "')";
                            connection.Open();
                            SqlCommand command = new SqlCommand(sql, connection);
                            command.ExecuteNonQuery();
                            in_id.Text = "";
                            MessageBox.Show("Delete Successfully!!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Invalid ID");
                        }

                    }
                    else if (in_category.SelectedIndex == 2)
                    {
                        try
                        {
                            connection = connection_class.GetSqlConnection();
                            string sql = "Delete from Huawei_Table WHERE Mobile_ID = ('" + in_id.Text + "')";
                            connection.Open();
                            SqlCommand command = new SqlCommand(sql, connection);
                            command.ExecuteNonQuery();
                            in_id.Text = "";
                            MessageBox.Show("Delete Successfully!!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Invalid ID");
                        }
                    }
                    else if (in_category.SelectedIndex == 3)
                    {
                        try
                        {
                            connection = connection_class.GetSqlConnection();
                            string sql = "Delete from Xiaomi_Table WHERE Mobile_ID = ('" + in_id.Text + "')";
                            connection.Open();
                            SqlCommand command = new SqlCommand(sql, connection);
                            command.ExecuteNonQuery();
                            in_id.Text = "";
                            MessageBox.Show("Delete Successfully!!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Invalid ID");
                        }
                    }
                   else if (in_category.SelectedIndex == 4)
                    {
                        try
                        {
                            connection = connection_class.GetSqlConnection();
                            string sql = "Delete from Accessory_Table WHERE Accessory_ID = ('" + in_id.Text + "')";
                            connection.Open();
                            SqlCommand command = new SqlCommand(sql, connection);
                            command.ExecuteNonQuery();
                            in_id.Text = "";
                            MessageBox.Show("Delete Successfully!!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Invalid ID");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection faild");
                }
            }
        }
    }
}
