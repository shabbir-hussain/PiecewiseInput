using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PieceWiseInput
{
    class FunctionBox
    {
        //position
        private int x;
        private int y;

        //inputs
        private System.Windows.Forms.Label Fx;
        private System.Windows.Forms.TextBox FunctionText;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.TextBox RangeLowText;
        private System.Windows.Forms.Label To;
        private System.Windows.Forms.TextBox RangeHighText;

        //math values
        public double d_RangeHigh { get; set; }
        public double d_RangleLow { get; set; }
        public string str_Function { get; set;}

        public FunctionBox(int xpos, int ypos, Panel contPanel)
        {
            //get position
            x = xpos;
            y = ypos;

            //init vars
            d_RangeHigh = 0;
            d_RangleLow = 0;
            str_Function = "";

            //init form objects
            Fx = new Label();
            FunctionText = new TextBox();
            From = new Label();
            RangeLowText = new TextBox();
            To = new Label();
            RangeHighText = new TextBox();

            //add to panel
            contPanel.Controls.Add(Fx);
            contPanel.Controls.Add(FunctionText);
            contPanel.Controls.Add(From);
            contPanel.Controls.Add(RangeLowText);
            contPanel.Controls.Add(To);
            contPanel.Controls.Add(RangeHighText);

            //init fx label;
            Fx.AutoSize = true;
            Fx.Location = new System.Drawing.Point(x, y);
            Fx.Size = new System.Drawing.Size(32, 13);
            Fx.Text = "F( x )= ";

            //init function input box
            FunctionText.Location = new System.Drawing.Point(x+40, y);
            FunctionText.Size = new System.Drawing.Size(182, 20);

            //init from
            From.AutoSize = true;
            From.Location = new System.Drawing.Point(x,y+22);
            From.Size = new System.Drawing.Size(32,13);
            From.Text = "From: ";

            //init range low text;
            RangeLowText.Location = new System.Drawing.Point(x+40,y+22);
            RangeLowText.Size = new System.Drawing.Size(40, 20);

            //init to box
            To.AutoSize = true;
            To.Location = new System.Drawing.Point(x+90,y+22);
            To.Size = new System.Drawing.Size(32,13);
            To.Text = " To ";

            //init range hihg
            RangeHighText.Location = new System.Drawing.Point(x+120,y+22);
            RangeHighText.Size = new System.Drawing.Size(40,20);



        }
    }
}
