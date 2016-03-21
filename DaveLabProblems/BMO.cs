using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    class BMO
    {

        public BMO()
        {
            //Up, Down, Left, Left, Right, Right, Down, Spin, Down, Up, Left, Right, Left, Down, Spin, Up, Down, Jump.
        }

        public string bmoCommands(string instructons)
        {
            List<string> InputCommands = new List<string>();
            InputCommands.Add("Up");
            InputCommands.Add("Down");
            InputCommands.Add("Left");
            InputCommands.Add("Left");
            InputCommands.Add("Right");
            InputCommands.Add("Right");
            InputCommands.Add("Down");
            InputCommands.Add("Spin");
            InputCommands.Add("Down");
            InputCommands.Add("Up");
            InputCommands.Add("Left");
            InputCommands.Add("Right");
            InputCommands.Add("Left");
            InputCommands.Add("Down");
            InputCommands.Add("Spin");
            InputCommands.Add("Up");
            InputCommands.Add("Down");
            InputCommands.Add("Jump");

            foreach (string commands in InputCommands)
            {
                Console.WriteLine(commands);
            }
            return instructons;
        }
        

    }
}
