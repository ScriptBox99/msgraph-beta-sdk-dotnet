using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum RootDomains {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "allFederated")]
        AllFederated,
        [EnumMember(Value = "allManaged")]
        AllManaged,
        [EnumMember(Value = "enumerated")]
        Enumerated,
        [EnumMember(Value = "allManagedAndEnumeratedFederated")]
        AllManagedAndEnumeratedFederated,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
