
/// <summary>
/// Use this to keep track of the results from "find the best loan".
/// </summary>


public class LoanCalculationResults
{
    public LoanCalculationResults()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    /// <summary>
    /// 
    /// </summary>
    public int RecommendedLoanAmount_Base{ get; set; }

    /// <summary>
    /// 
    /// </summary>
    public decimal RecommendedPayment_PrincipleAndInterest{ get; set; }

    /// <summary>
    /// Requested 17-July-2015: Want to display not just the loan amount, but the total house price you qualified for.
    /// Essentially, adding the down payment onto the loan amount to show how much house you can look for.
    /// </summary>
    public int RecommendedHouseAmount_Base { get; set; }
}
