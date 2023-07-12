using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// This topic provides descriptions of the declared methods, properties and relationships exposed by the AndroidDeviceOwnerCompliancePolicy resource.
    /// </summary>
    public class AndroidDeviceOwnerCompliancePolicy : DeviceCompliancePolicy, IParsable {
        /// <summary>MDATP Require Mobile Threat Protection minimum risk level to report noncompliance. Possible values are: unavailable, secured, low, medium, high, notSet.</summary>
        public DeviceThreatProtectionLevel? AdvancedThreatProtectionRequiredSecurityLevel {
            get { return BackingStore?.Get<DeviceThreatProtectionLevel?>("advancedThreatProtectionRequiredSecurityLevel"); }
            set { BackingStore?.Set("advancedThreatProtectionRequiredSecurityLevel", value); }
        }
        /// <summary>Require that devices have enabled device threat protection.</summary>
        public bool? DeviceThreatProtectionEnabled {
            get { return BackingStore?.Get<bool?>("deviceThreatProtectionEnabled"); }
            set { BackingStore?.Set("deviceThreatProtectionEnabled", value); }
        }
        /// <summary>Require Mobile Threat Protection minimum risk level to report noncompliance. Possible values are: unavailable, secured, low, medium, high, notSet.</summary>
        public DeviceThreatProtectionLevel? DeviceThreatProtectionRequiredSecurityLevel {
            get { return BackingStore?.Get<DeviceThreatProtectionLevel?>("deviceThreatProtectionRequiredSecurityLevel"); }
            set { BackingStore?.Set("deviceThreatProtectionRequiredSecurityLevel", value); }
        }
        /// <summary>Minimum Android security patch level.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinAndroidSecurityPatchLevel {
            get { return BackingStore?.Get<string?>("minAndroidSecurityPatchLevel"); }
            set { BackingStore?.Set("minAndroidSecurityPatchLevel", value); }
        }
#nullable restore
#else
        public string MinAndroidSecurityPatchLevel {
            get { return BackingStore?.Get<string>("minAndroidSecurityPatchLevel"); }
            set { BackingStore?.Set("minAndroidSecurityPatchLevel", value); }
        }
#endif
        /// <summary>Maximum Android version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsMaximumVersion {
            get { return BackingStore?.Get<string?>("osMaximumVersion"); }
            set { BackingStore?.Set("osMaximumVersion", value); }
        }
#nullable restore
#else
        public string OsMaximumVersion {
            get { return BackingStore?.Get<string>("osMaximumVersion"); }
            set { BackingStore?.Set("osMaximumVersion", value); }
        }
#endif
        /// <summary>Minimum Android version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsMinimumVersion {
            get { return BackingStore?.Get<string?>("osMinimumVersion"); }
            set { BackingStore?.Set("osMinimumVersion", value); }
        }
#nullable restore
#else
        public string OsMinimumVersion {
            get { return BackingStore?.Get<string>("osMinimumVersion"); }
            set { BackingStore?.Set("osMinimumVersion", value); }
        }
#endif
        /// <summary>Number of days before the password expires. Valid values 1 to 365</summary>
        public int? PasswordExpirationDays {
            get { return BackingStore?.Get<int?>("passwordExpirationDays"); }
            set { BackingStore?.Set("passwordExpirationDays", value); }
        }
        /// <summary>Minimum password length. Valid values 4 to 16</summary>
        public int? PasswordMinimumLength {
            get { return BackingStore?.Get<int?>("passwordMinimumLength"); }
            set { BackingStore?.Set("passwordMinimumLength", value); }
        }
        /// <summary>Indicates the minimum number of letter characters required for device password. Valid values 1 to 16</summary>
        public int? PasswordMinimumLetterCharacters {
            get { return BackingStore?.Get<int?>("passwordMinimumLetterCharacters"); }
            set { BackingStore?.Set("passwordMinimumLetterCharacters", value); }
        }
        /// <summary>Indicates the minimum number of lower case characters required for device password. Valid values 1 to 16</summary>
        public int? PasswordMinimumLowerCaseCharacters {
            get { return BackingStore?.Get<int?>("passwordMinimumLowerCaseCharacters"); }
            set { BackingStore?.Set("passwordMinimumLowerCaseCharacters", value); }
        }
        /// <summary>Indicates the minimum number of non-letter characters required for device password. Valid values 1 to 16</summary>
        public int? PasswordMinimumNonLetterCharacters {
            get { return BackingStore?.Get<int?>("passwordMinimumNonLetterCharacters"); }
            set { BackingStore?.Set("passwordMinimumNonLetterCharacters", value); }
        }
        /// <summary>Indicates the minimum number of numeric characters required for device password. Valid values 1 to 16</summary>
        public int? PasswordMinimumNumericCharacters {
            get { return BackingStore?.Get<int?>("passwordMinimumNumericCharacters"); }
            set { BackingStore?.Set("passwordMinimumNumericCharacters", value); }
        }
        /// <summary>Indicates the minimum number of symbol characters required for device password. Valid values 1 to 16</summary>
        public int? PasswordMinimumSymbolCharacters {
            get { return BackingStore?.Get<int?>("passwordMinimumSymbolCharacters"); }
            set { BackingStore?.Set("passwordMinimumSymbolCharacters", value); }
        }
        /// <summary>Indicates the minimum number of upper case letter characters required for device password. Valid values 1 to 16</summary>
        public int? PasswordMinimumUpperCaseCharacters {
            get { return BackingStore?.Get<int?>("passwordMinimumUpperCaseCharacters"); }
            set { BackingStore?.Set("passwordMinimumUpperCaseCharacters", value); }
        }
        /// <summary>Minutes of inactivity before a password is required.</summary>
        public int? PasswordMinutesOfInactivityBeforeLock {
            get { return BackingStore?.Get<int?>("passwordMinutesOfInactivityBeforeLock"); }
            set { BackingStore?.Set("passwordMinutesOfInactivityBeforeLock", value); }
        }
        /// <summary>Number of previous passwords to block. Valid values 1 to 24</summary>
        public int? PasswordPreviousPasswordCountToBlock {
            get { return BackingStore?.Get<int?>("passwordPreviousPasswordCountToBlock"); }
            set { BackingStore?.Set("passwordPreviousPasswordCountToBlock", value); }
        }
        /// <summary>Require a password to unlock device.</summary>
        public bool? PasswordRequired {
            get { return BackingStore?.Get<bool?>("passwordRequired"); }
            set { BackingStore?.Set("passwordRequired", value); }
        }
        /// <summary>Type of characters in password. Possible values are: deviceDefault, required, numeric, numericComplex, alphabetic, alphanumeric, alphanumericWithSymbols, lowSecurityBiometric, customPassword.</summary>
        public AndroidDeviceOwnerRequiredPasswordType? PasswordRequiredType {
            get { return BackingStore?.Get<AndroidDeviceOwnerRequiredPasswordType?>("passwordRequiredType"); }
            set { BackingStore?.Set("passwordRequiredType", value); }
        }
        /// <summary>If setting is set to true, checks that the Intune app installed on fully managed, dedicated, or corporate-owned work profile Android Enterprise enrolled devices, is the one provided by Microsoft from the Managed Google Playstore. If the check fails, the device will be reported as non-compliant.</summary>
        public bool? SecurityRequireIntuneAppIntegrity {
            get { return BackingStore?.Get<bool?>("securityRequireIntuneAppIntegrity"); }
            set { BackingStore?.Set("securityRequireIntuneAppIntegrity", value); }
        }
        /// <summary>Require the device to pass the SafetyNet basic integrity check.</summary>
        public bool? SecurityRequireSafetyNetAttestationBasicIntegrity {
            get { return BackingStore?.Get<bool?>("securityRequireSafetyNetAttestationBasicIntegrity"); }
            set { BackingStore?.Set("securityRequireSafetyNetAttestationBasicIntegrity", value); }
        }
        /// <summary>Require the device to pass the SafetyNet certified device check.</summary>
        public bool? SecurityRequireSafetyNetAttestationCertifiedDevice {
            get { return BackingStore?.Get<bool?>("securityRequireSafetyNetAttestationCertifiedDevice"); }
            set { BackingStore?.Set("securityRequireSafetyNetAttestationCertifiedDevice", value); }
        }
        /// <summary>Require encryption on Android devices.</summary>
        public bool? StorageRequireEncryption {
            get { return BackingStore?.Get<bool?>("storageRequireEncryption"); }
            set { BackingStore?.Set("storageRequireEncryption", value); }
        }
        /// <summary>
        /// Instantiates a new androidDeviceOwnerCompliancePolicy and sets the default values.
        /// </summary>
        public AndroidDeviceOwnerCompliancePolicy() : base() {
            OdataType = "#microsoft.graph.androidDeviceOwnerCompliancePolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AndroidDeviceOwnerCompliancePolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidDeviceOwnerCompliancePolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"advancedThreatProtectionRequiredSecurityLevel", n => { AdvancedThreatProtectionRequiredSecurityLevel = n.GetEnumValue<DeviceThreatProtectionLevel>(); } },
                {"deviceThreatProtectionEnabled", n => { DeviceThreatProtectionEnabled = n.GetBoolValue(); } },
                {"deviceThreatProtectionRequiredSecurityLevel", n => { DeviceThreatProtectionRequiredSecurityLevel = n.GetEnumValue<DeviceThreatProtectionLevel>(); } },
                {"minAndroidSecurityPatchLevel", n => { MinAndroidSecurityPatchLevel = n.GetStringValue(); } },
                {"osMaximumVersion", n => { OsMaximumVersion = n.GetStringValue(); } },
                {"osMinimumVersion", n => { OsMinimumVersion = n.GetStringValue(); } },
                {"passwordExpirationDays", n => { PasswordExpirationDays = n.GetIntValue(); } },
                {"passwordMinimumLength", n => { PasswordMinimumLength = n.GetIntValue(); } },
                {"passwordMinimumLetterCharacters", n => { PasswordMinimumLetterCharacters = n.GetIntValue(); } },
                {"passwordMinimumLowerCaseCharacters", n => { PasswordMinimumLowerCaseCharacters = n.GetIntValue(); } },
                {"passwordMinimumNonLetterCharacters", n => { PasswordMinimumNonLetterCharacters = n.GetIntValue(); } },
                {"passwordMinimumNumericCharacters", n => { PasswordMinimumNumericCharacters = n.GetIntValue(); } },
                {"passwordMinimumSymbolCharacters", n => { PasswordMinimumSymbolCharacters = n.GetIntValue(); } },
                {"passwordMinimumUpperCaseCharacters", n => { PasswordMinimumUpperCaseCharacters = n.GetIntValue(); } },
                {"passwordMinutesOfInactivityBeforeLock", n => { PasswordMinutesOfInactivityBeforeLock = n.GetIntValue(); } },
                {"passwordPreviousPasswordCountToBlock", n => { PasswordPreviousPasswordCountToBlock = n.GetIntValue(); } },
                {"passwordRequired", n => { PasswordRequired = n.GetBoolValue(); } },
                {"passwordRequiredType", n => { PasswordRequiredType = n.GetEnumValue<AndroidDeviceOwnerRequiredPasswordType>(); } },
                {"securityRequireIntuneAppIntegrity", n => { SecurityRequireIntuneAppIntegrity = n.GetBoolValue(); } },
                {"securityRequireSafetyNetAttestationBasicIntegrity", n => { SecurityRequireSafetyNetAttestationBasicIntegrity = n.GetBoolValue(); } },
                {"securityRequireSafetyNetAttestationCertifiedDevice", n => { SecurityRequireSafetyNetAttestationCertifiedDevice = n.GetBoolValue(); } },
                {"storageRequireEncryption", n => { StorageRequireEncryption = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<DeviceThreatProtectionLevel>("advancedThreatProtectionRequiredSecurityLevel", AdvancedThreatProtectionRequiredSecurityLevel);
            writer.WriteBoolValue("deviceThreatProtectionEnabled", DeviceThreatProtectionEnabled);
            writer.WriteEnumValue<DeviceThreatProtectionLevel>("deviceThreatProtectionRequiredSecurityLevel", DeviceThreatProtectionRequiredSecurityLevel);
            writer.WriteStringValue("minAndroidSecurityPatchLevel", MinAndroidSecurityPatchLevel);
            writer.WriteStringValue("osMaximumVersion", OsMaximumVersion);
            writer.WriteStringValue("osMinimumVersion", OsMinimumVersion);
            writer.WriteIntValue("passwordExpirationDays", PasswordExpirationDays);
            writer.WriteIntValue("passwordMinimumLength", PasswordMinimumLength);
            writer.WriteIntValue("passwordMinimumLetterCharacters", PasswordMinimumLetterCharacters);
            writer.WriteIntValue("passwordMinimumLowerCaseCharacters", PasswordMinimumLowerCaseCharacters);
            writer.WriteIntValue("passwordMinimumNonLetterCharacters", PasswordMinimumNonLetterCharacters);
            writer.WriteIntValue("passwordMinimumNumericCharacters", PasswordMinimumNumericCharacters);
            writer.WriteIntValue("passwordMinimumSymbolCharacters", PasswordMinimumSymbolCharacters);
            writer.WriteIntValue("passwordMinimumUpperCaseCharacters", PasswordMinimumUpperCaseCharacters);
            writer.WriteIntValue("passwordMinutesOfInactivityBeforeLock", PasswordMinutesOfInactivityBeforeLock);
            writer.WriteIntValue("passwordPreviousPasswordCountToBlock", PasswordPreviousPasswordCountToBlock);
            writer.WriteBoolValue("passwordRequired", PasswordRequired);
            writer.WriteEnumValue<AndroidDeviceOwnerRequiredPasswordType>("passwordRequiredType", PasswordRequiredType);
            writer.WriteBoolValue("securityRequireIntuneAppIntegrity", SecurityRequireIntuneAppIntegrity);
            writer.WriteBoolValue("securityRequireSafetyNetAttestationBasicIntegrity", SecurityRequireSafetyNetAttestationBasicIntegrity);
            writer.WriteBoolValue("securityRequireSafetyNetAttestationCertifiedDevice", SecurityRequireSafetyNetAttestationCertifiedDevice);
            writer.WriteBoolValue("storageRequireEncryption", StorageRequireEncryption);
        }
    }
}
