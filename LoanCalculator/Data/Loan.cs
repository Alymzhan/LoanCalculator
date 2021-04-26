namespace LoanCalculator.Data
{
    public class Loan
    {
        public int LoanId { get; set; }

        public double Balance { get; set; }
        public int Term { get; set; }

        public double Rate { get; set; }
    }
}
