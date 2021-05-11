namespace k_systems.РегАвт
{
    partial class Регистрация
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Регистрация));
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPatronomic = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSername = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPatronomic = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmail.Location = new System.Drawing.Point(149, 216);
            this.textBoxEmail.MaxLength = 30;
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(267, 39);
            this.textBoxEmail.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 39);
            this.label1.TabIndex = 35;
            this.label1.Text = "E-mail";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(149, 306);
            this.textBoxPassword.MaxLength = 20;
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(267, 39);
            this.textBoxPassword.TabIndex = 7;
            this.textBoxPassword.Tag = "";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(149, 261);
            this.textBoxLogin.MaxLength = 15;
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(267, 39);
            this.textBoxLogin.TabIndex = 6;
            // 
            // textBoxPatronomic
            // 
            this.textBoxPatronomic.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPatronomic.Location = new System.Drawing.Point(149, 125);
            this.textBoxPatronomic.MaxLength = 30;
            this.textBoxPatronomic.Multiline = true;
            this.textBoxPatronomic.Name = "textBoxPatronomic";
            this.textBoxPatronomic.Size = new System.Drawing.Size(267, 39);
            this.textBoxPatronomic.TabIndex = 3;
            this.textBoxPatronomic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPatronomic_KeyPress);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(149, 80);
            this.textBoxName.MaxLength = 30;
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(267, 39);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPatronomic_KeyPress);
            // 
            // textBoxSername
            // 
            this.textBoxSername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSername.Location = new System.Drawing.Point(149, 31);
            this.textBoxSername.MaxLength = 30;
            this.textBoxSername.Multiline = true;
            this.textBoxSername.Name = "textBoxSername";
            this.textBoxSername.Size = new System.Drawing.Size(267, 39);
            this.textBoxSername.TabIndex = 1;
            this.textBoxSername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPatronomic_KeyPress);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.Location = new System.Drawing.Point(16, 364);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(400, 72);
            this.buttonRegister.TabIndex = 29;
            this.buttonRegister.Text = "Зарегистрироваться";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(12, 306);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(100, 39);
            this.labelPassword.TabIndex = 28;
            this.labelPassword.Text = "Пароль";
            // 
            // labelLogin
            // 
            this.labelLogin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(12, 264);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(100, 39);
            this.labelLogin.TabIndex = 27;
            this.labelLogin.Text = "Логин";
            // 
            // labelPatronomic
            // 
            this.labelPatronomic.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPatronomic.Location = new System.Drawing.Point(12, 121);
            this.labelPatronomic.Name = "labelPatronomic";
            this.labelPatronomic.Size = new System.Drawing.Size(113, 39);
            this.labelPatronomic.TabIndex = 26;
            this.labelPatronomic.Text = "Отчество";
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(12, 76);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(100, 39);
            this.labelName.TabIndex = 25;
            this.labelName.Text = "Имя";
            // 
            // labelSername
            // 
            this.labelSername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSername.Location = new System.Drawing.Point(12, 31);
            this.labelSername.Name = "labelSername";
            this.labelSername.Size = new System.Drawing.Size(100, 39);
            this.labelSername.TabIndex = 24;
            this.labelSername.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 39);
            this.label2.TabIndex = 37;
            this.label2.Text = "Телефон";
            // 
            // Phone
            // 
            this.Phone.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Phone.Location = new System.Drawing.Point(149, 175);
            this.Phone.Mask = "+7(***) ***-****";
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(267, 32);
            this.Phone.TabIndex = 4;
            // 
            // Регистрация
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 453);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxPatronomic);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSername);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelPatronomic);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Регистрация";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Регистрация_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPatronomic;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSername;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPatronomic;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox Phone;
    }
}