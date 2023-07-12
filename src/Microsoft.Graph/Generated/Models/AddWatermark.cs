using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class AddWatermark : MarkContent, IParsable {
        /// <summary>The orientation property</summary>
        public PageOrientation? Orientation {
            get { return BackingStore?.Get<PageOrientation?>("orientation"); }
            set { BackingStore?.Set("orientation", value); }
        }
        /// <summary>
        /// Instantiates a new addWatermark and sets the default values.
        /// </summary>
        public AddWatermark() : base() {
            OdataType = "#microsoft.graph.addWatermark";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AddWatermark CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AddWatermark();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"orientation", n => { Orientation = n.GetEnumValue<PageOrientation>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<PageOrientation>("orientation", Orientation);
        }
    }
}
