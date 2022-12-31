using Siticone.Desktop.UI.WinForms;
using System.Diagnostics;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Runtime.InteropServices;

namespace QwertyInjector
{
    public partial class QwertyInjector : Form
    {
        public QwertyInjector()
        {
            InitializeComponent();
        }

        private void FileDialogButton_Click(object sender, EventArgs e)
        {
            var Dialog = new OpenFileDialog();
            Dialog.ShowDialog();
            if (Dialog.FileName == "")
            {
                MessageDialog.Show(null, "Please select a .dll!", "Error!", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
                LoggerLabel.Text = "Please select a .dll!";
            }
            else 
            {
                if (!Dialog.FileName.Contains(".dll"))
                {
                    MessageDialog.Show(null, "That file is not .dll!", "Error!", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
                    LoggerLabel.Text = "That file is not .dll!";
                }
                else
                {
                    FileLocation.Text = Dialog.FileName;
                }
            }
        }

        public void StartInject(object sender, EventArgs ev)
        {
            if(FileLocation.Text.Trim() == "")
            {
                LoggerLabel.Text = "Please select a .dll!";
            } else
            {
                if(ProcessName.Text.Trim() == "")
                {
                    LoggerLabel.Text = "Type process location to inject.";
                }
                else
                {
                    this.inject(FileLocation.Text, ProcessName.Text.Replace(".exe", "")); // Start Injecting
                }
            }
        }

        public void applyAppPackages(string DLLPath)
        {
            FileInfo fileInfo = new FileInfo(DLLPath);
            FileSecurity accessControl = fileInfo.GetAccessControl();
            accessControl.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier("S-1-15-2-1"), FileSystemRights.FullControl, InheritanceFlags.None, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
            fileInfo.SetAccessControl(accessControl);
        }

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        // Token: 0x06000038 RID: 56
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        // Token: 0x06000039 RID: 57
        [DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        // Token: 0x0600003A RID: 58
        [DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
        private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

        // Token: 0x0600003B RID: 59
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out UIntPtr lpNumberOfBytesWritten);

        // Token: 0x0600003C RID: 60
        [DllImport("kernel32.dll")]
        private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        public void inject(string path, string process_name)
        {
            if (Process.GetProcessesByName(process_name).Length != 0)
            {
                try // to prevent this error: if this has a failure that means user doesnt run the application to administrator.
                {
                    this.applyAppPackages(path);
                    Process process = Process.GetProcessesByName(process_name)[0];
                    IntPtr hProcess = OpenProcess(1082, false, process.Id);
                    IntPtr procAddress = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");
                    IntPtr intPtr = VirtualAllocEx(hProcess, IntPtr.Zero, (uint)((path.Length + 1) * Marshal.SizeOf(typeof(char))), 12288U, 4U);
                    UIntPtr uintPtr;
                    WriteProcessMemory(hProcess, intPtr, Encoding.Default.GetBytes(path), (uint)((path.Length + 1) * Marshal.SizeOf(typeof(char))), out uintPtr);
                    CreateRemoteThread(hProcess, IntPtr.Zero, 0U, procAddress, intPtr, 0U, IntPtr.Zero);
                    LoggerLabel.Text = "Injected!";
                    return;
                } catch
                {
                    LoggerLabel.Text = "Failed to Inject!";
                }
            } else
            {
                LoggerLabel.Text = "Failed to Inject!";
            }
        }

        private void RightClickMenu(object sender, MouseEventArgs e)
        {
            Menu.Show(Cursor.Position.X, Cursor.Position.Y); // menustrip trixks
        }

        private void InjectViaMenu(object sender, EventArgs e)
        {
            if (FileLocation.Text.Trim() == "")
            {
                LoggerLabel.Text = "Please select a .dll!";
            }
            else
            {
                if (ProcessName.Text.Trim() == "")
                {
                    LoggerLabel.Text = "Type process location to inject.";
                }
                else
                {
                    this.inject(FileLocation.Text, ProcessName.Text.Replace(".exe", "")); // Start Injecting
                }
            }
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DiscordLink_Open(object sender, EventArgs ev) => Process.Start("https://discord.gg/9QApUXEvpJ");
        private void GithubLink_Open(object sender, EventArgs ev) => Process.Start("https://github.com/QwertyDevelopment");
        private void WebsiteLink_Open(object sender, EventArgs ev) => Process.Start("https://qwertydev.tk/");
    }
}