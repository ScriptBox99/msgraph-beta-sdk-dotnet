using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class ExternalIdentitiesPolicy : PolicyBase, IParsable {
        /// <summary>Reserved for future use.</summary>
        public bool? AllowDeletedIdentitiesDataRemoval {
            get { return BackingStore?.Get<bool?>("allowDeletedIdentitiesDataRemoval"); }
            set { BackingStore?.Set("allowDeletedIdentitiesDataRemoval", value); }
        }
        /// <summary>Defines whether external users can leave the guest tenant. If set to false, self-service controls are disabled, and the admin of the guest tenant must manually remove the external user from the guest tenant. When the external user leaves the tenant, their data in the guest tenant is first soft-deleted then permanently deleted in 30 days.</summary>
        public bool? AllowExternalIdentitiesToLeave {
            get { return BackingStore?.Get<bool?>("allowExternalIdentitiesToLeave"); }
            set { BackingStore?.Set("allowExternalIdentitiesToLeave", value); }
        }
        /// <summary>
        /// Instantiates a new externalIdentitiesPolicy and sets the default values.
        /// </summary>
        public ExternalIdentitiesPolicy() : base() {
            OdataType = "#microsoft.graph.externalIdentitiesPolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ExternalIdentitiesPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExternalIdentitiesPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowDeletedIdentitiesDataRemoval", n => { AllowDeletedIdentitiesDataRemoval = n.GetBoolValue(); } },
                {"allowExternalIdentitiesToLeave", n => { AllowExternalIdentitiesToLeave = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowDeletedIdentitiesDataRemoval", AllowDeletedIdentitiesDataRemoval);
            writer.WriteBoolValue("allowExternalIdentitiesToLeave", AllowExternalIdentitiesToLeave);
        }
    }
}
