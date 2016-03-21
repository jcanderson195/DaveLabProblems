using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    class RotatedList
    {
        
        public RotatedList()
        {

        }

        public void myListRotated()
        {
            

            List<int> newRotatedList = new List<int>();
            newRotatedList.Add(1);
            newRotatedList.Add(2);
            newRotatedList.Add(3);

            newRotatedList[0] += 5;
            newRotatedList[1] += 5;
            newRotatedList[2] += 5;

            newRotatedList.Remove(6);
            newRotatedList.Insert(2, 6);
            
            

           foreach (int num in newRotatedList)
            {
                Console.WriteLine(num);
            }

          

        }

    }
}
