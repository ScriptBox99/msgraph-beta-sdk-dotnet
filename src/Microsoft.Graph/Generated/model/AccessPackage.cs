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
    /// The type Access Package.
    /// </summary>
    public partial class AccessPackage : Entity
    {
    
        /// <summary>
        /// Gets or sets catalog id.
        /// ID of the access package catalog referencing this access package. Read-only.
        /// </summary>
        [JsonPropertyName("catalogId")]
        public string CatalogId { get; set; }
    
        /// <summary>
        /// Gets or sets created by.
        /// UPN of the user or identity of the subject who created this resource. Read-only.
        /// </summary>
        [JsonPropertyName("createdBy")]
        public string CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// The description of the access package.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name of the access package.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets is hidden.
        /// Whether the access package is hidden from the requestor.
        /// </summary>
        [JsonPropertyName("isHidden")]
        public bool? IsHidden { get; set; }
    
        /// <summary>
        /// Gets or sets is role scopes visible.
        /// Indicates whether role scopes are visible.
        /// </summary>
        [JsonPropertyName("isRoleScopesVisible")]
        public bool? IsRoleScopesVisible { get; set; }
    
        /// <summary>
        /// Gets or sets modified by.
        /// The UPN of the user who last modified this resource. Read-only.
        /// </summary>
        [JsonPropertyName("modifiedBy")]
        public string ModifiedBy { get; set; }
    
        /// <summary>
        /// Gets or sets modified date time.
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        /// </summary>
        [JsonPropertyName("modifiedDateTime")]
        public DateTimeOffset? ModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets access package assignment policies.
        /// Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("accessPackageAssignmentPolicies")]
        public IAccessPackageAccessPackageAssignmentPoliciesCollectionPage AccessPackageAssignmentPolicies { get; set; }

        /// <summary>
        /// Gets or sets accessPackageAssignmentPoliciesNextLink.
        /// </summary>
        [JsonPropertyName("accessPackageAssignmentPolicies@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AccessPackageAssignmentPoliciesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets access package catalog.
        /// Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("accessPackageCatalog")]
        public AccessPackageCatalog AccessPackageCatalog { get; set; }
    
        /// <summary>
        /// Gets or sets access package resource role scopes.
        /// Nullable.
        /// </summary>
        [JsonPropertyName("accessPackageResourceRoleScopes")]
        public IAccessPackageAccessPackageResourceRoleScopesCollectionPage AccessPackageResourceRoleScopes { get; set; }

        /// <summary>
        /// Gets or sets accessPackageResourceRoleScopesNextLink.
        /// </summary>
        [JsonPropertyName("accessPackageResourceRoleScopes@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AccessPackageResourceRoleScopesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets access packages incompatible with.
        /// The access packages that are incompatible with this package. Read-only.
        /// </summary>
        [JsonPropertyName("accessPackagesIncompatibleWith")]
        public IAccessPackageAccessPackagesIncompatibleWithCollectionWithReferencesPage AccessPackagesIncompatibleWith { get; set; }

        /// <summary>
        /// Gets or sets accessPackagesIncompatibleWithNextLink.
        /// </summary>
        [JsonPropertyName("accessPackagesIncompatibleWith@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AccessPackagesIncompatibleWithNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets incompatible access packages.
        /// The  access packages whose assigned users are ineligible to be assigned this access package.
        /// </summary>
        [JsonPropertyName("incompatibleAccessPackages")]
        public IAccessPackageIncompatibleAccessPackagesCollectionWithReferencesPage IncompatibleAccessPackages { get; set; }

        /// <summary>
        /// Gets or sets incompatibleAccessPackagesNextLink.
        /// </summary>
        [JsonPropertyName("incompatibleAccessPackages@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string IncompatibleAccessPackagesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets incompatible groups.
        /// The groups whose members are ineligible to be assigned this access package.
        /// </summary>
        [JsonPropertyName("incompatibleGroups")]
        public IAccessPackageIncompatibleGroupsCollectionPage IncompatibleGroups { get; set; }

        /// <summary>
        /// Gets or sets incompatibleGroupsNextLink.
        /// </summary>
        [JsonPropertyName("incompatibleGroups@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string IncompatibleGroupsNextLink { get; set; }
    
    }
}

