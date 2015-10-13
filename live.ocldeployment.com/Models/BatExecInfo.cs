using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace live.ocldeployment.com.Models
{
    public class BatExecInfo
    {
        public BatExecInfo(){}
        public BatExecInfo(List<string> result)
        {
            BatExecResult = result;
        }

        public List<string> BatExecResult { get; set; }
    }
}