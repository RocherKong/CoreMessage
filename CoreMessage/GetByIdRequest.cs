using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Message
{
    public class GetByIdRequest<T> : RequestMessage
    {
        [Required]
        public T Id { get; set; }
    }


    public class GetByIdRequest : GetByIdRequest<long>
    {

    }
}
