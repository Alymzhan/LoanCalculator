using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using LoanCalculator.Data;

namespace LoanCalculator
{
    public partial class MainForm : Form
    {
        public BindingList<Loan> Loans = new();
        public BindingList<Cashflow> Results = new();
        public BindingList<Cashflow> PoolLevel = new();
        int LoanNum = 1;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddLoan_Click(object sender, EventArgs e)
        {
            //Sequence of Loans
            var loanId = Loans.Count + 1;

            Loans.Add(new Loan()
            {
                LoanId = loanId,
                Balance = (double)numBalance.Value,
                Term = (int)numTerm.Value,
                Rate = (double)numRate.Value
            });
            //Refreshing Loans GridView
            gridLoans.DataSource = typeof(BindingList<Loan>);
            gridLoans.DataSource = Loans;
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var loans = this.Loans;
            var results = this.Results;
            gridLoans.DataSource = loans;
            gridResults.DataSource = results;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Results.Clear();
            PoolLevel.Clear();
            //Checking if there is any row in Loans List
            if (Loans.Count > 0)
            {
                foreach (var Item in Loans)
                {
                    var remainBalance = Item.Balance;
                    for (int i = 1; i <= Item.Term; i++)
                    {
                        //Let's calculate everything
                        var totalMonthlyPayment = (Item.Balance * (Item.Rate / 1200)) / (1 - Math.Pow((1 + (Item.Rate / 1200)), -Item.Term));
                        var interest = remainBalance * (Item.Rate / 1200);
                        var principal = totalMonthlyPayment - interest;
                        remainBalance = remainBalance - principal;
                        
                        //Saving results to Cashflow List
                        Results.Add(new Cashflow()
                        {
                            LoanId = Item.LoanId,
                            Month = i,
                            Interest = Math.Round(interest, 2),
                            Principal = Math.Round(principal, 2),
                            RemBalance = Math.Round(remainBalance, 2)
                        });

                        var obj = PoolLevel.FirstOrDefault(x => x.Month == i);
                        if (obj != null)
                        {
                            obj.Interest += interest;
                            obj.Principal += principal;
                            obj.RemBalance += remainBalance;
                        }                            
                        else
                            PoolLevel.Add(new Cashflow()
                            {
                                LoanId = 0,
                                Month = i,
                                Interest = interest,
                                Principal = principal,
                                RemBalance = remainBalance
                            });
                    }                    
                }

                //Lets round all values for PoolLevel List
                foreach (var Item in PoolLevel)
                {
                    Item.Interest = Math.Round(Item.Interest, 2);
                    Item.Principal = Math.Round(Item.Principal, 2);
                    Item.RemBalance = Math.Round(Item.RemBalance, 2);
                }

                //Refreshing Results GridView
                LoanNum = 1;
                var result = new BindingList<Cashflow>(Results.Where(x => x.LoanId == LoanNum).ToList());
                gridResultUpdate(result);

            }
            else 
            {
                MessageBox.Show("Loans list is empty! Add at least one Loan!", 
                    "Calculate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Loans.Count>LoanNum)
            {
                LoanNum++;
                lbLoanName.Text = "Loan " + LoanNum;
                var result = new BindingList<Cashflow>(Results.Where(x => x.LoanId == LoanNum).ToList());
                gridResultUpdate(result);
            }            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (LoanNum > 1)
            {
                LoanNum--;
                lbLoanName.Text = "Loan " + LoanNum;
                var result = new BindingList<Cashflow>(Results.Where(x => x.LoanId == LoanNum).ToList());
                gridResultUpdate(result);
            }
        }

        private void btnPoolLevel_Click(object sender, EventArgs e)
        {
            lbLoanName.Text = "Pool Level";
            gridResultUpdate(PoolLevel);
        }

        private void gridResultUpdate(BindingList<Cashflow> dataSource)
        {
            gridResults.DataSource = typeof(BindingList<Cashflow>);
            gridResults.DataSource = dataSource;
            gridResults.Columns["LoanId"].Visible = false;
            gridResults.Columns["Month"].Width = 90;
        }
    }
}
