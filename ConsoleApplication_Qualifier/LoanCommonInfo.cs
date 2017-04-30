
/// <summary>
/// Class for items that are common across all loan types.  Ex: Credit Score doesn't change based on the loan type, so it is a common item.
/// </summary>


public class LoanCommonInfo
{
    public LoanCommonInfo()
    {
        // TODO: Add constructor logic here
    }
    public const int MonthsPerYear = 12;

    /// <summary>
    /// The Lender's Credit Score of the user.  This number should not be displayed to user, it is for calculations only.
    /// </summary>
    public int CreditScore{ get; set; }

    /// <summary>
    /// Borrower's monthly gross income.  Input by user.
    /// </summary>
    public int Income_Monthly{ get; set; }

    /// <summary>
    /// Borrower's monthly gross income.  Input by user.
    /// </summary>
    public int Debt_Monthly { get; set; }

    /// <summary>
    /// The percentage down.  This is a user input
    /// </summary>
    public decimal DownPaymentPercentage { get; set; }

    /// <summary>
    /// The HOA fees.  This is a user input that isn't used by this Qualifier program - just output the value that was input.
    /// </summary>
    public decimal HOA_Fees { get; set; }


    /// <summary>
    /// Reference to items specific to the FHA30 type of loan.
    /// </summary>
    public LoanProviderInfo LoanInfo_FHA30 { get; set; }

    /// <summary>
    /// Reference to items specific to the FHA15 type of loan.
    /// </summary>
    public LoanProviderInfo LoanInfo_FHA15 { get; set; }

    /// <summary>
    /// Reference to items specific to the VA30 type of loan.
    /// </summary>
    public LoanProviderInfo LoanInfo_VA30 { get; set; }

    /// <summary>
    /// Reference to items specific to the VA15 type of loan.
    /// </summary>
    public LoanProviderInfo LoanInfo_VA15 { get; set; }

    /// <summary>
    /// Reference to items specific to the VA15 type of loan.
    /// </summary>
    public LoanProviderInfo LoanInfo_USDA30 { get; set; }

    /// <summary>
    /// Reference to items specific to the VA15 type of loan.
    /// </summary>
    public LoanProviderInfo LoanInfo_CONV30 { get; set; }

    /// <summary>
    /// Reference to items specific to the VA15 type of loan.
    /// </summary>
    public LoanProviderInfo LoanInfo_CONV15 { get; set; }

    /// <summary>
    /// //1-May-2015: Enhancement request - add 10yr and 20yr loans...
    /// Reference to items specific to the _FHA25 type of loan.
    /// </summary>
    public LoanProviderInfo LoanInfo_FHA25 { get; set; }

    /// <summary>
    /// //1-May-2015: Enhancement request - add 10yr and 20yr loans...
    /// Reference to items specific to the _FHA20 type of loan.
    /// </summary>
    public LoanProviderInfo LoanInfo_FHA20 { get; set; }

    /// <summary>
    /// //1-May-2015: Enhancement request - add 10yr and 20yr loans...
    /// Reference to items specific to the _FHA10 type of loan.
    /// </summary>
    public LoanProviderInfo LoanInfo_FHA10 { get; set; }

    /// <summary>
    /// //1-May-2015: Enhancement request - add 10yr and 20yr loans...
    /// Reference to items specific to the _VA25 type of loan.
    /// </summary>
    public LoanProviderInfo LoanInfo_VA25 { get; set; }

    /// <summary>
    /// //1-May-2015: Enhancement request - add 10yr and 20yr loans...
    /// Reference to items specific to the _VA20 type of loan.
    /// </summary>
    public LoanProviderInfo LoanInfo_VA20 { get; set; }

    /// <summary>
    /// //1-May-2015: Enhancement request - add 10yr and 20yr loans...
    /// Reference to items specific to the _VA10 type of loan.
    /// </summary>
    public LoanProviderInfo LoanInfo_VA10 { get; set; }

    /// <summary>
    /// //1-May-2015: Enhancement request - add 10yr and 20yr loans...
    /// Reference to items specific to the _CONV25 type of loan.
    /// </summary>
    public LoanProviderInfo LoanInfo_CONV25 { get; set; }

    /// <summary>
    /// //1-May-2015: Enhancement request - add 10yr and 20yr loans...
    /// Reference to items specific to the _CONV20 type of loan.
    /// </summary>
    public LoanProviderInfo LoanInfo_CONV20 { get; set; }

    /// <summary>
    /// //1-May-2015: Enhancement request - add 10yr and 20yr loans...
    /// Reference to items specific to the _CONV10 type of loan.
    /// </summary>
    public LoanProviderInfo LoanInfo_CONV10 { get; set; }

}

