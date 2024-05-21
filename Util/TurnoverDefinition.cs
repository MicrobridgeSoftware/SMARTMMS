using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMARTMMS.Util
{
    public class TurnoverDefinition
    {
        public string MemberNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime? RefDate { get; set; }
        public string Congregation { get; set; }
        public string Comment { get; set; }
        public string ReportGroupField { get; set; }
    }
}
