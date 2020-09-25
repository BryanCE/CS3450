using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3450_Program1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test ints
            QQueue<int> myQQueue = new QQueue<int>();
            Container<int> q = new Container<int>(myQQueue);
            q.Add(91);
            q.Add(92);

            // Swap implementation
            ListQ<int> list = new ListQ<int>();
            list.Add(93);
            q.ChangeImplementation(list);
            q.Add(94);
            q.Add(95);
            DisplayAndEmptyQueue(q);

            // Test strings
            QQueue<string> myQueue2 = new QQueue<string>();
            myQueue2.Add("Discard Me");
            Container<string> q2 = new Container<string>(myQueue2);
            q2.Add("91");
            q2.Add("92");

            // Swap Implementation
            ListQ<string> list2 = new ListQ<string>();
            list2.Add("93");
            q2.ChangeImplementation(list2);
            q2.Add("94");
            q2.Add("95");
            DisplayAndEmptyQueue(q2);
            Console.ReadLine();
            /* Output:
            91 92 94 95
            91 92 94 95
            */
        }//end main()

        public static void DisplayAndEmptyQueue<T>(Container<T> q)
        {
            if (q is null) return;
            while(q.Size() > 0)
            {
                var thing = q.Remove();
                Console.Write(thing.ToString());
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
