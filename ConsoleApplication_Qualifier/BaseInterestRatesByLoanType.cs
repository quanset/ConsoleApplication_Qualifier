/// <summary>
/// Base Interest rates, depending on the loan type.
/// The base interest rate is later modified based on credit score and down payment.
/// </summary>
public class BaseInterestRatesByLoanType
{
    public BaseInterestRatesByLoanType()
    {
        // TODO: Add constructor logic here
    }
    // Loan Type indexes:
    public const int FHA30_index = 0;
    public const int FHA25_index = 1;
    public const int FHA20_index = 2;
    public const int FHA15_index = 3;
    public const int FHA10_index = 4;
    public const int VA30_index = 5;
    public const int VA25_index = 6;
    public const int VA20_index = 7;
    public const int VA15_index = 8;
    public const int VA10_index = 9;
    public const int USDA30_index = 10;
    public const int CONV30_index = 11;
    public const int CONV25_index = 12;
    public const int CONV20_index = 13;
    public const int CONV15_index = 14;
    public const int CONV10_index = 15;

    // This data changes often, so it was just easier to set it up as an array to make updates easy. 
    private static double[] InterestRatesByLoanType = new double[16] { 3.38, 3.38, 3.38, 2.88, 2.88, 3.50, 3.50, 3.38, 3.00, 3.00, 4.00, 4.00, 4.00, 3.75, 3.25, 3.25 };


    /// <summary>
    /// Base Interest rates, depending on the loan type.
    /// The base interest rate is modified based on credit score and down payment.
    /// </summary>
    public double FHA30 = InterestRatesByLoanType[FHA30_index];
    public double FHA25 = InterestRatesByLoanType[FHA25_index];
    public double FHA20 = InterestRatesByLoanType[FHA20_index];
    public double FHA15 = InterestRatesByLoanType[FHA15_index];
    public double FHA10 = InterestRatesByLoanType[FHA10_index];

    public double VA30 = InterestRatesByLoanType[VA30_index];
    public double VA25 = InterestRatesByLoanType[VA25_index];
    public double VA20 = InterestRatesByLoanType[VA20_index];
    public double VA15 = InterestRatesByLoanType[VA15_index];
    public double VA10 = InterestRatesByLoanType[VA10_index];
    
    public double USDA30 = InterestRatesByLoanType[USDA30_index];
    
    public double CONV30 = InterestRatesByLoanType[CONV30_index];
    public double CONV25 = InterestRatesByLoanType[CONV25_index];
    public double CONV20 = InterestRatesByLoanType[CONV20_index];
    public double CONV15 = InterestRatesByLoanType[CONV15_index];
    public double CONV10 = InterestRatesByLoanType[CONV10_index];

}
