using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Item.Reprovision {
    /// <summary>Provides operations to call the reprovision method.</summary>
    public class ReprovisionPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The osVersion property</summary>
        public CloudPcOperatingSystem? OsVersion {
            get { return BackingStore?.Get<CloudPcOperatingSystem?>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
        /// <summary>The userAccountType property</summary>
        public CloudPcUserAccountType? UserAccountType {
            get { return BackingStore?.Get<CloudPcUserAccountType?>("userAccountType"); }
            set { BackingStore?.Set("userAccountType", value); }
        }
        /// <summary>
        /// Instantiates a new reprovisionPostRequestBody and sets the default values.
        /// </summary>
        public ReprovisionPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ReprovisionPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ReprovisionPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"osVersion", n => { OsVersion = n.GetEnumValue<CloudPcOperatingSystem>(); } },
                {"userAccountType", n => { UserAccountType = n.GetEnumValue<CloudPcUserAccountType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<CloudPcOperatingSystem>("osVersion", OsVersion);
            writer.WriteEnumValue<CloudPcUserAccountType>("userAccountType", UserAccountType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
