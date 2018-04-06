using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Message
{
    public abstract class RequestMessage
    {
        public RequestMessage()
        {
            Header = new RequestHeader
            {

            };
        }
        public RequestHeader Header { get; set; }
    }
    /// <summary>
    /// 消息请求头
    /// </summary>
    public class RequestHeader
    {
        /// <summary>
        /// 操作人
        /// </summary>
        public long Operator { get; set; }
        /// <summary>
        /// 客户端IP
        /// </summary>
        public String IP { get; set; }
    }

}
