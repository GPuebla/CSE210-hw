using System;

public class Income : Transaction
{
    public Income(double amount, string description, string category) : base(amount, description, category)
    {
    }

    public Income(double amount, string description, string category, int monthNum, int dayNum, int yearNum) : base(amount, description, category, monthNum, dayNum, yearNum)
    {
    }
}