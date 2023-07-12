using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.IdentityGovernance {
    public enum ValueTypeObject {
        [EnumMember(Value = "enum")]
        Enum,
        [EnumMember(Value = "string")]
        String,
        [EnumMember(Value = "int")]
        Int,
        [EnumMember(Value = "bool")]
        Bool,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
