using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GMTool
{
    public partial class LoginForm : Form
    {
        public string m_UserName;

        public string m_Password;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            m_UserName = UserNameBox.Text;
            m_Password = PasswordBox.Text;
        }
    }
}
