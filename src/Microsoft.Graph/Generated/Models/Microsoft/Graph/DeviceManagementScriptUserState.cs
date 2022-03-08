using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class DeviceManagementScriptUserState : Entity, IParsable {
        /// <summary>List of run states for this script across all devices of specific user.</summary>
        public List<DeviceManagementScriptDeviceState> DeviceRunStates { get; set; }
        /// <summary>Error device count for specific user.</summary>
        public int? ErrorDeviceCount { get; set; }
        /// <summary>Success device count for specific user.</summary>
        public int? SuccessDeviceCount { get; set; }
        /// <summary>User principle name of specific user.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementScriptUserState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementScriptUserState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"deviceRunStates", (o,n) => { (o as DeviceManagementScriptUserState).DeviceRunStates = n.GetCollectionOfObjectValues<DeviceManagementScriptDeviceState>(DeviceManagementScriptDeviceState.CreateFromDiscriminatorValue).ToList(); } },
                {"errorDeviceCount", (o,n) => { (o as DeviceManagementScriptUserState).ErrorDeviceCount = n.GetIntValue(); } },
                {"successDeviceCount", (o,n) => { (o as DeviceManagementScriptUserState).SuccessDeviceCount = n.GetIntValue(); } },
                {"userPrincipalName", (o,n) => { (o as DeviceManagementScriptUserState).UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeviceManagementScriptDeviceState>("deviceRunStates", DeviceRunStates);
            writer.WriteIntValue("errorDeviceCount", ErrorDeviceCount);
            writer.WriteIntValue("successDeviceCount", SuccessDeviceCount);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
