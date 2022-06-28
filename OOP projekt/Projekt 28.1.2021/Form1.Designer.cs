namespace WindowsFormsApp15
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
            this.A00 = new System.Windows.Forms.Button();
            this.A10 = new System.Windows.Forms.Button();
            this.A20 = new System.Windows.Forms.Button();
            this.A21 = new System.Windows.Forms.Button();
            this.A11 = new System.Windows.Forms.Button();
            this.A01 = new System.Windows.Forms.Button();
            this.A22 = new System.Windows.Forms.Button();
            this.A12 = new System.Windows.Forms.Button();
            this.A02 = new System.Windows.Forms.Button();
            this.XWin = new System.Windows.Forms.Label();
            this.OWin = new System.Windows.Forms.Label();
            this.Draws = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NGButton = new System.Windows.Forms.Button();
            this.EButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // A00
            // 
            this.A00.Location = new System.Drawing.Point(79, 50);
            this.A00.Name = "A00";
            this.A00.Size = new System.Drawing.Size(96, 66);
            this.A00.TabIndex = 0;
            this.A00.UseVisualStyleBackColor = true;
            this.A00.Click += new System.EventHandler(this.buttonCLick);
            // 
            // A10
            // 
            this.A10.Location = new System.Drawing.Point(79, 148);
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(96, 66);
            this.A10.TabIndex = 1;
            this.A10.UseVisualStyleBackColor = true;
            this.A10.Click += new System.EventHandler(this.buttonCLick);
            // 
            // A20
            // 
            this.A20.Location = new System.Drawing.Point(79, 249);
            this.A20.Name = "A20";
            this.A20.Size = new System.Drawing.Size(96, 66);
            this.A20.TabIndex = 2;
            this.A20.UseVisualStyleBackColor = true;
            this.A20.Click += new System.EventHandler(this.buttonCLick);
            // 
            // A21
            // 
            this.A21.Location = new System.Drawing.Point(219, 249);
            this.A21.Name = "A21";
            this.A21.Size = new System.Drawing.Size(96, 66);
            this.A21.TabIndex = 5;
            this.A21.UseVisualStyleBackColor = true;
            this.A21.Click += new System.EventHandler(this.buttonCLick);
            // 
            // A11
            // 
            this.A11.Location = new System.Drawing.Point(219, 148);
            this.A11.Name = "A11";
            this.A11.Size = new System.Drawing.Size(96, 66);
            this.A11.TabIndex = 4;
            this.A11.UseVisualStyleBackColor = true;
            this.A11.Click += new System.EventHandler(this.buttonCLick);
            // 
            // A01
            // 
            this.A01.Location = new System.Drawing.Point(219, 50);
            this.A01.Name = "A01";
            this.A01.Size = new System.Drawing.Size(96, 66);
            this.A01.TabIndex = 3;
            this.A01.UseVisualStyleBackColor = true;
            this.A01.Click += new System.EventHandler(this.buttonCLick);
            // 
            // A22
            // 
            this.A22.Location = new System.Drawing.Point(358, 249);
            this.A22.Name = "A22";
            this.A22.Size = new System.Drawing.Size(96, 66);
            this.A22.TabIndex = 8;
            this.A22.UseVisualStyleBackColor = true;
            this.A22.Click += new System.EventHandler(this.buttonCLick);
            // 
            // A12
            // 
            this.A12.Location = new System.Drawing.Point(358, 148);
            this.A12.Name = "A12";
            this.A12.Size = new System.Drawing.Size(96, 66);
            this.A12.TabIndex = 7;
            this.A12.UseVisualStyleBackColor = true;
            this.A12.Click += new System.EventHandler(this.buttonCLick);
            // 
            // A02
            // 
            this.A02.Location = new System.Drawing.Point(358, 50);
            this.A02.Name = "A02";
            this.A02.Size = new System.Drawing.Size(96, 66);
            this.A02.TabIndex = 6;
            this.A02.UseVisualStyleBackColor = true;
            this.A02.Click += new System.EventHandler(this.buttonCLick);
            // 
            // XWin
            // 
            this.XWin.AutoSize = true;
            this.XWin.Location = new System.Drawing.Point(531, 98);
            this.XWin.Name = "XWin";
            this.XWin.Size = new System.Drawing.Size(72, 17);
            this.XWin.TabIndex = 12;
            this.XWin.Text = "X pobjeda";
            // 
            // OWin
            // 
            this.OWin.AutoSize = true;
            this.OWin.Location = new System.Drawing.Point(531, 173);
            this.OWin.Name = "OWin";
            this.OWin.Size = new System.Drawing.Size(74, 17);
            this.OWin.TabIndex = 13;
            this.OWin.Text = "O pobjeda";
            // 
            // Draws
            // 
            this.Draws.AutoSize = true;
            this.Draws.Location = new System.Drawing.Point(531, 274);
            this.Draws.Name = "Draws";
            this.Draws.Size = new System.Drawing.Size(79, 17);
            this.Draws.TabIndex = 14;
            this.Draws.Text = "Nerijesenih";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "Nova igra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // NGButton
            // 
            this.NGButton.Location = new System.Drawing.Point(238, 380);
            this.NGButton.Name = "NGButton";
            this.NGButton.Size = new System.Drawing.Size(105, 35);
            this.NGButton.TabIndex = 16;
            this.NGButton.Text = "Reset";
            this.NGButton.UseVisualStyleBackColor = true;
            this.NGButton.Click += new System.EventHandler(this.NGButton_Click);
            // 
            // EButton
            // 
            this.EButton.Location = new System.Drawing.Point(672, 385);
            this.EButton.Name = "EButton";
            this.EButton.Size = new System.Drawing.Size(102, 36);
            this.EButton.TabIndex = 17;
            this.EButton.Text = "Izlaz";
            this.EButton.UseVisualStyleBackColor = true;
            this.EButton.Click += new System.EventHandler(this.EButton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EButton);
            this.Controls.Add(this.NGButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Draws);
            this.Controls.Add(this.OWin);
            this.Controls.Add(this.XWin);
            this.Controls.Add(this.A22);
            this.Controls.Add(this.A12);
            this.Controls.Add(this.A02);
            this.Controls.Add(this.A21);
            this.Controls.Add(this.A11);
            this.Controls.Add(this.A01);
            this.Controls.Add(this.A20);
            this.Controls.Add(this.A10);
            this.Controls.Add(this.A00);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A00;
        private System.Windows.Forms.Button A10;
        private System.Windows.Forms.Button A20;
        private System.Windows.Forms.Button A21;
        private System.Windows.Forms.Button A11;
        private System.Windows.Forms.Button A01;
        private System.Windows.Forms.Button A22;
        private System.Windows.Forms.Button A12;
        private System.Windows.Forms.Button A02;
        private System.Windows.Forms.Label XWin;
        private System.Windows.Forms.Label OWin;
        private System.Windows.Forms.Label Draws;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button NGButton;
        private System.Windows.Forms.Button EButton;
    }
}

