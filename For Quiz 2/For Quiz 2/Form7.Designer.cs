
namespace For_Quiz_2
{
    partial class Frmarray
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
            this.btnArray = new System.Windows.Forms.Button();
            this.btnarray2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArray
            // 
            this.btnArray.Location = new System.Drawing.Point(401, 108);
            this.btnArray.Name = "btnArray";
            this.btnArray.Size = new System.Drawing.Size(179, 51);
            this.btnArray.TabIndex = 0;
            this.btnArray.Text = "Array";
            this.btnArray.UseVisualStyleBackColor = true;
            this.btnArray.Click += new System.EventHandler(this.btnArray_Click);
            // 
            // btnarray2
            // 
            this.btnarray2.Location = new System.Drawing.Point(397, 203);
            this.btnarray2.Name = "btnarray2";
            this.btnarray2.Size = new System.Drawing.Size(182, 68);
            this.btnarray2.TabIndex = 1;
            this.btnarray2.Text = "Array 2";
            this.btnarray2.UseVisualStyleBackColor = true;
            this.btnarray2.Click += new System.EventHandler(this.btnarray2_Click);
            // 
            // Frmarray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnarray2);
            this.Controls.Add(this.btnArray);
            this.Name = "Frmarray";
            this.Text = "Array";
            this.Load += new System.EventHandler(this.Frmarray_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArray;
        private System.Windows.Forms.Button btnarray2;
    }
}