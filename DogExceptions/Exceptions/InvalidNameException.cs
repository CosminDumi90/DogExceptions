using System;


namespace Exceptions
{
    public class InvalidNameException:ApplicationException
    {
        public InvalidNameException(string message="Invalid name, please try a longer name for your dog"):base(message)
        {

        }
    }
}
