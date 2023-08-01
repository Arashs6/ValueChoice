namespace ValueChoice.Shared.Models;

public class Candidate
{
    public Candidate(long id, Income income, byte age, Gender gender, bool isMarried, byte numberOfHouseholds, bool alreadyBuyAHouse, decimal saving, decimal amountWantToSave)
    {
        Id = id;
        Income = income;
        Age = age;
        Gender = gender;
        IsMarried = isMarried;
        NumberOfHouseholds = numberOfHouseholds;
        AlreadyBuyAHouse = alreadyBuyAHouse;
        Saving = saving;
        AmountWantToSave = amountWantToSave;

        //todo: publish an event
    }
    public long Id { get; private set; }
    public Income Income { get; private set; }
    public byte Age { get; private set; }
    public Gender Gender { get; private set; }
    public bool IsMarried { get; private set; }
    public byte NumberOfHouseholds { get; private set; }
    public bool AlreadyBuyAHouse { get; private set; }
    public decimal Saving { get; private set; }
    public decimal AmountWantToSave { get; private set; }
}