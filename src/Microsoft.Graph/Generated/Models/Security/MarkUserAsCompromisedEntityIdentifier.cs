using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum MarkUserAsCompromisedEntityIdentifier {
        [EnumMember(Value = "accountObjectId")]
        AccountObjectId,
        [EnumMember(Value = "initiatingProcessAccountObjectId")]
        InitiatingProcessAccountObjectId,
        [EnumMember(Value = "servicePrincipalId")]
        ServicePrincipalId,
        [EnumMember(Value = "recipientObjectId")]
        RecipientObjectId,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
