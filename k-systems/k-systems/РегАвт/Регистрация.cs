using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace k_systems.РегАвт
{
    public partial class Регистрация : Form
    {
        private string password;

        public Регистрация(string password)
        {
            this.password = password;
            this.InitializeComponent();
        }

        /// <summary>
        /// Метод шифрования пароля
        /// </summary>
        /// <param name="plainText"></param>
        /// <param name="password"></param>
        /// <param name="salt"></param>
        /// <param name="hashAlgorithm"></param>
        /// <param name="passwordInterations"></param>
        /// <param name="initialVector"></param>
        /// <param name="keySize"></param>
        /// <returns></returns>
        public static string Encrypt(string plainText, string password, string salt = "Kosher", string hashAlgorithm = "SHA1",
            int passwordInterations = 2, string initialVector = "PFRna73*aze01xY1", int keySize = 256)
        {
            if (string.IsNullOrEmpty(plainText))
                return "";

            byte[] initialVectorBytes = Encoding.ASCII.GetBytes(initialVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(salt);
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            var derivedPassword = new PasswordDeriveBytes(password, saltValueBytes, hashAlgorithm, passwordInterations);
            byte[] keyBytes = derivedPassword.GetBytes(keySize / 8);
            var symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;

            byte[] cipherTextBytes = null;

            using (ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initialVectorBytes))
            {
                using (var memStream = new MemoryStream())
                {
                    using (var cryptoStream = new CryptoStream(memStream, encryptor, CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                        cryptoStream.FlushFinalBlock();
                        cipherTextBytes = memStream.ToArray();
                        memStream.Close();
                        cryptoStream.Close();
                    }
                }
            }
            symmetricKey.Clear();
            return Convert.ToBase64String(cipherTextBytes);
        }

        /// <summary>
        /// Проверка заполненности полей
        /// </summary>
        /// <returns></returns>
        private bool CheckTextBoxes()
        {
            if (this.textBoxSername.Text == "" || this.textBoxName.Text == "" ||
                this.textBoxPatronomic.Text == "" || this.Phone.Text == ""||this.textBoxEmail.Text == "" ||
                this.textBoxLogin.Text == "" || this.textBoxPassword.Text == "")
            {
                return false;
            }
            return true;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (!this.CheckTextBoxes())
            {
                MessageBox.Show("Заполните все поля","Информация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newUser = EntityManager.UserDataTable.NewПользователиRow();
            newUser.Фамилия = this.textBoxSername.Text;
            newUser.Имя = this.textBoxName.Text;
            newUser.Отчество = this.textBoxPatronomic.Text;
            newUser._E_mail = this.textBoxEmail.Text;
            newUser.Телефон = this.Phone.Text;
            newUser.логин = this.textBoxLogin.Text;
            newUser.пароль = Encrypt(this.textBoxPassword.Text, this.password);
            EntityManager.UserDataTable.AddПользователиRow(newUser);
            EntityManager.UpdateUsers();

            MessageBox.Show("Регистрация успешна","Информация",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }

        private void textBoxPatronomic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = !(char.IsDigit(c) || c == '.' || c == ',' || c == '\b');
        }

        private void Регистрация_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult dialogResult = MessageBox.Show("Вы действиетльно хотите выйти?",
                    "Закрытие программы", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else e.Cancel = true;
            }
            else Application.Exit();
        }
    }
}
