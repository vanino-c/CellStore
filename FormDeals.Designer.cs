namespace CellStore
{
    partial class FormDeals
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listViewDeals = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelProvider = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.comboBoxPhone = new System.Windows.Forms.ComboBox();
            this.comboBoxProvider = new System.Windows.Forms.ComboBox();
            this.labelCase = new System.Windows.Forms.Label();
            this.labelSafe = new System.Windows.Forms.Label();
            this.comboBoxCase = new System.Windows.Forms.ComboBox();
            this.comboBoxSafe = new System.Windows.Forms.ComboBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelSd = new System.Windows.Forms.Label();
            this.labelPayment = new System.Windows.Forms.Label();
            this.textBoxPayment = new System.Windows.Forms.TextBox();
            this.comboBoxSeller = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.comboBoxSd = new System.Windows.Forms.ComboBox();
            this.textBoxFee = new System.Windows.Forms.TextBox();
            this.textBoxTotalP = new System.Windows.Forms.TextBox();
            this.labelFee = new System.Windows.Forms.Label();
            this.labelTotalP = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(342, 398);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(101, 31);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(235, 398);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(101, 31);
            this.buttonEdit.TabIndex = 11;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(128, 398);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(101, 31);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listViewDeals
            // 
            this.listViewDeals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader2,
            this.columnHeader12,
            this.columnHeader1,
            this.columnHeader13});
            this.listViewDeals.FullRowSelect = true;
            this.listViewDeals.GridLines = true;
            this.listViewDeals.HideSelection = false;
            this.listViewDeals.Location = new System.Drawing.Point(12, 12);
            this.listViewDeals.MultiSelect = false;
            this.listViewDeals.Name = "listViewDeals";
            this.listViewDeals.Size = new System.Drawing.Size(588, 380);
            this.listViewDeals.TabIndex = 9;
            this.listViewDeals.UseCompatibleStateImageBehavior = false;
            this.listViewDeals.View = System.Windows.Forms.View.Details;
            this.listViewDeals.SelectedIndexChanged += new System.EventHandler(this.listViewDeals_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Продавец";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Тип";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Товар";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Стоимость";
            // 
            // labelProvider
            // 
            this.labelProvider.AutoSize = true;
            this.labelProvider.Location = new System.Drawing.Point(608, 108);
            this.labelProvider.Name = "labelProvider";
            this.labelProvider.Size = new System.Drawing.Size(56, 13);
            this.labelProvider.TabIndex = 17;
            this.labelProvider.Text = "Оператор";
            this.labelProvider.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(606, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Тип услуги";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Покупка телефона",
            "Оплата связи"});
            this.comboBoxType.Location = new System.Drawing.Point(611, 77);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(182, 28);
            this.comboBoxType.TabIndex = 15;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // textBoxColor
            // 
            this.textBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxColor.Location = new System.Drawing.Point(611, 172);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(182, 26);
            this.textBoxColor.TabIndex = 14;
            this.textBoxColor.Text = "Чёрный";
            this.textBoxColor.Visible = false;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(610, 156);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(84, 13);
            this.labelColor.TabIndex = 16;
            this.labelColor.Text = "Цвет телефона";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(606, 108);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(52, 13);
            this.labelPhone.TabIndex = 17;
            this.labelPhone.Text = "Телефон";
            // 
            // comboBoxPhone
            // 
            this.comboBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPhone.FormattingEnabled = true;
            this.comboBoxPhone.Items.AddRange(new object[] {
            "Нет",
            "Да",
            "Гибридный"});
            this.comboBoxPhone.Location = new System.Drawing.Point(611, 124);
            this.comboBoxPhone.Name = "comboBoxPhone";
            this.comboBoxPhone.Size = new System.Drawing.Size(182, 28);
            this.comboBoxPhone.TabIndex = 19;
            this.comboBoxPhone.Visible = false;
            this.comboBoxPhone.SelectedIndexChanged += new System.EventHandler(this.comboBoxPhone_SelectedIndexChanged);
            // 
            // comboBoxProvider
            // 
            this.comboBoxProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxProvider.FormattingEnabled = true;
            this.comboBoxProvider.Location = new System.Drawing.Point(611, 123);
            this.comboBoxProvider.Name = "comboBoxProvider";
            this.comboBoxProvider.Size = new System.Drawing.Size(182, 28);
            this.comboBoxProvider.TabIndex = 19;
            this.comboBoxProvider.Visible = false;
            // 
            // labelCase
            // 
            this.labelCase.AutoSize = true;
            this.labelCase.Location = new System.Drawing.Point(610, 246);
            this.labelCase.Name = "labelCase";
            this.labelCase.Size = new System.Drawing.Size(38, 13);
            this.labelCase.TabIndex = 17;
            this.labelCase.Text = "Чехол";
            // 
            // labelSafe
            // 
            this.labelSafe.AutoSize = true;
            this.labelSafe.Location = new System.Drawing.Point(610, 294);
            this.labelSafe.Name = "labelSafe";
            this.labelSafe.Size = new System.Drawing.Size(97, 13);
            this.labelSafe.TabIndex = 17;
            this.labelSafe.Text = "Защитная плёнка";
            // 
            // comboBoxCase
            // 
            this.comboBoxCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCase.FormattingEnabled = true;
            this.comboBoxCase.Items.AddRange(new object[] {
            "Нет",
            "Да(+500)"});
            this.comboBoxCase.Location = new System.Drawing.Point(612, 262);
            this.comboBoxCase.Name = "comboBoxCase";
            this.comboBoxCase.Size = new System.Drawing.Size(182, 28);
            this.comboBoxCase.TabIndex = 19;
            this.comboBoxCase.SelectedIndexChanged += new System.EventHandler(this.comboBoxCase_SelectedIndexChanged);
            // 
            // comboBoxSafe
            // 
            this.comboBoxSafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSafe.FormattingEnabled = true;
            this.comboBoxSafe.Items.AddRange(new object[] {
            "Нет",
            "Да(+300)"});
            this.comboBoxSafe.Location = new System.Drawing.Point(613, 311);
            this.comboBoxSafe.Name = "comboBoxSafe";
            this.comboBoxSafe.Size = new System.Drawing.Size(182, 28);
            this.comboBoxSafe.TabIndex = 19;
            this.comboBoxSafe.SelectedIndexChanged += new System.EventHandler(this.comboBoxSafe_SelectedIndexChanged);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrice.Location = new System.Drawing.Point(613, 358);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(182, 26);
            this.textBoxPrice.TabIndex = 14;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(612, 342);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(94, 13);
            this.labelPrice.TabIndex = 16;
            this.labelPrice.Text = "Цена за телефон";
            // 
            // labelSd
            // 
            this.labelSd.AutoSize = true;
            this.labelSd.Location = new System.Drawing.Point(610, 201);
            this.labelSd.Name = "labelSd";
            this.labelSd.Size = new System.Drawing.Size(52, 13);
            this.labelSd.TabIndex = 17;
            this.labelSd.Text = "Sd карта";
            // 
            // labelPayment
            // 
            this.labelPayment.AutoSize = true;
            this.labelPayment.Location = new System.Drawing.Point(608, 154);
            this.labelPayment.Name = "labelPayment";
            this.labelPayment.Size = new System.Drawing.Size(44, 13);
            this.labelPayment.TabIndex = 17;
            this.labelPayment.Text = "Оплата";
            this.labelPayment.Visible = false;
            // 
            // textBoxPayment
            // 
            this.textBoxPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPayment.Location = new System.Drawing.Point(611, 171);
            this.textBoxPayment.Name = "textBoxPayment";
            this.textBoxPayment.Size = new System.Drawing.Size(182, 26);
            this.textBoxPayment.TabIndex = 14;
            this.textBoxPayment.Visible = false;
            this.textBoxPayment.TextChanged += new System.EventHandler(this.textBoxPayment_TextChanged);
            // 
            // comboBoxSeller
            // 
            this.comboBoxSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSeller.FormattingEnabled = true;
            this.comboBoxSeller.Items.AddRange(new object[] {
            "Покупка телефона",
            "Оплата связи"});
            this.comboBoxSeller.Location = new System.Drawing.Point(609, 30);
            this.comboBoxSeller.Name = "comboBoxSeller";
            this.comboBoxSeller.Size = new System.Drawing.Size(182, 28);
            this.comboBoxSeller.TabIndex = 15;
            this.comboBoxSeller.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(606, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Продавец";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTotal.Location = new System.Drawing.Point(613, 403);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(182, 26);
            this.textBoxTotal.TabIndex = 14;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(612, 387);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(82, 13);
            this.labelTotal.TabIndex = 16;
            this.labelTotal.Text = "Конечная цена";
            // 
            // comboBoxSd
            // 
            this.comboBoxSd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSd.FormattingEnabled = true;
            this.comboBoxSd.Items.AddRange(new object[] {
            "Нет",
            "4гб(+200)",
            "8гб(+400)",
            "16гб(+700)",
            "32гб(+1200)"});
            this.comboBoxSd.Location = new System.Drawing.Point(611, 217);
            this.comboBoxSd.MinimumSize = new System.Drawing.Size(182, 0);
            this.comboBoxSd.Name = "comboBoxSd";
            this.comboBoxSd.Size = new System.Drawing.Size(182, 28);
            this.comboBoxSd.TabIndex = 19;
            this.comboBoxSd.Visible = false;
            this.comboBoxSd.SelectedIndexChanged += new System.EventHandler(this.comboBoxSd_SelectedIndexChanged);
            // 
            // textBoxFee
            // 
            this.textBoxFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFee.Location = new System.Drawing.Point(613, 262);
            this.textBoxFee.Name = "textBoxFee";
            this.textBoxFee.ReadOnly = true;
            this.textBoxFee.Size = new System.Drawing.Size(182, 26);
            this.textBoxFee.TabIndex = 14;
            // 
            // textBoxTotalP
            // 
            this.textBoxTotalP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTotalP.Location = new System.Drawing.Point(611, 312);
            this.textBoxTotalP.Name = "textBoxTotalP";
            this.textBoxTotalP.ReadOnly = true;
            this.textBoxTotalP.Size = new System.Drawing.Size(182, 26);
            this.textBoxTotalP.TabIndex = 14;
            // 
            // labelFee
            // 
            this.labelFee.AutoSize = true;
            this.labelFee.Location = new System.Drawing.Point(612, 246);
            this.labelFee.Name = "labelFee";
            this.labelFee.Size = new System.Drawing.Size(58, 13);
            this.labelFee.TabIndex = 16;
            this.labelFee.Text = "Комиссия";
            // 
            // labelTotalP
            // 
            this.labelTotalP.AutoSize = true;
            this.labelTotalP.Location = new System.Drawing.Point(610, 296);
            this.labelTotalP.Name = "labelTotalP";
            this.labelTotalP.Size = new System.Drawing.Size(82, 13);
            this.labelTotalP.TabIndex = 16;
            this.labelTotalP.Text = "Конечная цена";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumber.Location = new System.Drawing.Point(611, 215);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(182, 26);
            this.textBoxNumber.TabIndex = 14;
            this.textBoxNumber.Visible = false;
            this.textBoxNumber.TextChanged += new System.EventHandler(this.textBoxPayment_TextChanged);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(610, 200);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(93, 13);
            this.labelNumber.TabIndex = 16;
            this.labelNumber.Text = "Номер телефона";
            this.labelNumber.Visible = false;
            // 
            // FormDeals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 439);
            this.Controls.Add(this.comboBoxSafe);
            this.Controls.Add(this.comboBoxCase);
            this.Controls.Add(this.comboBoxSd);
            this.Controls.Add(this.comboBoxProvider);
            this.Controls.Add(this.comboBoxPhone);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelSafe);
            this.Controls.Add(this.labelCase);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelSd);
            this.Controls.Add(this.labelTotalP);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelFee);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelPayment);
            this.Controls.Add(this.labelProvider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSeller);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.textBoxPayment);
            this.Controls.Add(this.textBoxTotalP);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.textBoxFee);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewDeals);
            this.MaximumSize = new System.Drawing.Size(816, 478);
            this.MinimumSize = new System.Drawing.Size(816, 478);
            this.Name = "FormDeals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сделки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listViewDeals;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Label labelProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.ComboBox comboBoxPhone;
        private System.Windows.Forms.ComboBox comboBoxProvider;
        private System.Windows.Forms.Label labelCase;
        private System.Windows.Forms.Label labelSafe;
        private System.Windows.Forms.ComboBox comboBoxCase;
        private System.Windows.Forms.ComboBox comboBoxSafe;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelSd;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Label labelPayment;
        private System.Windows.Forms.TextBox textBoxPayment;
        private System.Windows.Forms.ComboBox comboBoxSeller;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.ComboBox comboBoxSd;
        private System.Windows.Forms.TextBox textBoxFee;
        private System.Windows.Forms.TextBox textBoxTotalP;
        private System.Windows.Forms.Label labelFee;
        private System.Windows.Forms.Label labelTotalP;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelNumber;
    }
}