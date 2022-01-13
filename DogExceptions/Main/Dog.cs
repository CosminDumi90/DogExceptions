using Exceptions;
using System;

namespace Main
{
    public class Dog
    {
        private string name;
        private int age;

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value <=0)
                {
                    throw new InvalidAgeException();
                }else if (value > 100)
                {
                    throw new InvalidLifeExpetancy();
                }
            }
        }

        public string Name
        {
            get
            {

                return this.name;
            }
            set
            {
                if (value.Length > 2)
                {
                    this.name = value;
                }
                else
                {
                    throw new InvalidNameException();
                }
            }
        }



        public Dog(string name, int age)
        {
            try
            {
                this.Name = name;
            }
            catch(InvalidNameException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                this.Age = age;
            }
            catch(InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(InvalidLifeExpetancy ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}
