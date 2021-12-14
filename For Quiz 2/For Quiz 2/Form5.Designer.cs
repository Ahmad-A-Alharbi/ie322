
namespace For_Quiz_2
{
    partial class frmcmb
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
            this.btnrandom = new System.Windows.Forms.Button();
            this.btnBack3 = new System.Windows.Forms.Button();
            this.Btngeraterandom = new System.Windows.Forms.Button();
            this.largb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnrandom
            // 
            this.btnrandom.Location = new System.Drawing.Point(234, 35);
            this.btnrandom.Name = "btnrandom";
            this.btnrandom.Size = new System.Drawing.Size(281, 76);
            this.btnrandom.TabIndex = 0;
            this.btnrandom.Text = "Genrate random number";
            this.btnrandom.UseVisualStyleBackColor = true;
            this.btnrandom.Click += new System.EventHandler(this.btnrandom_Click);
            // 
            // btnBack3
            // 
            this.btnBack3.Location = new System.Drawing.Point(622, 346);
            this.btnBack3.Name = "btnBack3";
            this.btnBack3.Size = new System.Drawing.Size(125, 42);
            this.btnBack3.TabIndex = 1;
            this.btnBack3.Text = "Back";
            this.btnBack3.UseVisualStyleBackColor = true;
            this.btnBack3.Click += new System.EventHandler(this.btnBack3_Click);
            // 
            // Btngeraterandom
            // 
            this.Btngeraterandom.Location = new System.Drawing.Point(150, 269);
            this.Btngeraterandom.Name = "Btngeraterandom";
            this.Btngeraterandom.Size = new System.Drawing.Size(148, 62);
            this.Btngeraterandom.TabIndex = 2;
            this.Btngeraterandom.Text = "Random Number";
            this.Btngeraterandom.UseVisualStyleBackColor = true;
            this.Btngeraterandom.Click += new System.EventHandler(this.Btngeraterandom_Click);
            // 
            // largb
            // 
            this.largb.AutoSize = true;
            this.largb.Location = new System.Drawing.Point(371, 143);
            this.largb.Name = "largb";
            this.largb.Size = new System.Drawing.Size(39, 17);
            this.largb.TabIndex = 3;
            this.largb.Text = "r-g-b";
            this.largb.Click += new System.EventHandler(this.largb_Click);
            // 
            // frmcmb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.largb);
            this.Controls.Add(this.Btngeraterandom);
            this.Controls.Add(this.btnBack3);
            this.Controls.Add(this.btnrandom);
            this.Name = "frmcmb";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnrandom;
        private System.Windows.Forms.Button btnBack3;
        private System.Windows.Forms.Button Btngeraterandom;
        private System.Windows.Forms.Label largb;
    }
}