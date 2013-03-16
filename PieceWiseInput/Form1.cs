using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PieceWiseInput
{
    public partial class Form1 : Form
    {
        List<Function> funcList = new List<Function>();
        List<double> Graphpoints = new List<double>();
        double graphZeroProportion = 0.5;
        double graphMax = 0;
        double graphMin = 0;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            //resize the graph portion of the program
            this.graphPanel.Width = this.InputPanel.Left;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //add function to list
        private void AddFuncButton_Click(object sender, EventArgs e)
        {
            
            //validate input
            if (FunctionBox.Text.Equals("") ||
                RangeLowText.Text.Equals("") ||
                RangeHighText.Text.Equals("") ||
                IncrementText.Text.Equals(""))
            {
                MessageBox.Show("Missing inputs");
                return;
            }

            //validate the function
            Function userInput = null; 
            try
            {
                userInput = new Function(this.FunctionBox.Text, this.RangeLowText.Text, this.RangeHighText.Text, this.IncrementText.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (userInput == null)
                return;

            //add valid function to list
            funcList.Add(userInput);
            this.FunctionlistBox.Items.Add(funcList[funcList.Count-1].ToString());

            //draw new pts
            this.redrawGraph();
        }
        //remv selected function
        private void RemvFuncButton_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //resize the graph portion of the program
            this.graphPanel.Width = this.InputPanel.Left;
        }

        //redraw graph portion
        private void redrawGraph()
        {
            //erase list of points
            this.Graphpoints = new List<double>();

            //populate list of graphpoints
            foreach (Function element in funcList)
            {
                foreach(double num in element.getOutputs())
                {
                    this.Graphpoints.Add(num);
                }
            }

            //check if points
            if (Graphpoints.Count == 0)
                return;

            graphMax = Graphpoints[0];
            graphMin = Graphpoints[0];

            //find max and min
            foreach (double point in Graphpoints)
            {
                if (point > graphMax)
                    graphMax = point;
                else if (point < graphMin)
                    graphMin = point;
            }
            
            //find where to plot zero
            if (graphMax < 0) //negative values only
                graphZeroProportion = 0;
            else if (graphMin > 0) //positive values only
                graphZeroProportion = 1;
            else//both ranges
            {
                //use divider formula
                graphZeroProportion = graphMax / (graphMax - graphMin);
            }

            this.graphPanel.Invalidate();
        }

        private void graphPanel_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphicsObj;
            graphicsObj = e.Graphics;
            
            //draw axes
            Pen myPen = new Pen(System.Drawing.Color.Black, 2);
            graphicsObj.DrawLine(myPen, 0, 1, 0, e.ClipRectangle.Height-1);
            graphicsObj.DrawLine(myPen, 0, (int)(e.ClipRectangle.Height * graphZeroProportion), e.ClipRectangle.Right - 1,(int) (e.ClipRectangle.Height * graphZeroProportion));

            int ptsToDraw = e.ClipRectangle.Width;

            Brush curve = new SolidBrush(Color.Red);
            for(int x=0;x < ptsToDraw; x++)
            {
                if (x < Graphpoints.Count)
                {
                    Rectangle pt = new Rectangle(x,e.ClipRectangle.Height-(int)(Graphpoints[x]/graphMax*e.ClipRectangle.Height), 1, 1);
                    graphicsObj.FillRectangle(curve, pt);
                }
            }

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile = File.CreateText("output.csv");
            //populate list of graphpoints
            foreach (Function element in funcList)
            {
                foreach (double num in element.getOutputs())
                {
                    outputFile.WriteLine(num);
                }
            }
            outputFile.Close();
        }
    }
}
