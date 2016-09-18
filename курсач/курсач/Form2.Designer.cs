namespace курсач
{
    partial class Form2
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
            this.label_info = new System.Windows.Forms.Label();
            this.pictur_info = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictur_info)).BeginInit();
            this.SuspendLayout();
            // 
            // label_info
            // 
            this.label_info.AllowDrop = true;
            this.label_info.Location = new System.Drawing.Point(12, 9);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(547, 64);
            this.label_info.TabIndex = 0;
            this.label_info.Text = "В теоретической информатике недетерминированная машина Тьюринга — машина Тьюринга" +
    ", функция перехода которой представляет собой недетерминированный конечный автом" +
    "ат.";
            this.label_info.Click += new System.EventHandler(this.label_info_Click);
            // 
            // pictur_info
            // 
            this.pictur_info.BackColor = System.Drawing.SystemColors.Control;
            this.pictur_info.BackgroundImage = global::курсач.Properties.Resources.turing;
            this.pictur_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictur_info.Location = new System.Drawing.Point(60, 86);
            this.pictur_info.Name = "pictur_info";
            this.pictur_info.Size = new System.Drawing.Size(429, 291);
            this.pictur_info.TabIndex = 21;
            this.pictur_info.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 389);
            this.Controls.Add(this.pictur_info);
            this.Controls.Add(this.label_info);
            this.Name = "Form2";
            this.Text = "машина Тьюринга";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictur_info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.PictureBox pictur_info;


    }
}