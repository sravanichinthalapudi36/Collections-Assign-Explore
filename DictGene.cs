using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace COLLECTIONASS
{
    class DictGene
    {
        static void Main()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("1123", "Welcome");
            dict.Add("1124", "to");
            dict.Add("1125", "Restarants");
            dict.Add("1126", "hello");
            dict.Add("1127", "ppl");
            dict.Add("1128", "Resf");
            Console.WriteLine("--------------------using Enumerator-----------");
            IDictionaryEnumerator en = dict.GetEnumerator();
            while (en.MoveNext())
                Console.WriteLine(en.Key + " --> "  + en.Value);

            Console.WriteLine("------------using values---------------------");
            Dictionary<string, string>.ValueCollection valueColl =dict.Values;


            foreach (string s in valueColl)
            {
                Console.WriteLine("Value = {0}", s);


            }
            Dictionary<string, string>.KeyCollection keyColl = dict.Keys;

            Console.WriteLine("------------------using Keys------------------");
            foreach (string s1 in keyColl)
            {
                Console.WriteLine("key are = {0}", s1);


            }
            Console.WriteLine("count of dictionary is:{0}",dict.Count);
            Console.WriteLine("type  is:{0}",dict.GetType());
            Console.Write("\n\nValue associated with the value: ");
            Console.Write(dict["1123"]);

        }
    }
}
