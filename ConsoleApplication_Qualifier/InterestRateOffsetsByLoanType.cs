﻿/// <summary>
/// Base Interest rates, depending on the loan type.
/// The base interest rate is later modified based on credit score and down payment.
/// </summary>
public class InterestRateOffsetsByLoanType
{
    public InterestRateOffsetsByLoanType()
    {
    }

    public const double CSTL = -9999;  // CREDIT SCORE TOO LOW

    public static double[,] InterestRateOffsetByCreditScoreAndDownPayment_FHA30 = new double[11, 9] {
        {-0.125,	-0.125,	-0.125,	-0.125,	-0.125,	-0.125,	-0.125,	-0.125,	-0.125},
        {-0.125,	-0.125,	-0.125,	-0.125,	-0.125,	-0.125,	-0.125,	-0.125,	-0.125},
        {-0.125,	-0.125,	-0.125,	-0.125,	-0.125,	-0.125,	-0.125,	-0.125,	-0.125},
        {0.0,	0.0,	0.0,	0.0,	0.0,	0.0,	0.0,	0.0,	0.0},
        {0.0,	0.0,	0.0,	0.0,	0.0,	0.0,	0.0,	0.0,	0.0},
        {+0.125,	+0.125,	+0.125,	+0.125,	+0.125,	+0.125,	+0.125,	+0.125,	+0.125},
        {+0.125,	+0.125,	+0.125,	+0.125,	+0.125,	+0.125,	+0.125,	+0.125,	+0.125},
        {0.375, 0.375, 0.375, 0.375, 0.375, 0.375, 0.375, 0.375, 0.375},
        {0.625, 0.625, 0.625, 0.625, 0.625, 0.625, 0.625, 0.625, 0.625},
        {0.75, 0.75, 0.75, 0.75, 0.75, 0.75, 0.75, 0.75, 0.75},
        {CSTL,  CSTL,  CSTL,  CSTL,  CSTL,  CSTL,  CSTL,  CSTL,  CSTL} };
    public static double[,] InterestRateOffsetByCreditScoreAndDownPayment_FHA25 = new double[11, 9] { 
        {-0.125,-0.125,-0.125,-0.125,-0.125,-0.125,-0.125,-0.125,-0.125},
        {-0.125,-0.125,-0.125,-0.125,-0.125,-0.125,-0.125,-0.125,-0.125},
        {-0.125,-0.125,-0.125,-0.125,-0.125,-0.125,-0.125,-0.125,-0.125},
        {0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0},
        {0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0},
        {0.125,0.125,0.125,0.125,0.125,0.125,0.125,0.125,0.125},
        {0.125,0.125,0.125,0.125,0.125,0.125,0.125,0.125,0.125},
        {0.375, 0.375, 0.375, 0.375, 0.375, 0.375, 0.375, 0.375, 0.375},
        {0.625, 0.625, 0.625, 0.625, 0.625, 0.625, 0.625, 0.625, 0.625},
        {0.75, 0.75, 0.75, 0.75, 0.75, 0.75, 0.75, 0.75, 0.75},
        {CSTL,  CSTL,  CSTL,  CSTL,  CSTL,  CSTL,  CSTL,  CSTL,  CSTL} };
    public static double[,] InterestRateOffsetByCreditScoreAndDownPayment_FHA20 = new double[11, 9] { 
        {-0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125},
        {-0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125},
        {-0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125},
        {0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0},
        {0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0},
        {0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125},
        {0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125},
        {0.625, 0.625, 0.625, 0.625, 0.625, 0.625, 0.625, 0.625, 0.625},
        {0.75, 0.75, 0.75, 0.75, 0.75, 0.75, 0.75, 0.75, 0.75},
        {0.875, 0.875, 0.875, 0.875, 0.875, 0.875, 0.875, 0.875, 0.875},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };
    public static double[,] InterestRateOffsetByCreditScoreAndDownPayment_FHA15 = new double[11, 9] {
        {-0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125},
        {-0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125},
        {-0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125},
        {0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0},
        {0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0},
        {0.25, 0.25, 0.25, 0.25, 0.25, 0.25, 0.25, 0.25, 0.25},
        {0.25, 0.25, 0.25, 0.25, 0.25, 0.25, 0.25, 0.25, 0.25},
        {0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5},
        {0.625, 0.625, 0.625, 0.625, 0.625, 0.625, 0.625, 0.625, 0.625},
        {0.875, 0.875, 0.875, 0.875, 0.875, 0.875, 0.875, 0.875, 0.875},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };
    public static double[,] InterestRateOffsetByCreditScoreAndDownPayment_FHA10 = new double[11, 9] {
        {-0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125},
        {-0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125},
        {-0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125},
        {0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0},
        {0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0},
        {0.25, 0.25, 0.25, 0.25, 0.25, 0.25, 0.25, 0.25, 0.25},
        {0.25, 0.25, 0.25, 0.25, 0.25, 0.25, 0.25, 0.25, 0.25},
        {0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5},
        {0.625, 0.625, 0.625, 0.625, 0.625, 0.625, 0.625, 0.625, 0.625},
        {0.875, 0.875, 0.875, 0.875, 0.875, 0.875, 0.875, 0.875, 0.875},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };
    public static double[,] InterestRateOffsetByCreditScoreAndDownPayment_VA30 = new double[11, 9] {
        {-0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125},
        {-0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125},
        {-0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125},
        {0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0},
        {0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0},
        {0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125},
        {0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125},
        {0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5},
        {0.625, 0.625, 0.625, 0.625, 0.625, 0.625, 0.625, 0.625, 0.625},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };
    public static double[,] InterestRateOffsetByCreditScoreAndDownPayment_VA25 = new double[11, 9] {
        {-0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125},
        {-0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125},
        {-0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125},
        {0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0},
        {0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0},
        {0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125},
        {0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125},
        {0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5},
        {0.625, 0.625, 0.625, 0.625, 0.625, 0.625, 0.625, 0.625, 0.625},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };
    public static double[,] InterestRateOffsetByCreditScoreAndDownPayment_VA20 = new double[11, 9] {
        {-0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125},
        {-0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125},
        {-0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125},
        {0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0},
        {0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0},
        {0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125},
        {0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125},
        {0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5},
        {0.625, 0.625, 0.625, 0.625, 0.625, 0.625, 0.625, 0.625, 0.625},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };
    public static double[,] InterestRateOffsetByCreditScoreAndDownPayment_VA15 = new double[11, 9] {
        {-0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125},
        {-0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125},
        {-0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125},
        {0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0},
        {0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0},
        {0.25, 0.25, 0.25, 0.25, 0.25, 0.25, 0.25, 0.25, 0.25},
        {0.25, 0.25, 0.25, 0.25, 0.25, 0.25, 0.25, 0.25, 0.25},
        {0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5},
        {0.625, 0.625, 0.625, 0.625, 0.625, 0.625, 0.625, 0.625, 0.625},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };
    public static double[,] InterestRateOffsetByCreditScoreAndDownPayment_VA10 = new double[11, 9] {
        {-0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125},
        {-0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125},
        {-0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125},
        {0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0},
        {0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0},
        {0.25, 0.25, 0.25, 0.25, 0.25, 0.25, 0.25, 0.25, 0.25},
        {0.25, 0.25, 0.25, 0.25, 0.25, 0.25, 0.25, 0.25, 0.25},
        {0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5},
        {0.625, 0.625, 0.625, 0.625, 0.625, 0.625, 0.625, 0.625, 0.625},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };
    public static double[,] InterestRateOffsetByCreditScoreAndDownPayment_USDA30 = new double[11, 9] {
        {-0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125},
        {-0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125},
        {-0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125, -0.125},
        {0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0},
        {0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0},
        {0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125},
        {0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };
    public static double[,] InterestRateOffsetByCreditScoreAndDownPayment_CONV30 = new double[11, 9] {
        {0.25, 0.125, 0.125, 0.125, 0.125, 0, 0, 0, 0},
        {0.25, 0.125, 0.125, 0.125, 0.125, 0, 0, 0, 0},
        {0.25, 0.125, 0.125, 0.125, 0.125, 0.125, 0, 0, 0},
        {0.25, 0.25, 0.25, 0.25, 0.25, 0.25, 0.125, 0.125, 0},
        {0.25, 0.25, 0.25, 0.375, 0.375, 0.25, 0.125, 0.125, 0},
        {0.5, 0.5, 0.5, 0.625, 0.625, 0.5, 0.25, 0.25, 0},
        {0.625, 0.625, 0.625, 0.75, 0.75, 0.625, 0.25, 0.25, 0.125},
        {0.75, 0.75, 0.75, 0.75, 0.75, 0.75, 0.375, 0.375, 0.125},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };
    public static double[,] InterestRateOffsetByCreditScoreAndDownPayment_CONV25 = new double[11, 9] {
        {0.25, 0.125, 0.125, 0.125, 0.125, 0, 0, 0, 0},
        {0.25, 0.125, 0.125, 0.125, 0.125, 0, 0, 0, 0},
        {0.375, 0.125, 0.125, 0.125, 0.125, 0.125, 0, 0, 0},
        {0.375, 0.25, 0.25, 0.25, 0.375, 0.25, 0.125, 0.125, 0},
        {0.375, 0.25, 0.25, 0.5, 0.5, 0.25, 0.125, 0.125, 0},
        {0.5, 0.5, 0.5, 0.625, 0.625, 0.5, 0.25, 0.25, 0},
        {0.5, 0.625, 0.625, 0.75, 0.75, 0.625, 0.25, 0.25, 0.125},
        {0.625, 0.75, 0.75, 0.75, 0.75, 0.75, 0.375, 0.375, 0.125},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };
    public static double[,] InterestRateOffsetByCreditScoreAndDownPayment_CONV20 = new double[11, 9] {
        {0.25, 0.125, 0.125, 0.125, 0.125, 0, 0, 0, 0},
        {0.25, 0.125, 0.125, 0.125, 0.125, 0, 0, 0, 0},
        {0.375, 0.25, 0.25, 0.25, 0.25, 0.125, 0, 0, 0},
        {0.375, 0.375, 0.375, 0.375, 0.375, 0.25, 0.125, 0.125, 0},
        {0.375, 0.375, 0.375, 0.375, 0.375, 0.25, 0.125, 0.125, 0},
        {0.5, 0.5, 0.5, 0.5, 0.5, 0.375, 0.25, 0.25, 0},
        {0.625, 0.625, 0.625, 0.625, 0.625, 0.5, 0.25, 0.25, 0.125},
        {0.75, 0.625, 0.625, 0.625, 0.625, 0.625, 0.375, 0.375, 0.25},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };
    public static double[,] InterestRateOffsetByCreditScoreAndDownPayment_CONV15 = new double[11, 9] {
        {0.25, 0, 0, 0, 0, 0, 0, 0, 0},
        {0.25, 0, 0, 0, 0, 0, 0, 0, 0},
        {0.25, 0, 0, 0, 0, 0, 0, 0, 0},
        {0.25, 0, 0, 0, 0, 0, 0, 0, 0},
        {0.25, 0, 0, 0, 0, 0, 0, 0, 0},
        {0.375, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125},
        {0.375, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125},
        {0.375, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };
    public static double[,] InterestRateOffsetByCreditScoreAndDownPayment_CONV10 = new double[11, 9] {
        {0.25, 0, 0, 0, 0, 0, 0, 0, 0},
        {0.25, 0, 0, 0, 0, 0, 0, 0, 0},
        {0.375, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125},
        {0.375, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125},
        {0.375, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125},
        {0.375, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125},
        {0.375, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125},
        {0.375, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL},
        {CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL, CSTL} };

}
