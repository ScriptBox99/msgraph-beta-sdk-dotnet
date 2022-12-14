using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Identity.ConditionalAccess.AuthenticationStrengths.Policies.Item.UpdateAllowedCombinations {
    /// <summary>
    /// Provides operations to call the updateAllowedCombinations method.
    /// </summary>
    public class UpdateAllowedCombinationsPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The allowedCombinations property</summary>
        public List<Microsoft.Graph.Beta.Models.AuthenticationMethodModes?> AllowedCombinations {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AuthenticationMethodModes?>>("allowedCombinations"); }
            set { BackingStore?.Set("allowedCombinations", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>
        /// Instantiates a new updateAllowedCombinationsPostRequestBody and sets the default values.
        /// </summary>
        public UpdateAllowedCombinationsPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UpdateAllowedCombinationsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UpdateAllowedCombinationsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowedCombinations", n => { AllowedCombinations = n.GetCollectionOfEnumValues<Microsoft.Graph.Beta.Models.AuthenticationMethodModes>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfEnumValues<Microsoft.Graph.Beta.Models.AuthenticationMethodModes>("allowedCombinations", AllowedCombinations);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
