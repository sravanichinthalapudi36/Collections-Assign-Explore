using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace COLLECTIONASS
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList srt = new SortedList();
            srt.Add("5", "sravani");
            srt.Add("2", "balu");
            srt.Add("1", "Appu");
            srt.Add("4", "phani");
            srt.Add("3", "horlicks");
            Console.WriteLine("--------------using FOREACH loop-------------");
            foreach (DictionaryEntry kv in srt)
            {
                Console.WriteLine("{0}-->{1}", kv.Key, kv.Value);
            }
            IDictionaryEnumerator ide = srt.GetEnumerator();
            Console.WriteLine("-------------using ENUMERATOR----------------");
            while (ide.MoveNext())
            {
                Console.WriteLine(ide.Key + "--->" + ide.Value);
            }
            Console.WriteLine("----------------using Contains()-------------");
            if (srt.Contains("4") == true)
            {
                Console.WriteLine("Key is found!!!");
            }
            else
            {
                Console.WriteLine("key is not Found!!!");
            }
            Console.WriteLine("----------------using ContainsKey()----------");
            if (srt.ContainsKey("6") == true)
            {
                Console.WriteLine("key found!!");
            }
            else
            {
                Console.WriteLine("key is not found!!!!");
            }
            Console.WriteLine("--------------using containsValue()-----------");
            if (srt.ContainsValue("Appu") == true)
            {
                Console.WriteLine("value found!!");
            }
            else
            {
                Console.WriteLine("value is not found!!!!");
            }
            Console.WriteLine("---------------using capacity---------------");
            Console.WriteLine("Capacity is :  {0}", srt.Capacity);
            Console.WriteLine("----counting the elements in the list-------------");
            Console.WriteLine("Count Is : {0}", srt.Count);
            int i = 3;
            Console.WriteLine("key at index {0} is {1}", i, srt.GetKey(i));

            ICollection c = srt.Keys;
            Console.WriteLine("Displaying Content----------------------------");
            foreach (string str in c)
                Console.WriteLine(str + ": " + srt[str]);
            Console.WriteLine("-----------using readonly---------------------");
            Console.WriteLine(srt.IsReadOnly);
            Console.WriteLine("-------------------is fixedsize or not------------");
            Console.WriteLine(srt.IsFixedSize);
            Console.WriteLine("this property is used to get a value indicating whether access to a SortedList object is synchronized (thread safe) or not.");
            Console.WriteLine(srt.IsSynchronized);
            IList lis = srt.GetKeyList();

            // Prints the list of keys 
            Console.WriteLine("------------Key List---------------------------");
            foreach(DictionaryEntry id in srt)
            {
                Console.WriteLine("{0}",id.Key);
            }


            Console.Read();
        }
    }
}