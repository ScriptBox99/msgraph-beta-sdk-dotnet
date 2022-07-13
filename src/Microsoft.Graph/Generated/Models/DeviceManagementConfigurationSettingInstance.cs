using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Setting instance within policy</summary>
    public class DeviceManagementConfigurationSettingInstance : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Setting Definition Id</summary>
        public string SettingDefinitionId {
            get { return BackingStore?.Get<string>("settingDefinitionId"); }
            set { BackingStore?.Set("settingDefinitionId", value); }
        }
        /// <summary>Setting Instance Template Reference</summary>
        public DeviceManagementConfigurationSettingInstanceTemplateReference SettingInstanceTemplateReference {
            get { return BackingStore?.Get<DeviceManagementConfigurationSettingInstanceTemplateReference>("settingInstanceTemplateReference"); }
            set { BackingStore?.Set("settingInstanceTemplateReference", value); }
        }
        /// <summary>The type property</summary>
        public string Type {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new deviceManagementConfigurationSettingInstance and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationSettingInstance() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            Type = "#microsoft.graph.deviceManagementConfigurationSettingInstance";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceManagementConfigurationSettingInstance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.deviceManagementConfigurationChoiceSettingCollectionInstance" => new DeviceManagementConfigurationChoiceSettingCollectionInstance(),
                "#microsoft.graph.deviceManagementConfigurationChoiceSettingInstance" => new DeviceManagementConfigurationChoiceSettingInstance(),
                "#microsoft.graph.deviceManagementConfigurationGroupSettingCollectionInstance" => new DeviceManagementConfigurationGroupSettingCollectionInstance(),
                "#microsoft.graph.deviceManagementConfigurationGroupSettingInstance" => new DeviceManagementConfigurationGroupSettingInstance(),
                "#microsoft.graph.deviceManagementConfigurationSettingGroupCollectionInstance" => new DeviceManagementConfigurationSettingGroupCollectionInstance(),
                "#microsoft.graph.deviceManagementConfigurationSettingGroupInstance" => new DeviceManagementConfigurationSettingGroupInstance(),
                "#microsoft.graph.deviceManagementConfigurationSimpleSettingCollectionInstance" => new DeviceManagementConfigurationSimpleSettingCollectionInstance(),
                "#microsoft.graph.deviceManagementConfigurationSimpleSettingInstance" => new DeviceManagementConfigurationSimpleSettingInstance(),
                _ => new DeviceManagementConfigurationSettingInstance(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"settingDefinitionId", n => { SettingDefinitionId = n.GetStringValue(); } },
                {"settingInstanceTemplateReference", n => { SettingInstanceTemplateReference = n.GetObjectValue<DeviceManagementConfigurationSettingInstanceTemplateReference>(DeviceManagementConfigurationSettingInstanceTemplateReference.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("settingDefinitionId", SettingDefinitionId);
            writer.WriteObjectValue<DeviceManagementConfigurationSettingInstanceTemplateReference>("settingInstanceTemplateReference", SettingInstanceTemplateReference);
            writer.WriteStringValue("@odata.type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
