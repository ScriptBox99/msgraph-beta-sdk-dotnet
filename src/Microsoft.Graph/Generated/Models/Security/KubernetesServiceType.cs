using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum KubernetesServiceType {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "clusterIP")]
        ClusterIP,
        [EnumMember(Value = "externalName")]
        ExternalName,
        [EnumMember(Value = "nodePort")]
        NodePort,
        [EnumMember(Value = "loadBalancer")]
        LoadBalancer,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
