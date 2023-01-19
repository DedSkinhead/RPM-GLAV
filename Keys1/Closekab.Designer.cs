namespace keys
{
    partial class Closekab
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
            this.Net = new System.Windows.Forms.Button();
            this.Da = new System.Windows.Forms.Button();
            this.closekabinet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Net
            // 
            this.Net.Location = new System.Drawing.Point(276, 150);
            this.Net.Name = "Net";
            this.Net.Size = new System.Drawing.Size(89, 69);
            this.Net.TabIndex = 5;
            this.Net.Text = "Нет";
            this.Net.UseVisualStyleBackColor = true;
            this.Net.Click += new System.EventHandler(this.Net_Click);
            // 
            // Da
            // 
            this.Da.Location = new System.Drawing.Point(48, 150);
            this.Da.Name = "Da";
            this.Da.Size = new System.Drawing.Size(89, 69);
            this.Da.TabIndex = 4;
            this.Da.Text = "Да";
            this.Da.UseVisualStyleBackColor = true;
            this.Da.Click += new System.EventHandler(this.Da_Click);
            // 
            // closekabinet
            // 
            this.closekabinet.AutoSize = true;
            this.closekabinet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.closekabinet.Location = new System.Drawing.Point(63, 22);
            this.closekabinet.Name = "closekabinet";
            this.closekabinet.Size = new System.Drawing.Size(254, 25);
            this.closekabinet.TabIndex = 3;
            this.closekabinet.Text = "Хотите занять кабинет?";
            // 
            // Closekab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 258);
            this.Controls.Add(this.Net);
            this.Controls.Add(this.Da);
            this.Controls.Add(this.closekabinet);
            this.Name = "Closekab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Net;
        private System.Windows.Forms.Button Da;
        private System.Windows.Forms.Label closekabinet;
    }
}