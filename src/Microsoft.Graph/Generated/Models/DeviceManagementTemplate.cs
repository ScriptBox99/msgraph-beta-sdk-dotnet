// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Entity that represents a defined collection of device settings
    /// </summary>
    public class DeviceManagementTemplate : Entity, IParsable {
        /// <summary>Collection of setting categories within the template</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementTemplateSettingCategory>? Categories {
            get { return BackingStore?.Get<List<DeviceManagementTemplateSettingCategory>?>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
#nullable restore
#else
        public List<DeviceManagementTemplateSettingCategory> Categories {
            get { return BackingStore?.Get<List<DeviceManagementTemplateSettingCategory>>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
#endif
        /// <summary>The template&apos;s description</summary>
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
        /// <summary>The template&apos;s display name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Number of Intents created from this template.</summary>
        public int? IntentCount {
            get { return BackingStore?.Get<int?>("intentCount"); }
            set { BackingStore?.Set("intentCount", value); }
        }
        /// <summary>The template is deprecated or not. Intents cannot be created from a deprecated template.</summary>
        public bool? IsDeprecated {
            get { return BackingStore?.Get<bool?>("isDeprecated"); }
            set { BackingStore?.Set("isDeprecated", value); }
        }
        /// <summary>Collection of templates this template can migrate to</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementTemplate>? MigratableTo {
            get { return BackingStore?.Get<List<DeviceManagementTemplate>?>("migratableTo"); }
            set { BackingStore?.Set("migratableTo", value); }
        }
#nullable restore
#else
        public List<DeviceManagementTemplate> MigratableTo {
            get { return BackingStore?.Get<List<DeviceManagementTemplate>>("migratableTo"); }
            set { BackingStore?.Set("migratableTo", value); }
        }
#endif
        /// <summary>Supported platform types for policies.</summary>
        public PolicyPlatformType? PlatformType {
            get { return BackingStore?.Get<PolicyPlatformType?>("platformType"); }
            set { BackingStore?.Set("platformType", value); }
        }
        /// <summary>When the template was published</summary>
        public DateTimeOffset? PublishedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("publishedDateTime"); }
            set { BackingStore?.Set("publishedDateTime", value); }
        }
        /// <summary>Collection of all settings this template has</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementSettingInstance>? Settings {
            get { return BackingStore?.Get<List<DeviceManagementSettingInstance>?>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#nullable restore
#else
        public List<DeviceManagementSettingInstance> Settings {
            get { return BackingStore?.Get<List<DeviceManagementSettingInstance>>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#endif
        /// <summary>Template subtype</summary>
        public DeviceManagementTemplateSubtype? TemplateSubtype {
            get { return BackingStore?.Get<DeviceManagementTemplateSubtype?>("templateSubtype"); }
            set { BackingStore?.Set("templateSubtype", value); }
        }
        /// <summary>Template type</summary>
        public DeviceManagementTemplateType? TemplateType {
            get { return BackingStore?.Get<DeviceManagementTemplateType?>("templateType"); }
            set { BackingStore?.Set("templateType", value); }
        }
        /// <summary>The template&apos;s version information</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VersionInfo {
            get { return BackingStore?.Get<string?>("versionInfo"); }
            set { BackingStore?.Set("versionInfo", value); }
        }
#nullable restore
#else
        public string VersionInfo {
            get { return BackingStore?.Get<string>("versionInfo"); }
            set { BackingStore?.Set("versionInfo", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.securityBaselineTemplate" => new SecurityBaselineTemplate(),
                _ => new DeviceManagementTemplate(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"categories", n => { Categories = n.GetCollectionOfObjectValues<DeviceManagementTemplateSettingCategory>(DeviceManagementTemplateSettingCategory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"intentCount", n => { IntentCount = n.GetIntValue(); } },
                {"isDeprecated", n => { IsDeprecated = n.GetBoolValue(); } },
                {"migratableTo", n => { MigratableTo = n.GetCollectionOfObjectValues<DeviceManagementTemplate>(DeviceManagementTemplate.CreateFromDiscriminatorValue)?.ToList(); } },
                {"platformType", n => { PlatformType = n.GetEnumValue<PolicyPlatformType>(); } },
                {"publishedDateTime", n => { PublishedDateTime = n.GetDateTimeOffsetValue(); } },
                {"settings", n => { Settings = n.GetCollectionOfObjectValues<DeviceManagementSettingInstance>(DeviceManagementSettingInstance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"templateSubtype", n => { TemplateSubtype = n.GetEnumValue<DeviceManagementTemplateSubtype>(); } },
                {"templateType", n => { TemplateType = n.GetEnumValue<DeviceManagementTemplateType>(); } },
                {"versionInfo", n => { VersionInfo = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeviceManagementTemplateSettingCategory>("categories", Categories);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteIntValue("intentCount", IntentCount);
            writer.WriteBoolValue("isDeprecated", IsDeprecated);
            writer.WriteCollectionOfObjectValues<DeviceManagementTemplate>("migratableTo", MigratableTo);
            writer.WriteEnumValue<PolicyPlatformType>("platformType", PlatformType);
            writer.WriteDateTimeOffsetValue("publishedDateTime", PublishedDateTime);
            writer.WriteCollectionOfObjectValues<DeviceManagementSettingInstance>("settings", Settings);
            writer.WriteEnumValue<DeviceManagementTemplateSubtype>("templateSubtype", TemplateSubtype);
            writer.WriteEnumValue<DeviceManagementTemplateType>("templateType", TemplateType);
            writer.WriteStringValue("versionInfo", VersionInfo);
        }
    }
}
