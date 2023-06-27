using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class DefaultManagedAppProtection : ManagedAppProtection, IParsable {
        /// <summary>Semicolon seperated list of device manufacturers allowed, as a string, for the managed app to work. (Android only)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AllowedAndroidDeviceManufacturers {
            get { return BackingStore?.Get<string?>("allowedAndroidDeviceManufacturers"); }
            set { BackingStore?.Set("allowedAndroidDeviceManufacturers", value); }
        }
#nullable restore
#else
        public string AllowedAndroidDeviceManufacturers {
            get { return BackingStore?.Get<string>("allowedAndroidDeviceManufacturers"); }
            set { BackingStore?.Set("allowedAndroidDeviceManufacturers", value); }
        }
#endif
        /// <summary>List of device models allowed, as a string, for the managed app to work. (Android Only)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AllowedAndroidDeviceModels {
            get { return BackingStore?.Get<List<string>?>("allowedAndroidDeviceModels"); }
            set { BackingStore?.Set("allowedAndroidDeviceModels", value); }
        }
#nullable restore
#else
        public List<string> AllowedAndroidDeviceModels {
            get { return BackingStore?.Get<List<string>>("allowedAndroidDeviceModels"); }
            set { BackingStore?.Set("allowedAndroidDeviceModels", value); }
        }
#endif
        /// <summary>Semicolon seperated list of device models allowed, as a string, for the managed app to work. (iOS Only)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AllowedIosDeviceModels {
            get { return BackingStore?.Get<string?>("allowedIosDeviceModels"); }
            set { BackingStore?.Set("allowedIosDeviceModels", value); }
        }
#nullable restore
#else
        public string AllowedIosDeviceModels {
            get { return BackingStore?.Get<string>("allowedIosDeviceModels"); }
            set { BackingStore?.Set("allowedIosDeviceModels", value); }
        }
#endif
        /// <summary>Defines a managed app behavior, either block or warn, if the user is clocked out (non-working time). Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfAccountIsClockedOut {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>("appActionIfAccountIsClockedOut"); }
            set { BackingStore?.Set("appActionIfAccountIsClockedOut", value); }
        }
        /// <summary>An admin initiated action to be applied on a managed app.</summary>
        public ManagedAppRemediationAction? AppActionIfAndroidDeviceManufacturerNotAllowed {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>("appActionIfAndroidDeviceManufacturerNotAllowed"); }
            set { BackingStore?.Set("appActionIfAndroidDeviceManufacturerNotAllowed", value); }
        }
        /// <summary>An admin initiated action to be applied on a managed app.</summary>
        public ManagedAppRemediationAction? AppActionIfAndroidDeviceModelNotAllowed {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>("appActionIfAndroidDeviceModelNotAllowed"); }
            set { BackingStore?.Set("appActionIfAndroidDeviceModelNotAllowed", value); }
        }
        /// <summary>An admin initiated action to be applied on a managed app.</summary>
        public ManagedAppRemediationAction? AppActionIfAndroidSafetyNetAppsVerificationFailed {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>("appActionIfAndroidSafetyNetAppsVerificationFailed"); }
            set { BackingStore?.Set("appActionIfAndroidSafetyNetAppsVerificationFailed", value); }
        }
        /// <summary>An admin initiated action to be applied on a managed app.</summary>
        public ManagedAppRemediationAction? AppActionIfAndroidSafetyNetDeviceAttestationFailed {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>("appActionIfAndroidSafetyNetDeviceAttestationFailed"); }
            set { BackingStore?.Set("appActionIfAndroidSafetyNetDeviceAttestationFailed", value); }
        }
        /// <summary>An admin initiated action to be applied on a managed app.</summary>
        public ManagedAppRemediationAction? AppActionIfDeviceLockNotSet {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>("appActionIfDeviceLockNotSet"); }
            set { BackingStore?.Set("appActionIfDeviceLockNotSet", value); }
        }
        /// <summary>If the device does not have a passcode of high complexity or higher, trigger the stored action. Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfDevicePasscodeComplexityLessThanHigh {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>("appActionIfDevicePasscodeComplexityLessThanHigh"); }
            set { BackingStore?.Set("appActionIfDevicePasscodeComplexityLessThanHigh", value); }
        }
        /// <summary>If the device does not have a passcode of low complexity or higher, trigger the stored action. Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfDevicePasscodeComplexityLessThanLow {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>("appActionIfDevicePasscodeComplexityLessThanLow"); }
            set { BackingStore?.Set("appActionIfDevicePasscodeComplexityLessThanLow", value); }
        }
        /// <summary>If the device does not have a passcode of medium complexity or higher, trigger the stored action. Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfDevicePasscodeComplexityLessThanMedium {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>("appActionIfDevicePasscodeComplexityLessThanMedium"); }
            set { BackingStore?.Set("appActionIfDevicePasscodeComplexityLessThanMedium", value); }
        }
        /// <summary>An admin initiated action to be applied on a managed app.</summary>
        public ManagedAppRemediationAction? AppActionIfIosDeviceModelNotAllowed {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>("appActionIfIosDeviceModelNotAllowed"); }
            set { BackingStore?.Set("appActionIfIosDeviceModelNotAllowed", value); }
        }
        /// <summary>Represents the level to which app data is encrypted for managed apps</summary>
        public ManagedAppDataEncryptionType? AppDataEncryptionType {
            get { return BackingStore?.Get<ManagedAppDataEncryptionType?>("appDataEncryptionType"); }
            set { BackingStore?.Set("appDataEncryptionType", value); }
        }
        /// <summary>List of apps to which the policy is deployed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedMobileApp>? Apps {
            get { return BackingStore?.Get<List<ManagedMobileApp>?>("apps"); }
            set { BackingStore?.Set("apps", value); }
        }
#nullable restore
#else
        public List<ManagedMobileApp> Apps {
            get { return BackingStore?.Get<List<ManagedMobileApp>>("apps"); }
            set { BackingStore?.Set("apps", value); }
        }
#endif
        /// <summary>Indicates whether use of the biometric authentication is allowed in place of a pin if PinRequired is set to True. (Android Only)</summary>
        public bool? BiometricAuthenticationBlocked {
            get { return BackingStore?.Get<bool?>("biometricAuthenticationBlocked"); }
            set { BackingStore?.Set("biometricAuthenticationBlocked", value); }
        }
        /// <summary>Maximum number of days Company Portal update can be deferred on the device or app access will be blocked.</summary>
        public int? BlockAfterCompanyPortalUpdateDeferralInDays {
            get { return BackingStore?.Get<int?>("blockAfterCompanyPortalUpdateDeferralInDays"); }
            set { BackingStore?.Set("blockAfterCompanyPortalUpdateDeferralInDays", value); }
        }
        /// <summary>Whether the app should connect to the configured VPN on launch (Android only).</summary>
        public bool? ConnectToVpnOnLaunch {
            get { return BackingStore?.Get<bool?>("connectToVpnOnLaunch"); }
            set { BackingStore?.Set("connectToVpnOnLaunch", value); }
        }
        /// <summary>Friendly name of the preferred custom browser to open weblink on Android. (Android only)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomBrowserDisplayName {
            get { return BackingStore?.Get<string?>("customBrowserDisplayName"); }
            set { BackingStore?.Set("customBrowserDisplayName", value); }
        }
#nullable restore
#else
        public string CustomBrowserDisplayName {
            get { return BackingStore?.Get<string>("customBrowserDisplayName"); }
            set { BackingStore?.Set("customBrowserDisplayName", value); }
        }
#endif
        /// <summary>Unique identifier of a custom browser to open weblink on Android. (Android only)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomBrowserPackageId {
            get { return BackingStore?.Get<string?>("customBrowserPackageId"); }
            set { BackingStore?.Set("customBrowserPackageId", value); }
        }
#nullable restore
#else
        public string CustomBrowserPackageId {
            get { return BackingStore?.Get<string>("customBrowserPackageId"); }
            set { BackingStore?.Set("customBrowserPackageId", value); }
        }
#endif
        /// <summary>A custom browser protocol to open weblink on iOS. (iOS only)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomBrowserProtocol {
            get { return BackingStore?.Get<string?>("customBrowserProtocol"); }
            set { BackingStore?.Set("customBrowserProtocol", value); }
        }
#nullable restore
#else
        public string CustomBrowserProtocol {
            get { return BackingStore?.Get<string>("customBrowserProtocol"); }
            set { BackingStore?.Set("customBrowserProtocol", value); }
        }
#endif
        /// <summary>Friendly name of a custom dialer app to click-to-open a phone number on Android.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomDialerAppDisplayName {
            get { return BackingStore?.Get<string?>("customDialerAppDisplayName"); }
            set { BackingStore?.Set("customDialerAppDisplayName", value); }
        }
#nullable restore
#else
        public string CustomDialerAppDisplayName {
            get { return BackingStore?.Get<string>("customDialerAppDisplayName"); }
            set { BackingStore?.Set("customDialerAppDisplayName", value); }
        }
#endif
        /// <summary>PackageId of a custom dialer app to click-to-open a phone number on Android.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomDialerAppPackageId {
            get { return BackingStore?.Get<string?>("customDialerAppPackageId"); }
            set { BackingStore?.Set("customDialerAppPackageId", value); }
        }
#nullable restore
#else
        public string CustomDialerAppPackageId {
            get { return BackingStore?.Get<string>("customDialerAppPackageId"); }
            set { BackingStore?.Set("customDialerAppPackageId", value); }
        }
#endif
        /// <summary>Protocol of a custom dialer app to click-to-open a phone number on iOS, for example, skype:.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomDialerAppProtocol {
            get { return BackingStore?.Get<string?>("customDialerAppProtocol"); }
            set { BackingStore?.Set("customDialerAppProtocol", value); }
        }
#nullable restore
#else
        public string CustomDialerAppProtocol {
            get { return BackingStore?.Get<string>("customDialerAppProtocol"); }
            set { BackingStore?.Set("customDialerAppProtocol", value); }
        }
#endif
        /// <summary>A set of string key and string value pairs to be sent to the affected users, unalterned by this service</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValuePair>? CustomSettings {
            get { return BackingStore?.Get<List<KeyValuePair>?>("customSettings"); }
            set { BackingStore?.Set("customSettings", value); }
        }
#nullable restore
#else
        public List<KeyValuePair> CustomSettings {
            get { return BackingStore?.Get<List<KeyValuePair>>("customSettings"); }
            set { BackingStore?.Set("customSettings", value); }
        }
#endif
        /// <summary>Count of apps to which the current policy is deployed.</summary>
        public int? DeployedAppCount {
            get { return BackingStore?.Get<int?>("deployedAppCount"); }
            set { BackingStore?.Set("deployedAppCount", value); }
        }
        /// <summary>Navigation property to deployment summary of the configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ManagedAppPolicyDeploymentSummary? DeploymentSummary {
            get { return BackingStore?.Get<ManagedAppPolicyDeploymentSummary?>("deploymentSummary"); }
            set { BackingStore?.Set("deploymentSummary", value); }
        }
#nullable restore
#else
        public ManagedAppPolicyDeploymentSummary DeploymentSummary {
            get { return BackingStore?.Get<ManagedAppPolicyDeploymentSummary>("deploymentSummary"); }
            set { BackingStore?.Set("deploymentSummary", value); }
        }
#endif
        /// <summary>Defines if any kind of lock must be required on device. (android only)</summary>
        public bool? DeviceLockRequired {
            get { return BackingStore?.Get<bool?>("deviceLockRequired"); }
            set { BackingStore?.Set("deviceLockRequired", value); }
        }
        /// <summary>When this setting is enabled, app level encryption is disabled if device level encryption is enabled. (Android only)</summary>
        public bool? DisableAppEncryptionIfDeviceEncryptionIsEnabled {
            get { return BackingStore?.Get<bool?>("disableAppEncryptionIfDeviceEncryptionIsEnabled"); }
            set { BackingStore?.Set("disableAppEncryptionIfDeviceEncryptionIsEnabled", value); }
        }
        /// <summary>Disable protection of data transferred to other apps through IOS OpenIn option. This setting is only allowed to be True when AllowedOutboundDataTransferDestinations is set to ManagedApps. (iOS Only)</summary>
        public bool? DisableProtectionOfManagedOutboundOpenInData {
            get { return BackingStore?.Get<bool?>("disableProtectionOfManagedOutboundOpenInData"); }
            set { BackingStore?.Set("disableProtectionOfManagedOutboundOpenInData", value); }
        }
        /// <summary>Indicates whether managed-app data should be encrypted. (Android only)</summary>
        public bool? EncryptAppData {
            get { return BackingStore?.Get<bool?>("encryptAppData"); }
            set { BackingStore?.Set("encryptAppData", value); }
        }
        /// <summary>Android App packages in this list will be exempt from the policy and will be able to receive data from managed apps. (Android only)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValuePair>? ExemptedAppPackages {
            get { return BackingStore?.Get<List<KeyValuePair>?>("exemptedAppPackages"); }
            set { BackingStore?.Set("exemptedAppPackages", value); }
        }
#nullable restore
#else
        public List<KeyValuePair> ExemptedAppPackages {
            get { return BackingStore?.Get<List<KeyValuePair>>("exemptedAppPackages"); }
            set { BackingStore?.Set("exemptedAppPackages", value); }
        }
#endif
        /// <summary>iOS Apps in this list will be exempt from the policy and will be able to receive data from managed apps. (iOS Only)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValuePair>? ExemptedAppProtocols {
            get { return BackingStore?.Get<List<KeyValuePair>?>("exemptedAppProtocols"); }
            set { BackingStore?.Set("exemptedAppProtocols", value); }
        }
#nullable restore
#else
        public List<KeyValuePair> ExemptedAppProtocols {
            get { return BackingStore?.Get<List<KeyValuePair>>("exemptedAppProtocols"); }
            set { BackingStore?.Set("exemptedAppProtocols", value); }
        }
#endif
        /// <summary>Indicates whether use of the FaceID is allowed in place of a pin if PinRequired is set to True. (iOS Only)</summary>
        public bool? FaceIdBlocked {
            get { return BackingStore?.Get<bool?>("faceIdBlocked"); }
            set { BackingStore?.Set("faceIdBlocked", value); }
        }
        /// <summary>Defines if open-in operation is supported from the managed app to the filesharing locations selected. This setting only applies when AllowedOutboundDataTransferDestinations is set to ManagedApps and DisableProtectionOfManagedOutboundOpenInData is set to False. (iOS Only)</summary>
        public bool? FilterOpenInToOnlyManagedApps {
            get { return BackingStore?.Get<bool?>("filterOpenInToOnlyManagedApps"); }
            set { BackingStore?.Set("filterOpenInToOnlyManagedApps", value); }
        }
        /// <summary>Indicate to the client to enable both biometrics and fingerprints for the app.</summary>
        public bool? FingerprintAndBiometricEnabled {
            get { return BackingStore?.Get<bool?>("fingerprintAndBiometricEnabled"); }
            set { BackingStore?.Set("fingerprintAndBiometricEnabled", value); }
        }
        /// <summary>Minimum version of the Company portal that must be installed on the device or app access will be blocked</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumRequiredCompanyPortalVersion {
            get { return BackingStore?.Get<string?>("minimumRequiredCompanyPortalVersion"); }
            set { BackingStore?.Set("minimumRequiredCompanyPortalVersion", value); }
        }
#nullable restore
#else
        public string MinimumRequiredCompanyPortalVersion {
            get { return BackingStore?.Get<string>("minimumRequiredCompanyPortalVersion"); }
            set { BackingStore?.Set("minimumRequiredCompanyPortalVersion", value); }
        }
#endif
        /// <summary>Define the oldest required Android security patch level a user can have to gain secure access to the app. (Android only)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumRequiredPatchVersion {
            get { return BackingStore?.Get<string?>("minimumRequiredPatchVersion"); }
            set { BackingStore?.Set("minimumRequiredPatchVersion", value); }
        }
#nullable restore
#else
        public string MinimumRequiredPatchVersion {
            get { return BackingStore?.Get<string>("minimumRequiredPatchVersion"); }
            set { BackingStore?.Set("minimumRequiredPatchVersion", value); }
        }
#endif
        /// <summary>Versions less than the specified version will block the managed app from accessing company data. (iOS Only)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumRequiredSdkVersion {
            get { return BackingStore?.Get<string?>("minimumRequiredSdkVersion"); }
            set { BackingStore?.Set("minimumRequiredSdkVersion", value); }
        }
#nullable restore
#else
        public string MinimumRequiredSdkVersion {
            get { return BackingStore?.Get<string>("minimumRequiredSdkVersion"); }
            set { BackingStore?.Set("minimumRequiredSdkVersion", value); }
        }
#endif
        /// <summary>Minimum version of the Company portal that must be installed on the device or the user will receive a warning</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumWarningCompanyPortalVersion {
            get { return BackingStore?.Get<string?>("minimumWarningCompanyPortalVersion"); }
            set { BackingStore?.Set("minimumWarningCompanyPortalVersion", value); }
        }
#nullable restore
#else
        public string MinimumWarningCompanyPortalVersion {
            get { return BackingStore?.Get<string>("minimumWarningCompanyPortalVersion"); }
            set { BackingStore?.Set("minimumWarningCompanyPortalVersion", value); }
        }
#endif
        /// <summary>Define the oldest recommended Android security patch level a user can have for secure access to the app. (Android only)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumWarningPatchVersion {
            get { return BackingStore?.Get<string?>("minimumWarningPatchVersion"); }
            set { BackingStore?.Set("minimumWarningPatchVersion", value); }
        }
#nullable restore
#else
        public string MinimumWarningPatchVersion {
            get { return BackingStore?.Get<string>("minimumWarningPatchVersion"); }
            set { BackingStore?.Set("minimumWarningPatchVersion", value); }
        }
#endif
        /// <summary>Versions less than the specified version will result in warning message on the managed app from accessing company data. (iOS only)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumWarningSdkVersion {
            get { return BackingStore?.Get<string?>("minimumWarningSdkVersion"); }
            set { BackingStore?.Set("minimumWarningSdkVersion", value); }
        }
#nullable restore
#else
        public string MinimumWarningSdkVersion {
            get { return BackingStore?.Get<string>("minimumWarningSdkVersion"); }
            set { BackingStore?.Set("minimumWarningSdkVersion", value); }
        }
#endif
        /// <summary>Minimum version of the Company portal that must be installed on the device or the company data on the app will be wiped</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumWipeCompanyPortalVersion {
            get { return BackingStore?.Get<string?>("minimumWipeCompanyPortalVersion"); }
            set { BackingStore?.Set("minimumWipeCompanyPortalVersion", value); }
        }
#nullable restore
#else
        public string MinimumWipeCompanyPortalVersion {
            get { return BackingStore?.Get<string>("minimumWipeCompanyPortalVersion"); }
            set { BackingStore?.Set("minimumWipeCompanyPortalVersion", value); }
        }
#endif
        /// <summary>Android security patch level  less than or equal to the specified value will wipe the managed app and the associated company data. (Android only)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumWipePatchVersion {
            get { return BackingStore?.Get<string?>("minimumWipePatchVersion"); }
            set { BackingStore?.Set("minimumWipePatchVersion", value); }
        }
#nullable restore
#else
        public string MinimumWipePatchVersion {
            get { return BackingStore?.Get<string>("minimumWipePatchVersion"); }
            set { BackingStore?.Set("minimumWipePatchVersion", value); }
        }
#endif
        /// <summary>Versions less than the specified version will block the managed app from accessing company data.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumWipeSdkVersion {
            get { return BackingStore?.Get<string?>("minimumWipeSdkVersion"); }
            set { BackingStore?.Set("minimumWipeSdkVersion", value); }
        }
#nullable restore
#else
        public string MinimumWipeSdkVersion {
            get { return BackingStore?.Get<string>("minimumWipeSdkVersion"); }
            set { BackingStore?.Set("minimumWipeSdkVersion", value); }
        }
#endif
        /// <summary>Protect incoming data from unknown source. This setting is only allowed to be True when AllowedInboundDataTransferSources is set to AllApps. (iOS Only)</summary>
        public bool? ProtectInboundDataFromUnknownSources {
            get { return BackingStore?.Get<bool?>("protectInboundDataFromUnknownSources"); }
            set { BackingStore?.Set("protectInboundDataFromUnknownSources", value); }
        }
        /// <summary>Require user to apply Class 3 Biometrics on their Android device.</summary>
        public bool? RequireClass3Biometrics {
            get { return BackingStore?.Get<bool?>("requireClass3Biometrics"); }
            set { BackingStore?.Set("requireClass3Biometrics", value); }
        }
        /// <summary>An admin enforced Android SafetyNet Device Attestation requirement on a managed app.</summary>
        public AndroidManagedAppSafetyNetAppsVerificationType? RequiredAndroidSafetyNetAppsVerificationType {
            get { return BackingStore?.Get<AndroidManagedAppSafetyNetAppsVerificationType?>("requiredAndroidSafetyNetAppsVerificationType"); }
            set { BackingStore?.Set("requiredAndroidSafetyNetAppsVerificationType", value); }
        }
        /// <summary>An admin enforced Android SafetyNet Device Attestation requirement on a managed app.</summary>
        public AndroidManagedAppSafetyNetDeviceAttestationType? RequiredAndroidSafetyNetDeviceAttestationType {
            get { return BackingStore?.Get<AndroidManagedAppSafetyNetDeviceAttestationType?>("requiredAndroidSafetyNetDeviceAttestationType"); }
            set { BackingStore?.Set("requiredAndroidSafetyNetDeviceAttestationType", value); }
        }
        /// <summary>An admin enforced Android SafetyNet evaluation type requirement on a managed app.</summary>
        public AndroidManagedAppSafetyNetEvaluationType? RequiredAndroidSafetyNetEvaluationType {
            get { return BackingStore?.Get<AndroidManagedAppSafetyNetEvaluationType?>("requiredAndroidSafetyNetEvaluationType"); }
            set { BackingStore?.Set("requiredAndroidSafetyNetEvaluationType", value); }
        }
        /// <summary>A PIN prompt will override biometric prompts if class 3 biometrics are updated on the device.</summary>
        public bool? RequirePinAfterBiometricChange {
            get { return BackingStore?.Get<bool?>("requirePinAfterBiometricChange"); }
            set { BackingStore?.Set("requirePinAfterBiometricChange", value); }
        }
        /// <summary>Indicates whether screen capture is blocked. (Android only)</summary>
        public bool? ScreenCaptureBlocked {
            get { return BackingStore?.Get<bool?>("screenCaptureBlocked"); }
            set { BackingStore?.Set("screenCaptureBlocked", value); }
        }
        /// <summary>Defines if third party keyboards are allowed while accessing a managed app. (iOS Only)</summary>
        public bool? ThirdPartyKeyboardsBlocked {
            get { return BackingStore?.Get<bool?>("thirdPartyKeyboardsBlocked"); }
            set { BackingStore?.Set("thirdPartyKeyboardsBlocked", value); }
        }
        /// <summary>Maximum number of days Company Portal update can be deferred on the device or the user will receive the warning</summary>
        public int? WarnAfterCompanyPortalUpdateDeferralInDays {
            get { return BackingStore?.Get<int?>("warnAfterCompanyPortalUpdateDeferralInDays"); }
            set { BackingStore?.Set("warnAfterCompanyPortalUpdateDeferralInDays", value); }
        }
        /// <summary>Maximum number of days Company Portal update can be deferred on the device or the company data on the app will be wiped</summary>
        public int? WipeAfterCompanyPortalUpdateDeferralInDays {
            get { return BackingStore?.Get<int?>("wipeAfterCompanyPortalUpdateDeferralInDays"); }
            set { BackingStore?.Set("wipeAfterCompanyPortalUpdateDeferralInDays", value); }
        }
        /// <summary>
        /// Instantiates a new DefaultManagedAppProtection and sets the default values.
        /// </summary>
        public DefaultManagedAppProtection() : base() {
            OdataType = "#microsoft.graph.defaultManagedAppProtection";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DefaultManagedAppProtection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DefaultManagedAppProtection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedAndroidDeviceManufacturers", n => { AllowedAndroidDeviceManufacturers = n.GetStringValue(); } },
                {"allowedAndroidDeviceModels", n => { AllowedAndroidDeviceModels = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"allowedIosDeviceModels", n => { AllowedIosDeviceModels = n.GetStringValue(); } },
                {"appActionIfAccountIsClockedOut", n => { AppActionIfAccountIsClockedOut = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appActionIfAndroidDeviceManufacturerNotAllowed", n => { AppActionIfAndroidDeviceManufacturerNotAllowed = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appActionIfAndroidDeviceModelNotAllowed", n => { AppActionIfAndroidDeviceModelNotAllowed = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appActionIfAndroidSafetyNetAppsVerificationFailed", n => { AppActionIfAndroidSafetyNetAppsVerificationFailed = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appActionIfAndroidSafetyNetDeviceAttestationFailed", n => { AppActionIfAndroidSafetyNetDeviceAttestationFailed = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appActionIfDeviceLockNotSet", n => { AppActionIfDeviceLockNotSet = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appActionIfDevicePasscodeComplexityLessThanHigh", n => { AppActionIfDevicePasscodeComplexityLessThanHigh = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appActionIfDevicePasscodeComplexityLessThanLow", n => { AppActionIfDevicePasscodeComplexityLessThanLow = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appActionIfDevicePasscodeComplexityLessThanMedium", n => { AppActionIfDevicePasscodeComplexityLessThanMedium = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appActionIfIosDeviceModelNotAllowed", n => { AppActionIfIosDeviceModelNotAllowed = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appDataEncryptionType", n => { AppDataEncryptionType = n.GetEnumValue<ManagedAppDataEncryptionType>(); } },
                {"apps", n => { Apps = n.GetCollectionOfObjectValues<ManagedMobileApp>(ManagedMobileApp.CreateFromDiscriminatorValue)?.ToList(); } },
                {"biometricAuthenticationBlocked", n => { BiometricAuthenticationBlocked = n.GetBoolValue(); } },
                {"blockAfterCompanyPortalUpdateDeferralInDays", n => { BlockAfterCompanyPortalUpdateDeferralInDays = n.GetIntValue(); } },
                {"connectToVpnOnLaunch", n => { ConnectToVpnOnLaunch = n.GetBoolValue(); } },
                {"customBrowserDisplayName", n => { CustomBrowserDisplayName = n.GetStringValue(); } },
                {"customBrowserPackageId", n => { CustomBrowserPackageId = n.GetStringValue(); } },
                {"customBrowserProtocol", n => { CustomBrowserProtocol = n.GetStringValue(); } },
                {"customDialerAppDisplayName", n => { CustomDialerAppDisplayName = n.GetStringValue(); } },
                {"customDialerAppPackageId", n => { CustomDialerAppPackageId = n.GetStringValue(); } },
                {"customDialerAppProtocol", n => { CustomDialerAppProtocol = n.GetStringValue(); } },
                {"customSettings", n => { CustomSettings = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deployedAppCount", n => { DeployedAppCount = n.GetIntValue(); } },
                {"deploymentSummary", n => { DeploymentSummary = n.GetObjectValue<ManagedAppPolicyDeploymentSummary>(ManagedAppPolicyDeploymentSummary.CreateFromDiscriminatorValue); } },
                {"deviceLockRequired", n => { DeviceLockRequired = n.GetBoolValue(); } },
                {"disableAppEncryptionIfDeviceEncryptionIsEnabled", n => { DisableAppEncryptionIfDeviceEncryptionIsEnabled = n.GetBoolValue(); } },
                {"disableProtectionOfManagedOutboundOpenInData", n => { DisableProtectionOfManagedOutboundOpenInData = n.GetBoolValue(); } },
                {"encryptAppData", n => { EncryptAppData = n.GetBoolValue(); } },
                {"exemptedAppPackages", n => { ExemptedAppPackages = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"exemptedAppProtocols", n => { ExemptedAppProtocols = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"faceIdBlocked", n => { FaceIdBlocked = n.GetBoolValue(); } },
                {"filterOpenInToOnlyManagedApps", n => { FilterOpenInToOnlyManagedApps = n.GetBoolValue(); } },
                {"fingerprintAndBiometricEnabled", n => { FingerprintAndBiometricEnabled = n.GetBoolValue(); } },
                {"minimumRequiredCompanyPortalVersion", n => { MinimumRequiredCompanyPortalVersion = n.GetStringValue(); } },
                {"minimumRequiredPatchVersion", n => { MinimumRequiredPatchVersion = n.GetStringValue(); } },
                {"minimumRequiredSdkVersion", n => { MinimumRequiredSdkVersion = n.GetStringValue(); } },
                {"minimumWarningCompanyPortalVersion", n => { MinimumWarningCompanyPortalVersion = n.GetStringValue(); } },
                {"minimumWarningPatchVersion", n => { MinimumWarningPatchVersion = n.GetStringValue(); } },
                {"minimumWarningSdkVersion", n => { MinimumWarningSdkVersion = n.GetStringValue(); } },
                {"minimumWipeCompanyPortalVersion", n => { MinimumWipeCompanyPortalVersion = n.GetStringValue(); } },
                {"minimumWipePatchVersion", n => { MinimumWipePatchVersion = n.GetStringValue(); } },
                {"minimumWipeSdkVersion", n => { MinimumWipeSdkVersion = n.GetStringValue(); } },
                {"protectInboundDataFromUnknownSources", n => { ProtectInboundDataFromUnknownSources = n.GetBoolValue(); } },
                {"requireClass3Biometrics", n => { RequireClass3Biometrics = n.GetBoolValue(); } },
                {"requiredAndroidSafetyNetAppsVerificationType", n => { RequiredAndroidSafetyNetAppsVerificationType = n.GetEnumValue<AndroidManagedAppSafetyNetAppsVerificationType>(); } },
                {"requiredAndroidSafetyNetDeviceAttestationType", n => { RequiredAndroidSafetyNetDeviceAttestationType = n.GetEnumValue<AndroidManagedAppSafetyNetDeviceAttestationType>(); } },
                {"requiredAndroidSafetyNetEvaluationType", n => { RequiredAndroidSafetyNetEvaluationType = n.GetEnumValue<AndroidManagedAppSafetyNetEvaluationType>(); } },
                {"requirePinAfterBiometricChange", n => { RequirePinAfterBiometricChange = n.GetBoolValue(); } },
                {"screenCaptureBlocked", n => { ScreenCaptureBlocked = n.GetBoolValue(); } },
                {"thirdPartyKeyboardsBlocked", n => { ThirdPartyKeyboardsBlocked = n.GetBoolValue(); } },
                {"warnAfterCompanyPortalUpdateDeferralInDays", n => { WarnAfterCompanyPortalUpdateDeferralInDays = n.GetIntValue(); } },
                {"wipeAfterCompanyPortalUpdateDeferralInDays", n => { WipeAfterCompanyPortalUpdateDeferralInDays = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("allowedAndroidDeviceManufacturers", AllowedAndroidDeviceManufacturers);
            writer.WriteCollectionOfPrimitiveValues<string>("allowedAndroidDeviceModels", AllowedAndroidDeviceModels);
            writer.WriteStringValue("allowedIosDeviceModels", AllowedIosDeviceModels);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfAccountIsClockedOut", AppActionIfAccountIsClockedOut);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfAndroidDeviceManufacturerNotAllowed", AppActionIfAndroidDeviceManufacturerNotAllowed);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfAndroidDeviceModelNotAllowed", AppActionIfAndroidDeviceModelNotAllowed);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfAndroidSafetyNetAppsVerificationFailed", AppActionIfAndroidSafetyNetAppsVerificationFailed);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfAndroidSafetyNetDeviceAttestationFailed", AppActionIfAndroidSafetyNetDeviceAttestationFailed);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfDeviceLockNotSet", AppActionIfDeviceLockNotSet);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfDevicePasscodeComplexityLessThanHigh", AppActionIfDevicePasscodeComplexityLessThanHigh);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfDevicePasscodeComplexityLessThanLow", AppActionIfDevicePasscodeComplexityLessThanLow);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfDevicePasscodeComplexityLessThanMedium", AppActionIfDevicePasscodeComplexityLessThanMedium);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfIosDeviceModelNotAllowed", AppActionIfIosDeviceModelNotAllowed);
            writer.WriteEnumValue<ManagedAppDataEncryptionType>("appDataEncryptionType", AppDataEncryptionType);
            writer.WriteCollectionOfObjectValues<ManagedMobileApp>("apps", Apps);
            writer.WriteBoolValue("biometricAuthenticationBlocked", BiometricAuthenticationBlocked);
            writer.WriteIntValue("blockAfterCompanyPortalUpdateDeferralInDays", BlockAfterCompanyPortalUpdateDeferralInDays);
            writer.WriteBoolValue("connectToVpnOnLaunch", ConnectToVpnOnLaunch);
            writer.WriteStringValue("customBrowserDisplayName", CustomBrowserDisplayName);
            writer.WriteStringValue("customBrowserPackageId", CustomBrowserPackageId);
            writer.WriteStringValue("customBrowserProtocol", CustomBrowserProtocol);
            writer.WriteStringValue("customDialerAppDisplayName", CustomDialerAppDisplayName);
            writer.WriteStringValue("customDialerAppPackageId", CustomDialerAppPackageId);
            writer.WriteStringValue("customDialerAppProtocol", CustomDialerAppProtocol);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("customSettings", CustomSettings);
            writer.WriteIntValue("deployedAppCount", DeployedAppCount);
            writer.WriteObjectValue<ManagedAppPolicyDeploymentSummary>("deploymentSummary", DeploymentSummary);
            writer.WriteBoolValue("deviceLockRequired", DeviceLockRequired);
            writer.WriteBoolValue("disableAppEncryptionIfDeviceEncryptionIsEnabled", DisableAppEncryptionIfDeviceEncryptionIsEnabled);
            writer.WriteBoolValue("disableProtectionOfManagedOutboundOpenInData", DisableProtectionOfManagedOutboundOpenInData);
            writer.WriteBoolValue("encryptAppData", EncryptAppData);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("exemptedAppPackages", ExemptedAppPackages);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("exemptedAppProtocols", ExemptedAppProtocols);
            writer.WriteBoolValue("faceIdBlocked", FaceIdBlocked);
            writer.WriteBoolValue("filterOpenInToOnlyManagedApps", FilterOpenInToOnlyManagedApps);
            writer.WriteBoolValue("fingerprintAndBiometricEnabled", FingerprintAndBiometricEnabled);
            writer.WriteStringValue("minimumRequiredCompanyPortalVersion", MinimumRequiredCompanyPortalVersion);
            writer.WriteStringValue("minimumRequiredPatchVersion", MinimumRequiredPatchVersion);
            writer.WriteStringValue("minimumRequiredSdkVersion", MinimumRequiredSdkVersion);
            writer.WriteStringValue("minimumWarningCompanyPortalVersion", MinimumWarningCompanyPortalVersion);
            writer.WriteStringValue("minimumWarningPatchVersion", MinimumWarningPatchVersion);
            writer.WriteStringValue("minimumWarningSdkVersion", MinimumWarningSdkVersion);
            writer.WriteStringValue("minimumWipeCompanyPortalVersion", MinimumWipeCompanyPortalVersion);
            writer.WriteStringValue("minimumWipePatchVersion", MinimumWipePatchVersion);
            writer.WriteStringValue("minimumWipeSdkVersion", MinimumWipeSdkVersion);
            writer.WriteBoolValue("protectInboundDataFromUnknownSources", ProtectInboundDataFromUnknownSources);
            writer.WriteBoolValue("requireClass3Biometrics", RequireClass3Biometrics);
            writer.WriteEnumValue<AndroidManagedAppSafetyNetAppsVerificationType>("requiredAndroidSafetyNetAppsVerificationType", RequiredAndroidSafetyNetAppsVerificationType);
            writer.WriteEnumValue<AndroidManagedAppSafetyNetDeviceAttestationType>("requiredAndroidSafetyNetDeviceAttestationType", RequiredAndroidSafetyNetDeviceAttestationType);
            writer.WriteEnumValue<AndroidManagedAppSafetyNetEvaluationType>("requiredAndroidSafetyNetEvaluationType", RequiredAndroidSafetyNetEvaluationType);
            writer.WriteBoolValue("requirePinAfterBiometricChange", RequirePinAfterBiometricChange);
            writer.WriteBoolValue("screenCaptureBlocked", ScreenCaptureBlocked);
            writer.WriteBoolValue("thirdPartyKeyboardsBlocked", ThirdPartyKeyboardsBlocked);
            writer.WriteIntValue("warnAfterCompanyPortalUpdateDeferralInDays", WarnAfterCompanyPortalUpdateDeferralInDays);
            writer.WriteIntValue("wipeAfterCompanyPortalUpdateDeferralInDays", WipeAfterCompanyPortalUpdateDeferralInDays);
        }
    }
}
