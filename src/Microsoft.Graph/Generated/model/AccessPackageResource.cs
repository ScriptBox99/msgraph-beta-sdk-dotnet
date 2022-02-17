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
    /// The type Access Package Resource.
    /// </summary>
    public partial class AccessPackageResource : Entity
    {
    
        /// <summary>
        /// Gets or sets added by.
        /// The name of the user or application that first added this resource. Read-only.
        /// </summary>
        [JsonPropertyName("addedBy")]
        public string AddedBy { get; set; }
    
        /// <summary>
        /// Gets or sets added on.
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [JsonPropertyName("addedOn")]
        public DateTimeOffset? AddedOn { get; set; }
    
        /// <summary>
        /// Gets or sets attributes.
        /// Contains information about the attributes to be collected from the requestor and sent to the resource application.
        /// </summary>
        [JsonPropertyName("attributes")]
        public IEnumerable<AccessPackageResourceAttribute> Attributes { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// A description for the resource.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name of the resource, such as the application name, group name or site name.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets is pending onboarding.
        /// True if the resource is not yet available for assignment.
        /// </summary>
        [JsonPropertyName("isPendingOnboarding")]
        public bool? IsPendingOnboarding { get; set; }
    
        /// <summary>
        /// Gets or sets origin id.
        /// The unique identifier of the resource in the origin system. In the case of an Azure AD group, this is the identifier of the group.
        /// </summary>
        [JsonPropertyName("originId")]
        public string OriginId { get; set; }
    
        /// <summary>
        /// Gets or sets origin system.
        /// The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup.
        /// </summary>
        [JsonPropertyName("originSystem")]
        public string OriginSystem { get; set; }
    
        /// <summary>
        /// Gets or sets resource type.
        /// The type of the resource, such as Application if it is an Azure AD connected application, or SharePoint Online Site for a SharePoint Online site.
        /// </summary>
        [JsonPropertyName("resourceType")]
        public string ResourceType { get; set; }
    
        /// <summary>
        /// Gets or sets url.
        /// A unique resource locator for the resource, such as the URL for signing a user into an application.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
        /// <summary>
        /// Gets or sets access package resource environment.
        /// Contains the environment information for the resource. This can be set using either the @odata.bind annotation or the environment's originId.
        /// </summary>
        [JsonPropertyName("accessPackageResourceEnvironment")]
        public AccessPackageResourceEnvironment AccessPackageResourceEnvironment { get; set; }
    
        /// <summary>
        /// Gets or sets access package resource roles.
        /// Read-only. Nullable. Supports $expand.
        /// </summary>
        [JsonPropertyName("accessPackageResourceRoles")]
        public IAccessPackageResourceAccessPackageResourceRolesCollectionPage AccessPackageResourceRoles { get; set; }

        /// <summary>
        /// Gets or sets accessPackageResourceRolesNextLink.
        /// </summary>
        [JsonPropertyName("accessPackageResourceRoles@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AccessPackageResourceRolesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets access package resource scopes.
        /// Read-only. Nullable. Supports $expand.
        /// </summary>
        [JsonPropertyName("accessPackageResourceScopes")]
        public IAccessPackageResourceAccessPackageResourceScopesCollectionPage AccessPackageResourceScopes { get; set; }

        /// <summary>
        /// Gets or sets accessPackageResourceScopesNextLink.
        /// </summary>
        [JsonPropertyName("accessPackageResourceScopes@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AccessPackageResourceScopesNextLink { get; set; }
    
    }
}

