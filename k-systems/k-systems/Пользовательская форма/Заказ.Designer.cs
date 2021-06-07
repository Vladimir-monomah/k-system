namespace k_systems.Пользовательская_форма
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Заказ));
            this.OrderDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Phone = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.workKindLabel = new System.Windows.Forms.Label();
            this.workKindComboBox = new System.Windows.Forms.ComboBox();
            this.видРаботBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._k_systemsDataSet = new k_systems._k_systemsDataSet();
            this.priceLabel = new System.Windows.Forms.Label();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.dressTypeLabel = new System.Windows.Forms.Label();
            this.dressTypeComboBox = new System.Windows.Forms.ComboBox();
            this.типРемонтаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.вид_работTableAdapter = new k_systems._k_systemsDataSetTableAdapters.Вид_работTableAdapter();
            this.тип_ремонтаTableAdapter = new k_systems._k_systemsDataSetTableAdapters.Тип_ремонтаTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видРаботBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._k_systemsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типРемонтаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderDateTimePicker
            // 
            this.OrderDateTimePicker.Location = new System.Drawing.Point(270, 301);
            this.OrderDateTimePicker.Name = "OrderDateTimePicker";
            this.OrderDateTimePicker.Size = new System.Drawing.Size(274, 22);
            this.OrderDateTimePicker.TabIndex = 134;
            this.OrderDateTimePicker.ValueChanged += new System.EventHandler(this.OrderDateTimePicker_ValueChanged);
            // 
            // Phone
            // 
            this.Phone.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Phone.Location = new System.Drawing.Point(270, 47);
            this.Phone.Mask = "+7(***) ***-****";
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(274, 32);
            this.Phone.TabIndex = 132;
            this.Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Phone_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(114, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 39);
            this.label2.TabIndex = 133;
            this.label2.Text = "Телефон";
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Location = new System.Drawing.Point(271, 225);
            this.priceNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            -159383553,
            46653770,
            5421,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(273, 22);
            this.priceNumericUpDown.TabIndex = 129;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(76, 294);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 29);
            this.label3.TabIndex = 128;
            this.label3.Text = "Дата заказа";
            // 
            // workKindLabel
            // 
            this.workKindLabel.AutoSize = true;
            this.workKindLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workKindLabel.Location = new System.Drawing.Point(75, 102);
            this.workKindLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.workKindLabel.Name = "workKindLabel";
            this.workKindLabel.Size = new System.Drawing.Size(160, 29);
            this.workKindLabel.TabIndex = 123;
            this.workKindLabel.Text = "Вид работы";
            // 
            // workKindComboBox
            // 
            this.workKindComboBox.DataSource = this.видРаботBindingSource;
            this.workKindComboBox.DisplayMember = "Наименование";
            this.workKindComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workKindComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workKindComboBox.FormattingEnabled = true;
            this.workKindComboBox.Location = new System.Drawing.Point(271, 102);
            this.workKindComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.workKindComboBox.Name = "workKindComboBox";
            this.workKindComboBox.Size = new System.Drawing.Size(714, 32);
            this.workKindComboBox.TabIndex = 122;
            this.workKindComboBox.ValueMember = "Идентификатор";
            this.workKindComboBox.SelectedValueChanged += new System.EventHandler(this.workKindComboBox_SelectedValueChanged);
            // 
            // видРаботBindingSource
            // 
            this.видРаботBindingSource.DataMember = "Вид работ";
            this.видРаботBindingSource.DataSource = this._k_systemsDataSet;
            // 
            // _k_systemsDataSet
            // 
            this._k_systemsDataSet.DataSetName = "_k_systemsDataSet";
            this._k_systemsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.priceLabel.Location = new System.Drawing.Point(158, 225);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(76, 29);
            this.priceLabel.TabIndex = 127;
            this.priceLabel.Text = "Цена";
            // 
            // addOrderButton
            // 
            this.addOrderButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addOrderButton.Location = new System.Drawing.Point(436, 386);
            this.addOrderButton.Margin = new System.Windows.Forms.Padding(4);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(240, 64);
            this.addOrderButton.TabIndex = 126;
            this.addOrderButton.Text = "Добавить заказ";
            this.addOrderButton.UseVisualStyleBackColor = true;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // dressTypeLabel
            // 
            this.dressTypeLabel.AutoSize = true;
            this.dressTypeLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dressTypeLabel.Location = new System.Drawing.Point(65, 165);
            this.dressTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dressTypeLabel.Name = "dressTypeLabel";
            this.dressTypeLabel.Size = new System.Drawing.Size(172, 29);
            this.dressTypeLabel.TabIndex = 125;
            this.dressTypeLabel.Text = "Тип ремонта";
            // 
            // dressTypeComboBox
            // 
            this.dressTypeComboBox.DataSource = this.типРемонтаBindingSource;
            this.dressTypeComboBox.DisplayMember = "Наименование";
            this.dressTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dressTypeComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dressTypeComboBox.FormattingEnabled = true;
            this.dressTypeComboBox.Location = new System.Drawing.Point(271, 166);
            this.dressTypeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.dressTypeComboBox.Name = "dressTypeComboBox";
            this.dressTypeComboBox.Size = new System.Drawing.Size(714, 32);
            this.dressTypeComboBox.TabIndex = 124;
            this.dressTypeComboBox.ValueMember = "Идентификатор";
            this.dressTypeComboBox.SelectedValueChanged += new System.EventHandler(this.orderPriceComboBox_SelectedValueChanged);
            // 
            // типРемонтаBindingSource
            // 
            this.типРемонтаBindingSource.DataMember = "Тип ремонта";
            this.типРемонтаBindingSource.DataSource = this._k_systemsDataSet;
            // 
            // вид_работTableAdapter
            // 
            this.вид_работTableAdapter.ClearBeforeFill = true;
            // 
            // тип_ремонтаTableAdapter
            // 
            this.тип_ремонтаTableAdapter.ClearBeforeFill = true;
            // 
            // Заказ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 477);
            this.Controls.Add(this.OrderDateTimePicker);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priceNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.workKindLabel);
            this.Controls.Add(this.workKindComboBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.addOrderButton);
            this.Controls.Add(this.dressTypeLabel);
            this.Controls.Add(this.dressTypeComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Заказ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.Заказ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видРаботBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._k_systemsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типРемонтаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker OrderDateTimePicker;
        private System.Windows.Forms.MaskedTextBox Phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label workKindLabel;
        private System.Windows.Forms.ComboBox workKindComboBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.Label dressTypeLabel;
        private System.Windows.Forms.ComboBox dressTypeComboBox;
        private _k_systemsDataSet _k_systemsDataSet;
        private System.Windows.Forms.BindingSource видРаботBindingSource;
        private _k_systemsDataSetTableAdapters.Вид_работTableAdapter вид_работTableAdapter;
        private System.Windows.Forms.BindingSource типРемонтаBindingSource;
        private _k_systemsDataSetTableAdapters.Тип_ремонтаTableAdapter тип_ремонтаTableAdapter;
    }
}