// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess {
    public class BranchConnectivityConfiguration : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The branchId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BranchId {
            get { return BackingStore?.Get<string?>("branchId"); }
            set { BackingStore?.Set("branchId", value); }
        }
#nullable restore
#else
        public string BranchId {
            get { return BackingStore?.Get<string>("branchId"); }
            set { BackingStore?.Set("branchId", value); }
        }
#endif
        /// <summary>The branchName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BranchName {
            get { return BackingStore?.Get<string?>("branchName"); }
            set { BackingStore?.Set("branchName", value); }
        }
#nullable restore
#else
        public string BranchName {
            get { return BackingStore?.Get<string>("branchName"); }
            set { BackingStore?.Set("branchName", value); }
        }
#endif
        /// <summary>The links property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ConnectivityConfigurationLink>? Links {
            get { return BackingStore?.Get<List<ConnectivityConfigurationLink>?>("links"); }
            set { BackingStore?.Set("links", value); }
        }
#nullable restore
#else
        public List<ConnectivityConfigurationLink> Links {
            get { return BackingStore?.Get<List<ConnectivityConfigurationLink>>("links"); }
            set { BackingStore?.Set("links", value); }
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
        /// Instantiates a new branchConnectivityConfiguration and sets the default values.
        /// </summary>
        public BranchConnectivityConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BranchConnectivityConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BranchConnectivityConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"branchId", n => { BranchId = n.GetStringValue(); } },
                {"branchName", n => { BranchName = n.GetStringValue(); } },
                {"links", n => { Links = n.GetCollectionOfObjectValues<ConnectivityConfigurationLink>(ConnectivityConfigurationLink.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("branchId", BranchId);
            writer.WriteStringValue("branchName", BranchName);
            writer.WriteCollectionOfObjectValues<ConnectivityConfigurationLink>("links", Links);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
