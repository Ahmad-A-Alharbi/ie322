
namespace For_Quiz_2
{
    partial class Frmrandomcombo
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
            this.cmbrandom = new System.Windows.Forms.ComboBox();
            this.btngenratecmb = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbrandom
            // 
            this.cmbrandom.FormattingEnabled = true;
            this.cmbrandom.Location = new System.Drawing.Point(29, 27);
            this.cmbrandom.Name = "cmbrandom";
            this.cmbrandom.Size = new System.Drawing.Size(119, 24);
            this.cmbrandom.TabIndex = 0;
            this.cmbrandom.SelectedIndexChanged += new System.EventHandler(this.cmbrandom_SelectedIndexChanged);
            // 
            // btngenratecmb
            // 
            this.btngenratecmb.Location = new System.Drawing.Point(203, 27);
            this.btngenratecmb.Name = "btngenratecmb";
            this.btngenratecmb.Size = new System.Drawing.Size(145, 32);
            this.btngenratecmb.TabIndex = 1;
            this.btngenratecmb.Text = "Genrate";
            this.btngenratecmb.UseVisualStyleBackColor = true;
            this.btngenratecmb.Click += new System.EventHandler(this.btngenratecmb_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Rest";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(218, 88);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(119, 21);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Less than 500";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(218, 128);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(138, 21);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Greater than 500";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btngenratecmb);
            this.groupBox1.Controls.Add(this.cmbrandom);
            this.groupBox1.Location = new System.Drawing.Point(111, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 242);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Frmrandomcombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frmrandomcombo";
            this.Text = "frmrandomCombo";
            this.Load += new System.EventHandler(this.Frmrandomcombo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbrandom;
        private System.Windows.Forms.Button btngenratecmb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}