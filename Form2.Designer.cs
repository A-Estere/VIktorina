namespace VIktorina
{
    partial class Form2
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
            this.labpunku = new System.Windows.Forms.Label();
            this.labjautajums = new System.Windows.Forms.Label();
            this.labpierems = new System.Windows.Forms.Label();
            this.butatbilde1 = new System.Windows.Forms.Button();
            this.butatbilde2 = new System.Windows.Forms.Button();
            this.butatbilde3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labpunku
            // 
            this.labpunku.AutoSize = true;
            this.labpunku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labpunku.ForeColor = System.Drawing.Color.Maroon;
            this.labpunku.Location = new System.Drawing.Point(684, 18);
            this.labpunku.Name = "labpunku";
            this.labpunku.Size = new System.Drawing.Size(104, 29);
            this.labpunku.TabIndex = 0;
            this.labpunku.Text = "0 punkti";
            // 
            // labjautajums
            // 
            this.labjautajums.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labjautajums.ForeColor = System.Drawing.Color.Maroon;
            this.labjautajums.Location = new System.Drawing.Point(12, 95);
            this.labjautajums.Name = "labjautajums";
            this.labjautajums.Size = new System.Drawing.Size(761, 78);
            this.labjautajums.TabIndex = 1;
            this.labjautajums.Text = "Jautājums";
            // 
            // labpierems
            // 
            this.labpierems.AutoSize = true;
            this.labpierems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labpierems.Location = new System.Drawing.Point(12, 18);
            this.labpierems.Name = "labpierems";
            this.labpierems.Size = new System.Drawing.Size(253, 29);
            this.labpierems.TabIndex = 2;
            this.labpierems.Text = "1. no 10 jautājumiem";
            // 
            // butatbilde1
            // 
            this.butatbilde1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butatbilde1.Location = new System.Drawing.Point(30, 254);
            this.butatbilde1.Name = "butatbilde1";
            this.butatbilde1.Size = new System.Drawing.Size(726, 53);
            this.butatbilde1.TabIndex = 3;
            this.butatbilde1.Text = "1.atbilde";
            this.butatbilde1.UseVisualStyleBackColor = true;
            this.butatbilde1.Click += new System.EventHandler(this.butatbilde1_Click);
            // 
            // butatbilde2
            // 
            this.butatbilde2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butatbilde2.Location = new System.Drawing.Point(30, 313);
            this.butatbilde2.Name = "butatbilde2";
            this.butatbilde2.Size = new System.Drawing.Size(726, 55);
            this.butatbilde2.TabIndex = 4;
            this.butatbilde2.Text = "2.atbilde";
            this.butatbilde2.UseVisualStyleBackColor = true;
            this.butatbilde2.Click += new System.EventHandler(this.butatbilde2_Click);
            // 
            // butatbilde3
            // 
            this.butatbilde3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butatbilde3.Location = new System.Drawing.Point(30, 374);
            this.butatbilde3.Name = "butatbilde3";
            this.butatbilde3.Size = new System.Drawing.Size(726, 53);
            this.butatbilde3.TabIndex = 5;
            this.butatbilde3.Text = "3.atbilde";
            this.butatbilde3.UseVisualStyleBackColor = true;
            this.butatbilde3.Click += new System.EventHandler(this.butatbilde3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butatbilde3);
            this.Controls.Add(this.butatbilde2);
            this.Controls.Add(this.butatbilde1);
            this.Controls.Add(this.labpierems);
            this.Controls.Add(this.labjautajums);
            this.Controls.Add(this.labpunku);
            this.Name = "Form2";
            this.Text = "Viktorīna";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labpunku;
        private System.Windows.Forms.Label labjautajums;
        private System.Windows.Forms.Label labpierems;
        private System.Windows.Forms.Button butatbilde1;
        private System.Windows.Forms.Button butatbilde2;
        private System.Windows.Forms.Button butatbilde3;
    }
}