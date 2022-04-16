using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    internal abstract class MarketingExecutive : Employee   //it has become hirarchical inheritance now.one superclass 2 or more subclasses.
    {

        public abstract void ShowEmployeeName();
        private double KilometerTravel;
        private double TourAllowances;
        private double TelephoneAllowances = 1000;

        public void CalculateKilometerTravel(double KilometerTravel)
        {
            Console.WriteLine("Enter How many kilometers you have travelled recently");
            Console.ReadLine();
            this.KilometerTravel = KilometerTravel;

        }
        public void CalculateTourAllowances(double KilometerTravel)
        {
            this.KilometerTravel = KilometerTravel;
            TourAllowances = KilometerTravel * 5;
            Console.WriteLine("Here is the money accumulated as your Tour allowances {0} ", TourAllowances);

        }
        public override void CalculateSalary()
        {
            Employee emp = new Employee();
            Console.WriteLine("Overridden CalculateSalary method from Employee Class");
            emp.CalculateSalary();
        }


    }
}

