using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using EzAspDotNet.Protocols.Id;

namespace EzAspDotNet.Protocols
{
    public class RequestHeader
    {
        public virtual ProtocolId ProtocolId { get; set; }

        [JsonExtensionData]
        public JObject ExtensionData { get; set; }
    }
}
