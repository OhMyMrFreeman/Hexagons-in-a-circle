
namespace CirclesInCircle
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trackBarSmallDiametr = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSmallDiametr = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelDiametrRatio = new System.Windows.Forms.Label();
            this.labelCountHex = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSmallDiametr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBarSmallDiametr
            // 
            this.trackBarSmallDiametr.Location = new System.Drawing.Point(10, 27);
            this.trackBarSmallDiametr.Maximum = 800;
            this.trackBarSmallDiametr.Minimum = 1;
            this.trackBarSmallDiametr.Name = "trackBarSmallDiametr";
            this.trackBarSmallDiametr.Size = new System.Drawing.Size(104, 45);
            this.trackBarSmallDiametr.TabIndex = 2;
            this.trackBarSmallDiametr.Value = 1;
            this.trackBarSmallDiametr.Scroll += new System.EventHandler(this.trackBarSmallDiametr_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Диаметр кругов";
            // 
            // labelSmallDiametr
            // 
            this.labelSmallDiametr.AutoSize = true;
            this.labelSmallDiametr.Location = new System.Drawing.Point(10, 57);
            this.labelSmallDiametr.Name = "labelSmallDiametr";
            this.labelSmallDiametr.Size = new System.Drawing.Size(13, 15);
            this.labelSmallDiametr.TabIndex = 7;
            this.labelSmallDiametr.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(561, 441);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelDiametrRatio);
            this.splitContainer1.Panel1.Controls.Add(this.labelCountHex);
            this.splitContainer1.Panel1.Controls.Add(this.labelSmallDiametr);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.trackBarSmallDiametr);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(918, 445);
            this.splitContainer1.SplitterDistance = 349;
            this.splitContainer1.TabIndex = 8;
            // 
            // labelDiametrRatio
            // 
            this.labelDiametrRatio.AutoSize = true;
            this.labelDiametrRatio.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDiametrRatio.Location = new System.Drawing.Point(3, 212);
            this.labelDiametrRatio.Name = "labelDiametrRatio";
            this.labelDiametrRatio.Size = new System.Drawing.Size(0, 21);
            this.labelDiametrRatio.TabIndex = 9;
            // 
            // labelCountHex
            // 
            this.labelCountHex.AutoSize = true;
            this.labelCountHex.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCountHex.Location = new System.Drawing.Point(10, 97);
            this.labelCountHex.Name = "labelCountHex";
            this.labelCountHex.Size = new System.Drawing.Size(0, 26);
            this.labelCountHex.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 445);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Шестиуголики в Круге";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSmallDiametr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSmallDiametr;
        private System.Windows.Forms.TrackBar trackBarSmallDiametr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelCountHex;
        private System.Windows.Forms.Label labelDiametrRatio;
    }
}

