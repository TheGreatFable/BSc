namespace CSharpPre
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
            this.Reset = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtGcdR = new System.Windows.Forms.TextBox();
            this.txtGcd2 = new System.Windows.Forms.TextBox();
            this.txtGcd1 = new System.Windows.Forms.TextBox();
            this.cmdgcd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(372, 267);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(108, 46);
            this.Reset.TabIndex = 36;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(45, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(189, 29);
            this.Label1.TabIndex = 31;
            this.Label1.Text = "Input 2 Numbers";
            // 
            // txtGcdR
            // 
            this.txtGcdR.Enabled = false;
            this.txtGcdR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGcdR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtGcdR.Location = new System.Drawing.Point(154, 206);
            this.txtGcdR.Name = "txtGcdR";
            this.txtGcdR.Size = new System.Drawing.Size(202, 39);
            this.txtGcdR.TabIndex = 28;
            // 
            // txtGcd2
            // 
            this.txtGcd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGcd2.Location = new System.Drawing.Point(154, 93);
            this.txtGcd2.Name = "txtGcd2";
            this.txtGcd2.Size = new System.Drawing.Size(202, 39);
            this.txtGcd2.TabIndex = 25;
            // 
            // txtGcd1
            // 
            this.txtGcd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGcd1.Location = new System.Drawing.Point(154, 48);
            this.txtGcd1.Name = "txtGcd1";
            this.txtGcd1.Size = new System.Drawing.Size(202, 39);
            this.txtGcd1.TabIndex = 24;
            // 
            // cmdgcd
            // 
            this.cmdgcd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdgcd.Location = new System.Drawing.Point(154, 153);
            this.cmdgcd.Name = "cmdgcd";
            this.cmdgcd.Size = new System.Drawing.Size(202, 47);
            this.cmdgcd.TabIndex = 22;
            this.cmdgcd.Text = "GCD";
            this.cmdgcd.UseVisualStyleBackColor = true;
            this.cmdgcd.Click += new System.EventHandler(this.cmdgcd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 342);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtGcdR);
            this.Controls.Add(this.txtGcd2);
            this.Controls.Add(this.txtGcd1);
            this.Controls.Add(this.cmdgcd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Reset;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtGcdR;
        internal System.Windows.Forms.TextBox txtGcd2;
        internal System.Windows.Forms.TextBox txtGcd1;
        internal System.Windows.Forms.Button cmdgcd;
    }
}

