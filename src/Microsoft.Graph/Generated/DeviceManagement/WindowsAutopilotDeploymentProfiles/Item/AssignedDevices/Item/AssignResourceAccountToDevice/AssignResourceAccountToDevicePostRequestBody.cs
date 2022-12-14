using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeploymentProfiles.Item.AssignedDevices.Item.AssignResourceAccountToDevice {
    /// <summary>
    /// Provides operations to call the assignResourceAccountToDevice method.
    /// </summary>
    public class AssignResourceAccountToDevicePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The addressableUserName property</summary>
        public string AddressableUserName {
            get { return BackingStore?.Get<string>("addressableUserName"); }
            set { BackingStore?.Set("addressableUserName", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The resourceAccountName property</summary>
        public string ResourceAccountName {
            get { return BackingStore?.Get<string>("resourceAccountName"); }
            set { BackingStore?.Set("resourceAccountName", value); }
        }
        /// <summary>The userPrincipalName property</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
        /// <summary>
        /// Instantiates a new assignResourceAccountToDevicePostRequestBody and sets the default values.
        /// </summary>
        public AssignResourceAccountToDevicePostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AssignResourceAccountToDevicePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AssignResourceAccountToDevicePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"addressableUserName", n => { AddressableUserName = n.GetStringValue(); } },
                {"resourceAccountName", n => { ResourceAccountName = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("addressableUserName", AddressableUserName);
            writer.WriteStringValue("resourceAccountName", ResourceAccountName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
