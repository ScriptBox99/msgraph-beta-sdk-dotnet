using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationSettingDefinition : Entity, IParsable {
        /// <summary>The accessTypes property</summary>
        public DeviceManagementConfigurationSettingAccessTypes? AccessTypes {
            get { return BackingStore?.Get<DeviceManagementConfigurationSettingAccessTypes?>("accessTypes"); }
            set { BackingStore?.Set("accessTypes", value); }
        }
        /// <summary>Details which device setting is applicable on</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementConfigurationSettingApplicability? Applicability {
            get { return BackingStore?.Get<DeviceManagementConfigurationSettingApplicability?>("applicability"); }
            set { BackingStore?.Set("applicability", value); }
        }
#nullable restore
#else
        public DeviceManagementConfigurationSettingApplicability Applicability {
            get { return BackingStore?.Get<DeviceManagementConfigurationSettingApplicability>("applicability"); }
            set { BackingStore?.Set("applicability", value); }
        }
#endif
        /// <summary>Base CSP Path</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BaseUri {
            get { return BackingStore?.Get<string?>("baseUri"); }
            set { BackingStore?.Set("baseUri", value); }
        }
#nullable restore
#else
        public string BaseUri {
            get { return BackingStore?.Get<string>("baseUri"); }
            set { BackingStore?.Set("baseUri", value); }
        }
#endif
        /// <summary>Specifies the area group under which the setting is configured in a specified configuration service provider (CSP)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CategoryId {
            get { return BackingStore?.Get<string?>("categoryId"); }
            set { BackingStore?.Set("categoryId", value); }
        }
#nullable restore
#else
        public string CategoryId {
            get { return BackingStore?.Get<string>("categoryId"); }
            set { BackingStore?.Set("categoryId", value); }
        }
#endif
        /// <summary>Description of the item</summary>
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
        /// <summary>Display name of the item</summary>
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
        /// <summary>Help text of the item</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HelpText {
            get { return BackingStore?.Get<string?>("helpText"); }
            set { BackingStore?.Set("helpText", value); }
        }
#nullable restore
#else
        public string HelpText {
            get { return BackingStore?.Get<string>("helpText"); }
            set { BackingStore?.Set("helpText", value); }
        }
#endif
        /// <summary>List of links more info for the setting can be found at</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? InfoUrls {
            get { return BackingStore?.Get<List<string>?>("infoUrls"); }
            set { BackingStore?.Set("infoUrls", value); }
        }
#nullable restore
#else
        public List<string> InfoUrls {
            get { return BackingStore?.Get<List<string>>("infoUrls"); }
            set { BackingStore?.Set("infoUrls", value); }
        }
#endif
        /// <summary>Tokens which to search settings on</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Keywords {
            get { return BackingStore?.Get<List<string>?>("keywords"); }
            set { BackingStore?.Set("keywords", value); }
        }
#nullable restore
#else
        public List<string> Keywords {
            get { return BackingStore?.Get<List<string>>("keywords"); }
            set { BackingStore?.Set("keywords", value); }
        }
#endif
        /// <summary>Name of the item</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>Indicates whether the setting is required or not</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementConfigurationSettingOccurrence? Occurrence {
            get { return BackingStore?.Get<DeviceManagementConfigurationSettingOccurrence?>("occurrence"); }
            set { BackingStore?.Set("occurrence", value); }
        }
#nullable restore
#else
        public DeviceManagementConfigurationSettingOccurrence Occurrence {
            get { return BackingStore?.Get<DeviceManagementConfigurationSettingOccurrence>("occurrence"); }
            set { BackingStore?.Set("occurrence", value); }
        }
#endif
        /// <summary>Offset CSP Path from Base</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OffsetUri {
            get { return BackingStore?.Get<string?>("offsetUri"); }
            set { BackingStore?.Set("offsetUri", value); }
        }
#nullable restore
#else
        public string OffsetUri {
            get { return BackingStore?.Get<string>("offsetUri"); }
            set { BackingStore?.Set("offsetUri", value); }
        }
#endif
        /// <summary>List of referred setting information.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementConfigurationReferredSettingInformation>? ReferredSettingInformationList {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationReferredSettingInformation>?>("referredSettingInformationList"); }
            set { BackingStore?.Set("referredSettingInformationList", value); }
        }
#nullable restore
#else
        public List<DeviceManagementConfigurationReferredSettingInformation> ReferredSettingInformationList {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationReferredSettingInformation>>("referredSettingInformationList"); }
            set { BackingStore?.Set("referredSettingInformationList", value); }
        }
#endif
        /// <summary>Root setting definition if the setting is a child setting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RootDefinitionId {
            get { return BackingStore?.Get<string?>("rootDefinitionId"); }
            set { BackingStore?.Set("rootDefinitionId", value); }
        }
#nullable restore
#else
        public string RootDefinitionId {
            get { return BackingStore?.Get<string>("rootDefinitionId"); }
            set { BackingStore?.Set("rootDefinitionId", value); }
        }
#endif
        /// <summary>Supported setting types</summary>
        public DeviceManagementConfigurationSettingUsage? SettingUsage {
            get { return BackingStore?.Get<DeviceManagementConfigurationSettingUsage?>("settingUsage"); }
            set { BackingStore?.Set("settingUsage", value); }
        }
        /// <summary>Setting control type representation in the UX</summary>
        public DeviceManagementConfigurationControlType? UxBehavior {
            get { return BackingStore?.Get<DeviceManagementConfigurationControlType?>("uxBehavior"); }
            set { BackingStore?.Set("uxBehavior", value); }
        }
        /// <summary>Item Version</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version {
            get { return BackingStore?.Get<string?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#nullable restore
#else
        public string Version {
            get { return BackingStore?.Get<string>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#endif
        /// <summary>Supported setting types</summary>
        public DeviceManagementConfigurationSettingVisibility? Visibility {
            get { return BackingStore?.Get<DeviceManagementConfigurationSettingVisibility?>("visibility"); }
            set { BackingStore?.Set("visibility", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementConfigurationSettingDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.deviceManagementConfigurationChoiceSettingCollectionDefinition" => new DeviceManagementConfigurationChoiceSettingCollectionDefinition(),
                "#microsoft.graph.deviceManagementConfigurationChoiceSettingDefinition" => new DeviceManagementConfigurationChoiceSettingDefinition(),
                "#microsoft.graph.deviceManagementConfigurationRedirectSettingDefinition" => new DeviceManagementConfigurationRedirectSettingDefinition(),
                "#microsoft.graph.deviceManagementConfigurationSettingGroupCollectionDefinition" => new DeviceManagementConfigurationSettingGroupCollectionDefinition(),
                "#microsoft.graph.deviceManagementConfigurationSettingGroupDefinition" => new DeviceManagementConfigurationSettingGroupDefinition(),
                "#microsoft.graph.deviceManagementConfigurationSimpleSettingCollectionDefinition" => new DeviceManagementConfigurationSimpleSettingCollectionDefinition(),
                "#microsoft.graph.deviceManagementConfigurationSimpleSettingDefinition" => new DeviceManagementConfigurationSimpleSettingDefinition(),
                _ => new DeviceManagementConfigurationSettingDefinition(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessTypes", n => { AccessTypes = n.GetEnumValue<DeviceManagementConfigurationSettingAccessTypes>(); } },
                {"applicability", n => { Applicability = n.GetObjectValue<DeviceManagementConfigurationSettingApplicability>(DeviceManagementConfigurationSettingApplicability.CreateFromDiscriminatorValue); } },
                {"baseUri", n => { BaseUri = n.GetStringValue(); } },
                {"categoryId", n => { CategoryId = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"helpText", n => { HelpText = n.GetStringValue(); } },
                {"infoUrls", n => { InfoUrls = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"keywords", n => { Keywords = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"occurrence", n => { Occurrence = n.GetObjectValue<DeviceManagementConfigurationSettingOccurrence>(DeviceManagementConfigurationSettingOccurrence.CreateFromDiscriminatorValue); } },
                {"offsetUri", n => { OffsetUri = n.GetStringValue(); } },
                {"referredSettingInformationList", n => { ReferredSettingInformationList = n.GetCollectionOfObjectValues<DeviceManagementConfigurationReferredSettingInformation>(DeviceManagementConfigurationReferredSettingInformation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"rootDefinitionId", n => { RootDefinitionId = n.GetStringValue(); } },
                {"settingUsage", n => { SettingUsage = n.GetEnumValue<DeviceManagementConfigurationSettingUsage>(); } },
                {"uxBehavior", n => { UxBehavior = n.GetEnumValue<DeviceManagementConfigurationControlType>(); } },
                {"version", n => { Version = n.GetStringValue(); } },
                {"visibility", n => { Visibility = n.GetEnumValue<DeviceManagementConfigurationSettingVisibility>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<DeviceManagementConfigurationSettingAccessTypes>("accessTypes", AccessTypes);
            writer.WriteObjectValue<DeviceManagementConfigurationSettingApplicability>("applicability", Applicability);
            writer.WriteStringValue("baseUri", BaseUri);
            writer.WriteStringValue("categoryId", CategoryId);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("helpText", HelpText);
            writer.WriteCollectionOfPrimitiveValues<string>("infoUrls", InfoUrls);
            writer.WriteCollectionOfPrimitiveValues<string>("keywords", Keywords);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<DeviceManagementConfigurationSettingOccurrence>("occurrence", Occurrence);
            writer.WriteStringValue("offsetUri", OffsetUri);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationReferredSettingInformation>("referredSettingInformationList", ReferredSettingInformationList);
            writer.WriteStringValue("rootDefinitionId", RootDefinitionId);
            writer.WriteEnumValue<DeviceManagementConfigurationSettingUsage>("settingUsage", SettingUsage);
            writer.WriteEnumValue<DeviceManagementConfigurationControlType>("uxBehavior", UxBehavior);
            writer.WriteStringValue("version", Version);
            writer.WriteEnumValue<DeviceManagementConfigurationSettingVisibility>("visibility", Visibility);
        }
    }
}
