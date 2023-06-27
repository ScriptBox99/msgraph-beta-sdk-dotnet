using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Set of allowed and not allowed actions for a resource.
    /// </summary>
    public class ResourceAction : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Allowed Actions</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AllowedResourceActions {
            get { return BackingStore?.Get<List<string>?>("allowedResourceActions"); }
            set { BackingStore?.Set("allowedResourceActions", value); }
        }
#nullable restore
#else
        public List<string> AllowedResourceActions {
            get { return BackingStore?.Get<List<string>>("allowedResourceActions"); }
            set { BackingStore?.Set("allowedResourceActions", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Not Allowed Actions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? NotAllowedResourceActions {
            get { return BackingStore?.Get<List<string>?>("notAllowedResourceActions"); }
            set { BackingStore?.Set("notAllowedResourceActions", value); }
        }
#nullable restore
#else
        public List<string> NotAllowedResourceActions {
            get { return BackingStore?.Get<List<string>>("notAllowedResourceActions"); }
            set { BackingStore?.Set("notAllowedResourceActions", value); }
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
        /// <summary>
        /// Instantiates a new ResourceAction and sets the default values.
        /// </summary>
        public ResourceAction() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ResourceAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ResourceAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowedResourceActions", n => { AllowedResourceActions = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"notAllowedResourceActions", n => { NotAllowedResourceActions = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("allowedResourceActions", AllowedResourceActions);
            writer.WriteCollectionOfPrimitiveValues<string>("notAllowedResourceActions", NotAllowedResourceActions);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
