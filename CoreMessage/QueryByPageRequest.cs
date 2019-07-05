using System.ComponentModel.DataAnnotations;

namespace Core.Message
{
    public class QueryByPageRequest : RequestMessage
    {
        [Range(1, 9999999999999)] public int PageIndex { get; set; } = 1;
        [Range(1, 9999999999999)] public int PageSize { get; set; } = 10;

        public int Offset => (this.PageIndex - 1) * this.PageSize;
    }
}