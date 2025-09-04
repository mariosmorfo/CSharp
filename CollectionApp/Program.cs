using System.Threading.Channels;

namespace CollectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var intList = new List<int>() { 1, 2, 3, 4, 5 };
            var linkedList = new LinkedList<string?>();
            var words = new SortedDictionary<int, string>() { { 1, "AUEB" }, { 2, "OPA" } };
            var stack = new Stack<string>();
            var queue = new Queue<string>();
            var charSet = new SortedSet<char>() { 'a', 'b', 'c', 'd' };

            intList.Add(4);
            intList.AddRange([1, 2, 3]);
            intList.Add(5);
            intList.Insert(0, 4);
            intList.RemoveAt(0);
            intList[0] = 4;
            intList[1] = 5;

            intList.Sort();
            intList.Reverse();

            foreach (int el in intList)
            {
                Console.WriteLine(el);
            }

            intList.ForEach(x => Console.WriteLine(x));
            intList.ForEach(Console.WriteLine);


            /*
             * LinkedList
             */

            var item1 = linkedList.AddFirst("Coding");
            var item2 = linkedList.AddAfter(item1, "Factory");
            var item3 = linkedList.AddLast("AUEB");

            linkedList.First!.Next!.Next!.Value = "Athens Uni of Econ and Bus";

            foreach (var el in linkedList)
            {
                Console.WriteLine(el);
            }

            linkedList.ToList().ForEach(x => Console.WriteLine(x));
            linkedList.ToList().ForEach(Console.WriteLine);





            //Dictionares

            words.Add(1, "ATHENS");
            words[2] = "Uni";
            words[3] = "Economics";

            words.Remove(3);

            if (words.ContainsKey(4))
            {
                Console.WriteLine("Contains 4");
            } else
            {
                words[4] = "Business";
            }

            foreach (var keyVal in words)
            {
                Console.WriteLine($"{keyVal.Key}, {keyVal.Value}");
            }

            words.ToList().ForEach(x => Console.WriteLine(x.Key + "," + x.Value));

            //Sets 

            var charSet2 = new SortedSet<char>() { '!', '@' };
            charSet.Add('x');
            charSet.Remove('a');

            charSet.UnionWith(charSet2);

            foreach(var ch in charSet)
            {
                Console.WriteLine(ch + " ");
            }

            //Stack push and pop
            stack.Push("Hello");
            stack.Push("Word");
            string popped = stack.Pop(); //Word
            Console.WriteLine(popped);

            foreach (var el in stack)
            {
                Console.WriteLine(el);
            }

            //Queue
            queue.Enqueue("car1");
            queue.Enqueue("car2");
            queue.Enqueue("car3");
            string car1 = queue.Dequeue();

            foreach(var car in queue)
            {
                Console.WriteLine(car);
            }
        }

    }
}
