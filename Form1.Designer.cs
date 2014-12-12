namespace HTML5Minifer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_minify = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txt_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.rdo_dot_min = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_browse);
            this.groupBox1.Controls.Add(this.txt_path);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(25, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.groupBox1.Size = new System.Drawing.Size(376, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Input Directory ";
            // 
            // btn_browse
            // 
            this.btn_browse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_browse.Location = new System.Drawing.Point(15, 67);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(346, 36);
            this.btn_browse.TabIndex = 1;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // txt_path
            // 
            this.txt_path.BackColor = System.Drawing.SystemColors.Info;
            this.txt_path.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_path.Location = new System.Drawing.Point(15, 34);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(346, 27);
            this.txt_path.TabIndex = 0;
            this.txt_path.Text = "D:\\wamp\\www\\bizsearch";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.rdo_dot_min);
            this.groupBox2.Controls.Add(this.btn_minify);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(25, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.groupBox2.Size = new System.Drawing.Size(376, 159);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Output";
            // 
            // btn_minify
            // 
            this.btn_minify.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_minify.Location = new System.Drawing.Point(15, 100);
            this.btn_minify.Name = "btn_minify";
            this.btn_minify.Size = new System.Drawing.Size(346, 45);
            this.btn_minify.TabIndex = 1;
            this.btn_minify.Text = "Minify";
            this.btn_minify.UseVisualStyleBackColor = true;
            this.btn_minify.Click += new System.EventHandler(this.btn_minify_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_status});
            this.statusStrip1.Location = new System.Drawing.Point(25, 305);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(376, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txt_status
            // 
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(12, 17);
            this.txt_status.Text = "*";
            // 
            // rdo_dot_min
            // 
            this.rdo_dot_min.AutoSize = true;
            this.rdo_dot_min.Location = new System.Drawing.Point(18, 37);
            this.rdo_dot_min.Name = "rdo_dot_min";
            this.rdo_dot_min.Size = new System.Drawing.Size(233, 23);
            this.rdo_dot_min.TabIndex = 2;
            this.rdo_dot_min.Text = "Output on same place + \".min\"";
            this.rdo_dot_min.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(18, 66);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(271, 23);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Output on \'/_minified/\' sub directory";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 351);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(25, 24, 25, 24);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTML5Minifier : minifies all js and css files of a directory";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_minify;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txt_status;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rdo_dot_min;
    }
}

