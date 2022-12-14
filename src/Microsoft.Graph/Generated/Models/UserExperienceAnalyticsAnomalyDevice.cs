using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The user experience analytics anomaly entity contains device details.
    /// </summary>
    public class UserExperienceAnalyticsAnomalyDevice : Entity, IParsable {
        /// <summary>The unique identifier of the anomaly.</summary>
        public string AnomalyId {
            get { return BackingStore?.Get<string>("anomalyId"); }
            set { BackingStore?.Set("anomalyId", value); }
        }
        /// <summary>Indicates the first occurance date and time for the anomaly on the device.</summary>
        public DateTimeOffset? AnomalyOnDeviceFirstOccurrenceDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("anomalyOnDeviceFirstOccurrenceDateTime"); }
            set { BackingStore?.Set("anomalyOnDeviceFirstOccurrenceDateTime", value); }
        }
        /// <summary>Indicates the latest occurance date and time for the anomaly on the device.</summary>
        public DateTimeOffset? AnomalyOnDeviceLatestOccurrenceDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("anomalyOnDeviceLatestOccurrenceDateTime"); }
            set { BackingStore?.Set("anomalyOnDeviceLatestOccurrenceDateTime", value); }
        }
        /// <summary>The unique identifier of the device.</summary>
        public string DeviceId {
            get { return BackingStore?.Get<string>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
        /// <summary>The manufacturer name of the device.</summary>
        public string DeviceManufacturer {
            get { return BackingStore?.Get<string>("deviceManufacturer"); }
            set { BackingStore?.Set("deviceManufacturer", value); }
        }
        /// <summary>The model name of the device.</summary>
        public string DeviceModel {
            get { return BackingStore?.Get<string>("deviceModel"); }
            set { BackingStore?.Set("deviceModel", value); }
        }
        /// <summary>The name of the device.</summary>
        public string DeviceName {
            get { return BackingStore?.Get<string>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
        /// <summary>The name of the OS installed on the device.</summary>
        public string OsName {
            get { return BackingStore?.Get<string>("osName"); }
            set { BackingStore?.Set("osName", value); }
        }
        /// <summary>The OS version installed on the device.</summary>
        public string OsVersion {
            get { return BackingStore?.Get<string>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserExperienceAnalyticsAnomalyDevice CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsAnomalyDevice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"anomalyId", n => { AnomalyId = n.GetStringValue(); } },
                {"anomalyOnDeviceFirstOccurrenceDateTime", n => { AnomalyOnDeviceFirstOccurrenceDateTime = n.GetDateTimeOffsetValue(); } },
                {"anomalyOnDeviceLatestOccurrenceDateTime", n => { AnomalyOnDeviceLatestOccurrenceDateTime = n.GetDateTimeOffsetValue(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"deviceManufacturer", n => { DeviceManufacturer = n.GetStringValue(); } },
                {"deviceModel", n => { DeviceModel = n.GetStringValue(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"osName", n => { OsName = n.GetStringValue(); } },
                {"osVersion", n => { OsVersion = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("anomalyId", AnomalyId);
            writer.WriteDateTimeOffsetValue("anomalyOnDeviceFirstOccurrenceDateTime", AnomalyOnDeviceFirstOccurrenceDateTime);
            writer.WriteDateTimeOffsetValue("anomalyOnDeviceLatestOccurrenceDateTime", AnomalyOnDeviceLatestOccurrenceDateTime);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceManufacturer", DeviceManufacturer);
            writer.WriteStringValue("deviceModel", DeviceModel);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("osName", OsName);
            writer.WriteStringValue("osVersion", OsVersion);
        }
    }
}
