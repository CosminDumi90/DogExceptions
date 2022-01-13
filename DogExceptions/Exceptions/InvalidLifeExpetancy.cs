using System;


namespace Exceptions
{
   public class InvalidLifeExpetancy:ApplicationException
    {
        public InvalidLifeExpetancy(string message="sad but dogs don't live this long"):base(message)
        {

        }
    }
}
