using System;
public class ContractEmployee:EmployeeRecord
{
    public double HourlyRate{get; set;}
    public override double GetMonthlyPay()
    {
        double totalhours=0;
        for(int i=0;i<WeeklyHours.Length;i++)
        {
            totalhours+=WeeklyHours[i];
        }
        return totalhours*HourlyRate;
    }
}
































