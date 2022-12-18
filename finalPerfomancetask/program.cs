using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static void bookATicket() {
            double distance = 0;
            Console.WriteLine("Booking a one-time ticket");
            Console.WriteLine("Current Location: TTC HUB");
            Console.WriteLine();
            Console.WriteLine("Please select which TTC station you would like to go to");
            Console.WriteLine();
            string[] stations = {"1. Kipling", "2. Islington", "3. Old Mill", "4. Jane", "5. Runnymede"};
            for (int i = 0; i < stations.Length; i++) {
                Console.WriteLine(stations[i]);
            }
            Console.WriteLine();
            int selection = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (selection == 1){

                Console.Clear();
                Console.WriteLine("Selected Destination: TTC Kipling");
                distance = distance + 32;

                ticket ticketKipling = new ticket();
                ticketKipling.destination = "TTC Kipling";
                ticketKipling.type = "One-way Ticket";
                ticketKipling.travelTime = Math.Round((distance / 88) * 60, 2);
                ticketKipling.price = (distance * 1.50);

                Console.WriteLine();
                Console.WriteLine("Destination: " + ticketKipling.destination);
                Console.WriteLine("Ticket type: " + ticketKipling.type);
                Console.WriteLine("Travel time: " + ticketKipling.travelTime + " minutes");
                Console.WriteLine("Fare: $" + ticketKipling.price);
                Console.WriteLine();
                Console.WriteLine("Press 'enter' to proceed to seat selection and checkout");

            }

            if (selection == 2) {

                Console.Clear();
                Console.WriteLine("Selected Destination: TTC Islington");
                distance = distance + 45;

                ticket ticketIslington = new ticket();
                ticketIslington.destination = "TTC Islington";
                ticketIslington.type = "One-way Ticket";
                ticketIslington.travelTime = Math.Round((distance / 88) * 60, 2);
                ticketIslington.price = (distance * 1.50);

                Console.WriteLine();
                Console.WriteLine("Destination: " + ticketIslington.destination);
                Console.WriteLine("Ticket type: " + ticketIslington.type);
                Console.WriteLine("Travel time: " + ticketIslington.travelTime + " minutes");
                Console.WriteLine("Fare: $" + ticketIslington.price);
                Console.WriteLine();
                Console.WriteLine("Press 'enter' to proceed to seat selection and checkout");

            }

            if (selection == 3) {

                Console.Clear();
                Console.WriteLine("Selected Destination: TTC Old Mill");

                distance = distance + 56;

                ticket ticketOldMill = new ticket();
                ticketOldMill.destination = "TTC Old Mill";
                ticketOldMill.type = "One-way Ticket";
                ticketOldMill.travelTime = Math.Round((distance / 88) * 60, 2);
                ticketOldMill.price = (distance * 1.50);

                Console.WriteLine();
                Console.WriteLine("Destination: " + ticketOldMill.destination);
                Console.WriteLine("Ticket type: " + ticketOldMill.type);
                Console.WriteLine("Travel time: " + ticketOldMill.travelTime + " minutes");
                Console.WriteLine("Fare: $" + ticketOldMill.price);
                Console.WriteLine();
                Console.WriteLine("Press 'enter' to proceed to seat selection and checkout");

            }

            if (selection == 4) {

                Console.Clear();
                Console.WriteLine("Selected Destination: TTC Jane");

                distance = distance + 71;

                ticket ticketJane = new ticket();
                ticketJane.destination = "TTC Jane";
                ticketJane.type = "One-way Ticket";
                ticketJane.travelTime = Math.Round((distance / 88) * 60, 2);
                ticketJane.price = (distance * 1.50);

                Console.WriteLine();
                Console.WriteLine("Destination: " + ticketJane.destination);
                Console.WriteLine("Ticket type: " + ticketJane.type);
                Console.WriteLine("Travel time: " + ticketJane.travelTime + " minutes");
                Console.WriteLine("Fare: $" + ticketJane.price);
                Console.WriteLine();
                Console.WriteLine("Press 'enter' to proceed to seat selection and checkout");

            
            }

            if (selection == 5) {

                Console.Clear();
                Console.WriteLine("Selected Destination: TTC Runnymede");

                distance = distance + 95;

                ticket ticketRunnymede = new ticket();
                ticketRunnymede.destination = "TTC Runnymede";
                ticketRunnymede.type = "One-way Ticket";
                ticketRunnymede.travelTime = Math.Round((distance / 88) * 60, 2);
                ticketRunnymede.price = (distance * 1.50);

                Console.WriteLine();
                Console.WriteLine("Destination: " + ticketRunnymede.destination);
                Console.WriteLine("Ticket type: " + ticketRunnymede.type);
                Console.WriteLine("Travel time: " + ticketRunnymede.travelTime + " minutes");
                Console.WriteLine("Fare: $" + ticketRunnymede.price);
                Console.WriteLine();
                Console.WriteLine("Press 'enter' to proceed to seat selection and checkout");
 
            }


            //Console.WriteLine(selection);

            Console.ReadLine();
            Console.Clear();

        }
        static void bookASeat()
        {
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
            for (int i = 0; true; i++)
            {
                Console.WriteLine("Welcome to the TTC Ticketing Kiosk!");
                Console.WriteLine("Current Location: TTC HUB");
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

                if (choice == 1)
                {
                    Console.Clear();
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
            }

            Console.ReadLine();
        }
    }
}
