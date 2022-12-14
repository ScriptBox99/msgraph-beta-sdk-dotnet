using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
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
                "#microsoft.graph.addContentFooterAction" => new AddContentFooterAction(),
                "#microsoft.graph.addContentHeaderAction" => new AddContentHeaderAction(),
                "#microsoft.graph.addWatermarkAction" => new AddWatermarkAction(),
                "#microsoft.graph.applyLabelAction" => new ApplyLabelAction(),
                "#microsoft.graph.customAction" => new CustomAction(),
                "#microsoft.graph.justifyAction" => new JustifyAction(),
                "#microsoft.graph.metadataAction" => new MetadataAction(),
                "#microsoft.graph.protectAdhocAction" => new ProtectAdhocAction(),
                "#microsoft.graph.protectByTemplateAction" => new ProtectByTemplateAction(),
                "#microsoft.graph.protectDoNotForwardAction" => new ProtectDoNotForwardAction(),
                "#microsoft.graph.recommendLabelAction" => new RecommendLabelAction(),
                "#microsoft.graph.removeContentFooterAction" => new RemoveContentFooterAction(),
                "#microsoft.graph.removeContentHeaderAction" => new RemoveContentHeaderAction(),
                "#microsoft.graph.removeProtectionAction" => new RemoveProtectionAction(),
                "#microsoft.graph.removeWatermarkAction" => new RemoveWatermarkAction(),
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
