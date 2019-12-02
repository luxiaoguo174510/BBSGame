using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelInfo
{
    public class Comments
    {
        public int CId{ get; set; }
        public int UId{ get; set; }
        public string Content{ get; set; }
        public DateTime CreateDate { get; set; }
        public int PId{ get; set; }
        public int FId { get; set; }
    }
}
