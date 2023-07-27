using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class StandardWebPart : WebPart, IParsable {
        /// <summary>The instance identifier of the container text webPart. It only works for inline standard webPart in rich text webParts.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContainerTextWebPartId {
            get { return BackingStore?.Get<string?>("containerTextWebPartId"); }
            set { BackingStore?.Set("containerTextWebPartId", value); }
        }
#nullable restore
#else
        public string ContainerTextWebPartId {
            get { return BackingStore?.Get<string>("containerTextWebPartId"); }
            set { BackingStore?.Set("containerTextWebPartId", value); }
        }
#endif
        /// <summary>Data of the webPart.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WebPartData? Data {
            get { return BackingStore?.Get<WebPartData?>("data"); }
            set { BackingStore?.Set("data", value); }
        }
#nullable restore
#else
        public WebPartData Data {
            get { return BackingStore?.Get<WebPartData>("data"); }
            set { BackingStore?.Set("data", value); }
        }
#endif
        /// <summary>A Guid that indicates the webPart type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebPartType {
            get { return BackingStore?.Get<string?>("webPartType"); }
            set { BackingStore?.Set("webPartType", value); }
        }
#nullable restore
#else
        public string WebPartType {
            get { return BackingStore?.Get<string>("webPartType"); }
            set { BackingStore?.Set("webPartType", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new standardWebPart and sets the default values.
        /// </summary>
        public StandardWebPart() : base() {
            OdataType = "#microsoft.graph.standardWebPart";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new StandardWebPart CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new StandardWebPart();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"containerTextWebPartId", n => { ContainerTextWebPartId = n.GetStringValue(); } },
                {"data", n => { Data = n.GetObjectValue<WebPartData>(WebPartData.CreateFromDiscriminatorValue); } },
                {"webPartType", n => { WebPartType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("containerTextWebPartId", ContainerTextWebPartId);
            writer.WriteObjectValue<WebPartData>("data", Data);
            writer.WriteStringValue("webPartType", WebPartType);
        }
    }
}
