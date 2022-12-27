using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace snakeLadder
{
    public class optionPlay
    {
        public static void start()
        {
            int position = 0;
            Random random= new Random();
            int die = random.Next(1, 7);
            int prop=random.Next(3);
            const int NoPlay=0;
            const int ladder = 1;
            const int snake = 2;
              switch (prop)
                {
                    case NoPlay: 
                                 break;
                    case ladder: position = die;
                                 break;
                    case snake:  position = position - die;
                                 break;
                }
            Console.WriteLine("die::{0} \t option::{1} \t position::{2}",die, prop,position);
        }
    }
}
