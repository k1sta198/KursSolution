namespace Crypto
{
    partial class FormReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReg));
            this.tPassReg2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bReg = new System.Windows.Forms.Button();
            this.tPassReg1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tLoginReg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tPassReg2
            // 
            this.tPassReg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tPassReg2.Location = new System.Drawing.Point(99, 191);
            this.tPassReg2.Name = "tPassReg2";
            this.tPassReg2.PasswordChar = '*';
            this.tPassReg2.Size = new System.Drawing.Size(170, 26);
            this.tPassReg2.TabIndex = 22;
            this.tPassReg2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(28, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 26);
            this.label7.TabIndex = 21;
            this.label7.Text = "ПРОВЕРКА";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bReg
            // 
            this.bReg.Location = new System.Drawing.Point(28, 270);
            this.bReg.Name = "bReg";
            this.bReg.Size = new System.Drawing.Size(241, 29);
            this.bReg.TabIndex = 20;
            this.bReg.Text = "ЗАРЕГИСТРИРОВАТЬ";
            this.bReg.UseVisualStyleBackColor = true;
            this.bReg.Click += new System.EventHandler(this.bReg_Click);
            // 
            // tPassReg1
            // 
            this.tPassReg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tPassReg1.Location = new System.Drawing.Point(96, 142);
            this.tPassReg1.Name = "tPassReg1";
            this.tPassReg1.PasswordChar = '*';
            this.tPassReg1.Size = new System.Drawing.Size(173, 26);
            this.tPassReg1.TabIndex = 19;
            this.tPassReg1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(28, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 26);
            this.label3.TabIndex = 18;
            this.label3.Text = "ПАРОЛЬ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tLoginReg
            // 
            this.tLoginReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tLoginReg.Location = new System.Drawing.Point(89, 88);
            this.tLoginReg.Name = "tLoginReg";
            this.tLoginReg.Size = new System.Drawing.Size(180, 26);
            this.tLoginReg.TabIndex = 17;
            this.tLoginReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(28, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "ЛОГИН";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(34, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 34);
            this.label6.TabIndex = 15;
            this.label6.Text = "Укажите данные для регистрации\r\nнового пользователя";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 330);
            this.Controls.Add(this.tPassReg2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bReg);
            this.Controls.Add(this.tPassReg1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tLoginReg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.FormReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tPassReg2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bReg;
        private System.Windows.Forms.TextBox tPassReg1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tLoginReg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}