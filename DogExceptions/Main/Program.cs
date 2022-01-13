using System;
using Exceptions;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dog Dog = new Dog("a",30);
            }
            catch (InvalidNameException ex)
            {

                Console.WriteLine(ex.Message);
            }
            

            try
            {
                Dog Dog = new Dog("azorel", 101);
            }
            catch (InvalidLifeExpetancy ex)
            {

                Console.WriteLine(ex.Message);
            }



        }
    }
}
