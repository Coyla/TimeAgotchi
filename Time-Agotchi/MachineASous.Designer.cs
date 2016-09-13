namespace Time_Agotchi
{
    partial class MachineASous
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
            this.lbMessageInformation = new System.Windows.Forms.Label();
            this.pbGif = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGif)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMessageInformation
            // 
            this.lbMessageInformation.AutoSize = true;
            this.lbMessageInformation.Font = new System.Drawing.Font("Quartz MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessageInformation.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbMessageInformation.Location = new System.Drawing.Point(73, 239);
            this.lbMessageInformation.Name = "lbMessageInformation";
            this.lbMessageInformation.Size = new System.Drawing.Size(208, 18);
            this.lbMessageInformation.TabIndex = 1;
            this.lbMessageInformation.Text = "Realisation en cours ...";
            // 
            // pbGif
            // 
            this.pbGif.Image = global::Time_Agotchi.Properties.Resources.GIF_MachineASous;
            this.pbGif.Location = new System.Drawing.Point(76, 12);
            this.pbGif.Name = "pbGif";
            this.pbGif.Size = new System.Drawing.Size(200, 200);
            this.pbGif.TabIndex = 0;
            this.pbGif.TabStop = false;
            // 
            // MachineASous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(355, 355);
            this.Controls.Add(this.lbMessageInformation);
            this.Controls.Add(this.pbGif);
            this.Name = "MachineASous";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MachineASous";
            ((System.ComponentModel.ISupportInitialize)(this.pbGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGif;
        private System.Windows.Forms.Label lbMessageInformation;
    }
}