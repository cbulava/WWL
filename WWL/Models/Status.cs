using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WWL.Models
{
    public class Status
    {
        public string message { get; set; }
        public bool status { get; set; }

        public Status(bool status, string message)
        {
            this.message = message;
            this.status = status;
        }
    }
}
