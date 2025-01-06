namespace BillingApp
{
    partial class MainForm
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
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            deleteCustomerButton = new MaterialSkin.Controls.MaterialButton();
            billingDataView = new MaterialSkin.Controls.MaterialListView();
            SuspendLayout();
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(1375, 87);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(158, 36);
            materialButton1.TabIndex = 1;
            materialButton1.Text = "Add new customer";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = true;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += btnAddCustomer_Click;
            // 
            // deleteCustomerButton
            // 
            deleteCustomerButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            deleteCustomerButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            deleteCustomerButton.Depth = 0;
            deleteCustomerButton.HighEmphasis = true;
            deleteCustomerButton.Icon = null;
            deleteCustomerButton.Location = new Point(1375, 135);
            deleteCustomerButton.Margin = new Padding(4, 6, 4, 6);
            deleteCustomerButton.MouseState = MaterialSkin.MouseState.HOVER;
            deleteCustomerButton.Name = "deleteCustomerButton";
            deleteCustomerButton.NoAccentTextColor = Color.Empty;
            deleteCustomerButton.Size = new Size(158, 36);
            deleteCustomerButton.TabIndex = 2;
            deleteCustomerButton.Text = "Delete  customer";
            deleteCustomerButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            deleteCustomerButton.UseAccentColor = true;
            deleteCustomerButton.UseVisualStyleBackColor = true;
            deleteCustomerButton.Click += btnDeleteCustomer_Click;
            // 
            // billingDataView
            // 
            billingDataView.AutoSizeTable = false;
            billingDataView.BackColor = Color.FromArgb(255, 255, 255);
            billingDataView.BorderStyle = BorderStyle.None;
            billingDataView.Depth = 0;
            billingDataView.FullRowSelect = true;
            billingDataView.Location = new Point(16, 87);
            billingDataView.MinimumSize = new Size(200, 100);
            billingDataView.MouseLocation = new Point(-1, -1);
            billingDataView.MouseState = MaterialSkin.MouseState.OUT;
            billingDataView.Name = "billingDataView";
            billingDataView.OwnerDraw = true;
            billingDataView.Size = new Size(1340, 486);
            billingDataView.TabIndex = 3;
            billingDataView.UseCompatibleStateImageBehavior = false;
            billingDataView.View = View.Details;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1550, 617);
            Controls.Add(billingDataView);
            Controls.Add(deleteCustomerButton);
            Controls.Add(materialButton1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Padding = new Padding(4, 74, 4, 3);
            Text = "Billing App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton deleteCustomerButton;
        private MaterialSkin.Controls.MaterialListView billingDataView;
    }
}

