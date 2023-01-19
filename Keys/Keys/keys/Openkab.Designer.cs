namespace keys
{
    partial class Openkab
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
            this.openkabinet = new System.Windows.Forms.Label();
            this.Da = new System.Windows.Forms.Button();
            this.Net = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openkabinet
            // 
            this.openkabinet.AutoSize = true;
            this.openkabinet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.openkabinet.Location = new System.Drawing.Point(74, 25);
            this.openkabinet.Name = "openkabinet";
            this.openkabinet.Size = new System.Drawing.Size(302, 25);
            this.openkabinet.TabIndex = 0;
            this.openkabinet.Text = "Хотите освободить кабинет?";
            // 
            // Da
            // 
            this.Da.Location = new System.Drawing.Point(59, 153);
            this.Da.Name = "Da";
            this.Da.Size = new System.Drawing.Size(89, 69);
            this.Da.TabIndex = 1;
            this.Da.Text = "Да";
            this.Da.UseVisualStyleBackColor = true;
            this.Da.Click += new System.EventHandler(this.Da_Click);
            // 
            // Net
            // 
            this.Net.Location = new System.Drawing.Point(287, 153);
            this.Net.Name = "Net";
            this.Net.Size = new System.Drawing.Size(89, 69);
            this.Net.TabIndex = 2;
            this.Net.Text = "Нет";
            this.Net.UseVisualStyleBackColor = true;
            this.Net.Click += new System.EventHandler(this.Net_Click);
            // 
            // Openkab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 258);
            this.Controls.Add(this.Net);
            this.Controls.Add(this.Da);
            this.Controls.Add(this.openkabinet);
            this.Name = "Openkab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label openkabinet;
        private System.Windows.Forms.Button Da;
        private System.Windows.Forms.Button Net;
    }
}