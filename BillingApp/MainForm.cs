using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using BillingApp.Services;
using BillingApp.Models;
using BillingApp.Data;


namespace BillingApp
{
    public partial class MainForm : MaterialForm
    {
        private readonly AppDbContext _context;
        private readonly CustomerService _customerService;

        public MainForm(AppDbContext context, CustomerService customerService)
        {
            InitializeComponent();
            _context = context;
            _customerService = customerService;
            LoadCustomers();

            GUIOperations guiOperations = new GUIOperations();
            guiOperations.materialSkinSetup(this);
        }

        private void LoadCustomers()
        {
            var customers = _context.Customers
                .Select(c => new
                {
                    c.CustomerId,
                    c.CustomerName,
                    c.BillingInfo,
                    c.SubscribedServices,
                    c.SubscriptionStartDate,
                    c.SubscriptionEndDate,
                    c.IsPaid
                })
                .ToList();

            billingDataView.Columns.Clear();
            billingDataView.Items.Clear();

            billingDataView.Columns.Add("Customer ID", 200);
            billingDataView.Columns.Add("Customer Name", 200);
            billingDataView.Columns.Add("Billing Info", 200);
            billingDataView.Columns.Add("Subscribed Services", 200);
            billingDataView.Columns.Add("Subscription Start", 200);
            billingDataView.Columns.Add("Subscription End", 200);
            billingDataView.Columns.Add("Paid Status", 150);

            foreach (var customer in customers)
            {
                var item = new ListViewItem(customer.CustomerId.ToString());
                item.SubItems.Add(customer.CustomerName);
                item.SubItems.Add(customer.BillingInfo);
                item.SubItems.Add(customer.SubscribedServices);
                item.SubItems.Add(customer.SubscriptionStartDate.ToString("d"));
                item.SubItems.Add(customer.SubscriptionEndDate?.ToString("d") ?? "N/A");
                item.SubItems.Add(customer.IsPaid);
                billingDataView.Items.Add(item);
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var addCustomerForm = new AddCustomerForm(_customerService);
            addCustomerForm.ShowDialog();
            LoadCustomers();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (billingDataView.SelectedItems.Count > 0)
            {
                int customerId = int.Parse(billingDataView.SelectedItems[0].Text);
                try
                {
                    _customerService.DeleteCustomer(customerId);
                    MessageBox.Show("Customer deleted successfully.");
                    LoadCustomers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the customer: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.");
            }
        }
    }
}
