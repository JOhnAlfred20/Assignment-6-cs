using System;

namespace Assignment_6_cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1: Difference Between Passing by Value and by Reference
            Console.WriteLine("Question 1: Difference Between Passing by Value and by Reference");

            string str = "Original String";

            //value دي هنباصي ال 
            ModifyByValue(str);
            Console.WriteLine("After ModifyByValue: " + str);

            // Referenceدي هنباصي ال
            ModifyByReference(ref str);
            Console.WriteLine("After ModifyByReference: " + str);

            Console.WriteLine();

            //  call نيجي بقي نعملها 


            static void ModifyByValue(string str)
            {
                str = "Changed Inside ModifyByValue";
            }

            static void ModifyByReference(ref string str)
            {
                str = "Changed Inside ModifyByReference";
            }
            #endregion


            //---------------------------------------------

            #region Question 2: Summation and Subtraction
            Console.WriteLine("Question 2: Summation and Subtraction Function");

            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.Write("Enter fourth number: ");
            int num4 = int.Parse(Console.ReadLine());

            var result = Calculate(num1, num2, num3, num4);
            Console.WriteLine($"Summation: {result.sum}");
            Console.WriteLine($"Subtraction: {result.difference}");

            Console.WriteLine();



            // نديله بقي العمليات بتاع الجمع والطرح 
            static (int sum, int difference) Calculate(int num1, int num2, int num3, int num4)
            {
                int sum = num1 + num2 + num3 + num4;
                int difference = num1 - num2 - num3 - num4;
                return (sum, difference);
            }
            #endregion

            //-------------------------------------------------------------------------------------------------------------------------------------------------

            #region Question 3: MinMaxArray
            Console.WriteLine("Question 3: MinMaxArray Function");

            int[] array = { 3, 1, 7, 5, 9, 2 };
            int min = 0, max = 0;

            MinMaxArray(array, ref min, ref max);

            Console.WriteLine($"Minimum value: {min}");
            Console.WriteLine($"Maximum value: {max}");

            Console.WriteLine();


            static void MinMaxArray(int[] arr, ref int min, ref int max)
            {
                min = arr[0];
                max = arr[0];

                foreach (int num in arr)
                {
                    if (num < min)
                        min = num;

                    if (num > max)
                        max = num;
                }
            }
            #endregion

        }
    }
}
