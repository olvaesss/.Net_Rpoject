namespace kursach
{
    partial class Main
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
            this.Info = new System.Windows.Forms.Label();
            this.HomeCleanButton = new System.Windows.Forms.Button();
            this.Kovri = new System.Windows.Forms.Button();
            this.Dry = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(152, 44);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(493, 20);
            this.Info.TabIndex = 0;
            this.Info.Text = "Borcelle - сеть химчисток, предоставляющаяя услуги по всему городу";
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // HomeCleanButton
            // 
            this.HomeCleanButton.Location = new System.Drawing.Point(81, 99);
            this.HomeCleanButton.Name = "HomeCleanButton";
            this.HomeCleanButton.Size = new System.Drawing.Size(179, 50);
            this.HomeCleanButton.TabIndex = 1;
            this.HomeCleanButton.Text = "Заказать чистку на дом";
            this.HomeCleanButton.UseVisualStyleBackColor = true;
            this.HomeCleanButton.Click += new System.EventHandler(this.HomeCleanButton_Click);
            // 
            // Kovri
            // 
            this.Kovri.Location = new System.Drawing.Point(318, 99);
            this.Kovri.Name = "Kovri";
            this.Kovri.Size = new System.Drawing.Size(179, 50);
            this.Kovri.TabIndex = 2;
            this.Kovri.Text = "Чистка ковров/vмебели";
            this.Kovri.UseVisualStyleBackColor = true;
            this.Kovri.Click += new System.EventHandler(this.Kovri_Click);
            // 
            // Dry
            // 
            this.Dry.Location = new System.Drawing.Point(560, 99);
            this.Dry.Name = "Dry";
            this.Dry.Size = new System.Drawing.Size(179, 50);
            this.Dry.TabIndex = 3;
            this.Dry.Text = "Прачечная";
            this.Dry.UseVisualStyleBackColor = true;
            this.Dry.Click += new System.EventHandler(this.Dry_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(694, 28);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(94, 29);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Выйти";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(41, 22);
            this.toolStripLabel1.Text = "Help";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Dry);
            this.Controls.Add(this.Kovri);
            this.Controls.Add(this.HomeCleanButton);
            this.Controls.Add(this.Info);
            this.Name = "Main";
            this.Text = "Main";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Info;
        private Button HomeCleanButton;
        private Button Kovri;
        private Button Dry;
        private Button Exit;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
    }
}