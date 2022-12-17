ICS4U Final Performance Task

Project Idea: TTC Ticketing Kiosk Software

Program Structure

Welcome screen. Will produce four options
1. Book a ticket
2. Plan a trip
3. Available Trains
4. Log Sheets
5. Exit

The user will need to make a selection based on the given option

 Book a ticket

This menu option will be the portion of the program that will allow for the user to book a one-way ticket to any destination provided by the TTC.

The program will ask the user where they need to go, a list of destinations will be given
The user will answer the question, selecting a destination from the provided list
If the user enters an invalid option, the program will tell the user to try again
If the user enters a valid option, 
The program will display a labelled map of the train (4x 20) which will be created by a 2D array
The user will indicate to the program what seat they would like to sit at, and continue to  process trip information (e.g. A1 = 0,0)
the program will indicate to the user the destination, distance, travel time, and fare
The program will return to the main menu
The program will ask the user if they would like to confirm their trip details
The user will answer the question [y/n]
If the user answers n, the program will return to the list of possible destinations, allowing for the user to make the correct selection
If the user answers y, the program will provide the user with payment options
Credit/Debit
TTC Pass

Portion Summary:
Menu Method
Book a Ticket Method
Destinations List
Book a Seat Method
Train map 2D Array
Payment Method

   b.    Plan a trip

This menu option allows the user to plan a trip with multiple stops. The difference between this portion and the previous is that the user can choose multiple destinations when planning a trip. The summary will display multiple locations, a longer distance, a longer total travel time, and larger fee. 

The program will ask the user how many locations they would like to go to. 
The user will enter this amount (n) and press enter
The program will as the user n amount of times to what locations they would like to go to, displaying the list of possible destinations every time
After the user has indicated all n of the locations they would like to go to, the program will display a location summary and as the user if the information provided is correct, [y/n]
If the user selects n, the program will prompt the user to declare all the location they would like to visit
If the user selects y, the program will display a map of the train (4x20), allowing the user to select the seat they would like to sit at
The program will display a trip summary
Destinations, total distance, total travel time, total fee
The program will ask the user if the trip information is accurate [y/n]
If the user answers n, the user will be prompted to select their destination and plan their trip again
If the user answers y, the user will be prompted to pay

Portion Summary:
Plan a trip Method
Multiple Destinations Method
Multiple Destinations List

   
    c.   Available Trains

This portion of the program is purely informative and informational. The purpose is to display ot the user what trains the TTC has available for the user to use. The train information will inlcude. train model, train colour, train capacity, distance travelled, and 2 trains will have a special circumstance of having multiple conductors. 

The program will display a list of train names for the user to select which one they would like to learn about
Upon selection, the program will display the following information about the selected train will display
Train model
Train colour
Train capacity
Distance Travelled
2 Trains will have a special identifier which indicates how many conductors are needed to operate the train
The program will return to the train selection menu after 

Portion Summary:
Train Information Method
Trains Classes (Stored)

   d.   
