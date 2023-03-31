
namespace TriDemo
{
    partial class formMain
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
            this.components = new System.ComponentModel.Container();
            this.buttonCreateTriangle = new System.Windows.Forms.Button();
            this.textVertexA = new System.Windows.Forms.TextBox();
            this.labelVertexA = new System.Windows.Forms.Label();
            this.labelVertexB = new System.Windows.Forms.Label();
            this.textVertexB = new System.Windows.Forms.TextBox();
            this.labelVertexC = new System.Windows.Forms.Label();
            this.textVertexC = new System.Windows.Forms.TextBox();
            this.groupTriangle = new System.Windows.Forms.GroupBox();
            this.drawingCanvas = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupPointGeneration = new System.Windows.Forms.GroupBox();
            this.labelInterval = new System.Windows.Forms.Label();
            this.textInterval = new System.Windows.Forms.TextBox();
            this.buttonStopGen = new System.Windows.Forms.Button();
            this.buttonStartGen = new System.Windows.Forms.Button();
            this.buttonGenerateTriangle = new System.Windows.Forms.Button();
            this.textPointSize = new System.Windows.Forms.TextBox();
            this.labelPointSIze = new System.Windows.Forms.Label();
            this.groupTriangle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingCanvas)).BeginInit();
            this.groupPointGeneration.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreateTriangle
            // 
            this.buttonCreateTriangle.Location = new System.Drawing.Point(34, 170);
            this.buttonCreateTriangle.Name = "buttonCreateTriangle";
            this.buttonCreateTriangle.Size = new System.Drawing.Size(175, 29);
            this.buttonCreateTriangle.TabIndex = 0;
            this.buttonCreateTriangle.Text = "Create Triangle";
            this.buttonCreateTriangle.UseVisualStyleBackColor = true;
            this.buttonCreateTriangle.Click += new System.EventHandler(this.buttonCreateTriangle_Click);
            // 
            // textVertexA
            // 
            this.textVertexA.Location = new System.Drawing.Point(73, 32);
            this.textVertexA.Name = "textVertexA";
            this.textVertexA.Size = new System.Drawing.Size(136, 27);
            this.textVertexA.TabIndex = 1;
            // 
            // labelVertexA
            // 
            this.labelVertexA.AutoSize = true;
            this.labelVertexA.Location = new System.Drawing.Point(34, 35);
            this.labelVertexA.Name = "labelVertexA";
            this.labelVertexA.Size = new System.Drawing.Size(19, 20);
            this.labelVertexA.TabIndex = 2;
            this.labelVertexA.Text = "A";
            // 
            // labelVertexB
            // 
            this.labelVertexB.AutoSize = true;
            this.labelVertexB.Location = new System.Drawing.Point(34, 82);
            this.labelVertexB.Name = "labelVertexB";
            this.labelVertexB.Size = new System.Drawing.Size(18, 20);
            this.labelVertexB.TabIndex = 4;
            this.labelVertexB.Text = "B";
            // 
            // textVertexB
            // 
            this.textVertexB.Location = new System.Drawing.Point(73, 79);
            this.textVertexB.Name = "textVertexB";
            this.textVertexB.Size = new System.Drawing.Size(136, 27);
            this.textVertexB.TabIndex = 3;
            // 
            // labelVertexC
            // 
            this.labelVertexC.AutoSize = true;
            this.labelVertexC.Location = new System.Drawing.Point(34, 129);
            this.labelVertexC.Name = "labelVertexC";
            this.labelVertexC.Size = new System.Drawing.Size(18, 20);
            this.labelVertexC.TabIndex = 6;
            this.labelVertexC.Text = "C";
            // 
            // textVertexC
            // 
            this.textVertexC.Location = new System.Drawing.Point(73, 126);
            this.textVertexC.Name = "textVertexC";
            this.textVertexC.Size = new System.Drawing.Size(136, 27);
            this.textVertexC.TabIndex = 5;
            // 
            // groupTriangle
            // 
            this.groupTriangle.Controls.Add(this.textVertexB);
            this.groupTriangle.Controls.Add(this.labelVertexC);
            this.groupTriangle.Controls.Add(this.buttonCreateTriangle);
            this.groupTriangle.Controls.Add(this.textVertexC);
            this.groupTriangle.Controls.Add(this.textVertexA);
            this.groupTriangle.Controls.Add(this.labelVertexB);
            this.groupTriangle.Controls.Add(this.labelVertexA);
            this.groupTriangle.Location = new System.Drawing.Point(598, 12);
            this.groupTriangle.Name = "groupTriangle";
            this.groupTriangle.Size = new System.Drawing.Size(242, 219);
            this.groupTriangle.TabIndex = 7;
            this.groupTriangle.TabStop = false;
            this.groupTriangle.Text = "Triangle";
            // 
            // drawingCanvas
            // 
            this.drawingCanvas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.drawingCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawingCanvas.Location = new System.Drawing.Point(12, 12);
            this.drawingCanvas.Name = "drawingCanvas";
            this.drawingCanvas.Size = new System.Drawing.Size(580, 363);
            this.drawingCanvas.TabIndex = 8;
            this.drawingCanvas.TabStop = false;
            this.drawingCanvas.Click += new System.EventHandler(this.drawingCanvas_Click);
            this.drawingCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingCanvas_Paint);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // groupPointGeneration
            // 
            this.groupPointGeneration.Controls.Add(this.labelInterval);
            this.groupPointGeneration.Controls.Add(this.textInterval);
            this.groupPointGeneration.Controls.Add(this.buttonStopGen);
            this.groupPointGeneration.Controls.Add(this.buttonStartGen);
            this.groupPointGeneration.Location = new System.Drawing.Point(598, 237);
            this.groupPointGeneration.Name = "groupPointGeneration";
            this.groupPointGeneration.Size = new System.Drawing.Size(242, 138);
            this.groupPointGeneration.TabIndex = 9;
            this.groupPointGeneration.TabStop = false;
            this.groupPointGeneration.Text = "Point generation";
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Location = new System.Drawing.Point(34, 102);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(58, 20);
            this.labelInterval.TabIndex = 10;
            this.labelInterval.Text = "Interval";
            // 
            // textInterval
            // 
            this.textInterval.Location = new System.Drawing.Point(98, 99);
            this.textInterval.Name = "textInterval";
            this.textInterval.Size = new System.Drawing.Size(111, 27);
            this.textInterval.TabIndex = 9;
            // 
            // buttonStopGen
            // 
            this.buttonStopGen.Enabled = false;
            this.buttonStopGen.Location = new System.Drawing.Point(34, 64);
            this.buttonStopGen.Name = "buttonStopGen";
            this.buttonStopGen.Size = new System.Drawing.Size(175, 29);
            this.buttonStopGen.TabIndex = 8;
            this.buttonStopGen.Text = "Stop";
            this.buttonStopGen.UseVisualStyleBackColor = true;
            this.buttonStopGen.Click += new System.EventHandler(this.buttonStopGen_Click);
            // 
            // buttonStartGen
            // 
            this.buttonStartGen.Location = new System.Drawing.Point(34, 29);
            this.buttonStartGen.Name = "buttonStartGen";
            this.buttonStartGen.Size = new System.Drawing.Size(175, 29);
            this.buttonStartGen.TabIndex = 7;
            this.buttonStartGen.Text = "Start";
            this.buttonStartGen.UseVisualStyleBackColor = true;
            this.buttonStartGen.Click += new System.EventHandler(this.buttonStartGen_Click);
            // 
            // buttonGenerateTriangle
            // 
            this.buttonGenerateTriangle.Location = new System.Drawing.Point(407, 336);
            this.buttonGenerateTriangle.Name = "buttonGenerateTriangle";
            this.buttonGenerateTriangle.Size = new System.Drawing.Size(175, 29);
            this.buttonGenerateTriangle.TabIndex = 10;
            this.buttonGenerateTriangle.Text = "Generate triangle";
            this.buttonGenerateTriangle.UseVisualStyleBackColor = true;
            this.buttonGenerateTriangle.Click += new System.EventHandler(this.buttonGenerateTriangle_Click);
            // 
            // textPointSize
            // 
            this.textPointSize.Location = new System.Drawing.Point(484, 301);
            this.textPointSize.Name = "textPointSize";
            this.textPointSize.Size = new System.Drawing.Size(98, 27);
            this.textPointSize.TabIndex = 11;
            this.textPointSize.TextChanged += new System.EventHandler(this.textPointSize_TextChanged);
            // 
            // labelPointSIze
            // 
            this.labelPointSIze.AutoSize = true;
            this.labelPointSIze.BackColor = System.Drawing.Color.Transparent;
            this.labelPointSIze.Location = new System.Drawing.Point(407, 305);
            this.labelPointSIze.Name = "labelPointSIze";
            this.labelPointSIze.Size = new System.Drawing.Size(71, 20);
            this.labelPointSIze.TabIndex = 12;
            this.labelPointSIze.Text = "Point size";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(854, 387);
            this.Controls.Add(this.labelPointSIze);
            this.Controls.Add(this.textPointSize);
            this.Controls.Add(this.buttonGenerateTriangle);
            this.Controls.Add(this.groupPointGeneration);
            this.Controls.Add(this.drawingCanvas);
            this.Controls.Add(this.groupTriangle);
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.Text = "Demo";
            this.groupTriangle.ResumeLayout(false);
            this.groupTriangle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingCanvas)).EndInit();
            this.groupPointGeneration.ResumeLayout(false);
            this.groupPointGeneration.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateTriangle;
        private System.Windows.Forms.TextBox textVertexA;
        private System.Windows.Forms.Label labelVertexA;
        private System.Windows.Forms.Label labelVertexB;
        private System.Windows.Forms.TextBox textVertexB;
        private System.Windows.Forms.Label labelVertexC;
        private System.Windows.Forms.TextBox textVertexC;
        private System.Windows.Forms.GroupBox groupTriangle;
        private System.Windows.Forms.PictureBox drawingCanvas;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox groupPointGeneration;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.TextBox textInterval;
        private System.Windows.Forms.Button buttonStopGen;
        private System.Windows.Forms.Button buttonStartGen;
        private System.Windows.Forms.Button buttonGenerateTriangle;
        private System.Windows.Forms.TextBox textPointSize;
        private System.Windows.Forms.Label labelPointSIze;
    }
}

