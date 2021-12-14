
namespace For_Quiz_2
{
    partial class frmcombo
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
            this.cmbdays = new System.Windows.Forms.ComboBox();
            this.btnshow1 = new System.Windows.Forms.Button();
            this.btnRemovebyname = new System.Windows.Forms.Button();
            this.btnRemovebyindex = new System.Windows.Forms.Button();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.btnremovelist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbdays
            // 
            this.cmbdays.FormattingEnabled = true;
            this.cmbdays.Location = new System.Drawing.Point(134, 196);
            this.cmbdays.Name = "cmbdays";
            this.cmbdays.Size = new System.Drawing.Size(104, 24);
            this.cmbdays.TabIndex = 0;
            this.cmbdays.SelectedIndexChanged += new System.EventHandler(this.cmbdays_SelectedIndexChanged);
            // 
            // btnshow1
            // 
            this.btnshow1.Location = new System.Drawing.Point(101, 85);
            this.btnshow1.Name = "btnshow1";
            this.btnshow1.Size = new System.Drawing.Size(156, 45);
            this.btnshow1.TabIndex = 1;
            this.btnshow1.Text = "Show Selected";
            this.btnshow1.UseVisualStyleBackColor = true;
            this.btnshow1.Click += new System.EventHandler(this.btnshow1_Click);
            // 
            // btnRemovebyname
            // 
            this.btnRemovebyname.Location = new System.Drawing.Point(708, 85);
            this.btnRemovebyname.Name = "btnRemovebyname";
            this.btnRemovebyname.Size = new System.Drawing.Size(171, 57);
            this.btnRemovebyname.TabIndex = 2;
            this.btnRemovebyname.Text = "Remove by name";
            this.btnRemovebyname.UseVisualStyleBackColor = true;
            this.btnRemovebyname.Click += new System.EventHandler(this.btnRemovebyname_Click);
            // 
            // btnRemovebyindex
            // 
            this.btnRemovebyindex.Location = new System.Drawing.Point(712, 186);
            this.btnRemovebyindex.Name = "btnRemovebyindex";
            this.btnRemovebyindex.Size = new System.Drawing.Size(167, 62);
            this.btnRemovebyindex.TabIndex = 3;
            this.btnRemovebyindex.Text = "Remove by index";
            this.btnRemovebyindex.UseVisualStyleBackColor = true;
            this.btnRemovebyindex.Click += new System.EventHandler(this.btnRemovebyindex_Click);
            // 
            // btnBack2
            // 
            this.btnBack2.Location = new System.Drawing.Point(733, 336);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(160, 55);
            this.btnBack2.TabIndex = 4;
            this.btnBack2.Text = "Back";
            this.btnBack2.UseVisualStyleBackColor = true;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);
            // 
            // btnremovelist
            // 
            this.btnremovelist.Location = new System.Drawing.Point(386, 191);
            this.btnremovelist.Name = "btnremovelist";
            this.btnremovelist.Size = new System.Drawing.Size(143, 56);
            this.btnremovelist.TabIndex = 5;
            this.btnremovelist.Text = "Remove List";
            this.btnremovelist.UseVisualStyleBackColor = true;
            this.btnremovelist.Click += new System.EventHandler(this.btnremovelist_Click);
            // 
            // frmcombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 450);
            this.Controls.Add(this.btnremovelist);
            this.Controls.Add(this.btnBack2);
            this.Controls.Add(this.btnRemovebyindex);
            this.Controls.Add(this.btnRemovebyname);
            this.Controls.Add(this.btnshow1);
            this.Controls.Add(this.cmbdays);
            this.Name = "frmcombo";
            this.Text = "Combo form";
            this.Load += new System.EventHandler(this.frmcombo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbdays;
        private System.Windows.Forms.Button btnshow1;
        private System.Windows.Forms.Button btnRemovebyname;
        private System.Windows.Forms.Button btnRemovebyindex;
        private System.Windows.Forms.Button btnBack2;
        private System.Windows.Forms.Button btnremovelist;
    }
}