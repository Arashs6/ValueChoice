using System.Security.Cryptography.X509Certificates;

namespace ValueChoice.Shared.Models;

public class ReportGenerator
{
    public Report CalculateReport(decimal input,Candidate candidate)
    {
        var report = new Report();
        report.HourOfWorkLose = new WorkLoseCalculator().Calculate(candidate.Income,input);

        return report;
    }

    public class WorkLoseCalculator : ICalculator<decimal>
    {
        public decimal Calculate(decimal input1, decimal input2)
        {
            return input2 / (input1 / 166) ;
        }
    }

    public interface ICalculator<T>
    {
         T Calculate(T input1, T input2);

    }
}

