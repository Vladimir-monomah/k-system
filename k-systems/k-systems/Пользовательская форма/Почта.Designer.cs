namespace k_systems.Пользовательская_форма
{
    partial class Почта
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Почта));
            this.tabControlEmail = new System.Windows.Forms.TabControl();
            this.WriteLetter = new System.Windows.Forms.TabPage();
            this.emailSendButton = new System.Windows.Forms.Button();
            this.emailMessageTextBox = new System.Windows.Forms.TextBox();
            this.emailSubjectTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailTabPage = new System.Windows.Forms.TabPage();
            this.inputMessageDeleteButton = new System.Windows.Forms.Button();
            this.inputMessagesDataGridView = new System.Windows.Forms.DataGridView();
            this.outputMessagesTabPage = new System.Windows.Forms.TabPage();
            this.outputMessageDeleteButton = new System.Windows.Forms.Button();
            this.outputMessagesDataGridView = new System.Windows.Forms.DataGridView();
            this.Basket = new System.Windows.Forms.TabPage();
            this.deletedMessagesDataGridView = new System.Windows.Forms.DataGridView();
            this._k_systemsDataSet = new k_systems._k_systemsDataSet();
            this.сообщенияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сообщенияTableAdapter = new k_systems._k_systemsDataSetTableAdapters.СообщенияTableAdapter();
            this.темаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.текстСообщенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlEmail.SuspendLayout();
            this.WriteLetter.SuspendLayout();
            this.EmailTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputMessagesDataGridView)).BeginInit();
            this.outputMessagesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputMessagesDataGridView)).BeginInit();
            this.Basket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deletedMessagesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._k_systemsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сообщенияBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlEmail
            // 
            this.tabControlEmail.Controls.Add(this.WriteLetter);
            this.tabControlEmail.Controls.Add(this.EmailTabPage);
            this.tabControlEmail.Controls.Add(this.outputMessagesTabPage);
            this.tabControlEmail.Controls.Add(this.Basket);
            this.tabControlEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlEmail.Location = new System.Drawing.Point(0, 0);
            this.tabControlEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlEmail.Name = "tabControlEmail";
            this.tabControlEmail.SelectedIndex = 0;
            this.tabControlEmail.Size = new System.Drawing.Size(879, 799);
            this.tabControlEmail.TabIndex = 2;
            // 
            // WriteLetter
            // 
            this.WriteLetter.Controls.Add(this.emailSendButton);
            this.WriteLetter.Controls.Add(this.emailMessageTextBox);
            this.WriteLetter.Controls.Add(this.emailSubjectTextBox);
            this.WriteLetter.Controls.Add(this.label2);
            this.WriteLetter.Location = new System.Drawing.Point(4, 25);
            this.WriteLetter.Margin = new System.Windows.Forms.Padding(4);
            this.WriteLetter.Name = "WriteLetter";
            this.WriteLetter.Size = new System.Drawing.Size(871, 770);
            this.WriteLetter.TabIndex = 4;
            this.WriteLetter.Text = "Написать письмо";
            this.WriteLetter.UseVisualStyleBackColor = true;
            // 
            // emailSendButton
            // 
            this.emailSendButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailSendButton.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailSendButton.Location = new System.Drawing.Point(317, 716);
            this.emailSendButton.Margin = new System.Windows.Forms.Padding(4);
            this.emailSendButton.Name = "emailSendButton";
            this.emailSendButton.Size = new System.Drawing.Size(235, 43);
            this.emailSendButton.TabIndex = 3;
            this.emailSendButton.Text = "Отправить";
            this.emailSendButton.UseVisualStyleBackColor = true;
            // 
            // emailMessageTextBox
            // 
            this.emailMessageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailMessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailMessageTextBox.Location = new System.Drawing.Point(5, 69);
            this.emailMessageTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailMessageTextBox.Multiline = true;
            this.emailMessageTextBox.Name = "emailMessageTextBox";
            this.emailMessageTextBox.Size = new System.Drawing.Size(857, 639);
            this.emailMessageTextBox.TabIndex = 2;
            // 
            // emailSubjectTextBox
            // 
            this.emailSubjectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailSubjectTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailSubjectTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailSubjectTextBox.Location = new System.Drawing.Point(5, 28);
            this.emailSubjectTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailSubjectTextBox.Multiline = true;
            this.emailSubjectTextBox.Name = "emailSubjectTextBox";
            this.emailSubjectTextBox.Size = new System.Drawing.Size(857, 33);
            this.emailSubjectTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тема:";
            // 
            // EmailTabPage
            // 
            this.EmailTabPage.Controls.Add(this.inputMessageDeleteButton);
            this.EmailTabPage.Controls.Add(this.inputMessagesDataGridView);
            this.EmailTabPage.Location = new System.Drawing.Point(4, 25);
            this.EmailTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.EmailTabPage.Name = "EmailTabPage";
            this.EmailTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.EmailTabPage.Size = new System.Drawing.Size(871, 770);
            this.EmailTabPage.TabIndex = 0;
            this.EmailTabPage.Text = "Входящие";
            this.EmailTabPage.UseVisualStyleBackColor = true;
            // 
            // inputMessageDeleteButton
            // 
            this.inputMessageDeleteButton.Location = new System.Drawing.Point(631, 28);
            this.inputMessageDeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.inputMessageDeleteButton.Name = "inputMessageDeleteButton";
            this.inputMessageDeleteButton.Size = new System.Drawing.Size(187, 28);
            this.inputMessageDeleteButton.TabIndex = 1;
            this.inputMessageDeleteButton.Text = "Удалить сообщение";
            this.inputMessageDeleteButton.UseVisualStyleBackColor = true;
            // 
            // inputMessagesDataGridView
            // 
            this.inputMessagesDataGridView.AllowUserToAddRows = false;
            this.inputMessagesDataGridView.AllowUserToDeleteRows = false;
            this.inputMessagesDataGridView.AllowUserToOrderColumns = true;
            this.inputMessagesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputMessagesDataGridView.AutoGenerateColumns = false;
            this.inputMessagesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inputMessagesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.inputMessagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inputMessagesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.темаDataGridViewTextBoxColumn,
            this.текстСообщенияDataGridViewTextBoxColumn});
            this.inputMessagesDataGridView.DataSource = this.сообщенияBindingSource;
            this.inputMessagesDataGridView.Location = new System.Drawing.Point(4, 64);
            this.inputMessagesDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.inputMessagesDataGridView.Name = "inputMessagesDataGridView";
            this.inputMessagesDataGridView.ReadOnly = true;
            this.inputMessagesDataGridView.Size = new System.Drawing.Size(860, 695);
            this.inputMessagesDataGridView.TabIndex = 0;
            // 
            // outputMessagesTabPage
            // 
            this.outputMessagesTabPage.Controls.Add(this.outputMessageDeleteButton);
            this.outputMessagesTabPage.Controls.Add(this.outputMessagesDataGridView);
            this.outputMessagesTabPage.Location = new System.Drawing.Point(4, 25);
            this.outputMessagesTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.outputMessagesTabPage.Name = "outputMessagesTabPage";
            this.outputMessagesTabPage.Size = new System.Drawing.Size(871, 770);
            this.outputMessagesTabPage.TabIndex = 2;
            this.outputMessagesTabPage.Text = "Отправленные";
            this.outputMessagesTabPage.UseVisualStyleBackColor = true;
            // 
            // outputMessageDeleteButton
            // 
            this.outputMessageDeleteButton.Location = new System.Drawing.Point(629, 28);
            this.outputMessageDeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.outputMessageDeleteButton.Name = "outputMessageDeleteButton";
            this.outputMessageDeleteButton.Size = new System.Drawing.Size(187, 28);
            this.outputMessageDeleteButton.TabIndex = 1;
            this.outputMessageDeleteButton.Text = "Удалить сообщение";
            this.outputMessageDeleteButton.UseVisualStyleBackColor = true;
            // 
            // outputMessagesDataGridView
            // 
            this.outputMessagesDataGridView.AllowUserToAddRows = false;
            this.outputMessagesDataGridView.AllowUserToDeleteRows = false;
            this.outputMessagesDataGridView.AllowUserToOrderColumns = true;
            this.outputMessagesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputMessagesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.outputMessagesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.outputMessagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputMessagesDataGridView.Location = new System.Drawing.Point(4, 64);
            this.outputMessagesDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.outputMessagesDataGridView.Name = "outputMessagesDataGridView";
            this.outputMessagesDataGridView.ReadOnly = true;
            this.outputMessagesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.outputMessagesDataGridView.Size = new System.Drawing.Size(860, 695);
            this.outputMessagesDataGridView.TabIndex = 0;
            // 
            // Basket
            // 
            this.Basket.Controls.Add(this.deletedMessagesDataGridView);
            this.Basket.Location = new System.Drawing.Point(4, 25);
            this.Basket.Margin = new System.Windows.Forms.Padding(4);
            this.Basket.Name = "Basket";
            this.Basket.Size = new System.Drawing.Size(871, 770);
            this.Basket.TabIndex = 3;
            this.Basket.Text = "Корзина";
            this.Basket.UseVisualStyleBackColor = true;
            // 
            // deletedMessagesDataGridView
            // 
            this.deletedMessagesDataGridView.AllowUserToAddRows = false;
            this.deletedMessagesDataGridView.AllowUserToDeleteRows = false;
            this.deletedMessagesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deletedMessagesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.deletedMessagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deletedMessagesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deletedMessagesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.deletedMessagesDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.deletedMessagesDataGridView.Name = "deletedMessagesDataGridView";
            this.deletedMessagesDataGridView.ReadOnly = true;
            this.deletedMessagesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deletedMessagesDataGridView.Size = new System.Drawing.Size(871, 770);
            this.deletedMessagesDataGridView.TabIndex = 1;
            // 
            // _k_systemsDataSet
            // 
            this._k_systemsDataSet.DataSetName = "_k_systemsDataSet";
            this._k_systemsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сообщенияBindingSource
            // 
            this.сообщенияBindingSource.DataMember = "Сообщения";
            this.сообщенияBindingSource.DataSource = this._k_systemsDataSet;
            // 
            // сообщенияTableAdapter
            // 
            this.сообщенияTableAdapter.ClearBeforeFill = true;
            // 
            // темаDataGridViewTextBoxColumn
            // 
            this.темаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.темаDataGridViewTextBoxColumn.DataPropertyName = "Тема";
            this.темаDataGridViewTextBoxColumn.HeaderText = "Тема";
            this.темаDataGridViewTextBoxColumn.Name = "темаDataGridViewTextBoxColumn";
            this.темаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // текстСообщенияDataGridViewTextBoxColumn
            // 
            this.текстСообщенияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.текстСообщенияDataGridViewTextBoxColumn.DataPropertyName = "Текст сообщения";
            this.текстСообщенияDataGridViewTextBoxColumn.HeaderText = "Текст сообщения";
            this.текстСообщенияDataGridViewTextBoxColumn.Name = "текстСообщенияDataGridViewTextBoxColumn";
            this.текстСообщенияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Почта
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 799);
            this.Controls.Add(this.tabControlEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Почта";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Почта";
            this.Load += new System.EventHandler(this.Почта_Load);
            this.tabControlEmail.ResumeLayout(false);
            this.WriteLetter.ResumeLayout(false);
            this.WriteLetter.PerformLayout();
            this.EmailTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputMessagesDataGridView)).EndInit();
            this.outputMessagesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.outputMessagesDataGridView)).EndInit();
            this.Basket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deletedMessagesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._k_systemsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сообщенияBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlEmail;
        private System.Windows.Forms.TabPage WriteLetter;
        private System.Windows.Forms.Button emailSendButton;
        private System.Windows.Forms.TextBox emailMessageTextBox;
        private System.Windows.Forms.TextBox emailSubjectTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage EmailTabPage;
        private System.Windows.Forms.Button inputMessageDeleteButton;
        private System.Windows.Forms.DataGridView inputMessagesDataGridView;
        private System.Windows.Forms.TabPage outputMessagesTabPage;
        private System.Windows.Forms.Button outputMessageDeleteButton;
        private System.Windows.Forms.DataGridView outputMessagesDataGridView;
        private System.Windows.Forms.TabPage Basket;
        private System.Windows.Forms.DataGridView deletedMessagesDataGridView;
        private _k_systemsDataSet _k_systemsDataSet;
        private System.Windows.Forms.BindingSource сообщенияBindingSource;
        private _k_systemsDataSetTableAdapters.СообщенияTableAdapter сообщенияTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn темаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn текстСообщенияDataGridViewTextBoxColumn;
    }
}