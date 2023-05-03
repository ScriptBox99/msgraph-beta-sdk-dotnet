using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class CustomAppScope : AppScope, IParsable {
        /// <summary>The customAttributes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomAppScopeAttributesDictionary? CustomAttributes {
            get { return BackingStore?.Get<CustomAppScopeAttributesDictionary?>("customAttributes"); }
            set { BackingStore?.Set("customAttributes", value); }
        }
#nullable restore
#else
        public CustomAppScopeAttributesDictionary CustomAttributes {
            get { return BackingStore?.Get<CustomAppScopeAttributesDictionary>("customAttributes"); }
            set { BackingStore?.Set("customAttributes", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new CustomAppScope and sets the default values.
        /// </summary>
        public CustomAppScope() : base() {
            OdataType = "#microsoft.graph.customAppScope";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CustomAppScope CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CustomAppScope();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"customAttributes", n => { CustomAttributes = n.GetObjectValue<CustomAppScopeAttributesDictionary>(CustomAppScopeAttributesDictionary.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<CustomAppScopeAttributesDictionary>("customAttributes", CustomAttributes);
        }
    }
}
