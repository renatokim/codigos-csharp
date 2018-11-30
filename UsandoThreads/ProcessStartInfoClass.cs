using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoThreads
{
    public class ProcessStartInfoClass
    {
        public void ChromeStart()
        {
            Process.Start("https://www.dotnetperls.com/#default");
        }

        public void WordStart()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "WINWORD.EXE";
            startInfo.Arguments = @"C:\Users\Rebato\Desktop\teste.docx";
            Process.Start(startInfo);
        }

        public void NotePadStart()
        {
            Process.Start(@"C:\Program Files (x86)\Notepad++\Notepad++");
        }

        public void TxtStart()
        {
            Process.Start("writeLines.txt");
        }

        public void ExploresStart()
        {
            Process.Start("C:\\");
        }

            



    }
}
