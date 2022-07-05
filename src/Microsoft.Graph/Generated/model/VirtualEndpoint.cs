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
    /// The type Virtual Endpoint.
    /// </summary>
    public partial class VirtualEndpoint : Entity
    {
    
        /// <summary>
        /// Gets or sets audit events.
        /// Cloud PC audit event.
        /// </summary>
        [JsonPropertyName("auditEvents")]
        public IVirtualEndpointAuditEventsCollectionPage AuditEvents { get; set; }

        /// <summary>
        /// Gets or sets auditEventsNextLink.
        /// </summary>
        [JsonPropertyName("auditEvents@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AuditEventsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets cloud pcs.
        /// Cloud managed virtual desktops.
        /// </summary>
        [JsonPropertyName("cloudPCs")]
        public IVirtualEndpointCloudPCsCollectionPage CloudPCs { get; set; }

        /// <summary>
        /// Gets or sets cloudPCsNextLink.
        /// </summary>
        [JsonPropertyName("cloudPCs@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string CloudPCsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets device images.
        /// The image resource on Cloud PC.
        /// </summary>
        [JsonPropertyName("deviceImages")]
        public IVirtualEndpointDeviceImagesCollectionPage DeviceImages { get; set; }

        /// <summary>
        /// Gets or sets deviceImagesNextLink.
        /// </summary>
        [JsonPropertyName("deviceImages@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string DeviceImagesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets external partner settings.
        /// </summary>
        [JsonPropertyName("externalPartnerSettings")]
        public IVirtualEndpointExternalPartnerSettingsCollectionPage ExternalPartnerSettings { get; set; }

        /// <summary>
        /// Gets or sets externalPartnerSettingsNextLink.
        /// </summary>
        [JsonPropertyName("externalPartnerSettings@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ExternalPartnerSettingsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets gallery images.
        /// The gallery image resource on Cloud PC.
        /// </summary>
        [JsonPropertyName("galleryImages")]
        public IVirtualEndpointGalleryImagesCollectionPage GalleryImages { get; set; }

        /// <summary>
        /// Gets or sets galleryImagesNextLink.
        /// </summary>
        [JsonPropertyName("galleryImages@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string GalleryImagesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets on premises connections.
        /// A defined collection of Azure resource information that can be used to establish on-premises network connectivity for Cloud PCs.
        /// </summary>
        [JsonPropertyName("onPremisesConnections")]
        public IVirtualEndpointOnPremisesConnectionsCollectionPage OnPremisesConnections { get; set; }

        /// <summary>
        /// Gets or sets onPremisesConnectionsNextLink.
        /// </summary>
        [JsonPropertyName("onPremisesConnections@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string OnPremisesConnectionsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets organization settings.
        /// The Cloud PC organization settings for a tenant.
        /// </summary>
        [JsonPropertyName("organizationSettings")]
        public CloudPcOrganizationSettings OrganizationSettings { get; set; }
    
        /// <summary>
        /// Gets or sets provisioning policies.
        /// Cloud PC provisioning policy.
        /// </summary>
        [JsonPropertyName("provisioningPolicies")]
        public IVirtualEndpointProvisioningPoliciesCollectionPage ProvisioningPolicies { get; set; }

        /// <summary>
        /// Gets or sets provisioningPoliciesNextLink.
        /// </summary>
        [JsonPropertyName("provisioningPolicies@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ProvisioningPoliciesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets service plans.
        /// Cloud PC service plans.
        /// </summary>
        [JsonPropertyName("servicePlans")]
        public IVirtualEndpointServicePlansCollectionPage ServicePlans { get; set; }

        /// <summary>
        /// Gets or sets servicePlansNextLink.
        /// </summary>
        [JsonPropertyName("servicePlans@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ServicePlansNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets snapshots.
        /// Cloud PC snapshots.
        /// </summary>
        [JsonPropertyName("snapshots")]
        public IVirtualEndpointSnapshotsCollectionPage Snapshots { get; set; }

        /// <summary>
        /// Gets or sets snapshotsNextLink.
        /// </summary>
        [JsonPropertyName("snapshots@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string SnapshotsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets supported regions.
        /// Cloud PC supported regions.
        /// </summary>
        [JsonPropertyName("supportedRegions")]
        public IVirtualEndpointSupportedRegionsCollectionPage SupportedRegions { get; set; }

        /// <summary>
        /// Gets or sets supportedRegionsNextLink.
        /// </summary>
        [JsonPropertyName("supportedRegions@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string SupportedRegionsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets user settings.
        /// Cloud PC user settings.
        /// </summary>
        [JsonPropertyName("userSettings")]
        public IVirtualEndpointUserSettingsCollectionPage UserSettings { get; set; }

        /// <summary>
        /// Gets or sets userSettingsNextLink.
        /// </summary>
        [JsonPropertyName("userSettings@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string UserSettingsNextLink { get; set; }
    
    }
}

