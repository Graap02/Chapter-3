namespace EggsInteractive
{
    partial class lblResult
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
            this.btnTotal = new System.Windows.Forms.Button();
            this.eggsOne = new System.Windows.Forms.TextBox();
            this.eggsThree = new System.Windows.Forms.TextBox();
            this.eggsFour = new System.Windows.Forms.TextBox();
            this.eggsFive = new System.Windows.Forms.TextBox();
            this.eggsTwo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eggsResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(72, 266);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 46);
            this.btnTotal.TabIndex = 0;
            this.btnTotal.Text = "Click to calculate";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.button1_Click);
            // 
            // eggsOne
            // 
            this.eggsOne.Location = new System.Drawing.Point(49, 121);
            this.eggsOne.Name = "eggsOne";
            this.eggsOne.Size = new System.Drawing.Size(47, 20);
            this.eggsOne.TabIndex = 1;
            // 
            // eggsThree
            // 
            this.eggsThree.Location = new System.Drawing.Point(216, 121);
            this.eggsThree.Name = "eggsThree";
            this.eggsThree.Size = new System.Drawing.Size(42, 20);
            this.eggsThree.TabIndex = 2;
            // 
            // eggsFour
            // 
            this.eggsFour.Location = new System.Drawing.Point(48, 194);
            this.eggsFour.Name = "eggsFour";
            this.eggsFour.Size = new System.Drawing.Size(48, 20);
            this.eggsFour.TabIndex = 3;
            // 
            // eggsFive
            // 
            this.eggsFive.Location = new System.Drawing.Point(139, 194);
            this.eggsFive.Name = "eggsFive";
            this.eggsFive.Size = new System.Drawing.Size(51, 20);
            this.eggsFive.TabIndex = 4;
            // 
            // eggsTwo
            // 
            this.eggsTwo.Location = new System.Drawing.Point(139, 121);
            this.eggsTwo.Name = "eggsTwo";
            this.eggsTwo.Size = new System.Drawing.Size(51, 20);
            this.eggsTwo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter egss produced by each of 5 chickens";
            // 
            // eggsResult
            // 
            this.eggsResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.eggsResult.Location = new System.Drawing.Point(72, 355);
            this.eggsResult.Name = "eggsResult";
            this.eggsResult.Size = new System.Drawing.Size(156, 59);
            this.eggsResult.TabIndex = 7;
            // 
            // lblResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 450);
            this.Controls.Add(this.eggsResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eggsTwo);
            this.Controls.Add(this.eggsFive);
            this.Controls.Add(this.eggsFour);
            this.Controls.Add(this.eggsThree);
            this.Controls.Add(this.eggsOne);
            this.Controls.Add(this.btnTotal);
            this.Name = "lblResult";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.TextBox eggsOne;
        private System.Windows.Forms.TextBox eggsThree;
        private System.Windows.Forms.TextBox eggsFour;
        private System.Windows.Forms.TextBox eggsFive;
        private System.Windows.Forms.TextBox eggsTwo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label eggsResult;
    }
}

