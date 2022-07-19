namespace Collocations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random random = new Random();
            //double[] randomeDoubles = new double[20];

            //for(int i = 0; i < randomeDoubles.Length; i++)
            //{
            //    double value = random.NextDouble();
            //    randomeDoubles[i] = value;
            //}
            //foreach(var item in randomeDoubles)
            //{
            //    Console.WriteLine(item);
            //}


            //Stack<int> numberStack = new Stack<int>();
            //numberStack.Push(1);
            //numberStack.Push(2);
            //numberStack.Push(3);
            //numberStack.Push(4);
            //numberStack.Push(5);

            //foreach(int n in numberStack)
            //{
            //    Console.WriteLine(n);
            //}
            //Console.WriteLine("\n\n");
            //Console.WriteLine(numberStack.Pop());
            //Console.WriteLine("\n\n");
            //Console.WriteLine(numberStack.Peek());
            //Console.WriteLine(numberStack.Contains(4));

            //foreach(int i in numberStack)
            //{
            //    Console.WriteLine(i);
            //}

            Queue<string> names = new Queue<string>();
            names.Enqueue("Troy");
            names.Enqueue("Bob");
            names.Enqueue("Pickle");
            names.Enqueue("Collin");
            names.Enqueue("Jude");
            names.Enqueue("Amy");

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\n\n\n");
            Console.WriteLine(names.Dequeue());
            Console.WriteLine(names.First());
            Console.WriteLine(names.Contains("Amy"));

        }
    }
}