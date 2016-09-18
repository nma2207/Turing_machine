namespace курсач
{
    partial class Open
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
            this.ok_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ok_button
            // 
            this.ok_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ok_button.Location = new System.Drawing.Point(57, 203);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 47);
            this.ok_button.TabIndex = 0;
            this.ok_button.Text = "хорошо";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click_1);
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(138, 203);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(75, 47);
            this.close_button.TabIndex = 1;
            this.close_button.Text = "отмена";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(258, 185);
            this.panel.TabIndex = 2;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // Open
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.ok_button);
            this.Name = "Open";
            this.Text = "Open";
            this.Load += new System.EventHandler(this.Open_Load);
            this.Resize += new System.EventHandler(this.Open_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Panel panel;


    }
}