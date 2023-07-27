using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class ImpactedUserAsset : ImpactedAsset, IParsable {
        /// <summary>The identifier property</summary>
        public UserAssetIdentifier? Identifier {
            get { return BackingStore?.Get<UserAssetIdentifier?>("identifier"); }
            set { BackingStore?.Set("identifier", value); }
        }
        /// <summary>
        /// Instantiates a new impactedUserAsset and sets the default values.
        /// </summary>
        public ImpactedUserAsset() : base() {
            OdataType = "#microsoft.graph.security.impactedUserAsset";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ImpactedUserAsset CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ImpactedUserAsset();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"identifier", n => { Identifier = n.GetEnumValue<UserAssetIdentifier>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<UserAssetIdentifier>("identifier", Identifier);
        }
    }
}
