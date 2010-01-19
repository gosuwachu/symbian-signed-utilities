using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace S60SigningTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void browseFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                file.Text = openFileDialog.FileName;
            }
        }

        private void browseOutput_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                output.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void browseCertificate_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                certificate.Text = openFileDialog.FileName;
            }
        }

        private void browseKey_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                key.Text = openFileDialog.FileName;
            }
        }

        private void run_Click(object sender, EventArgs e)
        {
            ExecuteCmd cmd = new ExecuteCmd();
            if (unsign.Checked)
            {
                cmd.ExecuteCommandSync(BuildUnsignCommand());
            }
            cmd.ExecuteCommandSync(BuildSignCommand());
        }

        private string BuildUnsignCommand()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("signsis ");
            stringBuilder.Append("-u ");
            stringBuilder.Append(file.Text + " ");
            stringBuilder.Append(output.Text);
            return stringBuilder.ToString();
        }

        private string BuildSignCommand()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("signsis ");
            stringBuilder.Append("-v ");
            stringBuilder.Append(file.Text + " ");
            stringBuilder.Append(output.Text + " ");
            stringBuilder.Append(certificate.Text + " ");
            stringBuilder.Append(key.Text);
            return stringBuilder.ToString();
        }
    }
}
