namespace ValueChoice.Shared.Models;

public abstract class Cost
{
    protected Cost(decimal? rent, decimal? apartmentCharge, decimal? hobby, decimal? college, decimal? medical, decimal? loan)
    {
        Rent = rent;
        ApartmentCharge = apartmentCharge;
        Hobby = hobby;
        College = college;
        Medical = medical;
        Loan = loan;

        //todo: publish event
    }

    public decimal? Rent { get;private set; }
    public decimal? ApartmentCharge { get; private set; }
    public decimal? Hobby { get; private set; }
    public decimal? College { get; private set; }
    public decimal? Medical { get; private set; }
    public decimal? Loan { get; private set; }
}