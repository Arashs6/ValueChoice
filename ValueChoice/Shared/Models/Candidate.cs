namespace ValueChoice.Shared.Models;

public class Candidate
{
    public Candidate(decimal income, byte age, Gender gender, bool isMarried, byte? numberOfHouseholds, bool alreadyBuyAHouse, decimal? saving, decimal? amountWantToSave,decimal? rent)
    {
        if (isMarried is false && numberOfHouseholds.HasValue)
        {
            throw new Exception("برای شخص مجرد وارد کردن تعداد فرد خانواده مجاز نیست.");
        }

        if (alreadyBuyAHouse && rent.HasValue)
        {
            throw new Exception("شخصی که خانه دارد اجاره پرداخت نمی کند.");
        }
        Income = income;
        Age = age;
        Gender = gender;
        IsMarried = isMarried;
        NumberOfHouseholds = numberOfHouseholds;
        AlreadyBuyAHouse = alreadyBuyAHouse;
        Rent = rent;
        Saving = saving;
        AmountWantToSave = amountWantToSave;

        //todo: publish an event
    }

    public decimal? Rent { get;private set; }

    public long Id { get; private set; }
    public decimal Income { get; private set; }
    public byte Age { get; private set; }
    public Gender Gender { get; private set; }
    public bool IsMarried { get; private set; }
    public byte? NumberOfHouseholds { get; private set; }
    public bool AlreadyBuyAHouse { get; private set; }
    public decimal? Saving { get; private set; }
    public decimal? AmountWantToSave { get; private set; }

    

}