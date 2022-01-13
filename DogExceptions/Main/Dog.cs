using Exceptions;

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
            this.Name = name;
            this.Age = age;
        }


    }
}
