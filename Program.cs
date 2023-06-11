using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* string []ae =new string [5];
             ae[0] = "aaddel";
             ae[1] = "nasser";
             ae[2] = "subaiieh";
             ae[3] = "allesawed";
             ae[4] = "alfazari";

             for(int i=0; i<ae.Length; i++)
             {
                 Console.WriteLine(ae[i]);
             }

             int[] a = {1,5,7,9,10};
             int sum = 0;
             for(int i=0; i<a.Length; i++) 
             { 

                 sum += a[i]; 

             }
             Console.WriteLine(sum);
            */


            // average();
            //secondLargest();
            removDoublicat();
        }
        static void average()
        {
            /*Write a program that accepts an array of integers and calculates the average 
            of all the elements.*/
            Console.WriteLine("Write a program that accepts an array of integers and calculates the average of all the elements.");
            int[] marks = { 40, 67, 89, 56, 66, 90, 54, 78 };
            double sum1 = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                sum1 += marks[i];
            }
            double average = sum1 / marks.Length;
            Console.WriteLine("The averag of marks is = " + average);
        }

        static void maxMin()
        {



            Console.WriteLine("Write a program that accepts an array of integers and finds the maximum and minimum elements in the array");
            //Console.WriteLine("the maximum element is = "+marks.Max);
            int[] marks = { 45,35,56,67,64,53,63 };
            int max = marks[0];
            int min = marks[0];
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] > max)
                {
                    max = marks[i];
                }
                if (marks[i] < min)
                {
                    min = marks[i];
                }
            }
            Console.WriteLine("The maximum value is = " + max);
            Console.WriteLine("the minimum value is = " + min);
        }

        static void oddEven()
        {

            Console.WriteLine("Write a program that accepts an array of integers and counts the number of even and odd elements.");
            int[] marks = { 40, 67, 89, 56, 66, 90, 54, 78 };
            int evencounter = 0;
            int oddcounter = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] % 2 == 0)
                {
                    evencounter++;
                }
                if (marks[i] % 2 != 0)
                {
                    oddcounter++;
                }
            }
            Console.WriteLine("The  total even number are = " + evencounter);
            Console.WriteLine("the total odd number  are  = " + oddcounter);
        }


            static void secondLargest()
            {
                Console.WriteLine("Write a program that accepts an array of integers and finds the second largest element in the array.");

                int [] values= { 12, 34, 77, 20, 45, 23, 22 };
                int max = values[0];
                int secondmax =values[0];

                for(int i=0;i<values.Length ; i++) 
                {
                    if (values[i] > max)
                    {
                        secondmax = max;
                        max = values[i];
                    }
                    else if (values[i] > secondmax)
                    {
                        secondmax = values[i];
                    }
                }
                Console.WriteLine("The second largest element in the array is {0}", secondmax);

            }

        static void removDoublicat()
        {
            int[] nums = { 1, 2, 3, 4, 3, 55, 23, 2 };
            int[] dist = nums.Distinct().ToArray();
            for(int i=0;i<dist.Length;i++)
            {
                Console.WriteLine(dist[i]);

            }
        }


        
    }
}