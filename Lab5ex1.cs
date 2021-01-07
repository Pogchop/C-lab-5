using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5ex1
{
    class Expenditure
    {
        protected string[] expenditureType = { "Maintenance", "Salary Paid", "Miscellanous" };
        protected double[] expenditureAmount = new double[3];
        protected double TotalExpense = 0;
        internal virtual void AcceptDetails()
        {
            Console.WriteLine("Enter the expenditure for the following heads :");
            for (int i = 0; i < expenditureType.Length; i++)
            {
                Console.Write(expenditureType[i] + " : ");
                expenditureAmount[i] = Convert.ToDouble(Console.ReadLine());
                TotalExpense += expenditureAmount[i];
            }
        }
        internal virtual void DisplayDetails()
        {
            Console.WriteLine("\n\nExpenditure Account");
            Console.WriteLine("\nExpenditure Head \t\tAmount ($)");
            Console.WriteLine("-------------------------------------------");
            for (int i = 0; i < expenditureType.Length; i++)
            {
                Console.WriteLine(expenditureType[i] + "\t\t\t" + expenditureAmount[i]);
            }
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Total Expense\t\t" + TotalExpense);
        }
        class Revenue : Expenditure
        {
            private double totalIncome;
            private double balance;
            internal override void AcceptDetails()
            {
                Console.WriteLine("\n");
                base.AcceptDetails();
                Console.Write("\nEnter the revenue earned annually : ");
                totalIncome = Convert.ToDouble(Console.ReadLine());
            }
            internal override void DisplayDetails()
            {
                base.DisplayDetails();
                Console.WriteLine("\nTotal Income\t\t\t" + totalIncome);
                balance = totalIncome - TotalExpense;
                if (balance < 0)
                {
                    Console.WriteLine("\nNet Loss: " + -balance + "\n");
                }
                else
                {
                    Console.WriteLine("\nNet Profit: " + balance + "\n");
                }
            }
        }
        static void Main(string[] args)
        {
            Revenue objrevenue = new Revenue();
            Expenditure objexpenditure = new Expenditure();
            objexpenditure.AcceptDetails();
            objexpenditure.DisplayDetails();
            objrevenue.AcceptDetails();
            objrevenue.DisplayDetails();
            Console.ReadKey();
        }
    }
}
