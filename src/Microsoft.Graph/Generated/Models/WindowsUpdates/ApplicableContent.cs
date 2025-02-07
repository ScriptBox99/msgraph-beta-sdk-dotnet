// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public class ApplicableContent : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The catalogEntry property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.WindowsUpdates.CatalogEntry? CatalogEntry {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsUpdates.CatalogEntry?>("catalogEntry"); }
            set { BackingStore?.Set("catalogEntry", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.WindowsUpdates.CatalogEntry CatalogEntry {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsUpdates.CatalogEntry>("catalogEntry"); }
            set { BackingStore?.Set("catalogEntry", value); }
        }
#endif
        /// <summary>Collection of devices and recommendations for applicable catalog content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApplicableContentDeviceMatch>? MatchedDevices {
            get { return BackingStore?.Get<List<ApplicableContentDeviceMatch>?>("matchedDevices"); }
            set { BackingStore?.Set("matchedDevices", value); }
        }
#nullable restore
#else
        public List<ApplicableContentDeviceMatch> MatchedDevices {
            get { return BackingStore?.Get<List<ApplicableContentDeviceMatch>>("matchedDevices"); }
            set { BackingStore?.Set("matchedDevices", value); }
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
        /// Instantiates a new applicableContent and sets the default values.
        /// </summary>
        public ApplicableContent() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ApplicableContent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApplicableContent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"catalogEntry", n => { CatalogEntry = n.GetObjectValue<Microsoft.Graph.Beta.Models.WindowsUpdates.CatalogEntry>(Microsoft.Graph.Beta.Models.WindowsUpdates.CatalogEntry.CreateFromDiscriminatorValue); } },
                {"matchedDevices", n => { MatchedDevices = n.GetCollectionOfObjectValues<ApplicableContentDeviceMatch>(ApplicableContentDeviceMatch.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.WindowsUpdates.CatalogEntry>("catalogEntry", CatalogEntry);
            writer.WriteCollectionOfObjectValues<ApplicableContentDeviceMatch>("matchedDevices", MatchedDevices);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
