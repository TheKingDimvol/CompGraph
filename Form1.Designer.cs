
namespace CompGraph
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lineX0_lbl = new System.Windows.Forms.Label();
            this.clearLine = new System.Windows.Forms.Button();
            this.drawLine = new System.Windows.Forms.Button();
            this.lineY1 = new System.Windows.Forms.TextBox();
            this.lineY0 = new System.Windows.Forms.TextBox();
            this.lineX1 = new System.Windows.Forms.TextBox();
            this.lineX0 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.firstPointY = new System.Windows.Forms.TextBox();
            this.firstPointX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clearPolygon = new System.Windows.Forms.Button();
            this.drawPolygon = new System.Windows.Forms.Button();
            this.cordsY = new System.Windows.Forms.TextBox();
            this.cordsX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearCircle = new System.Windows.Forms.Button();
            this.drawCircle = new System.Windows.Forms.Button();
            this.circleRadius = new System.Windows.Forms.TextBox();
            this.circleCenterX = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.circleCenterY = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.lineX0_lbl);
            this.groupBox4.Controls.Add(this.clearLine);
            this.groupBox4.Controls.Add(this.drawLine);
            this.groupBox4.Controls.Add(this.lineY1);
            this.groupBox4.Controls.Add(this.lineY0);
            this.groupBox4.Controls.Add(this.lineX1);
            this.groupBox4.Controls.Add(this.lineX0);
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 99);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Линия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Y1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Y0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "X1";
            // 
            // lineX0_lbl
            // 
            this.lineX0_lbl.AutoSize = true;
            this.lineX0_lbl.Location = new System.Drawing.Point(5, 26);
            this.lineX0_lbl.Name = "lineX0_lbl";
            this.lineX0_lbl.Size = new System.Drawing.Size(20, 15);
            this.lineX0_lbl.TabIndex = 7;
            this.lineX0_lbl.Text = "X0";
            // 
            // clearLine
            // 
            this.clearLine.Location = new System.Drawing.Point(137, 52);
            this.clearLine.Name = "clearLine";
            this.clearLine.Size = new System.Drawing.Size(94, 26);
            this.clearLine.TabIndex = 6;
            this.clearLine.Text = "Clear";
            this.clearLine.UseVisualStyleBackColor = true;
            this.clearLine.Click += new System.EventHandler(this.clearLine_Click);
            // 
            // drawLine
            // 
            this.drawLine.Location = new System.Drawing.Point(137, 20);
            this.drawLine.Name = "drawLine";
            this.drawLine.Size = new System.Drawing.Size(94, 26);
            this.drawLine.TabIndex = 5;
            this.drawLine.Text = "Draw ";
            this.drawLine.UseVisualStyleBackColor = true;
            this.drawLine.Click += new System.EventHandler(this.drawLine_Click);
            // 
            // lineY1
            // 
            this.lineY1.Location = new System.Drawing.Point(86, 55);
            this.lineY1.Name = "lineY1";
            this.lineY1.Size = new System.Drawing.Size(31, 23);
            this.lineY1.TabIndex = 4;
            // 
            // lineY0
            // 
            this.lineY0.Location = new System.Drawing.Point(86, 22);
            this.lineY0.Name = "lineY0";
            this.lineY0.Size = new System.Drawing.Size(31, 23);
            this.lineY0.TabIndex = 3;
            // 
            // lineX1
            // 
            this.lineX1.Location = new System.Drawing.Point(27, 55);
            this.lineX1.Name = "lineX1";
            this.lineX1.Size = new System.Drawing.Size(31, 23);
            this.lineX1.TabIndex = 2;
            // 
            // lineX0
            // 
            this.lineX0.Location = new System.Drawing.Point(27, 22);
            this.lineX0.Name = "lineX0";
            this.lineX0.Size = new System.Drawing.Size(31, 23);
            this.lineX0.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.firstPointY);
            this.groupBox3.Controls.Add(this.firstPointX);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.number);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(0, 262);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 188);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Правильный Многоугольник";
            // 
            // firstPointY
            // 
            this.firstPointY.Location = new System.Drawing.Point(91, 51);
            this.firstPointY.Name = "firstPointY";
            this.firstPointY.Size = new System.Drawing.Size(40, 23);
            this.firstPointY.TabIndex = 16;
            // 
            // firstPointX
            // 
            this.firstPointX.Location = new System.Drawing.Point(27, 51);
            this.firstPointX.Name = "firstPointX";
            this.firstPointX.Size = new System.Drawing.Size(38, 23);
            this.firstPointX.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "X";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 26);
            this.button1.TabIndex = 12;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 26);
            this.button2.TabIndex = 12;
            this.button2.Text = "Draw ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(132, 93);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(36, 23);
            this.number.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Количество сторон";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Первая точка";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clearPolygon);
            this.groupBox2.Controls.Add(this.drawPolygon);
            this.groupBox2.Controls.Add(this.cordsY);
            this.groupBox2.Controls.Add(this.cordsX);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(0, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 151);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Многоугольник";
            // 
            // clearPolygon
            // 
            this.clearPolygon.Location = new System.Drawing.Point(266, 61);
            this.clearPolygon.Name = "clearPolygon";
            this.clearPolygon.Size = new System.Drawing.Size(94, 26);
            this.clearPolygon.TabIndex = 12;
            this.clearPolygon.Text = "Clear";
            this.clearPolygon.UseVisualStyleBackColor = true;
            this.clearPolygon.Click += new System.EventHandler(this.clearPolygon_Click);
            // 
            // drawPolygon
            // 
            this.drawPolygon.Location = new System.Drawing.Point(266, 18);
            this.drawPolygon.Name = "drawPolygon";
            this.drawPolygon.Size = new System.Drawing.Size(94, 26);
            this.drawPolygon.TabIndex = 12;
            this.drawPolygon.Text = "Draw ";
            this.drawPolygon.UseVisualStyleBackColor = true;
            this.drawPolygon.Click += new System.EventHandler(this.drawPolygon_Click);
            // 
            // cordsY
            // 
            this.cordsY.Location = new System.Drawing.Point(17, 112);
            this.cordsY.Name = "cordsY";
            this.cordsY.Size = new System.Drawing.Size(231, 23);
            this.cordsY.TabIndex = 3;
            // 
            // cordsX
            // 
            this.cordsX.Location = new System.Drawing.Point(17, 50);
            this.cordsX.Name = "cordsX";
            this.cordsX.Size = new System.Drawing.Size(231, 23);
            this.cordsX.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Координаты Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Координаты X (пр.: x0;x1;x2)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(401, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 244);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.circleCenterY);
            this.groupBox1.Controls.Add(this.clearCircle);
            this.groupBox1.Controls.Add(this.drawCircle);
            this.groupBox1.Controls.Add(this.circleRadius);
            this.groupBox1.Controls.Add(this.circleCenterX);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(199, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 187);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Круг";
            // 
            // clearCircle
            // 
            this.clearCircle.Location = new System.Drawing.Point(47, 154);
            this.clearCircle.Name = "clearCircle";
            this.clearCircle.Size = new System.Drawing.Size(105, 26);
            this.clearCircle.TabIndex = 14;
            this.clearCircle.Text = "Clear";
            this.clearCircle.UseVisualStyleBackColor = true;
            this.clearCircle.Click += new System.EventHandler(this.clearCircle_Click);
            // 
            // drawCircle
            // 
            this.drawCircle.Location = new System.Drawing.Point(47, 118);
            this.drawCircle.Name = "drawCircle";
            this.drawCircle.Size = new System.Drawing.Size(105, 26);
            this.drawCircle.TabIndex = 13;
            this.drawCircle.Text = "Draw ";
            this.drawCircle.UseVisualStyleBackColor = true;
            this.drawCircle.Click += new System.EventHandler(this.drawCircle_Click);
            // 
            // circleRadius
            // 
            this.circleRadius.Location = new System.Drawing.Point(57, 81);
            this.circleRadius.Name = "circleRadius";
            this.circleRadius.Size = new System.Drawing.Size(63, 23);
            this.circleRadius.TabIndex = 4;
            // 
            // circleCenterX
            // 
            this.circleCenterX.Location = new System.Drawing.Point(26, 51);
            this.circleCenterX.Name = "circleCenterX";
            this.circleCenterX.Size = new System.Drawing.Size(41, 23);
            this.circleCenterX.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Радиус";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Центр";
            // 
            // circleCenterY
            // 
            this.circleCenterY.Location = new System.Drawing.Point(93, 51);
            this.circleCenterY.Name = "circleCenterY";
            this.circleCenterY.Size = new System.Drawing.Size(41, 23);
            this.circleCenterY.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 15);
            this.label12.TabIndex = 17;
            this.label12.Text = "X";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(77, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 15);
            this.label13.TabIndex = 17;
            this.label13.Text = "Y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox lineY1;
        private System.Windows.Forms.TextBox lineY0;
        private System.Windows.Forms.TextBox lineX1;
        private System.Windows.Forms.TextBox lineX0;
        private System.Windows.Forms.Button drawLine;
        private System.Windows.Forms.Label lineX0_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearLine;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cordsY;
        private System.Windows.Forms.TextBox cordsX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clearPolygon;
        private System.Windows.Forms.Button drawPolygon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox firstPointY;
        private System.Windows.Forms.TextBox firstPointX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearCircle;
        private System.Windows.Forms.Button drawCircle;
        private System.Windows.Forms.TextBox circleRadius;
        private System.Windows.Forms.TextBox circleCenterX;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox circleCenterY;
    }
}

