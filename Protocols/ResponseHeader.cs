using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using EzAspDotNet.Protocols.Id;
using EzAspDotNet.Protocols.Code;

namespace EzAspDotNet.Protocols
{
    public class ResponseHeader
    {
        public ResultCode ResultCode { get; set; } = ResultCode.Success;

        public virtual ProtocolId ProtocolId { get; set; }

        [JsonExtensionData]
        public JObject ExtensionData { get; set; }
    }
}
