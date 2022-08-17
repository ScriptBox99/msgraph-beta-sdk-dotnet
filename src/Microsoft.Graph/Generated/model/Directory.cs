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
    /// The type Directory.
    /// </summary>
    public partial class Directory : Entity
    {
    
        /// <summary>
        /// Gets or sets impacted resources.
        /// </summary>
        [JsonPropertyName("impactedResources")]
        public IDirectoryImpactedResourcesCollectionPage ImpactedResources { get; set; }

        /// <summary>
        /// Gets or sets impactedResourcesNextLink.
        /// </summary>
        [JsonPropertyName("impactedResources@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ImpactedResourcesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets recommendations.
        /// </summary>
        [JsonPropertyName("recommendations")]
        public IDirectoryRecommendationsCollectionPage Recommendations { get; set; }

        /// <summary>
        /// Gets or sets recommendationsNextLink.
        /// </summary>
        [JsonPropertyName("recommendations@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string RecommendationsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets administrative units.
        /// Conceptual container for user and group directory objects.
        /// </summary>
        [JsonPropertyName("administrativeUnits")]
        public IDirectoryAdministrativeUnitsCollectionPage AdministrativeUnits { get; set; }

        /// <summary>
        /// Gets or sets administrativeUnitsNextLink.
        /// </summary>
        [JsonPropertyName("administrativeUnits@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AdministrativeUnitsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets attribute sets.
        /// Group of related custom security attribute definitions.
        /// </summary>
        [JsonPropertyName("attributeSets")]
        public IDirectoryAttributeSetsCollectionPage AttributeSets { get; set; }

        /// <summary>
        /// Gets or sets attributeSetsNextLink.
        /// </summary>
        [JsonPropertyName("attributeSets@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AttributeSetsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets custom security attribute definitions.
        /// Schema of a custom security attributes (key-value pairs).
        /// </summary>
        [JsonPropertyName("customSecurityAttributeDefinitions")]
        public IDirectoryCustomSecurityAttributeDefinitionsCollectionPage CustomSecurityAttributeDefinitions { get; set; }

        /// <summary>
        /// Gets or sets customSecurityAttributeDefinitionsNextLink.
        /// </summary>
        [JsonPropertyName("customSecurityAttributeDefinitions@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string CustomSecurityAttributeDefinitionsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets deleted items.
        /// </summary>
        [JsonPropertyName("deletedItems")]
        public IDirectoryDeletedItemsCollectionPage DeletedItems { get; set; }

        /// <summary>
        /// Gets or sets deletedItemsNextLink.
        /// </summary>
        [JsonPropertyName("deletedItems@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string DeletedItemsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets federation configurations.
        /// Configure domain federation with organizations whose identity provider (IdP) supports either the SAML or WS-Fed protocol.
        /// </summary>
        [JsonPropertyName("federationConfigurations")]
        public IDirectoryFederationConfigurationsCollectionPage FederationConfigurations { get; set; }

        /// <summary>
        /// Gets or sets federationConfigurationsNextLink.
        /// </summary>
        [JsonPropertyName("federationConfigurations@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string FederationConfigurationsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets inbound shared user profiles.
        /// </summary>
        [JsonPropertyName("inboundSharedUserProfiles")]
        public IDirectoryInboundSharedUserProfilesCollectionPage InboundSharedUserProfiles { get; set; }

        /// <summary>
        /// Gets or sets inboundSharedUserProfilesNextLink.
        /// </summary>
        [JsonPropertyName("inboundSharedUserProfiles@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string InboundSharedUserProfilesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets outbound shared user profiles.
        /// </summary>
        [JsonPropertyName("outboundSharedUserProfiles")]
        public IDirectoryOutboundSharedUserProfilesCollectionPage OutboundSharedUserProfiles { get; set; }

        /// <summary>
        /// Gets or sets outboundSharedUserProfilesNextLink.
        /// </summary>
        [JsonPropertyName("outboundSharedUserProfiles@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string OutboundSharedUserProfilesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets shared email domains.
        /// </summary>
        [JsonPropertyName("sharedEmailDomains")]
        public IDirectorySharedEmailDomainsCollectionPage SharedEmailDomains { get; set; }

        /// <summary>
        /// Gets or sets sharedEmailDomainsNextLink.
        /// </summary>
        [JsonPropertyName("sharedEmailDomains@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string SharedEmailDomainsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets feature rollout policies.
        /// </summary>
        [Obsolete("Feature Rollout Policies have been grouped with other policies under /policies. The existing /directory/featureRolloutPolicies is deprecated and will stop returning data on 06/30/2021. Please use /policies/featureRolloutPolicies.")]
        [JsonPropertyName("featureRolloutPolicies")]
        public IDirectoryFeatureRolloutPoliciesCollectionPage FeatureRolloutPolicies { get; set; }

        /// <summary>
        /// Gets or sets featureRolloutPoliciesNextLink.
        /// </summary>
        [JsonPropertyName("featureRolloutPolicies@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string FeatureRolloutPoliciesNextLink { get; set; }
    
    }
}

