using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Message
{
    public class MemberIdRequest : RequestMessage
    {
        [Required]
        public long MemberId { get; set; }
    }
}
