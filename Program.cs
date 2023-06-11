using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string []ae =new string [5];
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

            /*Write a program that accepts an array of integers and calculates the average 
            of all the elements.*/
            Console.WriteLine("Write a program that accepts an array of integers and calculates the average of all the elements.");
            int[] marks = { 40, 67, 89, 56, 66, 90, 54, 78 };
            int sum1 = 0;
            for(int i= 0; i<marks.Length; i++)
            {
                sum1 += marks[i];
            }
            double average= sum1 / marks.Length;
            Console.WriteLine("The averag of marks is = "+average);

            Console.WriteLine("Write a program that accepts an array of integers and finds the maximum and minimum elements in the array");
            //Console.WriteLine("the maximum element is = "+marks.Max);
            int max = marks[0];
            int min = marks[0];
            for (int i = 0; i < marks.Length ; i++)
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
            Console.WriteLine("The maximum value is = "+max);
            Console.WriteLine("the minimum value is = "+min);

            Console.WriteLine("Write a program that accepts an array of integers and counts the number of even and odd elements.");

            int evencounter = 0;
            int oddcounter  = 0;
            for (int i= 0;i<marks.Length ; i++)
            {
                if (marks[i] % 2==0) 
                {
                evencounter++;
                }
                if (marks[i] %2 !=0) 
                { 
                    oddcounter++;
                }
            }
            Console.WriteLine("The  total even number are = " + evencounter);
            Console.WriteLine("the total odd number  are  = " + oddcounter);
        }
    }
}