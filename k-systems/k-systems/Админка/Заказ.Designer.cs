namespace k_systems.Админка
{
    partial class Заказ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Заказ));
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.priceLabel = new System.Windows.Forms.Label();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.dressTypeLabel = new System.Windows.Forms.Label();
            this.dressTypeComboBox = new System.Windows.Forms.ComboBox();
            this.workKindLabel = new System.Windows.Forms.Label();
            this.workKindComboBox = new System.Windows.Forms.ComboBox();
            this.clientLabel = new System.Windows.Forms.Label();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Location = new System.Drawing.Point(278, 255);
            this.priceNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            -159383553,
            46653770,
            5421,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(273, 22);
            this.priceNumericUpDown.TabIndex = 18;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.priceLabel.Location = new System.Drawing.Point(166, 248);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(76, 29);
            this.priceLabel.TabIndex = 17;
            this.priceLabel.Text = "Цена";
            // 
            // addOrderButton
            // 
            this.addOrderButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addOrderButton.Location = new System.Drawing.Point(198, 346);
            this.addOrderButton.Margin = new System.Windows.Forms.Padding(4);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(240, 64);
            this.addOrderButton.TabIndex = 16;
            this.addOrderButton.Text = "Добавить заказ";
            this.addOrderButton.UseVisualStyleBackColor = true;
            // 
            // dressTypeLabel
            // 
            this.dressTypeLabel.AutoSize = true;
            this.dressTypeLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dressTypeLabel.Location = new System.Drawing.Point(69, 176);
            this.dressTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dressTypeLabel.Name = "dressTypeLabel";
            this.dressTypeLabel.Size = new System.Drawing.Size(169, 29);
            this.dressTypeLabel.TabIndex = 15;
            this.dressTypeLabel.Text = "Тип одежды";
            // 
            // dressTypeComboBox
            // 
            this.dressTypeComboBox.DisplayMember = "Наименование";
            this.dressTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dressTypeComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dressTypeComboBox.FormattingEnabled = true;
            this.dressTypeComboBox.Location = new System.Drawing.Point(277, 176);
            this.dressTypeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.dressTypeComboBox.Name = "dressTypeComboBox";
            this.dressTypeComboBox.Size = new System.Drawing.Size(273, 32);
            this.dressTypeComboBox.TabIndex = 14;
            this.dressTypeComboBox.ValueMember = "Идентификатор";
            // 
            // workKindLabel
            // 
            this.workKindLabel.AutoSize = true;
            this.workKindLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workKindLabel.Location = new System.Drawing.Point(77, 110);
            this.workKindLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.workKindLabel.Name = "workKindLabel";
            this.workKindLabel.Size = new System.Drawing.Size(160, 29);
            this.workKindLabel.TabIndex = 13;
            this.workKindLabel.Text = "Вид работы";
            // 
            // workKindComboBox
            // 
            this.workKindComboBox.DisplayMember = "Наименование";
            this.workKindComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workKindComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workKindComboBox.FormattingEnabled = true;
            this.workKindComboBox.Location = new System.Drawing.Point(278, 110);
            this.workKindComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.workKindComboBox.Name = "workKindComboBox";
            this.workKindComboBox.Size = new System.Drawing.Size(273, 32);
            this.workKindComboBox.TabIndex = 12;
            this.workKindComboBox.ValueMember = "Идентификатор";
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientLabel.Location = new System.Drawing.Point(138, 43);
            this.clientLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(105, 29);
            this.clientLabel.TabIndex = 11;
            this.clientLabel.Text = "Клиент";
            // 
            // clientComboBox
            // 
            this.clientComboBox.DisplayMember = "ФИО";
            this.clientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(277, 43);
            this.clientComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(273, 32);
            this.clientComboBox.TabIndex = 10;
            this.clientComboBox.ValueMember = "Идентификатор";
            // 
            // Заказ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 452);
            this.Controls.Add(this.priceNumericUpDown);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.addOrderButton);
            this.Controls.Add(this.dressTypeLabel);
            this.Controls.Add(this.dressTypeComboBox);
            this.Controls.Add(this.workKindLabel);
            this.Controls.Add(this.workKindComboBox);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.clientComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Заказ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказ";
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.Label dressTypeLabel;
        private System.Windows.Forms.ComboBox dressTypeComboBox;
        private System.Windows.Forms.Label workKindLabel;
        private System.Windows.Forms.ComboBox workKindComboBox;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.ComboBox clientComboBox;
    }
}