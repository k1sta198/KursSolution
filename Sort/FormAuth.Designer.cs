namespace Sort
{
    partial class FormAuth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuth));
            this.button_LogIn = new System.Windows.Forms.Button();
            this.textboxPassIn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textboxLoginIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_RegIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_LogIn
            // 
            this.button_LogIn.Location = new System.Drawing.Point(33, 234);
            this.button_LogIn.Margin = new System.Windows.Forms.Padding(4);
            this.button_LogIn.Name = "button_LogIn";
            this.button_LogIn.Size = new System.Drawing.Size(321, 41);
            this.button_LogIn.TabIndex = 6;
            this.button_LogIn.Text = "ВОЙТИ";
            this.button_LogIn.UseVisualStyleBackColor = true;
            this.button_LogIn.Click += new System.EventHandler(this.bIn_Click);
            // 
            // textboxPassIn
            // 
            this.textboxPassIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textboxPassIn.Location = new System.Drawing.Point(115, 167);
            this.textboxPassIn.Margin = new System.Windows.Forms.Padding(4);
            this.textboxPassIn.Name = "textboxPassIn";
            this.textboxPassIn.PasswordChar = '*';
            this.textboxPassIn.Size = new System.Drawing.Size(239, 30);
            this.textboxPassIn.TabIndex = 5;
            this.textboxPassIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(33, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "ПАРОЛЬ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textboxLoginIn
            // 
            this.textboxLoginIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textboxLoginIn.Location = new System.Drawing.Point(115, 101);
            this.textboxLoginIn.Margin = new System.Windows.Forms.Padding(4);
            this.textboxLoginIn.Name = "textboxLoginIn";
            this.textboxLoginIn.Size = new System.Drawing.Size(239, 30);
            this.textboxLoginIn.TabIndex = 3;
            this.textboxLoginIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(33, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "ЛОГИН";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Укажите данные для авторизации";
            // 
            // button_RegIn
            // 
            this.button_RegIn.FlatAppearance.BorderSize = 0;
            this.button_RegIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RegIn.ForeColor = System.Drawing.SystemColors.Control;
            this.button_RegIn.Location = new System.Drawing.Point(33, 276);
            this.button_RegIn.Margin = new System.Windows.Forms.Padding(4);
            this.button_RegIn.Name = "button_RegIn";
            this.button_RegIn.Size = new System.Drawing.Size(321, 36);
            this.button_RegIn.TabIndex = 7;
            this.button_RegIn.Text = "РЕГИСТРАЦИЯ";
            this.button_RegIn.UseVisualStyleBackColor = true;
            this.button_RegIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(380, 336);
            this.Controls.Add(this.button_RegIn);
            this.Controls.Add(this.button_LogIn);
            this.Controls.Add(this.textboxPassIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxLoginIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAuth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAuth_FormClosing);
            this.Load += new System.EventHandler(this.FormAuth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxLoginIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textboxPassIn;
        private System.Windows.Forms.Button button_LogIn;
        private System.Windows.Forms.Button button_RegIn;
    }
}

