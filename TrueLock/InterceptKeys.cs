using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace TrueLock
{
    namespace Security
    {
        /// <summary>
        /// This class contains all functions which makes a C low-level-hook to disable Keyboard Shortcuts.
        /// </summary>
        internal class InterceptKeys
        {
            public delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

            private const int WH_KEYBOARD_LL = 13;
            private const int WM_KEYDOWN = 0x0100;
            public static IntPtr SetHook(LowLevelKeyboardProc proc)
            {
                using (Process curProcess = Process.GetCurrentProcess())
                using (ProcessModule curModule = curProcess.MainModule)
                {
                    return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
                }
            }

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            private static extern IntPtr SetWindowsHookEx(int idHook,
                                                          LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool UnhookWindowsHookEx(IntPtr hhk);

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
                                                       IntPtr wParam, IntPtr lParam);

            [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            private static extern IntPtr GetModuleHandle(string lpModuleName);
        }

        /// <summary>
        /// Creates a C low-level-hook to disable Keyboard Shortcuts.
        /// <code>
        /// public DisableKeys dk = new DisableKeys();
        /// </code>
        /// </summary>
        public class DisableKeys
        {
            private static readonly InterceptKeys.LowLevelKeyboardProc _proc = HookCallback;
            private static IntPtr _hookID = IntPtr.Zero;

            public DisableKeys()
            {
                try
                {
                    _hookID = InterceptKeys.SetHook(_proc);
                }
                catch
                {
                    DetachKeyboardHook();
                }
            }
            public static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
            {
                if (nCode >= 0)
                {
                    int vkCode = Marshal.ReadInt32(lParam);
                    Keys key = (Keys)vkCode;

                    // Disable Most of the Keys. but ctrl + alt + del, win + l & fn + f1 still works and cannot be suppressed!
                    if (key == Keys.LWin || key == Keys.RWin || key == Keys.Alt || key == Keys.Tab || key == Keys.LControlKey 
                        || key == Keys.RControlKey || key == Keys.Delete || key == Keys.Escape || key == Keys.Control && key == Keys.Alt && key == Keys.Delete 
                        || key == Keys.Alt && key == Keys.Escape || key == Keys.LControlKey && key == Keys.Alt && key == Keys.Delete 
                        || key == Keys.RControlKey && key == Keys.Alt && key == Keys.Delete || key == Keys.VolumeUp || key == Keys.VolumeDown || key == Keys.VolumeDown 
                        || key == Keys.F4 || key == Keys.LWin && key == Keys.L || key == Keys.Print || key == Keys.Sleep || key == Keys.F11 || key == Keys.F1)
                        return (IntPtr)1;
                }

                return InterceptKeys.CallNextHookEx(_hookID, nCode, wParam, lParam);
            }

            public static void DetachKeyboardHook()
            {
                if (_hookID != IntPtr.Zero)
                    InterceptKeys.UnhookWindowsHookEx(_hookID);
            }
        }
    }
}
