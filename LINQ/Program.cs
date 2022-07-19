namespace LINQ
{
    internal class Program
    {
        static void Main()
        {
            List<int> intList = new List<int>() { 99, 33, 44, 1, 120, 130, 99999999 };
            List<string> wordList = new List<string>()
            {
                "banana",
                "computer",
                "aardvark",
                "zebra",
                "computer",
                "clouds"
            };

            List<int> numsLessThen100 = intList.Where(x => x < 100).ToList();

            List<int> orderedList = intList.Where(n => n < 100).OrderBy(n => n).ToList();

            //wordList.Where(s => s == "computer")
            //    .ToList()
            //    .ForEach(w => Console.WriteLine(w));

            //intList.OrderBy(x => x)
            //    .ToList()
            //    .ForEach(i => Console.WriteLine(i));

            //wordList.OrderByDescending(x => x)
            //    .ToList()
            //    .ForEach(w => Console.WriteLine(w));



            foreach(int x in orderedList)
            {
                Console.WriteLine(x);
            }
        }
    }
}