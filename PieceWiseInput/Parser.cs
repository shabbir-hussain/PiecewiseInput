using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PieceWiseInput
{
    class Parser
    {
        public static List<string> Methods;
        static Parser()
        {
            Methods = new List<string>();
            Methods.Add("ABS");
            Methods.Add("ACOS");
            Methods.Add("ASIN");
            Methods.Add("ATAN");
            Methods.Add("COS");
            Methods.Add("EXP");
            Methods.Add("LOG");
            Methods.Add("POW");
            Methods.Add("SIN");
            Methods.Add("SQRT");
            Methods.Add("TAN");
        }

        //string to double
        public static double stringToDouble(string input)
        {
           /* double result=0;
            bool negate = false;
            int ptr =0;
            
            //check for negation
            if (input.Length > 0 && input[ptr] == '-')
                negate = true;

            if (negate)
                result *= -1;*/

            return double.Parse(input);
        }

        //function = expression | method (expression)
        //expression = value | value operator value
        //value = double | x | doublex
        //operators = + - * / ^
        public static double evalFuncAt(string function, double x)
        {
            return 0;   
        }
        public enum ValType { NUMBER, OPpm,OPtd, VARIABLE, OPBRACKET, CLBRACKET,DECIMAL,LETTER };

        //=====instance members=======//
        private List<Token> funcToken;
        public Parser()
        {
            funcToken = null;
        }

        //get the numeric value the function at x
        public double evalFuncAt(double x)
        {
            if (funcToken == null)
                return 0;

            //plug in x
            foreach (var item in funcToken)
            {
                if (item.vType == ValType.VARIABLE)
                {
                    item.dValue = x;
                }
            }



            return 0;
        }

        private double eval(List<Token> Expression)
        {
            //evaluate using 
            //methods
            //brackets
            //exponents
            //divisions
            //multiplications
            //additions
            //subtractions

            //make copy
            List<Token> ExprCopy = new List<Token>();
            for (int i = 0; i < Expression.Count; i++)
            {
                ExprCopy.Add(new Token(Expression[i].vType, Expression[i].sValue));
            }

            //eval methods
            for (int i = 0; i < ExprCopy.Count; i++)
            {
                //if its the start of a method
                if (ExprCopy[i].vType == ValType.LETTER)
                {
                    //find args of method
                    int bracketDepth = 0;
                    List<Token> arguments = new List<Token>();
                    for (int j = i; j < ExprCopy.Count; j++)
                    {
                        if (ExprCopy[j].sValue == "(")
                            bracketDepth++;
                        else if (ExprCopy[j].sValue == "(")
                            bracketDepth--;

                        arguments.Add(ExprCopy[j]);
                        ExprCopy.RemoveAt(j);
                        j--;

                        if (bracketDepth == 0)
                            break;
                    }
                    
                    //recursively evaluate arguments
                    double dResult = eval(arguments);
                    Token tResult  = new Token(ValType.NUMBER,dResult.ToString());

                    //replace method with numeric value
                    ExprCopy[i] = tResult;

                }//end if
            }//end methods loop

            //eval brackets
            for (int i = 0; i < ExprCopy.Count; i++)
            {
                
            }



            return 0;
        }

        public void inputFuntion(string function)
        {
            funcToken = parseFunction(function);
        }

        public List<Token> parseFunction(string function)
        {
            //cannot have empty input
            if (function.Equals(""))
            {   //throw empty input exception
                InvalidInputException ex = new InvalidInputException();
                ex.Message = "Input is empty";
                throw ex;
            }

            //make all caps
            function = function.ToUpper();

            //list of tokens
            List<Token> tokens = new List<Token>();


            //========================================================================================//
            //== first break up the string into tokens from the categories listed in the enum below ==//

            //buffer to parse tokens with
            StringBuilder curToken = new StringBuilder();
            int ptr = 0;
            ValType lastvType = ValType.NUMBER;
            ValType curvType = ValType.NUMBER;

            //get first char type
            while (function[ptr] == ' ') //skip spaces
            {
                ptr++;
                if (ptr == function.Length)//check for empty strings
                {
                    InvalidInputException ex = new InvalidInputException();
                    ex.Message = "Input is empty";
                    throw ex;
                }
            }
            if (Regex.IsMatch(function[ptr].ToString(), "[*/^.)]"))
            {
                //throw invalid input
                InvalidInputException ex = new InvalidInputException();
                ex.Message = "* / ^ . ) not allowed at start";
                throw ex;
            }
            else if (function[ptr] == 'X')
                lastvType = ValType.VARIABLE;
            else if (function[ptr] == '(')
                lastvType = ValType.OPBRACKET;
            else if (Regex.IsMatch(function[ptr].ToString(), "[A-Z]"))
                lastvType = ValType.LETTER;
            else if (Regex.IsMatch(function[ptr].ToString(), "[+-]"))
                lastvType = ValType.OPpm;
            else if (Regex.IsMatch(function[ptr].ToString(), "[0-9]"))
                curvType = ValType.NUMBER;
            else
            {
                //throw invalid input
                InvalidInputException ex = new InvalidInputException();
                ex.Message = "Invalid input at start";
                throw ex;
            }

            curToken.Append(function[ptr]);
            ptr++;

            for (; ptr < function.Length; ptr++)
            {
                //get current value type
                if (function[ptr] == ' ') //skip spaces
                {
                    continue;
                }
                else if (Regex.IsMatch(function[ptr].ToString(), "[*/^]"))
                    curvType = ValType.OPtd;
                else if (function[ptr] == 'X')
                    curvType = ValType.VARIABLE;
                else if (function[ptr] == '(')
                    curvType = ValType.OPBRACKET;
                else if (function[ptr] == ')')
                    curvType = ValType.CLBRACKET;
                else if (function[ptr] == '.')
                    curvType = ValType.DECIMAL;
                else if (Regex.IsMatch(function[ptr].ToString(), "[A-Z]"))
                    curvType = ValType.LETTER;
                else if (Regex.IsMatch(function[ptr].ToString(), "[+-]"))
                    curvType = ValType.OPpm;
                else if (Regex.IsMatch(function[ptr].ToString(), "[0-9]"))
                    curvType = ValType.NUMBER;
                else
                {
                    //throw invalid input
                    InvalidInputException ex = new InvalidInputException();
                    ex.Message = "Invalid input at "+ptr;
                    throw ex;
                }

                //create comparison table
                switch (curvType)
                {
                    case ValType.NUMBER:
                        switch (lastvType)
                        {
                            case ValType.DECIMAL:
                                break;
                            case ValType.OPBRACKET:
                                tokens.Add(new Token(lastvType, curToken.ToString()));
                                curToken.Clear();
                                break;
                            case ValType.OPpm:
                                tokens.Add(new Token(lastvType, curToken.ToString()));
                                curToken.Clear();
                                break;
                            case ValType.OPtd:
                                tokens.Add(new Token(lastvType, curToken.ToString()));
                                curToken.Clear();
                                break;
                            case ValType.NUMBER:
                                break;
                            default:
                                {//not a valid input
                                    InvalidInputException Ex = (new InvalidInputException()); Ex.Message = "invalid input before character at " + ptr;
                                    throw Ex;
                                }
                                
                        }
                        break;

                    case ValType.OPpm:
                        switch (lastvType)
                        {
                            case ValType.NUMBER:
                                tokens.Add(new Token(lastvType, curToken.ToString()));
                                curToken.Clear();
                                break;
                            case ValType.VARIABLE:
                                tokens.Add(new Token(lastvType, curToken.ToString()));
                                curToken.Clear();
                                break;
                            case ValType.OPBRACKET:
                                tokens.Add(new Token(lastvType, curToken.ToString()));
                                curToken.Clear();
                                break;
                            case ValType.CLBRACKET:
                                tokens.Add(new Token(lastvType, curToken.ToString()));
                                curToken.Clear();
                                break;
                            default:
                                {//not a valid input
                                    InvalidInputException Ex = (new InvalidInputException()); Ex.Message = "invalid input before character at " + ptr;
                                    throw Ex;
                                }                                
                        }
                        break;
                    case ValType.OPtd:
                        switch (lastvType)
                        {
                            case ValType.NUMBER:
                                tokens.Add(new Token(lastvType, curToken.ToString()));
                                curToken.Clear();
                                break;
                            case ValType.VARIABLE:
                                tokens.Add(new Token(lastvType, curToken.ToString()));
                                curToken.Clear();
                                break;
                            case ValType.CLBRACKET:
                                tokens.Add(new Token(lastvType, curToken.ToString()));
                                curToken.Clear();
                                break;
                            default:
                                {//not a valid input
                                    InvalidInputException Ex = (new InvalidInputException()); Ex.Message = "invalid input before character at " + ptr;
                                    throw Ex;
                                }
                        }
                        break;
                    case ValType.VARIABLE:
                        switch (lastvType)
                        {
                            case ValType.OPtd:
                                tokens.Add(new Token(lastvType, curToken.ToString()));
                                curToken.Clear();
                                break;
                            case ValType.OPpm:
                                tokens.Add(new Token(lastvType, curToken.ToString()));
                                curToken.Clear();
                                break;
                            case ValType.OPBRACKET:
                                tokens.Add(new Token(lastvType, curToken.ToString()));
                                curToken.Clear();
                                break;
                            default:
                                {//not a valid input
                                    InvalidInputException Ex = (new InvalidInputException()); Ex.Message = "invalid input before character at " + ptr;
                                    throw Ex;
                                }
                        }
                        break;

                    case ValType.OPBRACKET:
                        switch (lastvType)
                        {
                            case ValType.OPpm:
                                tokens.Add(new Token(lastvType, curToken.ToString()));
                                curToken.Clear();
                                break;
                            case ValType.OPtd:
                                tokens.Add(new Token(lastvType, curToken.ToString()));
                                curToken.Clear();
                                break;
                            case ValType.OPBRACKET:
                                tokens.Add(new Token(lastvType, curToken.ToString()));
                                curToken.Clear();
                                break;
                            case ValType.LETTER:
                                tokens.Add(new Token(lastvType, curToken.ToString()));
                                curToken.Clear();
                                break;
                            default:
                                {//not a valid input
                                    InvalidInputException Ex = (new InvalidInputException()); Ex.Message = "invalid input before character at " + ptr;
                                    throw Ex;
                                }
                        }
                        break;

                    case ValType.CLBRACKET:
                        switch (lastvType)
                        {
                            case ValType.NUMBER:
                                tokens.Add(new Token(lastvType, curToken.ToString()));
                                curToken.Clear();
                                break;
                            case ValType.CLBRACKET:
                                tokens.Add(new Token(lastvType, curToken.ToString()));
                                curToken.Clear();
                                break;
                            case ValType.VARIABLE:
                                tokens.Add(new Token(lastvType, curToken.ToString()));
                                curToken.Clear();
                                break;
                            default:
                                {//not a valid input
                                    InvalidInputException Ex = (new InvalidInputException()); Ex.Message = "invalid input before character at " + ptr;
                                    throw Ex;
                                }
                        }
                        break;

                    case ValType.DECIMAL:
                        switch (lastvType)
                        {
                            case ValType.NUMBER:
                                break;
                            default:
                                {//not a valid input
                                    InvalidInputException Ex = (new InvalidInputException()); Ex.Message = "invalid input before character at " + ptr;
                                    throw Ex;
                                }
                        }
                        break;

                    case ValType.LETTER:
                        switch (lastvType)
                        {
                            case ValType.OPBRACKET:
                                tokens.Add(new Token(lastvType, curToken.ToString()));
                                curToken.Clear();
                                break;
                            case ValType.OPpm:
                                tokens.Add(new Token(lastvType, curToken.ToString()));
                                curToken.Clear();
                                break;
                            case ValType.OPtd:
                                tokens.Add(new Token(lastvType, curToken.ToString()));
                                curToken.Clear();
                                break;
                            case ValType.LETTER:
                                break;
                            default:
                                {//not a valid input
                                    InvalidInputException Ex = (new InvalidInputException()); Ex.Message = "invalid input before character at " + ptr;
                                    throw Ex;
                                }
                        }
                        break;
                    default:
                        break;
                }

                lastvType = curvType;
                curToken.Append(function[ptr]);
            }
            //handle last character
            tokens.Add(new Token(lastvType, curToken.ToString()));
            curToken.Clear();

            //===============check for input validity====================//
           
            //check for proper bracketing
            ptr = 0;
            int brackets = 0;
            for (; ptr < tokens.Count; ptr++)
            {
                if (tokens[ptr].vType == ValType.OPBRACKET)
                    brackets++;
                else if (tokens[ptr].vType == ValType.CLBRACKET)
                    brackets--;
            }
            if (brackets != 0)
            {
                InvalidInputException ex = new InvalidInputException();
                if (brackets > 0)
                    ex.Message = "Missing closing bracket";
                else
                    ex.Message = "Missing Opening bracket";
            }

            //check function ending
            //get last char type
            if (Regex.IsMatch(function[function.Length-1].ToString(), "[A-WYZ]"))
            {
                //throw invalid input
                InvalidInputException ex = new InvalidInputException();
                ex.Message = "A-WYZ*/^.(+- not allowed at ending";
                throw ex;
            }
            if (tokens[tokens.Count - 1].vType == ValType.OPtd
                || tokens[tokens.Count - 1].vType == ValType.OPpm
                || tokens[tokens.Count - 1].vType == ValType.OPBRACKET
                || tokens[tokens.Count - 1].vType == ValType.DECIMAL)
            {
                InvalidInputException ex = new InvalidInputException();
                ex.Message = "A-WYZ*/^.(+- not allowed at ending";
                throw ex;
            }
            

            return tokens;
        }
    }
}
