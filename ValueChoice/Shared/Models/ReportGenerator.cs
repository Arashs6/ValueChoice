using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ValueChoice.Shared.Models;

public class ReportGenerator
{
    public Report CalculateReport(decimal input,Candidate candidate)
    {
        var report = new Report();
        report.HourOfWorkLose = new WorkLoseCalculator().Calculate(candidate.Income,input);

        if (candidate.Rent.HasValue)
        {
            report.MissingRentPayment = new MissingRentCalculator().Calculate(candidate.Rent.Value, input);
        }

        return report;
    }

    public class MissingRentCalculator : ICalculator<Decimal, string>
    {
        public string Calculate(decimal input1, decimal input2)
        {
            var stringBuilder = new StringBuilder();
            var rentInDayMiss = (input2 * 30) / input1;
            var month = rentInDayMiss/30;
            if (month < 1)
            {
                return stringBuilder.Append($"{decimal.Truncate(rentInDayMiss) + 1 } روز").ToString();
            }

            if (month % 1 == 0)
            {
                return stringBuilder.Append($"{month} ماه").ToString();
            }

            return stringBuilder.Append($"{decimal.Truncate(month)} ماه و {rentInDayMiss - decimal.Truncate(month)*30} روز").ToString();
        }
    }





    public class WorkLoseCalculator : ICalculator<decimal,decimal>
    {
        public decimal Calculate(decimal input1, decimal input2)
        {
            return input2 / (input1 / 166) ;
        }
    }

    public interface ICalculator<TInput, out TOutput>
    {
         TOutput Calculate(TInput input1, TInput input2);

    }
}

public class RentReport
{
    public byte Month { get; set; }
    public int Day { get; set; }
}

