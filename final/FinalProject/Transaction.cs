using System;

public class Transaction
{
    private double _amount;
    private String _description;
    private String _category;
    private DateTime _date;
    private String _transactionId; //date.ToString("Mddyyyyhmm");

    public Transaction(double amount, string description, String category)
    {
        _amount = amount;
        _description = description;
        _category = category;
        _date = DateTime.Now;
        _transactionId = _date.ToString("Mddyyyyhmm");
    }
    public Transaction(double amount, string description, String category, int monthNum, int dayNum, int yearNum)
    {
        _amount = amount;
        _description = description;
        _category = category;
        DateTime today = DateTime.Now;
        int hourAndMin = int.Parse(today.ToString("hmm"));
        _date = new DateTime(yearNum, monthNum, dayNum);
        _transactionId = _date.ToString("Mddyyyy"+hourAndMin);
    }

    public override String ToString()
    {
        return $"${_amount}-{_description}-{_category}-{_date}-{_transactionId}";
    }
}