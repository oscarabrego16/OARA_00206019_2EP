using System;

namespace SourceCode.Modelo
{
    public class AlreadyExistingUsernameException : Exception
    {
        public AlreadyExistingUsernameException(string message) : base(message)
        {
        }
    }
}