namespace WFA_Dice
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
            this.lblResult = new System.Windows.Forms.Label();
            this.btnDice2 = new System.Windows.Forms.Button();
            this.btnDice1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDice2 = new System.Windows.Forms.Label();
            this.lblDice1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResult.Location = new System.Drawing.Point(196, 318);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(409, 81);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "Winning Status";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDice2
            // 
            this.btnDice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDice2.Location = new System.Drawing.Point(412, 249);
            this.btnDice2.Name = "btnDice2";
            this.btnDice2.Size = new System.Drawing.Size(193, 45);
            this.btnDice2.TabIndex = 8;
            this.btnDice2.Text = "roll the dice";
            this.btnDice2.UseVisualStyleBackColor = true;
            this.btnDice2.Click += new System.EventHandler(this.btnDice2_Click);
            // 
            // btnDice1
            // 
            this.btnDice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDice1.Location = new System.Drawing.Point(199, 249);
            this.btnDice1.Name = "btnDice1";
            this.btnDice1.Size = new System.Drawing.Size(193, 45);
            this.btnDice1.TabIndex = 9;
            this.btnDice1.Text = "roll the dice";
            this.btnDice1.UseVisualStyleBackColor = true;
            this.btnDice1.Click += new System.EventHandler(this.btnDice1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(461, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Second";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(244, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "First";
            // 
            // lblDice2
            // 
            this.lblDice2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 56F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDice2.Location = new System.Drawing.Point(412, 83);
            this.lblDice2.Name = "lblDice2";
            this.lblDice2.Size = new System.Drawing.Size(193, 163);
            this.lblDice2.TabIndex = 4;
            this.lblDice2.Text = "6";
            this.lblDice2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDice1
            // 
            this.lblDice1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 56F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDice1.Location = new System.Drawing.Point(199, 83);
            this.lblDice1.Name = "lblDice1";
            this.lblDice1.Size = new System.Drawing.Size(193, 163);
            this.lblDice1.TabIndex = 5;
            this.lblDice1.Text = "6";
            this.lblDice1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnDice2);
            this.Controls.Add(this.btnDice1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDice2);
            this.Controls.Add(this.lblDice1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnDice2;
        private System.Windows.Forms.Button btnDice1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDice2;
        private System.Windows.Forms.Label lblDice1;
    }
}

