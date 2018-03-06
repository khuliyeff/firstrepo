namespace Sinema_App
{
    partial class Cinema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cinema));
            this.label1 = new System.Windows.Forms.Label();
            this.CinameName_box = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CinemaData_Box = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.price_show_box = new System.Windows.Forms.TextBox();
            this.poeple_box = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "MOVIE";
            // 
            // CinameName_box
            // 
            this.CinameName_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CinameName_box.FormattingEnabled = true;
            this.CinameName_box.Location = new System.Drawing.Point(178, 75);
            this.CinameName_box.Name = "CinameName_box";
            this.CinameName_box.Size = new System.Drawing.Size(212, 32);
            this.CinameName_box.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(-5, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "SESSIONS";
            // 
            // CinemaData_Box
            // 
            this.CinemaData_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CinemaData_Box.FormattingEnabled = true;
            this.CinemaData_Box.Location = new System.Drawing.Point(178, 129);
            this.CinemaData_Box.Name = "CinemaData_Box";
            this.CinemaData_Box.Size = new System.Drawing.Size(212, 32);
            this.CinemaData_Box.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(531, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Location = new System.Drawing.Point(302, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Elave Et";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // price_show_box
            // 
            this.price_show_box.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.price_show_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.price_show_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_show_box.ForeColor = System.Drawing.Color.White;
            this.price_show_box.Location = new System.Drawing.Point(601, 21);
            this.price_show_box.Multiline = true;
            this.price_show_box.Name = "price_show_box";
            this.price_show_box.Size = new System.Drawing.Size(46, 31);
            this.price_show_box.TabIndex = 8;
            this.price_show_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // poeple_box
            // 
            this.poeple_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poeple_box.FormattingEnabled = true;
            this.poeple_box.Location = new System.Drawing.Point(178, 20);
            this.poeple_box.Name = "poeple_box";
            this.poeple_box.Size = new System.Drawing.Size(210, 32);
            this.poeple_box.TabIndex = 10;
            this.poeple_box.SelectedIndexChanged += new System.EventHandler(this.poeple_box_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-2, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Poeple";
            // 
            // Cinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 435);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.poeple_box);
            this.Controls.Add(this.price_show_box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CinemaData_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CinameName_box);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Cinema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinema Step";
            this.Load += new System.EventHandler(this.Cinema_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CinameName_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CinemaData_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox price_show_box;
        private System.Windows.Forms.ComboBox poeple_box;
        private System.Windows.Forms.Label label3;
    }
}

