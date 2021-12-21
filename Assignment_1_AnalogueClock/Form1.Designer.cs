namespace Assignment_1_AnalogueClock
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.btnSetHoursMinutes = new System.Windows.Forms.Button();
            this.lblHours = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCalculatedAngle = new System.Windows.Forms.TextBox();
            this.lblCalculatedAngle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(112, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(514, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(153, 345);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(114, 20);
            this.txtHours.TabIndex = 1;
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(339, 345);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(114, 20);
            this.txtMinutes.TabIndex = 2;
            // 
            // btnSetHoursMinutes
            // 
            this.btnSetHoursMinutes.Location = new System.Drawing.Point(480, 345);
            this.btnSetHoursMinutes.Name = "btnSetHoursMinutes";
            this.btnSetHoursMinutes.Size = new System.Drawing.Size(146, 23);
            this.btnSetHoursMinutes.TabIndex = 3;
            this.btnSetHoursMinutes.Text = "Calculate Angle";
            this.btnSetHoursMinutes.UseVisualStyleBackColor = true;
            this.btnSetHoursMinutes.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(109, 345);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(38, 13);
            this.lblHours.TabIndex = 4;
            this.lblHours.Text = "Hours:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Minutes:";
            // 
            // txtCalculatedAngle
            // 
            this.txtCalculatedAngle.BackColor = System.Drawing.SystemColors.Window;
            this.txtCalculatedAngle.Enabled = false;
            this.txtCalculatedAngle.Location = new System.Drawing.Point(204, 385);
            this.txtCalculatedAngle.Name = "txtCalculatedAngle";
            this.txtCalculatedAngle.Size = new System.Drawing.Size(422, 20);
            this.txtCalculatedAngle.TabIndex = 6;
            // 
            // lblCalculatedAngle
            // 
            this.lblCalculatedAngle.AutoSize = true;
            this.lblCalculatedAngle.Location = new System.Drawing.Point(111, 385);
            this.lblCalculatedAngle.Name = "lblCalculatedAngle";
            this.lblCalculatedAngle.Size = new System.Drawing.Size(87, 13);
            this.lblCalculatedAngle.TabIndex = 7;
            this.lblCalculatedAngle.Text = "Calculated Angle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCalculatedAngle);
            this.Controls.Add(this.txtCalculatedAngle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.btnSetHoursMinutes);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "AssignmentAnalogueClock";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.Button btnSetHoursMinutes;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCalculatedAngle;
        private System.Windows.Forms.Label lblCalculatedAngle;
    }
}

