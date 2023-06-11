namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string []ae =new string [5];
            ae [0] = " aaddel";
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
        }
    }
}