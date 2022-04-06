using System.Collections.Generic;

namespace EzAspDotNet.Protocols.Page
{
    public class PageMiniResponse<T> : ResponseHeader
    {
        public long Total { get; set; }

        public List<T> Contents { get; set; }

        public PageableMini Pageable { get; set; }

        public int TotalPage => (int)Total / Pageable.Limit;
    }
}
