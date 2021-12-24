namespace авторизация_и_регистрация
{
    partial class FrmProg
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
            this.pbScrin = new System.Windows.Forms.PictureBox();
            this.btnScrin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbScrin)).BeginInit();
            this.SuspendLayout();
            // 
            // pbScrin
            // 
            this.pbScrin.Location = new System.Drawing.Point(179, 140);
            this.pbScrin.Name = "pbScrin";
            this.pbScrin.Size = new System.Drawing.Size(460, 256);
            this.pbScrin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbScrin.TabIndex = 3;
            this.pbScrin.TabStop = false;
            this.pbScrin.Click += new System.EventHandler(this.pbScrin_Click);
            // 
            // btnScrin
            // 
            this.btnScrin.Location = new System.Drawing.Point(161, 55);
            this.btnScrin.Name = "btnScrin";
            this.btnScrin.Size = new System.Drawing.Size(266, 23);
            this.btnScrin.TabIndex = 2;
            this.btnScrin.Text = "Сделать скриншот";
            this.btnScrin.UseVisualStyleBackColor = true;
            this.btnScrin.Click += new System.EventHandler(this.btnScrin_Click);
            // 
            // FrmProg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbScrin);
            this.Controls.Add(this.btnScrin);
            this.ForeColor = System.Drawing.Color.Fuchsia;
            this.Name = "FrmProg";
            this.Text = "FrmProg";
            ((System.ComponentModel.ISupportInitialize)(this.pbScrin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbScrin;
        private System.Windows.Forms.Button btnScrin;
    }
}