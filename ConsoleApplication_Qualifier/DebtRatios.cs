﻿/// <summary>
/// The Max Payment is based on monthly income vs. monthly debt.
///   "This is the max you can afford on a loan"
///   Note that the ratios are the actual numbers, not offsets.
///   Note the ratios are in decimal format and not percentages  (Ex: .36 and not 36%)
/// </summary>
/// 
public class DebtRatios
{
    public DebtRatios()
    {
        // TODO: Add constructor logic here
    }

    public const double CSTL = -9999;  // CREDIT SCORE TOO LOW

    public double[,] DebtRatio_House_FHA30 = new double[11, 9] {
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.31, .31, .31, .31, .31, .31, .31, .31, .31},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };
    public double[,] DebtRatio_Total_FHA30 = new double[11, 9] {
{0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52},
{0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52},
{0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52},
{0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52},
{0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5},
{0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45},
{0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45},
{0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43},
{0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43},
{0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };

    public double[,] DebtRatio_House_FHA25 = new double[11, 9] {
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.31, .31, .31, .31, .31, .31, .31, .31, .31},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };
    public double[,] DebtRatio_Total_FHA25 = new double[11, 9] {
{0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52},
{0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52},
{0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52},
{0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52},
{0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5},
{0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45},
{0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45},
{0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43},
{0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43},
{0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };

    public double[,] DebtRatio_House_FHA20 = new double[11, 9] {
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.31, .31, .31, .31, .31, .31, .31, .31, .31},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };
    public double[,] DebtRatio_Total_FHA20 = new double[11, 9] {
{0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52},
{0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52},
{0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52},
{0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52},
{0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5},
{0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45},
{0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45},
{0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43},
{0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43},
{0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };

    public double[,] DebtRatio_House_FHA15 = new double[11, 9] {
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.31, .31, .31, .31, .31, .31, .31, .31, .31},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };
    public double[,] DebtRatio_Total_FHA15 = new double[11, 9] {
{0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52},
{0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52},
{0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52},
{0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52},
{0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5},
{0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45},
{0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45},
{0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43},
{0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43},
{0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };

    public double[,] DebtRatio_House_FHA10 = new double[11, 9] {
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.31, .31, .31, .31, .31, .31, .31, .31, .31},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };
    public double[,] DebtRatio_Total_FHA10 = new double[11, 9] {
{0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52},
{0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52},
{0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52},
{0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52, 0.52},
{0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5},
{0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45},
{0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45, 0.45},
{0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43},
{0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43},
{0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43, 0.43},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };

    public double[,] DebtRatio_House_VA30 = new double[11, 9] {
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };
    public double[,] DebtRatio_Total_VA30 = new double[11, 9] {
{.50, .50, .50, .50, .50, .50, .50, .50, .50},
{.50, .50, .50, .50, .50, .50, .50, .50, .50},
{.50, .50, .50, .50, .50, .50, .50, .50, .50},
{.45, .45, .50, .50, .50, .50, .50, .50, .50},
{.45, .45, .50, .50, .50, .50, .50, .50, .50},
{.45, .45, .45, .45, .45, .45, .45, .45, .45},
{.45, .45, .45, .45, .45, .45, .45, .45, .45},
{.43, .43, .43, .43, .43, .43, .43, .43, .43},
{.43, .43, .43, .43, .43, .43, .43, .43, .43},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };

    public double[,] DebtRatio_House_VA25 = new double[11, 9] {
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };
    public double[,] DebtRatio_Total_VA25 = new double[11, 9] {
{.50, .50, .50, .50, .50, .50, .50, .50, .50},
{.50, .50, .50, .50, .50, .50, .50, .50, .50},
{.50, .50, .50, .50, .50, .50, .50, .50, .50},
{.45, .45, .50, .50, .50, .50, .50, .50, .50},
{.45, .45, .50, .50, .50, .50, .50, .50, .50},
{.45, .45, .45, .45, .45, .45, .45, .45, .45},
{.45, .45, .45, .45, .45, .45, .45, .45, .45},
{.43, .43, .43, .43, .43, .43, .43, .43, .43},
{.43, .43, .43, .43, .43, .43, .43, .43, .43},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };

    public double[,] DebtRatio_House_VA20 = new double[11, 9] {
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };
    public double[,] DebtRatio_Total_VA20 = new double[11, 9] {
{.50, .50, .50, .50, .50, .50, .50, .50, .50},
{.50, .50, .50, .50, .50, .50, .50, .50, .50},
{.50, .50, .50, .50, .50, .50, .50, .50, .50},
{.45, .45, .50, .50, .50, .50, .50, .50, .50},
{.45, .45, .50, .50, .50, .50, .50, .50, .50},
{.45, .45, .45, .45, .45, .45, .45, .45, .45},
{.45, .45, .45, .45, .45, .45, .45, .45, .45},
{.43, .43, .43, .43, .43, .43, .43, .43, .43},
{.43, .43, .43, .43, .43, .43, .43, .43, .43},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL}};

    public double[,] DebtRatio_House_VA15 = new double[11, 9] {
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };
    public double[,] DebtRatio_Total_VA15 = new double[11, 9] {
{.50, .50, .50, .50, .50, .50, .50, .50, .50},
{.50, .50, .50, .50, .50, .50, .50, .50, .50},
{.50, .50, .50, .50, .50, .50, .50, .50, .50},
{.45, .45, .50, .50, .50, .50, .50, .50, .50},
{.45, .45, .50, .50, .50, .50, .50, .50, .50},
{.45, .45, .45, .45, .45, .45, .45, .45, .45},
{.45, .45, .45, .45, .45, .45, .45, .45, .45},
{.43, .43, .43, .43, .43, .43, .43, .43, .43},
{.43, .43, .43, .43, .43, .43, .43, .43, .43},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL}};

    public double[,] DebtRatio_House_VA10 = new double[11, 9] {
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };
    public double[,] DebtRatio_Total_VA10 = new double[11, 9] {
{.50, .50, .50, .50, .50, .50, .50, .50, .50},
{.50, .50, .50, .50, .50, .50, .50, .50, .50},
{.50, .50, .50, .50, .50, .50, .50, .50, .50},
{.45, .45, .50, .50, .50, .50, .50, .50, .50},
{.45, .45, .50, .50, .50, .50, .50, .50, .50},
{.45, .45, .45, .45, .45, .45, .45, .45, .45},
{.45, .45, .45, .45, .45, .45, .45, .45, .45},
{.43, .43, .43, .43, .43, .43, .43, .43, .43},
{.43, .43, .43, .43, .43, .43, .43, .43, .43},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL}};

    public double[,] DebtRatio_House_USDA30 = new double[11, 9] {
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };
    public double[,] DebtRatio_Total_USDA30 = new double[11, 9] {
{.45, .50, .50, .50, .50, .50, .50, .50, .50},
{.45, .50, .50, .50, .50, .50, .50, .50, .50},
{.45, .50, .50, .50, .50, .50, .50, .50, .50},
{.45, .45, .50, .50, .50, .50, .50, .50, .50},
{.45, .45, .50, .50, .50, .50, .50, .50, .50},
{.45, .45, .45, .45, .45, .45, .45, .45, .45},
{.45, .45, .45, .45, .45, .45, .45, .45, .45},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };

//USDA 15 Year - No Program

    public double[,] DebtRatio_House_CONV30 = new double[11, 9] {
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .36, .36, .38, .38, .38, .38, .38},
{.36, .36, .36, .36, .38, .38, .38, .38, .38},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };
    public double[,] DebtRatio_Total_CONV30 = new double[11, 9] {
{.45, .45, .45, .45, .50, .50, .50, .50, .50},
{.45, .45, .45, .45, .50, .50, .50, .50, .50},
{.45, .45, .45, .45, .50, .50, .50, .50, .50},
{.45, .45, .45, .45, .50, .50, .50, .50, .50},
{.45, .45, .45, .45, .50, .50, .50, .50, .50},
{.45, .45, .45, .45, .45, .45, .45, .45, .45},
{.45, .45, .45, .45, .45, .45, .45, .45, .45},
{.45, .45, .45, .45, .45, .45, .45, .45, .45},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };

    public double[,] DebtRatio_House_CONV25 = new double[11, 9] {
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .36, .36, .38, .38, .38, .38, .38},
{.36, .36, .36, .36, .38, .38, .38, .38, .38},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };
    public double[,] DebtRatio_Total_CONV25 = new double[11, 9] {
{.45, .45, .45, .45, .50, .50, .50, .50, .50},
{.45, .45, .45, .45, .50, .50, .50, .50, .50},
{.45, .45, .45, .45, .50, .50, .50, .50, .50},
{.45, .45, .45, .45, .50, .50, .50, .50, .50},
{.45, .45, .45, .45, .50, .50, .50, .50, .50},
{.45, .45, .45, .45, .45, .45, .45, .45, .45},
{.45, .45, .45, .45, .45, .45, .45, .45, .45},
{.45, .45, .45, .45, .45, .45, .45, .45, .45},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };

    public double[,] DebtRatio_House_CONV20 = new double[11, 9] {
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .36, .36, .38, .38, .38, .38, .38},
{.36, .36, .36, .36, .38, .38, .38, .38, .38},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };
    public double[,] DebtRatio_Total_CONV20 = new double[11, 9] {
{.45, .45, .45, .45, .50, .50, .50, .50, .50},
{.45, .45, .45, .45, .50, .50, .50, .50, .50},
{.45, .45, .45, .45, .50, .50, .50, .50, .50},
{.45, .45, .45, .45, .50, .50, .50, .50, .50},
{.45, .45, .45, .45, .50, .50, .50, .50, .50},
{.45, .45, .45, .45, .45, .45, .45, .45, .45},
{.45, .45, .45, .45, .45, .45, .45, .45, .45},
{.45, .45, .45, .45, .45, .45, .45, .45, .45},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };

    public double[,] DebtRatio_House_CONV15 = new double[11, 9] {
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .36, .36, .38, .38, .38, .38, .38},
{.36, .36, .36, .36, .38, .38, .38, .38, .38},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };
    public double[,] DebtRatio_Total_CONV15 = new double[11, 9] {
 {.45, .45, .45, .45, .50, .50, .50, .50, .50},
{.45, .45, .45, .45, .50, .50, .50, .50, .50},
{.45, .45, .45, .45, .50, .50, .50, .50, .50},
{.45, .45, .45, .45, .50, .50, .50, .50, .50},
{.45, .45, .45, .45, .50, .50, .50, .50, .50},
{.45, .45, .45, .45, .45, .45, .45, .45, .45},
{.45, .45, .45, .45, .45, .45, .45, .45, .45},
{.45, .45, .45, .45, .45, .45, .45, .45, .45},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };

    public double[,] DebtRatio_House_CONV10 = new double[11, 9] {
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .38, .38, .38, .38, .38, .38, .38},
{.36, .36, .36, .36, .38, .38, .38, .38, .38},
{.36, .36, .36, .36, .38, .38, .38, .38, .38},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{.36, .36, .36, .36, .36, .36, .36, .36, .36},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };
    public double[,] DebtRatio_Total_CONV10 = new double[11, 9] {
{.45, .50, .50, .50, .50, .50, .50, .50, .50},
{.45, .50, .50, .50, .50, .50, .50, .50, .50},
{.45, .45, .45, .45, .50, .50, .50, .50, .50},
{.45, .45, .45, .45, .50, .50, .50, .50, .50},
{.45, .45, .45, .45, .50, .50, .50, .50, .50},
{.45, .45, .45, .45, .45, .45, .45, .45, .45},
{.45, .45, .45, .45, .45, .45, .45, .45, .45},
{.45, .45, .45, .45, .45, .45, .45, .45, .45},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
{CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };

}

