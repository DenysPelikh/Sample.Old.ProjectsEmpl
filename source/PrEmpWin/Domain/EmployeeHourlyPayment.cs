﻿namespace PrEmpWin.Domain
{
    public class EmployeeHourlyPayment : EmployeeBase
    {
        public double HourlyRate { get; set; }

        public EmployeeHourlyPayment() { }

        public EmployeeHourlyPayment(int employeeId, string employeeName, double hourlyRate)
            : base(employeeId, employeeName)
        {
            HourlyRate = hourlyRate;
        }

        public override double GetAverageMonthlySalary()
        {
            return HourlyRate * (20.8 * 8);
        }
    }
}
