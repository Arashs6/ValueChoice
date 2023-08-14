using FluentAssertions;
using ValueChoice.Shared.Models;

namespace ValueChoice.Domain.Tests
{
    public class ReportGeneratorTests
    {
        [Fact]
        public void candidate_create_properly()
        {
            var income = new Income(new Money() { Amount = 7000000 });
            var saving = new Money() { Amount = 40000000 };
            var amountWantToSave = new Money() { Amount = 1000000 };
            const byte age = 33;
            var candidate =
                new Candidate(income, age, Gender.Male, false, null, true, saving, amountWantToSave, null);

            candidate.Income.Should().Be(income);
            candidate.Age.Should().Be(age);
            candidate.AlreadyBuyAHouse.Should().BeTrue();
            candidate.AmountWantToSave.Should().Be(amountWantToSave);
            candidate.Gender.Should().Be(Gender.Male);
            candidate.IsMarried.Should().BeFalse();
            candidate.NumberOfHouseholds.Should().BeNull();
            candidate.Rent.Should().BeNull();
        }

        [Fact]
        public void person_that_is_not_married_does_not_has_household_ember()
        {
            var income = new Income(new Money() { Amount = 7000000 });
            var saving = new Money() { Amount = 40000000 };
            var amountWantToSave = new Money() { Amount = 1000000 };
            const byte age = 33;
           
            var action = () =>
                new Candidate(income, age, Gender.Male, isMarried: false,numberOfHouseholds:3, true, saving, amountWantToSave, null);

            action.Should().Throw<Exception>().WithMessage("برای شخص مجرد وارد کردن تعداد فرد خانواده مجاز نیست.");

        }

        [Fact]
        public void person_who_has_a_house_can_not_pay_rent()
        {
           var candidate = new CandidateTestBuilder().HasAHousefasle)
            Action candidate = () =>
                new Candidate(income, age, Gender.Male, false, null, true, saving, amountWantToSave, rent);

            candidate.Should().Throw<Exception>().WithMessage("شخصی که خانه دارد اجاره پرداخت نمی کند.");
        }

        
    }
}