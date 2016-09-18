namespace курсач
{
    partial class Load_tapes
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
            this.button_ok = new System.Windows.Forms.Button();
            this.button_no = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(106, 332);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 45);
            this.button_ok.TabIndex = 0;
            this.button_ok.Text = "Хорошо";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_no
            // 
            this.button_no.Location = new System.Drawing.Point(259, 332);
            this.button_no.Name = "button_no";
            this.button_no.Size = new System.Drawing.Size(75, 45);
            this.button_no.TabIndex = 1;
            this.button_no.Text = "отмена";
            this.button_no.UseVisualStyleBackColor = true;
            this.button_no.Click += new System.EventHandler(this.button_no_Click);
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(13, 13);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(490, 313);
            this.panel.TabIndex = 2;
            // 
            // Load_tapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 389);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.button_no);
            this.Controls.Add(this.button_ok);
            this.Name = "Load_tapes";
            this.Text = "Load_tapes";
            this.Load += new System.EventHandler(this.Load_tapes_Load);
            this.Resize += new System.EventHandler(this.Load_tapes_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_no;
        private System.Windows.Forms.Panel panel;
    }
}