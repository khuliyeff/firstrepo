namespace Sinema_App
{
    partial class Rezerv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rezerv));
            this.Rezerv_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Rezerv_Btn
            // 
            this.Rezerv_Btn.BackColor = System.Drawing.Color.Black;
            this.Rezerv_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Rezerv_Btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.Rezerv_Btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Rezerv_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Rezerv_Btn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rezerv_Btn.ForeColor = System.Drawing.Color.White;
            this.Rezerv_Btn.Location = new System.Drawing.Point(616, 433);
            this.Rezerv_Btn.Name = "Rezerv_Btn";
            this.Rezerv_Btn.Size = new System.Drawing.Size(85, 32);
            this.Rezerv_Btn.TabIndex = 0;
            this.Rezerv_Btn.Text = "Rezerv Et";
            this.Rezerv_Btn.UseVisualStyleBackColor = false;
            this.Rezerv_Btn.Click += new System.EventHandler(this.Rezerv_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Screen Display";
            // 
            // Rezerv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(746, 477);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rezerv_Btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rezerv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Rezerv";
            this.Load += new System.EventHandler(this.Rezerv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Rezerv_Btn;
        private System.Windows.Forms.Label label1;
    }
}