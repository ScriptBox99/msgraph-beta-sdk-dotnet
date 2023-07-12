using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationWindowsSettingApplicability : DeviceManagementConfigurationSettingApplicability, IParsable {
        /// <summary>Version of CSP setting is a part of</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConfigurationServiceProviderVersion {
            get { return BackingStore?.Get<string?>("configurationServiceProviderVersion"); }
            set { BackingStore?.Set("configurationServiceProviderVersion", value); }
        }
#nullable restore
#else
        public string ConfigurationServiceProviderVersion {
            get { return BackingStore?.Get<string>("configurationServiceProviderVersion"); }
            set { BackingStore?.Set("configurationServiceProviderVersion", value); }
        }
#endif
        /// <summary>Maximum supported version of Windows</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MaximumSupportedVersion {
            get { return BackingStore?.Get<string?>("maximumSupportedVersion"); }
            set { BackingStore?.Set("maximumSupportedVersion", value); }
        }
#nullable restore
#else
        public string MaximumSupportedVersion {
            get { return BackingStore?.Get<string>("maximumSupportedVersion"); }
            set { BackingStore?.Set("maximumSupportedVersion", value); }
        }
#endif
        /// <summary>Minimum supported version of Windows</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumSupportedVersion {
            get { return BackingStore?.Get<string?>("minimumSupportedVersion"); }
            set { BackingStore?.Set("minimumSupportedVersion", value); }
        }
#nullable restore
#else
        public string MinimumSupportedVersion {
            get { return BackingStore?.Get<string>("minimumSupportedVersion"); }
            set { BackingStore?.Set("minimumSupportedVersion", value); }
        }
#endif
        /// <summary>Required AAD Trust Type</summary>
        public DeviceManagementConfigurationAzureAdTrustType? RequiredAzureAdTrustType {
            get { return BackingStore?.Get<DeviceManagementConfigurationAzureAdTrustType?>("requiredAzureAdTrustType"); }
            set { BackingStore?.Set("requiredAzureAdTrustType", value); }
        }
        /// <summary>AzureAD setting requirement</summary>
        public bool? RequiresAzureAd {
            get { return BackingStore?.Get<bool?>("requiresAzureAd"); }
            set { BackingStore?.Set("requiresAzureAd", value); }
        }
        /// <summary>List of Windows SKUs that the setting is applicable for</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementConfigurationWindowsSkus?>? WindowsSkus {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationWindowsSkus?>?>("windowsSkus"); }
            set { BackingStore?.Set("windowsSkus", value); }
        }
#nullable restore
#else
        public List<DeviceManagementConfigurationWindowsSkus?> WindowsSkus {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationWindowsSkus?>>("windowsSkus"); }
            set { BackingStore?.Set("windowsSkus", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new deviceManagementConfigurationWindowsSettingApplicability and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationWindowsSettingApplicability() : base() {
            OdataType = "#microsoft.graph.deviceManagementConfigurationWindowsSettingApplicability";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementConfigurationWindowsSettingApplicability CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationWindowsSettingApplicability();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"configurationServiceProviderVersion", n => { ConfigurationServiceProviderVersion = n.GetStringValue(); } },
                {"maximumSupportedVersion", n => { MaximumSupportedVersion = n.GetStringValue(); } },
                {"minimumSupportedVersion", n => { MinimumSupportedVersion = n.GetStringValue(); } },
                {"requiredAzureAdTrustType", n => { RequiredAzureAdTrustType = n.GetEnumValue<DeviceManagementConfigurationAzureAdTrustType>(); } },
                {"requiresAzureAd", n => { RequiresAzureAd = n.GetBoolValue(); } },
                {"windowsSkus", n => { WindowsSkus = n.GetCollectionOfEnumValues<DeviceManagementConfigurationWindowsSkus>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("configurationServiceProviderVersion", ConfigurationServiceProviderVersion);
            writer.WriteStringValue("maximumSupportedVersion", MaximumSupportedVersion);
            writer.WriteStringValue("minimumSupportedVersion", MinimumSupportedVersion);
            writer.WriteEnumValue<DeviceManagementConfigurationAzureAdTrustType>("requiredAzureAdTrustType", RequiredAzureAdTrustType);
            writer.WriteBoolValue("requiresAzureAd", RequiresAzureAd);
            writer.WriteCollectionOfEnumValues<DeviceManagementConfigurationWindowsSkus>("windowsSkus", WindowsSkus);
        }
    }
}
