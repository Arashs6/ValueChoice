using FluentAssertions;
using ValueChoice.Shared.Models;

namespace ValueChoice.Domain.Tests
{
    public class ReportGeneratorTests
    {
        [Fact]
        public void candidate_create_properly()
        {
            var income = 40000;
            var amountWantToSave = 3000M;
            byte age = 33;
            var candidate = new CandidateTestBuilder()
                .WithIncome(income)
                .WithAge(age)
                .WithAmounWantToSave(amountWantToSave)
                .HasAHouse(true).Build();

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
            var action = () =>
                new CandidateTestBuilder().HasMarried(false).WithNumberOfHouseHolds(3).Build();

            action.Should().Throw<Exception>().WithMessage("برای شخص مجرد وارد کردن تعداد فرد خانواده مجاز نیست.");

        }

        [Fact]
        public void person_who_has_a_house_can_not_pay_rent()
        {
            Action candidate = () => new CandidateTestBuilder().HasAHouse(true).WithRent(4000).Build();


            candidate.Should().Throw<Exception>().WithMessage("شخصی که خانه دارد اجاره پرداخت نمی کند.");
        }

        [Fact]
        public void report_generator_generate_report_when_data_is_import()
        {
            var moneyWantToSpend = 14000000M;
            var candidate = new CandidateTestBuilder().WithIncome(7000000).Build();
            var report = new ReportGenerator();

            var result =  report.CalculateReport(moneyWantToSpend,candidate);

            result.HourOfWorkLose.Should().Be(332);
        }
        
        
    }
}