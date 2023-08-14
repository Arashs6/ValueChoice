using ValueChoice.Shared.Models;

namespace ValueChoice.Domain.Tests;

public class CandidateTestBuilder
{

    public Candidate Build()
    {
        return new Candidate(Income, Age, Gender, IsMarried, NumberOfHouseholds, AlreadyBuyAHouse, Saving, AmountWantToSave, Rent);
    }



    public long Id = 2;
    public decimal Income = 20000000;
    public byte Age = 33;
    public Gender Gender = Gender.Male;
    public bool IsMarried = false;
    public byte? NumberOfHouseholds = null;
    public bool AlreadyBuyAHouse = false;
    public decimal? Saving = 40000000;
    public decimal? AmountWantToSave = 1000000;
    public decimal? Rent = null;

    public CandidateTestBuilder HasAHouse(bool hasAHouse)
    {
        this.AlreadyBuyAHouse = hasAHouse;
        return this;
    }

    public CandidateTestBuilder WithRent(decimal rent)
    {
        this.Rent = rent;

        return this;
    }

    public CandidateTestBuilder HasMarried(bool hasMarried)
    {
        this.IsMarried = hasMarried;

        return this;
    }

    public CandidateTestBuilder WithNumberOfHouseHolds(byte? noOfHouseHold)
    {
        this.NumberOfHouseholds = noOfHouseHold;

        return this;
    }

    public CandidateTestBuilder WithIncome(decimal income)
    {
        this.Income = income;

        return this;
    }

    public CandidateTestBuilder WithAge(byte age)
    {
        this.Age = age;

        return this;
    }

    public CandidateTestBuilder WithAmounWantToSave(decimal amountWantToSave)
    {
        this.AmountWantToSave = amountWantToSave;

        return this;
    }
}