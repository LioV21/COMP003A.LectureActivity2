﻿/*
* Author: Lioneel Villanueva
* Course: COMP-003A
* Purpose: Lecture activity for variables,type system,Math,and Console properties
* Reference: The C# Player's Guide (4e) by RB Whitaker
*/

using System.Security.Authentication;

namespace COMP003A.LectireActivity2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* working with variables */
            // the following code shows all three primary variable-related activities:
            string username;  // declaring a variable (1 of 3)
            Console.WriteLine("What is your name?"); // request for user input 
            username = Console.ReadLine(); // assigning a value to a variable (2 of 3 )
            Console.WriteLine("Hi " + username); //retrieving its current value (3 of 3)


            // another example of the three primary variable related activites 
            // (declairng,assigning, and retrieving)
            string favoriteColor;
            Console.WriteLine(" What is your favorite color?");
            favoriteColor = Console.ReadLine();
            Console.WriteLine("Your favorite color is " + favoriteColor);

            /* working with variable integers */
            int score; // declare a new variable with a data type int
            // score = "Generic USER"; // will fail to compile because you are assigning a string value to an integer variable
            // score = "0"; // will still fail to compile because the "0" is still assigned as a string - enclosed in the double quotes
            score = 0; // works
            score = 4; // you can also reassign values to the variable as long as they are within scope and not constant 
            score = 11;
            score = -1564;


            /* reading from a variable does not change it */
            int a;
            int b;

            a = 5;
            b = 2;
            Console.WriteLine("The current vvalue of a: " + a);
            Console.WriteLine("The current value of b: " + b);

            b = a;
            a = -3;
            Console.WriteLine("The new value of a:" + a);
            Console.WriteLine("The new value of b:" + b);

            /* variables are case-sensitive */
            // the variables below are different despite hjaviing similar names 
            string exampleVariable;
            string exampleVAriable;
            string exampleVARiable;

            Console.WriteLine("**************************************************");
            /* 
            * types of variables and values matter in C#. they are not interchangeable.
            * there are eight integer types for storing integers of differing sizes and ranges: int, short, long, byte, sbyte, uint, ushort, and ulong.
            * the char type stores single characters
            * tjere are tjree types for storing real numbers: float, double, and decimal.
            * the bool type stores truch values (true and false) used in logic. 
            * using var for a variable's type tells the compiler to infer its type from the surrounding code, so you do not have to type it out. (But it still has a specific type.)
            * the System.Conver class is a useful class to convert from one type to another.
            */

            /* declaring and using variables with integer tyypes */
            byte aSingleByte = 34;
            Console.WriteLine("aSingleByte:" + aSingleByte);
            aSingleByte = 17;
            Console.WriteLine("aSingleByte:" + aSingleByte);

            short aNumber = 5039;
            Console.WriteLine("aNumber:" + aNumber);
            aNumber = -4354;
            Console.WriteLine("aNumber:" + aNumber);

            long aVeryBigNumber = 395904282569;
            Console.WriteLine("aVeryBigNumber:" + aVeryBigNumber);
            aVeryBigNumber = 13;
            Console.WriteLine("aVeryBigNumber:" + aVeryBigNumber);
            int anInteger = 2147483647;

            /* a declaring,using, and concatenating characters ans strings */
            char aLetter = 'A'; // character values are enclosed in single quotes
            string message = "Hello World!"; // sting values are enclosed in double quotes

            Console.WriteLine("Concatenation using + :" + aLetter + " " + message); // use the plus (+) sign in between characters/strings to concatenate
            Console.WriteLine($"Concatenation using string interpolation: {aLetter}{message}"); // use stiring interpolation with a dolllar-sign ($) before the opening douible-quote and enclosing variables with curly braces ({variable Name})

            /* floating-point types */
            double number1 = 3.5623;
            float number2 = 3.5623f;
            decimal number3 = 3.5623m;
            Console.WriteLine($"Value of number 1: {number1}");
            Console.WriteLine($"Value of number 2): {number2}");
            Console.WriteLine($"Value of number 3: {number3}");

            /* scientificc notation */
            double avogadrosNumber = 6.022e23;
            Console.WriteLine($"Value of avogadrosNumber:{avogadrosNumber}");

            /* bool type */
            bool itWorked = true;
            Console.WriteLine($"Value of itWorked: {itWorked}");
            itWorked = false;
            Console.WriteLine($"Newv value of itWorkeed:{itWorked}");

            /* convert */
            string inputAgeString;
            int inputAge;
            int currentYear = 2023;

            Console.WriteLine($"Enter age in {currentYear}");
            inputAgeString = Console.ReadLine();
            inputAge = Convert.ToInt32(inputAgeString);
            Console.WriteLine($"Your age is  {inputAge}");

            Console.WriteLine("**************************************************);");
            /*
            * math operations
            * addition :+
            * subtraction: -
            * multiplication:" 
            * division : /
            * modulo: % (remainder)

            */

            int addition = 2 + 3;
            int subtraction = 5 - 2;
            int multiplication = 22 * 2;
            int division = 21 / 7;
            int modulo = 77 % 5;
            Console.WriteLine($"Value of addition: {addition}");
            Console.WriteLine($"Value of subtraction: {subtraction}");
            Console.WriteLine($"Value of multiplication: {multiplication}");
            Console.WriteLine($"Value of division: {division}");
            Console.WriteLine($"vALUE OF MODULO: {modulo}");

            /*
            * arithmetic, compound expresssions and order of operations
            * Multiplication and division are done first, left to right 
            * Addition and subtraction are done last, left to right
            * Reference: https//csharpplayerguide.com/articles/operators-table
            */

            int arithmetic1; // declaring the variable arithmetic1.
            arithmetic1 = 9 - 2; // assigning a alue to arithmetic1, using some math.
            Console.WriteLine($"Value of arithmetic1: {arithmetic1}");
            arithmetic1 = 3 + 3; // another assignment.
            Console.WriteLine($"New value of arithmetic1: {arithmetic1}");
            int arithmetic2 = 3 + 1; // declaring arithmetic2 and assigning a value to arithmetic all at once.
            Console.WriteLine($"Value of arithmetic2: {arithmetic2}");
            arithmetic2 = 1 + 2; // assigning a second value to arithmeitc2
            Console.WriteLine($"New value of airthmetic2: {arithmetic2}");

            // use multiple sets of parentheses to group operations
            int result = ((2 + 1) * 8 - (3 * 2) * 2) / 4;
            Console.WriteLine($"Value of result; {result}");

            /* compound assignemnt operator */
            int compoundAssignmentOperator = 0;
            compoundAssignmentOperator += 5; // The equivalent of compoundAssignmentOperator = compoundAssignmentOperator + 5; ( a is 5 after this line runs.)
            compoundAssignmentOperator -= 2; // The equivalent of compoundAssignmentOperator = compoundAssignmentOperator -2; (a is 3 after this line runs.)
            compoundAssignmentOperator *= 4; // The equivalent of compoundAssignmentOperator = compoundAssignmentOperator * 4; (a is 12 after this line runs.)
            compoundAssignmentOperator /= 2; // The equivalent of compoundAssignmentOperator = compoundAssignmentOperator / 2; (a is 6 after this line runs.)
            compoundAssignmentOperator %= 2; // The equivalent of compoundAssignmentOperator = compoundAssignmentOperator % 2; ( a is 0 after this line runs

            /* increment and decrement operators */
            int incrementDecrementOperations = 0;
            incrementDecrementOperations++; // The equivalent of incrementDecrementOperators += 1; or incrementDecrementOperators=incrementDecrementOperators +1;
            incrementDecrementOperations--; // The equivalent of incrementDecrementOperators -=1; or incrementDeecrementOperators= incrementDecrementOperators -1;

            Console.WriteLine("*************************************************");

            /* cconsole 2.0 */
            Console.WriteLine("What is your name, human "); // notice thee space at the end. 
            string userName = Console.ReadLine(); // reads the entire line 
            //result: What is your name, human? Lionel

            Console.WriteLine("Press any key when you're ready to begin");
            Console.ReadKey();// reads a keystroke

            Console.BackgroundColor = ConsoleColor.Yellow; // changes the console background to yellow
            Console.ForegroundColor = ConsoleColor.Black; // changes the console text to black 
            Console.Title = "Hello World!";  // changes the console title
            Console.Beep(440, 1000); // computer beeps
        }

    }
}




































