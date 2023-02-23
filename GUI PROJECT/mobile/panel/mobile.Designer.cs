
namespace mobile.panel
{
    partial class mobile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mobile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Apple = new System.Windows.Forms.Button();
            this.show_all_mobile = new System.Windows.Forms.Panel();
            this.xiaomi = new System.Windows.Forms.Button();
            this.huawie = new System.Windows.Forms.Button();
            this.samsung = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.Apple);
            this.panel1.Controls.Add(this.show_all_mobile);
            this.panel1.Controls.Add(this.xiaomi);
            this.panel1.Controls.Add(this.huawie);
            this.panel1.Controls.Add(this.samsung);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 477);
            this.panel1.TabIndex = 0;
            // 
            // Apple
            // 
            this.Apple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(229)))));
            this.Apple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Apple.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apple.ForeColor = System.Drawing.Color.Black;
            this.Apple.Location = new System.Drawing.Point(369, 2);
            this.Apple.Margin = new System.Windows.Forms.Padding(2);
            this.Apple.Name = "Apple";
            this.Apple.Size = new System.Drawing.Size(114, 42);
            this.Apple.TabIndex = 24;
            this.Apple.Text = "Apple";
            this.Apple.UseVisualStyleBackColor = false;
            this.Apple.Click += new System.EventHandler(this.Apple_Click);
            // 
            // show_all_mobile
            // 
            this.show_all_mobile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.show_all_mobile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("show_all_mobile.BackgroundImage")));
            this.show_all_mobile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.show_all_mobile.Location = new System.Drawing.Point(2, 63);
            this.show_all_mobile.Margin = new System.Windows.Forms.Padding(2);
            this.show_all_mobile.Name = "show_all_mobile";
            this.show_all_mobile.Size = new System.Drawing.Size(827, 412);
            this.show_all_mobile.TabIndex = 25;
            // 
            // xiaomi
            // 
            this.xiaomi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(229)))));
            this.xiaomi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xiaomi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xiaomi.Location = new System.Drawing.Point(251, 2);
            this.xiaomi.Margin = new System.Windows.Forms.Padding(2);
            this.xiaomi.Name = "xiaomi";
            this.xiaomi.Size = new System.Drawing.Size(114, 42);
            this.xiaomi.TabIndex = 23;
            this.xiaomi.Text = "Xiaomi";
            this.xiaomi.UseVisualStyleBackColor = false;
            this.xiaomi.Click += new System.EventHandler(this.xiaomi_Click);
            // 
            // huawie
            // 
            this.huawie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(229)))));
            this.huawie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.huawie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huawie.Location = new System.Drawing.Point(133, 2);
            this.huawie.Margin = new System.Windows.Forms.Padding(2);
            this.huawie.Name = "huawie";
            this.huawie.Size = new System.Drawing.Size(114, 42);
            this.huawie.TabIndex = 22;
            this.huawie.Text = "Huawie";
            this.huawie.UseVisualStyleBackColor = false;
            this.huawie.Click += new System.EventHandler(this.huawie_Click);
            // 
            // samsung
            // 
            this.samsung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(229)))));
            this.samsung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.samsung.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.samsung.Location = new System.Drawing.Point(12, 2);
            this.samsung.Margin = new System.Windows.Forms.Padding(2);
            this.samsung.Name = "samsung";
            this.samsung.Size = new System.Drawing.Size(117, 42);
            this.samsung.TabIndex = 21;
            this.samsung.Text = "Samsung";
            this.samsung.UseVisualStyleBackColor = false;
            this.samsung.Click += new System.EventHandler(this.samsung_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(610, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALL MOBILES";
            // 
            // mobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(830, 468);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mobile";
            this.Text = "All Mobiles";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel show_all_mobile;
        private System.Windows.Forms.Button Apple;
        private System.Windows.Forms.Button xiaomi;
        private System.Windows.Forms.Button huawie;
        private System.Windows.Forms.Button samsung;
    }
}