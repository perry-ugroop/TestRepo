using BasicAcct.Lib.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAcct.Lib.Models
{
    public class GeneralLedgerAccount
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public AccountingElementType ElementType { get; set; }
    }
}
