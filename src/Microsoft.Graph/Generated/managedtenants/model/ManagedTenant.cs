// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Managed Tenant.
    /// </summary>
    public partial class ManagedTenant : Microsoft.Graph.Entity
    {
    
        /// <summary>
        /// Gets or sets aggregated policy compliances.
        /// </summary>
        [JsonPropertyName("aggregatedPolicyCompliances")]
        public IManagedTenantAggregatedPolicyCompliancesCollectionPage AggregatedPolicyCompliances { get; set; }

        /// <summary>
        /// Gets or sets aggregatedPolicyCompliancesNextLink.
        /// </summary>
        [JsonPropertyName("aggregatedPolicyCompliances@odata.nextLink")]
        public string AggregatedPolicyCompliancesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets cloud pc connections.
        /// </summary>
        [JsonPropertyName("cloudPcConnections")]
        public IManagedTenantCloudPcConnectionsCollectionPage CloudPcConnections { get; set; }

        /// <summary>
        /// Gets or sets cloudPcConnectionsNextLink.
        /// </summary>
        [JsonPropertyName("cloudPcConnections@odata.nextLink")]
        public string CloudPcConnectionsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets cloud pc devices.
        /// </summary>
        [JsonPropertyName("cloudPcDevices")]
        public IManagedTenantCloudPcDevicesCollectionPage CloudPcDevices { get; set; }

        /// <summary>
        /// Gets or sets cloudPcDevicesNextLink.
        /// </summary>
        [JsonPropertyName("cloudPcDevices@odata.nextLink")]
        public string CloudPcDevicesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets cloud pcs overview.
        /// </summary>
        [JsonPropertyName("cloudPcsOverview")]
        public IManagedTenantCloudPcsOverviewCollectionPage CloudPcsOverview { get; set; }

        /// <summary>
        /// Gets or sets cloudPcsOverviewNextLink.
        /// </summary>
        [JsonPropertyName("cloudPcsOverview@odata.nextLink")]
        public string CloudPcsOverviewNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets conditional access policy coverages.
        /// </summary>
        [JsonPropertyName("conditionalAccessPolicyCoverages")]
        public IManagedTenantConditionalAccessPolicyCoveragesCollectionPage ConditionalAccessPolicyCoverages { get; set; }

        /// <summary>
        /// Gets or sets conditionalAccessPolicyCoveragesNextLink.
        /// </summary>
        [JsonPropertyName("conditionalAccessPolicyCoverages@odata.nextLink")]
        public string ConditionalAccessPolicyCoveragesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets credential user registrations summaries.
        /// </summary>
        [JsonPropertyName("credentialUserRegistrationsSummaries")]
        public IManagedTenantCredentialUserRegistrationsSummariesCollectionPage CredentialUserRegistrationsSummaries { get; set; }

        /// <summary>
        /// Gets or sets credentialUserRegistrationsSummariesNextLink.
        /// </summary>
        [JsonPropertyName("credentialUserRegistrationsSummaries@odata.nextLink")]
        public string CredentialUserRegistrationsSummariesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets device compliance policy setting state summaries.
        /// </summary>
        [JsonPropertyName("deviceCompliancePolicySettingStateSummaries")]
        public IManagedTenantDeviceCompliancePolicySettingStateSummariesCollectionPage DeviceCompliancePolicySettingStateSummaries { get; set; }

        /// <summary>
        /// Gets or sets deviceCompliancePolicySettingStateSummariesNextLink.
        /// </summary>
        [JsonPropertyName("deviceCompliancePolicySettingStateSummaries@odata.nextLink")]
        public string DeviceCompliancePolicySettingStateSummariesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets managed device compliances.
        /// </summary>
        [JsonPropertyName("managedDeviceCompliances")]
        public IManagedTenantManagedDeviceCompliancesCollectionPage ManagedDeviceCompliances { get; set; }

        /// <summary>
        /// Gets or sets managedDeviceCompliancesNextLink.
        /// </summary>
        [JsonPropertyName("managedDeviceCompliances@odata.nextLink")]
        public string ManagedDeviceCompliancesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets managed device compliance trends.
        /// </summary>
        [JsonPropertyName("managedDeviceComplianceTrends")]
        public IManagedTenantManagedDeviceComplianceTrendsCollectionPage ManagedDeviceComplianceTrends { get; set; }

        /// <summary>
        /// Gets or sets managedDeviceComplianceTrendsNextLink.
        /// </summary>
        [JsonPropertyName("managedDeviceComplianceTrends@odata.nextLink")]
        public string ManagedDeviceComplianceTrendsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets management actions.
        /// </summary>
        [JsonPropertyName("managementActions")]
        public IManagedTenantManagementActionsCollectionPage ManagementActions { get; set; }

        /// <summary>
        /// Gets or sets managementActionsNextLink.
        /// </summary>
        [JsonPropertyName("managementActions@odata.nextLink")]
        public string ManagementActionsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets management action tenant deployment statuses.
        /// </summary>
        [JsonPropertyName("managementActionTenantDeploymentStatuses")]
        public IManagedTenantManagementActionTenantDeploymentStatusesCollectionPage ManagementActionTenantDeploymentStatuses { get; set; }

        /// <summary>
        /// Gets or sets managementActionTenantDeploymentStatusesNextLink.
        /// </summary>
        [JsonPropertyName("managementActionTenantDeploymentStatuses@odata.nextLink")]
        public string ManagementActionTenantDeploymentStatusesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets management intents.
        /// </summary>
        [JsonPropertyName("managementIntents")]
        public IManagedTenantManagementIntentsCollectionPage ManagementIntents { get; set; }

        /// <summary>
        /// Gets or sets managementIntentsNextLink.
        /// </summary>
        [JsonPropertyName("managementIntents@odata.nextLink")]
        public string ManagementIntentsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets management templates.
        /// </summary>
        [JsonPropertyName("managementTemplates")]
        public IManagedTenantManagementTemplatesCollectionPage ManagementTemplates { get; set; }

        /// <summary>
        /// Gets or sets managementTemplatesNextLink.
        /// </summary>
        [JsonPropertyName("managementTemplates@odata.nextLink")]
        public string ManagementTemplatesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets risky users.
        /// </summary>
        [JsonPropertyName("riskyUsers")]
        public IManagedTenantRiskyUsersCollectionPage RiskyUsers { get; set; }

        /// <summary>
        /// Gets or sets riskyUsersNextLink.
        /// </summary>
        [JsonPropertyName("riskyUsers@odata.nextLink")]
        public string RiskyUsersNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets tenant groups.
        /// </summary>
        [JsonPropertyName("tenantGroups")]
        public IManagedTenantTenantGroupsCollectionPage TenantGroups { get; set; }

        /// <summary>
        /// Gets or sets tenantGroupsNextLink.
        /// </summary>
        [JsonPropertyName("tenantGroups@odata.nextLink")]
        public string TenantGroupsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets tenants.
        /// </summary>
        [JsonPropertyName("tenants")]
        public IManagedTenantTenantsCollectionPage Tenants { get; set; }

        /// <summary>
        /// Gets or sets tenantsNextLink.
        /// </summary>
        [JsonPropertyName("tenants@odata.nextLink")]
        public string TenantsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets tenants customized information.
        /// </summary>
        [JsonPropertyName("tenantsCustomizedInformation")]
        public IManagedTenantTenantsCustomizedInformationCollectionPage TenantsCustomizedInformation { get; set; }

        /// <summary>
        /// Gets or sets tenantsCustomizedInformationNextLink.
        /// </summary>
        [JsonPropertyName("tenantsCustomizedInformation@odata.nextLink")]
        public string TenantsCustomizedInformationNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets tenants detailed information.
        /// </summary>
        [JsonPropertyName("tenantsDetailedInformation")]
        public IManagedTenantTenantsDetailedInformationCollectionPage TenantsDetailedInformation { get; set; }

        /// <summary>
        /// Gets or sets tenantsDetailedInformationNextLink.
        /// </summary>
        [JsonPropertyName("tenantsDetailedInformation@odata.nextLink")]
        public string TenantsDetailedInformationNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets tenant tags.
        /// </summary>
        [JsonPropertyName("tenantTags")]
        public IManagedTenantTenantTagsCollectionPage TenantTags { get; set; }

        /// <summary>
        /// Gets or sets tenantTagsNextLink.
        /// </summary>
        [JsonPropertyName("tenantTags@odata.nextLink")]
        public string TenantTagsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets windows device malware states.
        /// </summary>
        [JsonPropertyName("windowsDeviceMalwareStates")]
        public IManagedTenantWindowsDeviceMalwareStatesCollectionPage WindowsDeviceMalwareStates { get; set; }

        /// <summary>
        /// Gets or sets windowsDeviceMalwareStatesNextLink.
        /// </summary>
        [JsonPropertyName("windowsDeviceMalwareStates@odata.nextLink")]
        public string WindowsDeviceMalwareStatesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets windows protection states.
        /// </summary>
        [JsonPropertyName("windowsProtectionStates")]
        public IManagedTenantWindowsProtectionStatesCollectionPage WindowsProtectionStates { get; set; }

        /// <summary>
        /// Gets or sets windowsProtectionStatesNextLink.
        /// </summary>
        [JsonPropertyName("windowsProtectionStates@odata.nextLink")]
        public string WindowsProtectionStatesNextLink { get; set; }
    
    }
}

