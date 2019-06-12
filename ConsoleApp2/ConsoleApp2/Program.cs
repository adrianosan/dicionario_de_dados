using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, int> dc = new Dictionary<string, int>()
            {

                { "abc",1 },
                { "bbc" ,2 },
                { "cbc" ,3 },
                {"ebc", 4 }
                };

            foreach(KeyValuePair<string,int>pair in dc)
            {
                Console.WriteLine("{0},{1}", pair.Key, pair.Value);
            }

            Console.ReadKey();

        }
    }
}
