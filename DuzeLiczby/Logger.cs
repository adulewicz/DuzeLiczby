using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuzeLiczby
{
    public class Logger
    {
        public bool ErrorFlag;
        public bool WarningFlag;
        public List<string> Messages { get; set; }

        public Logger()
        {
            this.Messages = new List<string>(); 
            this.ErrorFlag = false;
            this.WarningFlag = false;
        }

    }
}
