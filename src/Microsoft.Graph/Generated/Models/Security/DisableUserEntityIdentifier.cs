using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum DisableUserEntityIdentifier {
        [EnumMember(Value = "accountSid")]
        AccountSid,
        [EnumMember(Value = "initiatingProcessAccountSid")]
        InitiatingProcessAccountSid,
        [EnumMember(Value = "requestAccountSid")]
        RequestAccountSid,
        [EnumMember(Value = "onPremSid")]
        OnPremSid,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
