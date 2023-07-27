using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum IsolationType {
        [EnumMember(Value = "full")]
        Full,
        [EnumMember(Value = "selective")]
        Selective,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
