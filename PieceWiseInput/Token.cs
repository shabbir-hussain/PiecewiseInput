using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PieceWiseInput
{
    class Token
    {
        public Parser.ValType vType { get; set; }
        public string sValue { get; set; }
        public double dValue { get; set; }
    

        public Token(Parser.ValType ivType, string isValue)
        {
            vType = ivType;
            sValue = isValue;
        }

        public override string ToString()
        {
            return sValue;
        }

        public bool isEqual(Token test)
        {
            if (test.sValue.Equals(this.sValue,StringComparison.OrdinalIgnoreCase) )
                if (test.vType == this.vType)
                    return true;
            return false;
        }
    }
}
