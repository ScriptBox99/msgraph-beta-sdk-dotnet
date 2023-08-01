using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationSettingGroupCollectionDefinition : DeviceManagementConfigurationSettingGroupDefinition, IParsable {
        /// <summary>Maximum number of setting group count in the collection. Valid values 1 to 100</summary>
        public int? MaximumCount {
            get { return BackingStore?.Get<int?>("maximumCount"); }
            set { BackingStore?.Set("maximumCount", value); }
        }
        /// <summary>Minimum number of setting group count in the collection. Valid values 1 to 100</summary>
        public int? MinimumCount {
            get { return BackingStore?.Get<int?>("minimumCount"); }
            set { BackingStore?.Set("minimumCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementConfigurationSettingGroupCollectionDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationSettingGroupCollectionDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"maximumCount", n => { MaximumCount = n.GetIntValue(); } },
                {"minimumCount", n => { MinimumCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("maximumCount", MaximumCount);
            writer.WriteIntValue("minimumCount", MinimumCount);
        }
    }
}
