# TechnicalityTest

This is a very basic simulation of a web application that uses calls a 3rd party credit card processing API. Both the web application (TechnicalityTestWebApp) and the API (TechnicalityTestAPI) are included in one solution in this Git repo. It is intended to be used as a quick evaluation of software developer candidates. For a qualified candidate, this should only take 15-20 minutes to complete.

Both the WebApp project and the API project contain an EF Core migration. You will need to run a database update in each project to create the two databases.

The WebApp data model consists of two tables - Customers and Payments. There is a simple user interface to allow the end user to create Customers and then Payments for a particular Customer. (There is a link to Payments on the Customer Details view.)

When a Payment is created in the WebApp, the WebApp calls the API (simulating a credit card charge) and the API creates a record in the CreditCardCharges table in the API database.

**Assignment Details**

Fork this repo and create a branch named dev in the new repo. Make the following changes in the dev branch. You should commit each item separately with meaningful commit message. (Doesn't need to be long, just identifying what was done.)
1. When the WebApp POSTs to the API (to create a credit card charge), the API returns a ChargeId (integer value). The WebApp database has a field in the Payments table to store this (CreditCardChargeId) but it isn't being updated after the POST call. Add code to save the returned ChargeId in the Payments table.
2. There is a Service class and a Repository class in the API project, but the Controller class isn't using them. Change the Controller class so that it uses the Service and Repository class instead of directly accessing the EF Core DbContext class.
3. Add another endpoint to the API controller to update an existing charge. (It will be similar to the POST and should use standard REST conventions). It should allow the amount to be updated and update the DateTime field to be the current system time (in UTC).
4. Change the WebApp Edit to call the new endpoint created in #3 when a payment is updated (if the payment has a value in the nullable CreditCardChargeId field).

