using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static void bookATicket() {
            Console.WriteLine("Booking a one-time ticket");

        }
        static void bookASeat() {
            Console.WriteLine("Plan a Trip");
        }
        static void payment() { }
        static void planATrip() { }
        static void multipleDestinations() { }
        static void trainInfo() {
            Console.WriteLine("Available Trains");
        }

        static void Main(string[] args)
        {
            for (int i, i = 

            Console.WriteLine("Welcome to the TTC Ticketing Kiosk!");
            Console.WriteLine();
            Console.WriteLine("Please choose the action you would like to complete today, then press enter.");
            Console.WriteLine();
            Console.WriteLine("1. Book a Ticket");
            Console.WriteLine("2. Plan a Trip");
            Console.WriteLine("3. Available Trains");
            //Console.WriteLine("4. Log Sheets);
            Console.WriteLine("4. Exit");
            Console.WriteLine();
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1) {
                bookATicket();
            }

            if (choice == 2)
            {
                bookASeat();
            }

            if (choice == 3)
            {
                trainInfo();
            }

            if (choice == 4)
            {
                Console.WriteLine("Exit");
            }

            if (choice != 1 && choice != 2 && choice != 3 && choice != 4)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid option selected. Please select 1, 2, 3, or 4");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Press 'Enter' to return to the main menu");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.ReadLine();
                Console.Clear();
            }

            Console.ReadLine();
        }
    }
}
