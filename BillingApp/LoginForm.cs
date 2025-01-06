using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BillingApp.Data;
using MaterialSkin.Controls;
using BCrypt.Net;
using BillingApp.Models;
using System.ComponentModel;

namespace BillingApp
{
    [DataContract]
    public partial class LoginForm : MaterialForm
    {
        private readonly AppDbContext _context;

        public LoginForm(AppDbContext context)
        {
            InitializeComponent();
            _context = context;

            GUIOperations guiOperations = new GUIOperations();
            guiOperations.LoginPageSkinSetup(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = userNameInput.Text;
            var password = passwordInput.Text;

            var user = _context.Users.FirstOrDefault(u => u.Username == username);
            if (user != null && BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
