namespace k_systems.Админка
{
    partial class Отчётность_по_заказам
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Отчётность_по_заказам));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button44 = new System.Windows.Forms.Button();
            this.onPeriodEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.onPeriodBeginDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.onMonthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.onPeriodRadioButton = new System.Windows.Forms.RadioButton();
            this.onMonthRadioButton = new System.Windows.Forms.RadioButton();
            this.button47 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.заказыСКлиентамиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._k_systemsDataSet = new k_systems._k_systemsDataSet();
            this.заказы_с_клиентамиTableAdapter = new k_systems._k_systemsDataSetTableAdapters.Заказы_с_клиентамиTableAdapter();
            this.отчётностьПоЗаказамBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.отчётность_по_заказамTableAdapter = new k_systems._k_systemsDataSetTableAdapters.Отчётность_по_заказамTableAdapter();
            this.Отчётность_по_заказамBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заказыСКлиентамиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._k_systemsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отчётностьПоЗаказамBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Отчётность_по_заказамBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button44);
            this.panel1.Controls.Add(this.onPeriodEndDateTimePicker);
            this.panel1.Controls.Add(this.onPeriodBeginDateTimePicker);
            this.panel1.Controls.Add(this.onMonthDateTimePicker);
            this.panel1.Controls.Add(this.onPeriodRadioButton);
            this.panel1.Controls.Add(this.onMonthRadioButton);
            this.panel1.Controls.Add(this.button47);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 718);
            this.panel1.TabIndex = 5;
            // 
            // button44
            // 
            this.button44.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button44.Location = new System.Drawing.Point(48, 188);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(289, 28);
            this.button44.TabIndex = 2;
            this.button44.Text = "Сформировать отчёт";
            this.button44.UseVisualStyleBackColor = true;
            this.button44.Click += new System.EventHandler(this.button44_Click);
            // 
            // onPeriodEndDateTimePicker
            // 
            this.onPeriodEndDateTimePicker.Location = new System.Drawing.Point(105, 125);
            this.onPeriodEndDateTimePicker.Name = "onPeriodEndDateTimePicker";
            this.onPeriodEndDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.onPeriodEndDateTimePicker.TabIndex = 4;
            // 
            // onPeriodBeginDateTimePicker
            // 
            this.onPeriodBeginDateTimePicker.Location = new System.Drawing.Point(105, 97);
            this.onPeriodBeginDateTimePicker.Name = "onPeriodBeginDateTimePicker";
            this.onPeriodBeginDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.onPeriodBeginDateTimePicker.TabIndex = 4;
            // 
            // onMonthDateTimePicker
            // 
            this.onMonthDateTimePicker.Location = new System.Drawing.Point(105, 58);
            this.onMonthDateTimePicker.Name = "onMonthDateTimePicker";
            this.onMonthDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.onMonthDateTimePicker.TabIndex = 4;
            // 
            // onPeriodRadioButton
            // 
            this.onPeriodRadioButton.AutoSize = true;
            this.onPeriodRadioButton.Location = new System.Drawing.Point(8, 97);
            this.onPeriodRadioButton.Name = "onPeriodRadioButton";
            this.onPeriodRadioButton.Size = new System.Drawing.Size(98, 21);
            this.onPeriodRadioButton.TabIndex = 3;
            this.onPeriodRadioButton.TabStop = true;
            this.onPeriodRadioButton.Text = "За период";
            this.onPeriodRadioButton.UseVisualStyleBackColor = true;
            // 
            // onMonthRadioButton
            // 
            this.onMonthRadioButton.AutoSize = true;
            this.onMonthRadioButton.Location = new System.Drawing.Point(8, 58);
            this.onMonthRadioButton.Name = "onMonthRadioButton";
            this.onMonthRadioButton.Size = new System.Drawing.Size(91, 21);
            this.onMonthRadioButton.TabIndex = 3;
            this.onMonthRadioButton.TabStop = true;
            this.onMonthRadioButton.Text = "На месяц";
            this.onMonthRadioButton.UseVisualStyleBackColor = true;
            // 
            // button47
            // 
            this.button47.Image = ((System.Drawing.Image)(resources.GetObject("button47.Image")));
            this.button47.Location = new System.Drawing.Point(343, 18);
            this.button47.Name = "button47";
            this.button47.Size = new System.Drawing.Size(25, 26);
            this.button47.TabIndex = 2;
            this.button47.UseVisualStyleBackColor = true;
            this.button47.Click += new System.EventHandler(this.button47_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(124, 18);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(213, 22);
            this.textBox9.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(5, 18);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 17);
            this.label21.TabIndex = 0;
            this.label21.Text = "Клиенты";
            // 
            // заказыСКлиентамиBindingSource
            // 
            this.заказыСКлиентамиBindingSource.DataMember = "Заказы с клиентами";
            this.заказыСКлиентамиBindingSource.DataSource = this._k_systemsDataSet;
            // 
            // _k_systemsDataSet
            // 
            this._k_systemsDataSet.DataSetName = "_k_systemsDataSet";
            this._k_systemsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказы_с_клиентамиTableAdapter
            // 
            this.заказы_с_клиентамиTableAdapter.ClearBeforeFill = true;
            // 
            // отчётностьПоЗаказамBindingSource
            // 
            this.отчётностьПоЗаказамBindingSource.DataMember = "Отчётность по заказам";
            this.отчётностьПоЗаказамBindingSource.DataSource = this._k_systemsDataSet;
            // 
            // отчётность_по_заказамTableAdapter
            // 
            this.отчётность_по_заказамTableAdapter.ClearBeforeFill = true;
            // 
            // Отчётность_по_заказамBindingSource
            // 
            this.Отчётность_по_заказамBindingSource.DataMember = "Отчётность по заказам";
            this.Отчётность_по_заказамBindingSource.DataSource = this._k_systemsDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "k_systems.Админка.Отчётность по заказам.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(389, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1080, 708);
            this.reportViewer1.TabIndex = 6;
            // 
            // Отчётность_по_заказам
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 771);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Отчётность_по_заказам";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчётность по заказам";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Отчётность_по_заказам_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заказыСКлиентамиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._k_systemsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отчётностьПоЗаказамBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Отчётность_по_заказамBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button44;
        private System.Windows.Forms.DateTimePicker onPeriodEndDateTimePicker;
        private System.Windows.Forms.DateTimePicker onPeriodBeginDateTimePicker;
        private System.Windows.Forms.DateTimePicker onMonthDateTimePicker;
        private System.Windows.Forms.RadioButton onPeriodRadioButton;
        private System.Windows.Forms.RadioButton onMonthRadioButton;
        private System.Windows.Forms.Button button47;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label21;
        private _k_systemsDataSet _k_systemsDataSet;
        private System.Windows.Forms.BindingSource заказыСКлиентамиBindingSource;
        private _k_systemsDataSetTableAdapters.Заказы_с_клиентамиTableAdapter заказы_с_клиентамиTableAdapter;
        private System.Windows.Forms.BindingSource отчётностьПоЗаказамBindingSource;
        private _k_systemsDataSetTableAdapters.Отчётность_по_заказамTableAdapter отчётность_по_заказамTableAdapter;
        private System.Windows.Forms.BindingSource Отчётность_по_заказамBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}