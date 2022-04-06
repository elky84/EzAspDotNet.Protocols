
namespace EzAspDotNet.Protocols.Page
{
    public class Pageable
    {
        public int Offset { get; set; } = 0;

        public int Limit { get; set; } = 20;

        public int Page => (Offset / Limit) + 1;

        public string Sort { get; set; }

        public bool Asc { get; set; }
    }
}
