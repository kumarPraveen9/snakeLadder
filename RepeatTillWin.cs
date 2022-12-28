using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace snakeLadder
{
    public class RepeatTillWin
    {
        public static void start()
        {
            int position = 0;
            int currentPosition = 0;
            int endPosition = 100;
            int startposition = 0;
            const int NoPlay = 0;
            const int ladder = 1;
            const int snake = 2;
            int temp = 0;
            while (currentPosition < endPosition)
            {
                Random random = new Random();
                int die = random.Next(1, 7); //1 to 6
                int prop = random.Next(3);   //0,1,2
                switch (prop)
                {
                    case NoPlay:
                        position = 0;
                        break;
                    case ladder:
                        position = die;
                        break;
                    case snake:
                        if (currentPosition > 0)
                        {
                            position = 0;
                            currentPosition = currentPosition - die;
                            if (currentPosition < 0)
                            {
                                currentPosition = startposition;
                            }
                        }
                        else
                        {
                            currentPosition = startposition;
                        }
                        break;
                }

                currentPosition += (position);
                if (currentPosition <= 100)
                {
                    Console.WriteLine("die::{0} \t option::{1} \t position::{2}", die, prop, currentPosition);
                    temp = currentPosition;
                }

                /* Below writing the code to reach exact 100 */

                if (endPosition < currentPosition)
                {
                    while (temp < endPosition)
                    {
                        Random random1 = new Random();
                        int die1 = random.Next(1, 7); //1 to 6
                        int prop1 = random.Next(3);   //0,1,2
                        switch (prop1)
                        {
                            case NoPlay:
                                position = 0;
                                break;
                            case ladder:
                                if (temp + die1 == endPosition)
                                {
                                    position = die1;
                                }
                                else
                                {
                                    position = 0;
                                }
                                break;
                            case snake:
                                position = 0;
                                break;
                        }
                        temp += (position);
                        if (temp == endPosition)
                        {
                            Console.WriteLine("die::{0} \t option::{1} \t position::{2}", die1, prop1, temp);
                        }
                    }

                }
            }
        }


    }
}
