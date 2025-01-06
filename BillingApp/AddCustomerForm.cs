using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using BillingApp.Models;
using BillingApp.Services;

namespace BillingApp
{
    public partial class AddCustomerForm : MaterialForm
    {
        private readonly CustomerService _customerService;

        public AddCustomerForm(CustomerService customerService)
        {
            InitializeComponent();

            GUIOperations guiOperations = new GUIOperations();
            guiOperations.AddCustomerPageSkinSetup(this);

            _customerService = customerService;
            LoadSubscribedServices();

        }

        private void LoadSubscribedServices()
        {
            // Load subscribed services from the database
            var services = _customerService.GetServices();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var customer = _customerService.CreateCustomer(
                    txtCustomerName.Text,
                    txtBillingInfo.Text,
                    txtSubscribedServices.Text,
                    txtSubscriptionStartDate.Text,
                    txtSubscriptionEndDate.Text
                );

                MessageBox.Show("Customer added and subscribed to service successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}