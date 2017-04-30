using System;

/// <summary>
/// Class to give details that are specific to the lender type (Ex: FHA30, FHA15, VA15, VA30, etc)
/// </summary>


public class LoanProviderInfo : LoanCommonInfo
{
    /// <summary>
    /// Constructor for the lender type.  Initialize with description, term (years) and base interest rate.
    /// ex: "FHA 30-year Loan", 30, 3.63
    /// </summary>
    public LoanProviderInfo(string loanDescription, int loanTerm_Years, double loanBaseInterestRate)
    {
        LoanType = loanDescription;
        LoanTermYears = loanTerm_Years;
        InterestRate_Annual_Base = loanBaseInterestRate;
//        DebtRatioTable_House = debtRatioTable_House;
//        DebtRatioTable_Total = debtRatioTable_Total;

    }
    public const double CSTL = -9999;  // CREDIT SCORE TOO LOW


    protected static int LoanStartingAmount = 50000;  // This is the initial value to use when iterating through multiple scenarios.
    protected static int LoanIncrementalAmount = 2500;  // This is the value to use when iterating through multiple scenarios - each iteration, the loan amount increases by this much.

    // Column and row indexes for lookup tables
    protected static int[] MortgageInsuranceColumnIndexByCreditScore = new int[] { 760, 740, 720, 700, 680, 660, 640, 620, 600, 580, 0 }; //760 and higher	740-759	720-739	700-719	680-699	660-679	640-659	620-639	600-619	580-599	579 and Lower
    protected static double[] MortgageInsuranceRowIndexByDownPayment = new double[] { 4.99, 9.99, 14.99, 19.99, 24.99, 29.99, 34.99, 39.99, 100 }; //4.99% or less 5.00-9.99% 10.00-14.99% 15.00-19.99% 20.00-24.99% 25.00-29.99% 30.00-34.99% 35.00-39.99% 40.00% or More





    /// <summary>
    /// The term of the loan in months. This is the number of months
    /// that payments will be made.
    /// </summary>
    public String LoanType { get; set; }

    /// <summary>
    /// The term of the loan in months. This is the number of months
    /// that payments will be made.
    /// </summary>
    public double LoanTermMonths { get; set; }

    /// <summary>
    /// The term of the loan in years. This is the number of years
    /// that payments will be made.
    /// </summary>
    public double LoanTermYears
    {
        get { return LoanTermMonths / MonthsPerYear; }
        set { LoanTermMonths = (value * MonthsPerYear); }
    }

    /// <summary>
    /// The maximum payment allowed depends on the loan type.
    /// Calculated using table data.
    /// </summary>
    public int Payment_Maximum { get; set; }

    /// <summary>
    /// This is the amount of the loan without upfront mortgage insurance.
    /// Note that this is BEFORE any upfront mortgage insurance is applied, since the upfront mortgage insurance is provider specific.
    /// </summary>
    public decimal LoanAmount_Base { get; set; }

    /// <summary>
    /// Loan amount + UpfrontMortgageInsurancePayment.
    /// </summary>
    public decimal LoanAmount_Actual { get; set; }

    /// <summary>
    /// Loan amount/down payment modifier.
    /// </summary>
    public decimal HouseAmount_Actual { get; set; }

    /// <summary>
    /// Qualifier program will look up this rate based on down payment percentage and credit score.
    /// </summary>
    public double UpfrontMortgageInsuranceRate { get; set; }

    /// <summary>
    /// Payment that is calculated based on the UpfrontMortgageInsuranceRate.
    /// Uses the base loan amount, only.
    /// </summary>
    public decimal UpfrontMortgageInsurancePayment { get; set; }

    /// <summary>
    /// Qualifier program will look up this rate based on down payment percentage and credit score.
    /// </summary>
    public double MonthlyMortgageInsuranceRate { get; set; }

    /// <summary>
    /// (Base Loan + Upfront Mortgage Insurance Rate) * Monthly MI Rate.
    /// </summary>
    public decimal MonthlyMortgageInsurancePayment { get; set; }

    /// <summary>
    /// Qualifier program will look up this rate based on down payment percentage and credit score.
    /// </summary>
    public double MonthlyPropertyTaxRate { get; set; }

    /// <summary>
    /// (Base Loan + Upfront Mortgage Insurance Rate) * Monthly MI Rate.
    /// </summary>
    public decimal MonthlyPropertyTaxPayment { get; set; }

    /// <summary>
    /// The "base" annual interest rate - The base is configured by admin.
    /// Add the offset to this for total interest rate.
    /// </summary>
    public double InterestRate_Annual_Base { get; set; }

//    /// <summary>
//    /// Table of offsets for determining maximum debt percentage, as a percentage of income, based on down payment percentage and credit score, that you are allowed for the house payment.
//    /// </summary>
//    public double [,] DebtRatioTable_House { get; set; }
//    /// <summary>
//    /// Table of offsets for determining maximum debt percentage, as a percentage of income, based on down payment percentage and credit score, that you are allowed for all debt, including house payment.
//    /// </summary>
//    public double [,] DebtRatioTable_Total { get; set; }

    /// <summary>
    /// The annual interest rate "offset" - depends on credits score and down payment.
    /// Add this offset to the base for total interest rater.
    /// </summary>
    public double InterestRate_Annual_Offset { get; set; }

    /// <summary>
    /// The annual interest rate "offset" - depends on credits score and down payment.
    /// Add this offset to the base for total interest rater.
    /// </summary>
    public double InterestRate_Annual_Total {
        get { return InterestRate_Annual_Base + InterestRate_Annual_Offset; }
    }

    /// <summary>
    /// P&I payment for loan. To get the total payment, take this then add UpfrontMortgageInsurancePayment and MonthlyMortgageInsurancePayment.
    /// </summary>
    public decimal PrincipleAndInterestPayment { get; set; }

    /// <summary>
    /// P&I payment + UpfrontMortgageInsurancePayment + MonthlyMortgageInsurancePayment = total payment.
    /// </summary>
    public decimal TotalLoanPayment { get; set; }

    /// <summary>
    /// column index into the Mortgage Insurance lookup tables.
    /// </summary>
    public int MortgageInsuranceColumnIndex { get; set; }

    /// <summary>
    /// Row index into the Mortgage Insurance lookup tables.
    /// </summary>
    public int MortgageInsuranceRowIndex { get; set; }

    private void setupLookupTableIndices(int creditScore, decimal downPaymentPercentage)
    {
        MortgageInsuranceColumnIndex = getColumnForTableLookups(creditScore);
        MortgageInsuranceRowIndex = getRowForTableLookups(downPaymentPercentage);
    }

    public double Lookup_InterestRateOffset(int creditScore, decimal downPaymentPercentage, double[,] interestRateOffsetArray)
    {
        setupLookupTableIndices(creditScore, downPaymentPercentage);
        return interestRateOffsetArray[MortgageInsuranceColumnIndex, MortgageInsuranceRowIndex];
    }

    public double Lookup_UpfrontMortgageInsuranceRate(int creditScore, decimal downPaymentPercentage, double[,] upfrontMortgageInsuranceRatesArray)
    {
        setupLookupTableIndices(creditScore, downPaymentPercentage);
        return upfrontMortgageInsuranceRatesArray[MortgageInsuranceColumnIndex, MortgageInsuranceRowIndex];
    }
    public double Lookup_MonthlyMortgageInsuranceRate(int creditScore, decimal downPaymentPercentage, double[,] monthlyMortgageInterestRates)
    {
        setupLookupTableIndices(creditScore, downPaymentPercentage);
        return monthlyMortgageInterestRates[MortgageInsuranceColumnIndex, MortgageInsuranceRowIndex];
    }

    public double Lookup_MonthlyPropertyTaxRate()
    {
        return 1.00;   // Updated by Al: 20150803
    }

    // 760 and higher	740-759	720-739	700-719	680-699	660-679	640-659	620-639	600-619	580-599	579 and Lower
    private int getColumnForTableLookups(int creditScore)
    {
        int index = 0;
        while (MortgageInsuranceColumnIndexByCreditScore[index] > creditScore)
        {
            index++;
        }
        return index;
    }

    //4.99% or less 5.00-9.99% 10.00-14.99% 15.00-19.99% 20.00-24.99% 25.00-29.99% 30.00-34.99% 35.00-39.99% 40.00% or More
    private int getRowForTableLookups(decimal downPaymentPercentage)
    {
        int index = 0;
        while (MortgageInsuranceRowIndexByDownPayment[index] < (double)downPaymentPercentage)
        {
            index++;
        }
        return index;
    }

    /// <summary>
    /// Setup Loan-specific information.
    /// </summary>
    static public void setupLoanInfo(LoanProviderInfo loanProviderInfo, int creditScore, decimal downPaymentPercentage, double [,] interestRateOffsetByCreditScoreAndDownPayment, double [,] upfrontMortgageInterestRates, double [,] monthlyMortgageInterestRates)
    {
        loanProviderInfo.CreditScore = creditScore;

        // Interest rate and offset (add the two for actual interest rate)
//            loanProviderInfo.InterestRate_Annual_Base = annualInterestRate_Base;
        loanProviderInfo.InterestRate_Annual_Offset = loanProviderInfo.Lookup_InterestRateOffset(creditScore, downPaymentPercentage, interestRateOffsetByCreditScoreAndDownPayment);
        if (loanProviderInfo.InterestRate_Annual_Offset == CSTL)
        {
            throw new IndexOutOfRangeException("Credit Score too low for this loan (" + loanProviderInfo.LoanType + ") - Interest rate offset not found.");
        }

        // Upfront Mortgage Insurance
        loanProviderInfo.UpfrontMortgageInsuranceRate = loanProviderInfo.Lookup_UpfrontMortgageInsuranceRate(creditScore, downPaymentPercentage, upfrontMortgageInterestRates);
        if (loanProviderInfo.UpfrontMortgageInsuranceRate == CSTL)
        {
            throw new IndexOutOfRangeException("Credit Score too low for this loan (" + loanProviderInfo.LoanType + ") - Upfront Mortgage Insurance rate not found.");
        }

        // Monthly Mortgage Insurance
        loanProviderInfo.MonthlyMortgageInsuranceRate = loanProviderInfo.Lookup_MonthlyMortgageInsuranceRate(creditScore, downPaymentPercentage, monthlyMortgageInterestRates);
        if (loanProviderInfo.MonthlyMortgageInsuranceRate == CSTL)
        {
            throw new IndexOutOfRangeException("Credit Score too low for this loan (" + loanProviderInfo.LoanType + ") - Monthly Mortgage Insurance rate not found.");
        }

        // Property tax
        loanProviderInfo.MonthlyPropertyTaxRate = loanProviderInfo.Lookup_MonthlyPropertyTaxRate();
    }

    /// <summary>
    /// Setup Loan-specific information for USDA loans.
    /// 
    /// </summary>
    static public void setupLoanInfoUSDA(LoanProviderInfo loanProviderInfo, int creditScore, decimal downPaymentPercentage, double[,] interestRateOffsetByCreditScoreAndDownPayment, double[,] upfrontMortgageInterestRates, double[,] monthlyMortgageInterestRates)
    {
        loanProviderInfo.CreditScore = creditScore;

        // Interest rate and offset (add the two for actual interest rate)
        //            loanProviderInfo.InterestRate_Annual_Base = annualInterestRate_Base;
        loanProviderInfo.InterestRate_Annual_Offset = loanProviderInfo.Lookup_InterestRateOffset(creditScore, downPaymentPercentage, interestRateOffsetByCreditScoreAndDownPayment);
        if (loanProviderInfo.InterestRate_Annual_Offset == CSTL)
        {
            throw new IndexOutOfRangeException("Credit Score too low for this loan (" + loanProviderInfo.LoanType + ") - Interest rate offset not found.");
        }

        // Upfront Mortgage Insurance
        loanProviderInfo.UpfrontMortgageInsuranceRate = loanProviderInfo.Lookup_UpfrontMortgageInsuranceRate(creditScore, downPaymentPercentage, upfrontMortgageInterestRates);
        if (loanProviderInfo.UpfrontMortgageInsuranceRate == CSTL)
        {
            throw new IndexOutOfRangeException("Credit Score too low for this loan (" + loanProviderInfo.LoanType + ") - Upfront Mortgage Insurance rate not found.");
        }

        // Monthly Mortgage Insurance
        loanProviderInfo.MonthlyMortgageInsuranceRate = loanProviderInfo.Lookup_MonthlyMortgageInsuranceRate(creditScore, downPaymentPercentage, monthlyMortgageInterestRates);
        if (loanProviderInfo.MonthlyMortgageInsuranceRate == CSTL)
        {
            throw new IndexOutOfRangeException("Credit Score too low for this loan (" + loanProviderInfo.LoanType + ") - Monthly Mortgage Insurance rate not found.");
        }

        // Property tax
        loanProviderInfo.MonthlyPropertyTaxRate = loanProviderInfo.Lookup_MonthlyPropertyTaxRate();
    }

    /// <summary>
    /// Find how much the user can borrow for this loan type.
    /// </summary>
    public static void FindBestLoanAmount(LoanProviderInfo loanProviderInfo, int maxPayment, decimal downPaymentPercentage)
    {
        LoanCalculationResults calculationResult = new LoanCalculationResults();
        calculationResult = FindBestLoanBasedOnMonthlyPayment(maxPayment, loanProviderInfo.LoanTermMonths, loanProviderInfo.InterestRate_Annual_Total, loanProviderInfo.UpfrontMortgageInsuranceRate, loanProviderInfo.MonthlyMortgageInsuranceRate, loanProviderInfo.MonthlyPropertyTaxRate);
        UpdateLoanInfo(loanProviderInfo, calculationResult, downPaymentPercentage);
    }

    /// <summary>
    /// Based on the maximum-allowable-montly-payment, find the most that can be borrowed for this loan type.
    ///   Iterate through scenarios based on increasing loan amount.
    ///   If the scenario hasn't exceeded the max payment, remember the info from the iteration and keep going.
    ///   Once the max payment is exceeded, we know to stop and use the last iteration's data.  
    ///   In other words, go until you fail, then back up to the last success.
    /// </summary>
    private static LoanCalculationResults FindBestLoanBasedOnMonthlyPayment(int maxPayment, double loanTerm_Months, double interestRate_Annual, double upfrontRate_MI, double monthlyRate_MI, double monthlyRate_PropTax)
    {
        LoanCalculationResults calculationResults = new LoanCalculationResults();

        bool keepLooking = true;
        int index = 0;
        int loanInitialAmount = LoanStartingAmount;
        int loanIncrementAmount = LoanIncrementalAmount;
        int currentLoanAmount_Base = 0;
        int currentLoanAmount_BasePlusMortgageInsurance = 0;
        decimal pAndIPayment = 0;
        decimal upfrontPayment_MI = 0;
        decimal monthlyPayment_MI = 0;
        decimal annualMortgageInsurancePayment = 0;
        decimal monthlyPayment_PropTax = 0;
        decimal annualPayment_PropTax = 0;
        
        while (keepLooking == true)
        {
            currentLoanAmount_Base = (loanInitialAmount + (index * loanIncrementAmount));

            upfrontPayment_MI = ((decimal)((upfrontRate_MI / 100) * (double)currentLoanAmount_Base));

            annualMortgageInsurancePayment = (decimal)((monthlyRate_MI / 100) * (double)(currentLoanAmount_Base + upfrontPayment_MI));
            monthlyPayment_MI = annualMortgageInsurancePayment / 12;

            annualPayment_PropTax = (decimal)((monthlyRate_PropTax / 100) * (double)(currentLoanAmount_Base + upfrontPayment_MI));
            monthlyPayment_PropTax = annualPayment_PropTax / 12;

            currentLoanAmount_BasePlusMortgageInsurance = currentLoanAmount_Base + (int)upfrontPayment_MI;
            pAndIPayment = CalculatePrincipleAndInterestPayment(currentLoanAmount_BasePlusMortgageInsurance, loanTerm_Months, interestRate_Annual);



            if ((pAndIPayment + monthlyPayment_MI + monthlyPayment_PropTax) > maxPayment)
            {
                // We have exceeded the payment maximum, so this loan info isn't valid or desired.  
                // We want the info that was saved off from the previous loan calculation iteration.   
                keepLooking = false;  // max payment exceeded - Stop iterating.
            }
            else
            {
                // We haven't exceeded the payment maximum, so remember these values. (Keep going!)
                // The following lines "save the data" from this iteration in case this data is the last valid data iteration.
                calculationResults.RecommendedLoanAmount_Base = currentLoanAmount_Base;
                
                calculationResults.RecommendedPayment_PrincipleAndInterest = pAndIPayment;

                index++;  // Keep going.
            }

        }
        return calculationResults;
    }

    ///// <summary>
    ///// Calculates the monthy payment amount based on current settings.
    ///// </summary>
    ///// /// <returns>Returns the monthly principle and interest payment amount</returns>
    //static decimal CalculatePrincipleAndInterestPayment(LoanProviderInfo loanProviderInfo, decimal loanAmount)
    //{
    //    return CalculatePrincipleAndInterestPayment(loanAmount, loanProviderInfo.LoanTermMonths, (loanProviderInfo.InterestRate_Annual_Base + loanProviderInfo.InterestRate_Annual_Offset));
    //}

    /// <summary>
    /// Calculates the monthy payment amount based on current settings.
    /// loanAmount: "present value" or Principal - amount to borrow
    /// loanTermMonths: Number of payments for loan
    /// Loan Payment Formula:
    /// P = PV * (r / (1- (1+ r) ^-n))
    /// P = Payment
    /// r = rate for period
    /// PV = Present Value
    /// n = number of periods
    /// </summary>
    /// <returns>Returns the monthly principle and interest payment amount</returns>
    public static decimal CalculatePrincipleAndInterestPayment(decimal loanAmount, double loanTermMonths, double interestRate)
    {
        double payment = 0;

        if (loanTermMonths > 0)
        {
            if (interestRate != 0)
            {
                double ratePerMonth = ((interestRate / LoanCommonInfo.MonthsPerYear) / 100);  // Interest rate (per month) for loan
                double numberMonths_Negative = 0 - loanTermMonths;
                double factor = (ratePerMonth) / (1 - Math.Pow((1 + ratePerMonth), numberMonths_Negative));
                payment = ((double)loanAmount * factor);
            }
            else payment = ((double)loanAmount / loanTermMonths);
        }
        return (decimal)Math.Round(payment, 2);
    }

    /// <summary>
    /// Now that we have the info for the most money that can be borrowed, update the loan object with that "max" info.
    /// Then compute the payments based on the rates for various items.
    /// </summary>
    private static void UpdateLoanInfo(LoanProviderInfo masterLoanSpecificInfo, LoanCalculationResults theCalculationResults, decimal downPaymentPercentage)
    {
        masterLoanSpecificInfo.LoanAmount_Base = theCalculationResults.RecommendedLoanAmount_Base;
        masterLoanSpecificInfo.PrincipleAndInterestPayment = theCalculationResults.RecommendedPayment_PrincipleAndInterest;

        //if (masterLoanSpecificInfo.GetType.Equals("USDA 30-year Loan", StringComparison.OrdinalIgnoreCase) = true)
        masterLoanSpecificInfo.UpfrontMortgageInsurancePayment = (decimal)((masterLoanSpecificInfo.UpfrontMortgageInsuranceRate / 100) * (double)masterLoanSpecificInfo.LoanAmount_Base);

        decimal annualMortgageInsurancePayment = (decimal)((masterLoanSpecificInfo.MonthlyMortgageInsuranceRate / 100) * (double)(masterLoanSpecificInfo.LoanAmount_Base + masterLoanSpecificInfo.UpfrontMortgageInsurancePayment));
        masterLoanSpecificInfo.MonthlyMortgageInsurancePayment = annualMortgageInsurancePayment / 12;

        decimal annualPropertyTaxPayment = (decimal)((masterLoanSpecificInfo.MonthlyPropertyTaxRate / 100) * (double)(masterLoanSpecificInfo.LoanAmount_Base + masterLoanSpecificInfo.UpfrontMortgageInsurancePayment));
        masterLoanSpecificInfo.MonthlyPropertyTaxPayment = annualPropertyTaxPayment / 12;

        // Add all the new payments into the loan amount.
        masterLoanSpecificInfo.LoanAmount_Actual = masterLoanSpecificInfo.LoanAmount_Base + masterLoanSpecificInfo.UpfrontMortgageInsurancePayment;
        masterLoanSpecificInfo.TotalLoanPayment = masterLoanSpecificInfo.PrincipleAndInterestPayment + masterLoanSpecificInfo.MonthlyMortgageInsurancePayment + masterLoanSpecificInfo.MonthlyPropertyTaxPayment;

        int salesPriceIndex = masterLoanSpecificInfo.getRowForTableLookups(downPaymentPercentage);
        double downPaymentModifier = SalesPriceCalculationData.SalesPriceCalculation[salesPriceIndex];
        masterLoanSpecificInfo.HouseAmount_Actual = (decimal)((double)masterLoanSpecificInfo.LoanAmount_Actual / downPaymentModifier);
    }


    // Al notified me that the max payment is now loan specific.   Now this logic is moved out of the common area.
    /// <summary>
    /// The Max Payment is based on monthly income vs. monthly debt.
    /// The allowed debt ratio is loan specific (the debt ratio tables that are passed in).
    ///   "This is the max you can afford on a loan"
    /// </summary>
    public int calculateMaxPayment(LoanCommonInfo loanCommonInfo, LoanProviderInfo loanProviderInfo, double[,] debtRatioTable_House, double[,] debtRatioTable_Total)
    {
        int maxPayment = 0;

        setupLookupTableIndices(loanCommonInfo.CreditScore, loanCommonInfo.DownPaymentPercentage);

        double debtRatio_IncomeBased = debtRatioTable_House[MortgageInsuranceColumnIndex, MortgageInsuranceRowIndex];
        double debtRatio_DebtBased = debtRatioTable_Total[MortgageInsuranceColumnIndex, MortgageInsuranceRowIndex];

        int maxPaymentAllowedBasedOnIncome = (int)(loanCommonInfo.Income_Monthly * debtRatio_IncomeBased);
        int maxPaymentAllowedBasedOnDebt = (int)(loanCommonInfo.Income_Monthly * debtRatio_DebtBased) - loanCommonInfo.Debt_Monthly;


        if (maxPaymentAllowedBasedOnIncome > maxPaymentAllowedBasedOnDebt)
        {
            maxPayment = maxPaymentAllowedBasedOnDebt;

        }
        else
        {
            maxPayment = maxPaymentAllowedBasedOnIncome;
        }

        return maxPayment;
    }


}

