// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    [Flags]
    public enum NotificationDestination {
        [EnumMember(Value = "none")]
        None = 1,
        [EnumMember(Value = "api")]
        Api = 2,
        [EnumMember(Value = "email")]
        Email = 4,
        [EnumMember(Value = "sms")]
        Sms = 8,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue = 16,
    }
}
