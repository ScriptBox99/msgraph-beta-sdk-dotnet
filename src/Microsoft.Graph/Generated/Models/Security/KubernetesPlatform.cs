using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum KubernetesPlatform {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "aks")]
        Aks,
        [EnumMember(Value = "eks")]
        Eks,
        [EnumMember(Value = "gke")]
        Gke,
        [EnumMember(Value = "arc")]
        Arc,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
