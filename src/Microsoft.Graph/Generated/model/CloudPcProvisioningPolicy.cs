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
    /// The type Cloud Pc Provisioning Policy.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<CloudPcProvisioningPolicy>))]
    public partial class CloudPcProvisioningPolicy : Entity
    {
    
        /// <summary>
        /// Gets or sets description.
        /// The provisioning policy description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name for the provisioning policy.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets domain join configuration.
        /// </summary>
        [JsonPropertyName("domainJoinConfiguration")]
        public CloudPcDomainJoinConfiguration DomainJoinConfiguration { get; set; }
    
        /// <summary>
        /// Gets or sets image display name.
        /// The display name for the OS image you’re provisioning.
        /// </summary>
        [JsonPropertyName("imageDisplayName")]
        public string ImageDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets image id.
        /// The ID of the OS image you want to provision on Cloud PCs. The format for a gallery type image is: {publisher_offer_sku}. Supported values for each of the parameters are as follows:publisher: Microsoftwindowsdesktop. offer: windows-ent-cpc. sku: 21h1-ent-cpc-m365, 21h1-ent-cpc-os, 20h2-ent-cpc-m365, 20h2-ent-cpc-os, 20h1-ent-cpc-m365, 20h1-ent-cpc-os, 19h2-ent-cpc-m365 and 19h2-ent-cpc-os.
        /// </summary>
        [JsonPropertyName("imageId")]
        public string ImageId { get; set; }
    
        /// <summary>
        /// Gets or sets image type.
        /// The type of OS image (custom or gallery) you want to provision on Cloud PCs. Possible values are: gallery, custom.
        /// </summary>
        [JsonPropertyName("imageType")]
        public CloudPcProvisioningPolicyImageType? ImageType { get; set; }
    
        /// <summary>
        /// Gets or sets microsoft managed desktop.
        /// </summary>
        [JsonPropertyName("microsoftManagedDesktop")]
        public MicrosoftManagedDesktop MicrosoftManagedDesktop { get; set; }
    
        /// <summary>
        /// Gets or sets on premises connection id.
        /// The ID of the cloudPcOnPremisesConnection. To ensure that Cloud PCs have network connectivity and that they domain join, choose a connection with a virtual network that’s validated by the Cloud PC service.
        /// </summary>
        [JsonPropertyName("onPremisesConnectionId")]
        public string OnPremisesConnectionId { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// A defined collection of provisioning policy assignments. Represents the set of Microsoft 365 groups and security groups in Azure AD that have provisioning policy assigned. Returned only on $expand. See an example of getting the assignments relationship.
        /// </summary>
        [JsonPropertyName("assignments")]
        public ICloudPcProvisioningPolicyAssignmentsCollectionPage Assignments { get; set; }

        /// <summary>
        /// Gets or sets assignmentsNextLink.
        /// </summary>
        [JsonPropertyName("assignments@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AssignmentsNextLink { get; set; }
    
    }
}

