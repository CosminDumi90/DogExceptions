using System;


namespace Exceptions
{
   public class InvalidAgeException:ArgumentOutOfRangeException
    {
        public InvalidAgeException(string message="dog age should be a positive number"):base(message)
        {

        }
        
    }
}
