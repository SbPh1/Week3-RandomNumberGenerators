using System;

namespace RandomNumberGenerators
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int myRandomNumber = rnd.Next(1, 11);//nr 1-10

            //Console.WriteLine($"Sinu juhuslik number on {myRandomNumber}");

            //programm kontrollib, kas genereeritud nr on suurem kui 5
            //kui genereeritud nr on suurem kui 5, programm kuvab
            //"juhuslik nr on {myRandomNumber}, see on suurem kui 5"
            //kui genereeritud nr on väiksem kui 5, programm kuvab
            //"juhuslik nr on {myRandomNumber}, see on väiksem kui 5"
            //kui genereeritud nr on 5, programm kuvab
            //"juhuslik nr on 5"
            //<, >, ==

            if (myRandomNumber > 5)
            {
                Console.WriteLine($"Juhuslik number on {myRandomNumber}, see on suurem kui 5");
            }
            else if (myRandomNumber < 5)
            {
                Console.WriteLine($"Juhuslik number on {myRandomNumber}, see on väiksem kui 5");
            }
            else
            {
                Console.WriteLine("Juhuslik number on 5");
            }
           


        }
    }
}
