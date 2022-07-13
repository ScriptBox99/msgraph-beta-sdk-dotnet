using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The Group Policy setting to MDM/Intune mapping.</summary>
    public class GroupPolicySettingMapping : Entity, IParsable {
        /// <summary>Admx Group Policy Id</summary>
        public string AdmxSettingDefinitionId {
            get { return BackingStore?.Get<string>("admxSettingDefinitionId"); }
            set { BackingStore?.Set("admxSettingDefinitionId", value); }
        }
        /// <summary>List of Child Ids of the group policy setting.</summary>
        public List<string> ChildIdList {
            get { return BackingStore?.Get<List<string>>("childIdList"); }
            set { BackingStore?.Set("childIdList", value); }
        }
        /// <summary>The Intune Setting Definition Id</summary>
        public string IntuneSettingDefinitionId {
            get { return BackingStore?.Get<string>("intuneSettingDefinitionId"); }
            set { BackingStore?.Set("intuneSettingDefinitionId", value); }
        }
        /// <summary>The list of Intune Setting URIs this group policy setting maps to</summary>
        public List<string> IntuneSettingUriList {
            get { return BackingStore?.Get<List<string>>("intuneSettingUriList"); }
            set { BackingStore?.Set("intuneSettingUriList", value); }
        }
        /// <summary>Indicates if the setting is supported by Intune or not</summary>
        public bool? IsMdmSupported {
            get { return BackingStore?.Get<bool?>("isMdmSupported"); }
            set { BackingStore?.Set("isMdmSupported", value); }
        }
        /// <summary>The CSP name this group policy setting maps to.</summary>
        public string MdmCspName {
            get { return BackingStore?.Get<string>("mdmCspName"); }
            set { BackingStore?.Set("mdmCspName", value); }
        }
        /// <summary>The minimum OS version this mdm setting supports.</summary>
        public int? MdmMinimumOSVersion {
            get { return BackingStore?.Get<int?>("mdmMinimumOSVersion"); }
            set { BackingStore?.Set("mdmMinimumOSVersion", value); }
        }
        /// <summary>The MDM CSP URI this group policy setting maps to.</summary>
        public string MdmSettingUri {
            get { return BackingStore?.Get<string>("mdmSettingUri"); }
            set { BackingStore?.Set("mdmSettingUri", value); }
        }
        /// <summary>Mdm Support Status of the setting.</summary>
        public Microsoft.Graph.Beta.Models.MdmSupportedState? MdmSupportedState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MdmSupportedState?>("mdmSupportedState"); }
            set { BackingStore?.Set("mdmSupportedState", value); }
        }
        /// <summary>Parent Id of the group policy setting.</summary>
        public string ParentId {
            get { return BackingStore?.Get<string>("parentId"); }
            set { BackingStore?.Set("parentId", value); }
        }
        /// <summary>The category the group policy setting is in.</summary>
        public string SettingCategory {
            get { return BackingStore?.Get<string>("settingCategory"); }
            set { BackingStore?.Set("settingCategory", value); }
        }
        /// <summary>The display name of this group policy setting.</summary>
        public string SettingDisplayName {
            get { return BackingStore?.Get<string>("settingDisplayName"); }
            set { BackingStore?.Set("settingDisplayName", value); }
        }
        /// <summary>The display value of this group policy setting.</summary>
        public string SettingDisplayValue {
            get { return BackingStore?.Get<string>("settingDisplayValue"); }
            set { BackingStore?.Set("settingDisplayValue", value); }
        }
        /// <summary>The display value type of this group policy setting.</summary>
        public string SettingDisplayValueType {
            get { return BackingStore?.Get<string>("settingDisplayValueType"); }
            set { BackingStore?.Set("settingDisplayValueType", value); }
        }
        /// <summary>The name of this group policy setting.</summary>
        public string SettingName {
            get { return BackingStore?.Get<string>("settingName"); }
            set { BackingStore?.Set("settingName", value); }
        }
        /// <summary>Scope of the group policy setting.</summary>
        public GroupPolicySettingScope? SettingScope {
            get { return BackingStore?.Get<GroupPolicySettingScope?>("settingScope"); }
            set { BackingStore?.Set("settingScope", value); }
        }
        /// <summary>Setting type of the group policy.</summary>
        public GroupPolicySettingType? SettingType {
            get { return BackingStore?.Get<GroupPolicySettingType?>("settingType"); }
            set { BackingStore?.Set("settingType", value); }
        }
        /// <summary>The value of this group policy setting.</summary>
        public string SettingValue {
            get { return BackingStore?.Get<string>("settingValue"); }
            set { BackingStore?.Set("settingValue", value); }
        }
        /// <summary>The display units of this group policy setting value</summary>
        public string SettingValueDisplayUnits {
            get { return BackingStore?.Get<string>("settingValueDisplayUnits"); }
            set { BackingStore?.Set("settingValueDisplayUnits", value); }
        }
        /// <summary>The value type of this group policy setting.</summary>
        public string SettingValueType {
            get { return BackingStore?.Get<string>("settingValueType"); }
            set { BackingStore?.Set("settingValueType", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new GroupPolicySettingMapping CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GroupPolicySettingMapping();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"admxSettingDefinitionId", n => { AdmxSettingDefinitionId = n.GetStringValue(); } },
                {"childIdList", n => { ChildIdList = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"intuneSettingDefinitionId", n => { IntuneSettingDefinitionId = n.GetStringValue(); } },
                {"intuneSettingUriList", n => { IntuneSettingUriList = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"isMdmSupported", n => { IsMdmSupported = n.GetBoolValue(); } },
                {"mdmCspName", n => { MdmCspName = n.GetStringValue(); } },
                {"mdmMinimumOSVersion", n => { MdmMinimumOSVersion = n.GetIntValue(); } },
                {"mdmSettingUri", n => { MdmSettingUri = n.GetStringValue(); } },
                {"mdmSupportedState", n => { MdmSupportedState = n.GetEnumValue<MdmSupportedState>(); } },
                {"parentId", n => { ParentId = n.GetStringValue(); } },
                {"settingCategory", n => { SettingCategory = n.GetStringValue(); } },
                {"settingDisplayName", n => { SettingDisplayName = n.GetStringValue(); } },
                {"settingDisplayValue", n => { SettingDisplayValue = n.GetStringValue(); } },
                {"settingDisplayValueType", n => { SettingDisplayValueType = n.GetStringValue(); } },
                {"settingName", n => { SettingName = n.GetStringValue(); } },
                {"settingScope", n => { SettingScope = n.GetEnumValue<GroupPolicySettingScope>(); } },
                {"settingType", n => { SettingType = n.GetEnumValue<GroupPolicySettingType>(); } },
                {"settingValue", n => { SettingValue = n.GetStringValue(); } },
                {"settingValueDisplayUnits", n => { SettingValueDisplayUnits = n.GetStringValue(); } },
                {"settingValueType", n => { SettingValueType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("admxSettingDefinitionId", AdmxSettingDefinitionId);
            writer.WriteCollectionOfPrimitiveValues<string>("childIdList", ChildIdList);
            writer.WriteStringValue("intuneSettingDefinitionId", IntuneSettingDefinitionId);
            writer.WriteCollectionOfPrimitiveValues<string>("intuneSettingUriList", IntuneSettingUriList);
            writer.WriteBoolValue("isMdmSupported", IsMdmSupported);
            writer.WriteStringValue("mdmCspName", MdmCspName);
            writer.WriteIntValue("mdmMinimumOSVersion", MdmMinimumOSVersion);
            writer.WriteStringValue("mdmSettingUri", MdmSettingUri);
            writer.WriteEnumValue<MdmSupportedState>("mdmSupportedState", MdmSupportedState);
            writer.WriteStringValue("parentId", ParentId);
            writer.WriteStringValue("settingCategory", SettingCategory);
            writer.WriteStringValue("settingDisplayName", SettingDisplayName);
            writer.WriteStringValue("settingDisplayValue", SettingDisplayValue);
            writer.WriteStringValue("settingDisplayValueType", SettingDisplayValueType);
            writer.WriteStringValue("settingName", SettingName);
            writer.WriteEnumValue<GroupPolicySettingScope>("settingScope", SettingScope);
            writer.WriteEnumValue<GroupPolicySettingType>("settingType", SettingType);
            writer.WriteStringValue("settingValue", SettingValue);
            writer.WriteStringValue("settingValueDisplayUnits", SettingValueDisplayUnits);
            writer.WriteStringValue("settingValueType", SettingValueType);
        }
    }
}
