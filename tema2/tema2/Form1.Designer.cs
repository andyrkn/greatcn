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
            ((System.ComponentModel.ISupportInitialize)(this.nInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eInput)).BeginInit();
            this.SuspendLayout();
            // 
            // nInput
            // 
            this.nInput.Location = new System.Drawing.Point(253, 27);
            this.nInput.Name = "nInput";
            this.nInput.Size = new System.Drawing.Size(75, 20);
            this.nInput.TabIndex = 1;
            // 
            // eInput
            // 
            this.eInput.Location = new System.Drawing.Point(334, 27);
            this.eInput.Name = "eInput";
            this.eInput.Size = new System.Drawing.Size(63, 20);
            this.eInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "e";
            // 
            // matrixCreate
            // 
            this.matrixCreate.Location = new System.Drawing.Point(415, 24);
            this.matrixCreate.Name = "matrixCreate";
            this.matrixCreate.Size = new System.Drawing.Size(75, 23);
            this.matrixCreate.TabIndex = 5;
            this.matrixCreate.Text = "Create";
            this.matrixCreate.UseVisualStyleBackColor = true;
            this.matrixCreate.Click += new System.EventHandler(this.matrixCreate_Click);
            // 
            // matrixEntry
            // 
            this.matrixEntry.Location = new System.Drawing.Point(10, 53);
            this.matrixEntry.Name = "matrixEntry";
            this.matrixEntry.Size = new System.Drawing.Size(237, 180);
            this.matrixEntry.TabIndex = 6;
            this.matrixEntry.Text = "";
            // 
            // UMatrixText
            // 
            this.UMatrixText.Location = new System.Drawing.Point(496, 53);
            this.UMatrixText.Name = "UMatrixText";
            this.UMatrixText.Size = new System.Drawing.Size(237, 180);
            this.UMatrixText.TabIndex = 7;
            this.UMatrixText.Text = "";
            // 
            // LMatrixText
            // 
            this.LMatrixText.Location = new System.Drawing.Point(253, 53);
            this.LMatrixText.Name = "LMatrixText";
            this.LMatrixText.Size = new System.Drawing.Size(237, 180);
            this.LMatrixText.TabIndex = 8;
            this.LMatrixText.Text = "";
            // 
            // DeterminantResultLabel
            // 
            this.DeterminantResultLabel.AutoSize = true;
            this.DeterminantResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeterminantResultLabel.Location = new System.Drawing.Point(28, 11);
            this.DeterminantResultLabel.Name = "DeterminantResultLabel";
            this.DeterminantResultLabel.Size = new System.Drawing.Size(55, 31);
            this.DeterminantResultLabel.TabIndex = 9;
            this.DeterminantResultLabel.Text = "Δ =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "X =";
            // 
            // XVectorResult
            // 
            this.XVectorResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XVectorResult.Location = new System.Drawing.Point(83, 276);
            this.XVectorResult.Name = "XVectorResult";
            this.XVectorResult.Size = new System.Drawing.Size(559, 66);
            this.XVectorResult.TabIndex = 11;
            this.XVectorResult.Text = "";
            // 
            // BVectorInput
            // 
            this.BVectorInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVectorInput.Location = new System.Drawing.Point(83, 239);
            this.BVectorInput.Name = "BVectorInput";
            this.BVectorInput.Size = new System.Drawing.Size(559, 31);
            this.BVectorInput.TabIndex = 13;
            this.BVectorInput.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "B =";
            // 
            // ComputeAxB
            // 
            this.ComputeAxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputeAxB.Location = new System.Drawing.Point(648, 256);
            this.ComputeAxB.Name = "ComputeAxB";
            this.ComputeAxB.Size = new System.Drawing.Size(75, 68);
            this.ComputeAxB.TabIndex = 14;
            this.ComputeAxB.Text = "Compute\r\nAx = b\r\n";
            this.ComputeAxB.UseVisualStyleBackColor = true;
            this.ComputeAxB.Click += new System.EventHandler(this.ComputeAxB_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 31);
            this.label5.TabIndex = 15;
            this.label5.Text = "EC Norm =";
            // 
            // ECNormOutput
            // 
            this.ECNormOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ECNormOutput.Location = new System.Drawing.Point(158, 393);
            this.ECNormOutput.Name = "ECNormOutput";
            this.ECNormOutput.Size = new System.Drawing.Size(484, 31);
            this.ECNormOutput.TabIndex = 16;
            this.ECNormOutput.Text = "";
            // 
            // ComputeECNorm
            // 
            this.ComputeECNorm.Location = new System.Drawing.Point(648, 393);
            this.ComputeECNorm.Name = "ComputeECNorm";
            this.ComputeECNorm.Size = new System.Drawing.Size(75, 31);
            this.ComputeECNorm.TabIndex = 17;
            this.ComputeECNorm.Text = "Create";
            this.ComputeECNorm.UseVisualStyleBackColor = true;
            this.ComputeECNorm.Click += new System.EventHandler(this.ComputeECNorm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 502);
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
    }
}

