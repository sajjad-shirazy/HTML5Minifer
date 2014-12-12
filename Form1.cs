using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Ajax.Utilities;
using System.IO;

namespace HTML5Minifer
{
    public partial class Form1 : Form
    {
        DirectoryInfo outputDirectory;
        Minifier minifier;
        public Form1()
        {
            InitializeComponent();
            this.minifier = new Minifier();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK){
                this.txt_path.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

        private void btn_minify_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(this.txt_path.Text))
            {
                var directory = new DirectoryInfo(this.txt_path.Text);
                if (!this.rdo_dot_min.Checked)
                    this.outputDirectory = directory.CreateSubdirectory("_minified");
                this.proccessDirectory(directory);
                this.txt_status.Text = "done :)";
            }
            else
            {
                MessageBox.Show("Directory does not Exists !");
            }
        }
        private void proccessDirectory(DirectoryInfo root)
        {
            foreach (FileInfo file in root.GetFiles("*.js"))
            {
                this.txt_status.Text = file.FullName.Split(new string[] { this.txt_path.Text }, StringSplitOptions.None)[1];
                Application.DoEvents();
                var path = "";
                if (this.rdo_dot_min.Checked)
                {
                    var filename = Path.GetFileNameWithoutExtension(this.txt_status.Text);
                    var directory = Path.GetDirectoryName(this.txt_status.Text);
                    path = this.txt_path.Text + '\\' + directory + '\\' + filename + ".min" + Path.GetExtension(this.txt_status.Text);
                }
                else
                {
                    path = this.outputDirectory.FullName + this.txt_status.Text;
                }
                Directory.CreateDirectory(Path.GetDirectoryName(path));
                File.WriteAllText(path, this.minifier.MinifyJavaScript(file.OpenText().ReadToEnd()));
            }
            foreach (FileInfo file in root.GetFiles("*.css"))
            {
                this.txt_status.Text = file.FullName.Split(new string[] { this.txt_path.Text }, StringSplitOptions.None)[1];
                Application.DoEvents();
                var path = "";
                if (this.rdo_dot_min.Checked)
                {
                    var filename = Path.GetFileNameWithoutExtension(this.txt_status.Text);
                    var directory = Path.GetDirectoryName(this.txt_status.Text);
                    path = this.txt_path.Text + '\\' + directory + '\\' + filename + ".min" + Path.GetExtension(this.txt_status.Text);
                }
                else
                {
                    path = this.outputDirectory.FullName + this.txt_status.Text;

                }
                Directory.CreateDirectory(Path.GetDirectoryName(path));
                File.WriteAllText(path, this.minifier.MinifyStyleSheet(file.OpenText().ReadToEnd()));
            }
            foreach (DirectoryInfo directory in root.GetDirectories())
            {
                if (!directory.FullName.Contains("_minified"))
                    this.proccessDirectory(directory);
            }
        }
    }
}
