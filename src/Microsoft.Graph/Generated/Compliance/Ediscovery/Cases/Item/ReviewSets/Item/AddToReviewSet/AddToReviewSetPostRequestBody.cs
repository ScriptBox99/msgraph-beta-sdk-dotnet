using Microsoft.Graph.Beta.Models.Ediscovery;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.ReviewSets.Item.AddToReviewSet {
    /// <summary>
    /// Provides operations to call the addToReviewSet method.
    /// </summary>
    public class AddToReviewSetPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The additionalDataOptions property</summary>
        public Microsoft.Graph.Beta.Models.Ediscovery.AdditionalDataOptions? AdditionalDataOptions {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Ediscovery.AdditionalDataOptions?>("additionalDataOptions"); }
            set { BackingStore?.Set("additionalDataOptions", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The sourceCollection property</summary>
        public Microsoft.Graph.Beta.Models.Ediscovery.SourceCollection SourceCollection {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Ediscovery.SourceCollection>("sourceCollection"); }
            set { BackingStore?.Set("sourceCollection", value); }
        }
        /// <summary>
        /// Instantiates a new addToReviewSetPostRequestBody and sets the default values.
        /// </summary>
        public AddToReviewSetPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AddToReviewSetPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AddToReviewSetPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"additionalDataOptions", n => { AdditionalDataOptions = n.GetEnumValue<AdditionalDataOptions>(); } },
                {"sourceCollection", n => { SourceCollection = n.GetObjectValue<Microsoft.Graph.Beta.Models.Ediscovery.SourceCollection>(Microsoft.Graph.Beta.Models.Ediscovery.SourceCollection.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AdditionalDataOptions>("additionalDataOptions", AdditionalDataOptions);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Ediscovery.SourceCollection>("sourceCollection", SourceCollection);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
