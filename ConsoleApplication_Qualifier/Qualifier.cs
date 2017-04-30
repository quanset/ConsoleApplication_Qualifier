using System;

/// <summary>
/// Class to find the loan they qualify for!
/// Figure out the max monthly payment the borrower is allowed.
/// Use the max monthly payment amount to "seek" for the maximum loan amount for each loan type.
/// </summary>

public class Qualifier
{
//        public Qualifier()
//        {
//            // TODO: Add constructor logic here
//        }

    /// <summary>
    /// CLIENT SPECIFIC METHOD - Do not change
    /// </summary>
    static public void setupBorrowerInitialData(LoanCommonInfo loanCommonInfo, Decimal DownPaymentPercentage, int MonthlyIncome, int MonthlyDebt, int CreditScore, int HOAFees)
    {
        loanCommonInfo.DownPaymentPercentage = DownPaymentPercentage;
        loanCommonInfo.Income_Monthly = MonthlyIncome;
        loanCommonInfo.Debt_Monthly = MonthlyDebt;
        loanCommonInfo.CreditScore = CreditScore;
        loanCommonInfo.HOA_Fees = HOAFees;


        //InterestRates IR = new InterestRates();
        //loanCommonInfo.LoanInfo_FHA30 = new LoanProviderInfo("FHA 30-year Loan", 30, IR.FHA30);
        //loanCommonInfo.LoanInfo_FHA15 = new LoanProviderInfo("FHA 15-year Loan", 15, IR.FHA15);
        //loanCommonInfo.LoanInfo_VA30 = new LoanProviderInfo("VA 30-year Loan", 30, IR.VA30);
        //loanCommonInfo.LoanInfo_VA15 = new LoanProviderInfo("VA 15-year Loan", 15, IR.VA15);
        //loanCommonInfo.LoanInfo_USDA30 = new LoanProviderInfo("USDA 30-year Loan", 30, IR.USDA30);
        //loanCommonInfo.LoanInfo_CONV30 = new LoanProviderInfo("CONV 30-year Loan", 30, IR.CONV30);
        //loanCommonInfo.LoanInfo_CONV15 = new LoanProviderInfo("CONV 15-year Loan", 30, IR.CONV15);
        BaseInterestRatesByLoanType interestRates = new BaseInterestRatesByLoanType();
        DebtRatios debtRatios = new DebtRatios();

        loanCommonInfo.LoanInfo_FHA30 = new LoanProviderInfo("FHA 30-year Loan", 30, interestRates.FHA30);
        loanCommonInfo.LoanInfo_FHA25 = new LoanProviderInfo("FHA 25-year Loan", 25, interestRates.FHA25);
        loanCommonInfo.LoanInfo_FHA20 = new LoanProviderInfo("FHA 20-year Loan", 20, interestRates.FHA20);
        loanCommonInfo.LoanInfo_FHA15 = new LoanProviderInfo("FHA 15-year Loan", 15, interestRates.FHA15);
        loanCommonInfo.LoanInfo_FHA10 = new LoanProviderInfo("FHB 10-year Loan", 10, interestRates.FHA10);

        loanCommonInfo.LoanInfo_VA30 = new LoanProviderInfo("VA 30-year Loan", 30, interestRates.VA30);
        loanCommonInfo.LoanInfo_VA25 = new LoanProviderInfo("VA 25-year Loan", 25, interestRates.VA25);
        loanCommonInfo.LoanInfo_VA20 = new LoanProviderInfo("VA 20-year Loan", 20, interestRates.VA20);
        loanCommonInfo.LoanInfo_VA15 = new LoanProviderInfo("VA 15-year Loan", 15, interestRates.VA15);
        loanCommonInfo.LoanInfo_VA10 = new LoanProviderInfo("VA 10-year Loan", 10, interestRates.VA10);

        loanCommonInfo.LoanInfo_USDA30 = new LoanProviderInfo("USDA 30-year Loan", 30, interestRates.USDA30);

        loanCommonInfo.LoanInfo_CONV30 = new LoanProviderInfo("CONV 30-year Loan", 30, interestRates.CONV30);
        loanCommonInfo.LoanInfo_CONV25 = new LoanProviderInfo("CONV 25-year Loan", 25, interestRates.CONV25);
        loanCommonInfo.LoanInfo_CONV20 = new LoanProviderInfo("CONV 20-year Loan", 20, interestRates.CONV20);
        loanCommonInfo.LoanInfo_CONV15 = new LoanProviderInfo("CONV 15-year Loan", 15, interestRates.CONV15);
        loanCommonInfo.LoanInfo_CONV10 = new LoanProviderInfo("CONV 10-year Loan", 10, interestRates.CONV10);

//        calculateMaxPayment(loanCommonInfo);
    }

    /// <summary>
    /// Set the "common" data elements into the data structure: LoanCommonInfo
    /// </summary>
    static public void setupBorrowerInitialData(LoanCommonInfo loanCommonInfo, decimal DownPaymentPercentage, int MonthlyIncome, int MonthlyDebt, int CreditScore, int HOAFees, int dummyVariableToDistinguishMethodSignature)
    {
        loanCommonInfo.DownPaymentPercentage = DownPaymentPercentage;
        loanCommonInfo.Income_Monthly = MonthlyIncome;
        loanCommonInfo.Debt_Monthly = MonthlyDebt;
        loanCommonInfo.CreditScore = CreditScore;
        loanCommonInfo.HOA_Fees = HOAFees;

        BaseInterestRatesByLoanType interestRates = new BaseInterestRatesByLoanType();
        DebtRatios debtRatios = new DebtRatios();

        loanCommonInfo.LoanInfo_FHA30 = new LoanProviderInfo("FHA 30-year Loan", 30, interestRates.FHA30);
        // TODO: REFACTOR the max payment into the constructor for LoanProviderInfo (above line).
        loanCommonInfo.LoanInfo_FHA30.Payment_Maximum = loanCommonInfo.LoanInfo_FHA30.calculateMaxPayment(loanCommonInfo, loanCommonInfo.LoanInfo_FHA30, debtRatios.DebtRatio_House_FHA30, debtRatios.DebtRatio_Total_FHA30);

        loanCommonInfo.LoanInfo_FHA25 = new LoanProviderInfo("FHA 25-year Loan", 25, interestRates.FHA25);
        loanCommonInfo.LoanInfo_FHA25.Payment_Maximum = loanCommonInfo.LoanInfo_FHA25.calculateMaxPayment(loanCommonInfo, loanCommonInfo.LoanInfo_FHA25, debtRatios.DebtRatio_House_FHA25, debtRatios.DebtRatio_Total_FHA25);

        loanCommonInfo.LoanInfo_FHA20 = new LoanProviderInfo("FHA 20-year Loan", 20, interestRates.FHA20);
        loanCommonInfo.LoanInfo_FHA20.Payment_Maximum = loanCommonInfo.LoanInfo_FHA20.calculateMaxPayment(loanCommonInfo, loanCommonInfo.LoanInfo_FHA20, debtRatios.DebtRatio_House_FHA20, debtRatios.DebtRatio_Total_FHA20);

        loanCommonInfo.LoanInfo_FHA15 = new LoanProviderInfo("FHA 15-year Loan", 15, interestRates.FHA15);
        loanCommonInfo.LoanInfo_FHA15.Payment_Maximum = loanCommonInfo.LoanInfo_FHA15.calculateMaxPayment(loanCommonInfo, loanCommonInfo.LoanInfo_FHA15, debtRatios.DebtRatio_House_FHA15, debtRatios.DebtRatio_Total_FHA15);

        loanCommonInfo.LoanInfo_FHA10 = new LoanProviderInfo("FHA 10-year Loan", 10, interestRates.FHA10);
        loanCommonInfo.LoanInfo_FHA10.Payment_Maximum = loanCommonInfo.LoanInfo_FHA10.calculateMaxPayment(loanCommonInfo, loanCommonInfo.LoanInfo_FHA10, debtRatios.DebtRatio_House_FHA10, debtRatios.DebtRatio_Total_FHA10);

        loanCommonInfo.LoanInfo_VA30 = new LoanProviderInfo("VA 30-year Loan", 30, interestRates.VA30);
        loanCommonInfo.LoanInfo_VA30.Payment_Maximum = loanCommonInfo.LoanInfo_VA30.calculateMaxPayment(loanCommonInfo, loanCommonInfo.LoanInfo_VA30, debtRatios.DebtRatio_House_VA30, debtRatios.DebtRatio_Total_VA30);

        loanCommonInfo.LoanInfo_VA25 = new LoanProviderInfo("VA 25-year Loan", 25, interestRates.VA25);
        loanCommonInfo.LoanInfo_VA25.Payment_Maximum = loanCommonInfo.LoanInfo_VA25.calculateMaxPayment(loanCommonInfo, loanCommonInfo.LoanInfo_VA25, debtRatios.DebtRatio_House_VA25, debtRatios.DebtRatio_Total_VA25);

        loanCommonInfo.LoanInfo_VA20 = new LoanProviderInfo("VA 20-year Loan", 20, interestRates.VA20);
        loanCommonInfo.LoanInfo_VA20.Payment_Maximum = loanCommonInfo.LoanInfo_VA20.calculateMaxPayment(loanCommonInfo, loanCommonInfo.LoanInfo_VA20, debtRatios.DebtRatio_House_VA20, debtRatios.DebtRatio_Total_VA20);

        loanCommonInfo.LoanInfo_VA15 = new LoanProviderInfo("VA 15-year Loan", 15, interestRates.VA15);
        loanCommonInfo.LoanInfo_VA15.Payment_Maximum = loanCommonInfo.LoanInfo_VA15.calculateMaxPayment(loanCommonInfo, loanCommonInfo.LoanInfo_VA15, debtRatios.DebtRatio_House_VA15, debtRatios.DebtRatio_Total_VA15);

        loanCommonInfo.LoanInfo_VA10 = new LoanProviderInfo("VA 10-year Loan", 10, interestRates.VA10);
        loanCommonInfo.LoanInfo_VA10.Payment_Maximum = loanCommonInfo.LoanInfo_VA10.calculateMaxPayment(loanCommonInfo, loanCommonInfo.LoanInfo_VA10, debtRatios.DebtRatio_House_VA10, debtRatios.DebtRatio_Total_VA10);

        loanCommonInfo.LoanInfo_USDA30 = new LoanProviderInfo("USDA 30-year Loan", 30, interestRates.USDA30);
        loanCommonInfo.LoanInfo_USDA30.Payment_Maximum = loanCommonInfo.LoanInfo_USDA30.calculateMaxPayment(loanCommonInfo, loanCommonInfo.LoanInfo_USDA30, debtRatios.DebtRatio_House_USDA30, debtRatios.DebtRatio_Total_USDA30);

        loanCommonInfo.LoanInfo_CONV30 = new LoanProviderInfo("CONV 30-year Loan", 30, interestRates.CONV30);
        loanCommonInfo.LoanInfo_CONV30.Payment_Maximum = loanCommonInfo.LoanInfo_CONV30.calculateMaxPayment(loanCommonInfo, loanCommonInfo.LoanInfo_CONV30, debtRatios.DebtRatio_House_CONV30, debtRatios.DebtRatio_Total_CONV30);

        loanCommonInfo.LoanInfo_CONV25 = new LoanProviderInfo("CONV 25-year Loan", 25, interestRates.CONV25);
        loanCommonInfo.LoanInfo_CONV25.Payment_Maximum = loanCommonInfo.LoanInfo_CONV25.calculateMaxPayment(loanCommonInfo, loanCommonInfo.LoanInfo_CONV25, debtRatios.DebtRatio_House_CONV25, debtRatios.DebtRatio_Total_CONV25);

        loanCommonInfo.LoanInfo_CONV20 = new LoanProviderInfo("CONV 20-year Loan", 20, interestRates.CONV20);
        loanCommonInfo.LoanInfo_CONV20.Payment_Maximum = loanCommonInfo.LoanInfo_CONV20.calculateMaxPayment(loanCommonInfo, loanCommonInfo.LoanInfo_CONV20, debtRatios.DebtRatio_House_CONV20, debtRatios.DebtRatio_Total_CONV20);

        loanCommonInfo.LoanInfo_CONV15 = new LoanProviderInfo("CONV 15-year Loan", 15, interestRates.CONV15);
        loanCommonInfo.LoanInfo_CONV15.Payment_Maximum = loanCommonInfo.LoanInfo_CONV15.calculateMaxPayment(loanCommonInfo, loanCommonInfo.LoanInfo_CONV15, debtRatios.DebtRatio_House_CONV15, debtRatios.DebtRatio_Total_CONV15);

        loanCommonInfo.LoanInfo_CONV10 = new LoanProviderInfo("CONV 10-year Loan", 10, interestRates.CONV10);
        loanCommonInfo.LoanInfo_CONV10.Payment_Maximum = loanCommonInfo.LoanInfo_CONV10.calculateMaxPayment(loanCommonInfo, loanCommonInfo.LoanInfo_CONV10, debtRatios.DebtRatio_House_CONV10, debtRatios.DebtRatio_Total_CONV10);

    }



    static public void DisplayLoanInformation(LoanCommonInfo loan_info)
    {
        DisplayCommonLoanInformation(loan_info);

        Console.WriteLine("FHA30 specific info follows: -----------------------------------");
        DisplayLoanSpecificInfo(loan_info.LoanInfo_FHA30, 9999);
        Console.WriteLine("FHA15 specific info follows: -----------------------------------");
        DisplayLoanSpecificInfo(loan_info.LoanInfo_FHA15, 9999);
        Console.WriteLine("VA30 specific info follows: -----------------------------------");
        DisplayLoanSpecificInfo(loan_info.LoanInfo_VA30, 9999);
        Console.WriteLine("VA15 specific info follows: -----------------------------------");
        DisplayLoanSpecificInfo(loan_info.LoanInfo_VA15, 9999);
        Console.WriteLine("USDA30 specific info follows: -----------------------------------");
        DisplayLoanSpecificInfo(loan_info.LoanInfo_USDA30, 9999);
        Console.WriteLine("CONV30 specific info follows: -----------------------------------");
        DisplayLoanSpecificInfo(loan_info.LoanInfo_CONV30, 9999);
        Console.WriteLine("CONV15 specific info follows: -----------------------------------");
        DisplayLoanSpecificInfo(loan_info.LoanInfo_CONV15, 9999);
        Console.WriteLine("_FHA25 specific info follows: -----------------------------------");
        DisplayLoanSpecificInfo(loan_info.LoanInfo_FHA25, 9999);
        Console.WriteLine("_FHA20 specific info follows: -----------------------------------");
        DisplayLoanSpecificInfo(loan_info.LoanInfo_FHA20, 9999);
        Console.WriteLine("_FHA10 specific info follows: -----------------------------------");
        DisplayLoanSpecificInfo(loan_info.LoanInfo_FHA10, 9999);
        Console.WriteLine("_VA25 specific info follows: -----------------------------------");
        DisplayLoanSpecificInfo(loan_info.LoanInfo_VA25, 9999);
        Console.WriteLine("_VA20 specific info follows: -----------------------------------");
        DisplayLoanSpecificInfo(loan_info.LoanInfo_VA20, 9999);
        Console.WriteLine("_VA10 specific info follows: -----------------------------------");
        DisplayLoanSpecificInfo(loan_info.LoanInfo_VA10, 9999);
        Console.WriteLine("_CONV25 specific info follows: -----------------------------------");
        DisplayLoanSpecificInfo(loan_info.LoanInfo_CONV25, 9999);
        Console.WriteLine("_CONV20 specific info follows: -----------------------------------");
        DisplayLoanSpecificInfo(loan_info.LoanInfo_CONV20, 9999);
        Console.WriteLine("_CONV10 specific info follows: -----------------------------------");
        DisplayLoanSpecificInfo(loan_info.LoanInfo_CONV10, 9999);
    }

    private static void DisplayLoanSpecificInfo(LoanProviderInfo loanSpecificInfo, int dummyVariableToDistinguishMethodSignature)
    {
        Console.WriteLine("Loan Type: {0}", loanSpecificInfo.LoanType);
        Console.WriteLine("Loan Term: {0} years ({1} months)", loanSpecificInfo.LoanTermYears, loanSpecificInfo.LoanTermMonths);
        Console.WriteLine("Max Loan Amount qualified for - Base: {0:C}", loanSpecificInfo.LoanAmount_Base);
        Console.WriteLine("Loan Amount - including upfront Mortgage Insurance: {0:C}", loanSpecificInfo.LoanAmount_Actual);
        Console.WriteLine("Annual Interest Rate BASE: {0}%", loanSpecificInfo.InterestRate_Annual_Base);
        Console.WriteLine("Annual Interest Rate OFFSET: {0}%", loanSpecificInfo.InterestRate_Annual_Offset);
        Console.WriteLine("Annual Interest Rate TOTAL: {0}%", loanSpecificInfo.InterestRate_Annual_Total);
        Console.WriteLine("Upfront Mortgage Insurance Rate: {0}%", loanSpecificInfo.UpfrontMortgageInsuranceRate);
        Console.WriteLine("Upfront Mortgage Insurance Amount: {0:C}", loanSpecificInfo.UpfrontMortgageInsurancePayment);
        Console.WriteLine("Monthly Mortgage Insurance Rate: {0}%", loanSpecificInfo.MonthlyMortgageInsuranceRate);
        Console.WriteLine("Monthly Mortgage Insurance Payment: {0:C}", loanSpecificInfo.MonthlyMortgageInsurancePayment);
        Console.WriteLine("Monthly Property Tax Rate: {0}%", loanSpecificInfo.MonthlyPropertyTaxRate);
        Console.WriteLine("Monthly Property Tax Payment: {0:C}", loanSpecificInfo.MonthlyPropertyTaxPayment);
        Console.WriteLine("Monthly P&I: {0:C}", loanSpecificInfo.PrincipleAndInterestPayment);
        Console.WriteLine("Total Payment (P&I + Insurance): {0:C}", loanSpecificInfo.TotalLoanPayment);
        Console.WriteLine();
    }


    /// <summary>
    /// Invoked when an input text file is provided to iterate through.
    /// Flat-format allows multiple scenarios to be read and compared more easily.
    /// </summary>
    static public void DisplayLoanInformation_FlatFormat(LoanCommonInfo loan_info)
    {
        DisplayCommonLoanInformation(loan_info);


        // Display header for the "loan specific" data.
        // The constant formatting string. It specifies the padding.
	    // ... A negative number means to left-align.
	    // ... A positive number means to right-align.
        string header = String.Format("{0,-20}{1,-5}{2,-13}{3,-11}{4,-15}{5,-15}{6,-10}{7,-10}{8,-10}{9,-15}{10,-20}{11,-15}{12,-15}{13,-15}{14,-25}{15,-15}{16,-15}\n",
                                        "Type", "Term", "MaxHouseCost", "MaxPayment", "MaxBase", "MaxLoanTotal", "IntBase", "IntOffset", "IntTotal", "UpfrontMIBase", 
                                        "UpfrontMIAmount", "MonthlyMIRate", "MonthlyMIPmt", "MonthlyPTRate", "MonthlyPTPayment", "MonthlyP&I", "TotalPayment");
        Console.WriteLine(header);

    //      Console.WriteLine("Type Term    MaxBase BaxLoanTotal    IntBase IntOffset   IntTotal    UpfrontMIBase   UpfrontMIAmount MonthlyMIRate   MonthlyMIPmt    MonthlyPTRate   MonthlyPTPayment    MonthlyP&I  TotalPayment");
        DisplayLoanSpecificInfo_FlatFormat(loan_info.LoanInfo_CONV10);
        DisplayLoanSpecificInfo_FlatFormat(loan_info.LoanInfo_CONV15);
        DisplayLoanSpecificInfo_FlatFormat(loan_info.LoanInfo_CONV20);
        DisplayLoanSpecificInfo_FlatFormat(loan_info.LoanInfo_CONV25);
        DisplayLoanSpecificInfo_FlatFormat(loan_info.LoanInfo_CONV30);

        DisplayLoanSpecificInfo_FlatFormat(loan_info.LoanInfo_USDA30);

        DisplayLoanSpecificInfo_FlatFormat(loan_info.LoanInfo_FHA10);
        DisplayLoanSpecificInfo_FlatFormat(loan_info.LoanInfo_FHA15);
        DisplayLoanSpecificInfo_FlatFormat(loan_info.LoanInfo_FHA20);
        DisplayLoanSpecificInfo_FlatFormat(loan_info.LoanInfo_FHA25);
        DisplayLoanSpecificInfo_FlatFormat(loan_info.LoanInfo_FHA30);

        DisplayLoanSpecificInfo_FlatFormat(loan_info.LoanInfo_VA10);
        DisplayLoanSpecificInfo_FlatFormat(loan_info.LoanInfo_VA15);
        DisplayLoanSpecificInfo_FlatFormat(loan_info.LoanInfo_VA20);
        DisplayLoanSpecificInfo_FlatFormat(loan_info.LoanInfo_VA25);
        DisplayLoanSpecificInfo_FlatFormat(loan_info.LoanInfo_VA30);


    }

    private static void DisplayCommonLoanInformation(LoanCommonInfo loan_info)
    {
        Console.WriteLine("Common info from initial setups: -----------------------------------");
        Console.WriteLine("Credit Score      (input from client): {0}", loan_info.CreditScore);
        Console.WriteLine("Down Payment      (input from client): {0}%", loan_info.DownPaymentPercentage);
        Console.WriteLine("Income (monthly)  (input from client): {0:C}", loan_info.Income_Monthly);
        Console.WriteLine("Debt (monthly)    (input from client): {0:C}", loan_info.Debt_Monthly);
        Console.WriteLine("HOA Fees          (input from client): {0:C}", loan_info.HOA_Fees);
        Console.WriteLine("");
    }

    private static void DisplayLoanSpecificInfo_FlatFormat(LoanProviderInfo loanSpecificInfo)
    {
        string output;
        output = String.Format("{0,-20}{1,-5}{2,-13:C}{3,-11:C}{4,-15:C}{5,-15:C}{6,-10}{7,-10}{8,-10}{9,-15}{10,-20:C}{11,-15}{12,-15:C}{13,-15}{14,-25:C}{15,-15:C}{16,-15:C}",
            loanSpecificInfo.LoanType,
            loanSpecificInfo.LoanTermYears,
            loanSpecificInfo.HouseAmount_Actual,
            loanSpecificInfo.Payment_Maximum,
            loanSpecificInfo.LoanAmount_Base,
            loanSpecificInfo.LoanAmount_Actual,
            loanSpecificInfo.InterestRate_Annual_Base,
            loanSpecificInfo.InterestRate_Annual_Offset,
            loanSpecificInfo.InterestRate_Annual_Total,
            loanSpecificInfo.UpfrontMortgageInsuranceRate,
            loanSpecificInfo.UpfrontMortgageInsurancePayment,
            loanSpecificInfo.MonthlyMortgageInsuranceRate,
            loanSpecificInfo.MonthlyMortgageInsurancePayment,
            loanSpecificInfo.MonthlyPropertyTaxRate,
            loanSpecificInfo.MonthlyPropertyTaxPayment,
            loanSpecificInfo.PrincipleAndInterestPayment,
            loanSpecificInfo.TotalLoanPayment);
        Console.WriteLine(output);

        //Console.WriteLine();
    }

    /// <summary>
    /// CLIENT SPECIFIC DISPLAY METHOD - Do not change
    /// </summary>
    static public string DisplayLoanInformation(LoanCommonInfo loan_info, bool isThirty)
    {
        string results = string.Empty;
        //results = "<hr><ul>";
        //results += "<li>Common info from initial setups: -----------------------------------</li>";
        //results += "<li>" + String.Format("Credit Score : {0}", loan_info.CreditScore) + "</li>";
        //results += "<li>" + String.Format("Down Payment: {0}%", loan_info.DownPaymentPercentage) + "</li>";
        //results += "<li>" + String.Format("Income (monthly): {0:C}", loan_info.Income_Monthly) + "</li>";
        //results += "<li>" + String.Format("Debt (monthly): {0:C}", loan_info.Debt_Monthly) + "</li>";
        //results += "<li>" + String.Format("Maximum Payment allowed: {0:C}", loan_info.Payment_Maximum) + "</li>";
        //results += "</ul>";
        //results += "<hr>";

        if (isThirty)
        {
            results += "<table class=\"table table-striped\">";
            results += "<tr>";
            results += "</tr>";
            results += DisplayLoanSpecificInfo(loan_info.LoanInfo_FHA30);
            results += "</table>";
        }
        if (!isThirty)
        {
            results += "<table class=\"table table-striped\">";
            results += "<tr>";
            results += "</tr>";
            results += DisplayLoanSpecificInfo(loan_info.LoanInfo_FHA15);
            results += "</table>";
        }
        if (isThirty)
        {
            results += "<table class=\"table table-striped\">";
            results += "<tr>";
            results += "</tr>";
            results += DisplayLoanSpecificInfo(loan_info.LoanInfo_VA30);
            results += "</table>";
        }
        if (!isThirty)
        {
            results += "<table class=\"table table-striped\">";
            results += "<tr>";
            results += "</tr>";
            results += DisplayLoanSpecificInfo(loan_info.LoanInfo_VA15);
            results += "</table>";
        }
        if (isThirty)
        {
            results += "<table class=\"table table-striped\">";
            results += "<tr>";
            results += "</tr>";
            results += DisplayLoanSpecificInfo(loan_info.LoanInfo_USDA30);
            results += "</table>";
        }
        if (isThirty)
        {
            results += "<table class=\"table table-striped\">";
            results += "<tr>";
            results += DisplayLoanSpecificInfo(loan_info.LoanInfo_CONV30);
            results += "</table>";
        }
        if (!isThirty)
        {
            results += "<table class=\"table table-striped\">";
            results += "<tr>";
            results += "</tr>";
            results += DisplayLoanSpecificInfo(loan_info.LoanInfo_CONV15);
            results += "</table>";
        }


        return results;
    }

    /// <summary>
    /// CLIENT SPECIFIC DISPLAY METHOD - Do not change
    /// </summary>
    static private string DisplayLoanSpecificInfo(LoanProviderInfo loanSpecificInfo)
    {
        string returnLI = string.Empty;
        try
        {
            returnLI += "<tr><td colspan=2>" + String.Format("<h5>{0}</h5>", loanSpecificInfo.LoanType) + "</td></tr>";
            returnLI += "<tr><td>" + String.Format("Loan Term:</td><td> {0} years ({1} months)", loanSpecificInfo.LoanTermYears, loanSpecificInfo.LoanTermMonths) + "</td></tr>";
            returnLI += "<tr><td>" + String.Format("Max Loan Amount qualified for - Base:</td><td> {0:C}", loanSpecificInfo.LoanAmount_Base) + "</td></tr>";
            returnLI += "<tr><td>" + String.Format("Loan Amount - including upfront Mortgage Insurance:</td><td> {0:C}", loanSpecificInfo.LoanAmount_Actual) + "</td></tr>";
            returnLI += "<tr><td>" + String.Format("Annual Interest Rate BASE:</td><td> {0}%", loanSpecificInfo.InterestRate_Annual_Base) + "</td></tr>";
            returnLI += "<tr><td>" + String.Format("Annual Interest Rate OFFSET:</td><td> {0}%", loanSpecificInfo.InterestRate_Annual_Offset) + "</td></tr>";
            returnLI += "<tr><td>" + String.Format("Annual Interest Rate TOTAL:</td><td> {0}%", loanSpecificInfo.InterestRate_Annual_Total) + "</td></tr>";
            returnLI += "<tr><td>" + String.Format("Upfront Mortgage Insurance Rate:</td><td> {0}%", loanSpecificInfo.UpfrontMortgageInsuranceRate) + "</td></tr>";
            returnLI += "<tr><td>" + String.Format("Upfront Mortgage Insurance Amount:</td><td> {0:C}", loanSpecificInfo.UpfrontMortgageInsurancePayment) + "</td></tr>";
            returnLI += "<tr><td>" + String.Format("Monthly Mortgage Insurance Rate:</td><td> {0}%", loanSpecificInfo.MonthlyMortgageInsuranceRate) + "</td></tr>";
            returnLI += "<tr><td>" + String.Format("Monthly Mortgage Insurance Payment:</td><td> {0:C}", loanSpecificInfo.MonthlyMortgageInsurancePayment) + "</td></tr>";
            returnLI += "<tr><td>" + String.Format("Monthly Property Tax Rate:</td><td> {0}%", loanSpecificInfo.MonthlyPropertyTaxRate) + "</td></tr>";
            returnLI += "<tr><td>" + String.Format("Monthly Property Tax Payment:</td><td> {0:C}", loanSpecificInfo.MonthlyPropertyTaxPayment) + "</td></tr>";
            returnLI += "<tr><td>" + String.Format("Monthly P&I:</td><td> {0:C}", loanSpecificInfo.PrincipleAndInterestPayment) + "</td></tr>";
            returnLI += "<tr><td>" + String.Format("Total Payment (P&I + Insurance):</td><td> {0:C}", loanSpecificInfo.TotalLoanPayment) + "</td></tr>";
        }
        catch (Exception ex)
        {
            returnLI += "Errored Out:" + ex.Message;
        }
        return returnLI;

    }
}
