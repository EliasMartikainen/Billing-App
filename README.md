# Billing Application

## This billing application is Windows Forms desktop application designed to manage customer information, services and subscription details. The app uses Material Design components to provide a modern and user-friendly interface.
## Username: admin
## Password: password

## Features

### 1. Login system
#### - A login form for user authentication.
#### - Field for username (admin) and password (password).
#### - Displays an error message for incorrect information.

### 2. Main dashboard
#### - Displays a list of customers with details including customer ID, customer name, billing info, subscribed services, subscription start/end dates and paid status.
#### - "Add new customer" button to open the customer addition form.
#### - "Delete customer" button to remove selected customers.

### 3. Add customer form
#### - Form to add customer with the following fields:
##### - Customer organization.
##### - Billing information.
##### - Subscribed service(s).
##### - Subscription start date.
##### - Subscription end date.
#### - "Save" button to add the customer to the database.

## Application flow

### 1. Login process
#### - Open the application.
#### - Enter the username (admin) and password (password).
#### - If the login information are incorrect, an error dialog is shown.

### 2. Main dashboard
#### - After successful login, the main dashboard displays an empty list of customers.
#### - Click "Add new customer" to open the form for adding a new customer.
#### - Click "Delete customer" to remove the selected customer.
#### - Customer details are shown in the DataGridView.

### 3. Add customer process
#### - Fill in the customer information and service subscription details.
#### - Click "Save" to confirm the addition.
#### - A confirmation dialog is shown.

### 4. Deleting a customer
#### - Select a customer from the list.
#### - Click "Delete customer".
#### - A confirmation dialog appears after succesful deletion.

## Technical details

### Framework: .NET Windows Forms.
### UI Components: MaterialSkin library for modern design.
### Database: Entity Framework is assumed for customer data storage.

## Getting started
### 1. Clone or download the project.
### 2.



