
public class Invoice
{
    public decimal Amount { get; private set; }
    public decimal Taxes { get; private set; }
    public decimal NetAmount { get; private set; }

    public Invoice() { }

    public void setAmount(decimal amount)
    {
        Amount = amount;
    }
}