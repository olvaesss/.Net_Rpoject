namespace kursach
{
    partial class AddManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.Name_Input = new System.Windows.Forms.TextBox();
            this.Email_Input = new System.Windows.Forms.TextBox();
            this.Phone_Input = new System.Windows.Forms.TextBox();
            this.Password_Input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(255, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление Менеджера";
            // 
            // Name_Input
            // 
            this.Name_Input.Location = new System.Drawing.Point(268, 147);
            this.Name_Input.Name = "Name_Input";
            this.Name_Input.Size = new System.Drawing.Size(256, 27);
            this.Name_Input.TabIndex = 1;
            // 
            // Email_Input
            // 
            this.Email_Input.Location = new System.Drawing.Point(268, 192);
            this.Email_Input.Name = "Email_Input";
            this.Email_Input.Size = new System.Drawing.Size(256, 27);
            this.Email_Input.TabIndex = 2;
            // 
            // Phone_Input
            // 
            this.Phone_Input.Location = new System.Drawing.Point(268, 240);
            this.Phone_Input.Name = "Phone_Input";
            this.Phone_Input.Size = new System.Drawing.Size(256, 27);
            this.Phone_Input.TabIndex = 3;
            // 
            // Password_Input
            // 
            this.Password_Input.Location = new System.Drawing.Point(268, 289);
            this.Password_Input.Name = "Password_Input";
            this.Password_Input.Size = new System.Drawing.Size(256, 27);
            this.Password_Input.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(330, 322);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(123, 39);
            this.Confirm.TabIndex = 9;
            this.Confirm.Text = "Создать";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(694, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(94, 29);
            this.Back.TabIndex = 10;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // AddManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Password_Input);
            this.Controls.Add(this.Phone_Input);
            this.Controls.Add(this.Email_Input);
            this.Controls.Add(this.Name_Input);
            this.Controls.Add(this.label1);
            this.Name = "AddManager";
            this.Text = "AddManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox Name_Input;
        private TextBox Email_Input;
        private TextBox Phone_Input;
        private TextBox Password_Input;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button Confirm;
        private Button Back;
    }
}