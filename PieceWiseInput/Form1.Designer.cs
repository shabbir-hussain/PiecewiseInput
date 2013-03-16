namespace PieceWiseInput
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.RemvFuncButton = new System.Windows.Forms.Button();
            this.AddFuncButton = new System.Windows.Forms.Button();
            this.FunctionlistBox = new System.Windows.Forms.ListBox();
            this.FunctionBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Range = new System.Windows.Forms.Label();
            this.RangeHighText = new System.Windows.Forms.TextBox();
            this.IncrementText = new System.Windows.Forms.TextBox();
            this.RangeLowText = new System.Windows.Forms.TextBox();
            this.graphPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BackgroundPanel.SuspendLayout();
            this.InputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.Controls.Add(this.InputPanel);
            this.BackgroundPanel.Controls.Add(this.graphPanel);
            this.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(797, 321);
            this.BackgroundPanel.TabIndex = 0;
            // 
            // InputPanel
            // 
            this.InputPanel.AutoScroll = true;
            this.InputPanel.AutoSize = true;
            this.InputPanel.Controls.Add(this.button1);
            this.InputPanel.Controls.Add(this.RemvFuncButton);
            this.InputPanel.Controls.Add(this.AddFuncButton);
            this.InputPanel.Controls.Add(this.FunctionlistBox);
            this.InputPanel.Controls.Add(this.FunctionBox);
            this.InputPanel.Controls.Add(this.label3);
            this.InputPanel.Controls.Add(this.label2);
            this.InputPanel.Controls.Add(this.label1);
            this.InputPanel.Controls.Add(this.Range);
            this.InputPanel.Controls.Add(this.RangeHighText);
            this.InputPanel.Controls.Add(this.IncrementText);
            this.InputPanel.Controls.Add(this.RangeLowText);
            this.InputPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.InputPanel.Location = new System.Drawing.Point(444, 0);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(353, 321);
            this.InputPanel.TabIndex = 1;
            // 
            // RemvFuncButton
            // 
            this.RemvFuncButton.Location = new System.Drawing.Point(114, 267);
            this.RemvFuncButton.Name = "RemvFuncButton";
            this.RemvFuncButton.Size = new System.Drawing.Size(116, 23);
            this.RemvFuncButton.TabIndex = 10;
            this.RemvFuncButton.Text = "Remove Function";
            this.RemvFuncButton.UseVisualStyleBackColor = true;
            this.RemvFuncButton.Click += new System.EventHandler(this.RemvFuncButton_Click);
            // 
            // AddFuncButton
            // 
            this.AddFuncButton.Location = new System.Drawing.Point(114, 124);
            this.AddFuncButton.Name = "AddFuncButton";
            this.AddFuncButton.Size = new System.Drawing.Size(113, 23);
            this.AddFuncButton.TabIndex = 9;
            this.AddFuncButton.Text = "Add Function To List";
            this.AddFuncButton.UseVisualStyleBackColor = true;
            this.AddFuncButton.Click += new System.EventHandler(this.AddFuncButton_Click);
            // 
            // FunctionlistBox
            // 
            this.FunctionlistBox.FormattingEnabled = true;
            this.FunctionlistBox.Location = new System.Drawing.Point(40, 153);
            this.FunctionlistBox.Name = "FunctionlistBox";
            this.FunctionlistBox.Size = new System.Drawing.Size(272, 108);
            this.FunctionlistBox.TabIndex = 8;
            // 
            // FunctionBox
            // 
            this.FunctionBox.Location = new System.Drawing.Point(90, 19);
            this.FunctionBox.Name = "FunctionBox";
            this.FunctionBox.Size = new System.Drawing.Size(206, 20);
            this.FunctionBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "F(x) = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "< X <";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Increments:";
            // 
            // Range
            // 
            this.Range.AutoSize = true;
            this.Range.Location = new System.Drawing.Point(21, 55);
            this.Range.Name = "Range";
            this.Range.Size = new System.Drawing.Size(42, 13);
            this.Range.TabIndex = 3;
            this.Range.Text = "Range:";
            // 
            // RangeHighText
            // 
            this.RangeHighText.Location = new System.Drawing.Point(215, 52);
            this.RangeHighText.Name = "RangeHighText";
            this.RangeHighText.Size = new System.Drawing.Size(82, 20);
            this.RangeHighText.TabIndex = 2;
            // 
            // IncrementText
            // 
            this.IncrementText.Location = new System.Drawing.Point(89, 92);
            this.IncrementText.Name = "IncrementText";
            this.IncrementText.Size = new System.Drawing.Size(82, 20);
            this.IncrementText.TabIndex = 1;
            // 
            // RangeLowText
            // 
            this.RangeLowText.Location = new System.Drawing.Point(89, 52);
            this.RangeLowText.Name = "RangeLowText";
            this.RangeLowText.Size = new System.Drawing.Size(82, 20);
            this.RangeLowText.TabIndex = 0;
            // 
            // graphPanel
            // 
            this.graphPanel.BackColor = System.Drawing.Color.White;
            this.graphPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.graphPanel.Location = new System.Drawing.Point(0, 0);
            this.graphPanel.Name = "graphPanel";
            this.graphPanel.Size = new System.Drawing.Size(383, 321);
            this.graphPanel.TabIndex = 0;
            this.graphPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.graphPanel_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 321);
            this.Controls.Add(this.BackgroundPanel);
            this.Name = "Form1";
            this.Text = "FunctionGenerator";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.BackgroundPanel.ResumeLayout(false);
            this.BackgroundPanel.PerformLayout();
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackgroundPanel;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Range;
        private System.Windows.Forms.TextBox RangeHighText;
        private System.Windows.Forms.TextBox IncrementText;
        private System.Windows.Forms.TextBox RangeLowText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FunctionBox;
        private System.Windows.Forms.Button RemvFuncButton;
        private System.Windows.Forms.Button AddFuncButton;
        private System.Windows.Forms.ListBox FunctionlistBox;
        private System.Windows.Forms.Panel graphPanel;
        private System.Windows.Forms.Button button1;


    }
}

