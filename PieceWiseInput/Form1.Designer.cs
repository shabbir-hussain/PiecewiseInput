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
            this.graphPanel = new System.Windows.Forms.Panel();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.RangeLowText = new System.Windows.Forms.TextBox();
            this.IncrementText = new System.Windows.Forms.TextBox();
            this.RangeHighText = new System.Windows.Forms.TextBox();
            this.Range = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.BackgroundPanel.Size = new System.Drawing.Size(749, 299);
            this.BackgroundPanel.TabIndex = 0;
            // 
            // graphPanel
            // 
            this.graphPanel.BackColor = System.Drawing.Color.White;
            this.graphPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.graphPanel.Location = new System.Drawing.Point(0, 0);
            this.graphPanel.Name = "graphPanel";
            this.graphPanel.Size = new System.Drawing.Size(383, 299);
            this.graphPanel.TabIndex = 0;
            // 
            // InputPanel
            // 
            this.InputPanel.AutoScroll = true;
            this.InputPanel.Controls.Add(this.label2);
            this.InputPanel.Controls.Add(this.label1);
            this.InputPanel.Controls.Add(this.Range);
            this.InputPanel.Controls.Add(this.RangeHighText);
            this.InputPanel.Controls.Add(this.IncrementText);
            this.InputPanel.Controls.Add(this.RangeLowText);
            this.InputPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.InputPanel.Location = new System.Drawing.Point(389, 0);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(360, 299);
            this.InputPanel.TabIndex = 1;
            // 
            // RangeLowText
            // 
            this.RangeLowText.Location = new System.Drawing.Point(89, 30);
            this.RangeLowText.Name = "RangeLowText";
            this.RangeLowText.Size = new System.Drawing.Size(82, 20);
            this.RangeLowText.TabIndex = 0;
            // 
            // IncrementText
            // 
            this.IncrementText.Location = new System.Drawing.Point(89, 70);
            this.IncrementText.Name = "IncrementText";
            this.IncrementText.Size = new System.Drawing.Size(82, 20);
            this.IncrementText.TabIndex = 1;
            // 
            // RangeHighText
            // 
            this.RangeHighText.Location = new System.Drawing.Point(215, 30);
            this.RangeHighText.Name = "RangeHighText";
            this.RangeHighText.Size = new System.Drawing.Size(82, 20);
            this.RangeHighText.TabIndex = 2;
            // 
            // Range
            // 
            this.Range.AutoSize = true;
            this.Range.Location = new System.Drawing.Point(21, 33);
            this.Range.Name = "Range";
            this.Range.Size = new System.Drawing.Size(42, 13);
            this.Range.TabIndex = 3;
            this.Range.Text = "Range:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Increments:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "< X <";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 299);
            this.Controls.Add(this.BackgroundPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.BackgroundPanel.ResumeLayout(false);
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackgroundPanel;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.Panel graphPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Range;
        private System.Windows.Forms.TextBox RangeHighText;
        private System.Windows.Forms.TextBox IncrementText;
        private System.Windows.Forms.TextBox RangeLowText;


    }
}

