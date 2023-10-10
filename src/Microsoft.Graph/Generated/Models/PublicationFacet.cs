// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class PublicationFacet : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>User who has checked out the file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? CheckedOutBy {
            get { return BackingStore?.Get<IdentitySet?>("checkedOutBy"); }
            set { BackingStore?.Set("checkedOutBy", value); }
        }
#nullable restore
#else
        public IdentitySet CheckedOutBy {
            get { return BackingStore?.Get<IdentitySet>("checkedOutBy"); }
            set { BackingStore?.Set("checkedOutBy", value); }
        }
#endif
        /// <summary>The state of publication for this document. Either published or checkout. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Level {
            get { return BackingStore?.Get<string?>("level"); }
            set { BackingStore?.Set("level", value); }
        }
#nullable restore
#else
        public string Level {
            get { return BackingStore?.Get<string>("level"); }
            set { BackingStore?.Set("level", value); }
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
        /// <summary>The unique identifier for the version that is visible to the current caller. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VersionId {
            get { return BackingStore?.Get<string?>("versionId"); }
            set { BackingStore?.Set("versionId", value); }
        }
#nullable restore
#else
        public string VersionId {
            get { return BackingStore?.Get<string>("versionId"); }
            set { BackingStore?.Set("versionId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new publicationFacet and sets the default values.
        /// </summary>
        public PublicationFacet() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PublicationFacet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PublicationFacet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"checkedOutBy", n => { CheckedOutBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"level", n => { Level = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"versionId", n => { VersionId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<IdentitySet>("checkedOutBy", CheckedOutBy);
            writer.WriteStringValue("level", Level);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("versionId", VersionId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
