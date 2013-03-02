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

            if (vType == Parser.ValType.NUMBER)
            {
                if(sValue.Equals("PI"))
                    dValue = Math.PI;
                else
                    dValue =Parser.stringToDouble(sValue);
            }
        }
        public Token(double value)
        {
            vType = Parser.ValType.NUMBER;
            sValue = value.ToString();
            dValue = value;
        }

        public override string ToString()
        {
            return sValue;
        }

        //check if two string values are equal
        public bool isEqual(Token test)
        {
            if (test.sValue.Equals(this.sValue,StringComparison.OrdinalIgnoreCase) )
                if (test.vType == this.vType)
                    return true;
            return false;
        }
    }
}
