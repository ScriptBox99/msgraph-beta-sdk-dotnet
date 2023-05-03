using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationSettingApplicability : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>description of the setting</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>Describes applicability for the mode the device is in</summary>
        public DeviceManagementConfigurationDeviceMode? DeviceMode {
            get { return BackingStore?.Get<DeviceManagementConfigurationDeviceMode?>("deviceMode"); }
            set { BackingStore?.Set("deviceMode", value); }
        }
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
        /// <summary>Supported platform types.</summary>
        public DeviceManagementConfigurationPlatforms? Platform {
            get { return BackingStore?.Get<DeviceManagementConfigurationPlatforms?>("platform"); }
            set { BackingStore?.Set("platform", value); }
        }
        /// <summary>Describes which technology this setting can be deployed with</summary>
        public DeviceManagementConfigurationTechnologies? Technologies {
            get { return BackingStore?.Get<DeviceManagementConfigurationTechnologies?>("technologies"); }
            set { BackingStore?.Set("technologies", value); }
        }
        /// <summary>
        /// Instantiates a new deviceManagementConfigurationSettingApplicability and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationSettingApplicability() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeviceManagementConfigurationSettingApplicability CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.deviceManagementConfigurationApplicationSettingApplicability" => new DeviceManagementConfigurationApplicationSettingApplicability(),
                "#microsoft.graph.deviceManagementConfigurationExchangeOnlineSettingApplicability" => new DeviceManagementConfigurationExchangeOnlineSettingApplicability(),
                "#microsoft.graph.deviceManagementConfigurationWindowsSettingApplicability" => new DeviceManagementConfigurationWindowsSettingApplicability(),
                _ => new DeviceManagementConfigurationSettingApplicability(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"description", n => { Description = n.GetStringValue(); } },
                {"deviceMode", n => { DeviceMode = n.GetEnumValue<DeviceManagementConfigurationDeviceMode>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"platform", n => { Platform = n.GetEnumValue<DeviceManagementConfigurationPlatforms>(); } },
                {"technologies", n => { Technologies = n.GetEnumValue<DeviceManagementConfigurationTechnologies>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<DeviceManagementConfigurationDeviceMode>("deviceMode", DeviceMode);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<DeviceManagementConfigurationPlatforms>("platform", Platform);
            writer.WriteEnumValue<DeviceManagementConfigurationTechnologies>("technologies", Technologies);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
