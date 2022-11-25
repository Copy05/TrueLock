using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using TrueLock.Util;

namespace TrueLock
{

    namespace Util
    {
        internal class Helpers
        {
            /// <summary>
            /// Executes a command.
            /// </summary>
            public static void ExecuteCommand(string command)
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.Arguments = "/C" + command;
                process.StartInfo = startInfo;
                process.Start();
            }

            public static void KillProcess(string proc)
            {
                ExecuteCommand("taskkill /f /im " + proc);
            }
        }

    }
    
}