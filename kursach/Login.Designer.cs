namespace kursach
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Email_Input = new System.Windows.Forms.TextBox();
            this.Passwotd_Input = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RegisterLink = new System.Windows.Forms.LinkLabel();
            this.SignManager = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(421, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вход";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(235, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Почта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(235, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            // 
            // Email_Input
            // 
            this.Email_Input.Location = new System.Drawing.Point(369, 167);
            this.Email_Input.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Email_Input.Name = "Email_Input";
            this.Email_Input.Size = new System.Drawing.Size(188, 27);
            this.Email_Input.TabIndex = 3;
            // 
            // Passwotd_Input
            // 
            this.Passwotd_Input.Location = new System.Drawing.Point(369, 232);
            this.Passwotd_Input.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Passwotd_Input.Name = "Passwotd_Input";
            this.Passwotd_Input.Size = new System.Drawing.Size(188, 27);
            this.Passwotd_Input.TabIndex = 4;
            this.Passwotd_Input.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(398, 284);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegisterLink
            // 
            this.RegisterLink.AutoSize = true;
            this.RegisterLink.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegisterLink.Location = new System.Drawing.Point(369, 340);
            this.RegisterLink.Name = "RegisterLink";
            this.RegisterLink.Size = new System.Drawing.Size(202, 23);
            this.RegisterLink.TabIndex = 6;
            this.RegisterLink.TabStop = true;
            this.RegisterLink.Text = "Нет аккаунта? Создайте!";
            this.RegisterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // SignManager
            // 
            this.SignManager.AutoSize = true;
            this.SignManager.Location = new System.Drawing.Point(387, 379);
            this.SignManager.Name = "SignManager";
            this.SignManager.Size = new System.Drawing.Size(153, 20);
            this.SignManager.TabIndex = 7;
            this.SignManager.TabStop = true;
            this.SignManager.Text = "Войти как менеджер";
            this.SignManager.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignManager_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 516);
            this.Controls.Add(this.SignManager);
            this.Controls.Add(this.RegisterLink);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Passwotd_Input);
            this.Controls.Add(this.Email_Input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Email_Input;
        private TextBox Passwotd_Input;
        private Button button1;
        private LinkLabel RegisterLink;
        private LinkLabel SignManager;
    }
}