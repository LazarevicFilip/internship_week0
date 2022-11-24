using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internship_week0
{
    internal class CollectionExercise
    {
        public void ListTest()
        {
            var list = new List<int>() { 1,2,3,4,5};
            list.ForEach(x => Console.WriteLine(x));
        }

        public void DicionaryTest()
        {
            var dictionary = new Dictionary<string, int>() { { "one", 1 }, { "two", 2 }, { "three", 3 }};
            dictionary.Add("one", 1);
            foreach (KeyValuePair<string,int> d in dictionary)
            {
                Console.WriteLine($"Key: {d.Key},Value: {d.Value}");
            }
            //get values
            Dictionary<string, int>.ValueCollection valueColl = dictionary.Values;
            //get keys
            Dictionary<string, int>.KeyCollection keyColl = dictionary.Keys;

        }
        public void QueueTest()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Dequeue();
            foreach(int i in queue)
            {
                Console.WriteLine(i);
            }
        }
        public void StackTest()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("one");
            stack.Push("two");
            stack.Push("three");
            stack.Push("four");
            stack.Push("five");
            stack.Pop();

            foreach (string i in stack)
            {
                Console.WriteLine(i);
            }

        }
    
    }
}
