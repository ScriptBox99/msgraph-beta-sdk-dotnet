using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The user experience analytics work from anywhere model performance.
    /// </summary>
    public class UserExperienceAnalyticsWorkFromAnywhereModelPerformance : Entity, IParsable {
        /// <summary>The user experience work from anywhere&apos;s cloud identity score for the model. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? CloudIdentityScore {
            get { return BackingStore?.Get<double?>("cloudIdentityScore"); }
            set { BackingStore?.Set("cloudIdentityScore", value); }
        }
        /// <summary>The user experience work from anywhere&apos;s cloud management score for the model. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? CloudManagementScore {
            get { return BackingStore?.Get<double?>("cloudManagementScore"); }
            set { BackingStore?.Set("cloudManagementScore", value); }
        }
        /// <summary>The user experience work from anywhere&apos;s cloud provisioning score for the model. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? CloudProvisioningScore {
            get { return BackingStore?.Get<double?>("cloudProvisioningScore"); }
            set { BackingStore?.Set("cloudProvisioningScore", value); }
        }
        /// <summary>The healthStatus property</summary>
        public UserExperienceAnalyticsHealthState? HealthStatus {
            get { return BackingStore?.Get<UserExperienceAnalyticsHealthState?>("healthStatus"); }
            set { BackingStore?.Set("healthStatus", value); }
        }
        /// <summary>The user experience work from anywhere&apos;s manufacturer name of the devices.</summary>
        public string Manufacturer {
            get { return BackingStore?.Get<string>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
        /// <summary>The user experience work from anywhere&apos;s model name of the devices.</summary>
        public string Model {
            get { return BackingStore?.Get<string>("model"); }
            set { BackingStore?.Set("model", value); }
        }
        /// <summary>The user experience work from anywhere&apos;s devices count for the model. Valid values -2147483648 to 2147483647</summary>
        public int? ModelDeviceCount {
            get { return BackingStore?.Get<int?>("modelDeviceCount"); }
            set { BackingStore?.Set("modelDeviceCount", value); }
        }
        /// <summary>The user experience work from anywhere windows score for the model. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? WindowsScore {
            get { return BackingStore?.Get<double?>("windowsScore"); }
            set { BackingStore?.Set("windowsScore", value); }
        }
        /// <summary>The user experience work from anywhere overall score for the model. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? WorkFromAnywhereScore {
            get { return BackingStore?.Get<double?>("workFromAnywhereScore"); }
            set { BackingStore?.Set("workFromAnywhereScore", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserExperienceAnalyticsWorkFromAnywhereModelPerformance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsWorkFromAnywhereModelPerformance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"cloudIdentityScore", n => { CloudIdentityScore = n.GetDoubleValue(); } },
                {"cloudManagementScore", n => { CloudManagementScore = n.GetDoubleValue(); } },
                {"cloudProvisioningScore", n => { CloudProvisioningScore = n.GetDoubleValue(); } },
                {"healthStatus", n => { HealthStatus = n.GetEnumValue<UserExperienceAnalyticsHealthState>(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"modelDeviceCount", n => { ModelDeviceCount = n.GetIntValue(); } },
                {"windowsScore", n => { WindowsScore = n.GetDoubleValue(); } },
                {"workFromAnywhereScore", n => { WorkFromAnywhereScore = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDoubleValue("cloudIdentityScore", CloudIdentityScore);
            writer.WriteDoubleValue("cloudManagementScore", CloudManagementScore);
            writer.WriteDoubleValue("cloudProvisioningScore", CloudProvisioningScore);
            writer.WriteEnumValue<UserExperienceAnalyticsHealthState>("healthStatus", HealthStatus);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteIntValue("modelDeviceCount", ModelDeviceCount);
            writer.WriteDoubleValue("windowsScore", WindowsScore);
            writer.WriteDoubleValue("workFromAnywhereScore", WorkFromAnywhereScore);
        }
    }
}
