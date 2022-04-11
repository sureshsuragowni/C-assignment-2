using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class Employee
    {
        private int EmpNo;    
        private String EmpName;
        private double Salary;
        private double HRA;
        private double TA;
        private double DA;
        private double PF;
        private double TDS;
        private double NetSalary;
        private double GrossSalary;

      
        public Employee()  
        {

        }

        public int EmployeeNumber { get; set; }
        public String EmployeeName { get; set; }
        public double EmployeeSalary { get; set; }
        public void Method1(int EmpNo)
        {
            Console.WriteLine("Enter Employee Number");
            Console.ReadLine();
            if (EmpNo == 23434)
            {
                this.EmpNo = EmpNo;
            }
            else
            {
                Console.WriteLine("Invalid Employee Number..");
            }

        }
        public void Method2(String EmpName)
        {
            Console.WriteLine("Enter Employee Name");
            Console.ReadLine();
            if (EmpName == "Suresh Gowd")
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
            Console.WriteLine("Enter Employee Salary");
            Console.ReadLine();
            MethodforHRA();              
            MethodForGrossSalary();     
            CalculateSalary();          
        }
        public void MethodforHRA()
        {

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
                Console.WriteLine("Invalid....");
            }
        }

        public void MethodForGrossSalary()
        {
            Console.WriteLine("Your Gross Salary is..");
            GrossSalary = Salary + HRA + TA + DA;
            Console.WriteLine(GrossSalary);
        }
        public void CalculateSalary()
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