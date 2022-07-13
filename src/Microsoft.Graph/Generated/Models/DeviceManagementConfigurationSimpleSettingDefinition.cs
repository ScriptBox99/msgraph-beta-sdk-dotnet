using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationSimpleSettingDefinition : DeviceManagementConfigurationSettingDefinition, IParsable {
        /// <summary>Default setting value for this setting</summary>
        public DeviceManagementConfigurationSettingValue DefaultValue {
            get { return BackingStore?.Get<DeviceManagementConfigurationSettingValue>("defaultValue"); }
            set { BackingStore?.Set("defaultValue", value); }
        }
        /// <summary>list of child settings that depend on this setting</summary>
        public List<DeviceManagementConfigurationSettingDependedOnBy> DependedOnBy {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationSettingDependedOnBy>>("dependedOnBy"); }
            set { BackingStore?.Set("dependedOnBy", value); }
        }
        /// <summary>list of parent settings this setting is dependent on</summary>
        public List<DeviceManagementConfigurationDependentOn> DependentOn {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationDependentOn>>("dependentOn"); }
            set { BackingStore?.Set("dependentOn", value); }
        }
        /// <summary>Definition of the value for this setting</summary>
        public DeviceManagementConfigurationSettingValueDefinition ValueDefinition {
            get { return BackingStore?.Get<DeviceManagementConfigurationSettingValueDefinition>("valueDefinition"); }
            set { BackingStore?.Set("valueDefinition", value); }
        }
        /// <summary>
        /// Instantiates a new DeviceManagementConfigurationSimpleSettingDefinition and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationSimpleSettingDefinition() : base() {
            Type = "#microsoft.graph.deviceManagementConfigurationSimpleSettingDefinition";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementConfigurationSimpleSettingDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.deviceManagementConfigurationSimpleSettingCollectionDefinition" => new DeviceManagementConfigurationSimpleSettingCollectionDefinition(),
                _ => new DeviceManagementConfigurationSimpleSettingDefinition(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"defaultValue", n => { DefaultValue = n.GetObjectValue<DeviceManagementConfigurationSettingValue>(DeviceManagementConfigurationSettingValue.CreateFromDiscriminatorValue); } },
                {"dependedOnBy", n => { DependedOnBy = n.GetCollectionOfObjectValues<DeviceManagementConfigurationSettingDependedOnBy>(DeviceManagementConfigurationSettingDependedOnBy.CreateFromDiscriminatorValue).ToList(); } },
                {"dependentOn", n => { DependentOn = n.GetCollectionOfObjectValues<DeviceManagementConfigurationDependentOn>(DeviceManagementConfigurationDependentOn.CreateFromDiscriminatorValue).ToList(); } },
                {"valueDefinition", n => { ValueDefinition = n.GetObjectValue<DeviceManagementConfigurationSettingValueDefinition>(DeviceManagementConfigurationSettingValueDefinition.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<DeviceManagementConfigurationSettingValue>("defaultValue", DefaultValue);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationSettingDependedOnBy>("dependedOnBy", DependedOnBy);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationDependentOn>("dependentOn", DependentOn);
            writer.WriteObjectValue<DeviceManagementConfigurationSettingValueDefinition>("valueDefinition", ValueDefinition);
        }
    }
}
