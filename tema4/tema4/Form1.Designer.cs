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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "LOAD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelM1
            // 
            this.LabelM1.AutoSize = true;
            this.LabelM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelM1.Location = new System.Drawing.Point(12, 53);
            this.LabelM1.Name = "LabelM1";
            this.LabelM1.Size = new System.Drawing.Size(57, 25);
            this.LabelM1.TabIndex = 1;
            this.LabelM1.Text = "M1 - ";
            // 
            // LabelM2
            // 
            this.LabelM2.AutoSize = true;
            this.LabelM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelM2.Location = new System.Drawing.Point(12, 82);
            this.LabelM2.Name = "LabelM2";
            this.LabelM2.Size = new System.Drawing.Size(57, 25);
            this.LabelM2.TabIndex = 2;
            this.LabelM2.Text = "M2 - ";
            // 
            // LabelM3
            // 
            this.LabelM3.AutoSize = true;
            this.LabelM3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelM3.Location = new System.Drawing.Point(12, 110);
            this.LabelM3.Name = "LabelM3";
            this.LabelM3.Size = new System.Drawing.Size(57, 25);
            this.LabelM3.TabIndex = 3;
            this.LabelM3.Text = "M3 - ";
            // 
            // LabelM4
            // 
            this.LabelM4.AutoSize = true;
            this.LabelM4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelM4.Location = new System.Drawing.Point(12, 135);
            this.LabelM4.Name = "LabelM4";
            this.LabelM4.Size = new System.Drawing.Size(57, 25);
            this.LabelM4.TabIndex = 4;
            this.LabelM4.Text = "M4 - ";
            // 
            // LabelM5
            // 
            this.LabelM5.AutoSize = true;
            this.LabelM5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelM5.Location = new System.Drawing.Point(12, 160);
            this.LabelM5.Name = "LabelM5";
            this.LabelM5.Size = new System.Drawing.Size(57, 25);
            this.LabelM5.TabIndex = 5;
            this.LabelM5.Text = "M5 - ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelM5);
            this.Controls.Add(this.LabelM4);
            this.Controls.Add(this.LabelM3);
            this.Controls.Add(this.LabelM2);
            this.Controls.Add(this.LabelM1);
            this.Controls.Add(this.button1);
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
    }
}

