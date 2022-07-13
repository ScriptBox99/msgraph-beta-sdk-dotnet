using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsManagementAppHealthSummary : Entity, IParsable {
        /// <summary>Healthy device count.</summary>
        public int? HealthyDeviceCount {
            get { return BackingStore?.Get<int?>("healthyDeviceCount"); }
            set { BackingStore?.Set("healthyDeviceCount", value); }
        }
        /// <summary>Unhealthy device count.</summary>
        public int? UnhealthyDeviceCount {
            get { return BackingStore?.Get<int?>("unhealthyDeviceCount"); }
            set { BackingStore?.Set("unhealthyDeviceCount", value); }
        }
        /// <summary>Unknown device count.</summary>
        public int? UnknownDeviceCount {
            get { return BackingStore?.Get<int?>("unknownDeviceCount"); }
            set { BackingStore?.Set("unknownDeviceCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsManagementAppHealthSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsManagementAppHealthSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"healthyDeviceCount", n => { HealthyDeviceCount = n.GetIntValue(); } },
                {"unhealthyDeviceCount", n => { UnhealthyDeviceCount = n.GetIntValue(); } },
                {"unknownDeviceCount", n => { UnknownDeviceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("healthyDeviceCount", HealthyDeviceCount);
            writer.WriteIntValue("unhealthyDeviceCount", UnhealthyDeviceCount);
            writer.WriteIntValue("unknownDeviceCount", UnknownDeviceCount);
        }
    }
}
