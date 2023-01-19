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
            this.kab1 = new System.Windows.Forms.Button();
            this.pass = new System.Windows.Forms.Label();
            this.passw = new System.Windows.Forms.TextBox();
            this.kab2 = new System.Windows.Forms.Button();
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
            // kab1
            // 
            this.kab1.BackColor = System.Drawing.Color.Green;
            this.kab1.Location = new System.Drawing.Point(12, 31);
            this.kab1.Name = "kab1";
            this.kab1.Size = new System.Drawing.Size(97, 74);
            this.kab1.TabIndex = 2;
            this.kab1.Text = "Кабинет 1";
            this.kab1.UseVisualStyleBackColor = false;
            this.kab1.Click += new System.EventHandler(this.kab1_Click);
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
            // kab2
            // 
            this.kab2.BackColor = System.Drawing.Color.Red;
            this.kab2.Location = new System.Drawing.Point(12, 111);
            this.kab2.Name = "kab2";
            this.kab2.Size = new System.Drawing.Size(97, 74);
            this.kab2.TabIndex = 6;
            this.kab2.Text = "Кабинет 2";
            this.kab2.UseVisualStyleBackColor = false;
            this.kab2.Click += new System.EventHandler(this.kab2_Click);
            // 
            // Glav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kab2);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.passw);
            this.Controls.Add(this.kab1);
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
        public System.Windows.Forms.Button kab1;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.TextBox passw;
        public System.Windows.Forms.Button kab2;
    }
}

