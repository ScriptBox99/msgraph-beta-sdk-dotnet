using Microsoft.Graph.Beta.Models.WindowsUpdates;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Admin.Windows.Updates.Deployments.Item.Audience.Exclusions.UnenrollAssets {
    /// <summary>
    /// Provides operations to call the unenrollAssets method.
    /// </summary>
    public class UnenrollAssetsPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The assets property</summary>
        public List<UpdatableAsset> Assets {
            get { return BackingStore?.Get<List<UpdatableAsset>>("assets"); }
            set { BackingStore?.Set("assets", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The updateCategory property</summary>
        public Microsoft.Graph.Beta.Models.WindowsUpdates.UpdateCategory? UpdateCategory {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdateCategory?>("updateCategory"); }
            set { BackingStore?.Set("updateCategory", value); }
        }
        /// <summary>
        /// Instantiates a new unenrollAssetsPostRequestBody and sets the default values.
        /// </summary>
        public UnenrollAssetsPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UnenrollAssetsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnenrollAssetsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"assets", n => { Assets = n.GetCollectionOfObjectValues<UpdatableAsset>(UpdatableAsset.CreateFromDiscriminatorValue)?.ToList(); } },
                {"updateCategory", n => { UpdateCategory = n.GetEnumValue<UpdateCategory>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<UpdatableAsset>("assets", Assets);
            writer.WriteEnumValue<UpdateCategory>("updateCategory", UpdateCategory);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
