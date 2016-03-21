using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    public class ElementCounter
    {

        public ElementCounter()
        {

        }
        
        public string ListCounter(string counter)
        {
            List<string> InputString = new List<string>();
            InputString.Add(Console.ReadLine());
            InputString.Add(Console.ReadLine());
            InputString.Add(Console.ReadLine());
            



            foreach (string word in InputString)
            {
                Console.WriteLine(InputString.Count); 
            }

            return counter;
        }
    }
}
