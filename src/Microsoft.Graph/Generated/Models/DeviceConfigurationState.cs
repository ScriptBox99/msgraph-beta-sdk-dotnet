using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Device Configuration State for a given device.</summary>
    public class DeviceConfigurationState : Entity, IParsable {
        /// <summary>The name of the policy for this policyBase</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>Supported platform types for policies.</summary>
        public PolicyPlatformType? PlatformType {
            get { return BackingStore?.Get<PolicyPlatformType?>("platformType"); }
            set { BackingStore?.Set("platformType", value); }
        }
        /// <summary>Count of how many setting a policy holds</summary>
        public int? SettingCount {
            get { return BackingStore?.Get<int?>("settingCount"); }
            set { BackingStore?.Set("settingCount", value); }
        }
        /// <summary>The settingStates property</summary>
        public List<DeviceConfigurationSettingState> SettingStates {
            get { return BackingStore?.Get<List<DeviceConfigurationSettingState>>("settingStates"); }
            set { BackingStore?.Set("settingStates", value); }
        }
        /// <summary>The state property</summary>
        public ComplianceStatus? State {
            get { return BackingStore?.Get<ComplianceStatus?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>User unique identifier, must be Guid</summary>
        public string UserId {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
        /// <summary>User Principal Name</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
        /// <summary>The version of the policy</summary>
        public int? Version {
            get { return BackingStore?.Get<int?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceConfigurationState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceConfigurationState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"platformType", n => { PlatformType = n.GetEnumValue<PolicyPlatformType>(); } },
                {"settingCount", n => { SettingCount = n.GetIntValue(); } },
                {"settingStates", n => { SettingStates = n.GetCollectionOfObjectValues<DeviceConfigurationSettingState>(DeviceConfigurationSettingState.CreateFromDiscriminatorValue).ToList(); } },
                {"state", n => { State = n.GetEnumValue<ComplianceStatus>(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                {"version", n => { Version = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<PolicyPlatformType>("platformType", PlatformType);
            writer.WriteIntValue("settingCount", SettingCount);
            writer.WriteCollectionOfObjectValues<DeviceConfigurationSettingState>("settingStates", SettingStates);
            writer.WriteEnumValue<ComplianceStatus>("state", State);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteIntValue("version", Version);
        }
    }
}
