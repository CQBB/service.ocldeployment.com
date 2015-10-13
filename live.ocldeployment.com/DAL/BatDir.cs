using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace live.ocldeployment.com.DAL
{
    public class BatDir
    {
        public String[] BatDirs {             
        get { 
            String[] BatDirs=new String[11];
            BatDirs[0] = "c:\\Websites\\OCL-HG\\DeploymentBats\\DeployAdmin.nurse.com.bat";
            BatDirs[1] = "c:\\Websites\\OCL-HG\\DeploymentBats\\Deployce.nurse.com.bat";
            BatDirs[2] = "c:\\Websites\\OCL-HG\\DeploymentBats\\DeployCEAdmin.bat";
            BatDirs[3] = "c:\\Websites\\OCL-HG\\DeploymentBats\\DeployCEDirect.bat";
            BatDirs[4] = "c:\\Websites\\OCL-HG\\DeploymentBats\\DeployContinuingeducation.com.bat";
            BatDirs[5] = "c:\\Websites\\OCL-HG\\DeploymentBats\\DeployJobAdmin.nurse.com.bat";
            BatDirs[6] = "c:\\Websites\\OCL-HG\\DeploymentBats\\Deploypearlsreview.com.bat";
            BatDirs[7] = "c:\\Websites\\OCL-HG\\DeploymentBats\\DeploySymphonyImport.bat";
            BatDirs[8] = "c:\\Websites\\OCL-HG\\DeploymentBats\\Deploywww.nurse.com.bat";
            BatDirs[9] = "c:\\Websites\\OCL-HG\\DeploymentBats\\Deploywww.todayinot.com.bat";
            BatDirs[10] = "c:\\Websites\\OCL-HG\\DeploymentBats\\Deploywww.todayinpt.com.bat";

            return BatDirs;
        }  }
    }
}