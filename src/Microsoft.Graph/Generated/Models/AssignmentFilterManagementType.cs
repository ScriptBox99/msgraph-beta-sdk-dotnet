using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Supported filter management types whether its devices or apps.</summary>
    public enum AssignmentFilterManagementType {
        /// <summary>Indicates when filter is supported based on device properties. This is the default value when management type resolution fails.</summary>
        [EnumMember(Value = "devices")]
        Devices,
        /// <summary>Indicates when filter is supported based on app properties.</summary>
        [EnumMember(Value = "apps")]
        Apps,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
