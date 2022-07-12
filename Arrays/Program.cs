namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //string[] titles; //Declare array
            //titles = new string[3]; //instantianting an empty arra with 3 elements

            //titles[0] = "What about Bob";
            //titles[1] = "Groundhog Day";
            ////titles[2] = "";

            //foreach(string item in titles)
            //{
            //    Console.WriteLine(item);
            //}

            int[] intArray = { 1, 2, 3, 4, 5, 6, 15, 43, 10 };

            int oddNumber = intArray.Count(n => n % 2 == 1);
            Console.WriteLine(oddNumber);

            //foreach(int item in intArray)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //decimal[] prices = { 2.50m, 9.99m, 5.00m };
            //decimal sum = 0;
            //foreach(decimal item in prices)
            //{
            //    sum += item;
            //}

            //Console.WriteLine(prices.Average());

            //for(int i = 0; i < intArray.Length; i++)
            //{
            //    Console.WriteLine(intArray[i]);
            //    intArray[i] += 1;
            //    Console.WriteLine(intArray[i]);
            //}
        }
    }
}