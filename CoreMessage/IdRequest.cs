using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Core.Message
{
    public class IdRequest<T> : RequestMessage
    {
        [Required]
        public T Id { get; set; }
    }

    public class IdRequest : IdRequest<long>
    {

    }
}
