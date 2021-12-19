
namespace Paint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.Circle = new System.Windows.Forms.Button();
            this.Rectangle = new System.Windows.Forms.Button();
            this.Wagon = new System.Windows.Forms.Button();
            this.Coal = new System.Windows.Forms.Button();
            this.Sand = new System.Windows.Forms.Button();
            this.Train = new System.Windows.Forms.Button();
            this.Radius = new System.Windows.Forms.TextBox();
            this.Weight = new System.Windows.Forms.TextBox();
            this.Height = new System.Windows.Forms.TextBox();
            this.Count = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DrawPanel
            // 
            this.DrawPanel.Location = new System.Drawing.Point(13, 76);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(775, 362);
            this.DrawPanel.TabIndex = 0;
            this.DrawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPanel_Paint);
            this.DrawPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseClick);
            // 
            // Circle
            // 
            this.Circle.Location = new System.Drawing.Point(13, 13);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(75, 23);
            this.Circle.TabIndex = 1;
            this.Circle.Text = "Circle";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.Location = new System.Drawing.Point(13, 47);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(75, 23);
            this.Rectangle.TabIndex = 2;
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // Wagon
            // 
            this.Wagon.Location = new System.Drawing.Point(94, 13);
            this.Wagon.Name = "Wagon";
            this.Wagon.Size = new System.Drawing.Size(75, 23);
            this.Wagon.TabIndex = 3;
            this.Wagon.Text = "Wagon";
            this.Wagon.UseVisualStyleBackColor = true;
            this.Wagon.Click += new System.EventHandler(this.Wagon_Click);
            // 
            // Coal
            // 
            this.Coal.Location = new System.Drawing.Point(94, 47);
            this.Coal.Name = "Coal";
            this.Coal.Size = new System.Drawing.Size(75, 23);
            this.Coal.TabIndex = 4;
            this.Coal.Text = "Coal";
            this.Coal.UseVisualStyleBackColor = true;
            this.Coal.Click += new System.EventHandler(this.Coal_Click);
            // 
            // Sand
            // 
            this.Sand.Location = new System.Drawing.Point(175, 13);
            this.Sand.Name = "Sand";
            this.Sand.Size = new System.Drawing.Size(75, 23);
            this.Sand.TabIndex = 5;
            this.Sand.Text = "Sand";
            this.Sand.UseVisualStyleBackColor = true;
            this.Sand.Click += new System.EventHandler(this.Sand_Click);
            // 
            // Train
            // 
            this.Train.Location = new System.Drawing.Point(175, 47);
            this.Train.Name = "Train";
            this.Train.Size = new System.Drawing.Size(75, 23);
            this.Train.TabIndex = 6;
            this.Train.Text = "Train";
            this.Train.UseVisualStyleBackColor = true;
            this.Train.Click += new System.EventHandler(this.Train_Click);
            // 
            // Radius
            // 
            this.Radius.Location = new System.Drawing.Point(336, 35);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(100, 23);
            this.Radius.TabIndex = 7;
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(442, 35);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(100, 23);
            this.Weight.TabIndex = 8;
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(548, 35);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(100, 23);
            this.Height.TabIndex = 9;
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(654, 35);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(100, 23);
            this.Count.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Radius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(682, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Count";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(256, 47);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 15;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.Radius);
            this.Controls.Add(this.Train);
            this.Controls.Add(this.Sand);
            this.Controls.Add(this.Coal);
            this.Controls.Add(this.Wagon);
            this.Controls.Add(this.Rectangle);
            this.Controls.Add(this.Circle);
            this.Controls.Add(this.DrawPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.Button Circle;
        private System.Windows.Forms.Button Rectangle;
        private System.Windows.Forms.Button Wagon;
        private System.Windows.Forms.Button Coal;
        private System.Windows.Forms.Button Sand;
        private System.Windows.Forms.Button Train;
        private System.Windows.Forms.TextBox Radius;
        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.TextBox Count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Clear;
    }
}

