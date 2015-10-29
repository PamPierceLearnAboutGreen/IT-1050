using System;

namespace IT1050Assignment4PamPierce
{
    class MovieTrip
    {
        private static int ChildDayPrice = 399;
        private static int AdultDayPrice = 599;
        private static int SeniorDayPrice = 450;
        private static int ChildNightPrice = 699;
        private static int AdultNightPrice = 1099;
        private static int SeniorNightPrice = 850;
        private static int SmallSodaPrice = 350;
        private static int LargeSodaPrice = 599;
        private static int HotDogPrice = 399;
        private static int PopcornPrice = 450;
        private static int CandyPrice = 199;

        private int PopcornCouponCount = 0;
        private int CandyCouponCount = 0;
        private int PopcornSodaCouponCount = 0;  //may be reduced if they don't buy enough tickets!

        private string FullName = "";
        private int ChildDayQty = 0;
        private int AdultDayQty = 0;
        private int SeniorDayQty = 0;
        private int ChildNightQty = 0;
        private int AdultNightQty = 0;
        private int SeniorNightQty = 0;
        private int SmallSodaQty = 0;
        private int LargeSodaQty = 0;
        private int HotDogQty = 0;
        private int PopcornQty = 0;
        private int CandyQty = 0;

        private int TotalTicketQty = 0;

        private decimal Discount = 0.00m;
        private decimal TotalCost = 0.00m;

        public void AskDetail()
        {
            Console.WriteLine("Welcome to Love Theater, Where your your friends and family will love the experience!");
            Console.WriteLine("Please enter your full name as shown on your season pass -");
            FullName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(FullName + ", you can purchase tickets for the special showing of TopGun, today only!");
            Console.WriteLine("Would you like to purchase a ticket (y/n)?");
            String WantTicket = Console.ReadLine();
            if (WantTicket.ToLower().Contains("y"))
            {
                Console.WriteLine("We have both evening shows and discounted matinee shows.");
                Console.WriteLine("Discounted matinee shows: Children $3.99, Adults $5.99, and Seniors $4.50");
                Console.WriteLine("Evening shows: Children $6.99, Adult $10.99, and Seniors $8.50");
                Console.WriteLine("Purchase 3 or more tickets for the EVENING to receive one free bag of popcorn.  Yummy!");
                Console.WriteLine("");
                Console.WriteLine("Please enter the quantity of each ticket type:");
                Console.WriteLine("Enter a 0 if not purchasing a specific type of ticket.");
                Console.WriteLine("Matinee");
                Console.Write("     Child    --> ");
                ChildDayQty = int.Parse(Console.ReadLine());
                Console.Write("     Adult    --> ");
                AdultDayQty = int.Parse(Console.ReadLine());
                Console.Write("     Senior   --> ");
                SeniorDayQty = int.Parse(Console.ReadLine());
                Console.WriteLine("Evening");
                Console.Write("     Child    --> ");
                ChildNightQty = int.Parse(Console.ReadLine());
                Console.Write("     Adult    --> ");
                AdultNightQty = int.Parse(Console.ReadLine());
                Console.Write("     Senior   --> ");
                SeniorNightQty = int.Parse(Console.ReadLine());
                TotalTicketQty = ChildDayQty + AdultDayQty + SeniorDayQty + ChildNightQty + AdultNightQty + SeniorNightQty;
                CalcPopcornCoupon();
                Console.WriteLine("");
                Console.WriteLine("Each purchase of a popcorn and large soda provides a $2 discount on one movie ticket.");
                Console.WriteLine("For every 3 candies you buy, get the 4th candy FREE!");
                Console.WriteLine("");
                Console.WriteLine("Yes, you may eat food purchased in the theater while watching your movie.");
                Console.WriteLine("Choose what you would like to munch on:");
                Console.Write("     Small Soda    --> ");
                SmallSodaQty = int.Parse(Console.ReadLine());
                Console.Write("     Large Soda    --> ");
                LargeSodaQty = int.Parse(Console.ReadLine());
                Console.Write("     Hot Dog       --> ");
                HotDogQty = int.Parse(Console.ReadLine());
                Console.Write("     Popcorn       --> ");
                PopcornQty = int.Parse(Console.ReadLine());
                Console.Write("     Candy         --> ");
                CandyQty = int.Parse(Console.ReadLine());
            }
        }

        public void CalcPrice()
        {
            CalcCandyCoupon();
            CalcPopcornSodaCoupon();

        }
        public void CalcPopcornCoupon()
        {
            if (ChildNightQty + AdultNightQty + SeniorNightQty> 3)
            {
                PopcornCouponCount = 1;
                Console.WriteLine("Great! You have a FREE popcorn!!!");
            }
        }
    public void CalcCandyCoupon()
        {
            CandyCouponCount = (CandyQty / 3);
            if (CandyCouponCount > 0)
            {
                Console.WriteLine("Great! You have " + CandyCouponCount + " FREE candy!!!");
            }
        }
        public void CalcPopcornSodaCoupon()
        {
            if (PopcornQty > 0 && LargeSodaQty > 0)
            {
                if (LargeSodaQty > PopcornQty)
                {
                    PopcornSodaCouponCount = PopcornQty;
                }
                else
                {
                    PopcornSodaCouponCount = LargeSodaQty;
                }
            }

            if (TotalTicketQty > 0 && PopcornSodaCouponCount > 0)
            {
                if (PopcornSodaCouponCount >= TotalTicketQty)
                {
                    PopcornSodaCouponCount = TotalTicketQty;
                }
                Console.WriteLine("What a delicious way to save money! You have $" + PopcornSodaCouponCount * 2 + " off " + TotalTicketQty + " tickets.");
            }
        }
        public void PrintPrice()
        {
            Console.WriteLine("Here is the summary of what you are purchasing for your review:");
            if (ChildDayQty > 0)
            {

                Console.WriteLine(ChildDayQty + " Child Matinee:  " + ((decimal)(ChildDayQty * ChildDayPrice) / 100).ToString("C2"));
                TotalCost += (decimal)(ChildDayQty * ChildDayPrice) / 100;
            }
            if (AdultDayQty > 0)
            {
                Console.WriteLine(AdultDayQty + " Adult Matinee:  " + ((decimal)(AdultDayQty * AdultDayPrice) / 100).ToString("C2"));
                TotalCost += (decimal)(AdultDayQty * AdultDayPrice) / 100;
            }
            if (SeniorDayQty > 0)
            {
                Console.WriteLine(SeniorDayQty + " Senior Matinee: " + ((decimal)(SeniorDayQty * SeniorDayPrice) / 100).ToString("C2"));
                TotalCost += (decimal)(SeniorDayQty * SeniorDayPrice) / 100;
            }
            if (ChildNightQty > 0)
            {
                Console.WriteLine(ChildNightQty + " Child Evening:  " + ((decimal)(ChildNightQty * ChildNightPrice) / 100).ToString("C2"));
                TotalCost += (decimal)(ChildNightQty * ChildNightPrice) / 100;
            }
            if (AdultNightQty > 0)
            {
                Console.WriteLine(AdultNightQty + " Adult Evening:  " + ((decimal)(AdultNightQty * AdultNightPrice) / 100).ToString("C2"));
                TotalCost += (decimal)(AdultNightQty * AdultNightPrice) / 100;
            }
            if (SeniorNightQty > 0)
            {
                Console.WriteLine(SeniorNightQty + " Senior Evening: " + ((decimal)(SeniorNightQty * SeniorNightPrice) / 100).ToString("C2"));
                TotalCost += (decimal)(SeniorNightQty * SeniorNightPrice) / 100;
            }
            if (SmallSodaQty > 0)
            {
                Console.WriteLine(SmallSodaQty + " Small Soda: " + ((decimal)(SmallSodaQty * SmallSodaPrice) / 100).ToString("C2"));
                TotalCost += (decimal)(SmallSodaQty * SmallSodaPrice) / 100;
            }
            if (LargeSodaQty > 0)
            {
                Console.WriteLine(LargeSodaQty + " Large Soda: " + ((decimal)(LargeSodaQty * LargeSodaPrice) / 100).ToString("C2"));
                TotalCost += (decimal)(LargeSodaQty * LargeSodaPrice) / 100;
            }
            if (HotDogQty > 0)
            {
                Console.WriteLine(HotDogQty + " Hot Dog: " + ((decimal)(HotDogQty * HotDogPrice) / 100).ToString("C2"));
                TotalCost += (decimal)(HotDogQty * HotDogPrice) / 100;
            }
            if (PopcornQty > 0)
            {
                Console.WriteLine(PopcornQty + " Popcorn: " + ((decimal)(PopcornQty * PopcornPrice) / 100).ToString("C2"));
                TotalCost += (decimal)(PopcornQty * PopcornPrice) / 100;
            }
            if (CandyQty > 0)
            {
                Console.WriteLine(CandyQty + " Candy: " + ((decimal)(CandyQty * CandyPrice) / 100).ToString("C2"));
                TotalCost += (decimal)(CandyQty * CandyPrice) / 100;
            }
            if (PopcornCouponCount + CandyCouponCount + PopcornSodaCouponCount > 0)
            {
                Console.WriteLine("PLUS: ");
                if (PopcornCouponCount > 0) Console.WriteLine(PopcornCouponCount + " free popcorn");
                if (CandyCouponCount > 0) Console.WriteLine(CandyCouponCount + " free candy");
                Discount = (decimal)(PopcornSodaCouponCount * 2);
                if (PopcornSodaCouponCount > 0) Console.WriteLine(PopcornSodaCouponCount + " ticket discount of $2 each, totalling -$" + Discount);
            }
            Console.WriteLine("Total Cost " + ((TotalCost - Discount).ToString("C2")));
        }
    }
}
