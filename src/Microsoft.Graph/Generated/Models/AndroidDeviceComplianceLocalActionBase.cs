using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidDeviceComplianceLocalActionBase : Entity, IParsable {
        /// <summary>Number of minutes to wait till a local action is enforced. Valid values 0 to 2147483647</summary>
        public int? GracePeriodInMinutes {
            get { return BackingStore?.Get<int?>("gracePeriodInMinutes"); }
            set { BackingStore?.Set("gracePeriodInMinutes", value); }
        }
        /// <summary>
        /// Instantiates a new AndroidDeviceComplianceLocalActionBase and sets the default values.
        /// </summary>
        public AndroidDeviceComplianceLocalActionBase() : base() {
            Type = "#microsoft.graph.androidDeviceComplianceLocalActionBase";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AndroidDeviceComplianceLocalActionBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.androidDeviceComplianceLocalActionLockDevice" => new AndroidDeviceComplianceLocalActionLockDevice(),
                "#microsoft.graph.androidDeviceComplianceLocalActionLockDeviceWithPasscode" => new AndroidDeviceComplianceLocalActionLockDeviceWithPasscode(),
                _ => new AndroidDeviceComplianceLocalActionBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"gracePeriodInMinutes", n => { GracePeriodInMinutes = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("gracePeriodInMinutes", GracePeriodInMinutes);
        }
    }
}
