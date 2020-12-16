using System;

namespace _02._Summer_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            //int budget = int.Parse(Console.ReadLine());
            //double towelPrice = double.Parse(Console.ReadLine());
            //int discountPercent = int.Parse(Console.ReadLine());

            //double umbrellaPrice = (towelPrice * 2) / 3;
            //double flipFlopPrice = umbrellaPrice * 0.75;
            //double bagPrice = (flipFlopPrice + towelPrice) / 3;

            //double finalPrice = (towelPrice + umbrellaPrice + flipFlopPrice + bagPrice) * (1 - discountPercent / 100.0);
            //double difference = Math.Abs(finalPrice - budget);

            //if (finalPrice <= budget)
            //{
            //    Console.WriteLine($"Annie's sum is {finalPrice:F2} lv. She has {difference:F2} lv. left.");
            //}
            //else
            //{
            //    Console.WriteLine($"Annie's sum is {finalPrice:F2} lv. She needs {difference:F2} lv. more.");
            //budget = int(input())
            //towel = float(input())
            //discount = int(input())

            //umbrella = towel_price / 3 * 2
            //flipflops = umbrella_price * 0.75
            //beachbag = (flip_flops_price + towel_price) / 3
            //total = towel_price + umbrella_price + flip_flops_price + bag_price
            //discout_percentage = discount / 100
            //total_amount_products_discount = total_amount_products - (total_amount_products * discout_percentage)


            //if ani_budget >= total_amount_products_discount:
            //amount_left = ani_budget - total_amount_products_discount
            //print(f"Annie's sum is {total_amount_products_discount:.2f} lv. She has {amount_left:.2f} lv. left.")
            //else:
            //budget_left = total_amount_products_discount - ani_budget
            //print(f"Annie's sum is {total_amount_products_discount:.2f} lv. She needs {budget_left:.2f} lv. more.")
            int budget = int.Parse(Console.ReadLine());
            double towelPrice = double.Parse(Console.ReadLine());
            int percentDiscount = int.Parse(Console.ReadLine());

            double umbrellaPrice = towelPrice * 2 / 3;
            double flipFlopsPrice = umbrellaPrice * 0.75;
            double bag = (flipFlopsPrice + towelPrice) * 1 / 3;

            double totalPrice = towelPrice + umbrellaPrice + flipFlopsPrice + bag;
            double afterDiscount = totalPrice - totalPrice * percentDiscount / 100;

            if (budget >= afterDiscount )
            {
                Console.WriteLine($"Annie's sum is {afterDiscount:f2} lv. She has {budget - afterDiscount:f2} lv. left");
            }
            else
            {
                Console.WriteLine($"Annie's sum is {afterDiscount:f2} lv. She needs {budget - afterDiscount:f2} leva more.");
            }



           

        }
    }
}
