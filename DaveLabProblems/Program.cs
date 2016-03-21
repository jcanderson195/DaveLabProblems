using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {

            ElementCounter newCounter = new ElementCounter();
            newCounter.ListCounter("Heat");
            
            ValueOfPi newPi = new ValueOfPi();
            newPi.piOutput();
            
            BMO comboMove = new BMO();
            comboMove.bmoCommands("Win");
           
            RotatedList rotateList = new RotatedList();
            rotateList.myListRotated();
            
            DancingMan newDanceMan = new DancingMan();
            newDanceMan.dancingMan();



        }
    }
}
