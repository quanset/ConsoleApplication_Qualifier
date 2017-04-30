/// <summary>
/// Once the loan amount is calculated, they want to indicate the "total house price you can qualify for".
/// This is a number to divide into the loan amount to get the house price you can shop for.
/// </summary>
/// 
public class SalesPriceCalculationData
{
    public SalesPriceCalculationData()
    {
    }

    public const double CSTL = -9999;  // CREDIT SCORE TOO LOW

    //4.99 or Less	  5.00-9.99%	  10.00-14.99%	  15.00-19.99%	  20.00-24.99%	  25.00-29.99%	  30.00-34.99%	  35.00-39.99%	  40.00% or More
    public static double[] SalesPriceCalculation = new double[9] { 0.97, 0.95, 0.90, 0.85, 0.80, 0.75, 0.70, 0.65, 0.60 };
}
