using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// This topic provides descriptions of the declared methods, properties and relationships exposed by the androidDeviceOwnerGeneralDeviceConfiguration resource.
    /// </summary>
    public class AndroidDeviceOwnerGeneralDeviceConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Indicates whether or not adding or removing accounts is disabled.</summary>
        public bool? AccountsBlockModification {
            get { return BackingStore?.Get<bool?>("accountsBlockModification"); }
            set { BackingStore?.Set("accountsBlockModification", value); }
        }
        /// <summary>Indicates whether or not the user is allowed to enable to unknown sources setting.</summary>
        public bool? AppsAllowInstallFromUnknownSources {
            get { return BackingStore?.Get<bool?>("appsAllowInstallFromUnknownSources"); }
            set { BackingStore?.Set("appsAllowInstallFromUnknownSources", value); }
        }
        /// <summary>Indicates the value of the app auto update policy. Possible values are: notConfigured, userChoice, never, wiFiOnly, always.</summary>
        public AndroidDeviceOwnerAppAutoUpdatePolicyType? AppsAutoUpdatePolicy {
            get { return BackingStore?.Get<AndroidDeviceOwnerAppAutoUpdatePolicyType?>("appsAutoUpdatePolicy"); }
            set { BackingStore?.Set("appsAutoUpdatePolicy", value); }
        }
        /// <summary>Indicates the permission policy for requests for runtime permissions if one is not defined for the app specifically. Possible values are: deviceDefault, prompt, autoGrant, autoDeny.</summary>
        public AndroidDeviceOwnerDefaultAppPermissionPolicyType? AppsDefaultPermissionPolicy {
            get { return BackingStore?.Get<AndroidDeviceOwnerDefaultAppPermissionPolicyType?>("appsDefaultPermissionPolicy"); }
            set { BackingStore?.Set("appsDefaultPermissionPolicy", value); }
        }
        /// <summary>Whether or not to recommend all apps skip any first-time-use hints they may have added.</summary>
        public bool? AppsRecommendSkippingFirstUseHints {
            get { return BackingStore?.Get<bool?>("appsRecommendSkippingFirstUseHints"); }
            set { BackingStore?.Set("appsRecommendSkippingFirstUseHints", value); }
        }
        /// <summary>A list of managed apps that will have their data cleared during a global sign-out in AAD shared device mode. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AppListItem>? AzureAdSharedDeviceDataClearApps {
            get { return BackingStore?.Get<List<AppListItem>?>("azureAdSharedDeviceDataClearApps"); }
            set { BackingStore?.Set("azureAdSharedDeviceDataClearApps", value); }
        }
#nullable restore
#else
        public List<AppListItem> AzureAdSharedDeviceDataClearApps {
            get { return BackingStore?.Get<List<AppListItem>>("azureAdSharedDeviceDataClearApps"); }
            set { BackingStore?.Set("azureAdSharedDeviceDataClearApps", value); }
        }
#endif
        /// <summary>Indicates whether or not to block a user from configuring bluetooth.</summary>
        public bool? BluetoothBlockConfiguration {
            get { return BackingStore?.Get<bool?>("bluetoothBlockConfiguration"); }
            set { BackingStore?.Set("bluetoothBlockConfiguration", value); }
        }
        /// <summary>Indicates whether or not to block a user from sharing contacts via bluetooth.</summary>
        public bool? BluetoothBlockContactSharing {
            get { return BackingStore?.Get<bool?>("bluetoothBlockContactSharing"); }
            set { BackingStore?.Set("bluetoothBlockContactSharing", value); }
        }
        /// <summary>Indicates whether or not to disable the use of the camera.</summary>
        public bool? CameraBlocked {
            get { return BackingStore?.Get<bool?>("cameraBlocked"); }
            set { BackingStore?.Set("cameraBlocked", value); }
        }
        /// <summary>Indicates whether or not to block Wi-Fi tethering.</summary>
        public bool? CellularBlockWiFiTethering {
            get { return BackingStore?.Get<bool?>("cellularBlockWiFiTethering"); }
            set { BackingStore?.Set("cellularBlockWiFiTethering", value); }
        }
        /// <summary>Indicates whether or not to block users from any certificate credential configuration.</summary>
        public bool? CertificateCredentialConfigurationDisabled {
            get { return BackingStore?.Get<bool?>("certificateCredentialConfigurationDisabled"); }
            set { BackingStore?.Set("certificateCredentialConfigurationDisabled", value); }
        }
        /// <summary>Indicates whether or not text copied from one profile (personal or work) can be pasted in the other.</summary>
        public bool? CrossProfilePoliciesAllowCopyPaste {
            get { return BackingStore?.Get<bool?>("crossProfilePoliciesAllowCopyPaste"); }
            set { BackingStore?.Set("crossProfilePoliciesAllowCopyPaste", value); }
        }
        /// <summary>Indicates whether data from one profile (personal or work) can be shared with apps in the other profile. Possible values are: notConfigured, crossProfileDataSharingBlocked, dataSharingFromWorkToPersonalBlocked, crossProfileDataSharingAllowed, unkownFutureValue.</summary>
        public AndroidDeviceOwnerCrossProfileDataSharing? CrossProfilePoliciesAllowDataSharing {
            get { return BackingStore?.Get<AndroidDeviceOwnerCrossProfileDataSharing?>("crossProfilePoliciesAllowDataSharing"); }
            set { BackingStore?.Set("crossProfilePoliciesAllowDataSharing", value); }
        }
        /// <summary>Indicates whether or not contacts stored in work profile are shown in personal profile contact searches/incoming calls.</summary>
        public bool? CrossProfilePoliciesShowWorkContactsInPersonalProfile {
            get { return BackingStore?.Get<bool?>("crossProfilePoliciesShowWorkContactsInPersonalProfile"); }
            set { BackingStore?.Set("crossProfilePoliciesShowWorkContactsInPersonalProfile", value); }
        }
        /// <summary>Indicates whether or not to block a user from data roaming.</summary>
        public bool? DataRoamingBlocked {
            get { return BackingStore?.Get<bool?>("dataRoamingBlocked"); }
            set { BackingStore?.Set("dataRoamingBlocked", value); }
        }
        /// <summary>Indicates whether or not to block the user from manually changing the date or time on the device</summary>
        public bool? DateTimeConfigurationBlocked {
            get { return BackingStore?.Get<bool?>("dateTimeConfigurationBlocked"); }
            set { BackingStore?.Set("dateTimeConfigurationBlocked", value); }
        }
        /// <summary>Represents the customized detailed help text provided to users when they attempt to modify managed settings on their device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AndroidDeviceOwnerUserFacingMessage? DetailedHelpText {
            get { return BackingStore?.Get<AndroidDeviceOwnerUserFacingMessage?>("detailedHelpText"); }
            set { BackingStore?.Set("detailedHelpText", value); }
        }
#nullable restore
#else
        public AndroidDeviceOwnerUserFacingMessage DetailedHelpText {
            get { return BackingStore?.Get<AndroidDeviceOwnerUserFacingMessage>("detailedHelpText"); }
            set { BackingStore?.Set("detailedHelpText", value); }
        }
#endif
        /// <summary>Represents the customized lock screen message provided to users when they attempt to modify managed settings on their device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AndroidDeviceOwnerUserFacingMessage? DeviceOwnerLockScreenMessage {
            get { return BackingStore?.Get<AndroidDeviceOwnerUserFacingMessage?>("deviceOwnerLockScreenMessage"); }
            set { BackingStore?.Set("deviceOwnerLockScreenMessage", value); }
        }
#nullable restore
#else
        public AndroidDeviceOwnerUserFacingMessage DeviceOwnerLockScreenMessage {
            get { return BackingStore?.Get<AndroidDeviceOwnerUserFacingMessage>("deviceOwnerLockScreenMessage"); }
            set { BackingStore?.Set("deviceOwnerLockScreenMessage", value); }
        }
#endif
        /// <summary>Android Device Owner Enrollment Profile types.</summary>
        public AndroidDeviceOwnerEnrollmentProfileType? EnrollmentProfile {
            get { return BackingStore?.Get<AndroidDeviceOwnerEnrollmentProfileType?>("enrollmentProfile"); }
            set { BackingStore?.Set("enrollmentProfile", value); }
        }
        /// <summary>Indicates whether or not the factory reset option in settings is disabled.</summary>
        public bool? FactoryResetBlocked {
            get { return BackingStore?.Get<bool?>("factoryResetBlocked"); }
            set { BackingStore?.Set("factoryResetBlocked", value); }
        }
        /// <summary>List of Google account emails that will be required to authenticate after a device is factory reset before it can be set up.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? FactoryResetDeviceAdministratorEmails {
            get { return BackingStore?.Get<List<string>?>("factoryResetDeviceAdministratorEmails"); }
            set { BackingStore?.Set("factoryResetDeviceAdministratorEmails", value); }
        }
#nullable restore
#else
        public List<string> FactoryResetDeviceAdministratorEmails {
            get { return BackingStore?.Get<List<string>>("factoryResetDeviceAdministratorEmails"); }
            set { BackingStore?.Set("factoryResetDeviceAdministratorEmails", value); }
        }
#endif
        /// <summary>Proxy is set up directly with host, port and excluded hosts.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AndroidDeviceOwnerGlobalProxy? GlobalProxy {
            get { return BackingStore?.Get<AndroidDeviceOwnerGlobalProxy?>("globalProxy"); }
            set { BackingStore?.Set("globalProxy", value); }
        }
#nullable restore
#else
        public AndroidDeviceOwnerGlobalProxy GlobalProxy {
            get { return BackingStore?.Get<AndroidDeviceOwnerGlobalProxy>("globalProxy"); }
            set { BackingStore?.Set("globalProxy", value); }
        }
#endif
        /// <summary>Indicates whether or not google accounts will be blocked.</summary>
        public bool? GoogleAccountsBlocked {
            get { return BackingStore?.Get<bool?>("googleAccountsBlocked"); }
            set { BackingStore?.Set("googleAccountsBlocked", value); }
        }
        /// <summary>Indicates whether a user can access the device&apos;s Settings app while in Kiosk Mode.</summary>
        public bool? KioskCustomizationDeviceSettingsBlocked {
            get { return BackingStore?.Get<bool?>("kioskCustomizationDeviceSettingsBlocked"); }
            set { BackingStore?.Set("kioskCustomizationDeviceSettingsBlocked", value); }
        }
        /// <summary>Whether the power menu is shown when a user long presses the Power button of a device in Kiosk Mode.</summary>
        public bool? KioskCustomizationPowerButtonActionsBlocked {
            get { return BackingStore?.Get<bool?>("kioskCustomizationPowerButtonActionsBlocked"); }
            set { BackingStore?.Set("kioskCustomizationPowerButtonActionsBlocked", value); }
        }
        /// <summary>Indicates whether system info and notifications are disabled in Kiosk Mode. Possible values are: notConfigured, notificationsAndSystemInfoEnabled, systemInfoOnly.</summary>
        public AndroidDeviceOwnerKioskCustomizationStatusBar? KioskCustomizationStatusBar {
            get { return BackingStore?.Get<AndroidDeviceOwnerKioskCustomizationStatusBar?>("kioskCustomizationStatusBar"); }
            set { BackingStore?.Set("kioskCustomizationStatusBar", value); }
        }
        /// <summary>Indicates whether system error dialogs for crashed or unresponsive apps are shown in Kiosk Mode.</summary>
        public bool? KioskCustomizationSystemErrorWarnings {
            get { return BackingStore?.Get<bool?>("kioskCustomizationSystemErrorWarnings"); }
            set { BackingStore?.Set("kioskCustomizationSystemErrorWarnings", value); }
        }
        /// <summary>Indicates which navigation features are enabled in Kiosk Mode. Possible values are: notConfigured, navigationEnabled, homeButtonOnly.</summary>
        public AndroidDeviceOwnerKioskCustomizationSystemNavigation? KioskCustomizationSystemNavigation {
            get { return BackingStore?.Get<AndroidDeviceOwnerKioskCustomizationSystemNavigation?>("kioskCustomizationSystemNavigation"); }
            set { BackingStore?.Set("kioskCustomizationSystemNavigation", value); }
        }
        /// <summary>Whether or not to enable app ordering in Kiosk Mode.</summary>
        public bool? KioskModeAppOrderEnabled {
            get { return BackingStore?.Get<bool?>("kioskModeAppOrderEnabled"); }
            set { BackingStore?.Set("kioskModeAppOrderEnabled", value); }
        }
        /// <summary>The ordering of items on Kiosk Mode Managed Home Screen. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AndroidDeviceOwnerKioskModeAppPositionItem>? KioskModeAppPositions {
            get { return BackingStore?.Get<List<AndroidDeviceOwnerKioskModeAppPositionItem>?>("kioskModeAppPositions"); }
            set { BackingStore?.Set("kioskModeAppPositions", value); }
        }
#nullable restore
#else
        public List<AndroidDeviceOwnerKioskModeAppPositionItem> KioskModeAppPositions {
            get { return BackingStore?.Get<List<AndroidDeviceOwnerKioskModeAppPositionItem>>("kioskModeAppPositions"); }
            set { BackingStore?.Set("kioskModeAppPositions", value); }
        }
#endif
        /// <summary>A list of managed apps that will be shown when the device is in Kiosk Mode. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AppListItem>? KioskModeApps {
            get { return BackingStore?.Get<List<AppListItem>?>("kioskModeApps"); }
            set { BackingStore?.Set("kioskModeApps", value); }
        }
#nullable restore
#else
        public List<AppListItem> KioskModeApps {
            get { return BackingStore?.Get<List<AppListItem>>("kioskModeApps"); }
            set { BackingStore?.Set("kioskModeApps", value); }
        }
#endif
        /// <summary>Whether or not to alphabetize applications within a folder in Kiosk Mode.</summary>
        public bool? KioskModeAppsInFolderOrderedByName {
            get { return BackingStore?.Get<bool?>("kioskModeAppsInFolderOrderedByName"); }
            set { BackingStore?.Set("kioskModeAppsInFolderOrderedByName", value); }
        }
        /// <summary>Whether or not to allow a user to configure Bluetooth settings in Kiosk Mode.</summary>
        public bool? KioskModeBluetoothConfigurationEnabled {
            get { return BackingStore?.Get<bool?>("kioskModeBluetoothConfigurationEnabled"); }
            set { BackingStore?.Set("kioskModeBluetoothConfigurationEnabled", value); }
        }
        /// <summary>Whether or not to allow a user to easy access to the debug menu in Kiosk Mode.</summary>
        public bool? KioskModeDebugMenuEasyAccessEnabled {
            get { return BackingStore?.Get<bool?>("kioskModeDebugMenuEasyAccessEnabled"); }
            set { BackingStore?.Set("kioskModeDebugMenuEasyAccessEnabled", value); }
        }
        /// <summary>Exit code to allow a user to escape from Kiosk Mode when the device is in Kiosk Mode.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KioskModeExitCode {
            get { return BackingStore?.Get<string?>("kioskModeExitCode"); }
            set { BackingStore?.Set("kioskModeExitCode", value); }
        }
#nullable restore
#else
        public string KioskModeExitCode {
            get { return BackingStore?.Get<string>("kioskModeExitCode"); }
            set { BackingStore?.Set("kioskModeExitCode", value); }
        }
#endif
        /// <summary>Whether or not to allow a user to use the flashlight in Kiosk Mode.</summary>
        public bool? KioskModeFlashlightConfigurationEnabled {
            get { return BackingStore?.Get<bool?>("kioskModeFlashlightConfigurationEnabled"); }
            set { BackingStore?.Set("kioskModeFlashlightConfigurationEnabled", value); }
        }
        /// <summary>Folder icon configuration for managed home screen in Kiosk Mode. Possible values are: notConfigured, darkSquare, darkCircle, lightSquare, lightCircle.</summary>
        public AndroidDeviceOwnerKioskModeFolderIcon? KioskModeFolderIcon {
            get { return BackingStore?.Get<AndroidDeviceOwnerKioskModeFolderIcon?>("kioskModeFolderIcon"); }
            set { BackingStore?.Set("kioskModeFolderIcon", value); }
        }
        /// <summary>Number of rows for Managed Home Screen grid with app ordering enabled in Kiosk Mode. Valid values 1 to 9999999</summary>
        public int? KioskModeGridHeight {
            get { return BackingStore?.Get<int?>("kioskModeGridHeight"); }
            set { BackingStore?.Set("kioskModeGridHeight", value); }
        }
        /// <summary>Number of columns for Managed Home Screen grid with app ordering enabled in Kiosk Mode. Valid values 1 to 9999999</summary>
        public int? KioskModeGridWidth {
            get { return BackingStore?.Get<int?>("kioskModeGridWidth"); }
            set { BackingStore?.Set("kioskModeGridWidth", value); }
        }
        /// <summary>Icon size configuration for managed home screen in Kiosk Mode. Possible values are: notConfigured, smallest, small, regular, large, largest.</summary>
        public AndroidDeviceOwnerKioskModeIconSize? KioskModeIconSize {
            get { return BackingStore?.Get<AndroidDeviceOwnerKioskModeIconSize?>("kioskModeIconSize"); }
            set { BackingStore?.Set("kioskModeIconSize", value); }
        }
        /// <summary>Whether or not to lock home screen to the end user in Kiosk Mode.</summary>
        public bool? KioskModeLockHomeScreen {
            get { return BackingStore?.Get<bool?>("kioskModeLockHomeScreen"); }
            set { BackingStore?.Set("kioskModeLockHomeScreen", value); }
        }
        /// <summary>A list of managed folders for a device in Kiosk Mode. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AndroidDeviceOwnerKioskModeManagedFolder>? KioskModeManagedFolders {
            get { return BackingStore?.Get<List<AndroidDeviceOwnerKioskModeManagedFolder>?>("kioskModeManagedFolders"); }
            set { BackingStore?.Set("kioskModeManagedFolders", value); }
        }
#nullable restore
#else
        public List<AndroidDeviceOwnerKioskModeManagedFolder> KioskModeManagedFolders {
            get { return BackingStore?.Get<List<AndroidDeviceOwnerKioskModeManagedFolder>>("kioskModeManagedFolders"); }
            set { BackingStore?.Set("kioskModeManagedFolders", value); }
        }
#endif
        /// <summary>Whether or not to automatically sign-out of MHS and Shared device mode applications after inactive for Managed Home Screen.</summary>
        public bool? KioskModeManagedHomeScreenAutoSignout {
            get { return BackingStore?.Get<bool?>("kioskModeManagedHomeScreenAutoSignout"); }
            set { BackingStore?.Set("kioskModeManagedHomeScreenAutoSignout", value); }
        }
        /// <summary>Number of seconds to give user notice before automatically signing them out for Managed Home Screen. Valid values 0 to 9999999</summary>
        public int? KioskModeManagedHomeScreenInactiveSignOutDelayInSeconds {
            get { return BackingStore?.Get<int?>("kioskModeManagedHomeScreenInactiveSignOutDelayInSeconds"); }
            set { BackingStore?.Set("kioskModeManagedHomeScreenInactiveSignOutDelayInSeconds", value); }
        }
        /// <summary>Number of seconds device is inactive before automatically signing user out for Managed Home Screen. Valid values 0 to 9999999</summary>
        public int? KioskModeManagedHomeScreenInactiveSignOutNoticeInSeconds {
            get { return BackingStore?.Get<int?>("kioskModeManagedHomeScreenInactiveSignOutNoticeInSeconds"); }
            set { BackingStore?.Set("kioskModeManagedHomeScreenInactiveSignOutNoticeInSeconds", value); }
        }
        /// <summary>Complexity of PIN for sign-in session for Managed Home Screen. Possible values are: notConfigured, simple, complex.</summary>
        public Microsoft.Graph.Beta.Models.KioskModeManagedHomeScreenPinComplexity? KioskModeManagedHomeScreenPinComplexity {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.KioskModeManagedHomeScreenPinComplexity?>("kioskModeManagedHomeScreenPinComplexity"); }
            set { BackingStore?.Set("kioskModeManagedHomeScreenPinComplexity", value); }
        }
        /// <summary>Whether or not require user to set a PIN for sign-in session for Managed Home Screen.</summary>
        public bool? KioskModeManagedHomeScreenPinRequired {
            get { return BackingStore?.Get<bool?>("kioskModeManagedHomeScreenPinRequired"); }
            set { BackingStore?.Set("kioskModeManagedHomeScreenPinRequired", value); }
        }
        /// <summary>Whether or not required user to enter session PIN if screensaver has appeared for Managed Home Screen.</summary>
        public bool? KioskModeManagedHomeScreenPinRequiredToResume {
            get { return BackingStore?.Get<bool?>("kioskModeManagedHomeScreenPinRequiredToResume"); }
            set { BackingStore?.Set("kioskModeManagedHomeScreenPinRequiredToResume", value); }
        }
        /// <summary>Custom URL background for sign-in screen for Managed Home Screen.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KioskModeManagedHomeScreenSignInBackground {
            get { return BackingStore?.Get<string?>("kioskModeManagedHomeScreenSignInBackground"); }
            set { BackingStore?.Set("kioskModeManagedHomeScreenSignInBackground", value); }
        }
#nullable restore
#else
        public string KioskModeManagedHomeScreenSignInBackground {
            get { return BackingStore?.Get<string>("kioskModeManagedHomeScreenSignInBackground"); }
            set { BackingStore?.Set("kioskModeManagedHomeScreenSignInBackground", value); }
        }
#endif
        /// <summary>Custom URL branding logo for sign-in screen and session pin page for Managed Home Screen.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KioskModeManagedHomeScreenSignInBrandingLogo {
            get { return BackingStore?.Get<string?>("kioskModeManagedHomeScreenSignInBrandingLogo"); }
            set { BackingStore?.Set("kioskModeManagedHomeScreenSignInBrandingLogo", value); }
        }
#nullable restore
#else
        public string KioskModeManagedHomeScreenSignInBrandingLogo {
            get { return BackingStore?.Get<string>("kioskModeManagedHomeScreenSignInBrandingLogo"); }
            set { BackingStore?.Set("kioskModeManagedHomeScreenSignInBrandingLogo", value); }
        }
#endif
        /// <summary>Whether or not show sign-in screen for Managed Home Screen.</summary>
        public bool? KioskModeManagedHomeScreenSignInEnabled {
            get { return BackingStore?.Get<bool?>("kioskModeManagedHomeScreenSignInEnabled"); }
            set { BackingStore?.Set("kioskModeManagedHomeScreenSignInEnabled", value); }
        }
        /// <summary>Whether or not to display the Managed Settings entry point on the managed home screen in Kiosk Mode.</summary>
        public bool? KioskModeManagedSettingsEntryDisabled {
            get { return BackingStore?.Get<bool?>("kioskModeManagedSettingsEntryDisabled"); }
            set { BackingStore?.Set("kioskModeManagedSettingsEntryDisabled", value); }
        }
        /// <summary>Whether or not to allow a user to change the media volume in Kiosk Mode.</summary>
        public bool? KioskModeMediaVolumeConfigurationEnabled {
            get { return BackingStore?.Get<bool?>("kioskModeMediaVolumeConfigurationEnabled"); }
            set { BackingStore?.Set("kioskModeMediaVolumeConfigurationEnabled", value); }
        }
        /// <summary>Screen orientation configuration for managed home screen in Kiosk Mode. Possible values are: notConfigured, portrait, landscape, autoRotate.</summary>
        public AndroidDeviceOwnerKioskModeScreenOrientation? KioskModeScreenOrientation {
            get { return BackingStore?.Get<AndroidDeviceOwnerKioskModeScreenOrientation?>("kioskModeScreenOrientation"); }
            set { BackingStore?.Set("kioskModeScreenOrientation", value); }
        }
        /// <summary>Whether or not to enable screen saver mode or not in Kiosk Mode.</summary>
        public bool? KioskModeScreenSaverConfigurationEnabled {
            get { return BackingStore?.Get<bool?>("kioskModeScreenSaverConfigurationEnabled"); }
            set { BackingStore?.Set("kioskModeScreenSaverConfigurationEnabled", value); }
        }
        /// <summary>Whether or not the device screen should show the screen saver if audio/video is playing in Kiosk Mode.</summary>
        public bool? KioskModeScreenSaverDetectMediaDisabled {
            get { return BackingStore?.Get<bool?>("kioskModeScreenSaverDetectMediaDisabled"); }
            set { BackingStore?.Set("kioskModeScreenSaverDetectMediaDisabled", value); }
        }
        /// <summary>The number of seconds that the device will display the screen saver for in Kiosk Mode. Valid values 0 to 9999999</summary>
        public int? KioskModeScreenSaverDisplayTimeInSeconds {
            get { return BackingStore?.Get<int?>("kioskModeScreenSaverDisplayTimeInSeconds"); }
            set { BackingStore?.Set("kioskModeScreenSaverDisplayTimeInSeconds", value); }
        }
        /// <summary>URL for an image that will be the device&apos;s screen saver in Kiosk Mode.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KioskModeScreenSaverImageUrl {
            get { return BackingStore?.Get<string?>("kioskModeScreenSaverImageUrl"); }
            set { BackingStore?.Set("kioskModeScreenSaverImageUrl", value); }
        }
#nullable restore
#else
        public string KioskModeScreenSaverImageUrl {
            get { return BackingStore?.Get<string>("kioskModeScreenSaverImageUrl"); }
            set { BackingStore?.Set("kioskModeScreenSaverImageUrl", value); }
        }
#endif
        /// <summary>The number of seconds the device needs to be inactive for before the screen saver is shown in Kiosk Mode. Valid values 1 to 9999999</summary>
        public int? KioskModeScreenSaverStartDelayInSeconds {
            get { return BackingStore?.Get<int?>("kioskModeScreenSaverStartDelayInSeconds"); }
            set { BackingStore?.Set("kioskModeScreenSaverStartDelayInSeconds", value); }
        }
        /// <summary>Whether or not to display application notification badges in Kiosk Mode.</summary>
        public bool? KioskModeShowAppNotificationBadge {
            get { return BackingStore?.Get<bool?>("kioskModeShowAppNotificationBadge"); }
            set { BackingStore?.Set("kioskModeShowAppNotificationBadge", value); }
        }
        /// <summary>Whether or not to allow a user to access basic device information.</summary>
        public bool? KioskModeShowDeviceInfo {
            get { return BackingStore?.Get<bool?>("kioskModeShowDeviceInfo"); }
            set { BackingStore?.Set("kioskModeShowDeviceInfo", value); }
        }
        /// <summary>Whether or not to use single app kiosk mode or multi-app kiosk mode. Possible values are: notConfigured, singleAppMode, multiAppMode.</summary>
        public KioskModeType? KioskModeUseManagedHomeScreenApp {
            get { return BackingStore?.Get<KioskModeType?>("kioskModeUseManagedHomeScreenApp"); }
            set { BackingStore?.Set("kioskModeUseManagedHomeScreenApp", value); }
        }
        /// <summary>Whether or not to display a virtual home button when the device is in Kiosk Mode.</summary>
        public bool? KioskModeVirtualHomeButtonEnabled {
            get { return BackingStore?.Get<bool?>("kioskModeVirtualHomeButtonEnabled"); }
            set { BackingStore?.Set("kioskModeVirtualHomeButtonEnabled", value); }
        }
        /// <summary>Indicates whether the virtual home button is a swipe up home button or a floating home button. Possible values are: notConfigured, swipeUp, floating.</summary>
        public AndroidDeviceOwnerVirtualHomeButtonType? KioskModeVirtualHomeButtonType {
            get { return BackingStore?.Get<AndroidDeviceOwnerVirtualHomeButtonType?>("kioskModeVirtualHomeButtonType"); }
            set { BackingStore?.Set("kioskModeVirtualHomeButtonType", value); }
        }
        /// <summary>URL to a publicly accessible image to use for the wallpaper when the device is in Kiosk Mode.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KioskModeWallpaperUrl {
            get { return BackingStore?.Get<string?>("kioskModeWallpaperUrl"); }
            set { BackingStore?.Set("kioskModeWallpaperUrl", value); }
        }
#nullable restore
#else
        public string KioskModeWallpaperUrl {
            get { return BackingStore?.Get<string>("kioskModeWallpaperUrl"); }
            set { BackingStore?.Set("kioskModeWallpaperUrl", value); }
        }
#endif
        /// <summary>The restricted set of WIFI SSIDs available for the user to configure in Kiosk Mode. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? KioskModeWifiAllowedSsids {
            get { return BackingStore?.Get<List<string>?>("kioskModeWifiAllowedSsids"); }
            set { BackingStore?.Set("kioskModeWifiAllowedSsids", value); }
        }
#nullable restore
#else
        public List<string> KioskModeWifiAllowedSsids {
            get { return BackingStore?.Get<List<string>>("kioskModeWifiAllowedSsids"); }
            set { BackingStore?.Set("kioskModeWifiAllowedSsids", value); }
        }
#endif
        /// <summary>Whether or not to allow a user to configure Wi-Fi settings in Kiosk Mode.</summary>
        public bool? KioskModeWiFiConfigurationEnabled {
            get { return BackingStore?.Get<bool?>("kioskModeWiFiConfigurationEnabled"); }
            set { BackingStore?.Set("kioskModeWiFiConfigurationEnabled", value); }
        }
        /// <summary>Indicates whether or not LocateDevice for devices with lost mode (COBO, COPE) is enabled.</summary>
        public bool? LocateDeviceLostModeEnabled {
            get { return BackingStore?.Get<bool?>("locateDeviceLostModeEnabled"); }
            set { BackingStore?.Set("locateDeviceLostModeEnabled", value); }
        }
        /// <summary>Indicates whether or not LocateDevice for userless (COSU) devices is disabled.</summary>
        public bool? LocateDeviceUserlessDisabled {
            get { return BackingStore?.Get<bool?>("locateDeviceUserlessDisabled"); }
            set { BackingStore?.Set("locateDeviceUserlessDisabled", value); }
        }
        /// <summary>Indicates whether or not to block unmuting the microphone on the device.</summary>
        public bool? MicrophoneForceMute {
            get { return BackingStore?.Get<bool?>("microphoneForceMute"); }
            set { BackingStore?.Set("microphoneForceMute", value); }
        }
        /// <summary>Indicates whether or not to you want configure Microsoft Launcher.</summary>
        public bool? MicrosoftLauncherConfigurationEnabled {
            get { return BackingStore?.Get<bool?>("microsoftLauncherConfigurationEnabled"); }
            set { BackingStore?.Set("microsoftLauncherConfigurationEnabled", value); }
        }
        /// <summary>Indicates whether or not the user can modify the wallpaper to personalize their device.</summary>
        public bool? MicrosoftLauncherCustomWallpaperAllowUserModification {
            get { return BackingStore?.Get<bool?>("microsoftLauncherCustomWallpaperAllowUserModification"); }
            set { BackingStore?.Set("microsoftLauncherCustomWallpaperAllowUserModification", value); }
        }
        /// <summary>Indicates whether or not to configure the wallpaper on the targeted devices.</summary>
        public bool? MicrosoftLauncherCustomWallpaperEnabled {
            get { return BackingStore?.Get<bool?>("microsoftLauncherCustomWallpaperEnabled"); }
            set { BackingStore?.Set("microsoftLauncherCustomWallpaperEnabled", value); }
        }
        /// <summary>Indicates the URL for the image file to use as the wallpaper on the targeted devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MicrosoftLauncherCustomWallpaperImageUrl {
            get { return BackingStore?.Get<string?>("microsoftLauncherCustomWallpaperImageUrl"); }
            set { BackingStore?.Set("microsoftLauncherCustomWallpaperImageUrl", value); }
        }
#nullable restore
#else
        public string MicrosoftLauncherCustomWallpaperImageUrl {
            get { return BackingStore?.Get<string>("microsoftLauncherCustomWallpaperImageUrl"); }
            set { BackingStore?.Set("microsoftLauncherCustomWallpaperImageUrl", value); }
        }
#endif
        /// <summary>Indicates whether or not the user can modify the device dock configuration on the device.</summary>
        public bool? MicrosoftLauncherDockPresenceAllowUserModification {
            get { return BackingStore?.Get<bool?>("microsoftLauncherDockPresenceAllowUserModification"); }
            set { BackingStore?.Set("microsoftLauncherDockPresenceAllowUserModification", value); }
        }
        /// <summary>Indicates whether or not you want to configure the device dock. Possible values are: notConfigured, show, hide, disabled.</summary>
        public MicrosoftLauncherDockPresence? MicrosoftLauncherDockPresenceConfiguration {
            get { return BackingStore?.Get<MicrosoftLauncherDockPresence?>("microsoftLauncherDockPresenceConfiguration"); }
            set { BackingStore?.Set("microsoftLauncherDockPresenceConfiguration", value); }
        }
        /// <summary>Indicates whether or not the user can modify the launcher feed on the device.</summary>
        public bool? MicrosoftLauncherFeedAllowUserModification {
            get { return BackingStore?.Get<bool?>("microsoftLauncherFeedAllowUserModification"); }
            set { BackingStore?.Set("microsoftLauncherFeedAllowUserModification", value); }
        }
        /// <summary>Indicates whether or not you want to enable the launcher feed on the device.</summary>
        public bool? MicrosoftLauncherFeedEnabled {
            get { return BackingStore?.Get<bool?>("microsoftLauncherFeedEnabled"); }
            set { BackingStore?.Set("microsoftLauncherFeedEnabled", value); }
        }
        /// <summary>Indicates the search bar placement configuration on the device. Possible values are: notConfigured, top, bottom, hide.</summary>
        public MicrosoftLauncherSearchBarPlacement? MicrosoftLauncherSearchBarPlacementConfiguration {
            get { return BackingStore?.Get<MicrosoftLauncherSearchBarPlacement?>("microsoftLauncherSearchBarPlacementConfiguration"); }
            set { BackingStore?.Set("microsoftLauncherSearchBarPlacementConfiguration", value); }
        }
        /// <summary>Indicates whether or not the device will allow connecting to a temporary network connection at boot time.</summary>
        public bool? NetworkEscapeHatchAllowed {
            get { return BackingStore?.Get<bool?>("networkEscapeHatchAllowed"); }
            set { BackingStore?.Set("networkEscapeHatchAllowed", value); }
        }
        /// <summary>Indicates whether or not to block NFC outgoing beam.</summary>
        public bool? NfcBlockOutgoingBeam {
            get { return BackingStore?.Get<bool?>("nfcBlockOutgoingBeam"); }
            set { BackingStore?.Set("nfcBlockOutgoingBeam", value); }
        }
        /// <summary>Indicates whether or not the keyguard is disabled.</summary>
        public bool? PasswordBlockKeyguard {
            get { return BackingStore?.Get<bool?>("passwordBlockKeyguard"); }
            set { BackingStore?.Set("passwordBlockKeyguard", value); }
        }
        /// <summary>List of device keyguard features to block. This collection can contain a maximum of 11 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AndroidKeyguardFeature?>? PasswordBlockKeyguardFeatures {
            get { return BackingStore?.Get<List<AndroidKeyguardFeature?>?>("passwordBlockKeyguardFeatures"); }
            set { BackingStore?.Set("passwordBlockKeyguardFeatures", value); }
        }
#nullable restore
#else
        public List<AndroidKeyguardFeature?> PasswordBlockKeyguardFeatures {
            get { return BackingStore?.Get<List<AndroidKeyguardFeature?>>("passwordBlockKeyguardFeatures"); }
            set { BackingStore?.Set("passwordBlockKeyguardFeatures", value); }
        }
#endif
        /// <summary>Indicates the amount of time that a password can be set for before it expires and a new password will be required. Valid values 1 to 365</summary>
        public int? PasswordExpirationDays {
            get { return BackingStore?.Get<int?>("passwordExpirationDays"); }
            set { BackingStore?.Set("passwordExpirationDays", value); }
        }
        /// <summary>Indicates the minimum length of the password required on the device. Valid values 4 to 16</summary>
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
        /// <summary>Minutes of inactivity before the screen times out.</summary>
        public int? PasswordMinutesOfInactivityBeforeScreenTimeout {
            get { return BackingStore?.Get<int?>("passwordMinutesOfInactivityBeforeScreenTimeout"); }
            set { BackingStore?.Set("passwordMinutesOfInactivityBeforeScreenTimeout", value); }
        }
        /// <summary>Indicates the length of password history, where the user will not be able to enter a new password that is the same as any password in the history. Valid values 0 to 24</summary>
        public int? PasswordPreviousPasswordCountToBlock {
            get { return BackingStore?.Get<int?>("passwordPreviousPasswordCountToBlock"); }
            set { BackingStore?.Set("passwordPreviousPasswordCountToBlock", value); }
        }
        /// <summary>Indicates the minimum password quality required on the device. Possible values are: deviceDefault, required, numeric, numericComplex, alphabetic, alphanumeric, alphanumericWithSymbols, lowSecurityBiometric, customPassword.</summary>
        public AndroidDeviceOwnerRequiredPasswordType? PasswordRequiredType {
            get { return BackingStore?.Get<AndroidDeviceOwnerRequiredPasswordType?>("passwordRequiredType"); }
            set { BackingStore?.Set("passwordRequiredType", value); }
        }
        /// <summary>Indicates the timeout period after which a device must be unlocked using a form of strong authentication. Possible values are: deviceDefault, daily, unkownFutureValue.</summary>
        public AndroidDeviceOwnerRequiredPasswordUnlock? PasswordRequireUnlock {
            get { return BackingStore?.Get<AndroidDeviceOwnerRequiredPasswordUnlock?>("passwordRequireUnlock"); }
            set { BackingStore?.Set("passwordRequireUnlock", value); }
        }
        /// <summary>Indicates the number of times a user can enter an incorrect password before the device is wiped. Valid values 4 to 11</summary>
        public int? PasswordSignInFailureCountBeforeFactoryReset {
            get { return BackingStore?.Get<int?>("passwordSignInFailureCountBeforeFactoryReset"); }
            set { BackingStore?.Set("passwordSignInFailureCountBeforeFactoryReset", value); }
        }
        /// <summary>Indicates whether the user can install apps from unknown sources on the personal profile.</summary>
        public bool? PersonalProfileAppsAllowInstallFromUnknownSources {
            get { return BackingStore?.Get<bool?>("personalProfileAppsAllowInstallFromUnknownSources"); }
            set { BackingStore?.Set("personalProfileAppsAllowInstallFromUnknownSources", value); }
        }
        /// <summary>Indicates whether to disable the use of the camera on the personal profile.</summary>
        public bool? PersonalProfileCameraBlocked {
            get { return BackingStore?.Get<bool?>("personalProfileCameraBlocked"); }
            set { BackingStore?.Set("personalProfileCameraBlocked", value); }
        }
        /// <summary>Policy applied to applications in the personal profile. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AppListItem>? PersonalProfilePersonalApplications {
            get { return BackingStore?.Get<List<AppListItem>?>("personalProfilePersonalApplications"); }
            set { BackingStore?.Set("personalProfilePersonalApplications", value); }
        }
#nullable restore
#else
        public List<AppListItem> PersonalProfilePersonalApplications {
            get { return BackingStore?.Get<List<AppListItem>>("personalProfilePersonalApplications"); }
            set { BackingStore?.Set("personalProfilePersonalApplications", value); }
        }
#endif
        /// <summary>Used together with PersonalProfilePersonalApplications to control how apps in the personal profile are allowed or blocked. Possible values are: notConfigured, blockedApps, allowedApps.</summary>
        public PersonalProfilePersonalPlayStoreMode? PersonalProfilePlayStoreMode {
            get { return BackingStore?.Get<PersonalProfilePersonalPlayStoreMode?>("personalProfilePlayStoreMode"); }
            set { BackingStore?.Set("personalProfilePlayStoreMode", value); }
        }
        /// <summary>Indicates whether to disable the capability to take screenshots on the personal profile.</summary>
        public bool? PersonalProfileScreenCaptureBlocked {
            get { return BackingStore?.Get<bool?>("personalProfileScreenCaptureBlocked"); }
            set { BackingStore?.Set("personalProfileScreenCaptureBlocked", value); }
        }
        /// <summary>Indicates the Play Store mode of the device. Possible values are: notConfigured, allowList, blockList.</summary>
        public AndroidDeviceOwnerPlayStoreMode? PlayStoreMode {
            get { return BackingStore?.Get<AndroidDeviceOwnerPlayStoreMode?>("playStoreMode"); }
            set { BackingStore?.Set("playStoreMode", value); }
        }
        /// <summary>Indicates whether or not to disable the capability to take screenshots.</summary>
        public bool? ScreenCaptureBlocked {
            get { return BackingStore?.Get<bool?>("screenCaptureBlocked"); }
            set { BackingStore?.Set("screenCaptureBlocked", value); }
        }
        /// <summary>Represents the security common criteria mode enabled provided to users when they attempt to modify managed settings on their device.</summary>
        public bool? SecurityCommonCriteriaModeEnabled {
            get { return BackingStore?.Get<bool?>("securityCommonCriteriaModeEnabled"); }
            set { BackingStore?.Set("securityCommonCriteriaModeEnabled", value); }
        }
        /// <summary>Indicates whether or not the user is allowed to access developer settings like developer options and safe boot on the device.</summary>
        public bool? SecurityDeveloperSettingsEnabled {
            get { return BackingStore?.Get<bool?>("securityDeveloperSettingsEnabled"); }
            set { BackingStore?.Set("securityDeveloperSettingsEnabled", value); }
        }
        /// <summary>Indicates whether or not verify apps is required.</summary>
        public bool? SecurityRequireVerifyApps {
            get { return BackingStore?.Get<bool?>("securityRequireVerifyApps"); }
            set { BackingStore?.Set("securityRequireVerifyApps", value); }
        }
        /// <summary>Represents the customized short help text provided to users when they attempt to modify managed settings on their device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AndroidDeviceOwnerUserFacingMessage? ShortHelpText {
            get { return BackingStore?.Get<AndroidDeviceOwnerUserFacingMessage?>("shortHelpText"); }
            set { BackingStore?.Set("shortHelpText", value); }
        }
#nullable restore
#else
        public AndroidDeviceOwnerUserFacingMessage ShortHelpText {
            get { return BackingStore?.Get<AndroidDeviceOwnerUserFacingMessage>("shortHelpText"); }
            set { BackingStore?.Set("shortHelpText", value); }
        }
#endif
        /// <summary>Indicates whether or the status bar is disabled, including notifications, quick settings and other screen overlays.</summary>
        public bool? StatusBarBlocked {
            get { return BackingStore?.Get<bool?>("statusBarBlocked"); }
            set { BackingStore?.Set("statusBarBlocked", value); }
        }
        /// <summary>List of modes in which the device&apos;s display will stay powered-on. This collection can contain a maximum of 4 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AndroidDeviceOwnerBatteryPluggedMode?>? StayOnModes {
            get { return BackingStore?.Get<List<AndroidDeviceOwnerBatteryPluggedMode?>?>("stayOnModes"); }
            set { BackingStore?.Set("stayOnModes", value); }
        }
#nullable restore
#else
        public List<AndroidDeviceOwnerBatteryPluggedMode?> StayOnModes {
            get { return BackingStore?.Get<List<AndroidDeviceOwnerBatteryPluggedMode?>>("stayOnModes"); }
            set { BackingStore?.Set("stayOnModes", value); }
        }
#endif
        /// <summary>Indicates whether or not to allow USB mass storage.</summary>
        public bool? StorageAllowUsb {
            get { return BackingStore?.Get<bool?>("storageAllowUsb"); }
            set { BackingStore?.Set("storageAllowUsb", value); }
        }
        /// <summary>Indicates whether or not to block external media.</summary>
        public bool? StorageBlockExternalMedia {
            get { return BackingStore?.Get<bool?>("storageBlockExternalMedia"); }
            set { BackingStore?.Set("storageBlockExternalMedia", value); }
        }
        /// <summary>Indicates whether or not to block USB file transfer.</summary>
        public bool? StorageBlockUsbFileTransfer {
            get { return BackingStore?.Get<bool?>("storageBlockUsbFileTransfer"); }
            set { BackingStore?.Set("storageBlockUsbFileTransfer", value); }
        }
        /// <summary>Indicates the annually repeating time periods during which system updates are postponed. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AndroidDeviceOwnerSystemUpdateFreezePeriod>? SystemUpdateFreezePeriods {
            get { return BackingStore?.Get<List<AndroidDeviceOwnerSystemUpdateFreezePeriod>?>("systemUpdateFreezePeriods"); }
            set { BackingStore?.Set("systemUpdateFreezePeriods", value); }
        }
#nullable restore
#else
        public List<AndroidDeviceOwnerSystemUpdateFreezePeriod> SystemUpdateFreezePeriods {
            get { return BackingStore?.Get<List<AndroidDeviceOwnerSystemUpdateFreezePeriod>>("systemUpdateFreezePeriods"); }
            set { BackingStore?.Set("systemUpdateFreezePeriods", value); }
        }
#endif
        /// <summary>The type of system update configuration. Possible values are: deviceDefault, postpone, windowed, automatic.</summary>
        public AndroidDeviceOwnerSystemUpdateInstallType? SystemUpdateInstallType {
            get { return BackingStore?.Get<AndroidDeviceOwnerSystemUpdateInstallType?>("systemUpdateInstallType"); }
            set { BackingStore?.Set("systemUpdateInstallType", value); }
        }
        /// <summary>Indicates the number of minutes after midnight that the system update window ends. Valid values 0 to 1440</summary>
        public int? SystemUpdateWindowEndMinutesAfterMidnight {
            get { return BackingStore?.Get<int?>("systemUpdateWindowEndMinutesAfterMidnight"); }
            set { BackingStore?.Set("systemUpdateWindowEndMinutesAfterMidnight", value); }
        }
        /// <summary>Indicates the number of minutes after midnight that the system update window starts. Valid values 0 to 1440</summary>
        public int? SystemUpdateWindowStartMinutesAfterMidnight {
            get { return BackingStore?.Get<int?>("systemUpdateWindowStartMinutesAfterMidnight"); }
            set { BackingStore?.Set("systemUpdateWindowStartMinutesAfterMidnight", value); }
        }
        /// <summary>Whether or not to block Android system prompt windows, like toasts, phone activities, and system alerts.</summary>
        public bool? SystemWindowsBlocked {
            get { return BackingStore?.Get<bool?>("systemWindowsBlocked"); }
            set { BackingStore?.Set("systemWindowsBlocked", value); }
        }
        /// <summary>Indicates whether or not adding users and profiles is disabled.</summary>
        public bool? UsersBlockAdd {
            get { return BackingStore?.Get<bool?>("usersBlockAdd"); }
            set { BackingStore?.Set("usersBlockAdd", value); }
        }
        /// <summary>Indicates whether or not to disable removing other users from the device.</summary>
        public bool? UsersBlockRemove {
            get { return BackingStore?.Get<bool?>("usersBlockRemove"); }
            set { BackingStore?.Set("usersBlockRemove", value); }
        }
        /// <summary>Indicates whether or not adjusting the master volume is disabled.</summary>
        public bool? VolumeBlockAdjustment {
            get { return BackingStore?.Get<bool?>("volumeBlockAdjustment"); }
            set { BackingStore?.Set("volumeBlockAdjustment", value); }
        }
        /// <summary>If an always on VPN package name is specified, whether or not to lock network traffic when that VPN is disconnected.</summary>
        public bool? VpnAlwaysOnLockdownMode {
            get { return BackingStore?.Get<bool?>("vpnAlwaysOnLockdownMode"); }
            set { BackingStore?.Set("vpnAlwaysOnLockdownMode", value); }
        }
        /// <summary>Android app package name for app that will handle an always-on VPN connection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VpnAlwaysOnPackageIdentifier {
            get { return BackingStore?.Get<string?>("vpnAlwaysOnPackageIdentifier"); }
            set { BackingStore?.Set("vpnAlwaysOnPackageIdentifier", value); }
        }
#nullable restore
#else
        public string VpnAlwaysOnPackageIdentifier {
            get { return BackingStore?.Get<string>("vpnAlwaysOnPackageIdentifier"); }
            set { BackingStore?.Set("vpnAlwaysOnPackageIdentifier", value); }
        }
#endif
        /// <summary>Indicates whether or not to block the user from editing the wifi connection settings.</summary>
        public bool? WifiBlockEditConfigurations {
            get { return BackingStore?.Get<bool?>("wifiBlockEditConfigurations"); }
            set { BackingStore?.Set("wifiBlockEditConfigurations", value); }
        }
        /// <summary>Indicates whether or not to block the user from editing just the networks defined by the policy.</summary>
        public bool? WifiBlockEditPolicyDefinedConfigurations {
            get { return BackingStore?.Get<bool?>("wifiBlockEditPolicyDefinedConfigurations"); }
            set { BackingStore?.Set("wifiBlockEditPolicyDefinedConfigurations", value); }
        }
        /// <summary>Indicates the number of days that a work profile password can be set before it expires and a new password will be required. Valid values 1 to 365</summary>
        public int? WorkProfilePasswordExpirationDays {
            get { return BackingStore?.Get<int?>("workProfilePasswordExpirationDays"); }
            set { BackingStore?.Set("workProfilePasswordExpirationDays", value); }
        }
        /// <summary>Indicates the minimum length of the work profile password. Valid values 4 to 16</summary>
        public int? WorkProfilePasswordMinimumLength {
            get { return BackingStore?.Get<int?>("workProfilePasswordMinimumLength"); }
            set { BackingStore?.Set("workProfilePasswordMinimumLength", value); }
        }
        /// <summary>Indicates the minimum number of letter characters required for the work profile password. Valid values 1 to 16</summary>
        public int? WorkProfilePasswordMinimumLetterCharacters {
            get { return BackingStore?.Get<int?>("workProfilePasswordMinimumLetterCharacters"); }
            set { BackingStore?.Set("workProfilePasswordMinimumLetterCharacters", value); }
        }
        /// <summary>Indicates the minimum number of lower-case characters required for the work profile password. Valid values 1 to 16</summary>
        public int? WorkProfilePasswordMinimumLowerCaseCharacters {
            get { return BackingStore?.Get<int?>("workProfilePasswordMinimumLowerCaseCharacters"); }
            set { BackingStore?.Set("workProfilePasswordMinimumLowerCaseCharacters", value); }
        }
        /// <summary>Indicates the minimum number of non-letter characters required for the work profile password. Valid values 1 to 16</summary>
        public int? WorkProfilePasswordMinimumNonLetterCharacters {
            get { return BackingStore?.Get<int?>("workProfilePasswordMinimumNonLetterCharacters"); }
            set { BackingStore?.Set("workProfilePasswordMinimumNonLetterCharacters", value); }
        }
        /// <summary>Indicates the minimum number of numeric characters required for the work profile password. Valid values 1 to 16</summary>
        public int? WorkProfilePasswordMinimumNumericCharacters {
            get { return BackingStore?.Get<int?>("workProfilePasswordMinimumNumericCharacters"); }
            set { BackingStore?.Set("workProfilePasswordMinimumNumericCharacters", value); }
        }
        /// <summary>Indicates the minimum number of symbol characters required for the work profile password. Valid values 1 to 16</summary>
        public int? WorkProfilePasswordMinimumSymbolCharacters {
            get { return BackingStore?.Get<int?>("workProfilePasswordMinimumSymbolCharacters"); }
            set { BackingStore?.Set("workProfilePasswordMinimumSymbolCharacters", value); }
        }
        /// <summary>Indicates the minimum number of upper-case letter characters required for the work profile password. Valid values 1 to 16</summary>
        public int? WorkProfilePasswordMinimumUpperCaseCharacters {
            get { return BackingStore?.Get<int?>("workProfilePasswordMinimumUpperCaseCharacters"); }
            set { BackingStore?.Set("workProfilePasswordMinimumUpperCaseCharacters", value); }
        }
        /// <summary>Indicates the length of the work profile password history, where the user will not be able to enter a new password that is the same as any password in the history. Valid values 0 to 24</summary>
        public int? WorkProfilePasswordPreviousPasswordCountToBlock {
            get { return BackingStore?.Get<int?>("workProfilePasswordPreviousPasswordCountToBlock"); }
            set { BackingStore?.Set("workProfilePasswordPreviousPasswordCountToBlock", value); }
        }
        /// <summary>Indicates the minimum password quality required on the work profile password. Possible values are: deviceDefault, required, numeric, numericComplex, alphabetic, alphanumeric, alphanumericWithSymbols, lowSecurityBiometric, customPassword.</summary>
        public AndroidDeviceOwnerRequiredPasswordType? WorkProfilePasswordRequiredType {
            get { return BackingStore?.Get<AndroidDeviceOwnerRequiredPasswordType?>("workProfilePasswordRequiredType"); }
            set { BackingStore?.Set("workProfilePasswordRequiredType", value); }
        }
        /// <summary>Indicates the timeout period after which a work profile must be unlocked using a form of strong authentication. Possible values are: deviceDefault, daily, unkownFutureValue.</summary>
        public AndroidDeviceOwnerRequiredPasswordUnlock? WorkProfilePasswordRequireUnlock {
            get { return BackingStore?.Get<AndroidDeviceOwnerRequiredPasswordUnlock?>("workProfilePasswordRequireUnlock"); }
            set { BackingStore?.Set("workProfilePasswordRequireUnlock", value); }
        }
        /// <summary>Indicates the number of times a user can enter an incorrect work profile password before the device is wiped. Valid values 4 to 11</summary>
        public int? WorkProfilePasswordSignInFailureCountBeforeFactoryReset {
            get { return BackingStore?.Get<int?>("workProfilePasswordSignInFailureCountBeforeFactoryReset"); }
            set { BackingStore?.Set("workProfilePasswordSignInFailureCountBeforeFactoryReset", value); }
        }
        /// <summary>
        /// Instantiates a new androidDeviceOwnerGeneralDeviceConfiguration and sets the default values.
        /// </summary>
        public AndroidDeviceOwnerGeneralDeviceConfiguration() : base() {
            OdataType = "#microsoft.graph.androidDeviceOwnerGeneralDeviceConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AndroidDeviceOwnerGeneralDeviceConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidDeviceOwnerGeneralDeviceConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accountsBlockModification", n => { AccountsBlockModification = n.GetBoolValue(); } },
                {"appsAllowInstallFromUnknownSources", n => { AppsAllowInstallFromUnknownSources = n.GetBoolValue(); } },
                {"appsAutoUpdatePolicy", n => { AppsAutoUpdatePolicy = n.GetEnumValue<AndroidDeviceOwnerAppAutoUpdatePolicyType>(); } },
                {"appsDefaultPermissionPolicy", n => { AppsDefaultPermissionPolicy = n.GetEnumValue<AndroidDeviceOwnerDefaultAppPermissionPolicyType>(); } },
                {"appsRecommendSkippingFirstUseHints", n => { AppsRecommendSkippingFirstUseHints = n.GetBoolValue(); } },
                {"azureAdSharedDeviceDataClearApps", n => { AzureAdSharedDeviceDataClearApps = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"bluetoothBlockConfiguration", n => { BluetoothBlockConfiguration = n.GetBoolValue(); } },
                {"bluetoothBlockContactSharing", n => { BluetoothBlockContactSharing = n.GetBoolValue(); } },
                {"cameraBlocked", n => { CameraBlocked = n.GetBoolValue(); } },
                {"cellularBlockWiFiTethering", n => { CellularBlockWiFiTethering = n.GetBoolValue(); } },
                {"certificateCredentialConfigurationDisabled", n => { CertificateCredentialConfigurationDisabled = n.GetBoolValue(); } },
                {"crossProfilePoliciesAllowCopyPaste", n => { CrossProfilePoliciesAllowCopyPaste = n.GetBoolValue(); } },
                {"crossProfilePoliciesAllowDataSharing", n => { CrossProfilePoliciesAllowDataSharing = n.GetEnumValue<AndroidDeviceOwnerCrossProfileDataSharing>(); } },
                {"crossProfilePoliciesShowWorkContactsInPersonalProfile", n => { CrossProfilePoliciesShowWorkContactsInPersonalProfile = n.GetBoolValue(); } },
                {"dataRoamingBlocked", n => { DataRoamingBlocked = n.GetBoolValue(); } },
                {"dateTimeConfigurationBlocked", n => { DateTimeConfigurationBlocked = n.GetBoolValue(); } },
                {"detailedHelpText", n => { DetailedHelpText = n.GetObjectValue<AndroidDeviceOwnerUserFacingMessage>(AndroidDeviceOwnerUserFacingMessage.CreateFromDiscriminatorValue); } },
                {"deviceOwnerLockScreenMessage", n => { DeviceOwnerLockScreenMessage = n.GetObjectValue<AndroidDeviceOwnerUserFacingMessage>(AndroidDeviceOwnerUserFacingMessage.CreateFromDiscriminatorValue); } },
                {"enrollmentProfile", n => { EnrollmentProfile = n.GetEnumValue<AndroidDeviceOwnerEnrollmentProfileType>(); } },
                {"factoryResetBlocked", n => { FactoryResetBlocked = n.GetBoolValue(); } },
                {"factoryResetDeviceAdministratorEmails", n => { FactoryResetDeviceAdministratorEmails = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"globalProxy", n => { GlobalProxy = n.GetObjectValue<AndroidDeviceOwnerGlobalProxy>(AndroidDeviceOwnerGlobalProxy.CreateFromDiscriminatorValue); } },
                {"googleAccountsBlocked", n => { GoogleAccountsBlocked = n.GetBoolValue(); } },
                {"kioskCustomizationDeviceSettingsBlocked", n => { KioskCustomizationDeviceSettingsBlocked = n.GetBoolValue(); } },
                {"kioskCustomizationPowerButtonActionsBlocked", n => { KioskCustomizationPowerButtonActionsBlocked = n.GetBoolValue(); } },
                {"kioskCustomizationStatusBar", n => { KioskCustomizationStatusBar = n.GetEnumValue<AndroidDeviceOwnerKioskCustomizationStatusBar>(); } },
                {"kioskCustomizationSystemErrorWarnings", n => { KioskCustomizationSystemErrorWarnings = n.GetBoolValue(); } },
                {"kioskCustomizationSystemNavigation", n => { KioskCustomizationSystemNavigation = n.GetEnumValue<AndroidDeviceOwnerKioskCustomizationSystemNavigation>(); } },
                {"kioskModeAppOrderEnabled", n => { KioskModeAppOrderEnabled = n.GetBoolValue(); } },
                {"kioskModeAppPositions", n => { KioskModeAppPositions = n.GetCollectionOfObjectValues<AndroidDeviceOwnerKioskModeAppPositionItem>(AndroidDeviceOwnerKioskModeAppPositionItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"kioskModeApps", n => { KioskModeApps = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"kioskModeAppsInFolderOrderedByName", n => { KioskModeAppsInFolderOrderedByName = n.GetBoolValue(); } },
                {"kioskModeBluetoothConfigurationEnabled", n => { KioskModeBluetoothConfigurationEnabled = n.GetBoolValue(); } },
                {"kioskModeDebugMenuEasyAccessEnabled", n => { KioskModeDebugMenuEasyAccessEnabled = n.GetBoolValue(); } },
                {"kioskModeExitCode", n => { KioskModeExitCode = n.GetStringValue(); } },
                {"kioskModeFlashlightConfigurationEnabled", n => { KioskModeFlashlightConfigurationEnabled = n.GetBoolValue(); } },
                {"kioskModeFolderIcon", n => { KioskModeFolderIcon = n.GetEnumValue<AndroidDeviceOwnerKioskModeFolderIcon>(); } },
                {"kioskModeGridHeight", n => { KioskModeGridHeight = n.GetIntValue(); } },
                {"kioskModeGridWidth", n => { KioskModeGridWidth = n.GetIntValue(); } },
                {"kioskModeIconSize", n => { KioskModeIconSize = n.GetEnumValue<AndroidDeviceOwnerKioskModeIconSize>(); } },
                {"kioskModeLockHomeScreen", n => { KioskModeLockHomeScreen = n.GetBoolValue(); } },
                {"kioskModeManagedFolders", n => { KioskModeManagedFolders = n.GetCollectionOfObjectValues<AndroidDeviceOwnerKioskModeManagedFolder>(AndroidDeviceOwnerKioskModeManagedFolder.CreateFromDiscriminatorValue)?.ToList(); } },
                {"kioskModeManagedHomeScreenAutoSignout", n => { KioskModeManagedHomeScreenAutoSignout = n.GetBoolValue(); } },
                {"kioskModeManagedHomeScreenInactiveSignOutDelayInSeconds", n => { KioskModeManagedHomeScreenInactiveSignOutDelayInSeconds = n.GetIntValue(); } },
                {"kioskModeManagedHomeScreenInactiveSignOutNoticeInSeconds", n => { KioskModeManagedHomeScreenInactiveSignOutNoticeInSeconds = n.GetIntValue(); } },
                {"kioskModeManagedHomeScreenPinComplexity", n => { KioskModeManagedHomeScreenPinComplexity = n.GetEnumValue<KioskModeManagedHomeScreenPinComplexity>(); } },
                {"kioskModeManagedHomeScreenPinRequired", n => { KioskModeManagedHomeScreenPinRequired = n.GetBoolValue(); } },
                {"kioskModeManagedHomeScreenPinRequiredToResume", n => { KioskModeManagedHomeScreenPinRequiredToResume = n.GetBoolValue(); } },
                {"kioskModeManagedHomeScreenSignInBackground", n => { KioskModeManagedHomeScreenSignInBackground = n.GetStringValue(); } },
                {"kioskModeManagedHomeScreenSignInBrandingLogo", n => { KioskModeManagedHomeScreenSignInBrandingLogo = n.GetStringValue(); } },
                {"kioskModeManagedHomeScreenSignInEnabled", n => { KioskModeManagedHomeScreenSignInEnabled = n.GetBoolValue(); } },
                {"kioskModeManagedSettingsEntryDisabled", n => { KioskModeManagedSettingsEntryDisabled = n.GetBoolValue(); } },
                {"kioskModeMediaVolumeConfigurationEnabled", n => { KioskModeMediaVolumeConfigurationEnabled = n.GetBoolValue(); } },
                {"kioskModeScreenOrientation", n => { KioskModeScreenOrientation = n.GetEnumValue<AndroidDeviceOwnerKioskModeScreenOrientation>(); } },
                {"kioskModeScreenSaverConfigurationEnabled", n => { KioskModeScreenSaverConfigurationEnabled = n.GetBoolValue(); } },
                {"kioskModeScreenSaverDetectMediaDisabled", n => { KioskModeScreenSaverDetectMediaDisabled = n.GetBoolValue(); } },
                {"kioskModeScreenSaverDisplayTimeInSeconds", n => { KioskModeScreenSaverDisplayTimeInSeconds = n.GetIntValue(); } },
                {"kioskModeScreenSaverImageUrl", n => { KioskModeScreenSaverImageUrl = n.GetStringValue(); } },
                {"kioskModeScreenSaverStartDelayInSeconds", n => { KioskModeScreenSaverStartDelayInSeconds = n.GetIntValue(); } },
                {"kioskModeShowAppNotificationBadge", n => { KioskModeShowAppNotificationBadge = n.GetBoolValue(); } },
                {"kioskModeShowDeviceInfo", n => { KioskModeShowDeviceInfo = n.GetBoolValue(); } },
                {"kioskModeUseManagedHomeScreenApp", n => { KioskModeUseManagedHomeScreenApp = n.GetEnumValue<KioskModeType>(); } },
                {"kioskModeVirtualHomeButtonEnabled", n => { KioskModeVirtualHomeButtonEnabled = n.GetBoolValue(); } },
                {"kioskModeVirtualHomeButtonType", n => { KioskModeVirtualHomeButtonType = n.GetEnumValue<AndroidDeviceOwnerVirtualHomeButtonType>(); } },
                {"kioskModeWallpaperUrl", n => { KioskModeWallpaperUrl = n.GetStringValue(); } },
                {"kioskModeWifiAllowedSsids", n => { KioskModeWifiAllowedSsids = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"kioskModeWiFiConfigurationEnabled", n => { KioskModeWiFiConfigurationEnabled = n.GetBoolValue(); } },
                {"locateDeviceLostModeEnabled", n => { LocateDeviceLostModeEnabled = n.GetBoolValue(); } },
                {"locateDeviceUserlessDisabled", n => { LocateDeviceUserlessDisabled = n.GetBoolValue(); } },
                {"microphoneForceMute", n => { MicrophoneForceMute = n.GetBoolValue(); } },
                {"microsoftLauncherConfigurationEnabled", n => { MicrosoftLauncherConfigurationEnabled = n.GetBoolValue(); } },
                {"microsoftLauncherCustomWallpaperAllowUserModification", n => { MicrosoftLauncherCustomWallpaperAllowUserModification = n.GetBoolValue(); } },
                {"microsoftLauncherCustomWallpaperEnabled", n => { MicrosoftLauncherCustomWallpaperEnabled = n.GetBoolValue(); } },
                {"microsoftLauncherCustomWallpaperImageUrl", n => { MicrosoftLauncherCustomWallpaperImageUrl = n.GetStringValue(); } },
                {"microsoftLauncherDockPresenceAllowUserModification", n => { MicrosoftLauncherDockPresenceAllowUserModification = n.GetBoolValue(); } },
                {"microsoftLauncherDockPresenceConfiguration", n => { MicrosoftLauncherDockPresenceConfiguration = n.GetEnumValue<MicrosoftLauncherDockPresence>(); } },
                {"microsoftLauncherFeedAllowUserModification", n => { MicrosoftLauncherFeedAllowUserModification = n.GetBoolValue(); } },
                {"microsoftLauncherFeedEnabled", n => { MicrosoftLauncherFeedEnabled = n.GetBoolValue(); } },
                {"microsoftLauncherSearchBarPlacementConfiguration", n => { MicrosoftLauncherSearchBarPlacementConfiguration = n.GetEnumValue<MicrosoftLauncherSearchBarPlacement>(); } },
                {"networkEscapeHatchAllowed", n => { NetworkEscapeHatchAllowed = n.GetBoolValue(); } },
                {"nfcBlockOutgoingBeam", n => { NfcBlockOutgoingBeam = n.GetBoolValue(); } },
                {"passwordBlockKeyguard", n => { PasswordBlockKeyguard = n.GetBoolValue(); } },
                {"passwordBlockKeyguardFeatures", n => { PasswordBlockKeyguardFeatures = n.GetCollectionOfEnumValues<AndroidKeyguardFeature>()?.ToList(); } },
                {"passwordExpirationDays", n => { PasswordExpirationDays = n.GetIntValue(); } },
                {"passwordMinimumLength", n => { PasswordMinimumLength = n.GetIntValue(); } },
                {"passwordMinimumLetterCharacters", n => { PasswordMinimumLetterCharacters = n.GetIntValue(); } },
                {"passwordMinimumLowerCaseCharacters", n => { PasswordMinimumLowerCaseCharacters = n.GetIntValue(); } },
                {"passwordMinimumNonLetterCharacters", n => { PasswordMinimumNonLetterCharacters = n.GetIntValue(); } },
                {"passwordMinimumNumericCharacters", n => { PasswordMinimumNumericCharacters = n.GetIntValue(); } },
                {"passwordMinimumSymbolCharacters", n => { PasswordMinimumSymbolCharacters = n.GetIntValue(); } },
                {"passwordMinimumUpperCaseCharacters", n => { PasswordMinimumUpperCaseCharacters = n.GetIntValue(); } },
                {"passwordMinutesOfInactivityBeforeScreenTimeout", n => { PasswordMinutesOfInactivityBeforeScreenTimeout = n.GetIntValue(); } },
                {"passwordPreviousPasswordCountToBlock", n => { PasswordPreviousPasswordCountToBlock = n.GetIntValue(); } },
                {"passwordRequiredType", n => { PasswordRequiredType = n.GetEnumValue<AndroidDeviceOwnerRequiredPasswordType>(); } },
                {"passwordRequireUnlock", n => { PasswordRequireUnlock = n.GetEnumValue<AndroidDeviceOwnerRequiredPasswordUnlock>(); } },
                {"passwordSignInFailureCountBeforeFactoryReset", n => { PasswordSignInFailureCountBeforeFactoryReset = n.GetIntValue(); } },
                {"personalProfileAppsAllowInstallFromUnknownSources", n => { PersonalProfileAppsAllowInstallFromUnknownSources = n.GetBoolValue(); } },
                {"personalProfileCameraBlocked", n => { PersonalProfileCameraBlocked = n.GetBoolValue(); } },
                {"personalProfilePersonalApplications", n => { PersonalProfilePersonalApplications = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"personalProfilePlayStoreMode", n => { PersonalProfilePlayStoreMode = n.GetEnumValue<PersonalProfilePersonalPlayStoreMode>(); } },
                {"personalProfileScreenCaptureBlocked", n => { PersonalProfileScreenCaptureBlocked = n.GetBoolValue(); } },
                {"playStoreMode", n => { PlayStoreMode = n.GetEnumValue<AndroidDeviceOwnerPlayStoreMode>(); } },
                {"screenCaptureBlocked", n => { ScreenCaptureBlocked = n.GetBoolValue(); } },
                {"securityCommonCriteriaModeEnabled", n => { SecurityCommonCriteriaModeEnabled = n.GetBoolValue(); } },
                {"securityDeveloperSettingsEnabled", n => { SecurityDeveloperSettingsEnabled = n.GetBoolValue(); } },
                {"securityRequireVerifyApps", n => { SecurityRequireVerifyApps = n.GetBoolValue(); } },
                {"shortHelpText", n => { ShortHelpText = n.GetObjectValue<AndroidDeviceOwnerUserFacingMessage>(AndroidDeviceOwnerUserFacingMessage.CreateFromDiscriminatorValue); } },
                {"statusBarBlocked", n => { StatusBarBlocked = n.GetBoolValue(); } },
                {"stayOnModes", n => { StayOnModes = n.GetCollectionOfEnumValues<AndroidDeviceOwnerBatteryPluggedMode>()?.ToList(); } },
                {"storageAllowUsb", n => { StorageAllowUsb = n.GetBoolValue(); } },
                {"storageBlockExternalMedia", n => { StorageBlockExternalMedia = n.GetBoolValue(); } },
                {"storageBlockUsbFileTransfer", n => { StorageBlockUsbFileTransfer = n.GetBoolValue(); } },
                {"systemUpdateFreezePeriods", n => { SystemUpdateFreezePeriods = n.GetCollectionOfObjectValues<AndroidDeviceOwnerSystemUpdateFreezePeriod>(AndroidDeviceOwnerSystemUpdateFreezePeriod.CreateFromDiscriminatorValue)?.ToList(); } },
                {"systemUpdateInstallType", n => { SystemUpdateInstallType = n.GetEnumValue<AndroidDeviceOwnerSystemUpdateInstallType>(); } },
                {"systemUpdateWindowEndMinutesAfterMidnight", n => { SystemUpdateWindowEndMinutesAfterMidnight = n.GetIntValue(); } },
                {"systemUpdateWindowStartMinutesAfterMidnight", n => { SystemUpdateWindowStartMinutesAfterMidnight = n.GetIntValue(); } },
                {"systemWindowsBlocked", n => { SystemWindowsBlocked = n.GetBoolValue(); } },
                {"usersBlockAdd", n => { UsersBlockAdd = n.GetBoolValue(); } },
                {"usersBlockRemove", n => { UsersBlockRemove = n.GetBoolValue(); } },
                {"volumeBlockAdjustment", n => { VolumeBlockAdjustment = n.GetBoolValue(); } },
                {"vpnAlwaysOnLockdownMode", n => { VpnAlwaysOnLockdownMode = n.GetBoolValue(); } },
                {"vpnAlwaysOnPackageIdentifier", n => { VpnAlwaysOnPackageIdentifier = n.GetStringValue(); } },
                {"wifiBlockEditConfigurations", n => { WifiBlockEditConfigurations = n.GetBoolValue(); } },
                {"wifiBlockEditPolicyDefinedConfigurations", n => { WifiBlockEditPolicyDefinedConfigurations = n.GetBoolValue(); } },
                {"workProfilePasswordExpirationDays", n => { WorkProfilePasswordExpirationDays = n.GetIntValue(); } },
                {"workProfilePasswordMinimumLength", n => { WorkProfilePasswordMinimumLength = n.GetIntValue(); } },
                {"workProfilePasswordMinimumLetterCharacters", n => { WorkProfilePasswordMinimumLetterCharacters = n.GetIntValue(); } },
                {"workProfilePasswordMinimumLowerCaseCharacters", n => { WorkProfilePasswordMinimumLowerCaseCharacters = n.GetIntValue(); } },
                {"workProfilePasswordMinimumNonLetterCharacters", n => { WorkProfilePasswordMinimumNonLetterCharacters = n.GetIntValue(); } },
                {"workProfilePasswordMinimumNumericCharacters", n => { WorkProfilePasswordMinimumNumericCharacters = n.GetIntValue(); } },
                {"workProfilePasswordMinimumSymbolCharacters", n => { WorkProfilePasswordMinimumSymbolCharacters = n.GetIntValue(); } },
                {"workProfilePasswordMinimumUpperCaseCharacters", n => { WorkProfilePasswordMinimumUpperCaseCharacters = n.GetIntValue(); } },
                {"workProfilePasswordPreviousPasswordCountToBlock", n => { WorkProfilePasswordPreviousPasswordCountToBlock = n.GetIntValue(); } },
                {"workProfilePasswordRequiredType", n => { WorkProfilePasswordRequiredType = n.GetEnumValue<AndroidDeviceOwnerRequiredPasswordType>(); } },
                {"workProfilePasswordRequireUnlock", n => { WorkProfilePasswordRequireUnlock = n.GetEnumValue<AndroidDeviceOwnerRequiredPasswordUnlock>(); } },
                {"workProfilePasswordSignInFailureCountBeforeFactoryReset", n => { WorkProfilePasswordSignInFailureCountBeforeFactoryReset = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("accountsBlockModification", AccountsBlockModification);
            writer.WriteBoolValue("appsAllowInstallFromUnknownSources", AppsAllowInstallFromUnknownSources);
            writer.WriteEnumValue<AndroidDeviceOwnerAppAutoUpdatePolicyType>("appsAutoUpdatePolicy", AppsAutoUpdatePolicy);
            writer.WriteEnumValue<AndroidDeviceOwnerDefaultAppPermissionPolicyType>("appsDefaultPermissionPolicy", AppsDefaultPermissionPolicy);
            writer.WriteBoolValue("appsRecommendSkippingFirstUseHints", AppsRecommendSkippingFirstUseHints);
            writer.WriteCollectionOfObjectValues<AppListItem>("azureAdSharedDeviceDataClearApps", AzureAdSharedDeviceDataClearApps);
            writer.WriteBoolValue("bluetoothBlockConfiguration", BluetoothBlockConfiguration);
            writer.WriteBoolValue("bluetoothBlockContactSharing", BluetoothBlockContactSharing);
            writer.WriteBoolValue("cameraBlocked", CameraBlocked);
            writer.WriteBoolValue("cellularBlockWiFiTethering", CellularBlockWiFiTethering);
            writer.WriteBoolValue("certificateCredentialConfigurationDisabled", CertificateCredentialConfigurationDisabled);
            writer.WriteBoolValue("crossProfilePoliciesAllowCopyPaste", CrossProfilePoliciesAllowCopyPaste);
            writer.WriteEnumValue<AndroidDeviceOwnerCrossProfileDataSharing>("crossProfilePoliciesAllowDataSharing", CrossProfilePoliciesAllowDataSharing);
            writer.WriteBoolValue("crossProfilePoliciesShowWorkContactsInPersonalProfile", CrossProfilePoliciesShowWorkContactsInPersonalProfile);
            writer.WriteBoolValue("dataRoamingBlocked", DataRoamingBlocked);
            writer.WriteBoolValue("dateTimeConfigurationBlocked", DateTimeConfigurationBlocked);
            writer.WriteObjectValue<AndroidDeviceOwnerUserFacingMessage>("detailedHelpText", DetailedHelpText);
            writer.WriteObjectValue<AndroidDeviceOwnerUserFacingMessage>("deviceOwnerLockScreenMessage", DeviceOwnerLockScreenMessage);
            writer.WriteEnumValue<AndroidDeviceOwnerEnrollmentProfileType>("enrollmentProfile", EnrollmentProfile);
            writer.WriteBoolValue("factoryResetBlocked", FactoryResetBlocked);
            writer.WriteCollectionOfPrimitiveValues<string>("factoryResetDeviceAdministratorEmails", FactoryResetDeviceAdministratorEmails);
            writer.WriteObjectValue<AndroidDeviceOwnerGlobalProxy>("globalProxy", GlobalProxy);
            writer.WriteBoolValue("googleAccountsBlocked", GoogleAccountsBlocked);
            writer.WriteBoolValue("kioskCustomizationDeviceSettingsBlocked", KioskCustomizationDeviceSettingsBlocked);
            writer.WriteBoolValue("kioskCustomizationPowerButtonActionsBlocked", KioskCustomizationPowerButtonActionsBlocked);
            writer.WriteEnumValue<AndroidDeviceOwnerKioskCustomizationStatusBar>("kioskCustomizationStatusBar", KioskCustomizationStatusBar);
            writer.WriteBoolValue("kioskCustomizationSystemErrorWarnings", KioskCustomizationSystemErrorWarnings);
            writer.WriteEnumValue<AndroidDeviceOwnerKioskCustomizationSystemNavigation>("kioskCustomizationSystemNavigation", KioskCustomizationSystemNavigation);
            writer.WriteBoolValue("kioskModeAppOrderEnabled", KioskModeAppOrderEnabled);
            writer.WriteCollectionOfObjectValues<AndroidDeviceOwnerKioskModeAppPositionItem>("kioskModeAppPositions", KioskModeAppPositions);
            writer.WriteCollectionOfObjectValues<AppListItem>("kioskModeApps", KioskModeApps);
            writer.WriteBoolValue("kioskModeAppsInFolderOrderedByName", KioskModeAppsInFolderOrderedByName);
            writer.WriteBoolValue("kioskModeBluetoothConfigurationEnabled", KioskModeBluetoothConfigurationEnabled);
            writer.WriteBoolValue("kioskModeDebugMenuEasyAccessEnabled", KioskModeDebugMenuEasyAccessEnabled);
            writer.WriteStringValue("kioskModeExitCode", KioskModeExitCode);
            writer.WriteBoolValue("kioskModeFlashlightConfigurationEnabled", KioskModeFlashlightConfigurationEnabled);
            writer.WriteEnumValue<AndroidDeviceOwnerKioskModeFolderIcon>("kioskModeFolderIcon", KioskModeFolderIcon);
            writer.WriteIntValue("kioskModeGridHeight", KioskModeGridHeight);
            writer.WriteIntValue("kioskModeGridWidth", KioskModeGridWidth);
            writer.WriteEnumValue<AndroidDeviceOwnerKioskModeIconSize>("kioskModeIconSize", KioskModeIconSize);
            writer.WriteBoolValue("kioskModeLockHomeScreen", KioskModeLockHomeScreen);
            writer.WriteCollectionOfObjectValues<AndroidDeviceOwnerKioskModeManagedFolder>("kioskModeManagedFolders", KioskModeManagedFolders);
            writer.WriteBoolValue("kioskModeManagedHomeScreenAutoSignout", KioskModeManagedHomeScreenAutoSignout);
            writer.WriteIntValue("kioskModeManagedHomeScreenInactiveSignOutDelayInSeconds", KioskModeManagedHomeScreenInactiveSignOutDelayInSeconds);
            writer.WriteIntValue("kioskModeManagedHomeScreenInactiveSignOutNoticeInSeconds", KioskModeManagedHomeScreenInactiveSignOutNoticeInSeconds);
            writer.WriteEnumValue<KioskModeManagedHomeScreenPinComplexity>("kioskModeManagedHomeScreenPinComplexity", KioskModeManagedHomeScreenPinComplexity);
            writer.WriteBoolValue("kioskModeManagedHomeScreenPinRequired", KioskModeManagedHomeScreenPinRequired);
            writer.WriteBoolValue("kioskModeManagedHomeScreenPinRequiredToResume", KioskModeManagedHomeScreenPinRequiredToResume);
            writer.WriteStringValue("kioskModeManagedHomeScreenSignInBackground", KioskModeManagedHomeScreenSignInBackground);
            writer.WriteStringValue("kioskModeManagedHomeScreenSignInBrandingLogo", KioskModeManagedHomeScreenSignInBrandingLogo);
            writer.WriteBoolValue("kioskModeManagedHomeScreenSignInEnabled", KioskModeManagedHomeScreenSignInEnabled);
            writer.WriteBoolValue("kioskModeManagedSettingsEntryDisabled", KioskModeManagedSettingsEntryDisabled);
            writer.WriteBoolValue("kioskModeMediaVolumeConfigurationEnabled", KioskModeMediaVolumeConfigurationEnabled);
            writer.WriteEnumValue<AndroidDeviceOwnerKioskModeScreenOrientation>("kioskModeScreenOrientation", KioskModeScreenOrientation);
            writer.WriteBoolValue("kioskModeScreenSaverConfigurationEnabled", KioskModeScreenSaverConfigurationEnabled);
            writer.WriteBoolValue("kioskModeScreenSaverDetectMediaDisabled", KioskModeScreenSaverDetectMediaDisabled);
            writer.WriteIntValue("kioskModeScreenSaverDisplayTimeInSeconds", KioskModeScreenSaverDisplayTimeInSeconds);
            writer.WriteStringValue("kioskModeScreenSaverImageUrl", KioskModeScreenSaverImageUrl);
            writer.WriteIntValue("kioskModeScreenSaverStartDelayInSeconds", KioskModeScreenSaverStartDelayInSeconds);
            writer.WriteBoolValue("kioskModeShowAppNotificationBadge", KioskModeShowAppNotificationBadge);
            writer.WriteBoolValue("kioskModeShowDeviceInfo", KioskModeShowDeviceInfo);
            writer.WriteEnumValue<KioskModeType>("kioskModeUseManagedHomeScreenApp", KioskModeUseManagedHomeScreenApp);
            writer.WriteBoolValue("kioskModeVirtualHomeButtonEnabled", KioskModeVirtualHomeButtonEnabled);
            writer.WriteEnumValue<AndroidDeviceOwnerVirtualHomeButtonType>("kioskModeVirtualHomeButtonType", KioskModeVirtualHomeButtonType);
            writer.WriteStringValue("kioskModeWallpaperUrl", KioskModeWallpaperUrl);
            writer.WriteCollectionOfPrimitiveValues<string>("kioskModeWifiAllowedSsids", KioskModeWifiAllowedSsids);
            writer.WriteBoolValue("kioskModeWiFiConfigurationEnabled", KioskModeWiFiConfigurationEnabled);
            writer.WriteBoolValue("locateDeviceLostModeEnabled", LocateDeviceLostModeEnabled);
            writer.WriteBoolValue("locateDeviceUserlessDisabled", LocateDeviceUserlessDisabled);
            writer.WriteBoolValue("microphoneForceMute", MicrophoneForceMute);
            writer.WriteBoolValue("microsoftLauncherConfigurationEnabled", MicrosoftLauncherConfigurationEnabled);
            writer.WriteBoolValue("microsoftLauncherCustomWallpaperAllowUserModification", MicrosoftLauncherCustomWallpaperAllowUserModification);
            writer.WriteBoolValue("microsoftLauncherCustomWallpaperEnabled", MicrosoftLauncherCustomWallpaperEnabled);
            writer.WriteStringValue("microsoftLauncherCustomWallpaperImageUrl", MicrosoftLauncherCustomWallpaperImageUrl);
            writer.WriteBoolValue("microsoftLauncherDockPresenceAllowUserModification", MicrosoftLauncherDockPresenceAllowUserModification);
            writer.WriteEnumValue<MicrosoftLauncherDockPresence>("microsoftLauncherDockPresenceConfiguration", MicrosoftLauncherDockPresenceConfiguration);
            writer.WriteBoolValue("microsoftLauncherFeedAllowUserModification", MicrosoftLauncherFeedAllowUserModification);
            writer.WriteBoolValue("microsoftLauncherFeedEnabled", MicrosoftLauncherFeedEnabled);
            writer.WriteEnumValue<MicrosoftLauncherSearchBarPlacement>("microsoftLauncherSearchBarPlacementConfiguration", MicrosoftLauncherSearchBarPlacementConfiguration);
            writer.WriteBoolValue("networkEscapeHatchAllowed", NetworkEscapeHatchAllowed);
            writer.WriteBoolValue("nfcBlockOutgoingBeam", NfcBlockOutgoingBeam);
            writer.WriteBoolValue("passwordBlockKeyguard", PasswordBlockKeyguard);
            writer.WriteCollectionOfEnumValues<AndroidKeyguardFeature>("passwordBlockKeyguardFeatures", PasswordBlockKeyguardFeatures);
            writer.WriteIntValue("passwordExpirationDays", PasswordExpirationDays);
            writer.WriteIntValue("passwordMinimumLength", PasswordMinimumLength);
            writer.WriteIntValue("passwordMinimumLetterCharacters", PasswordMinimumLetterCharacters);
            writer.WriteIntValue("passwordMinimumLowerCaseCharacters", PasswordMinimumLowerCaseCharacters);
            writer.WriteIntValue("passwordMinimumNonLetterCharacters", PasswordMinimumNonLetterCharacters);
            writer.WriteIntValue("passwordMinimumNumericCharacters", PasswordMinimumNumericCharacters);
            writer.WriteIntValue("passwordMinimumSymbolCharacters", PasswordMinimumSymbolCharacters);
            writer.WriteIntValue("passwordMinimumUpperCaseCharacters", PasswordMinimumUpperCaseCharacters);
            writer.WriteIntValue("passwordMinutesOfInactivityBeforeScreenTimeout", PasswordMinutesOfInactivityBeforeScreenTimeout);
            writer.WriteIntValue("passwordPreviousPasswordCountToBlock", PasswordPreviousPasswordCountToBlock);
            writer.WriteEnumValue<AndroidDeviceOwnerRequiredPasswordType>("passwordRequiredType", PasswordRequiredType);
            writer.WriteEnumValue<AndroidDeviceOwnerRequiredPasswordUnlock>("passwordRequireUnlock", PasswordRequireUnlock);
            writer.WriteIntValue("passwordSignInFailureCountBeforeFactoryReset", PasswordSignInFailureCountBeforeFactoryReset);
            writer.WriteBoolValue("personalProfileAppsAllowInstallFromUnknownSources", PersonalProfileAppsAllowInstallFromUnknownSources);
            writer.WriteBoolValue("personalProfileCameraBlocked", PersonalProfileCameraBlocked);
            writer.WriteCollectionOfObjectValues<AppListItem>("personalProfilePersonalApplications", PersonalProfilePersonalApplications);
            writer.WriteEnumValue<PersonalProfilePersonalPlayStoreMode>("personalProfilePlayStoreMode", PersonalProfilePlayStoreMode);
            writer.WriteBoolValue("personalProfileScreenCaptureBlocked", PersonalProfileScreenCaptureBlocked);
            writer.WriteEnumValue<AndroidDeviceOwnerPlayStoreMode>("playStoreMode", PlayStoreMode);
            writer.WriteBoolValue("screenCaptureBlocked", ScreenCaptureBlocked);
            writer.WriteBoolValue("securityCommonCriteriaModeEnabled", SecurityCommonCriteriaModeEnabled);
            writer.WriteBoolValue("securityDeveloperSettingsEnabled", SecurityDeveloperSettingsEnabled);
            writer.WriteBoolValue("securityRequireVerifyApps", SecurityRequireVerifyApps);
            writer.WriteObjectValue<AndroidDeviceOwnerUserFacingMessage>("shortHelpText", ShortHelpText);
            writer.WriteBoolValue("statusBarBlocked", StatusBarBlocked);
            writer.WriteCollectionOfEnumValues<AndroidDeviceOwnerBatteryPluggedMode>("stayOnModes", StayOnModes);
            writer.WriteBoolValue("storageAllowUsb", StorageAllowUsb);
            writer.WriteBoolValue("storageBlockExternalMedia", StorageBlockExternalMedia);
            writer.WriteBoolValue("storageBlockUsbFileTransfer", StorageBlockUsbFileTransfer);
            writer.WriteCollectionOfObjectValues<AndroidDeviceOwnerSystemUpdateFreezePeriod>("systemUpdateFreezePeriods", SystemUpdateFreezePeriods);
            writer.WriteEnumValue<AndroidDeviceOwnerSystemUpdateInstallType>("systemUpdateInstallType", SystemUpdateInstallType);
            writer.WriteIntValue("systemUpdateWindowEndMinutesAfterMidnight", SystemUpdateWindowEndMinutesAfterMidnight);
            writer.WriteIntValue("systemUpdateWindowStartMinutesAfterMidnight", SystemUpdateWindowStartMinutesAfterMidnight);
            writer.WriteBoolValue("systemWindowsBlocked", SystemWindowsBlocked);
            writer.WriteBoolValue("usersBlockAdd", UsersBlockAdd);
            writer.WriteBoolValue("usersBlockRemove", UsersBlockRemove);
            writer.WriteBoolValue("volumeBlockAdjustment", VolumeBlockAdjustment);
            writer.WriteBoolValue("vpnAlwaysOnLockdownMode", VpnAlwaysOnLockdownMode);
            writer.WriteStringValue("vpnAlwaysOnPackageIdentifier", VpnAlwaysOnPackageIdentifier);
            writer.WriteBoolValue("wifiBlockEditConfigurations", WifiBlockEditConfigurations);
            writer.WriteBoolValue("wifiBlockEditPolicyDefinedConfigurations", WifiBlockEditPolicyDefinedConfigurations);
            writer.WriteIntValue("workProfilePasswordExpirationDays", WorkProfilePasswordExpirationDays);
            writer.WriteIntValue("workProfilePasswordMinimumLength", WorkProfilePasswordMinimumLength);
            writer.WriteIntValue("workProfilePasswordMinimumLetterCharacters", WorkProfilePasswordMinimumLetterCharacters);
            writer.WriteIntValue("workProfilePasswordMinimumLowerCaseCharacters", WorkProfilePasswordMinimumLowerCaseCharacters);
            writer.WriteIntValue("workProfilePasswordMinimumNonLetterCharacters", WorkProfilePasswordMinimumNonLetterCharacters);
            writer.WriteIntValue("workProfilePasswordMinimumNumericCharacters", WorkProfilePasswordMinimumNumericCharacters);
            writer.WriteIntValue("workProfilePasswordMinimumSymbolCharacters", WorkProfilePasswordMinimumSymbolCharacters);
            writer.WriteIntValue("workProfilePasswordMinimumUpperCaseCharacters", WorkProfilePasswordMinimumUpperCaseCharacters);
            writer.WriteIntValue("workProfilePasswordPreviousPasswordCountToBlock", WorkProfilePasswordPreviousPasswordCountToBlock);
            writer.WriteEnumValue<AndroidDeviceOwnerRequiredPasswordType>("workProfilePasswordRequiredType", WorkProfilePasswordRequiredType);
            writer.WriteEnumValue<AndroidDeviceOwnerRequiredPasswordUnlock>("workProfilePasswordRequireUnlock", WorkProfilePasswordRequireUnlock);
            writer.WriteIntValue("workProfilePasswordSignInFailureCountBeforeFactoryReset", WorkProfilePasswordSignInFailureCountBeforeFactoryReset);
        }
    }
}
