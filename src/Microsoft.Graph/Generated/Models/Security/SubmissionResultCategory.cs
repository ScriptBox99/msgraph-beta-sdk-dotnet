// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum SubmissionResultCategory {
        [EnumMember(Value = "notJunk")]
        NotJunk,
        [EnumMember(Value = "spam")]
        Spam,
        [EnumMember(Value = "phishing")]
        Phishing,
        [EnumMember(Value = "malware")]
        Malware,
        [EnumMember(Value = "allowedByPolicy")]
        AllowedByPolicy,
        [EnumMember(Value = "blockedByPolicy")]
        BlockedByPolicy,
        [EnumMember(Value = "spoof")]
        Spoof,
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "noResultAvailable")]
        NoResultAvailable,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
