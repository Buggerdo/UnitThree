namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] titles; //Declare array
            titles = new string[3]; //instantianting an empty arra with 3 elements

            titles[0] = "What about Bob";
            titles[1] = "Groundhog Day";
            //titles[2] = "";

            foreach(string item in titles)
            {
                Console.WriteLine(item);
            }

            int[] intArray = {1, 2, 3, 4, 5, 6, 15, 43, 10};

            foreach(int item in intArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}