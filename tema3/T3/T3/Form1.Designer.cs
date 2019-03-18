namespace T3
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.matrixSumOutput = new System.Windows.Forms.RichTextBox();
            this.originalSumResult = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vectorBOutput = new System.Windows.Forms.RichTextBox();
            this.originalBOutput = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.NLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 49);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load Matrix A+B";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 35);
            this.label1.TabIndex = 1;
            // 
            // matrixSumOutput
            // 
            this.matrixSumOutput.Location = new System.Drawing.Point(165, 49);
            this.matrixSumOutput.Margin = new System.Windows.Forms.Padding(4);
            this.matrixSumOutput.Name = "matrixSumOutput";
            this.matrixSumOutput.Size = new System.Drawing.Size(323, 367);
            this.matrixSumOutput.TabIndex = 2;
            this.matrixSumOutput.Text = "";
            // 
            // originalSumResult
            // 
            this.originalSumResult.Location = new System.Drawing.Point(506, 49);
            this.originalSumResult.Margin = new System.Windows.Forms.Padding(4);
            this.originalSumResult.Name = "originalSumResult";
            this.originalSumResult.Size = new System.Drawing.Size(323, 367);
            this.originalSumResult.TabIndex = 3;
            this.originalSumResult.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Our Result Matrix";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(500, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Expected Result Matrix";
            // 
            // vectorBOutput
            // 
            this.vectorBOutput.Location = new System.Drawing.Point(846, 49);
            this.vectorBOutput.Margin = new System.Windows.Forms.Padding(4);
            this.vectorBOutput.Name = "vectorBOutput";
            this.vectorBOutput.Size = new System.Drawing.Size(323, 367);
            this.vectorBOutput.TabIndex = 6;
            this.vectorBOutput.Text = "";
            // 
            // originalBOutput
            // 
            this.originalBOutput.Location = new System.Drawing.Point(1188, 49);
            this.originalBOutput.Margin = new System.Windows.Forms.Padding(4);
            this.originalBOutput.Name = "originalBOutput";
            this.originalBOutput.Size = new System.Drawing.Size(314, 367);
            this.originalBOutput.TabIndex = 7;
            this.originalBOutput.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(853, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Our Result b";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1194, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 36);
            this.label5.TabIndex = 9;
            this.label5.Text = "Expected Result b";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 124);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 52);
            this.button2.TabIndex = 10;
            this.button2.Text = "Load Matrix A*B";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 198);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 52);
            this.button3.TabIndex = 11;
            this.button3.Text = "Load Matrix A*x";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // NLabel
            // 
            this.NLabel.AutoSize = true;
            this.NLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NLabel.Location = new System.Drawing.Point(159, 450);
            this.NLabel.Name = "NLabel";
            this.NLabel.Size = new System.Drawing.Size(57, 36);
            this.NLabel.TabIndex = 12;
            this.NLabel.Text = "n =";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XLabel.Location = new System.Drawing.Point(515, 450);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(55, 36);
            this.XLabel.TabIndex = 13;
            this.XLabel.Text = "x =";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 273);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 52);
            this.button4.TabIndex = 14;
            this.button4.Text = "Load Matrix B*x";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 520);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.NLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.originalBOutput);
            this.Controls.Add(this.vectorBOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.originalSumResult);
            this.Controls.Add(this.matrixSumOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox matrixSumOutput;
        private System.Windows.Forms.RichTextBox originalSumResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox vectorBOutput;
        private System.Windows.Forms.RichTextBox originalBOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label NLabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Button button4;
    }
}

