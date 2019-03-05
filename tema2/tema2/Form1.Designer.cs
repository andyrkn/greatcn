namespace tema2
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
            this.nInput = new System.Windows.Forms.NumericUpDown();
            this.eInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.matrixCreate = new System.Windows.Forms.Button();
            this.matrixEntry = new System.Windows.Forms.RichTextBox();
            this.UMatrixText = new System.Windows.Forms.RichTextBox();
            this.LMatrixText = new System.Windows.Forms.RichTextBox();
            this.DeterminantResultLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.XVectorResult = new System.Windows.Forms.RichTextBox();
            this.BVectorInput = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComputeAxB = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ECNormOutput = new System.Windows.Forms.RichTextBox();
            this.ComputeECNorm = new System.Windows.Forms.Button();
            this.errorXlabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MatrixInversedOutput = new System.Windows.Forms.RichTextBox();
            this.ErrorXOutput = new System.Windows.Forms.RichTextBox();
            this.Norm2Output = new System.Windows.Forms.RichTextBox();
            this.LibXLabel = new System.Windows.Forms.Label();
            this.libXOutput = new System.Windows.Forms.RichTextBox();
            this.ComputeLibraryErrorsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eInput)).BeginInit();
            this.SuspendLayout();
            // 
            // nInput
            // 
            this.nInput.Location = new System.Drawing.Point(337, 33);
            this.nInput.Margin = new System.Windows.Forms.Padding(4);
            this.nInput.Name = "nInput";
            this.nInput.Size = new System.Drawing.Size(100, 22);
            this.nInput.TabIndex = 1;
            // 
            // eInput
            // 
            this.eInput.Location = new System.Drawing.Point(445, 33);
            this.eInput.Margin = new System.Windows.Forms.Padding(4);
            this.eInput.Name = "eInput";
            this.eInput.Size = new System.Drawing.Size(84, 22);
            this.eInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "e";
            // 
            // matrixCreate
            // 
            this.matrixCreate.Location = new System.Drawing.Point(553, 30);
            this.matrixCreate.Margin = new System.Windows.Forms.Padding(4);
            this.matrixCreate.Name = "matrixCreate";
            this.matrixCreate.Size = new System.Drawing.Size(100, 28);
            this.matrixCreate.TabIndex = 5;
            this.matrixCreate.Text = "Create";
            this.matrixCreate.UseVisualStyleBackColor = true;
            this.matrixCreate.Click += new System.EventHandler(this.matrixCreate_Click);
            // 
            // matrixEntry
            // 
            this.matrixEntry.Location = new System.Drawing.Point(13, 65);
            this.matrixEntry.Margin = new System.Windows.Forms.Padding(4);
            this.matrixEntry.Name = "matrixEntry";
            this.matrixEntry.Size = new System.Drawing.Size(315, 221);
            this.matrixEntry.TabIndex = 6;
            this.matrixEntry.Text = "";
            // 
            // UMatrixText
            // 
            this.UMatrixText.Location = new System.Drawing.Point(661, 65);
            this.UMatrixText.Margin = new System.Windows.Forms.Padding(4);
            this.UMatrixText.Name = "UMatrixText";
            this.UMatrixText.Size = new System.Drawing.Size(315, 221);
            this.UMatrixText.TabIndex = 7;
            this.UMatrixText.Text = "";
            // 
            // LMatrixText
            // 
            this.LMatrixText.Location = new System.Drawing.Point(337, 65);
            this.LMatrixText.Margin = new System.Windows.Forms.Padding(4);
            this.LMatrixText.Name = "LMatrixText";
            this.LMatrixText.Size = new System.Drawing.Size(315, 221);
            this.LMatrixText.TabIndex = 8;
            this.LMatrixText.Text = "";
            // 
            // DeterminantResultLabel
            // 
            this.DeterminantResultLabel.AutoSize = true;
            this.DeterminantResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeterminantResultLabel.Location = new System.Drawing.Point(37, 14);
            this.DeterminantResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeterminantResultLabel.Name = "DeterminantResultLabel";
            this.DeterminantResultLabel.Size = new System.Drawing.Size(69, 39);
            this.DeterminantResultLabel.TabIndex = 9;
            this.DeterminantResultLabel.Text = "Δ =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 361);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 39);
            this.label3.TabIndex = 10;
            this.label3.Text = "X =";
            // 
            // XVectorResult
            // 
            this.XVectorResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XVectorResult.Location = new System.Drawing.Point(111, 340);
            this.XVectorResult.Margin = new System.Windows.Forms.Padding(4);
            this.XVectorResult.Name = "XVectorResult";
            this.XVectorResult.Size = new System.Drawing.Size(744, 80);
            this.XVectorResult.TabIndex = 11;
            this.XVectorResult.Text = "";
            // 
            // BVectorInput
            // 
            this.BVectorInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVectorInput.Location = new System.Drawing.Point(111, 294);
            this.BVectorInput.Margin = new System.Windows.Forms.Padding(4);
            this.BVectorInput.Name = "BVectorInput";
            this.BVectorInput.Size = new System.Drawing.Size(744, 37);
            this.BVectorInput.TabIndex = 13;
            this.BVectorInput.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 294);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 39);
            this.label4.TabIndex = 12;
            this.label4.Text = "B =";
            // 
            // ComputeAxB
            // 
            this.ComputeAxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputeAxB.Location = new System.Drawing.Point(864, 315);
            this.ComputeAxB.Margin = new System.Windows.Forms.Padding(4);
            this.ComputeAxB.Name = "ComputeAxB";
            this.ComputeAxB.Size = new System.Drawing.Size(100, 84);
            this.ComputeAxB.TabIndex = 14;
            this.ComputeAxB.Text = "Compute\r\nAx = b\r\n";
            this.ComputeAxB.UseVisualStyleBackColor = true;
            this.ComputeAxB.Click += new System.EventHandler(this.ComputeAxB_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 452);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 39);
            this.label5.TabIndex = 15;
            this.label5.Text = "EC Norm =";
            // 
            // ECNormOutput
            // 
            this.ECNormOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ECNormOutput.Location = new System.Drawing.Point(200, 454);
            this.ECNormOutput.Margin = new System.Windows.Forms.Padding(4);
            this.ECNormOutput.Name = "ECNormOutput";
            this.ECNormOutput.Size = new System.Drawing.Size(644, 37);
            this.ECNormOutput.TabIndex = 16;
            this.ECNormOutput.Text = "";
            // 
            // ComputeECNorm
            // 
            this.ComputeECNorm.Location = new System.Drawing.Point(864, 454);
            this.ComputeECNorm.Margin = new System.Windows.Forms.Padding(4);
            this.ComputeECNorm.Name = "ComputeECNorm";
            this.ComputeECNorm.Size = new System.Drawing.Size(100, 38);
            this.ComputeECNorm.TabIndex = 17;
            this.ComputeECNorm.Text = "Compute";
            this.ComputeECNorm.UseVisualStyleBackColor = true;
            this.ComputeECNorm.Click += new System.EventHandler(this.ComputeECNorm_Click);
            // 
            // errorXlabel
            // 
            this.errorXlabel.AutoSize = true;
            this.errorXlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorXlabel.Location = new System.Drawing.Point(989, 297);
            this.errorXlabel.Name = "errorXlabel";
            this.errorXlabel.Size = new System.Drawing.Size(111, 36);
            this.errorXlabel.TabIndex = 18;
            this.errorXlabel.Text = "Error X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(989, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 36);
            this.label7.TabIndex = 19;
            this.label7.Text = "Norm#2";
            // 
            // MatrixInversedOutput
            // 
            this.MatrixInversedOutput.Location = new System.Drawing.Point(984, 65);
            this.MatrixInversedOutput.Margin = new System.Windows.Forms.Padding(4);
            this.MatrixInversedOutput.Name = "MatrixInversedOutput";
            this.MatrixInversedOutput.Size = new System.Drawing.Size(315, 221);
            this.MatrixInversedOutput.TabIndex = 20;
            this.MatrixInversedOutput.Text = "";
            // 
            // ErrorXOutput
            // 
            this.ErrorXOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorXOutput.Location = new System.Drawing.Point(984, 333);
            this.ErrorXOutput.Margin = new System.Windows.Forms.Padding(4);
            this.ErrorXOutput.Name = "ErrorXOutput";
            this.ErrorXOutput.Size = new System.Drawing.Size(293, 80);
            this.ErrorXOutput.TabIndex = 21;
            this.ErrorXOutput.Text = "";
            // 
            // Norm2Output
            // 
            this.Norm2Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Norm2Output.Location = new System.Drawing.Point(984, 470);
            this.Norm2Output.Margin = new System.Windows.Forms.Padding(4);
            this.Norm2Output.Name = "Norm2Output";
            this.Norm2Output.Size = new System.Drawing.Size(293, 80);
            this.Norm2Output.TabIndex = 22;
            this.Norm2Output.Text = "";
            // 
            // LibXLabel
            // 
            this.LibXLabel.AutoSize = true;
            this.LibXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibXLabel.Location = new System.Drawing.Point(21, 531);
            this.LibXLabel.Name = "LibXLabel";
            this.LibXLabel.Size = new System.Drawing.Size(118, 36);
            this.LibXLabel.TabIndex = 23;
            this.LibXLabel.Text = "Lib X = ";
            // 
            // libXOutput
            // 
            this.libXOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libXOutput.Location = new System.Drawing.Point(146, 530);
            this.libXOutput.Margin = new System.Windows.Forms.Padding(4);
            this.libXOutput.Name = "libXOutput";
            this.libXOutput.Size = new System.Drawing.Size(644, 37);
            this.libXOutput.TabIndex = 24;
            this.libXOutput.Text = "";
            // 
            // ComputeLibraryErrorsButton
            // 
            this.ComputeLibraryErrorsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputeLibraryErrorsButton.Location = new System.Drawing.Point(821, 512);
            this.ComputeLibraryErrorsButton.Margin = new System.Windows.Forms.Padding(4);
            this.ComputeLibraryErrorsButton.Name = "ComputeLibraryErrorsButton";
            this.ComputeLibraryErrorsButton.Size = new System.Drawing.Size(100, 84);
            this.ComputeLibraryErrorsButton.TabIndex = 25;
            this.ComputeLibraryErrorsButton.Text = "Compute\r\n Errors";
            this.ComputeLibraryErrorsButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 691);
            this.Controls.Add(this.ComputeLibraryErrorsButton);
            this.Controls.Add(this.libXOutput);
            this.Controls.Add(this.LibXLabel);
            this.Controls.Add(this.Norm2Output);
            this.Controls.Add(this.ErrorXOutput);
            this.Controls.Add(this.MatrixInversedOutput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.errorXlabel);
            this.Controls.Add(this.ComputeECNorm);
            this.Controls.Add(this.ECNormOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComputeAxB);
            this.Controls.Add(this.BVectorInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.XVectorResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeterminantResultLabel);
            this.Controls.Add(this.LMatrixText);
            this.Controls.Add(this.UMatrixText);
            this.Controls.Add(this.matrixEntry);
            this.Controls.Add(this.matrixCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eInput);
            this.Controls.Add(this.nInput);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nInput;
        private System.Windows.Forms.NumericUpDown eInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button matrixCreate;
        private System.Windows.Forms.RichTextBox matrixEntry;
        private System.Windows.Forms.RichTextBox UMatrixText;
        private System.Windows.Forms.RichTextBox LMatrixText;
        private System.Windows.Forms.Label DeterminantResultLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox XVectorResult;
        private System.Windows.Forms.RichTextBox BVectorInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ComputeAxB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox ECNormOutput;
        private System.Windows.Forms.Button ComputeECNorm;
        private System.Windows.Forms.Label errorXlabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox MatrixInversedOutput;
        private System.Windows.Forms.RichTextBox ErrorXOutput;
        private System.Windows.Forms.RichTextBox Norm2Output;
        private System.Windows.Forms.Label LibXLabel;
        private System.Windows.Forms.RichTextBox libXOutput;
        private System.Windows.Forms.Button ComputeLibraryErrorsButton;
    }
}

