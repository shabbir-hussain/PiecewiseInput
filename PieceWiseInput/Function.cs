using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PieceWiseInput
{
    /// <summary>
    /// A class to hold all the function parameters
    /// </summary>
    class Function
    {
        string functionStr;
        double from;
        double to;
        double increments;
        Parser fParser;
        double[] inputs;
        double[] outputs;

        //check for function validity before constructing
        public Function(string inputFuncion, string from, string to, string increments)
        {

            this.functionStr = inputFuncion;
            this.from = double.Parse(from);
            this.to = double.Parse(to);
            this.increments = double.Parse(increments);

            //how many inputs to function are needed
            int numberOfInputs = (int)Math.Abs((this.from - this.to) / this.increments)+1;
            inputs = new double[numberOfInputs];
            outputs = new double[numberOfInputs];

            //parse that fucntion
            fParser = new Parser();
            fParser.inputFuntion(functionStr);

            //calculate values
            for (int i = 0; i < numberOfInputs; i++)
            {
                outputs[i] = fParser.evalFuncAt(this.from + this.increments * i);
            }

            
        }

        public double[] getOutputs()
        {
            return outputs;
        }

        public override string ToString()
        {
            return this.functionStr + " [" + from + " :" + increments + ": " + to + "]";
        }
    }
}
