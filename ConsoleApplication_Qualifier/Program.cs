using System;
using System.IO;    // <- required for File and StreamReader classes
/// <summary>
///    Change log:
///      20150501: Added new input param: HOA fees.  Not used by this Qualifier code, just pass it through.
/// </summary>



public class Program
{
    /// <summary>
    /// Wrapper around entry APIs.
    /// Required (from client): Down Payment (as a decimal percentage), Monthly Income, Monthly Debt, Credit Score).
    /// This method accomodates: 
    ///     1) Input from a .txt file
    ///         a) Setup (named) in the ConsoleApplication_Qualifier properties in the DEBUG menu.
    ///         b)   (My test file is: C:\Users\kfultz\Documents\Visual Studio 2013\Projects\ConsoleApplication_Qualifier\ConsoleApplication_Qualifier\bin\Debug\Qualifier_input_params.txt)
    ///         c) .txt file can have multiple groups that will get iterated through.
    ///     2) Command line parameters:
    ///         a) Console.WriteLine("Down Payment percentage - args[0]: {0:P}", args[0]);
    ///         b) Console.WriteLine("Monthly Income - args[1]: {0:C}", args[1]);
    ///         c) Console.WriteLine("Monthly Debt - args[2]: {0:C}", args[2]);
    ///         d) Console.WriteLine("Credit Score - args[3]: {0}", args[3]);
    ///     3) No input parameters
    ///         a) Causes it to use some hard-coded default parameters.
    /// </summary>
    static void Main(string[] args)
    {
        LoanCommonInfo loanCommonInfo = null;

        // Some defaults for testing purposes:
        decimal downPaymentPercentage = -1;
        int monthlyIncome = -1;
        int monthlyDebt = -1;
        int creditScore = -1;
        int specificPrice = -1;   // Phase 2: Used only if the user wants to calculate based on a specific loan amount.
        int downPayment = -1; // Phase 2: Used only if the user wants to calculate based on a specific loan amount.

        int hoaFees = 0;  // Al requested that I allow this to be passed in and just pass it through to an output param. Value NOT USED in the actual Qualifier program.

        if (args.Length > 0)
        {
            if(File.Exists(args[0]))
            {
                // Run using a text file with input params.
                using(StreamReader sr = new StreamReader(args[0]))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parameters = line.Split(',');

                        string formatType = parameters[0];
                        switch (formatType)
                        {
                            case "TYPE":
                                // "header" row - ignore this row
                                break;

                            case "ORIGINAL":
                                // phase 1 version
                                parseInputParams_OriginalType(parameters, out downPaymentPercentage, out monthlyIncome, out monthlyDebt, out creditScore, out hoaFees);
                                loanCommonInfo = RunQualifier(downPaymentPercentage, monthlyIncome, monthlyDebt, creditScore, hoaFees);
                                Qualifier.DisplayLoanInformation_FlatFormat(loanCommonInfo);
                                Console.WriteLine("</RunQualifier> *****************************************************************************************\n");
                                break;

                            case "SPECIFIC_PRICE":
                                // phase 2 version
                                parseInputParams_SpecificPriceType(parameters, out specificPrice, out downPayment, out monthlyIncome, out monthlyDebt, out creditScore, out hoaFees);
                                downPaymentPercentage = calculateDownPaymentPercentage(specificPrice, downPayment);
                                loanCommonInfo = RunQualifier(downPaymentPercentage, monthlyIncome, monthlyDebt, creditScore, hoaFees);
                                Qualifier.DisplayLoanInformation_FlatFormat(loanCommonInfo);
                                Console.WriteLine("</RunQualifier> *****************************************************************************************\n");
                                break;

                            default:
                                break;
                        }
                    }
                }
            } 
            else 
            {
                // Run using single set of commandline params.
                Console.WriteLine("Number of args: {0}", args.Length);
                Console.WriteLine("Down Payment percentage - args[0]: {0:P}", args[0]);
                Console.WriteLine("Monthly Income - args[1]: {0:C}", args[1]);
                Console.WriteLine("Monthly Debt - args[2]: {0:C}", args[2]);
                Console.WriteLine("Credit Score - args[3]: {0}", args[3]);
                Console.WriteLine("HOA Fees - args[4]: {0}", args[4]);

                // values from command line
                downPaymentPercentage = decimal.Parse(args[0]);
                monthlyIncome = int.Parse(args[1]);
                monthlyDebt = int.Parse(args[2]);
                creditScore = int.Parse(args[3]);
                hoaFees = int.Parse(args[4]);

                loanCommonInfo = RunQualifier(downPaymentPercentage, monthlyIncome, monthlyDebt, creditScore, hoaFees);
                Qualifier.DisplayLoanInformation(loanCommonInfo);
                Console.WriteLine("*****************************************************************************************\n");
            }

        }
        else
        {
            // No commandline params - Run using some defaults for testing purposes:
            downPaymentPercentage = (decimal)3.0;
            monthlyIncome = 4500;
            monthlyDebt = 530;
            creditScore = 680;

            hoaFees = 0;

            loanCommonInfo = RunQualifier(downPaymentPercentage, monthlyIncome, monthlyDebt, creditScore, hoaFees);
            Qualifier.DisplayLoanInformation(loanCommonInfo);
            Console.WriteLine("*****************************************************************************************\n");
        }
        Console.ReadKey();  // Just to pause the console window for reading.

    }

    private static void parseInputParams_OriginalType(string[] parameters, 
        out decimal downPaymentPercentage, 
        out int monthlyIncome, 
        out int monthlyDebt, 
        out int creditScore, 
        out int hoaFees)
    {
        downPaymentPercentage = decimal.Parse(parameters[1]);
        monthlyIncome = int.Parse(parameters[2]);
        monthlyDebt = int.Parse(parameters[3]);
        creditScore = int.Parse(parameters[4]);
        hoaFees = int.Parse(parameters[5]);
    }

    private static void parseInputParams_SpecificPriceType(string[] parameters,
        out int specificPrice,
        out int downPayment, 
        out int monthlyIncome, 
        out int monthlyDebt, 
        out int creditScore, 
        out int hoaFees)
    {
        specificPrice = int.Parse(parameters[1]);
        downPayment = int.Parse(parameters[2]);
        monthlyIncome = int.Parse(parameters[3]);
        monthlyDebt = int.Parse(parameters[4]);
        creditScore = int.Parse(parameters[5]);
        hoaFees = int.Parse(parameters[6]);
    }

    private static decimal calculateDownPaymentPercentage(int specificPrice, int downPayment)
    {
        int loanAmount = 0;
        decimal downPaymentPercentage = 0.0M;

        loanAmount = specificPrice - downPayment;
        downPaymentPercentage = 1M - (decimal)loanAmount / (decimal)specificPrice;
        downPaymentPercentage = downPaymentPercentage * 100M;
        return downPaymentPercentage;
    }


    /// <summary>
    /// This is a good entry point for a client.
    /// Wrapper around entry APIs.
    /// Required (from client): Down Payment (as a decimal percentage), Monthly Income, Monthly Debt, Credit Score).
    /// </summary>
    public static LoanCommonInfo RunQualifier(decimal downPaymentPercentage, int monthlyIncome, int monthlyDebt, int creditScore, int hoaFees)
    {

        Qualifier qualifier = new Qualifier();
        LoanCommonInfo loanCommonInfo = new LoanCommonInfo();

        Qualifier.setupBorrowerInitialData(loanCommonInfo, downPaymentPercentage, monthlyIncome, monthlyDebt, creditScore, hoaFees, 9999);

        Console.WriteLine("<RunQualifier> *****************************************************************************************");

        try
        {
            // FHA 30-Year
            LoanProviderInfo.setupLoanInfo(loanCommonInfo.LoanInfo_FHA30, loanCommonInfo.CreditScore, loanCommonInfo.DownPaymentPercentage, InterestRateOffsetsByLoanType.InterestRateOffsetByCreditScoreAndDownPayment_FHA30, MortgageInterestRatesByLoanType.UpfrontMortgageInterestRates_FHA30, MortgageInterestRatesByLoanType.MonthlyMortgageInterestRates_FHA30);
            LoanProviderInfo.FindBestLoanAmount(loanCommonInfo.LoanInfo_FHA30, loanCommonInfo.LoanInfo_FHA30.Payment_Maximum, loanCommonInfo.DownPaymentPercentage);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Credit Score too low for this loan - Credit Score: " + loanCommonInfo.CreditScore);
            Console.WriteLine(ex.GetType().FullName);
            Console.WriteLine(ex.Message);
        }

        try
        {
            // FHA 15-Year
            LoanProviderInfo.setupLoanInfo(loanCommonInfo.LoanInfo_FHA15, loanCommonInfo.CreditScore, loanCommonInfo.DownPaymentPercentage, InterestRateOffsetsByLoanType.InterestRateOffsetByCreditScoreAndDownPayment_FHA15, MortgageInterestRatesByLoanType.UpfrontMortgageInterestRates_FHA15, MortgageInterestRatesByLoanType.MonthlyMortgageInterestRates_FHA15);
            LoanProviderInfo.FindBestLoanAmount(loanCommonInfo.LoanInfo_FHA15, loanCommonInfo.LoanInfo_FHA15.Payment_Maximum, loanCommonInfo.DownPaymentPercentage);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Credit Score too low for this loan");
            Console.WriteLine(ex.GetType().FullName);
            Console.WriteLine(ex.Message);
        }

        try
        {
            // VA 30-Year
            LoanProviderInfo.setupLoanInfo(loanCommonInfo.LoanInfo_VA30, loanCommonInfo.CreditScore, loanCommonInfo.DownPaymentPercentage, InterestRateOffsetsByLoanType.InterestRateOffsetByCreditScoreAndDownPayment_VA30, MortgageInterestRatesByLoanType.UpfrontMortgageInterestRates_VA30, MortgageInterestRatesByLoanType.MonthlyMortgageInterestRates_VA30);
            LoanProviderInfo.FindBestLoanAmount(loanCommonInfo.LoanInfo_VA30, loanCommonInfo.LoanInfo_VA30.Payment_Maximum, loanCommonInfo.DownPaymentPercentage);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Credit Score too low for this loan");
            Console.WriteLine(ex.GetType().FullName);
            Console.WriteLine(ex.Message);
        }

        try
        {
            // VA 15-Year
            LoanProviderInfo.setupLoanInfo(loanCommonInfo.LoanInfo_VA15, loanCommonInfo.CreditScore, loanCommonInfo.DownPaymentPercentage, InterestRateOffsetsByLoanType.InterestRateOffsetByCreditScoreAndDownPayment_VA15, MortgageInterestRatesByLoanType.UpfrontMortgageInterestRates_VA15, MortgageInterestRatesByLoanType.MonthlyMortgageInterestRates_VA15);
            LoanProviderInfo.FindBestLoanAmount(loanCommonInfo.LoanInfo_VA15, loanCommonInfo.LoanInfo_VA15.Payment_Maximum, loanCommonInfo.DownPaymentPercentage);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Credit Score too low for this loan");
            Console.WriteLine(ex.GetType().FullName);
            Console.WriteLine(ex.Message);
        }

        try
        {
            // USDA 30-Year
            LoanProviderInfo.setupLoanInfo(loanCommonInfo.LoanInfo_USDA30, loanCommonInfo.CreditScore, loanCommonInfo.DownPaymentPercentage, InterestRateOffsetsByLoanType.InterestRateOffsetByCreditScoreAndDownPayment_USDA30, MortgageInterestRatesByLoanType.UpfrontMortgageInterestRates_USDA30, MortgageInterestRatesByLoanType.MonthlyMortgageInterestRates_USDA30);
            LoanProviderInfo.FindBestLoanAmount(loanCommonInfo.LoanInfo_USDA30, loanCommonInfo.LoanInfo_USDA30.Payment_Maximum, loanCommonInfo.DownPaymentPercentage);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Credit Score too low for this loan");
            Console.WriteLine(ex.GetType().FullName);
            Console.WriteLine(ex.Message);
        }

        try
        {
            // CONV 30-Year
            LoanProviderInfo.setupLoanInfo(loanCommonInfo.LoanInfo_CONV30, loanCommonInfo.CreditScore, loanCommonInfo.DownPaymentPercentage, InterestRateOffsetsByLoanType.InterestRateOffsetByCreditScoreAndDownPayment_CONV30, MortgageInterestRatesByLoanType.UpfrontMortgageInterestRates_CONV30, MortgageInterestRatesByLoanType.MonthlyMortgageInterestRates_CONV30);
            LoanProviderInfo.FindBestLoanAmount(loanCommonInfo.LoanInfo_CONV30, loanCommonInfo.LoanInfo_CONV30.Payment_Maximum, loanCommonInfo.DownPaymentPercentage);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Credit Score too low for this loan");
            Console.WriteLine(ex.GetType().FullName);
            Console.WriteLine(ex.Message);
        }

        try
        {
            // CONV 15-Year
            LoanProviderInfo.setupLoanInfo(loanCommonInfo.LoanInfo_CONV15, loanCommonInfo.CreditScore, loanCommonInfo.DownPaymentPercentage, InterestRateOffsetsByLoanType.InterestRateOffsetByCreditScoreAndDownPayment_CONV15, MortgageInterestRatesByLoanType.UpfrontMortgageInterestRates_CONV15, MortgageInterestRatesByLoanType.MonthlyMortgageInterestRates_CONV15);
            LoanProviderInfo.FindBestLoanAmount(loanCommonInfo.LoanInfo_CONV15, loanCommonInfo.LoanInfo_CONV15.Payment_Maximum, loanCommonInfo.DownPaymentPercentage);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Credit Score too low for this loan");
            Console.WriteLine(ex.GetType().FullName);
            Console.WriteLine(ex.Message);
        }

        try
        {
            //1-May-2015: Enhancement request - add 10yr and 20yr loans...
            // _FHA25
            LoanProviderInfo.setupLoanInfo(loanCommonInfo.LoanInfo_FHA25, loanCommonInfo.CreditScore, loanCommonInfo.DownPaymentPercentage, InterestRateOffsetsByLoanType.InterestRateOffsetByCreditScoreAndDownPayment_FHA25, MortgageInterestRatesByLoanType.UpfrontMortgageInterestRates_FHA25, MortgageInterestRatesByLoanType.MonthlyMortgageInterestRates_FHA25);
            LoanProviderInfo.FindBestLoanAmount(loanCommonInfo.LoanInfo_FHA25, loanCommonInfo.LoanInfo_FHA25.Payment_Maximum, loanCommonInfo.DownPaymentPercentage);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Credit Score too low for this loan");
            Console.WriteLine(ex.GetType().FullName);
            Console.WriteLine(ex.Message);
        }

        try
        {
            //1-May-2015: Enhancement request - add 10yr and 20yr loans...
            // _FHA20
            LoanProviderInfo.setupLoanInfo(loanCommonInfo.LoanInfo_FHA20, loanCommonInfo.CreditScore, loanCommonInfo.DownPaymentPercentage, InterestRateOffsetsByLoanType.InterestRateOffsetByCreditScoreAndDownPayment_FHA20, MortgageInterestRatesByLoanType.UpfrontMortgageInterestRates_FHA20, MortgageInterestRatesByLoanType.MonthlyMortgageInterestRates_FHA20);
            LoanProviderInfo.FindBestLoanAmount(loanCommonInfo.LoanInfo_FHA20, loanCommonInfo.LoanInfo_FHA20.Payment_Maximum, loanCommonInfo.DownPaymentPercentage);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Credit Score too low for this loan");
            Console.WriteLine(ex.GetType().FullName);
            Console.WriteLine(ex.Message);
        }

        try
        {
            //1-May-2015: Enhancement request - add 10yr and 20yr loans...
            // _FHA10
            LoanProviderInfo.setupLoanInfo(loanCommonInfo.LoanInfo_FHA10, loanCommonInfo.CreditScore, loanCommonInfo.DownPaymentPercentage, InterestRateOffsetsByLoanType.InterestRateOffsetByCreditScoreAndDownPayment_FHA10, MortgageInterestRatesByLoanType.UpfrontMortgageInterestRates_FHA10, MortgageInterestRatesByLoanType.MonthlyMortgageInterestRates_FHA10);
            LoanProviderInfo.FindBestLoanAmount(loanCommonInfo.LoanInfo_FHA10, loanCommonInfo.LoanInfo_FHA10.Payment_Maximum, loanCommonInfo.DownPaymentPercentage);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Credit Score too low for this loan");
            Console.WriteLine(ex.GetType().FullName);
            Console.WriteLine(ex.Message);
        }
        try
        {
            //1-May-2015: Enhancement request - add 10yr and 20yr loans...
            // _VA25
            LoanProviderInfo.setupLoanInfo(loanCommonInfo.LoanInfo_VA25, loanCommonInfo.CreditScore, loanCommonInfo.DownPaymentPercentage, InterestRateOffsetsByLoanType.InterestRateOffsetByCreditScoreAndDownPayment_VA25, MortgageInterestRatesByLoanType.UpfrontMortgageInterestRates_VA25, MortgageInterestRatesByLoanType.MonthlyMortgageInterestRates_VA25);
            LoanProviderInfo.FindBestLoanAmount(loanCommonInfo.LoanInfo_VA25, loanCommonInfo.LoanInfo_VA25.Payment_Maximum, loanCommonInfo.DownPaymentPercentage);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Credit Score too low for this loan");
            Console.WriteLine(ex.GetType().FullName);
            Console.WriteLine(ex.Message);
        }
        try
        {
            //1-May-2015: Enhancement request - add 10yr and 20yr loans...
            // _VA20
            LoanProviderInfo.setupLoanInfo(loanCommonInfo.LoanInfo_VA20, loanCommonInfo.CreditScore, loanCommonInfo.DownPaymentPercentage, InterestRateOffsetsByLoanType.InterestRateOffsetByCreditScoreAndDownPayment_VA20, MortgageInterestRatesByLoanType.UpfrontMortgageInterestRates_VA20, MortgageInterestRatesByLoanType.MonthlyMortgageInterestRates_VA20);
            LoanProviderInfo.FindBestLoanAmount(loanCommonInfo.LoanInfo_VA20, loanCommonInfo.LoanInfo_VA20.Payment_Maximum, loanCommonInfo.DownPaymentPercentage);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Credit Score too low for this loan");
            Console.WriteLine(ex.GetType().FullName);
            Console.WriteLine(ex.Message);
        }
        try
        {
            //1-May-2015: Enhancement request - add 10yr and 20yr loans...
            // _VA10
            LoanProviderInfo.setupLoanInfo(loanCommonInfo.LoanInfo_VA10, loanCommonInfo.CreditScore, loanCommonInfo.DownPaymentPercentage, InterestRateOffsetsByLoanType.InterestRateOffsetByCreditScoreAndDownPayment_VA10, MortgageInterestRatesByLoanType.UpfrontMortgageInterestRates_VA10, MortgageInterestRatesByLoanType.MonthlyMortgageInterestRates_VA10);
            LoanProviderInfo.FindBestLoanAmount(loanCommonInfo.LoanInfo_VA10, loanCommonInfo.LoanInfo_VA10.Payment_Maximum, loanCommonInfo.DownPaymentPercentage);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Credit Score too low for this loan");
            Console.WriteLine(ex.GetType().FullName);
            Console.WriteLine(ex.Message);
        }
        try
        {
            //1-May-2015: Enhancement request - add 10yr and 20yr loans...
            // _CONV25
            LoanProviderInfo.setupLoanInfo(loanCommonInfo.LoanInfo_CONV25, loanCommonInfo.CreditScore, loanCommonInfo.DownPaymentPercentage, InterestRateOffsetsByLoanType.InterestRateOffsetByCreditScoreAndDownPayment_CONV25, MortgageInterestRatesByLoanType.UpfrontMortgageInterestRates_CONV25, MortgageInterestRatesByLoanType.MonthlyMortgageInterestRates_CONV25);
            LoanProviderInfo.FindBestLoanAmount(loanCommonInfo.LoanInfo_CONV25, loanCommonInfo.LoanInfo_CONV25.Payment_Maximum, loanCommonInfo.DownPaymentPercentage);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Credit Score too low for this loan");
            Console.WriteLine(ex.GetType().FullName);
            Console.WriteLine(ex.Message);
        }
        try
        {
            //1-May-2015: Enhancement request - add 10yr and 20yr loans...
            // _CONV20
            LoanProviderInfo.setupLoanInfo(loanCommonInfo.LoanInfo_CONV20, loanCommonInfo.CreditScore, loanCommonInfo.DownPaymentPercentage, InterestRateOffsetsByLoanType.InterestRateOffsetByCreditScoreAndDownPayment_CONV20, MortgageInterestRatesByLoanType.UpfrontMortgageInterestRates_CONV20, MortgageInterestRatesByLoanType.MonthlyMortgageInterestRates_CONV20);
            LoanProviderInfo.FindBestLoanAmount(loanCommonInfo.LoanInfo_CONV20, loanCommonInfo.LoanInfo_CONV20.Payment_Maximum, loanCommonInfo.DownPaymentPercentage);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Credit Score too low for this loan");
            Console.WriteLine(ex.GetType().FullName);
            Console.WriteLine(ex.Message);
        }
        try
        {
            //1-May-2015: Enhancement request - add 10yr and 20yr loans...
            // _CONV10
            LoanProviderInfo.setupLoanInfo(loanCommonInfo.LoanInfo_CONV10, loanCommonInfo.CreditScore, loanCommonInfo.DownPaymentPercentage, InterestRateOffsetsByLoanType.InterestRateOffsetByCreditScoreAndDownPayment_CONV10, MortgageInterestRatesByLoanType.UpfrontMortgageInterestRates_CONV10, MortgageInterestRatesByLoanType.MonthlyMortgageInterestRates_CONV10);
            LoanProviderInfo.FindBestLoanAmount(loanCommonInfo.LoanInfo_CONV10, loanCommonInfo.LoanInfo_CONV10.Payment_Maximum, loanCommonInfo.DownPaymentPercentage);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Credit Score too low for this loan");
            Console.WriteLine(ex.GetType().FullName);
            Console.WriteLine(ex.Message);
        }

        return loanCommonInfo;

    }

    /// <summary>
    /// This is a good entry point for a client.
    /// Wrapper around entry APIs.
    /// Required (from client): Down Payment (as a decimal percentage), Monthly Income, Monthly Debt, Credit Score).
    /// 
    /// NOTE: This is the 2nd phase requested by Al.  After the original qualifier is called, he wants to then specify a loan amount (MaxLoanTotal) and see what loans he qualifies for.
    /// </summary>
    public static LoanCommonInfo RunQualifier_specificPrice(decimal downPaymentPercentage, int monthlyIncome, int monthlyDebt, int creditScore, int hoaFees)
    {

        Qualifier qualifier = new Qualifier();
        LoanCommonInfo loanCommonInfo = new LoanCommonInfo();

        Qualifier.setupBorrowerInitialData(loanCommonInfo, downPaymentPercentage, monthlyIncome, monthlyDebt, creditScore, hoaFees, 9999);

        Console.WriteLine("<RunQualifier> *****************************************************************************************");

        try
        {
            // FHA 30-Year
            LoanProviderInfo.setupLoanInfo(loanCommonInfo.LoanInfo_FHA30, loanCommonInfo.CreditScore, loanCommonInfo.DownPaymentPercentage, InterestRateOffsetsByLoanType.InterestRateOffsetByCreditScoreAndDownPayment_FHA30, MortgageInterestRatesByLoanType.UpfrontMortgageInterestRates_FHA30, MortgageInterestRatesByLoanType.MonthlyMortgageInterestRates_FHA30);
            LoanProviderInfo.FindBestLoanAmount(loanCommonInfo.LoanInfo_FHA30, loanCommonInfo.LoanInfo_FHA30.Payment_Maximum, loanCommonInfo.DownPaymentPercentage);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Credit Score too low for this loan - Credit Score: " + loanCommonInfo.CreditScore);
            Console.WriteLine(ex.GetType().FullName);
            Console.WriteLine(ex.Message);
        }

        return loanCommonInfo;

    }

    /// <summary>
    /// This is a test method that was initially used to pump test cases directly through the Loan Calculator logic.
    /// This method isn't really used anymore, but is here, just in case!
    /// </summary>
    public static void TestLoanCalculator()
    {
        //public static decimal CalculatePrincipleAndInterestPayment(decimal loanAmount, double loanTermMonths, double interestRate)
        Console.WriteLine("$145,000, 360 months, 3.63%: {0:C}", LoanProviderInfo.CalculatePrincipleAndInterestPayment(145000, 360, 3.63));
        Console.WriteLine("$150,000, 360 months, 3.63%: {0:C}", LoanProviderInfo.CalculatePrincipleAndInterestPayment(150000, 360, 3.63));
        Console.WriteLine("$155,000, 360 months, 3.63%: {0:C}", LoanProviderInfo.CalculatePrincipleAndInterestPayment(155000, 360, 3.63));
        Console.WriteLine("");
    }

}
