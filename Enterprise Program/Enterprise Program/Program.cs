using System;

namespace Enterprise_Program
{
    class Program
    {
        static decimal firstSalary(decimal cost,decimal day)
        {
            decimal output = cost * day;
            return output;
        }
        static decimal secondSalary(decimal empoyees, decimal day, decimal cost)
        {
            decimal result = firstSalary(cost, day);
            decimal output = result * empoyees;
            return output;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Type number of employees");
            decimal empoyees = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type the cost of 1 workday");
            decimal cost = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Type the number of days for which payment is made");
            decimal day = Convert.ToInt32(Console.ReadLine());
            decimal result = firstSalary(cost,day);
            decimal secondResult = secondSalary(empoyees,day,cost);
            Console.WriteLine($"For One Empoyee `{result}");
            Console.WriteLine($"For {empoyees} Empoyees `{secondResult}");
        }
    }
}
