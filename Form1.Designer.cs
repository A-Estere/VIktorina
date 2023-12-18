namespace VIktorina
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
            this.butsakt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butsakt
            // 
            this.butsakt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butsakt.ForeColor = System.Drawing.Color.Maroon;
            this.butsakt.Location = new System.Drawing.Point(496, 416);
            this.butsakt.Name = "butsakt";
            this.butsakt.Size = new System.Drawing.Size(117, 46);
            this.butsakt.TabIndex = 0;
            this.butsakt.Text = "Sākt";
            this.butsakt.UseVisualStyleBackColor = true;
            this.butsakt.Click += new System.EventHandler(this.butsakt_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(289, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ko Tu zini par Latviju?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VIktorina.Properties.Resources.Latvija;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1131, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butsakt);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Viktorīna";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butsakt;
        private System.Windows.Forms.Label label1;
    }
}

