using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Contains properties for the run summary of a device management script.
    /// </summary>
    public class DeviceComplianceScriptRunSummary : Entity, IParsable {
        /// <summary>Number of devices on which the detection script execution encountered an error and did not complete. Valid values -2147483648 to 2147483647</summary>
        public int? DetectionScriptErrorDeviceCount {
            get { return BackingStore?.Get<int?>("detectionScriptErrorDeviceCount"); }
            set { BackingStore?.Set("detectionScriptErrorDeviceCount", value); }
        }
        /// <summary>Number of devices which have not yet run the latest version of the device compliance script. Valid values -2147483648 to 2147483647</summary>
        public int? DetectionScriptPendingDeviceCount {
            get { return BackingStore?.Get<int?>("detectionScriptPendingDeviceCount"); }
            set { BackingStore?.Set("detectionScriptPendingDeviceCount", value); }
        }
        /// <summary>Number of devices for which the detection script found an issue. Valid values -2147483648 to 2147483647</summary>
        public int? IssueDetectedDeviceCount {
            get { return BackingStore?.Get<int?>("issueDetectedDeviceCount"); }
            set { BackingStore?.Set("issueDetectedDeviceCount", value); }
        }
        /// <summary>Last run time for the script across all devices</summary>
        public DateTimeOffset? LastScriptRunDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastScriptRunDateTime"); }
            set { BackingStore?.Set("lastScriptRunDateTime", value); }
        }
        /// <summary>Number of devices for which the detection script did not find an issue and the device is healthy. Valid values -2147483648 to 2147483647</summary>
        public int? NoIssueDetectedDeviceCount {
            get { return BackingStore?.Get<int?>("noIssueDetectedDeviceCount"); }
            set { BackingStore?.Set("noIssueDetectedDeviceCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceComplianceScriptRunSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceComplianceScriptRunSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"detectionScriptErrorDeviceCount", n => { DetectionScriptErrorDeviceCount = n.GetIntValue(); } },
                {"detectionScriptPendingDeviceCount", n => { DetectionScriptPendingDeviceCount = n.GetIntValue(); } },
                {"issueDetectedDeviceCount", n => { IssueDetectedDeviceCount = n.GetIntValue(); } },
                {"lastScriptRunDateTime", n => { LastScriptRunDateTime = n.GetDateTimeOffsetValue(); } },
                {"noIssueDetectedDeviceCount", n => { NoIssueDetectedDeviceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("detectionScriptErrorDeviceCount", DetectionScriptErrorDeviceCount);
            writer.WriteIntValue("detectionScriptPendingDeviceCount", DetectionScriptPendingDeviceCount);
            writer.WriteIntValue("issueDetectedDeviceCount", IssueDetectedDeviceCount);
            writer.WriteDateTimeOffsetValue("lastScriptRunDateTime", LastScriptRunDateTime);
            writer.WriteIntValue("noIssueDetectedDeviceCount", NoIssueDetectedDeviceCount);
        }
    }
}
