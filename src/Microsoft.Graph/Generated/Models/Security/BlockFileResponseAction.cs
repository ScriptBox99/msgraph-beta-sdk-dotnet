using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class BlockFileResponseAction : ResponseAction, IParsable {
        /// <summary>The deviceGroupNames property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DeviceGroupNames {
            get { return BackingStore?.Get<List<string>?>("deviceGroupNames"); }
            set { BackingStore?.Set("deviceGroupNames", value); }
        }
#nullable restore
#else
        public List<string> DeviceGroupNames {
            get { return BackingStore?.Get<List<string>>("deviceGroupNames"); }
            set { BackingStore?.Set("deviceGroupNames", value); }
        }
#endif
        /// <summary>The identifier property</summary>
        public FileEntityIdentifier? Identifier {
            get { return BackingStore?.Get<FileEntityIdentifier?>("identifier"); }
            set { BackingStore?.Set("identifier", value); }
        }
        /// <summary>
        /// Instantiates a new blockFileResponseAction and sets the default values.
        /// </summary>
        public BlockFileResponseAction() : base() {
            OdataType = "#microsoft.graph.security.blockFileResponseAction";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new BlockFileResponseAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BlockFileResponseAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deviceGroupNames", n => { DeviceGroupNames = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"identifier", n => { Identifier = n.GetEnumValue<FileEntityIdentifier>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("deviceGroupNames", DeviceGroupNames);
            writer.WriteEnumValue<FileEntityIdentifier>("identifier", Identifier);
        }
    }
}
