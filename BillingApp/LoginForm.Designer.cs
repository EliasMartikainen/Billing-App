namespace BillingApp
{
    partial class LoginForm
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
            userNameInput = new MaterialSkin.Controls.MaterialTextBox2();
            passwordInput = new MaterialSkin.Controls.MaterialTextBox2();
            loginButton = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // userNameInput
            // 
            userNameInput.AnimateReadOnly = false;
            userNameInput.BackgroundImageLayout = ImageLayout.None;
            userNameInput.CharacterCasing = CharacterCasing.Normal;
            userNameInput.Depth = 0;
            userNameInput.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            userNameInput.HideSelection = true;
            userNameInput.Hint = "Username";
            userNameInput.LeadingIcon = null;
            userNameInput.Location = new Point(240, 193);
            userNameInput.Margin = new Padding(4, 3, 4, 3);
            userNameInput.MaxLength = 32767;
            userNameInput.MouseState = MaterialSkin.MouseState.OUT;
            userNameInput.Name = "userNameInput";
            userNameInput.PasswordChar = '\0';
            userNameInput.PrefixSuffixText = null;
            userNameInput.ReadOnly = false;
            userNameInput.RightToLeft = RightToLeft.No;
            userNameInput.SelectedText = "";
            userNameInput.SelectionLength = 0;
            userNameInput.SelectionStart = 0;
            userNameInput.ShortcutsEnabled = true;
            userNameInput.Size = new Size(195, 48);
            userNameInput.TabIndex = 1;
            userNameInput.TabStop = false;
            userNameInput.TextAlign = HorizontalAlignment.Left;
            userNameInput.TrailingIcon = null;
            userNameInput.UseSystemPasswordChar = false;
            // 
            // passwordInput
            // 
            passwordInput.AnimateReadOnly = false;
            passwordInput.BackgroundImageLayout = ImageLayout.None;
            passwordInput.CharacterCasing = CharacterCasing.Normal;
            passwordInput.Depth = 0;
            passwordInput.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            passwordInput.HideSelection = true;
            passwordInput.Hint = "Password";
            passwordInput.LeadingIcon = null;
            passwordInput.Location = new Point(240, 256);
            passwordInput.Margin = new Padding(4, 3, 4, 3);
            passwordInput.MaxLength = 32767;
            passwordInput.MouseState = MaterialSkin.MouseState.OUT;
            passwordInput.Name = "passwordInput";
            passwordInput.PasswordChar = '●';
            passwordInput.PrefixSuffixText = null;
            passwordInput.ReadOnly = false;
            passwordInput.RightToLeft = RightToLeft.No;
            passwordInput.SelectedText = "";
            passwordInput.SelectionLength = 0;
            passwordInput.SelectionStart = 0;
            passwordInput.ShortcutsEnabled = true;
            passwordInput.Size = new Size(195, 48);
            passwordInput.TabIndex = 3;
            passwordInput.TabStop = false;
            passwordInput.TextAlign = HorizontalAlignment.Left;
            passwordInput.TrailingIcon = null;
            passwordInput.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            loginButton.AutoSize = false;
            loginButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            loginButton.Depth = 0;
            loginButton.HighEmphasis = true;
            loginButton.Icon = null;
            loginButton.Location = new Point(240, 314);
            loginButton.Margin = new Padding(5, 7, 5, 7);
            loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            loginButton.Name = "loginButton";
            loginButton.NoAccentTextColor = Color.Empty;
            loginButton.Size = new Size(195, 36);
            loginButton.TabIndex = 4;
            loginButton.Text = "Login";
            loginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            loginButton.UseAccentColor = true;
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 519);
            Controls.Add(loginButton);
            Controls.Add(passwordInput);
            Controls.Add(userNameInput);
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoginForm";
            Padding = new Padding(4, 74, 4, 3);
            Text = "Login";
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox2 userNameInput;
        private MaterialSkin.Controls.MaterialTextBox2 passwordInput;
        private MaterialSkin.Controls.MaterialButton loginButton;
    }
}