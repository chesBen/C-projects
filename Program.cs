

namespace CharityCampaign
{

    using System;
    public class Program
    {
        public static void Main()
        {
            double campaignDays = double.Parse(Console.ReadLine());
            double cooks = double.Parse(Console.ReadLine());
            double cakes = double.Parse(Console.ReadLine());
            double gofrettes = double.Parse(Console.ReadLine());
            double pancakes = double.Parse(Console.ReadLine());

            double cakesPrice = cakes * 45.00;
            double gofrettesPrice = gofrettes * 5.80;
            double pancakesPrice = pancakes * 3.20;
            double daySum = (cakesPrice + gofrettesPrice + pancakesPrice) * cooks;
            double allSum = daySum * campaignDays;
            double sumAfterBills = allSum - allSum * 1/8;

            Console.WriteLine("{0:f2}", sumAfterBills);
        }
    }
}
