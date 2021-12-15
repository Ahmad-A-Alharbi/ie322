
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
            this.listnumber = new System.Windows.Forms.ListBox();
            this.arrayequation = new System.Windows.Forms.Button();
            this.btnBack5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArray
            // 
            this.btnArray.Location = new System.Drawing.Point(73, 73);
            this.btnArray.Name = "btnArray";
            this.btnArray.Size = new System.Drawing.Size(179, 51);
            this.btnArray.TabIndex = 0;
            this.btnArray.Text = "Array For";
            this.btnArray.UseVisualStyleBackColor = true;
            this.btnArray.Click += new System.EventHandler(this.btnArray_Click);
            // 
            // btnarray2
            // 
            this.btnarray2.Location = new System.Drawing.Point(73, 147);
            this.btnarray2.Name = "btnarray2";
            this.btnarray2.Size = new System.Drawing.Size(182, 68);
            this.btnarray2.TabIndex = 1;
            this.btnarray2.Text = "Array Foreach";
            this.btnarray2.UseVisualStyleBackColor = true;
            this.btnarray2.Click += new System.EventHandler(this.btnarray2_Click);
            // 
            // listnumber
            // 
            this.listnumber.FormattingEnabled = true;
            this.listnumber.ItemHeight = 16;
            this.listnumber.Location = new System.Drawing.Point(594, 193);
            this.listnumber.Name = "listnumber";
            this.listnumber.Size = new System.Drawing.Size(142, 148);
            this.listnumber.TabIndex = 2;
            // 
            // arrayequation
            // 
            this.arrayequation.Location = new System.Drawing.Point(409, 235);
            this.arrayequation.Name = "arrayequation";
            this.arrayequation.Size = new System.Drawing.Size(148, 50);
            this.arrayequation.TabIndex = 3;
            this.arrayequation.Text = "Array equiation";
            this.arrayequation.UseVisualStyleBackColor = true;
            this.arrayequation.Click += new System.EventHandler(this.arrayequation_Click);
            // 
            // btnBack5
            // 
            this.btnBack5.Location = new System.Drawing.Point(593, 398);
            this.btnBack5.Name = "btnBack5";
            this.btnBack5.Size = new System.Drawing.Size(153, 38);
            this.btnBack5.TabIndex = 4;
            this.btnBack5.Text = "Back";
            this.btnBack5.UseVisualStyleBackColor = true;
            this.btnBack5.Click += new System.EventHandler(this.btnBack5_Click);
            // 
            // Frmarray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack5);
            this.Controls.Add(this.arrayequation);
            this.Controls.Add(this.listnumber);
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
        private System.Windows.Forms.ListBox listnumber;
        private System.Windows.Forms.Button arrayequation;
        private System.Windows.Forms.Button btnBack5;
    }
}