
namespace For_Quiz_2
{
    partial class Frmain
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
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnusername = new System.Windows.Forms.Label();
            this.btnpassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnradio = new System.Windows.Forms.Button();
            this.btnCheckBox = new System.Windows.Forms.Button();
            this.btnCombo = new System.Windows.Forms.Button();
            this.btnCombo2 = new System.Windows.Forms.Button();
            this.btnrandomcombo = new System.Windows.Forms.Button();
            this.buttonarray = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(60, 167);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(163, 43);
            this.btnlogin.TabIndex = 0;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnusername
            // 
            this.btnusername.AutoSize = true;
            this.btnusername.ForeColor = System.Drawing.Color.Red;
            this.btnusername.Location = new System.Drawing.Point(30, 61);
            this.btnusername.Name = "btnusername";
            this.btnusername.Size = new System.Drawing.Size(73, 17);
            this.btnusername.TabIndex = 1;
            this.btnusername.Text = "Username";
            // 
            // btnpassword
            // 
            this.btnpassword.AutoSize = true;
            this.btnpassword.ForeColor = System.Drawing.Color.Red;
            this.btnpassword.Location = new System.Drawing.Point(30, 113);
            this.btnpassword.Name = "btnpassword";
            this.btnpassword.Size = new System.Drawing.Size(69, 17);
            this.btnpassword.TabIndex = 2;
            this.btnpassword.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(91, 22);
            this.textBox2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnusername);
            this.groupBox1.Controls.Add(this.btnlogin);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.btnpassword);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(72, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 227);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // btnradio
            // 
            this.btnradio.Location = new System.Drawing.Point(447, 93);
            this.btnradio.Name = "btnradio";
            this.btnradio.Size = new System.Drawing.Size(146, 62);
            this.btnradio.TabIndex = 6;
            this.btnradio.Text = "Radio";
            this.btnradio.UseVisualStyleBackColor = true;
            this.btnradio.Click += new System.EventHandler(this.btnradio_Click);
            // 
            // btnCheckBox
            // 
            this.btnCheckBox.Location = new System.Drawing.Point(447, 181);
            this.btnCheckBox.Name = "btnCheckBox";
            this.btnCheckBox.Size = new System.Drawing.Size(138, 54);
            this.btnCheckBox.TabIndex = 7;
            this.btnCheckBox.Text = "Check Box";
            this.btnCheckBox.UseVisualStyleBackColor = true;
            this.btnCheckBox.Click += new System.EventHandler(this.btnCheckBox_Click);
            // 
            // btnCombo
            // 
            this.btnCombo.Location = new System.Drawing.Point(632, 97);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(156, 60);
            this.btnCombo.TabIndex = 8;
            this.btnCombo.Text = "Combo";
            this.btnCombo.UseVisualStyleBackColor = true;
            this.btnCombo.Click += new System.EventHandler(this.btnCombo_Click);
            // 
            // btnCombo2
            // 
            this.btnCombo2.Location = new System.Drawing.Point(455, 12);
            this.btnCombo2.Name = "btnCombo2";
            this.btnCombo2.Size = new System.Drawing.Size(130, 50);
            this.btnCombo2.TabIndex = 9;
            this.btnCombo2.Text = "Combo 2";
            this.btnCombo2.UseVisualStyleBackColor = true;
            this.btnCombo2.Click += new System.EventHandler(this.btnCombo2_Click);
            // 
            // btnrandomcombo
            // 
            this.btnrandomcombo.Location = new System.Drawing.Point(656, 12);
            this.btnrandomcombo.Name = "btnrandomcombo";
            this.btnrandomcombo.Size = new System.Drawing.Size(98, 52);
            this.btnrandomcombo.TabIndex = 10;
            this.btnrandomcombo.Text = "Random Combo";
            this.btnrandomcombo.UseVisualStyleBackColor = true;
            this.btnrandomcombo.Click += new System.EventHandler(this.btnrandomcombo_Click);
            // 
            // buttonarray
            // 
            this.buttonarray.Location = new System.Drawing.Point(633, 181);
            this.buttonarray.Name = "buttonarray";
            this.buttonarray.Size = new System.Drawing.Size(121, 68);
            this.buttonarray.TabIndex = 11;
            this.buttonarray.Text = "Array";
            this.buttonarray.UseVisualStyleBackColor = true;
            this.buttonarray.Click += new System.EventHandler(this.buttonarray_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnExit.Location = new System.Drawing.Point(618, 382);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(135, 52);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Frmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.buttonarray);
            this.Controls.Add(this.btnrandomcombo);
            this.Controls.Add(this.btnCombo2);
            this.Controls.Add(this.btnCombo);
            this.Controls.Add(this.btnCheckBox);
            this.Controls.Add(this.btnradio);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frmain";
            this.Text = "My First Application";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label btnusername;
        private System.Windows.Forms.Label btnpassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnradio;
        private System.Windows.Forms.Button btnCheckBox;
        private System.Windows.Forms.Button btnCombo;
        private System.Windows.Forms.Button btnCombo2;
        private System.Windows.Forms.Button btnrandomcombo;
        private System.Windows.Forms.Button buttonarray;
        private System.Windows.Forms.Button btnExit;
    }
}

