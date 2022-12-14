using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class InformationProtectionAction : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new informationProtectionAction and sets the default values.
        /// </summary>
        public InformationProtectionAction() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static InformationProtectionAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.security.addContentFooterAction" => new AddContentFooterAction(),
                "#microsoft.graph.security.addContentHeaderAction" => new AddContentHeaderAction(),
                "#microsoft.graph.security.addWatermarkAction" => new AddWatermarkAction(),
                "#microsoft.graph.security.applyLabelAction" => new ApplyLabelAction(),
                "#microsoft.graph.security.customAction" => new CustomAction(),
                "#microsoft.graph.security.justifyAction" => new JustifyAction(),
                "#microsoft.graph.security.metadataAction" => new MetadataAction(),
                "#microsoft.graph.security.protectAdhocAction" => new ProtectAdhocAction(),
                "#microsoft.graph.security.protectByTemplateAction" => new ProtectByTemplateAction(),
                "#microsoft.graph.security.protectDoNotForwardAction" => new ProtectDoNotForwardAction(),
                "#microsoft.graph.security.recommendLabelAction" => new RecommendLabelAction(),
                "#microsoft.graph.security.removeContentFooterAction" => new RemoveContentFooterAction(),
                "#microsoft.graph.security.removeContentHeaderAction" => new RemoveContentHeaderAction(),
                "#microsoft.graph.security.removeProtectionAction" => new RemoveProtectionAction(),
                "#microsoft.graph.security.removeWatermarkAction" => new RemoveWatermarkAction(),
                _ => new InformationProtectionAction(),
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
