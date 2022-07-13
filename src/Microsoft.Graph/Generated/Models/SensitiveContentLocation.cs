using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SensitiveContentLocation : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The confidence property</summary>
        public int? Confidence {
            get { return BackingStore?.Get<int?>("confidence"); }
            set { BackingStore?.Set("confidence", value); }
        }
        /// <summary>The evidences property</summary>
        public List<SensitiveContentEvidence> Evidences {
            get { return BackingStore?.Get<List<SensitiveContentEvidence>>("evidences"); }
            set { BackingStore?.Set("evidences", value); }
        }
        /// <summary>The idMatch property</summary>
        public string IdMatch {
            get { return BackingStore?.Get<string>("idMatch"); }
            set { BackingStore?.Set("idMatch", value); }
        }
        /// <summary>The length property</summary>
        public int? Length {
            get { return BackingStore?.Get<int?>("length"); }
            set { BackingStore?.Set("length", value); }
        }
        /// <summary>The offset property</summary>
        public int? Offset {
            get { return BackingStore?.Get<int?>("offset"); }
            set { BackingStore?.Set("offset", value); }
        }
        /// <summary>
        /// Instantiates a new sensitiveContentLocation and sets the default values.
        /// </summary>
        public SensitiveContentLocation() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SensitiveContentLocation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SensitiveContentLocation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"confidence", n => { Confidence = n.GetIntValue(); } },
                {"evidences", n => { Evidences = n.GetCollectionOfObjectValues<SensitiveContentEvidence>(SensitiveContentEvidence.CreateFromDiscriminatorValue).ToList(); } },
                {"idMatch", n => { IdMatch = n.GetStringValue(); } },
                {"length", n => { Length = n.GetIntValue(); } },
                {"offset", n => { Offset = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("confidence", Confidence);
            writer.WriteCollectionOfObjectValues<SensitiveContentEvidence>("evidences", Evidences);
            writer.WriteStringValue("idMatch", IdMatch);
            writer.WriteIntValue("length", Length);
            writer.WriteIntValue("offset", Offset);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
