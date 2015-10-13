using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using live.ocldeployment.com.Models;
using System.Diagnostics;
using System.IO;
using System.Security;

namespace live.ocldeployment.com.DAL
{
    public class BatExecution
    {
        public BatExecInfo  findBat(int website)
        {
            //get bat directories
            BatDir batdir = new BatDir();
            string[] dirs = batdir.BatDirs;

            

            List<string> result = new List<string>();
            result = executeBat(dirs[website]);
            

            BatExecInfo batinfo = new BatExecInfo(result);
            return batinfo;
        }


        //private List<string> executeBat(string dir)
        //{
        //    List<string> results = new List<string>();
        //    Process process = new Process();
        //    process.StartInfo.FileName = dir; 
        //    process.StartInfo.UseShellExecute = false;

        //    string updatePath = "C:\\Websites\\OCL-HG\\update.log";
           

        //    process.Start();

        //    //Read the bat file
        //    System.IO.StreamReader strm = System.IO.File.OpenText(dir);


        //    while (strm.Peek() != -1)
        //    {
        //        results.Add(strm.ReadLine());
        //    }
        //    process.WaitForExit();


        //    // Read the log file
        //    //System.IO.StreamReader strm = System.IO.File.OpenText(updatePath);


        //    //while (strm.Peek() != -1)
        //    //{
        //    //    results.Add(strm.ReadLine());
        //    //}
        //    return results;
        //}

        private List<string> executeBat(string dir)
        {
            // Get the full file path
            string strFilePath = dir;

            List<string> results = new List<string>();
         //    Create the ProcessInfo object
           ProcessStartInfo psi = new ProcessStartInfo("cmd.exe");
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardInput = true;
            psi.RedirectStandardError = true;
            psi.UserName = "SVNuser";

        // Set secure strin
            var pw = new SecureString();
            foreach (char c in "dfHG56tr")
            {
                pw.AppendChar(c);
            }


            psi.Password = pw;


           //  Start the process
            Process proc = Process.Start(psi);



           //  Open the batch file for reading
           StreamReader strm = File.OpenText(strFilePath);


          //   Attach the output for reading
           StreamReader sOut = proc.StandardOutput;


         //    Attach the in for writing
           StreamWriter sIn = proc.StandardInput;



           //  Write each line of the batch file to standard input
            while (strm.Peek() != -1)
            {
                sIn.WriteLine(strm.ReadLine());
             
            }


            strm.Close();


           //  Exit CMD.EXE
            string stEchoFmt = "# {0} run successfully. Exiting";


            sIn.WriteLine(String.Format(stEchoFmt, strFilePath));
            sIn.WriteLine("EXIT");


           //  Close the process
            proc.Close();


            // Read the sOut to a string.
            string temp = sOut.ReadToEnd().Trim().Replace(System.Environment.NewLine, "<br>");
            results.Add(temp);



           //  Close the io Streams;
            sIn.Close();
            sOut.Close();

            return results;
        }
    }
}