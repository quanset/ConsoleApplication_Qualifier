/// <summary>
/// Base Interest rates, depending on the loan type.
/// The base interest rate is later modified based on credit score and down payment.
/// </summary>
public class MortgageInterestRatesByLoanType
{
    public MortgageInterestRatesByLoanType()
    {
    }

    public const double CSTL = -9999;  // CREDIT SCORE TOO LOW

    public static double[,] UpfrontMortgageInterestRates_FHA30 = new double[11, 9] {
        {1.25, 1.2, 1.2, 1.2, 1.2, 1.2, 1.2, 1.2, 1.2},
        {1.25, 1.2, 1.2, 1.2, 1.2, 1.2, 1.2, 1.2, 1.2},
        {1.25, 1.2, 1.2, 1.2, 1.2, 1.2, 1.2, 1.2, 1.2},
        {1.25, 1.2, 1.2, 1.2, 1.2, 1.2, 1.2, 1.2, 1.2},
        {1.25, 1.2, 1.2, 1.2, 1.2, 1.2, 1.2, 1.2, 1.2},
        {1.25, 1.2, 1.2, 1.2, 1.2, 1.2, 1.2, 1.2, 1.2},
        {1.25, 1.2, 1.2, 1.2, 1.2, 1.2, 1.2, 1.2, 1.2},
        {1.25, 1.2, 1.2, 1.2, 1.2, 1.2, 1.2, 1.2, 1.2},
        {1.25, 1.2, 1.2, 1.2, 1.2, 1.2, 1.2, 1.2, 1.2},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };
    public static double[,] MonthlyMortgageInterestRates_FHA30 = new double[11, 9] {
        {0.85, 0.8, 0.8, 0.8, 0.8, 0.8, 0.8, 0.8, 0.8},
        {0.85, 0.8, 0.8, 0.8, 0.8, 0.8, 0.8, 0.8, 0.8},
        {0.85, 0.8, 0.8, 0.8, 0.8, 0.8, 0.8, 0.8, 0.8},
        {0.85, 0.8, 0.8, 0.8, 0.8, 0.8, 0.8, 0.8, 0.8},
        {0.85, 0.8, 0.8, 0.8, 0.8, 0.8, 0.8, 0.8, 0.8},
        {0.85, 0.8, 0.8, 0.8, 0.8, 0.8, 0.8, 0.8, 0.8},
        {0.85, 0.8, 0.8, 0.8, 0.8, 0.8, 0.8, 0.8, 0.8},
        {0.85, 0.8, 0.8, 0.8, 0.8, 0.8, 0.8, 0.8, 0.8},
        {0.85, 0.8, 0.8, 0.8, 0.8, 0.8, 0.8, 0.8, 0.8},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };

    public static double[,] UpfrontMortgageInterestRates_FHA25 = UpfrontMortgageInterestRates_FHA30;  // SAME as FHA30
    public static double[,] MonthlyMortgageInterestRates_FHA25 = MonthlyMortgageInterestRates_FHA30;  // SAME as FHA30

    public static double[,] UpfrontMortgageInterestRates_FHA20 = UpfrontMortgageInterestRates_FHA30;  // SAME as FHA30
    public static double[,] MonthlyMortgageInterestRates_FHA20 = MonthlyMortgageInterestRates_FHA30;  // SAME as FHA30

    public static double[,] UpfrontMortgageInterestRates_FHA15 = new double[11, 9] {
        {0.6, 0.6, 0.35, 0.35, 0.35, 0, 0, 0, 0},
        {0.6, 0.6, 0.35, 0.35, 0.35, 0, 0, 0, 0},
        {0.6, 0.6, 0.35, 0.35, 0.35, 0, 0, 0, 0},
        {0.6, 0.6, 0.35, 0.35, 0.35, 0, 0, 0, 0},
        {0.6, 0.6, 0.35, 0.35, 0.35, 0, 0, 0, 0},
        {0.6, 0.6, 0.35, 0.35, 0.35, 0, 0, 0, 0},
        {0.6, 0.6, 0.35, 0.35, 0.35, 0, 0, 0, 0},
        {0.6, 0.6, 0.35, 0.35, 0.35, 0, 0, 0, 0},
        {0.6, 0.6, 0.35, 0.35, 0.35, 0, 0, 0, 0},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };
    public static double[,] MonthlyMortgageInterestRates_FHA15 = new double[11, 9] {
        {0.7, 0.7, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45},
        {0.7, 0.7, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45},
        {0.7, 0.7, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45},
        {0.7, 0.7, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45},
        {0.7, 0.7, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45},
        {0.7, 0.7, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45},
        {0.7, 0.7, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45},
        {0.7, 0.7, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45},
        {0.7, 0.7, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };

    public static double[,] UpfrontMortgageInterestRates_FHA10 = UpfrontMortgageInterestRates_FHA15;
    public static double[,] MonthlyMortgageInterestRates_FHA10 = MonthlyMortgageInterestRates_FHA15;

    public static double[,] UpfrontMortgageInterestRates_VA30 = new double[11, 9] {
        {2.15, 1.5, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25},
        {2.15, 1.5, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25},
        {2.15, 1.5, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25},
        {2.15, 1.5, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25},
        {2.15, 1.5, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25},
        {2.15, 1.5, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25},
        {2.15, 1.5, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25},
        {2.15, 1.5, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25},
        {2.15, 1.5, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };
    public static double[,] MonthlyMortgageInterestRates_VA30 = new double[11, 9] {
        {0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };

    public static double[,] UpfrontMortgageInterestRates_VA25 = UpfrontMortgageInterestRates_VA30;
    public static double[,] MonthlyMortgageInterestRates_VA25 = MonthlyMortgageInterestRates_VA30;

    public static double[,] UpfrontMortgageInterestRates_VA20 = UpfrontMortgageInterestRates_VA30;
    public static double[,] MonthlyMortgageInterestRates_VA20 = MonthlyMortgageInterestRates_VA30;

    public static double[,] UpfrontMortgageInterestRates_VA15 = new double[11, 9] {
        {2.15, 1.5, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25},
        {2.15, 1.5, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25},
        {2.15, 1.5, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25},
        {2.15, 1.5, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25},
        {2.15, 1.5, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25},
        {2.15, 1.5, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25},
        {2.15, 1.5, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25},
        {2.15, 1.5, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25},
        {2.15, 1.5, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25, 1.25},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };
    public static double[,] MonthlyMortgageInterestRates_VA15 = new double[11, 9] {
        {0,0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0,0},
        {CSTL,CSTL,CSTL,CSTL,CSTL,CSTL,CSTL,CSTL,CSTL},
        {CSTL,CSTL,CSTL,CSTL,CSTL,CSTL,CSTL,CSTL,CSTL} };

    public static double[,] UpfrontMortgageInterestRates_VA10 = UpfrontMortgageInterestRates_VA15;
    public static double[,] MonthlyMortgageInterestRates_VA10 = MonthlyMortgageInterestRates_VA15;

    public static double[,] UpfrontMortgageInterestRates_USDA30 = new double[11, 9] {
        {1, 1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1, 1},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0} };
    public static double[,] MonthlyMortgageInterestRates_USDA30 = new double[11, 9] {
        {0.35, 0.35, 0.35, 0.35, 0.35, 0.35, 0.35, 0.35, 0.35},
        {0.35, 0.35, 0.35, 0.35, 0.35, 0.35, 0.35, 0.35, 0.35},
        {0.35, 0.35, 0.35, 0.35, 0.35, 0.35, 0.35, 0.35, 0.35},
        {0.35, 0.35, 0.35, 0.35, 0.35, 0.35, 0.35, 0.35, 0.35},
        {0.35, 0.35, 0.35, 0.35, 0.35, 0.35, 0.35, 0.35, 0.35},
        {0.35, 0.35, 0.35, 0.35, 0.35, 0.35, 0.35, 0.35, 0.35},
        {0.35, 0.35, 0.35, 0.35, 0.35, 0.35, 0.35, 0.35, 0.35},
        {0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0} };

    public static double[,] UpfrontMortgageInterestRates_CONV30 = new double[11, 9] {
        {0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };
    public static double[,] MonthlyMortgageInterestRates_CONV30 = new double[11, 9] {
        {0.55, 0.41, 0.3, 0.19, 0, 0, 0, 0, 0},
        {0.75, 0.59, 0.41, 0.2, 0, 0, 0, 0, 0},
        {0.95, 0.73, 0.5, 0.23, 0, 0, 0, 0, 0},
        {1.15, 0.87, 0.6, 0.27, 0, 0, 0, 0, 0},
        {1.4, 1.08, 0.73, 0.32, 0, 0, 0, 0, 0},
        {1.9, 1.42, 1.0, 0.41, 0, 0, 0, 0, 0},
        {2.05, 1.5, 1.05, 0.43, 0, 0, 0, 0, 0},
        {2.25, 1.61, 1.1, 0.45, 0, 0, 0, 0, 0},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };

    public static double[,] UpfrontMortgageInterestRates_CONV25 = UpfrontMortgageInterestRates_CONV30;
    public static double[,] MonthlyMortgageInterestRates_CONV25 = new double[11, 9] {
        {0.55, 0.41, 0.3, 0.19, 0, 0, 0, 0, 0},
        {0.75, 0.59, 0.41, 0.2, 0, 0, 0, 0, 0},
        {0.95, 0.73, 0.5, 0.23, 0, 0, 0, 0, 0},
        {1.15, 0.87, 0.6, 0.27, 0, 0, 0, 0, 0},
        {1.4, 1.08, 0.73, 0.32, 0, 0, 0, 0, 0},
        {1.9, 1.42, 1.0, 0.41, 0, 0, 0, 0, 0},
        {2.05, 1.5, 1.05, 0.43, 0, 0, 0, 0, 0},
        {2.25, 1.61, 1.1, 0.45, 0, 0, 0, 0, 0},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL}};

    public static double[,] UpfrontMortgageInterestRates_CONV20 = UpfrontMortgageInterestRates_CONV30;
    public static double[,] MonthlyMortgageInterestRates_CONV20 = new double[11, 9] {
        {0.37, 0.28, 0.19, 0.17, 0, 0, 0, 0, 0},
        {0.5, 0.38, 0.21, 0.18, 0, 0, 0, 0, 0},
        {0.65, 0.45, 0.25, 0.19, 0, 0, 0, 0, 0},
        {0.77, 0.54, 0.28, 0.2, 0, 0, 0, 0, 0},
        {0.97, 0.65, 0.33, 0.2, 0, 0, 0, 0, 0},
        {1.3, 0.8, 0.42, 0.22, 0, 0, 0, 0, 0},
        {1.45, 0.93, 0.47, 0.24, 0, 0, 0, 0, 0},
        {1.65, 1.09, 0.55, 0.27, 0, 0, 0, 0, 0},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };

    public static double[,] UpfrontMortgageInterestRates_CONV15 = new double[11, 9] { { 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00 }, { 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00 }, { 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00 }, { 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00 }, { 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00 }, { 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00 }, { 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00 }, { 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00 }, { CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL }, { CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL }, { CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL } };
    public static double[,] MonthlyMortgageInterestRates_CONV15 = new double[11, 9] {
        {0.37, 0.28, 0.19, 0.17, 0, 0, 0, 0, 0},
        {0.5, 0.38, 0.21, 0.18, 0, 0, 0, 0, 0},
        {0.65, 0.45, 0.25, 0.19, 0, 0, 0, 0, 0},
        {0.77, 0.54, 0.28, 0.2, 0, 0, 0, 0, 0},
        {0.97, 0.65, 0.33, 0.2, 0, 0, 0, 0, 0},
        {1.3, 0.8, 0.42, 0.22, 0, 0, 0, 0, 0},
        {1.45, 0.93, 0.47, 0.24, 0, 0, 0, 0, 0},
        {1.65, 1.09, 0.55, 0.27, 0, 0, 0, 0, 0},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };

    public static double[,] UpfrontMortgageInterestRates_CONV10 = UpfrontMortgageInterestRates_CONV15;
    public static double[,] MonthlyMortgageInterestRates_CONV10 = new double[11, 9] {
        {0.37, 0.28, 0.19, 0.17, 0, 0, 0, 0, 0},
        {0.5, 0.38, 0.21, 0.18, 0, 0, 0, 0, 0},
        {0.65, 0.45, 0.25, 0.19, 0, 0, 0, 0, 0},
        {0.77, 0.54, 0.28, 0.2, 0, 0, 0, 0, 0},
        {0.97, 0.65, 0.33, 0.2, 0, 0, 0, 0, 0},
        {1.3, 0.8, 0.42, 0.22, 0, 0, 0, 0, 0},
        {1.45, 0.93, 0.47, 0.24, 0, 0, 0, 0, 0},
        {1.65, 1.09, 0.55, 0.27, 0, 0, 0, 0, 0},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };


}
