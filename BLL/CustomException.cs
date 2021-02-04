using System;
using System.Collections.Generic;
using System.Text;


namespace BLL
{
    class CustomException : Exception
    {
        public CustomException() : base() { }
        public CustomException(string msg) : base(msg) { }
    }
}
