using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Entity that represents device state for an intent
    /// </summary>
    public class DeviceManagementIntentDeviceState : Entity, IParsable {
        /// <summary>Device name that is being reported</summary>
        public string DeviceDisplayName {
            get { return BackingStore?.Get<string>("deviceDisplayName"); }
            set { BackingStore?.Set("deviceDisplayName", value); }
        }
        /// <summary>Device id that is being reported</summary>
        public string DeviceId {
            get { return BackingStore?.Get<string>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
        /// <summary>Last modified date time of an intent report</summary>
        public DateTimeOffset? LastReportedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastReportedDateTime"); }
            set { BackingStore?.Set("lastReportedDateTime", value); }
        }
        /// <summary>The state property</summary>
        public ComplianceStatus? State {
            get { return BackingStore?.Get<ComplianceStatus?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>The user name that is being reported on a device</summary>
        public string UserName {
            get { return BackingStore?.Get<string>("userName"); }
            set { BackingStore?.Set("userName", value); }
        }
        /// <summary>The user principal name that is being reported on a device</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementIntentDeviceState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementIntentDeviceState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deviceDisplayName", n => { DeviceDisplayName = n.GetStringValue(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"lastReportedDateTime", n => { LastReportedDateTime = n.GetDateTimeOffsetValue(); } },
                {"state", n => { State = n.GetEnumValue<ComplianceStatus>(); } },
                {"userName", n => { UserName = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("deviceDisplayName", DeviceDisplayName);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteDateTimeOffsetValue("lastReportedDateTime", LastReportedDateTime);
            writer.WriteEnumValue<ComplianceStatus>("state", State);
            writer.WriteStringValue("userName", UserName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
