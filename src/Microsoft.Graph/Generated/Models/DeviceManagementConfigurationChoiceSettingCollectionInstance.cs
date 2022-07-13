using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationChoiceSettingCollectionInstance : DeviceManagementConfigurationSettingInstance, IParsable {
        /// <summary>Choice setting collection value</summary>
        public List<DeviceManagementConfigurationChoiceSettingValue> ChoiceSettingCollectionValue {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationChoiceSettingValue>>("choiceSettingCollectionValue"); }
            set { BackingStore?.Set("choiceSettingCollectionValue", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementConfigurationChoiceSettingCollectionInstance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationChoiceSettingCollectionInstance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"choiceSettingCollectionValue", n => { ChoiceSettingCollectionValue = n.GetCollectionOfObjectValues<DeviceManagementConfigurationChoiceSettingValue>(DeviceManagementConfigurationChoiceSettingValue.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationChoiceSettingValue>("choiceSettingCollectionValue", ChoiceSettingCollectionValue);
        }
    }
}
