using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    internal class Employee
    {
        private int EmpNo;       //non-static - global vars
        private String EmpName;
        public double Salary;    //private members cannot be accesesd by other class
        private double HRA;
        private double TA;
        private double DA;
        private double PF;
        private double TDS;
        private double NetSalary;
        public double GrossSalary;

        /*public Employee(int EmpNo, String EmpName, double Salary)
        {
            this.EmpNo = EmpNo;
            this.EmpName = EmpName; 
            this.Salary = Salary;
            //Console.WriteLine("Enter your Employee Number/Emp ID");
            //Console.ReadLine();
        }*/
        public Employee()  //Zero argument constructor for future reference
        {

        }

        public int EmployeeNumber { get; set; }
        public String EmployeeName { get; set; }
        public double EmployeeSalary { get; set; }


        public void Method1(int EmpNo)
        {
            Console.WriteLine("Enter your Employee Number");
            Console.ReadLine();
            if (EmpNo == 101)
            {
                this.EmpNo = EmpNo;
            }
            else
            {
                Console.WriteLine("Invalid Employee Number/ EmpNo Does not exists in the database..");
            }

        }
        public void Method2(String EmpName)
        {
            Console.WriteLine("Enter your Employee Name");
            Console.ReadLine();
            if (EmpName == "kishan kumar")
            {
                this.EmpName = EmpName;
            }
            else
            {
                Console.WriteLine("Invalid Emloyee Name");
            }
        }
        public void Method3()
        {
            Console.WriteLine("Enter your Employee Salary");
            Console.ReadLine();
            MethodforHRA(5000);              //calling non-static methods inside non- static method--> just by calling its member name
            MethodForGrossSalary();      //calling non-static methods inside non- static method--> just by calling its member name
            CalculateSalary();           //calling non-static methods inside non- static method--> just by calling its member name

            /*if(Salary == 25000)
            {
                this.Salary = Salary;
            }
            else if(Salary <= 25000)
            {
                Console.WriteLine("Mention Exact salary for Employee Kishan kumar ");
            }
            else if(Salary >= 25000)
            {
                Console.WriteLine("Mention Exact salary for Employee Kishan kumar ");
            }
            else
            {
                Console.WriteLine("Invalid Salary Numbers, Please Enter Valid Salary details");
            }*/
        }
        public void MethodforHRA(double Salary)
        {
            //Manager.manager = new Manager();
            this.Salary = Salary;
            if (Salary < 5000)
            {
                HRA = (10 / Salary) * 100;
                Console.WriteLine(HRA);
                TA = (5 / Salary) * 100;
                Console.WriteLine(TA);
                DA = (15 / Salary) * 100;
                Console.WriteLine(DA);

            }
            if (Salary < 10000)
            {
                HRA = (15 / Salary) * 100;
                Console.WriteLine(HRA);
                TA = (10 / Salary) * 100;
                Console.WriteLine(TA);
                DA = (20 / Salary) * 100;
                Console.WriteLine(DA);
            }
            if (Salary < 15000)
            {
                HRA = (20 / Salary) * 100;
                Console.WriteLine(HRA);
                TA = (15 / Salary) * 100;
                Console.WriteLine(TA);
                DA = (25 / Salary) * 100;
                Console.WriteLine(DA);
            }
            if (Salary < 20000)
            {
                HRA = (25 / Salary) * 100;
                Console.WriteLine(HRA);
                TA = (20 / Salary) * 100;
                Console.WriteLine(TA);
                DA = (30 / Salary) * 100;
                Console.WriteLine(DA);
            }
            if (Salary >= 20000)
            {
                HRA = (30 / Salary) * 100;
                Console.WriteLine(HRA);
                TA = (25 / Salary) * 100;
                Console.WriteLine(TA);
                DA = (35 / Salary) * 100;
                Console.WriteLine(DA);
            }
            else
            {
                Console.WriteLine("Invalid Salary Numbers");
            }
        }

        public virtual void MethodForGrossSalary()
        {
            Console.WriteLine("Your Gross Salary will be replicated like this");
            GrossSalary = Salary + HRA + TA + DA;
            Console.WriteLine(GrossSalary);
        }
        public virtual void CalculateSalary()
        {
            PF = (10 / GrossSalary) * 100;
            Console.WriteLine(PF);
            TDS = (18 / GrossSalary) * 100;
            Console.WriteLine(TDS);
            NetSalary = (GrossSalary - (PF + TDS));
            Console.WriteLine(NetSalary);
        }

    }
}

