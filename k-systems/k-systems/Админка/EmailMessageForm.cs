using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k_systems.Админка
{
    public partial class EmailMessageForm : Form
    {
        public EmailMessageForm()
        {
            InitializeComponent();
        }

        public EmailMessageForm(string subjectMessage, string textMessage)
            : this()
        {
            this.emailMessageTextBox.Text = textMessage;
            this.emailSubjectTextBox.Text = subjectMessage;
        }
    }
}
