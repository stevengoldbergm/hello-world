using System;

namespace HelloWorld // Use the name of your actual application
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int myInt = 5;
          int mySecondInt = 10;

          // Let's talk about ++
            // ++ adds a single value
          myInt++;
          Console.WriteLine(myInt);

          // +=
            // += adds a specific value to the variable
          myInt+= 7;
          Console.WriteLine(myInt);

          // -= 
            //  reduces a variable by the value listed
          myInt-= 8;
          Console.WriteLine(myInt);

          // Basic math stuff
          Console.WriteLine(myInt * mySecondInt);
          Console.WriteLine(myInt / mySecondInt); // result is 0, because it's an int, not a decimal
          Console.WriteLine(mySecondInt / myInt);
          Console.WriteLine(mySecondInt + myInt);
          Console.WriteLine(mySecondInt - myInt);

          // Order of Operations
            // C# uses the PEMDAS method
            // Parentheses, Exponents, Multiplication, Division, Addition, Subtraction
          Console.WriteLine(5+5*10);
          Console.WriteLine((5+5) * 10);

          // Using Exponents
            // This function takes the X variable and multiplies it by itself a number a times equal to the Y variable
          Console.WriteLine(Math.Pow(5,2));
          Console.WriteLine(Math.Pow(5,3));
          Console.WriteLine(Math.Pow(5,4));

          // Using Square Routes
          Console.WriteLine(Math.Sqrt(49)); // Should be 7

          // Using math operators with strings
          string myString = "String";
          Console.WriteLine(myString);

          // Use the += operator to append new text to your string
          myString+= "s are great!";
          Console.WriteLine(myString);

          // The += operator works the same way as redefining the string value using older logic
          myString = myString + " But I like them better when I use a simple syntax! ";
          Console.WriteLine(myString);

          // Putting quotes and other special characters in a string
          Console.WriteLine("\"this is how you use quotes in C#\"");

          // Splitting Strings
          string[] myStringArray = myString.Split("! "); // Enter the delimiter you want to use to split the string
          Console.WriteLine(myStringArray[0]);
          Console.WriteLine(myStringArray[1]);

          // Other string/array functions
            //Remove
            //Replace
            //Reverse

          // Conditionals
            // .Equal Returns a Boolean value
            // It does what it says on the tin
            Console.WriteLine(myInt.Equals(mySecondInt));
            Console.WriteLine(myInt.Equals(mySecondInt / 2));

            // The double = sign == or the bang equal sign != for Not Equal
            Console.WriteLine(myInt == mySecondInt);
            Console.WriteLine(myInt == mySecondInt / 2);
            Console.WriteLine(myInt != mySecondInt);
            Console.WriteLine(myInt != mySecondInt / 2);
            Console.WriteLine(myInt != mySecondInt / 3);

            // >, <, >=, <=
            Console.WriteLine(myInt > mySecondInt);
            Console.WriteLine(myInt < mySecondInt);
            Console.WriteLine(myInt >= mySecondInt);
            Console.WriteLine(myInt <= mySecondInt);

            // AND and OR

            // AND &&
            Console.WriteLine(5 > 2 && 5 < 5); // prints False
            
            // OR ||
            Console.WriteLine(5 > 2 || 5 < 5); // prints True

        }
    }
}
