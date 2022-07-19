namespace InferenceV
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
            this.CBOverlay = new System.Windows.Forms.CheckBox();
            this.CBEnemy = new System.Windows.Forms.CheckBox();
            this.CBHead = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CBOverlay
            // 
            this.CBOverlay.AutoSize = true;
            this.CBOverlay.Location = new System.Drawing.Point(27, 43);
            this.CBOverlay.Name = "CBOverlay";
            this.CBOverlay.Size = new System.Drawing.Size(76, 20);
            this.CBOverlay.TabIndex = 0;
            this.CBOverlay.Text = "Overlay";
            this.CBOverlay.UseVisualStyleBackColor = true;
            this.CBOverlay.CheckedChanged += new System.EventHandler(this.CBOverlay_CheckedChanged);
            // 
            // CBEnemy
            // 
            this.CBEnemy.AutoSize = true;
            this.CBEnemy.Location = new System.Drawing.Point(3, 37);
            this.CBEnemy.Name = "CBEnemy";
            this.CBEnemy.Size = new System.Drawing.Size(71, 20);
            this.CBEnemy.TabIndex = 1;
            this.CBEnemy.Text = "Enemy";
            this.CBEnemy.UseVisualStyleBackColor = true;
            // 
            // CBHead
            // 
            this.CBHead.AutoSize = true;
            this.CBHead.Location = new System.Drawing.Point(102, 37);
            this.CBHead.Name = "CBHead";
            this.CBHead.Size = new System.Drawing.Size(63, 20);
            this.CBHead.TabIndex = 2;
            this.CBHead.Text = "Head";
            this.CBHead.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CBEnemy);
            this.panel1.Controls.Add(this.CBHead);
            this.panel1.Location = new System.Drawing.Point(27, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 251);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CBOverlay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CBOverlay;
        private System.Windows.Forms.CheckBox CBEnemy;
        private System.Windows.Forms.CheckBox CBHead;
        private System.Windows.Forms.Panel panel1;
    }
}

