namespace kursach
{
    partial class ManagerForm
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
            this.Exit = new System.Windows.Forms.Button();
            this.OFFERS_Table = new System.Windows.Forms.DataGridView();
            this.CloseOFFER = new System.Windows.Forms.Button();
            this.GivePrice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OFFERS_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(694, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(94, 29);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Выйти";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // OFFERS_Table
            // 
            this.OFFERS_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OFFERS_Table.Location = new System.Drawing.Point(12, 22);
            this.OFFERS_Table.Name = "OFFERS_Table";
            this.OFFERS_Table.RowHeadersWidth = 51;
            this.OFFERS_Table.RowTemplate.Height = 29;
            this.OFFERS_Table.Size = new System.Drawing.Size(497, 394);
            this.OFFERS_Table.TabIndex = 1;
            this.OFFERS_Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OFFERS_Table_CellContentClick);
            // 
            // CloseOFFER
            // 
            this.CloseOFFER.Location = new System.Drawing.Point(515, 92);
            this.CloseOFFER.Name = "CloseOFFER";
            this.CloseOFFER.Size = new System.Drawing.Size(273, 29);
            this.CloseOFFER.TabIndex = 2;
            this.CloseOFFER.Text = "Закрыть заказ";
            this.CloseOFFER.UseVisualStyleBackColor = true;
            this.CloseOFFER.Click += new System.EventHandler(this.CloseOFFER_Click);
            // 
            // GivePrice
            // 
            this.GivePrice.Location = new System.Drawing.Point(515, 57);
            this.GivePrice.Name = "GivePrice";
            this.GivePrice.Size = new System.Drawing.Size(273, 29);
            this.GivePrice.TabIndex = 3;
            this.GivePrice.Text = "Установить цену";
            this.GivePrice.UseVisualStyleBackColor = true;
            this.GivePrice.Click += new System.EventHandler(this.GivePrice_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GivePrice);
            this.Controls.Add(this.CloseOFFER);
            this.Controls.Add(this.OFFERS_Table);
            this.Controls.Add(this.Exit);
            this.Name = "ManagerForm";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OFFERS_Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Exit;
        private DataGridView OFFERS_Table;
        private Button CloseOFFER;
        private Button GivePrice;
    }
}