namespace kursach
{
    partial class GivePrice
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
            this.Confirm = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Price_Input = new System.Windows.Forms.TextBox();
            this.ID_Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(542, 37);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(112, 29);
            this.Confirm.TabIndex = 0;
            this.Confirm.Text = "Установить";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(676, 37);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(94, 29);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Отменить";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Price_Input
            // 
            this.Price_Input.Location = new System.Drawing.Point(248, 39);
            this.Price_Input.Name = "Price_Input";
            this.Price_Input.Size = new System.Drawing.Size(184, 27);
            this.Price_Input.TabIndex = 2;
            // 
            // ID_Input
            // 
            this.ID_Input.Location = new System.Drawing.Point(248, 6);
            this.ID_Input.Name = "ID_Input";
            this.ID_Input.Size = new System.Drawing.Size(184, 27);
            this.ID_Input.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID Заказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Цена";
            // 
            // GivePrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 78);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID_Input);
            this.Controls.Add(this.Price_Input);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Confirm);
            this.Name = "GivePrice";
            this.Text = "GivePrice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Confirm;
        private Button Cancel;
        private TextBox Price_Input;
        private TextBox ID_Input;
        private Label label1;
        private Label label2;
    }
}