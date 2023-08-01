using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum EducationModuleStatus {
        [EnumMember(Value = "draft")]
        Draft,
        [EnumMember(Value = "published")]
        Published,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
