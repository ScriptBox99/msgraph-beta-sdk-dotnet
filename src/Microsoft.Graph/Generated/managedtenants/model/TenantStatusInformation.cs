// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type TenantStatusInformation.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<TenantStatusInformation>))]
    public partial class TenantStatusInformation
    {

        /// <summary>
        /// Gets or sets delegatedPrivilegeStatus.
        /// The status of the delegated admin privilege relationship between the managing entity and the managed tenant. Possible values are: none, delegatedAdminPrivileges, unknownFutureValue. Optional. Read-only.
        /// </summary>
        [JsonPropertyName("delegatedPrivilegeStatus")]
        public DelegatedPrivilegeStatus? DelegatedPrivilegeStatus { get; set; }
    
        /// <summary>
        /// Gets or sets lastDelegatedPrivilegeRefreshDateTime.
        /// The date and time the delegated admin privileges status was updated. Optional. Read-only.
        /// </summary>
        [JsonPropertyName("lastDelegatedPrivilegeRefreshDateTime")]
        public DateTimeOffset? LastDelegatedPrivilegeRefreshDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets offboardedByUserId.
        /// The identifier for the account that offboarded the managed tenant. Optional. Read-only.
        /// </summary>
        [JsonPropertyName("offboardedByUserId")]
        public string OffboardedByUserId { get; set; }
    
        /// <summary>
        /// Gets or sets offboardedDateTime.
        /// The date and time when the managed tenant was offboarded. Optional. Read-only.
        /// </summary>
        [JsonPropertyName("offboardedDateTime")]
        public DateTimeOffset? OffboardedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets onboardedByUserId.
        /// The identifier for the account that onboarded the managed tenant. Optional. Read-only.
        /// </summary>
        [JsonPropertyName("onboardedByUserId")]
        public string OnboardedByUserId { get; set; }
    
        /// <summary>
        /// Gets or sets onboardedDateTime.
        /// The date and time when the managed tenant was onboarded. Optional. Read-only.
        /// </summary>
        [JsonPropertyName("onboardedDateTime")]
        public DateTimeOffset? OnboardedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets onboardingStatus.
        /// The onboarding status for the managed tenant.. Possible values are: ineligible, inProcess, active, inactive, unknownFutureValue. Optional. Read-only.
        /// </summary>
        [JsonPropertyName("onboardingStatus")]
        public TenantOnboardingStatus? OnboardingStatus { get; set; }
    
        /// <summary>
        /// Gets or sets workloadStatuses.
        /// The collection of workload statues for the managed tenant. Optional. Read-only.
        /// </summary>
        [JsonPropertyName("workloadStatuses")]
        public IEnumerable<WorkloadStatus> WorkloadStatuses { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
