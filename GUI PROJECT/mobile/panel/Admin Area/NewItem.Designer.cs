
namespace mobile.panel.Admin_Area
{
    partial class NewItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.in_category = new System.Windows.Forms.ComboBox();
            this.category = new System.Windows.Forms.Label();
            this.in_name = new System.Windows.Forms.TextBox();
            this.itemname = new System.Windows.Forms.Label();
            this.browse = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.RichTextBox();
            this.in_price = new System.Windows.Forms.TextBox();
            this.in_id = new System.Windows.Forms.TextBox();
            this.discription = new System.Windows.Forms.Label();
            this.itemprice = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.upload = new System.Windows.Forms.Button();
            this.ItemImage = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ItemImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 38);
            this.label2.TabIndex = 94;
            this.label2.Text = "Add Items";
            // 
            // in_category
            // 
            this.in_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_category.FormattingEnabled = true;
            this.in_category.Items.AddRange(new object[] {
            "Apple",
            "Samsung",
            "Huawei",
            "Xiaomi",
            "Accessories"});
            this.in_category.Location = new System.Drawing.Point(461, 53);
            this.in_category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.in_category.Name = "in_category";
            this.in_category.Size = new System.Drawing.Size(264, 33);
            this.in_category.TabIndex = 93;
            this.in_category.SelectedIndexChanged += new System.EventHandler(this.in_category_SelectedIndexChanged);
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.ForeColor = System.Drawing.Color.White;
            this.category.Location = new System.Drawing.Point(291, 53);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(110, 29);
            this.category.TabIndex = 92;
            this.category.Text = "Category";
            // 
            // in_name
            // 
            this.in_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.in_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_name.Location = new System.Drawing.Point(461, 145);
            this.in_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.in_name.Name = "in_name";
            this.in_name.Size = new System.Drawing.Size(353, 30);
            this.in_name.TabIndex = 91;
            // 
            // itemname
            // 
            this.itemname.AutoSize = true;
            this.itemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemname.ForeColor = System.Drawing.Color.White;
            this.itemname.Location = new System.Drawing.Point(291, 145);
            this.itemname.Name = "itemname";
            this.itemname.Size = new System.Drawing.Size(142, 29);
            this.itemname.TabIndex = 90;
            this.itemname.Text = "Item Name :";
            // 
            // browse
            // 
            this.browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.browse.Location = new System.Drawing.Point(39, 276);
            this.browse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(196, 50);
            this.browse.TabIndex = 89;
            this.browse.Text = "Browse Image";
            this.browse.UseVisualStyleBackColor = false;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // description
            // 
            this.description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.description.BackColor = System.Drawing.Color.White;
            this.description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(489, 313);
            this.description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(353, 84);
            this.description.TabIndex = 87;
            this.description.Text = "";
            // 
            // in_price
            // 
            this.in_price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.in_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_price.Location = new System.Drawing.Point(461, 198);
            this.in_price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.in_price.Name = "in_price";
            this.in_price.Size = new System.Drawing.Size(353, 30);
            this.in_price.TabIndex = 85;
            // 
            // in_id
            // 
            this.in_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.in_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_id.Location = new System.Drawing.Point(461, 100);
            this.in_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.in_id.Name = "in_id";
            this.in_id.Size = new System.Drawing.Size(353, 30);
            this.in_id.TabIndex = 86;
            this.in_id.TextChanged += new System.EventHandler(this.in_id_TextChanged);
            // 
            // discription
            // 
            this.discription.AutoSize = true;
            this.discription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discription.ForeColor = System.Drawing.Color.White;
            this.discription.Location = new System.Drawing.Point(291, 259);
            this.discription.Name = "discription";
            this.discription.Size = new System.Drawing.Size(147, 29);
            this.discription.TabIndex = 82;
            this.discription.Text = "Description :";
            // 
            // itemprice
            // 
            this.itemprice.AutoSize = true;
            this.itemprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemprice.ForeColor = System.Drawing.Color.White;
            this.itemprice.Location = new System.Drawing.Point(291, 199);
            this.itemprice.Name = "itemprice";
            this.itemprice.Size = new System.Drawing.Size(133, 29);
            this.itemprice.TabIndex = 83;
            this.itemprice.Text = "Item Price :";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.Color.White;
            this.id.Location = new System.Drawing.Point(291, 100);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 29);
            this.id.TabIndex = 84;
            this.id.Text = "Item ID :";
            // 
            // upload
            // 
            this.upload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.upload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.upload.Location = new System.Drawing.Point(972, 386);
            this.upload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(115, 41);
            this.upload.TabIndex = 81;
            this.upload.Text = "Upload";
            this.upload.UseVisualStyleBackColor = false;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // ItemImage
            // 
            this.ItemImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemImage.Location = new System.Drawing.Point(37, 66);
            this.ItemImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ItemImage.Name = "ItemImage";
            this.ItemImage.Size = new System.Drawing.Size(197, 193);
            this.ItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ItemImage.TabIndex = 88;
            this.ItemImage.TabStop = false;
            this.ItemImage.Click += new System.EventHandler(this.ItemImage_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 524);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1101, 169);
            this.dataGridView1.TabIndex = 95;
            // 
            // NewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1101, 693);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.in_category);
            this.Controls.Add(this.category);
            this.Controls.Add(this.in_name);
            this.Controls.Add(this.itemname);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.ItemImage);
            this.Controls.Add(this.description);
            this.Controls.Add(this.in_price);
            this.Controls.Add(this.in_id);
            this.Controls.Add(this.discription);
            this.Controls.Add(this.itemprice);
            this.Controls.Add(this.id);
            this.Controls.Add(this.upload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NewItem";
            this.Text = "NewItem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NewItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox in_category;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.TextBox in_name;
        private System.Windows.Forms.Label itemname;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.PictureBox ItemImage;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.TextBox in_price;
        private System.Windows.Forms.TextBox in_id;
        private System.Windows.Forms.Label discription;
        private System.Windows.Forms.Label itemprice;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}