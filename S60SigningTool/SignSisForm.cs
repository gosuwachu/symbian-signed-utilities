using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace S60SigningTool
{
    public partial class SignSisForm : Form
    {
        public SignSisForm()
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
            if (string.IsNullOrEmpty(output.Text) && saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                output.Text = saveFileDialog.FileName;
            }

            Execute();           
        }

        private void Execute()
        {
            ExecuteCmd cmd = new ExecuteCmd();
            cmd.Error += new System.Diagnostics.DataReceivedEventHandler(cmd_Error);
            cmd.Output += new System.Diagnostics.DataReceivedEventHandler(cmd_Output);

            if (unsign.Checked)
            {
                cmd.ExecuteCommandSync(BuildUnsignCommand());
            }
            cmd.ExecuteCommandSync(BuildSignCommand());
        }

        void cmd_Output(object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new DataReceivedEventHandler(cmd_Output), sender, e);
            }
            else
            {
                if (e.Data != null)
                {
                    consoleOutput.Items.Add(e.Data);
                }
            }
        }

        void cmd_Error(object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new DataReceivedEventHandler(cmd_Error), sender, e);
            }
            else
            {
                if (e.Data != null)
                {
                    consoleOutput.Items.Add(e.Data);
                }
            }
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

        private void SaveProject(object sender, EventArgs e)
        {
            Project project = new Project();
            project.FilePath = file.Text;
            project.Output = output.Text;
            project.Certificate = certificate.Text;
            project.Key = key.Text;
            project.Unsign = unsign.Checked;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Project.Serialize(openFileDialog.FileName, project);
            }            
        }

        private void LoadProject(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Project project = Project.Deserialize(openFileDialog.FileName);
                file.Text = project.FilePath;
                output.Text = project.Output;
                certificate.Text = project.Certificate;
                key.Text = project.Key;
                unsign.Checked = project.Unsign;
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            SymbianSigned form = new SymbianSigned();
            form.ShowDialog();
            form.Dispose();
        }
    }
}
