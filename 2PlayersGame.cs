using System;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace snakeLadder
{
     class Program
    {
        public  int position = 0;
        public  int position2 = 0;
        public  int brk = 0;

        public  int currentPosition = 0;
        public  int currentPosition2 = 0;
        public  int endPosition = 100;
        public  int startposition = 0;

        public  int temp = 0;
        public  int temp2 = 0;
        public  int flag = 0;
        public  int flag2 = 0;
        public  int resultflag = 0;
        public  int flag3 = 0;
        public  int flag4 = 0;
        public  int player2resultflag = 0;
        public void start(string player)
        {
            const int NoPlay = 0;
            const int ladder = 1;
            const int snake = 2;
            bool Turn = true;
            while (Turn&&(currentPosition < endPosition))
            {
                
                Random random = new Random();
                int die = random.Next(1, 7); //1 to 6
                flag++;
                int prop = random.Next(3);   //0,1,2
                switch (prop)
                {
                    case NoPlay:
                        position = 0;
                        Turn= false;
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
                        Turn= false;
                        break;
                }

                currentPosition += (position);
                if (currentPosition < 100)
                {
                    Console.WriteLine("player1 >>>> die::{0} \t option::{1} \t position::{2}", die, prop, currentPosition);
                    temp = currentPosition;
                }
                if (currentPosition == 100)
                {

                    Console.WriteLine("Player1 >>>> die::{0} \t option::{1} \t position::{2}", die, prop, currentPosition);
                    Console.WriteLine("Player1 has won the game !!");
                    

                }

            }
           /* Console.WriteLine("dice rolled to reach win : " + flag);
            Console.WriteLine("dice rolled to reach exact win : " + flag2);*/
          //  resultflag = flag + flag2;
            
        }
        public void start2(string player)
        {
            const int NoPlay = 0;
            const int ladder = 1;
            const int snake = 2;
            bool Turn = true;
            while (Turn && (currentPosition < endPosition))
            {

                Random random = new Random();
                int die = random.Next(1, 7); //1 to 6
                flag3++;
                int prop = random.Next(3);   //0,1,2
                switch (prop)
                {
                    case NoPlay:
                        position = 0;
                        Turn = false;
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
                        Turn = false;
                        break;
                }

                currentPosition += (position);
                if (currentPosition < 100)
                {
                    Console.WriteLine("Player2 >>>> die::{0} \t option::{1} \t position::{2}", die, prop, currentPosition);
                    temp = currentPosition;
                }
                
                if (currentPosition == 100)
                {

                    Console.WriteLine("Player2 >>>> die::{0} \t option::{1} \t position::{2}", die, prop, currentPosition);
                    Console.WriteLine("Player2 has won the game !!");


                }




            }
            /* Console.WriteLine("dice rolled to reach win : " + flag);
             Console.WriteLine("dice rolled to reach exact win : " + flag2);*/
           // player2resultflag = flag3 + flag4;

        }

        /* Below writing the code to reach exact 100 */
        public void Player1exact(string player1)
        {
            const int NoPlay = 0;
            const int ladder = 1;
            const int snake = 2;
            bool Turn = true;
            while (Turn && endPosition < currentPosition && temp < endPosition)
            {

                Random random1 = new Random();
                int die1 = random1.Next(1, 7); //1 to 6
                flag2++;
                int prop1 = random1.Next(3);   //0,1,2
                switch (prop1)
                {
                    case NoPlay:
                        position = 0;
                        Turn = false;
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
                        Turn = false;
                        break;
                }
                temp += (position);
                if (temp == endPosition)
                {
                    Console.WriteLine("player1 >>>> die::{0} \t option::{1} \t position::{2}", die1, prop1, temp);
                    Console.WriteLine("Player1 has won the game !!");
                    

                }
            
            }
           
        }
        /* Below writing the code to reach exact 100 */
        public void Player2exact(string player2)
        {
            const int NoPlay = 0;
            const int ladder = 1;
            const int snake = 2;
        
            bool Turn = true;
            while (Turn && endPosition < currentPosition && temp < endPosition)
            {
                Random random9 = new Random();
                    int die9 = random9.Next(1, 7); //1 to 6
                    flag4++;
                    int prop9 = random9.Next(3);   //0,1,2
                    switch (prop9)
                    {
                        case NoPlay:
                            position = 0;
                            Turn = false;
                            break;
                        case ladder:
                            if (temp + die9 == endPosition)
                            {
                            position = die9;
                            }
                            else
                            {
                           
                                position = 0;
                            }
                            break;
                        case snake:
                            position = 0;
                            Turn = false;
                            break;
                    }
                    temp += (position);
                    if (temp == endPosition || currentPosition <= endPosition - 6)
                    {
                        Console.WriteLine("player2 >>>> die::{0} \t option::{1} \t position::{2}", die9, prop9, temp);
                        Console.WriteLine("Player2 has won the game !!");
                        

                }
                }

            
        }
        public static void Main(string[] args)
        {
            int Turn = 1;
            bool fuzz = true;
            int pin = 0;
            //   int lastPosition = 0;
            //  int player2lastPosition = 0;
            Console.WriteLine("Welcome to snack and ladder Game\n");
            Program player1 = new Program();
            Program player2 = new Program();
            while (player1.currentPosition < 100 && player2.currentPosition < 100)
            {
                if (Turn == 1)
                {
                    player1.start("Player 1");
                    Turn = 2;
                }
                else if (Turn == 2)
                {
                    player2.start2("Player 2");
                    Turn = 1;
                }

            }
            if(fuzz)
            { 
            while (player1.currentPosition > 100)
            {
                    pin++;
                if (Turn == 1)
                {
                    player1.Player1exact("Player1");
                    Turn = 2;
                }
                else if (Turn == 2)
                {
                   
                    
                        player2.Player2exact("Player2");
                    
                    Turn = 1;
                }

            }
                if (pin == 1)
                {
                    fuzz = true;
                }
                else
                {
                    fuzz= false;
                }
                
        }
            if(fuzz)
            {
                while (player2.currentPosition > 100)
                {
                    if (Turn == 1)
                    {
                        
                            player1.Player1exact("Player1");
                        
                        Turn = 2;
                    }
                    else if (Turn == 2)
                    {
                        player2.Player2exact("Player2");
                        Turn = 1;
                    }
                }
                fuzz= false;
            }
           
            
         

            player1.resultflag = player1.flag + player1.flag2;
            player2.player2resultflag= player2.flag3 + player2.flag4;

            Console.WriteLine("Player1>>>>the number of times die rolled : " + player1.resultflag);
            Console.WriteLine("Player2>>>>the number of times die rolled : " + player2.player2resultflag);

        }
 
     }
}
