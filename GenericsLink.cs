using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace COLLECTIONASS
{
    class GenericsLink
    {
        static void Main()
        {
            LinkedList<String> list = new LinkedList<String>();
            list.AddLast("one");
            list.AddLast("two");
            list.AddLast("three");
            list.AddLast("four");
            list.AddLast("five");
            list.AddLast("six");
            list.AddLast("seven");
            Console.WriteLine("-------elements in the linkedlist---------------");
            foreach (var st in list)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine("--------------using Enumerator-------------------");
            LinkedList<string>.Enumerator ll = list.GetEnumerator();
            while (ll.MoveNext())
            {
                Console.WriteLine(ll.Current);
            }
            Console.WriteLine("remove paricualr element-------------------");
            list.Remove("one");
            foreach(var e in list)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("remove at first-------------------------");
            list.RemoveFirst();
            foreach (var e in list)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Removes at last------------------------------");
            list.RemoveLast();
            foreach (var e in list)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Add at first---------------------------------");
            list.AddFirst("hello");
            foreach (var e in list)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("add at last---------------------------------");
            list.AddLast("Sravss");
            foreach (var e in list)
            {
                Console.WriteLine(e);
            }
            var newNode = list.AddLast("Brad");
            list.AddBefore(newNode, "wowo super");
            Console.WriteLine("LinkedList after adding new nodes...");
            foreach (var stu in list)
            {
                Console.WriteLine(stu);
            }
            var newNode1 = list.AddFirst("welcome");
            list.AddAfter(newNode1, "zensarians");
            Console.WriteLine("LinkedList after adding new nodes...");
            foreach (var stu in list)
            {
                Console.WriteLine(stu);
            }
            Console.WriteLine("using find()--------------------------");

            LinkedListNode<string> temp = list.Find("hello");

            Console.WriteLine(temp.Value);
        }
    }
}
