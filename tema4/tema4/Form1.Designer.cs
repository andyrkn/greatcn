namespace tema4
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
            this.LabelM1 = new System.Windows.Forms.Label();
            this.LabelM2 = new System.Windows.Forms.Label();
            this.LabelM3 = new System.Windows.Forms.Label();
            this.LabelM4 = new System.Windows.Forms.Label();
            this.LabelM5 = new System.Windows.Forms.Label();
            this.omegaInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MaxIterInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SolveBtn = new System.Windows.Forms.Button();
            this.NormLabel = new System.Windows.Forms.Label();
            this.SORiterLabel = new System.Windows.Forms.Label();
            this.SorM2Output = new System.Windows.Forms.TextBox();
            this.SorM3Output = new System.Windows.Forms.TextBox();
            this.DetM5Output = new System.Windows.Forms.TextBox();
            this.SorM5Output = new System.Windows.Forms.TextBox();
            this.DetM3Output = new System.Windows.Forms.TextBox();
            this.SorM1Output = new System.Windows.Forms.TextBox();
            this.DetM2Output = new System.Windows.Forms.TextBox();
            this.DetM4Output = new System.Windows.Forms.TextBox();
            this.SorM4Output = new System.Windows.Forms.TextBox();
            this.DetM1Output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "LOAD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelM1
            // 
            this.LabelM1.AutoSize = true;
            this.LabelM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelM1.Location = new System.Drawing.Point(14, 127);
            this.LabelM1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelM1.Name = "LabelM1";
            this.LabelM1.Size = new System.Drawing.Size(70, 29);
            this.LabelM1.TabIndex = 1;
            this.LabelM1.Text = "M1 - ";
            // 
            // LabelM2
            // 
            this.LabelM2.AutoSize = true;
            this.LabelM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelM2.Location = new System.Drawing.Point(15, 181);
            this.LabelM2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelM2.Name = "LabelM2";
            this.LabelM2.Size = new System.Drawing.Size(70, 29);
            this.LabelM2.TabIndex = 2;
            this.LabelM2.Text = "M2 - ";
            // 
            // LabelM3
            // 
            this.LabelM3.AutoSize = true;
            this.LabelM3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelM3.Location = new System.Drawing.Point(15, 240);
            this.LabelM3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelM3.Name = "LabelM3";
            this.LabelM3.Size = new System.Drawing.Size(70, 29);
            this.LabelM3.TabIndex = 3;
            this.LabelM3.Text = "M3 - ";
            // 
            // LabelM4
            // 
            this.LabelM4.AutoSize = true;
            this.LabelM4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelM4.Location = new System.Drawing.Point(14, 293);
            this.LabelM4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelM4.Name = "LabelM4";
            this.LabelM4.Size = new System.Drawing.Size(70, 29);
            this.LabelM4.TabIndex = 4;
            this.LabelM4.Text = "M4 - ";
            // 
            // LabelM5
            // 
            this.LabelM5.AutoSize = true;
            this.LabelM5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelM5.Location = new System.Drawing.Point(15, 346);
            this.LabelM5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelM5.Name = "LabelM5";
            this.LabelM5.Size = new System.Drawing.Size(70, 29);
            this.LabelM5.TabIndex = 5;
            this.LabelM5.Text = "M5 - ";
            // 
            // omegaInput
            // 
            this.omegaInput.Location = new System.Drawing.Point(83, 421);
            this.omegaInput.Name = "omegaInput";
            this.omegaInput.Size = new System.Drawing.Size(140, 22);
            this.omegaInput.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "w =";
            // 
            // MaxIterInput
            // 
            this.MaxIterInput.Location = new System.Drawing.Point(83, 465);
            this.MaxIterInput.Name = "MaxIterInput";
            this.MaxIterInput.Size = new System.Drawing.Size(140, 22);
            this.MaxIterInput.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "max iter.";
            // 
            // SolveBtn
            // 
            this.SolveBtn.Location = new System.Drawing.Point(304, 426);
            this.SolveBtn.Name = "SolveBtn";
            this.SolveBtn.Size = new System.Drawing.Size(117, 43);
            this.SolveBtn.TabIndex = 10;
            this.SolveBtn.Text = "SOLVE";
            this.SolveBtn.UseVisualStyleBackColor = true;
            this.SolveBtn.Click += new System.EventHandler(this.SolveBtn_Click);
            // 
            // NormLabel
            // 
            this.NormLabel.AutoSize = true;
            this.NormLabel.Location = new System.Drawing.Point(181, 89);
            this.NormLabel.Name = "NormLabel";
            this.NormLabel.Size = new System.Drawing.Size(64, 17);
            this.NormLabel.TabIndex = 12;
            this.NormLabel.Text = "||Ax - b|| :";
            // 
            // SORiterLabel
            // 
            this.SORiterLabel.AutoSize = true;
            this.SORiterLabel.Location = new System.Drawing.Point(376, 89);
            this.SORiterLabel.Name = "SORiterLabel";
            this.SORiterLabel.Size = new System.Drawing.Size(66, 17);
            this.SORiterLabel.TabIndex = 13;
            this.SORiterLabel.Text = "SOR iter.";
            // 
            // SorM2Output
            // 
            this.SorM2Output.Location = new System.Drawing.Point(379, 187);
            this.SorM2Output.Name = "SorM2Output";
            this.SorM2Output.Size = new System.Drawing.Size(189, 22);
            this.SorM2Output.TabIndex = 23;
            // 
            // SorM3Output
            // 
            this.SorM3Output.Location = new System.Drawing.Point(379, 247);
            this.SorM3Output.Name = "SorM3Output";
            this.SorM3Output.Size = new System.Drawing.Size(189, 22);
            this.SorM3Output.TabIndex = 22;
            // 
            // DetM5Output
            // 
            this.DetM5Output.Location = new System.Drawing.Point(179, 353);
            this.DetM5Output.Name = "DetM5Output";
            this.DetM5Output.Size = new System.Drawing.Size(189, 22);
            this.DetM5Output.TabIndex = 21;
            // 
            // SorM5Output
            // 
            this.SorM5Output.Location = new System.Drawing.Point(379, 353);
            this.SorM5Output.Name = "SorM5Output";
            this.SorM5Output.Size = new System.Drawing.Size(189, 22);
            this.SorM5Output.TabIndex = 20;
            // 
            // DetM3Output
            // 
            this.DetM3Output.Location = new System.Drawing.Point(179, 246);
            this.DetM3Output.Name = "DetM3Output";
            this.DetM3Output.Size = new System.Drawing.Size(189, 22);
            this.DetM3Output.TabIndex = 19;
            // 
            // SorM1Output
            // 
            this.SorM1Output.Location = new System.Drawing.Point(379, 133);
            this.SorM1Output.Name = "SorM1Output";
            this.SorM1Output.Size = new System.Drawing.Size(189, 22);
            this.SorM1Output.TabIndex = 28;
            // 
            // DetM2Output
            // 
            this.DetM2Output.Location = new System.Drawing.Point(179, 188);
            this.DetM2Output.Name = "DetM2Output";
            this.DetM2Output.Size = new System.Drawing.Size(189, 22);
            this.DetM2Output.TabIndex = 27;
            // 
            // DetM4Output
            // 
            this.DetM4Output.Location = new System.Drawing.Point(179, 301);
            this.DetM4Output.Name = "DetM4Output";
            this.DetM4Output.Size = new System.Drawing.Size(189, 22);
            this.DetM4Output.TabIndex = 26;
            // 
            // SorM4Output
            // 
            this.SorM4Output.Location = new System.Drawing.Point(379, 301);
            this.SorM4Output.Name = "SorM4Output";
            this.SorM4Output.Size = new System.Drawing.Size(189, 22);
            this.SorM4Output.TabIndex = 25;
            // 
            // DetM1Output
            // 
            this.DetM1Output.Location = new System.Drawing.Point(179, 134);
            this.DetM1Output.Name = "DetM1Output";
            this.DetM1Output.Size = new System.Drawing.Size(189, 22);
            this.DetM1Output.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 567);
            this.Controls.Add(this.SorM1Output);
            this.Controls.Add(this.DetM2Output);
            this.Controls.Add(this.DetM4Output);
            this.Controls.Add(this.SorM4Output);
            this.Controls.Add(this.DetM1Output);
            this.Controls.Add(this.SorM2Output);
            this.Controls.Add(this.SorM3Output);
            this.Controls.Add(this.DetM5Output);
            this.Controls.Add(this.SorM5Output);
            this.Controls.Add(this.DetM3Output);
            this.Controls.Add(this.SORiterLabel);
            this.Controls.Add(this.NormLabel);
            this.Controls.Add(this.SolveBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaxIterInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.omegaInput);
            this.Controls.Add(this.LabelM5);
            this.Controls.Add(this.LabelM4);
            this.Controls.Add(this.LabelM3);
            this.Controls.Add(this.LabelM2);
            this.Controls.Add(this.LabelM1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LabelM1;
        private System.Windows.Forms.Label LabelM2;
        private System.Windows.Forms.Label LabelM3;
        private System.Windows.Forms.Label LabelM4;
        private System.Windows.Forms.Label LabelM5;
        private System.Windows.Forms.TextBox omegaInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MaxIterInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SolveBtn;
        private System.Windows.Forms.Label NormLabel;
        private System.Windows.Forms.Label SORiterLabel;
        private System.Windows.Forms.TextBox SorM2Output;
        private System.Windows.Forms.TextBox SorM3Output;
        private System.Windows.Forms.TextBox DetM5Output;
        private System.Windows.Forms.TextBox SorM5Output;
        private System.Windows.Forms.TextBox DetM3Output;
        private System.Windows.Forms.TextBox SorM1Output;
        private System.Windows.Forms.TextBox DetM2Output;
        private System.Windows.Forms.TextBox DetM4Output;
        private System.Windows.Forms.TextBox SorM4Output;
        private System.Windows.Forms.TextBox DetM1Output;
    }
}

