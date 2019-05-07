namespace tema6
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
            this.ComputeBtn = new System.Windows.Forms.Button();
            this.PolyInput = new System.Windows.Forms.TextBox();
            this.RootsOutput = new System.Windows.Forms.RichTextBox();
            this.RootsLabel = new System.Windows.Forms.Label();
            this.IntervalLabel = new System.Windows.Forms.Label();
            this.IntervalOutput = new System.Windows.Forms.TextBox();
            this.FstDOutput = new System.Windows.Forms.TextBox();
            this.SndDOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SavingInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ComputeBtn
            // 
            this.ComputeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputeBtn.Location = new System.Drawing.Point(656, 81);
            this.ComputeBtn.Name = "ComputeBtn";
            this.ComputeBtn.Size = new System.Drawing.Size(120, 50);
            this.ComputeBtn.TabIndex = 0;
            this.ComputeBtn.Text = "Compute";
            this.ComputeBtn.UseVisualStyleBackColor = true;
            this.ComputeBtn.Click += new System.EventHandler(this.ComputeBtn_Click);
            // 
            // PolyInput
            // 
            this.PolyInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PolyInput.Location = new System.Drawing.Point(97, 36);
            this.PolyInput.Name = "PolyInput";
            this.PolyInput.Size = new System.Drawing.Size(652, 30);
            this.PolyInput.TabIndex = 1;
            // 
            // RootsOutput
            // 
            this.RootsOutput.Location = new System.Drawing.Point(97, 242);
            this.RootsOutput.Name = "RootsOutput";
            this.RootsOutput.Size = new System.Drawing.Size(349, 122);
            this.RootsOutput.TabIndex = 2;
            this.RootsOutput.Text = "";
            // 
            // RootsLabel
            // 
            this.RootsLabel.AutoSize = true;
            this.RootsLabel.Location = new System.Drawing.Point(34, 347);
            this.RootsLabel.Name = "RootsLabel";
            this.RootsLabel.Size = new System.Drawing.Size(49, 17);
            this.RootsLabel.TabIndex = 3;
            this.RootsLabel.Text = "Roots:";
            // 
            // IntervalLabel
            // 
            this.IntervalLabel.AutoSize = true;
            this.IntervalLabel.Location = new System.Drawing.Point(527, 274);
            this.IntervalLabel.Name = "IntervalLabel";
            this.IntervalLabel.Size = new System.Drawing.Size(58, 17);
            this.IntervalLabel.TabIndex = 4;
            this.IntervalLabel.Text = "Interval:";
            // 
            // IntervalOutput
            // 
            this.IntervalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntervalOutput.Location = new System.Drawing.Point(591, 264);
            this.IntervalOutput.Name = "IntervalOutput";
            this.IntervalOutput.Size = new System.Drawing.Size(185, 30);
            this.IntervalOutput.TabIndex = 5;
            // 
            // FstDOutput
            // 
            this.FstDOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FstDOutput.Location = new System.Drawing.Point(97, 103);
            this.FstDOutput.Name = "FstDOutput";
            this.FstDOutput.Size = new System.Drawing.Size(375, 30);
            this.FstDOutput.TabIndex = 6;
            // 
            // SndDOutput
            // 
            this.SndDOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SndDOutput.Location = new System.Drawing.Point(97, 169);
            this.SndDOutput.Name = "SndDOutput";
            this.SndDOutput.Size = new System.Drawing.Size(375, 30);
            this.SndDOutput.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "P(x) = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "P\'(x) = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "P\'\'(x) = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Save As: ";
            // 
            // SavingInput
            // 
            this.SavingInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavingInput.Location = new System.Drawing.Point(591, 326);
            this.SavingInput.Name = "SavingInput";
            this.SavingInput.Size = new System.Drawing.Size(185, 30);
            this.SavingInput.TabIndex = 12;
            this.SavingInput.Enter += new System.EventHandler(this.Save);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 394);
            this.Controls.Add(this.SavingInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SndDOutput);
            this.Controls.Add(this.FstDOutput);
            this.Controls.Add(this.IntervalOutput);
            this.Controls.Add(this.IntervalLabel);
            this.Controls.Add(this.RootsLabel);
            this.Controls.Add(this.RootsOutput);
            this.Controls.Add(this.PolyInput);
            this.Controls.Add(this.ComputeBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ComputeBtn;
        private System.Windows.Forms.TextBox PolyInput;
        private System.Windows.Forms.RichTextBox RootsOutput;
        private System.Windows.Forms.Label RootsLabel;
        private System.Windows.Forms.Label IntervalLabel;
        private System.Windows.Forms.TextBox IntervalOutput;
        private System.Windows.Forms.TextBox FstDOutput;
        private System.Windows.Forms.TextBox SndDOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SavingInput;
    }
}

