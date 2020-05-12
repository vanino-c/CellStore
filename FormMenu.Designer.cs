namespace CellStore
{
    partial class FormMenu
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
            this.buttonSellers = new System.Windows.Forms.Button();
            this.buttonPhones = new System.Windows.Forms.Button();
            this.buttonProviders = new System.Windows.Forms.Button();
            this.buttonDeals = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSellers
            // 
            this.buttonSellers.Enabled = false;
            this.buttonSellers.Location = new System.Drawing.Point(12, 101);
            this.buttonSellers.Name = "buttonSellers";
            this.buttonSellers.Size = new System.Drawing.Size(248, 48);
            this.buttonSellers.TabIndex = 0;
            this.buttonSellers.Text = "Управление продавцами";
            this.buttonSellers.UseVisualStyleBackColor = true;
            this.buttonSellers.Click += new System.EventHandler(this.buttonSellers_Click);
            // 
            // buttonPhones
            // 
            this.buttonPhones.Location = new System.Drawing.Point(12, 155);
            this.buttonPhones.Name = "buttonPhones";
            this.buttonPhones.Size = new System.Drawing.Size(248, 48);
            this.buttonPhones.TabIndex = 0;
            this.buttonPhones.Text = "Телефоны";
            this.buttonPhones.UseVisualStyleBackColor = true;
            this.buttonPhones.Click += new System.EventHandler(this.buttonPhones_Click);
            // 
            // buttonProviders
            // 
            this.buttonProviders.Location = new System.Drawing.Point(12, 209);
            this.buttonProviders.Name = "buttonProviders";
            this.buttonProviders.Size = new System.Drawing.Size(248, 48);
            this.buttonProviders.TabIndex = 0;
            this.buttonProviders.Text = "Операторы связи";
            this.buttonProviders.UseVisualStyleBackColor = true;
            this.buttonProviders.Click += new System.EventHandler(this.buttonProviders_Click);
            // 
            // buttonDeals
            // 
            this.buttonDeals.Location = new System.Drawing.Point(12, 263);
            this.buttonDeals.Name = "buttonDeals";
            this.buttonDeals.Size = new System.Drawing.Size(248, 48);
            this.buttonDeals.TabIndex = 0;
            this.buttonDeals.Text = "Сделки";
            this.buttonDeals.UseVisualStyleBackColor = true;
            this.buttonDeals.Click += new System.EventHandler(this.buttonDeals_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CellStore.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUser.Location = new System.Drawing.Point(12, 9);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(80, 20);
            this.labelUser.TabIndex = 2;
            this.labelUser.Text = "labelUser";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 323);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDeals);
            this.Controls.Add(this.buttonProviders);
            this.Controls.Add(this.buttonPhones);
            this.Controls.Add(this.buttonSellers);
            this.MaximumSize = new System.Drawing.Size(288, 362);
            this.MinimumSize = new System.Drawing.Size(288, 362);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Связьфон";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMenu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSellers;
        private System.Windows.Forms.Button buttonPhones;
        private System.Windows.Forms.Button buttonProviders;
        private System.Windows.Forms.Button buttonDeals;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelUser;
    }
}

