namespace Calculator
{
    partial class frmCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculator));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblCurrentOperation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCalculate_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 60);
            this.button2.TabIndex = 0;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnCalculate_click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(210, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 60);
            this.button3.TabIndex = 0;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnCalculate_click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(310, 83);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(66, 60);
            this.btnDivide.TabIndex = 0;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.Location = new System.Drawing.Point(410, 83);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(66, 60);
            this.btnClearEntry.TabIndex = 0;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = true;
            this.btnClearEntry.Click += new System.EventHandler(this.btnClearEntry_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(10, 159);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(66, 60);
            this.btnFour.TabIndex = 0;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnCalculate_click);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(110, 159);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(66, 60);
            this.btnFive.TabIndex = 0;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnCalculate_click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(210, 159);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(66, 60);
            this.btnSix.TabIndex = 0;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnCalculate_click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(310, 159);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(66, 60);
            this.btnMultiply.TabIndex = 0;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(410, 159);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(66, 60);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(10, 238);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(66, 60);
            this.btnOne.TabIndex = 0;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnCalculate_click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(110, 238);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(66, 60);
            this.btnTwo.TabIndex = 0;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnCalculate_click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(210, 238);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(66, 60);
            this.btnThree.TabIndex = 0;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnCalculate_click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(310, 238);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(66, 60);
            this.btnMinus.TabIndex = 0;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(10, 319);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(166, 60);
            this.btnZero.TabIndex = 0;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnCalculate_click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(210, 319);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(66, 60);
            this.button18.TabIndex = 0;
            this.button18.Text = ".";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.btnCalculate_click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(310, 319);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(66, 60);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(410, 238);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(66, 141);
            this.btnEquals.TabIndex = 0;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(13, 43);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(463, 27);
            this.txtResult.TabIndex = 1;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCurrentOperation
            // 
            this.lblCurrentOperation.AutoSize = true;
            this.lblCurrentOperation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCurrentOperation.Location = new System.Drawing.Point(13, 10);
            this.lblCurrentOperation.Name = "lblCurrentOperation";
            this.lblCurrentOperation.Size = new System.Drawing.Size(0, 20);
            this.lblCurrentOperation.TabIndex = 2;
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 390);
            this.Controls.Add(this.lblCurrentOperation);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnClearEntry);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnClearEntry;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblCurrentOperation;
    }
}

