using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum MailboxAssetIdentifier {
        [EnumMember(Value = "accountUpn")]
        AccountUpn,
        [EnumMember(Value = "fileOwnerUpn")]
        FileOwnerUpn,
        [EnumMember(Value = "initiatingProcessAccountUpn")]
        InitiatingProcessAccountUpn,
        [EnumMember(Value = "lastModifyingAccountUpn")]
        LastModifyingAccountUpn,
        [EnumMember(Value = "targetAccountUpn")]
        TargetAccountUpn,
        [EnumMember(Value = "senderFromAddress")]
        SenderFromAddress,
        [EnumMember(Value = "senderDisplayName")]
        SenderDisplayName,
        [EnumMember(Value = "recipientEmailAddress")]
        RecipientEmailAddress,
        [EnumMember(Value = "senderMailFromAddress")]
        SenderMailFromAddress,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
