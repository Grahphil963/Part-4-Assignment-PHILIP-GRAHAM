namespace Part_4_Assignment_PHILIP_GRAHAM
{
    partial class RandomNumbers
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.btnInt = new System.Windows.Forms.Button();
            this.btnDbl = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(2, 24);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(332, 25);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Please enter a Minimum and Maximum";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(13, 83);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(95, 25);
            this.lblMin.TabIndex = 1;
            this.lblMin.Text = "Minimum";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(13, 128);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(95, 25);
            this.lblMax.TabIndex = 2;
            this.lblMax.Text = "Maximum";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(114, 83);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(100, 20);
            this.txtMin.TabIndex = 3;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(114, 133);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(100, 20);
            this.txtMax.TabIndex = 4;
            // 
            // btnInt
            // 
            this.btnInt.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnInt.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInt.Location = new System.Drawing.Point(12, 171);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(136, 60);
            this.btnInt.TabIndex = 5;
            this.btnInt.Text = "Get Integer";
            this.btnInt.UseVisualStyleBackColor = false;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // btnDbl
            // 
            this.btnDbl.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDbl.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDbl.Location = new System.Drawing.Point(154, 171);
            this.btnDbl.Name = "btnDbl";
            this.btnDbl.Size = new System.Drawing.Size(136, 60);
            this.btnDbl.TabIndex = 6;
            this.btnDbl.Text = "Get Double";
            this.btnDbl.UseVisualStyleBackColor = false;
            this.btnDbl.Click += new System.EventHandler(this.btnDbl_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(84, 258);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 24);
            this.lblOutput.TabIndex = 7;
            // 
            // RandomNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 301);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnDbl);
            this.Controls.Add(this.btnInt);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblInstructions);
            this.Name = "RandomNumbers";
            this.Text = "Random Numbers";
            this.Load += new System.EventHandler(this.RandomNumbers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnDbl;
        private System.Windows.Forms.Label lblOutput;
    }
}

