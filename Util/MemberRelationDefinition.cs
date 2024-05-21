using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMARTMMS.Util
{
    public class MemberRelationDefinition
    {
        public string MemberNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public short RelationTypeId { get; set; }
        public int MemberId { get; set; }
        public int MemberRelationId { get; set; }
    }
}
