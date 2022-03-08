using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceAppManagement singleton.</summary>
    public class WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary : Entity, IParsable {
        /// <summary>Number of Devices that have successfully deployed this WindowsDefenderApplicationControl supplemental policy.</summary>
        public int? DeployedDeviceCount { get; set; }
        /// <summary>Number of Devices that have failed to deploy this WindowsDefenderApplicationControl supplemental policy.</summary>
        public int? FailedDeviceCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"deployedDeviceCount", (o,n) => { (o as WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary).DeployedDeviceCount = n.GetIntValue(); } },
                {"failedDeviceCount", (o,n) => { (o as WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary).FailedDeviceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("deployedDeviceCount", DeployedDeviceCount);
            writer.WriteIntValue("failedDeviceCount", FailedDeviceCount);
        }
    }
}
