using HomeWork17Module.Types;

namespace HomeWork17Module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var generalAccount = new GeneralAccount()
            {
                Balance = 100000               
            };
          
            Calculator.CalculateInterest(generalAccount);

            Console.WriteLine(generalAccount.Interest); 

            var salaryAccount = new SalaryAccount()
            {
                Balance = 100000
            };

            Calculator.CalculateInterest(salaryAccount);

            Console.WriteLine(salaryAccount.Interest);
        }
    }
}