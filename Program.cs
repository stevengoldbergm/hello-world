using System;

namespace HelloWorld // Use the name of your actual application
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int myInt = 5;
          int mySecondInt = 10;
          string resultString = " If was FALSE";
          
          // Complex Conditional Statements
          // IF statements

          if (myInt < mySecondInt)
          {
            myInt+= 10;
            resultString = " If was TRUE";
          }

          Console.WriteLine(myInt + resultString);

          string myCow = "cow";
          string myCapitalizedCow = "cow";

          if (myCow == myCapitalizedCow)
          {
            Console.WriteLine("The Strings matched!");
          } 
          // if (myCow != myCapitalizedCow)
          // {
          //   Console.WriteLine("The Strings didn't match!");
          // } We don't need this block! We should use ELSE
          else if (myCow == myCapitalizedCow.ToLower())
          {
            Console.WriteLine("The letters are the same, but the capitalization is off!");
          }
          else
          {
            Console.WriteLine("The Strings didn't match!");
          }

          // Switches - MUST USE CONSTANTS!
          //  This minor edit is intended to keep my streak going on github. It's so disheartening that I can't even get a call.

        }
    }
}
