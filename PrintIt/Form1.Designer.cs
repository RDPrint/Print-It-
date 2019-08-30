namespace PrintIt
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.select_file_btn = new System.Windows.Forms.Button();
            this.helloWorldLabel = new System.Windows.Forms.Label();
            this.file_path = new System.Windows.Forms.TextBox();
            this.ip_address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enable_lpr_btn = new System.Windows.Forms.Button();
            this.print_it_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.help_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // select_file_btn
            // 
            this.select_file_btn.Location = new System.Drawing.Point(390, 100);
            this.select_file_btn.Margin = new System.Windows.Forms.Padding(2);
            this.select_file_btn.Name = "select_file_btn";
            this.select_file_btn.Size = new System.Drawing.Size(74, 19);
            this.select_file_btn.TabIndex = 2;
            this.select_file_btn.Text = "Select file";
            this.select_file_btn.UseVisualStyleBackColor = true;
            this.select_file_btn.Click += new System.EventHandler(this.Select_file_btn_Click);
            // 
            // helloWorldLabel
            // 
            this.helloWorldLabel.AutoSize = true;
            this.helloWorldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloWorldLabel.Location = new System.Drawing.Point(228, 9);
            this.helloWorldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.helloWorldLabel.Name = "helloWorldLabel";
            this.helloWorldLabel.Size = new System.Drawing.Size(81, 26);
            this.helloWorldLabel.TabIndex = 3;
            this.helloWorldLabel.Text = "Print It!";
            // 
            // file_path
            // 
            this.file_path.Location = new System.Drawing.Point(76, 99);
            this.file_path.Name = "file_path";
            this.file_path.Size = new System.Drawing.Size(309, 20);
            this.file_path.TabIndex = 4;
            // 
            // ip_address
            // 
            this.ip_address.Location = new System.Drawing.Point(76, 138);
            this.ip_address.Name = "ip_address";
            this.ip_address.Size = new System.Drawing.Size(309, 20);
            this.ip_address.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Printer IP Address";
            // 
            // enable_lpr_btn
            // 
            this.enable_lpr_btn.Location = new System.Drawing.Point(12, 257);
            this.enable_lpr_btn.Name = "enable_lpr_btn";
            this.enable_lpr_btn.Size = new System.Drawing.Size(75, 23);
            this.enable_lpr_btn.TabIndex = 7;
            this.enable_lpr_btn.Text = "Enable LPR";
            this.enable_lpr_btn.UseVisualStyleBackColor = true;
            this.enable_lpr_btn.Click += new System.EventHandler(this.Enable_lpr_btn_Click);
            // 
            // print_it_btn
            // 
            this.print_it_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_it_btn.Location = new System.Drawing.Point(212, 216);
            this.print_it_btn.Name = "print_it_btn";
            this.print_it_btn.Size = new System.Drawing.Size(101, 31);
            this.print_it_btn.TabIndex = 8;
            this.print_it_btn.Text = "Print it!";
            this.print_it_btn.UseVisualStyleBackColor = true;
            this.print_it_btn.Click += new System.EventHandler(this.Print_it_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "A visual LPR printer written in C# by Rick Dove";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // help_btn
            // 
            this.help_btn.BackColor = System.Drawing.SystemColors.Control;
            this.help_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("help_btn.BackgroundImage")));
            this.help_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.help_btn.FlatAppearance.BorderSize = 0;
            this.help_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help_btn.Location = new System.Drawing.Point(489, 9);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(32, 32);
            this.help_btn.TabIndex = 10;
            this.help_btn.UseVisualStyleBackColor = false;
            this.help_btn.Click += new System.EventHandler(this.Help_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.help_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.print_it_btn);
            this.Controls.Add(this.enable_lpr_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ip_address);
            this.Controls.Add(this.file_path);
            this.Controls.Add(this.helloWorldLabel);
            this.Controls.Add(this.select_file_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Print It!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button select_file_btn;
        private System.Windows.Forms.Label helloWorldLabel;
        private System.Windows.Forms.TextBox file_path;
        private System.Windows.Forms.TextBox ip_address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enable_lpr_btn;
        private System.Windows.Forms.Button print_it_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button help_btn;
    }
}

