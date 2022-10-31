namespace Activity01
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
            this.btnSum = new System.Windows.Forms.Button();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblResultText = new System.Windows.Forms.Label();
            this.txtFirstNumber = new System.Windows.Forms.TextBox();
            this.txtSecondNumber = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblAreaText = new System.Windows.Forms.Label();
            this.lblPerimeterText = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSum
            // 
            this.btnSum.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSum.Location = new System.Drawing.Point(236, 245);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(148, 63);
            this.btnSum.TabIndex = 0;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = false;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(221, 95);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(107, 20);
            this.lblFirst.TabIndex = 1;
            this.lblFirst.Text = "First Number";
            this.lblFirst.Click += new System.EventHandler(this.lblFirst_Click);
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Location = new System.Drawing.Point(199, 175);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(129, 20);
            this.lblSecond.TabIndex = 1;
            this.lblSecond.Text = "Second Number";
            this.lblSecond.Click += new System.EventHandler(this.lblSecond_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(275, 367);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(62, 20);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Result:";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // lblResultText
            // 
            this.lblResultText.AutoSize = true;
            this.lblResultText.Location = new System.Drawing.Point(384, 367);
            this.lblResultText.Name = "lblResultText";
            this.lblResultText.Size = new System.Drawing.Size(0, 20);
            this.lblResultText.TabIndex = 1;
            this.lblResultText.Click += new System.EventHandler(this.lblResultText_Click);
            // 
            // txtFirstNumber
            // 
            this.txtFirstNumber.Location = new System.Drawing.Point(377, 92);
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size = new System.Drawing.Size(212, 27);
            this.txtFirstNumber.TabIndex = 2;
            this.txtFirstNumber.TextChanged += new System.EventHandler(this.txtFirstNumber_TextChanged);
            // 
            // txtSecondNumber
            // 
            this.txtSecondNumber.Location = new System.Drawing.Point(377, 168);
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.Size = new System.Drawing.Size(212, 27);
            this.txtSecondNumber.TabIndex = 2;
            this.txtSecondNumber.TextChanged += new System.EventHandler(this.txtSecondNumber_TextChanged);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(711, 95);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(52, 20);
            this.lblWidth.TabIndex = 3;
            this.lblWidth.Text = "Width";
            this.lblWidth.Click += new System.EventHandler(this.lblWidth_Click);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(711, 157);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(60, 20);
            this.lblLength.TabIndex = 3;
            this.lblLength.Text = "Length";
            this.lblLength.Click += new System.EventHandler(this.lblLength_Click);
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(984, 99);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(87, 20);
            this.lblPerimeter.TabIndex = 3;
            this.lblPerimeter.Text = "Perimeter:";
            this.lblPerimeter.Click += new System.EventHandler(this.lblPerimeter_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(984, 157);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(49, 20);
            this.lblArea.TabIndex = 3;
            this.lblArea.Text = "Area:";
            this.lblArea.Click += new System.EventHandler(this.lblArea_Click);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(785, 88);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(171, 27);
            this.txtWidth.TabIndex = 4;
            this.txtWidth.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(785, 150);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(171, 27);
            this.txtLength.TabIndex = 4;
            this.txtLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            // 
            // lblAreaText
            // 
            this.lblAreaText.AutoSize = true;
            this.lblAreaText.Location = new System.Drawing.Point(1071, 157);
            this.lblAreaText.Name = "lblAreaText";
            this.lblAreaText.Size = new System.Drawing.Size(0, 20);
            this.lblAreaText.TabIndex = 3;
            this.lblAreaText.Click += new System.EventHandler(this.lblAreaText_Click);
            // 
            // lblPerimeterText
            // 
            this.lblPerimeterText.AutoSize = true;
            this.lblPerimeterText.Location = new System.Drawing.Point(1071, 99);
            this.lblPerimeterText.Name = "lblPerimeterText";
            this.lblPerimeterText.Size = new System.Drawing.Size(0, 20);
            this.lblPerimeterText.TabIndex = 3;
            this.lblPerimeterText.Click += new System.EventHandler(this.lblPerimeterText_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Aquamarine;
            this.btnCalculate.Location = new System.Drawing.Point(715, 245);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(140, 52);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1391, 583);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.lblPerimeterText);
            this.Controls.Add(this.lblAreaText);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.txtSecondNumber);
            this.Controls.Add(this.txtFirstNumber);
            this.Controls.Add(this.lblResultText);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.btnSum);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblResultText;
        private System.Windows.Forms.TextBox txtFirstNumber;
        private System.Windows.Forms.TextBox txtSecondNumber;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblAreaText;
        private System.Windows.Forms.Label lblPerimeterText;
        private System.Windows.Forms.Button btnCalculate;
    }
}
