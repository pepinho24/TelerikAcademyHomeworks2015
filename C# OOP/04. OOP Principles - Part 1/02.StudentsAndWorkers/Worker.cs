//Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. 
namespace _02.StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set { this.weekSalary = value; }
        }

        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set { this.workHoursPerDay = value; }
        }

        public decimal MoneyPerHour(int workDaysAWeekCount = 5)
        {
            if (workDaysAWeekCount < 0 || workDaysAWeekCount > 7)
            {
                throw new ArgumentOutOfRangeException("Workdays cannot be less than 0 and more than 7!");
            }

            int workHoursPerWeek = this.WorkHoursPerDay * workDaysAWeekCount;
            decimal moneyPerHour = this.WeekSalary / workHoursPerWeek;

            return moneyPerHour;
        }

        public override string ToString()
        {
            return string.Format("{0}, WeekSalary: {1:0.00}, Work hours per day: {2}, Money per hour: {3:0.00}", base.ToString(), this.WeekSalary, this.WorkHoursPerDay, this.MoneyPerHour());
        }
    }
}
