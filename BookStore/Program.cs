using System;

namespace BookStoreApp
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("=== BOOK STORE ORDER ===");

            Console.Write("Enter Book Title: ");
            string bookTitle = Console.ReadLine();

            Console.Write("Enter Price per Book: ");
            double pricePerBook = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Delivery Fee: ");
            double deliveryFee = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Packaging Fee: ");
            double packagingFee = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter First Letter of Genre: ");
            char genreLetter = Convert.ToChar(Console.ReadLine());

            Console.Write("Is Gift Wrap? (true/false): ");
            bool isGiftWrap = Convert.ToBoolean(Console.ReadLine());

            double booksCost = pricePerBook * quantity;

            double finalCost = booksCost;
            finalCost += deliveryFee;
            finalCost += packagingFee;  

           
            Console.WriteLine("\n=== ORDER SUMMARY ===");
            Console.WriteLine("Book Title: " + bookTitle);
            Console.WriteLine("Price per Book: " + pricePerBook.ToString("F2"));
            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("Delivery Fee: " + deliveryFee.ToString("F2"));
            Console.WriteLine("Packaging Fee: " + packagingFee.ToString("F2"));
            Console.WriteLine("First Letter of Genre: " + genreLetter);
            Console.WriteLine("Gift Wrap: " + isGiftWrap);

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Books Cost: " + booksCost.ToString("F2"));
            Console.WriteLine("Final Cost: " + finalCost.ToString("F2"));
            Console.WriteLine("-----------------------------");

           
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}