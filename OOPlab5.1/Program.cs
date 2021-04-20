using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlab5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time();
            time.Input();
            time.Minutes();
            time.Display();
            //Time time1 = new Time(time);
        }
    }
}
