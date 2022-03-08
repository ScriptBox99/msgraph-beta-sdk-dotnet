using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class AdvancedThreatProtectionOnboardingDeviceSettingState : Entity, IParsable {
        /// <summary>The DateTime when device compliance grace period expires</summary>
        public DateTimeOffset? ComplianceGracePeriodExpirationDateTime { get; set; }
        /// <summary>The Device Id that is being reported</summary>
        public string DeviceId { get; set; }
        /// <summary>The device model that is being reported</summary>
        public string DeviceModel { get; set; }
        /// <summary>The Device Name that is being reported</summary>
        public string DeviceName { get; set; }
        /// <summary>Device platform type. Possible values are: desktop, windowsRT, winMO6, nokia, windowsPhone, mac, winCE, winEmbedded, iPhone, iPad, iPod, android, iSocConsumer, unix, macMDM, holoLens, surfaceHub, androidForWork, androidEnterprise, windows10x, androidnGMS, cloudPC, blackberry, palm, unknown.</summary>
        public DeviceType? PlatformType { get; set; }
        /// <summary>The setting class name and property name.</summary>
        public string Setting { get; set; }
        /// <summary>The Setting Name that is being reported</summary>
        public string SettingName { get; set; }
        /// <summary>The compliance state of the setting. Possible values are: unknown, notApplicable, compliant, remediated, nonCompliant, error, conflict, notAssigned.</summary>
        public ComplianceStatus? State { get; set; }
        /// <summary>The User email address that is being reported</summary>
        public string UserEmail { get; set; }
        /// <summary>The user Id that is being reported</summary>
        public string UserId { get; set; }
        /// <summary>The User Name that is being reported</summary>
        public string UserName { get; set; }
        /// <summary>The User PrincipalName that is being reported</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AdvancedThreatProtectionOnboardingDeviceSettingState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AdvancedThreatProtectionOnboardingDeviceSettingState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"complianceGracePeriodExpirationDateTime", (o,n) => { (o as AdvancedThreatProtectionOnboardingDeviceSettingState).ComplianceGracePeriodExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"deviceId", (o,n) => { (o as AdvancedThreatProtectionOnboardingDeviceSettingState).DeviceId = n.GetStringValue(); } },
                {"deviceModel", (o,n) => { (o as AdvancedThreatProtectionOnboardingDeviceSettingState).DeviceModel = n.GetStringValue(); } },
                {"deviceName", (o,n) => { (o as AdvancedThreatProtectionOnboardingDeviceSettingState).DeviceName = n.GetStringValue(); } },
                {"platformType", (o,n) => { (o as AdvancedThreatProtectionOnboardingDeviceSettingState).PlatformType = n.GetEnumValue<DeviceType>(); } },
                {"setting", (o,n) => { (o as AdvancedThreatProtectionOnboardingDeviceSettingState).Setting = n.GetStringValue(); } },
                {"settingName", (o,n) => { (o as AdvancedThreatProtectionOnboardingDeviceSettingState).SettingName = n.GetStringValue(); } },
                {"state", (o,n) => { (o as AdvancedThreatProtectionOnboardingDeviceSettingState).State = n.GetEnumValue<ComplianceStatus>(); } },
                {"userEmail", (o,n) => { (o as AdvancedThreatProtectionOnboardingDeviceSettingState).UserEmail = n.GetStringValue(); } },
                {"userId", (o,n) => { (o as AdvancedThreatProtectionOnboardingDeviceSettingState).UserId = n.GetStringValue(); } },
                {"userName", (o,n) => { (o as AdvancedThreatProtectionOnboardingDeviceSettingState).UserName = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as AdvancedThreatProtectionOnboardingDeviceSettingState).UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("complianceGracePeriodExpirationDateTime", ComplianceGracePeriodExpirationDateTime);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceModel", DeviceModel);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteEnumValue<DeviceType>("platformType", PlatformType);
            writer.WriteStringValue("setting", Setting);
            writer.WriteStringValue("settingName", SettingName);
            writer.WriteEnumValue<ComplianceStatus>("state", State);
            writer.WriteStringValue("userEmail", UserEmail);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userName", UserName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
