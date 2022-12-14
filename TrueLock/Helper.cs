/*
 * 
 * Copyright Copy05 2016-2023
 * TrueLock is a product by Copy05.
 * 
 * **/

using System;
using System.Diagnostics;

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
