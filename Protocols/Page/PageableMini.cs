
namespace EzAspDotNet.Protocols.Page
{
    public class PageableMini
    {
        public int Offset { get; set; } = 0;

        public int Limit { get; set; } = 20;
        public int Page => (Offset / Limit) + 1;
    }
}
