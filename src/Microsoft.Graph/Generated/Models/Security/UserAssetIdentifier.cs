using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum UserAssetIdentifier {
        [EnumMember(Value = "accountObjectId")]
        AccountObjectId,
        [EnumMember(Value = "accountSid")]
        AccountSid,
        [EnumMember(Value = "accountUpn")]
        AccountUpn,
        [EnumMember(Value = "accountName")]
        AccountName,
        [EnumMember(Value = "accountDomain")]
        AccountDomain,
        [EnumMember(Value = "accountId")]
        AccountId,
        [EnumMember(Value = "requestAccountSid")]
        RequestAccountSid,
        [EnumMember(Value = "requestAccountName")]
        RequestAccountName,
        [EnumMember(Value = "requestAccountDomain")]
        RequestAccountDomain,
        [EnumMember(Value = "recipientObjectId")]
        RecipientObjectId,
        [EnumMember(Value = "processAccountObjectId")]
        ProcessAccountObjectId,
        [EnumMember(Value = "initiatingAccountSid")]
        InitiatingAccountSid,
        [EnumMember(Value = "initiatingProcessAccountUpn")]
        InitiatingProcessAccountUpn,
        [EnumMember(Value = "initiatingAccountName")]
        InitiatingAccountName,
        [EnumMember(Value = "initiatingAccountDomain")]
        InitiatingAccountDomain,
        [EnumMember(Value = "servicePrincipalId")]
        ServicePrincipalId,
        [EnumMember(Value = "servicePrincipalName")]
        ServicePrincipalName,
        [EnumMember(Value = "targetAccountUpn")]
        TargetAccountUpn,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
