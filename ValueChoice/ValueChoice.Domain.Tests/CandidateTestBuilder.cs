using ValueChoice.Shared.Models;

namespace ValueChoice.Domain.Tests;

public class CandidateTestBuilder
{

    public Candidate Build()
    {
        return new Candidate(Income,);
    }


    public Money? Rent = null;

    public long Id = 2;
    public Income Income = new Income(new Money() { Amount = 7000000 });
    public byte Age = 33;
    public Gender Gender = Gender.Male;
    public bool IsMarried = false;
    public byte? NumberOfHouseholds = null;
    public bool AlreadyBuyAHouse = false;
    public decimal? Saving = 40000000;
    public decimal? AmountWantToSave = 1000000;
}