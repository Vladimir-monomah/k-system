namespace k_systems.Админка
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Почта));
            this.deletedMessagesTabControl = new System.Windows.Forms.TabControl();
            this.WriteLetter = new System.Windows.Forms.TabPage();
            this.userAdresseesComboBox = new System.Windows.Forms.ComboBox();
            this.sendEmailButton = new System.Windows.Forms.Button();
            this.emailMessageTextBox = new System.Windows.Forms.TextBox();
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelWhom = new System.Windows.Forms.Label();
            this.emailSubjectTextBox = new System.Windows.Forms.TextBox();
            this.incomingMessagesTabPanel = new System.Windows.Forms.TabPage();
            this.deleteMessageButton = new System.Windows.Forms.Button();
            this.outcommingMessagesTabPanel = new System.Windows.Forms.TabPage();
            this.deleteOutMessageButton = new System.Windows.Forms.Button();
            this.Basket = new System.Windows.Forms.TabPage();
            this.deletedMessagesTabControl.SuspendLayout();
            this.WriteLetter.SuspendLayout();
            this.incomingMessagesTabPanel.SuspendLayout();
            this.outcommingMessagesTabPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // deletedMessagesTabControl
            // 
            this.deletedMessagesTabControl.Controls.Add(this.WriteLetter);
            this.deletedMessagesTabControl.Controls.Add(this.incomingMessagesTabPanel);
            this.deletedMessagesTabControl.Controls.Add(this.outcommingMessagesTabPanel);
            this.deletedMessagesTabControl.Controls.Add(this.Basket);
            this.deletedMessagesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deletedMessagesTabControl.Location = new System.Drawing.Point(0, 0);
            this.deletedMessagesTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.deletedMessagesTabControl.Name = "deletedMessagesTabControl";
            this.deletedMessagesTabControl.SelectedIndex = 0;
            this.deletedMessagesTabControl.Size = new System.Drawing.Size(879, 799);
            this.deletedMessagesTabControl.TabIndex = 1;
            // 
            // WriteLetter
            // 
            this.WriteLetter.Controls.Add(this.userAdresseesComboBox);
            this.WriteLetter.Controls.Add(this.sendEmailButton);
            this.WriteLetter.Controls.Add(this.emailMessageTextBox);
            this.WriteLetter.Controls.Add(this.labelSubject);
            this.WriteLetter.Controls.Add(this.labelWhom);
            this.WriteLetter.Controls.Add(this.emailSubjectTextBox);
            this.WriteLetter.Location = new System.Drawing.Point(4, 25);
            this.WriteLetter.Margin = new System.Windows.Forms.Padding(4);
            this.WriteLetter.Name = "WriteLetter";
            this.WriteLetter.Size = new System.Drawing.Size(871, 770);
            this.WriteLetter.TabIndex = 4;
            this.WriteLetter.Text = "Написать письмо";
            this.WriteLetter.UseVisualStyleBackColor = true;
            // 
            // userAdresseesComboBox
            // 
            this.userAdresseesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userAdresseesComboBox.DisplayMember = "ФИО";
            this.userAdresseesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userAdresseesComboBox.FormattingEnabled = true;
            this.userAdresseesComboBox.Location = new System.Drawing.Point(9, 20);
            this.userAdresseesComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.userAdresseesComboBox.Name = "userAdresseesComboBox";
            this.userAdresseesComboBox.Size = new System.Drawing.Size(852, 24);
            this.userAdresseesComboBox.TabIndex = 4;
            this.userAdresseesComboBox.ValueMember = "Идентификатор";
            // 
            // sendEmailButton
            // 
            this.sendEmailButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendEmailButton.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendEmailButton.Location = new System.Drawing.Point(347, 704);
            this.sendEmailButton.Margin = new System.Windows.Forms.Padding(4);
            this.sendEmailButton.Name = "sendEmailButton";
            this.sendEmailButton.Size = new System.Drawing.Size(199, 43);
            this.sendEmailButton.TabIndex = 3;
            this.sendEmailButton.Text = "Отправить";
            this.sendEmailButton.UseVisualStyleBackColor = true;
            // 
            // emailMessageTextBox
            // 
            this.emailMessageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailMessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailMessageTextBox.Location = new System.Drawing.Point(4, 113);
            this.emailMessageTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailMessageTextBox.Multiline = true;
            this.emailMessageTextBox.Name = "emailMessageTextBox";
            this.emailMessageTextBox.Size = new System.Drawing.Size(858, 583);
            this.emailMessageTextBox.TabIndex = 2;
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSubject.Location = new System.Drawing.Point(5, 53);
            this.labelSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(49, 17);
            this.labelSubject.TabIndex = 1;
            this.labelSubject.Text = "Тема:";
            // 
            // labelWhom
            // 
            this.labelWhom.AutoSize = true;
            this.labelWhom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWhom.Location = new System.Drawing.Point(5, 0);
            this.labelWhom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWhom.Name = "labelWhom";
            this.labelWhom.Size = new System.Drawing.Size(51, 17);
            this.labelWhom.TabIndex = 1;
            this.labelWhom.Text = "Кому:";
            // 
            // emailSubjectTextBox
            // 
            this.emailSubjectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailSubjectTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailSubjectTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailSubjectTextBox.Location = new System.Drawing.Point(5, 73);
            this.emailSubjectTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailSubjectTextBox.Multiline = true;
            this.emailSubjectTextBox.Name = "emailSubjectTextBox";
            this.emailSubjectTextBox.Size = new System.Drawing.Size(858, 33);
            this.emailSubjectTextBox.TabIndex = 0;
            // 
            // incomingMessagesTabPanel
            // 
            this.incomingMessagesTabPanel.Controls.Add(this.deleteMessageButton);
            this.incomingMessagesTabPanel.Location = new System.Drawing.Point(4, 25);
            this.incomingMessagesTabPanel.Margin = new System.Windows.Forms.Padding(4);
            this.incomingMessagesTabPanel.Name = "incomingMessagesTabPanel";
            this.incomingMessagesTabPanel.Padding = new System.Windows.Forms.Padding(4);
            this.incomingMessagesTabPanel.Size = new System.Drawing.Size(871, 770);
            this.incomingMessagesTabPanel.TabIndex = 0;
            this.incomingMessagesTabPanel.Text = "Входящие";
            this.incomingMessagesTabPanel.UseVisualStyleBackColor = true;
            // 
            // deleteMessageButton
            // 
            this.deleteMessageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteMessageButton.Location = new System.Drawing.Point(687, 50);
            this.deleteMessageButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteMessageButton.Name = "deleteMessageButton";
            this.deleteMessageButton.Size = new System.Drawing.Size(176, 28);
            this.deleteMessageButton.TabIndex = 1;
            this.deleteMessageButton.Text = "Удалить сообщение";
            this.deleteMessageButton.UseVisualStyleBackColor = true;
            // 
            // outcommingMessagesTabPanel
            // 
            this.outcommingMessagesTabPanel.Controls.Add(this.deleteOutMessageButton);
            this.outcommingMessagesTabPanel.Location = new System.Drawing.Point(4, 25);
            this.outcommingMessagesTabPanel.Margin = new System.Windows.Forms.Padding(4);
            this.outcommingMessagesTabPanel.Name = "outcommingMessagesTabPanel";
            this.outcommingMessagesTabPanel.Size = new System.Drawing.Size(871, 770);
            this.outcommingMessagesTabPanel.TabIndex = 2;
            this.outcommingMessagesTabPanel.Text = "Отправленные";
            this.outcommingMessagesTabPanel.UseVisualStyleBackColor = true;
            // 
            // deleteOutMessageButton
            // 
            this.deleteOutMessageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteOutMessageButton.Location = new System.Drawing.Point(687, 50);
            this.deleteOutMessageButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteOutMessageButton.Name = "deleteOutMessageButton";
            this.deleteOutMessageButton.Size = new System.Drawing.Size(176, 28);
            this.deleteOutMessageButton.TabIndex = 2;
            this.deleteOutMessageButton.Text = "Удалить сообщение";
            this.deleteOutMessageButton.UseVisualStyleBackColor = true;
            // 
            // Basket
            // 
            this.Basket.Location = new System.Drawing.Point(4, 25);
            this.Basket.Margin = new System.Windows.Forms.Padding(4);
            this.Basket.Name = "Basket";
            this.Basket.Size = new System.Drawing.Size(871, 770);
            this.Basket.TabIndex = 3;
            this.Basket.Text = "Корзина";
            this.Basket.UseVisualStyleBackColor = true;
            // 
            // Почта
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 799);
            this.Controls.Add(this.deletedMessagesTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Почта";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Почта";
            this.deletedMessagesTabControl.ResumeLayout(false);
            this.WriteLetter.ResumeLayout(false);
            this.WriteLetter.PerformLayout();
            this.incomingMessagesTabPanel.ResumeLayout(false);
            this.outcommingMessagesTabPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl deletedMessagesTabControl;
        private System.Windows.Forms.TabPage WriteLetter;
        private System.Windows.Forms.ComboBox userAdresseesComboBox;
        private System.Windows.Forms.Button sendEmailButton;
        private System.Windows.Forms.TextBox emailMessageTextBox;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelWhom;
        private System.Windows.Forms.TextBox emailSubjectTextBox;
        private System.Windows.Forms.TabPage incomingMessagesTabPanel;
        private System.Windows.Forms.Button deleteMessageButton;
        private System.Windows.Forms.TabPage outcommingMessagesTabPanel;
        private System.Windows.Forms.Button deleteOutMessageButton;
        private System.Windows.Forms.TabPage Basket;
    }
}