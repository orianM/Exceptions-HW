using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            #region question 1

            /*An exception is a problem that happens during the execution of a program.
              There are two different cirumstances in which where an exception can happen:
              (1). Exception during complie time - when this happens, the program won't run until the problem is fixed.
              (2). Exception during Runtime - when this happens, the program will run until it reaches the problem.
                                            And then will out of the method/function until it gets to Main, at which point
                                            it will suddenly close.*/

            #endregion

            #region question 2

            /*What happens during an exception: 
               (a). exception not handled - stops/exits the program.
               (b). exception handled - continues to next lines*/

            #endregion

            #region question 3

            /*In order to handle a Runtime exception, we need to try our code and see if it's allowed.
              for example if variable x = 0, and we want to divide (number/x) - knowing that dividing by zero is not allowed:
              we'd check using try
                               {
                                  result = number / x;
                               }
                               catch (Exception someException)
                               {
                                   Console.WriteLine(someException.message)
                               }*/

            #endregion

            #region question 4

            /*What does each block of code do:
              (a). try block - allows to give specific instructions on how to deal with the block of code in case of an exception.
              (b). catch block - "catches" a specific exception/any exception, and decides what to do/write/change when an exception
                   occurs.
              (c). finally block - anything and all lines written in the finally block of code will always be executed, wether or not
                   an exception occurs.*/

            #endregion

            #region question 5

            /*The main to child classes that derive from Exception class are:
              (1). SystemException - uses all the base predefined exceptions.
              (2). ApplicationException - supports exceptions generated(created specifically) by certain application programs.*/

            #endregion

            #region question 6

            /*When an exception happens in the try block it stops and moves to the catch/finally that handles the exception.
              In other words the try block will only execute lines until it reaches an exception.*/

            #endregion

            #region question 7

            /*When we want to make sure a line of code gets executed whether an exception occurs or not, we use the finally block.*/

            #endregion

            #region question 8

            /*It's important to write our catch blocks in order(from last to base Exception).
              Since Exception class includes all exceptions if we want to do something specific for a specific exception -
              we need to make sure we "catch" specifically before we "catch" any Exception.
              for example: try
                           {
                             int zero = 0;
                             int x = 3/0;
                           }
                           catch (Exception anyExc)
                           {
                              Console.WriteLine("some Exception happened");
                           }
                           catch (DivideByZeroException zeroExc)  <- this catch will never be executed.
                           {
                              Console.WriteLine("Attempted to divide by zero");
                           }*/

            #endregion

            #region question 9

            /*We use StackTrace when we want to find out in which lines our exception occurs.*/

            #endregion

            #region question 10

            /*We can create our own execptions using the "throw" keyword followed by, new ExceptionName("Message").*/

            #endregion

            #region question 11

            /*When writing the message of the exception we should - specify what is the problem with that exception.*/

            #endregion

            #region question 12

            /*It's possible to use try with only finally(without catch).*/

            #endregion

            #region question 13

            /*A custom exception is used when we want to make exceptions that are related to a specific class/function in our code.
              In other words when we want to Handle a specific type of problem in a specific type of place.*/

            #endregion

            #region question 14

            /*We should derive from ApplicationException when making a custom exception, 
              because a custom exception is meant to handle an exception that is related to a certain object.
              Not something that the entire system needs.*/

            #endregion

            #region question 15

            /*The keyword when works in a similar way to if, for example:
              int y = 0;
              int x = 0;
              int z = 0;
              try
              {
                  y = int.Parse(Console.ReadLine());
                  x = int.Parse(Console.ReadLine());
                  z = int.Parse(Console.ReadLine());
              
                  int sum = x / y;
                  sum = y / x;
                  sum = x / y / z;
              }
              catch (DivideByZeroException exc1) when (y == 0) //if y is equal to 0
              {
                  Console.WriteLine("y is equal to 0");
              }
              catch (DivideByZeroException exc2) when (z == 0) //else if z i equal to 0
              {
                  Console.WriteLine("z is equal to 0");
              }
              catch (DivideByZeroException exc3) //else
              {
                  Console.WriteLine("x is equal to 0");
              }*/

            #endregion

        }
    }
}
