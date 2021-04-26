# LoanCalculator

Task done by Alymzhan Kurbanov
04/26/2021

## Interview Test
### Assignment
Write a fixed rate loan cash flow generator as a Visual C# Windows Forms, Visual C++ MFC, or Visual C# ASP.NET application as
instructed by your interviewer.

### Input parameters
The user should have the ability to input any number of loans for calculation. Each loan is defined by three parameters:
The amount of money loaned in dollars (balance)
The time over which the loan will be repaid, in months (term)
The percentage rate at which interest will accrue on the loan (rate)
Each loan can have a different term, rate and balance.

### Output
For the n loans inputted, the user should be able to click a button which will present them with n + 1 cash flows: one cash flow for
each loan plus one cash flow for the aggregate pool of loans.
A cashflow is a record of monthly payments spanning the entire term of a loan (or pool) broken down into the monetary allocation
of interest and principal as well as a record of the remaining balance of said loan (or pool) for that month.

Monthly payments have these details:
The month (1 corresponding to the 1st month of payment, through the total number of months)
The interest paid this month 
The principal paid this month 
The remaining loan balance at the end of the month 