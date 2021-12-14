
namespace For_Quiz_2
{
    partial class frmcheckbox
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
            this.btnShow = new System.Windows.Forms.Button();
            this.cheCoffe = new System.Windows.Forms.CheckBox();
            this.cheDount = new System.Windows.Forms.CheckBox();
            this.cheBrownie = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(76, 29);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(151, 54);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // cheCoffe
            // 
            this.cheCoffe.AutoSize = true;
            this.cheCoffe.Location = new System.Drawing.Point(34, 28);
            this.cheCoffe.Name = "cheCoffe";
            this.cheCoffe.Size = new System.Drawing.Size(63, 21);
            this.cheCoffe.TabIndex = 1;
            this.cheCoffe.Text = "Coffe";
            this.cheCoffe.UseVisualStyleBackColor = true;
            // 
            // cheDount
            // 
            this.cheDount.AutoSize = true;
            this.cheDount.Location = new System.Drawing.Point(34, 82);
            this.cheDount.Name = "cheDount";
            this.cheDount.Size = new System.Drawing.Size(68, 21);
            this.cheDount.TabIndex = 2;
            this.cheDount.Text = "Dount";
            this.cheDount.UseVisualStyleBackColor = true;
            // 
            // cheBrownie
            // 
            this.cheBrownie.AutoSize = true;
            this.cheBrownie.Location = new System.Drawing.Point(34, 133);
            this.cheBrownie.Name = "cheBrownie";
            this.cheBrownie.Size = new System.Drawing.Size(80, 21);
            this.cheBrownie.TabIndex = 3;
            this.cheBrownie.Text = "Brownie";
            this.cheBrownie.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cheCoffe);
            this.panel1.Controls.Add(this.cheDount);
            this.panel1.Controls.Add(this.cheBrownie);
            this.panel1.Location = new System.Drawing.Point(59, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 177);
            this.panel1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 47);
            this.button2.TabIndex = 5;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmcheckbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnShow);
            this.Name = "frmcheckbox";
            this.Text = "CheckBox form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.CheckBox cheCoffe;
        private System.Windows.Forms.CheckBox cheDount;
        private System.Windows.Forms.CheckBox cheBrownie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
    }
}