//Arithmetic Order of Operations:

   // () Inner most parenthesis first and from left to right

   // / * % From left to right

   // + - From left to right


//allows you to not have to use the "System." in System.Console.Write
using System;
namespace Treehouse.FitnessFrog
{
  class Program
  {
      static void Main()
      {
        int runningTotal = 0;
        bool keepGoing = true;
        
        while(keepGoing){
              //prompt the user for minutes exercised
          Console.Write("enter how many mins you exercized or type \"quit\" to exit: ");
          
          string entry = Console.ReadLine();
          
          if ( entry == "quit"){
          keepGoing = false;
          } 
          else {
          
          int minutes = int.Parse(entry);
         
          //Sytem.Console.ReadLine() gets input from user console entered
          
          //Add mins exercised to total
           runningTotal = runningTotal + minutes;
          
          //Display total minutes exercized to the screen
          Console.WriteLine("You've entered " + runningTotal + " minutes");
          
          //repeat until the user quits
          }
        }
        Console.WriteLine("Thankyou and Goodbye!");
        }
    }
}