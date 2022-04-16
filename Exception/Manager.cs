using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class Program
    {

        internal abstract class Manager : Employee //if a class contains atleast one abstract method then class should be declared as abstract.
        {

            public abstract string Name { get; }  //---> abstract method 
            Employee employee = new Employee();

            private double PetrolAllowance;
            private double FoodAllowance;
            private double OtherAllowances;
            
                private void CalculatePetrolAllownace(double Salary)
                {
                    this.Salary = Salary;
                    PetrolAllowance = (8 / Salary) * 100;
                    Console.WriteLine("Petrol allowances {0}", PetrolAllowance);
                }
                private void CalculateFoodAllowance(double Salary)
                {
                    this.Salary = Salary;
                    FoodAllowance = (13 / Salary) * 100;
                    Console.WriteLine("food allowance {0}", FoodAllowance);
                }
                private void CalculateOtherAllowances(double Salary)
                {
                    this.Salary = Salary;
                    OtherAllowances = (3 / Salary) * 100;
                    Console.WriteLine("Other Allowances {0}", OtherAllowances);

                }

            /*public double HRA { get; }                //how to add OtherAllowances to Grosssalary which contains private members.
       public override void MethodForGrossSalary()
       {
           Employee employee = new Employee();

       }*/
            public override void CalculateSalary()
            {
                Employee emp = new Employee();
                Console.WriteLine("Overridden CalculateSalary method from Employee Class");
                emp.CalculateSalary();
            }


        }
    
        }
    }

