// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Device App Management.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DeviceAppManagement>))]
    public partial class DeviceAppManagement : Entity
    {
    
        /// <summary>
        /// Gets or sets is enabled for microsoft store for business.
        /// Whether the account is enabled for syncing applications from the Microsoft Store for Business.
        /// </summary>
        [JsonPropertyName("isEnabledForMicrosoftStoreForBusiness")]
        public bool? IsEnabledForMicrosoftStoreForBusiness { get; set; }
    
        /// <summary>
        /// Gets or sets microsoft store for business language.
        /// The locale information used to sync applications from the Microsoft Store for Business. Cultures that are specific to a country/region. The names of these cultures follow RFC 4646 (Windows Vista and later). The format is -&amp;lt;country/regioncode2&amp;gt;, where  is a lowercase two-letter code derived from ISO 639-1 and &amp;lt;country/regioncode2&amp;gt; is an uppercase two-letter code derived from ISO 3166. For example, en-US for English (United States) is a specific culture.
        /// </summary>
        [JsonPropertyName("microsoftStoreForBusinessLanguage")]
        public string MicrosoftStoreForBusinessLanguage { get; set; }
    
        /// <summary>
        /// Gets or sets microsoft store for business last completed application sync time.
        /// The last time an application sync from the Microsoft Store for Business was completed.
        /// </summary>
        [JsonPropertyName("microsoftStoreForBusinessLastCompletedApplicationSyncTime")]
        public DateTimeOffset? MicrosoftStoreForBusinessLastCompletedApplicationSyncTime { get; set; }
    
        /// <summary>
        /// Gets or sets microsoft store for business last successful sync date time.
        /// The last time the apps from the Microsoft Store for Business were synced successfully for the account.
        /// </summary>
        [JsonPropertyName("microsoftStoreForBusinessLastSuccessfulSyncDateTime")]
        public DateTimeOffset? MicrosoftStoreForBusinessLastSuccessfulSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets microsoft store for business portal selection.
        /// The end user portal information is used to sync applications from the Microsoft Store for Business to Intune Company Portal. There are three options to pick from ['Company portal only', 'Company portal and private store', 'Private store only']. Possible values are: none, companyPortal, privateStore.
        /// </summary>
        [JsonPropertyName("microsoftStoreForBusinessPortalSelection")]
        public MicrosoftStoreForBusinessPortalSelectionOptions? MicrosoftStoreForBusinessPortalSelection { get; set; }
    
        /// <summary>
        /// Gets or sets managed ebook categories.
        /// The mobile eBook categories.
        /// </summary>
        [JsonPropertyName("managedEBookCategories")]
        public IDeviceAppManagementManagedEBookCategoriesCollectionPage ManagedEBookCategories { get; set; }

        /// <summary>
        /// Gets or sets managedEBookCategoriesNextLink.
        /// </summary>
        [JsonPropertyName("managedEBookCategories@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ManagedEBookCategoriesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets enterprise code signing certificates.
        /// The Windows Enterprise Code Signing Certificate.
        /// </summary>
        [JsonPropertyName("enterpriseCodeSigningCertificates")]
        public IDeviceAppManagementEnterpriseCodeSigningCertificatesCollectionPage EnterpriseCodeSigningCertificates { get; set; }

        /// <summary>
        /// Gets or sets enterpriseCodeSigningCertificatesNextLink.
        /// </summary>
        [JsonPropertyName("enterpriseCodeSigningCertificates@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string EnterpriseCodeSigningCertificatesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets ios lob app provisioning configurations.
        /// The IOS Lob App Provisioning Configurations.
        /// </summary>
        [JsonPropertyName("iosLobAppProvisioningConfigurations")]
        public IDeviceAppManagementIosLobAppProvisioningConfigurationsCollectionPage IosLobAppProvisioningConfigurations { get; set; }

        /// <summary>
        /// Gets or sets iosLobAppProvisioningConfigurationsNextLink.
        /// </summary>
        [JsonPropertyName("iosLobAppProvisioningConfigurations@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string IosLobAppProvisioningConfigurationsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets mobile app categories.
        /// The mobile app categories.
        /// </summary>
        [JsonPropertyName("mobileAppCategories")]
        public IDeviceAppManagementMobileAppCategoriesCollectionPage MobileAppCategories { get; set; }

        /// <summary>
        /// Gets or sets mobileAppCategoriesNextLink.
        /// </summary>
        [JsonPropertyName("mobileAppCategories@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string MobileAppCategoriesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets mobile app configurations.
        /// The Managed Device Mobile Application Configurations.
        /// </summary>
        [JsonPropertyName("mobileAppConfigurations")]
        public IDeviceAppManagementMobileAppConfigurationsCollectionPage MobileAppConfigurations { get; set; }

        /// <summary>
        /// Gets or sets mobileAppConfigurationsNextLink.
        /// </summary>
        [JsonPropertyName("mobileAppConfigurations@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string MobileAppConfigurationsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets mobile apps.
        /// The mobile apps.
        /// </summary>
        [JsonPropertyName("mobileApps")]
        public IDeviceAppManagementMobileAppsCollectionPage MobileApps { get; set; }

        /// <summary>
        /// Gets or sets mobileAppsNextLink.
        /// </summary>
        [JsonPropertyName("mobileApps@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string MobileAppsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets symantec code signing certificate.
        /// The WinPhone Symantec Code Signing Certificate.
        /// </summary>
        [JsonPropertyName("symantecCodeSigningCertificate")]
        public SymantecCodeSigningCertificate SymantecCodeSigningCertificate { get; set; }
    
        /// <summary>
        /// Gets or sets managed ebooks.
        /// The Managed eBook.
        /// </summary>
        [JsonPropertyName("managedEBooks")]
        public IDeviceAppManagementManagedEBooksCollectionPage ManagedEBooks { get; set; }

        /// <summary>
        /// Gets or sets managedEBooksNextLink.
        /// </summary>
        [JsonPropertyName("managedEBooks@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ManagedEBooksNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets policy sets.
        /// The PolicySet of Policies and Applications
        /// </summary>
        [JsonPropertyName("policySets")]
        public IDeviceAppManagementPolicySetsCollectionPage PolicySets { get; set; }

        /// <summary>
        /// Gets or sets policySetsNextLink.
        /// </summary>
        [JsonPropertyName("policySets@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string PolicySetsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets side loading keys.
        /// Side Loading Keys that are required for the Windows 8 and 8.1 Apps installation.
        /// </summary>
        [JsonPropertyName("sideLoadingKeys")]
        public IDeviceAppManagementSideLoadingKeysCollectionPage SideLoadingKeys { get; set; }

        /// <summary>
        /// Gets or sets sideLoadingKeysNextLink.
        /// </summary>
        [JsonPropertyName("sideLoadingKeys@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string SideLoadingKeysNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets vpp tokens.
        /// List of Vpp tokens for this organization.
        /// </summary>
        [JsonPropertyName("vppTokens")]
        public IDeviceAppManagementVppTokensCollectionPage VppTokens { get; set; }

        /// <summary>
        /// Gets or sets vppTokensNextLink.
        /// </summary>
        [JsonPropertyName("vppTokens@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string VppTokensNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets windows management app.
        /// Windows management app.
        /// </summary>
        [JsonPropertyName("windowsManagementApp")]
        public WindowsManagementApp WindowsManagementApp { get; set; }
    
        /// <summary>
        /// Gets or sets android managed app protections.
        /// Android managed app policies.
        /// </summary>
        [JsonPropertyName("androidManagedAppProtections")]
        public IDeviceAppManagementAndroidManagedAppProtectionsCollectionPage AndroidManagedAppProtections { get; set; }

        /// <summary>
        /// Gets or sets androidManagedAppProtectionsNextLink.
        /// </summary>
        [JsonPropertyName("androidManagedAppProtections@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AndroidManagedAppProtectionsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets default managed app protections.
        /// Default managed app policies.
        /// </summary>
        [JsonPropertyName("defaultManagedAppProtections")]
        public IDeviceAppManagementDefaultManagedAppProtectionsCollectionPage DefaultManagedAppProtections { get; set; }

        /// <summary>
        /// Gets or sets defaultManagedAppProtectionsNextLink.
        /// </summary>
        [JsonPropertyName("defaultManagedAppProtections@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string DefaultManagedAppProtectionsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets ios managed app protections.
        /// iOS managed app policies.
        /// </summary>
        [JsonPropertyName("iosManagedAppProtections")]
        public IDeviceAppManagementIosManagedAppProtectionsCollectionPage IosManagedAppProtections { get; set; }

        /// <summary>
        /// Gets or sets iosManagedAppProtectionsNextLink.
        /// </summary>
        [JsonPropertyName("iosManagedAppProtections@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string IosManagedAppProtectionsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets managed app policies.
        /// Managed app policies.
        /// </summary>
        [JsonPropertyName("managedAppPolicies")]
        public IDeviceAppManagementManagedAppPoliciesCollectionPage ManagedAppPolicies { get; set; }

        /// <summary>
        /// Gets or sets managedAppPoliciesNextLink.
        /// </summary>
        [JsonPropertyName("managedAppPolicies@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ManagedAppPoliciesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets managed app registrations.
        /// The managed app registrations.
        /// </summary>
        [JsonPropertyName("managedAppRegistrations")]
        public IDeviceAppManagementManagedAppRegistrationsCollectionPage ManagedAppRegistrations { get; set; }

        /// <summary>
        /// Gets or sets managedAppRegistrationsNextLink.
        /// </summary>
        [JsonPropertyName("managedAppRegistrations@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ManagedAppRegistrationsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets managed app statuses.
        /// The managed app statuses.
        /// </summary>
        [JsonPropertyName("managedAppStatuses")]
        public IDeviceAppManagementManagedAppStatusesCollectionPage ManagedAppStatuses { get; set; }

        /// <summary>
        /// Gets or sets managedAppStatusesNextLink.
        /// </summary>
        [JsonPropertyName("managedAppStatuses@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ManagedAppStatusesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets mdm windows information protection policies.
        /// Windows information protection for apps running on devices which are MDM enrolled.
        /// </summary>
        [JsonPropertyName("mdmWindowsInformationProtectionPolicies")]
        public IDeviceAppManagementMdmWindowsInformationProtectionPoliciesCollectionPage MdmWindowsInformationProtectionPolicies { get; set; }

        /// <summary>
        /// Gets or sets mdmWindowsInformationProtectionPoliciesNextLink.
        /// </summary>
        [JsonPropertyName("mdmWindowsInformationProtectionPolicies@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string MdmWindowsInformationProtectionPoliciesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets targeted managed app configurations.
        /// Targeted managed app configurations.
        /// </summary>
        [JsonPropertyName("targetedManagedAppConfigurations")]
        public IDeviceAppManagementTargetedManagedAppConfigurationsCollectionPage TargetedManagedAppConfigurations { get; set; }

        /// <summary>
        /// Gets or sets targetedManagedAppConfigurationsNextLink.
        /// </summary>
        [JsonPropertyName("targetedManagedAppConfigurations@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string TargetedManagedAppConfigurationsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets windows information protection device registrations.
        /// Windows information protection device registrations that are not MDM enrolled.
        /// </summary>
        [JsonPropertyName("windowsInformationProtectionDeviceRegistrations")]
        public IDeviceAppManagementWindowsInformationProtectionDeviceRegistrationsCollectionPage WindowsInformationProtectionDeviceRegistrations { get; set; }

        /// <summary>
        /// Gets or sets windowsInformationProtectionDeviceRegistrationsNextLink.
        /// </summary>
        [JsonPropertyName("windowsInformationProtectionDeviceRegistrations@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string WindowsInformationProtectionDeviceRegistrationsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets windows information protection policies.
        /// Windows information protection for apps running on devices which are not MDM enrolled.
        /// </summary>
        [JsonPropertyName("windowsInformationProtectionPolicies")]
        public IDeviceAppManagementWindowsInformationProtectionPoliciesCollectionPage WindowsInformationProtectionPolicies { get; set; }

        /// <summary>
        /// Gets or sets windowsInformationProtectionPoliciesNextLink.
        /// </summary>
        [JsonPropertyName("windowsInformationProtectionPolicies@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string WindowsInformationProtectionPoliciesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets windows information protection wipe actions.
        /// Windows information protection wipe actions.
        /// </summary>
        [JsonPropertyName("windowsInformationProtectionWipeActions")]
        public IDeviceAppManagementWindowsInformationProtectionWipeActionsCollectionPage WindowsInformationProtectionWipeActions { get; set; }

        /// <summary>
        /// Gets or sets windowsInformationProtectionWipeActionsNextLink.
        /// </summary>
        [JsonPropertyName("windowsInformationProtectionWipeActions@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string WindowsInformationProtectionWipeActionsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets device app management tasks.
        /// Device app management tasks.
        /// </summary>
        [JsonPropertyName("deviceAppManagementTasks")]
        public IDeviceAppManagementDeviceAppManagementTasksCollectionPage DeviceAppManagementTasks { get; set; }

        /// <summary>
        /// Gets or sets deviceAppManagementTasksNextLink.
        /// </summary>
        [JsonPropertyName("deviceAppManagementTasks@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string DeviceAppManagementTasksNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets wdac supplemental policies.
        /// The collection of Windows Defender Application Control Supplemental Policies.
        /// </summary>
        [JsonPropertyName("wdacSupplementalPolicies")]
        public IDeviceAppManagementWdacSupplementalPoliciesCollectionPage WdacSupplementalPolicies { get; set; }

        /// <summary>
        /// Gets or sets wdacSupplementalPoliciesNextLink.
        /// </summary>
        [JsonPropertyName("wdacSupplementalPolicies@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string WdacSupplementalPoliciesNextLink { get; set; }
    
    }
}

