using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class Picture : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The content property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Content {
            get { return BackingStore?.Get<byte[]?>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#nullable restore
#else
        public byte[] Content {
            get { return BackingStore?.Get<byte[]>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#endif
        /// <summary>The contentType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentType {
            get { return BackingStore?.Get<string?>("contentType"); }
            set { BackingStore?.Set("contentType", value); }
        }
#nullable restore
#else
        public string ContentType {
            get { return BackingStore?.Get<string>("contentType"); }
            set { BackingStore?.Set("contentType", value); }
        }
#endif
        /// <summary>The height property</summary>
        public int? Height {
            get { return BackingStore?.Get<int?>("height"); }
            set { BackingStore?.Set("height", value); }
        }
        /// <summary>The id property</summary>
        public Guid? Id {
            get { return BackingStore?.Get<Guid?>("id"); }
            set { BackingStore?.Set("id", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The width property</summary>
        public int? Width {
            get { return BackingStore?.Get<int?>("width"); }
            set { BackingStore?.Set("width", value); }
        }
        /// <summary>
        /// Instantiates a new picture and sets the default values.
        /// </summary>
        public Picture() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Picture CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Picture();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"content", n => { Content = n.GetByteArrayValue(); } },
                {"contentType", n => { ContentType = n.GetStringValue(); } },
                {"height", n => { Height = n.GetIntValue(); } },
                {"id", n => { Id = n.GetGuidValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"width", n => { Width = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteByteArrayValue("content", Content);
            writer.WriteStringValue("contentType", ContentType);
            writer.WriteIntValue("height", Height);
            writer.WriteGuidValue("id", Id);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("width", Width);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
