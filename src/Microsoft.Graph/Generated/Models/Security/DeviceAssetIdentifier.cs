using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum DeviceAssetIdentifier {
        [EnumMember(Value = "deviceId")]
        DeviceId,
        [EnumMember(Value = "deviceName")]
        DeviceName,
        [EnumMember(Value = "remoteDeviceName")]
        RemoteDeviceName,
        [EnumMember(Value = "targetDeviceName")]
        TargetDeviceName,
        [EnumMember(Value = "destinationDeviceName")]
        DestinationDeviceName,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
