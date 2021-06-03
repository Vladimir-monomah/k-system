using k_systems.РегАвт;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k_systems.Админка
{
    public partial class Клиенты : Form
    {
        private string password;

        public Клиенты(string password)
        {
            this.password = password;
            InitializeComponent();
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
                this.textBoxPatronomic.Text == "" || this.textBoxEmail.Text == "" ||
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
                MessageBox.Show("Заполните все поля", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var isEmailValid = ValidEmail.IsValidEmail(this.textBoxEmail.Text);
            if (!isEmailValid)
            {
                MessageBox.Show("Введите корректный Email!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var newUser = EntityManager.ClientDataTable.NewКлиентRow();
            newUser.Фамилия = this.textBoxSername.Text;
            newUser.Имя = this.textBoxName.Text;
            newUser.Отчество = this.textBoxPatronomic.Text;
            newUser._E_mail = this.textBoxEmail.Text;
            newUser.логин = this.textBoxLogin.Text;
            newUser.пароль = Encrypt(this.textBoxPassword.Text, this.password);
            EntityManager.ClientDataTable.AddКлиентRow(newUser);
            EntityManager.UpdateClient();
            this.клиентTableAdapter.Fill(this._k_systemsDataSet.Клиент);

            MessageBox.Show("Добавление клиента прошло успешно!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxSername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void Клиенты_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_k_systemsDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this._k_systemsDataSet.Клиент);

        }
    }
}
