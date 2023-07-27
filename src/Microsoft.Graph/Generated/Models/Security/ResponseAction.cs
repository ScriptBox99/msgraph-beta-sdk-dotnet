using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class ResponseAction : IAdditionalDataHolder, IBackedModel, IParsable {
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
        /// <summary>
        /// Instantiates a new responseAction and sets the default values.
        /// </summary>
        public ResponseAction() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ResponseAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.security.allowFileResponseAction" => new AllowFileResponseAction(),
                "#microsoft.graph.security.blockFileResponseAction" => new BlockFileResponseAction(),
                "#microsoft.graph.security.collectInvestigationPackageResponseAction" => new CollectInvestigationPackageResponseAction(),
                "#microsoft.graph.security.disableUserResponseAction" => new DisableUserResponseAction(),
                "#microsoft.graph.security.forceUserPasswordResetResponseAction" => new ForceUserPasswordResetResponseAction(),
                "#microsoft.graph.security.hardDeleteResponseAction" => new HardDeleteResponseAction(),
                "#microsoft.graph.security.initiateInvestigationResponseAction" => new InitiateInvestigationResponseAction(),
                "#microsoft.graph.security.isolateDeviceResponseAction" => new IsolateDeviceResponseAction(),
                "#microsoft.graph.security.markUserAsCompromisedResponseAction" => new MarkUserAsCompromisedResponseAction(),
                "#microsoft.graph.security.moveToDeletedItemsResponseAction" => new MoveToDeletedItemsResponseAction(),
                "#microsoft.graph.security.moveToInboxResponseAction" => new MoveToInboxResponseAction(),
                "#microsoft.graph.security.moveToJunkResponseAction" => new MoveToJunkResponseAction(),
                "#microsoft.graph.security.restrictAppExecutionResponseAction" => new RestrictAppExecutionResponseAction(),
                "#microsoft.graph.security.runAntivirusScanResponseAction" => new RunAntivirusScanResponseAction(),
                "#microsoft.graph.security.softDeleteResponseAction" => new SoftDeleteResponseAction(),
                "#microsoft.graph.security.stopAndQuarantineFileResponseAction" => new StopAndQuarantineFileResponseAction(),
                _ => new ResponseAction(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
