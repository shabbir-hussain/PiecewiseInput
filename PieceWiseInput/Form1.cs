using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PieceWiseInput
{
    public partial class Form1 : Form
    {
        FunctionBox f1;
        public Form1()
        {
            InitializeComponent();
            f1 = new FunctionBox(21, 120, this.InputPanel);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphicsObj;
            graphicsObj = this.CreateGraphics();

            Pen myPen = new Pen(System.Drawing.Color.Red, 10);
            graphicsObj.DrawLine(myPen, 20, 20, 200, 210);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
