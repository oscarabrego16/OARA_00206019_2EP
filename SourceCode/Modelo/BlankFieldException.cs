using System;

namespace SourceCode.Modelo
{
    public class BlankFieldException : Exception
    {
        public BlankFieldException(string message) : base(message)
        {
        }
    }
}