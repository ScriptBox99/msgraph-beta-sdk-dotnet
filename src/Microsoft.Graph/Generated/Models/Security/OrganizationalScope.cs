using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class OrganizationalScope : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
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
        /// <summary>The scopeNames property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ScopeNames {
            get { return BackingStore?.Get<List<string>?>("scopeNames"); }
            set { BackingStore?.Set("scopeNames", value); }
        }
#nullable restore
#else
        public List<string> ScopeNames {
            get { return BackingStore?.Get<List<string>>("scopeNames"); }
            set { BackingStore?.Set("scopeNames", value); }
        }
#endif
        /// <summary>The scopeType property</summary>
        public Microsoft.Graph.Beta.Models.Security.ScopeType? ScopeType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.ScopeType?>("scopeType"); }
            set { BackingStore?.Set("scopeType", value); }
        }
        /// <summary>
        /// Instantiates a new organizationalScope and sets the default values.
        /// </summary>
        public OrganizationalScope() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static OrganizationalScope CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OrganizationalScope();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"scopeNames", n => { ScopeNames = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"scopeType", n => { ScopeType = n.GetEnumValue<ScopeType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfPrimitiveValues<string>("scopeNames", ScopeNames);
            writer.WriteEnumValue<ScopeType>("scopeType", ScopeType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
