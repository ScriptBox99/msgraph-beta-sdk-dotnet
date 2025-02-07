// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class AuthenticationAttributeCollectionPage : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The customStringsFileId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomStringsFileId {
            get { return BackingStore?.Get<string?>("customStringsFileId"); }
            set { BackingStore?.Set("customStringsFileId", value); }
        }
#nullable restore
#else
        public string CustomStringsFileId {
            get { return BackingStore?.Get<string>("customStringsFileId"); }
            set { BackingStore?.Set("customStringsFileId", value); }
        }
#endif
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
        /// <summary>A collection of displays of the attribute collection page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AuthenticationAttributeCollectionPageViewConfiguration>? Views {
            get { return BackingStore?.Get<List<AuthenticationAttributeCollectionPageViewConfiguration>?>("views"); }
            set { BackingStore?.Set("views", value); }
        }
#nullable restore
#else
        public List<AuthenticationAttributeCollectionPageViewConfiguration> Views {
            get { return BackingStore?.Get<List<AuthenticationAttributeCollectionPageViewConfiguration>>("views"); }
            set { BackingStore?.Set("views", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new authenticationAttributeCollectionPage and sets the default values.
        /// </summary>
        public AuthenticationAttributeCollectionPage() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AuthenticationAttributeCollectionPage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuthenticationAttributeCollectionPage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"customStringsFileId", n => { CustomStringsFileId = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"views", n => { Views = n.GetCollectionOfObjectValues<AuthenticationAttributeCollectionPageViewConfiguration>(AuthenticationAttributeCollectionPageViewConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("customStringsFileId", CustomStringsFileId);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<AuthenticationAttributeCollectionPageViewConfiguration>("views", Views);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
