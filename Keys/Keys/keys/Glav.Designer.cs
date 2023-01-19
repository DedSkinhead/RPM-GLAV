namespace keys
{
    partial class Glav
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        
        private void InitializeComponent()
        {
            this.logi = new System.Windows.Forms.TextBox();
            this.log = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.passw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // logi
            // 
            this.logi.Location = new System.Drawing.Point(450, 12);
            this.logi.Name = "logi";
            this.logi.Size = new System.Drawing.Size(100, 20);
            this.logi.TabIndex = 0;
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.Location = new System.Drawing.Point(406, 15);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(38, 13);
            this.log.TabIndex = 1;
            this.log.Text = "Логин";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(590, 15);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(45, 13);
            this.pass.TabIndex = 5;
            this.pass.Text = "Пароль";
            // 
            // passw
            // 
            this.passw.Location = new System.Drawing.Point(641, 12);
            this.passw.Name = "passw";
            this.passw.Size = new System.Drawing.Size(100, 20);
            this.passw.TabIndex = 4;
            // 
            // Glav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.passw);
            this.Controls.Add(this.log);
            this.Controls.Add(this.logi);
            this.Name = "Glav";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logi;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.TextBox passw;
    }
}

