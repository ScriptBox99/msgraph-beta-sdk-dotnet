// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class OnAttributeCollectionListener : AuthenticationEventListener, IParsable {
        /// <summary>Required. Configuration for what to invoke if the event resolves to this listener.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OnAttributeCollectionHandler? Handler {
            get { return BackingStore?.Get<OnAttributeCollectionHandler?>("handler"); }
            set { BackingStore?.Set("handler", value); }
        }
#nullable restore
#else
        public OnAttributeCollectionHandler Handler {
            get { return BackingStore?.Get<OnAttributeCollectionHandler>("handler"); }
            set { BackingStore?.Set("handler", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new onAttributeCollectionListener and sets the default values.
        /// </summary>
        public OnAttributeCollectionListener() : base() {
            OdataType = "#microsoft.graph.onAttributeCollectionListener";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new OnAttributeCollectionListener CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnAttributeCollectionListener();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"handler", n => { Handler = n.GetObjectValue<OnAttributeCollectionHandler>(OnAttributeCollectionHandler.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<OnAttributeCollectionHandler>("handler", Handler);
        }
    }
}
