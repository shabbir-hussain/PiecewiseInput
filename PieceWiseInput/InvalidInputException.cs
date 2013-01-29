using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PieceWiseInput
{
    class InvalidInputException:Exception
    {
        
        public string Message { get; set; }
        public InvalidInputException()
        {
            Message = "Invalid Inputs";
        }
    }
}
