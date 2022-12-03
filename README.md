

<div align="center">
<h1 style="font-size:40px">
	  <b>Truelock</b>
</h1>
<p>
	  A simple & User friendly Screenlocker
</p>

<b>Author:</b> Copy05
<br><br>
</div>

**Truelock** is a user-friendly screenlock application for kiosk windows devices and for users who want to lock their screen. *(probably double locking.)*

## **Why did i made this project**
---
I wanted to create my own lock screen, which has more feature than the windows login screen. I wanted that the login screen should not be boring or annoying that's why i implemented the Texteditor feature but for safety features i didnt implement the save button. 

The Design of this application is inspired by Windows XP & Windows 95.

# Features

- Splash Screen
- User-friendly UI
- Ability to double lock *(Lock and then Win + L)*
- Customizeable Login Deails
- CLI

```ps1
./truelock username password -browser url
```

- WebBrowser Lock
- Disabling Keyboard Shortcuts *(Alt + f4, Alt + Tab, etc...)*
- Can be used in a multiple monitor workspace.

Optional Options
-
- Shutdown Button on Login Form
- TrueLock TextEditor Option. (content cannot be saved.)
- Taskkill most of the applications

Knowen Problems
-
- If you're not carefully you can lose your unsaved work.
- If TrueLock Crashes and you dont have Task Manager then you have to restart
- WebBrowser can crash.


# Some Code Snippits

**Which Process gets killed when "Kill Mostly of apps" is enabled:** 
```cs
// Task names are stored in a array. these processes are getting killed if it's enabled
string[] procName = { "chrome.exe", "teams.exe", "edge.exe", "firefox.exe", "word.exe", "excel.exe", "code.exe", 
                    "powerpoint.exe", "outlook.exe", "notepad.exe", "mspaint.exe", "powershell.exe", "minecraft.exe", "access.exe" };
```

**Which Keys are disabled:**
```cs
// Variables for Keycodes and C# Keys
int vkCode = Marshal.ReadInt32(lParam);
Keys key = (Keys)vkCode;

// Disable Most of the Keys. but ctrl + alt + del, win + l & fn + f1 still works and cannot be suppressed!
if (key == Keys.LWin || key == Keys.RWin || key == Keys.Alt || key == Keys.Tab || key == Keys.LControlKey || key == Keys.RControlKey || key == Keys.Delete || key == Keys.Escape || key == Keys.Control && key == Keys.Alt && key == Keys.Delete || key == Keys.Alt && key == Keys.Escape || key == Keys.LControlKey && key == Keys.Alt && key == Keys.Delete || key == Keys.RControlKey && key == Keys.Alt && key == Keys.Delete || key == Keys.VolumeUp || key == Keys.VolumeDown || key == Keys.VolumeDown || key == Keys.F4 || key == Keys.LWin && key == Keys.L || key == Keys.Print || key == Keys.Sleep || key == Keys.F11 || key == Keys.F1)
    return (IntPtr)1; // Key disabled. 
```
