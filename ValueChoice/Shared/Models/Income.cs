namespace ValueChoice.Shared.Models;

public class Income
{
    public Income(Money money)
    {
        this.Money = money;
    }
    public Money Money { get;private set; }
}