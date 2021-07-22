// Program to show the differences between Value type and Reference type of parameters.
using System;

namespace csoop
{
    class ValueReferenceType
    {

        static int ValueTypeCube(int number)
        {
            return number * number * number;
        }

        static void ReferenceTypeCube(ref int number)
        {
            number = number * number * number;
            System.Console.WriteLine(number);
        }

        static void Main(string[] args)
        {
            int number = 5;
            System.Console.WriteLine("Before calling any method, value of number is : " + number);

            // Calling ValueTypeCube : maintains the original value of number (here, 5) in the Main class.

            System.Console.Write("\nCalling ValueTypeCube method : ");
            System.Console.WriteLine(ValueTypeCube(number));
            System.Console.WriteLine("After calling ValueTypeCube method, value of number is : " + number);

            // Calling ReferenceTypeCUbe : changes the original value of number (here, 5) to 125 (bcz, cube of 5 = 125) in the method as well as in Main class.

            System.Console.WriteLine("\nCurrent value of number is : " + number);
            System.Console.Write("\nRepresenting value returned from ReferenceTypeCube method : ");
            ReferenceTypeCube(ref number);

            // To know if the above method changed value of number in Main class 

            System.Console.WriteLine("\nValue of number now : " + number);

        }
    }
}
