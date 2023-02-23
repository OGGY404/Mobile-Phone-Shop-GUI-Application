
namespace mobile.panel.Admin_Area
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.admin_panel = new System.Windows.Forms.Panel();
            this.log_out = new System.Windows.Forms.Button();
            this.delete_item = new System.Windows.Forms.Button();
            this.edit_item = new System.Windows.Forms.Button();
            this.add_item = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 36);
            this.label1.TabIndex = 13;
            this.label1.Text = "Admin Area";
            // 
            // admin_panel
            // 
            this.admin_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.admin_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("admin_panel.BackgroundImage")));
            this.admin_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.admin_panel.Location = new System.Drawing.Point(182, 28);
            this.admin_panel.Margin = new System.Windows.Forms.Padding(2);
            this.admin_panel.Name = "admin_panel";
            this.admin_panel.Size = new System.Drawing.Size(738, 462);
            this.admin_panel.TabIndex = 12;
            // 
            // log_out
            // 
            this.log_out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.log_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(30)))), ((int)(((byte)(88)))));
            this.log_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_out.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.log_out.Location = new System.Drawing.Point(9, 405);
            this.log_out.Margin = new System.Windows.Forms.Padding(2);
            this.log_out.Name = "log_out";
            this.log_out.Size = new System.Drawing.Size(168, 40);
            this.log_out.TabIndex = 11;
            this.log_out.Text = "Log Out";
            this.log_out.UseVisualStyleBackColor = false;
            this.log_out.Click += new System.EventHandler(this.log_out_Click);
            // 
            // delete_item
            // 
            this.delete_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(30)))), ((int)(((byte)(88)))));
            this.delete_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_item.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.delete_item.Location = new System.Drawing.Point(9, 197);
            this.delete_item.Margin = new System.Windows.Forms.Padding(2);
            this.delete_item.Name = "delete_item";
            this.delete_item.Size = new System.Drawing.Size(168, 40);
            this.delete_item.TabIndex = 10;
            this.delete_item.Text = "Delete Items";
            this.delete_item.UseVisualStyleBackColor = false;
            this.delete_item.Click += new System.EventHandler(this.delete_item_Click);
            // 
            // edit_item
            // 
            this.edit_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(30)))), ((int)(((byte)(88)))));
            this.edit_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_item.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.edit_item.Location = new System.Drawing.Point(9, 144);
            this.edit_item.Margin = new System.Windows.Forms.Padding(2);
            this.edit_item.Name = "edit_item";
            this.edit_item.Size = new System.Drawing.Size(168, 40);
            this.edit_item.TabIndex = 9;
            this.edit_item.Text = "Edit Item";
            this.edit_item.UseVisualStyleBackColor = false;
            this.edit_item.Click += new System.EventHandler(this.edit_item_Click);
            // 
            // add_item
            // 
            this.add_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(30)))), ((int)(((byte)(88)))));
            this.add_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_item.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.add_item.Location = new System.Drawing.Point(9, 92);
            this.add_item.Margin = new System.Windows.Forms.Padding(2);
            this.add_item.Name = "add_item";
            this.add_item.Size = new System.Drawing.Size(168, 40);
            this.add_item.TabIndex = 8;
            this.add_item.Text = "Add Item";
            this.add_item.UseVisualStyleBackColor = false;
            this.add_item.Click += new System.EventHandler(this.add_item_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(885, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(844, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(922, 489);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.admin_panel);
            this.Controls.Add(this.log_out);
            this.Controls.Add(this.delete_item);
            this.Controls.Add(this.edit_item);
            this.Controls.Add(this.add_item);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel admin_panel;
        private System.Windows.Forms.Button log_out;
        private System.Windows.Forms.Button delete_item;
        private System.Windows.Forms.Button edit_item;
        private System.Windows.Forms.Button add_item;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}