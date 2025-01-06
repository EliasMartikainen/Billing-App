namespace BillingApp
{
    partial class AddCustomerForm
    {
        private MaterialSkin.Controls.MaterialTextBox txtCustomerName;
        private MaterialSkin.Controls.MaterialTextBox txtBillingInfo;
        private MaterialSkin.Controls.MaterialButton btnSave;

        private void InitializeComponent()
        {
            txtCustomerName = new MaterialSkin.Controls.MaterialTextBox();
            txtBillingInfo = new MaterialSkin.Controls.MaterialTextBox();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            txtSubscribedServices = new MaterialSkin.Controls.MaterialTextBox();
            txtSubscriptionStartDate = new MaterialSkin.Controls.MaterialTextBox();
            txtSubscriptionEndDate = new MaterialSkin.Controls.MaterialTextBox();
            SuspendLayout();
            // 
            // txtCustomerName
            // 
            txtCustomerName.AnimateReadOnly = false;
            txtCustomerName.BorderStyle = BorderStyle.None;
            txtCustomerName.Depth = 0;
            txtCustomerName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCustomerName.Hint = "Customer Organization";
            txtCustomerName.LeadingIcon = null;
            txtCustomerName.Location = new Point(236, 140);
            txtCustomerName.MaxLength = 50;
            txtCustomerName.MouseState = MaterialSkin.MouseState.OUT;
            txtCustomerName.Multiline = false;
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(260, 50);
            txtCustomerName.TabIndex = 0;
            txtCustomerName.Text = "";
            txtCustomerName.TrailingIcon = null;
            // 
            // txtBillingInfo
            // 
            txtBillingInfo.AnimateReadOnly = false;
            txtBillingInfo.BorderStyle = BorderStyle.None;
            txtBillingInfo.Depth = 0;
            txtBillingInfo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBillingInfo.Hint = "Billing Information";
            txtBillingInfo.LeadingIcon = null;
            txtBillingInfo.Location = new Point(236, 196);
            txtBillingInfo.MaxLength = 50;
            txtBillingInfo.MouseState = MaterialSkin.MouseState.OUT;
            txtBillingInfo.Multiline = false;
            txtBillingInfo.Name = "txtBillingInfo";
            txtBillingInfo.Size = new Size(260, 50);
            txtBillingInfo.TabIndex = 1;
            txtBillingInfo.Text = "";
            txtBillingInfo.TrailingIcon = null;
            // 
            // btnSave
            // 
            btnSave.AutoSize = false;
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(236, 423);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(260, 36);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = true;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtSubscribedServices
            // 
            txtSubscribedServices.AnimateReadOnly = false;
            txtSubscribedServices.BorderStyle = BorderStyle.None;
            txtSubscribedServices.Depth = 0;
            txtSubscribedServices.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSubscribedServices.Hint = "Subscribed service(s)";
            txtSubscribedServices.LeadingIcon = null;
            txtSubscribedServices.Location = new Point(236, 252);
            txtSubscribedServices.MaxLength = 50;
            txtSubscribedServices.MouseState = MaterialSkin.MouseState.OUT;
            txtSubscribedServices.Multiline = false;
            txtSubscribedServices.Name = "txtSubscribedServices";
            txtSubscribedServices.Size = new Size(260, 50);
            txtSubscribedServices.TabIndex = 4;
            txtSubscribedServices.Text = "";
            txtSubscribedServices.TrailingIcon = null;
            // 
            // txtSubscriptionStartDate
            // 
            txtSubscriptionStartDate.AnimateReadOnly = false;
            txtSubscriptionStartDate.BorderStyle = BorderStyle.None;
            txtSubscriptionStartDate.Depth = 0;
            txtSubscriptionStartDate.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSubscriptionStartDate.Hint = "Subscription start date";
            txtSubscriptionStartDate.LeadingIcon = null;
            txtSubscriptionStartDate.Location = new Point(236, 308);
            txtSubscriptionStartDate.MaxLength = 50;
            txtSubscriptionStartDate.MouseState = MaterialSkin.MouseState.OUT;
            txtSubscriptionStartDate.Multiline = false;
            txtSubscriptionStartDate.Name = "txtSubscriptionStartDate";
            txtSubscriptionStartDate.Size = new Size(260, 50);
            txtSubscriptionStartDate.TabIndex = 5;
            txtSubscriptionStartDate.Text = "";
            txtSubscriptionStartDate.TrailingIcon = null;
            // 
            // txtSubscriptionEndDate
            // 
            txtSubscriptionEndDate.AnimateReadOnly = false;
            txtSubscriptionEndDate.BorderStyle = BorderStyle.None;
            txtSubscriptionEndDate.Depth = 0;
            txtSubscriptionEndDate.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSubscriptionEndDate.Hint = "Subscription end date";
            txtSubscriptionEndDate.LeadingIcon = null;
            txtSubscriptionEndDate.Location = new Point(236, 364);
            txtSubscriptionEndDate.MaxLength = 50;
            txtSubscriptionEndDate.MouseState = MaterialSkin.MouseState.OUT;
            txtSubscriptionEndDate.Multiline = false;
            txtSubscriptionEndDate.Name = "txtSubscriptionEndDate";
            txtSubscriptionEndDate.Size = new Size(260, 50);
            txtSubscriptionEndDate.TabIndex = 6;
            txtSubscriptionEndDate.Text = "";
            txtSubscriptionEndDate.TrailingIcon = null;
            // 
            // AddCustomerForm
            // 
            ClientSize = new Size(717, 568);
            Controls.Add(txtSubscriptionEndDate);
            Controls.Add(txtSubscriptionStartDate);
            Controls.Add(txtSubscribedServices);
            Controls.Add(btnSave);
            Controls.Add(txtBillingInfo);
            Controls.Add(txtCustomerName);
            Name = "AddCustomerForm";
            Text = "Add Customer";
            ResumeLayout(false);
        }

        private MaterialSkin.Controls.MaterialTextBox txtSubscribedServices;
        private MaterialSkin.Controls.MaterialTextBox txtSubscriptionStartDate;
        private MaterialSkin.Controls.MaterialTextBox txtSubscriptionEndDate;
    }
}