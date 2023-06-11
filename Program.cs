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
          string myCapitalizedCow = "Cow";

          if (myCow == myCapitalizedCow)
          {
            Console.WriteLine("The Strings matched!");
          } 
          if (myCow != myCapitalizedCow)
          {
            Console.WriteLine("The Strings didn't match!");
          }

        }
    }
}
