using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The type for deployment of groups or apps.</summary>
    public class TargetedManagedAppPolicyAssignment : Entity, IParsable {
        /// <summary>Represents source of assignment.</summary>
        public DeviceAndAppManagementAssignmentSource? Source {
            get { return BackingStore?.Get<DeviceAndAppManagementAssignmentSource?>("source"); }
            set { BackingStore?.Set("source", value); }
        }
        /// <summary>Identifier for resource used for deployment to a group</summary>
        public string SourceId {
            get { return BackingStore?.Get<string>("sourceId"); }
            set { BackingStore?.Set("sourceId", value); }
        }
        /// <summary>Identifier for deployment to a group or app</summary>
        public DeviceAndAppManagementAssignmentTarget Target {
            get { return BackingStore?.Get<DeviceAndAppManagementAssignmentTarget>("target"); }
            set { BackingStore?.Set("target", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TargetedManagedAppPolicyAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TargetedManagedAppPolicyAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"source", n => { Source = n.GetEnumValue<DeviceAndAppManagementAssignmentSource>(); } },
                {"sourceId", n => { SourceId = n.GetStringValue(); } },
                {"target", n => { Target = n.GetObjectValue<DeviceAndAppManagementAssignmentTarget>(DeviceAndAppManagementAssignmentTarget.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<DeviceAndAppManagementAssignmentSource>("source", Source);
            writer.WriteStringValue("sourceId", SourceId);
            writer.WriteObjectValue<DeviceAndAppManagementAssignmentTarget>("target", Target);
        }
    }
}
