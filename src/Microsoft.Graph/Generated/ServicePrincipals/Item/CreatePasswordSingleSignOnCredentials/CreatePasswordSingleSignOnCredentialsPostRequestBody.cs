using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.ServicePrincipals.Item.CreatePasswordSingleSignOnCredentials {
    /// <summary>
    /// Provides operations to call the createPasswordSingleSignOnCredentials method.
    /// </summary>
    public class CreatePasswordSingleSignOnCredentialsPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The credentials property</summary>
        public List<Credential> Credentials {
            get { return BackingStore?.Get<List<Credential>>("credentials"); }
            set { BackingStore?.Set("credentials", value); }
        }
        /// <summary>The id property</summary>
        public string Id {
            get { return BackingStore?.Get<string>("id"); }
            set { BackingStore?.Set("id", value); }
        }
        /// <summary>
        /// Instantiates a new createPasswordSingleSignOnCredentialsPostRequestBody and sets the default values.
        /// </summary>
        public CreatePasswordSingleSignOnCredentialsPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CreatePasswordSingleSignOnCredentialsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreatePasswordSingleSignOnCredentialsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"credentials", n => { Credentials = n.GetCollectionOfObjectValues<Credential>(Credential.CreateFromDiscriminatorValue)?.ToList(); } },
                {"id", n => { Id = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<Credential>("credentials", Credentials);
            writer.WriteStringValue("id", Id);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
