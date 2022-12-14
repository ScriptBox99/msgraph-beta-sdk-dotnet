using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Entity that represents device setting state summary for an intent
    /// </summary>
    public class DeviceManagementIntentDeviceSettingStateSummary : Entity, IParsable {
        /// <summary>Number of compliant devices</summary>
        public int? CompliantCount {
            get { return BackingStore?.Get<int?>("compliantCount"); }
            set { BackingStore?.Set("compliantCount", value); }
        }
        /// <summary>Number of devices in conflict</summary>
        public int? ConflictCount {
            get { return BackingStore?.Get<int?>("conflictCount"); }
            set { BackingStore?.Set("conflictCount", value); }
        }
        /// <summary>Number of error devices</summary>
        public int? ErrorCount {
            get { return BackingStore?.Get<int?>("errorCount"); }
            set { BackingStore?.Set("errorCount", value); }
        }
        /// <summary>Number of non compliant devices</summary>
        public int? NonCompliantCount {
            get { return BackingStore?.Get<int?>("nonCompliantCount"); }
            set { BackingStore?.Set("nonCompliantCount", value); }
        }
        /// <summary>Number of not applicable devices</summary>
        public int? NotApplicableCount {
            get { return BackingStore?.Get<int?>("notApplicableCount"); }
            set { BackingStore?.Set("notApplicableCount", value); }
        }
        /// <summary>Number of remediated devices</summary>
        public int? RemediatedCount {
            get { return BackingStore?.Get<int?>("remediatedCount"); }
            set { BackingStore?.Set("remediatedCount", value); }
        }
        /// <summary>Name of a setting</summary>
        public string SettingName {
            get { return BackingStore?.Get<string>("settingName"); }
            set { BackingStore?.Set("settingName", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementIntentDeviceSettingStateSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementIntentDeviceSettingStateSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"compliantCount", n => { CompliantCount = n.GetIntValue(); } },
                {"conflictCount", n => { ConflictCount = n.GetIntValue(); } },
                {"errorCount", n => { ErrorCount = n.GetIntValue(); } },
                {"nonCompliantCount", n => { NonCompliantCount = n.GetIntValue(); } },
                {"notApplicableCount", n => { NotApplicableCount = n.GetIntValue(); } },
                {"remediatedCount", n => { RemediatedCount = n.GetIntValue(); } },
                {"settingName", n => { SettingName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("compliantCount", CompliantCount);
            writer.WriteIntValue("conflictCount", ConflictCount);
            writer.WriteIntValue("errorCount", ErrorCount);
            writer.WriteIntValue("nonCompliantCount", NonCompliantCount);
            writer.WriteIntValue("notApplicableCount", NotApplicableCount);
            writer.WriteIntValue("remediatedCount", RemediatedCount);
            writer.WriteStringValue("settingName", SettingName);
        }
    }
}
