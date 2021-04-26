namespace LoanCalculator.Data
{
    public class Cashflow
    {
        public int LoanId { get; set; }
        public int Month { get; set; }
        public double Interest { get; set; }
        public double Principal { get; set; }
        public double RemBalance { get; set; }

    }
}
