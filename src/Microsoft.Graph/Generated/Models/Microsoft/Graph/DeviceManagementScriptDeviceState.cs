using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class DeviceManagementScriptDeviceState : Entity, IParsable {
        /// <summary>Error code corresponding to erroneous execution of the device management script.</summary>
        public int? ErrorCode { get; set; }
        /// <summary>Error description corresponding to erroneous execution of the device management script.</summary>
        public string ErrorDescription { get; set; }
        /// <summary>Latest time the device management script executes.</summary>
        public DateTimeOffset? LastStateUpdateDateTime { get; set; }
        /// <summary>The managed devices that executes the device management script.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedDevice ManagedDevice { get; set; }
        /// <summary>Details of execution output.</summary>
        public string ResultMessage { get; set; }
        /// <summary>State of latest run of the device management script. Possible values are: unknown, success, fail, scriptError, pending, notApplicable.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.RunState? RunState { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementScriptDeviceState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementScriptDeviceState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"errorCode", (o,n) => { (o as DeviceManagementScriptDeviceState).ErrorCode = n.GetIntValue(); } },
                {"errorDescription", (o,n) => { (o as DeviceManagementScriptDeviceState).ErrorDescription = n.GetStringValue(); } },
                {"lastStateUpdateDateTime", (o,n) => { (o as DeviceManagementScriptDeviceState).LastStateUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                {"managedDevice", (o,n) => { (o as DeviceManagementScriptDeviceState).ManagedDevice = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedDevice>(MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedDevice.CreateFromDiscriminatorValue); } },
                {"resultMessage", (o,n) => { (o as DeviceManagementScriptDeviceState).ResultMessage = n.GetStringValue(); } },
                {"runState", (o,n) => { (o as DeviceManagementScriptDeviceState).RunState = n.GetEnumValue<RunState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("errorCode", ErrorCode);
            writer.WriteStringValue("errorDescription", ErrorDescription);
            writer.WriteDateTimeOffsetValue("lastStateUpdateDateTime", LastStateUpdateDateTime);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedDevice>("managedDevice", ManagedDevice);
            writer.WriteStringValue("resultMessage", ResultMessage);
            writer.WriteEnumValue<RunState>("runState", RunState);
        }
    }
}
