using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progr1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money, food, foodUnitePrice=10;
            bool isAbleToPay;
            Console.WriteLine("dobro pozaovat! segodnia eda prodaetsa po " + foodUnitePrice + " za schtuku");
            Console.Write("skolko u vas zolota?");
            money = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("skolko vam nuzno edy? ");
            food = Convert.ToInt32(Console.ReadLine());

            isAbleToPay = money >= food * foodUnitePrice;
            food *= Convert.ToInt32(isAbleToPay);

            money -= food * foodUnitePrice;
            Console.WriteLine($"u vas v sumke {food} edy i {money} deneg ");

           
            Console.ReadKey();
        }
    }
}
