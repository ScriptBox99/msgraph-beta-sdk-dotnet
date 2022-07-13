using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceHealthScriptRunSummary : Entity, IParsable {
        /// <summary>Number of devices on which the detection script execution encountered an error and did not complete</summary>
        public int? DetectionScriptErrorDeviceCount {
            get { return BackingStore?.Get<int?>("detectionScriptErrorDeviceCount"); }
            set { BackingStore?.Set("detectionScriptErrorDeviceCount", value); }
        }
        /// <summary>Number of devices for which the detection script was not applicable</summary>
        public int? DetectionScriptNotApplicableDeviceCount {
            get { return BackingStore?.Get<int?>("detectionScriptNotApplicableDeviceCount"); }
            set { BackingStore?.Set("detectionScriptNotApplicableDeviceCount", value); }
        }
        /// <summary>Number of devices which have not yet run the latest version of the device health script</summary>
        public int? DetectionScriptPendingDeviceCount {
            get { return BackingStore?.Get<int?>("detectionScriptPendingDeviceCount"); }
            set { BackingStore?.Set("detectionScriptPendingDeviceCount", value); }
        }
        /// <summary>Number of devices for which the detection script found an issue</summary>
        public int? IssueDetectedDeviceCount {
            get { return BackingStore?.Get<int?>("issueDetectedDeviceCount"); }
            set { BackingStore?.Set("issueDetectedDeviceCount", value); }
        }
        /// <summary>Number of devices that were remediated over the last 30 days</summary>
        public int? IssueRemediatedCumulativeDeviceCount {
            get { return BackingStore?.Get<int?>("issueRemediatedCumulativeDeviceCount"); }
            set { BackingStore?.Set("issueRemediatedCumulativeDeviceCount", value); }
        }
        /// <summary>Number of devices for which the remediation script was able to resolve the detected issue</summary>
        public int? IssueRemediatedDeviceCount {
            get { return BackingStore?.Get<int?>("issueRemediatedDeviceCount"); }
            set { BackingStore?.Set("issueRemediatedDeviceCount", value); }
        }
        /// <summary>Number of devices for which the remediation script executed successfully but failed to resolve the detected issue</summary>
        public int? IssueReoccurredDeviceCount {
            get { return BackingStore?.Get<int?>("issueReoccurredDeviceCount"); }
            set { BackingStore?.Set("issueReoccurredDeviceCount", value); }
        }
        /// <summary>Last run time for the script across all devices</summary>
        public DateTimeOffset? LastScriptRunDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastScriptRunDateTime"); }
            set { BackingStore?.Set("lastScriptRunDateTime", value); }
        }
        /// <summary>Number of devices for which the detection script did not find an issue and the device is healthy</summary>
        public int? NoIssueDetectedDeviceCount {
            get { return BackingStore?.Get<int?>("noIssueDetectedDeviceCount"); }
            set { BackingStore?.Set("noIssueDetectedDeviceCount", value); }
        }
        /// <summary>Number of devices for which the remediation script execution encountered an error and did not complete</summary>
        public int? RemediationScriptErrorDeviceCount {
            get { return BackingStore?.Get<int?>("remediationScriptErrorDeviceCount"); }
            set { BackingStore?.Set("remediationScriptErrorDeviceCount", value); }
        }
        /// <summary>Number of devices for which remediation was skipped</summary>
        public int? RemediationSkippedDeviceCount {
            get { return BackingStore?.Get<int?>("remediationSkippedDeviceCount"); }
            set { BackingStore?.Set("remediationSkippedDeviceCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceHealthScriptRunSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceHealthScriptRunSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"detectionScriptErrorDeviceCount", n => { DetectionScriptErrorDeviceCount = n.GetIntValue(); } },
                {"detectionScriptNotApplicableDeviceCount", n => { DetectionScriptNotApplicableDeviceCount = n.GetIntValue(); } },
                {"detectionScriptPendingDeviceCount", n => { DetectionScriptPendingDeviceCount = n.GetIntValue(); } },
                {"issueDetectedDeviceCount", n => { IssueDetectedDeviceCount = n.GetIntValue(); } },
                {"issueRemediatedCumulativeDeviceCount", n => { IssueRemediatedCumulativeDeviceCount = n.GetIntValue(); } },
                {"issueRemediatedDeviceCount", n => { IssueRemediatedDeviceCount = n.GetIntValue(); } },
                {"issueReoccurredDeviceCount", n => { IssueReoccurredDeviceCount = n.GetIntValue(); } },
                {"lastScriptRunDateTime", n => { LastScriptRunDateTime = n.GetDateTimeOffsetValue(); } },
                {"noIssueDetectedDeviceCount", n => { NoIssueDetectedDeviceCount = n.GetIntValue(); } },
                {"remediationScriptErrorDeviceCount", n => { RemediationScriptErrorDeviceCount = n.GetIntValue(); } },
                {"remediationSkippedDeviceCount", n => { RemediationSkippedDeviceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("detectionScriptErrorDeviceCount", DetectionScriptErrorDeviceCount);
            writer.WriteIntValue("detectionScriptNotApplicableDeviceCount", DetectionScriptNotApplicableDeviceCount);
            writer.WriteIntValue("detectionScriptPendingDeviceCount", DetectionScriptPendingDeviceCount);
            writer.WriteIntValue("issueDetectedDeviceCount", IssueDetectedDeviceCount);
            writer.WriteIntValue("issueRemediatedCumulativeDeviceCount", IssueRemediatedCumulativeDeviceCount);
            writer.WriteIntValue("issueRemediatedDeviceCount", IssueRemediatedDeviceCount);
            writer.WriteIntValue("issueReoccurredDeviceCount", IssueReoccurredDeviceCount);
            writer.WriteDateTimeOffsetValue("lastScriptRunDateTime", LastScriptRunDateTime);
            writer.WriteIntValue("noIssueDetectedDeviceCount", NoIssueDetectedDeviceCount);
            writer.WriteIntValue("remediationScriptErrorDeviceCount", RemediationScriptErrorDeviceCount);
            writer.WriteIntValue("remediationSkippedDeviceCount", RemediationSkippedDeviceCount);
        }
    }
}
