using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace S60SigningTool
{
    /// <summary>
    /// 
    /// </summary>
    public class ExecuteCmd
    {
        public event DataReceivedEventHandler Output;
        public event DataReceivedEventHandler Error;

        /// <summary>
        /// Executes a shell command synchronously.
        /// </summary>
        /// <param name="command">string command</param>
        /// <returns>string, as output of the command.</returns>
        public void ExecuteCommandSync(object command)
        {
            try
            {
                ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd",  "/c " + command);

                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.RedirectStandardError = true;
                procStartInfo.UseShellExecute = false;                             
                procStartInfo.CreateNoWindow = true;

                Process proc = new System.Diagnostics.Process();

                proc.StartInfo = procStartInfo;
                proc.EnableRaisingEvents = true;

                proc.ErrorDataReceived += new DataReceivedEventHandler(proc_ErrorDataReceived);
                proc.OutputDataReceived += new DataReceivedEventHandler(proc_OutputDataReceived);                

                proc.Start();

                proc.BeginErrorReadLine();
                proc.BeginOutputReadLine();

                proc.WaitForExit();
            }
            catch (Exception objException)
            {
            }
        }

        void proc_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (Output != null)
            {
                Output(sender, e);
            }
        }

        void proc_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (Error != null)
            {
                Error(sender, e);
            }
        }

        /// <summary>
        /// Execute the command Asynchronously.
        /// </summary>
        /// <param name="command">string command.</param>
        public void ExecuteCommandAsync(string command)
        {
            try
            {
                //Asynchronously start the Thread to process the Execute command request.
                Thread objThread = new Thread(new ParameterizedThreadStart(ExecuteCommandSync));

                //Make the thread as background thread.
                objThread.IsBackground = true;

                //Set the Priority of the thread.
                objThread.Priority = ThreadPriority.AboveNormal;

                //Start the thread.
                objThread.Start(command);
            }
            catch (ThreadStartException objException)
            {
                // Log the exception
            }
            catch (ThreadAbortException objException)
            {
                // Log the exception
            }
            catch (Exception objException)
            {
                // Log the exception
            }
        }
    }
}
