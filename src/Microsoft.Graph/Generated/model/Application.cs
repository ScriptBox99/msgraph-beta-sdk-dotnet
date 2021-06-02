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
    /// The type Application.
    /// </summary>
    public partial class Application : DirectoryObject
    {
    
        ///<summary>
        /// The Application constructor
        ///</summary>
        public Application()
        {
            this.ODataType = "microsoft.graph.application";
        }

        /// <summary>
        /// Gets or sets api.
        /// Specifies settings for an application that implements a web API.
        /// </summary>
        [JsonPropertyName("api")]
        public ApiApplication Api { get; set; }
    
        /// <summary>
        /// Gets or sets app id.
        /// The unique identifier for the application that is assigned by Azure AD. Not nullable. Read-only.
        /// </summary>
        [JsonPropertyName("appId")]
        public string AppId { get; set; }
    
        /// <summary>
        /// Gets or sets app roles.
        /// The collection of roles assigned to the application. With app role assignments, these roles can be assigned to users, groups, or service principals associated with other applications. Not nullable.
        /// </summary>
        [JsonPropertyName("appRoles")]
        public IEnumerable<AppRole> AppRoles { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// The date and time the application was registered. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets default redirect uri.
        /// </summary>
        [JsonPropertyName("defaultRedirectUri")]
        public string DefaultRedirectUri { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name for the application.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets group membership claims.
        /// Configures the groups claim issued in a user or OAuth 2.0 access token that the application expects. To set this attribute, use one of the following string values: None, SecurityGroup (for security groups and Azure AD roles), All (this gets all security groups, distribution groups, and Azure AD directory roles that the signed-in user is a member of).
        /// </summary>
        [JsonPropertyName("groupMembershipClaims")]
        public string GroupMembershipClaims { get; set; }
    
        /// <summary>
        /// Gets or sets identifier uris.
        /// The URIs that identify the application within its Azure AD tenant, or within a verified custom domain if the application is multi-tenant. For more information, see Application Objects and Service Principal Objects. The any operator is required for filter expressions on multi-valued properties. Not nullable.
        /// </summary>
        [JsonPropertyName("identifierUris")]
        public IEnumerable<string> IdentifierUris { get; set; }
    
        /// <summary>
        /// Gets or sets info.
        /// Basic profile information of the application, such as it's marketing, support, terms of service, and privacy statement URLs. The terms of service and privacy statement are surfaced to users through the user consent experience. For more information, see How to: Add Terms of service and privacy statement for registered Azure AD apps.
        /// </summary>
        [JsonPropertyName("info")]
        public InformationalUrl Info { get; set; }
    
        /// <summary>
        /// Gets or sets is device only auth supported.
        /// Specifies whether this application supports device authentication without a user. The default is false.
        /// </summary>
        [JsonPropertyName("isDeviceOnlyAuthSupported")]
        public bool? IsDeviceOnlyAuthSupported { get; set; }
    
        /// <summary>
        /// Gets or sets is fallback public client.
        /// Specifies the fallback application type as public client, such as an installed application running on a mobile device. The default value is false which means the fallback application type is confidential client such as a web app. There are certain scenarios where Azure AD cannot determine the client application type. For example, the ROPC flow where the application is configured without specifying a redirect URI. In those cases Azure AD interprets the application type based on the value of this property.
        /// </summary>
        [JsonPropertyName("isFallbackPublicClient")]
        public bool? IsFallbackPublicClient { get; set; }
    
        /// <summary>
        /// Gets or sets key credentials.
        /// The collection of key credentials associated with the application. Not nullable.
        /// </summary>
        [JsonPropertyName("keyCredentials")]
        public IEnumerable<KeyCredential> KeyCredentials { get; set; }
    
        /// <summary>
        /// Gets or sets logo.
        /// The main logo for the application. Not nullable.
        /// </summary>
        [JsonPropertyName("logo")]
        public Stream Logo { get; set; }
    
        /// <summary>
        /// Gets or sets notes.
        /// Notes relevant for the management of the application.
        /// </summary>
        [JsonPropertyName("notes")]
        public string Notes { get; set; }
    
        /// <summary>
        /// Gets or sets optional claims.
        /// Application developers can configure optional claims in their Azure AD applications to specify the claims that are sent to their application by the Microsoft security token service. For more information, see How to: Provide optional claims to your app.
        /// </summary>
        [JsonPropertyName("optionalClaims")]
        public OptionalClaims OptionalClaims { get; set; }
    
        /// <summary>
        /// Gets or sets parental control settings.
        /// Specifies parental control settings for an application.
        /// </summary>
        [JsonPropertyName("parentalControlSettings")]
        public ParentalControlSettings ParentalControlSettings { get; set; }
    
        /// <summary>
        /// Gets or sets password credentials.
        /// The collection of password credentials associated with the application. Not nullable.
        /// </summary>
        [JsonPropertyName("passwordCredentials")]
        public IEnumerable<PasswordCredential> PasswordCredentials { get; set; }
    
        /// <summary>
        /// Gets or sets public client.
        /// Specifies settings for installed clients such as desktop or mobile devices.
        /// </summary>
        [JsonPropertyName("publicClient")]
        public PublicClientApplication PublicClient { get; set; }
    
        /// <summary>
        /// Gets or sets publisher domain.
        /// The verified publisher domain for the application. Read-only.
        /// </summary>
        [JsonPropertyName("publisherDomain")]
        public string PublisherDomain { get; set; }
    
        /// <summary>
        /// Gets or sets required resource access.
        /// Specifies the resources that the application needs to access. This property also specifies the set of OAuth permission scopes and application roles that it needs for each of those resources. This configuration of access to the required resources drives the consent experience. Not nullable.
        /// </summary>
        [JsonPropertyName("requiredResourceAccess")]
        public IEnumerable<RequiredResourceAccess> RequiredResourceAccess { get; set; }
    
        /// <summary>
        /// Gets or sets sign in audience.
        /// Specifies the Microsoft accounts that are supported for the current application. Supported values are: AzureADMyOrg, AzureADMultipleOrgs, AzureADandPersonalMicrosoftAccount, PersonalMicrosoftAccount. See more in the table below.
        /// </summary>
        [JsonPropertyName("signInAudience")]
        public string SignInAudience { get; set; }
    
        /// <summary>
        /// Gets or sets spa.
        /// Specifies settings for a single-page application, including sign out URLs and redirect URIs for authorization codes and access tokens.
        /// </summary>
        [JsonPropertyName("spa")]
        public SpaApplication Spa { get; set; }
    
        /// <summary>
        /// Gets or sets tags.
        /// Custom strings that can be used to categorize and identify the application. Not nullable.
        /// </summary>
        [JsonPropertyName("tags")]
        public IEnumerable<string> Tags { get; set; }
    
        /// <summary>
        /// Gets or sets token encryption key id.
        /// Specifies the keyId of a public key from the keyCredentials collection. When configured, Azure AD encrypts all the tokens it emits by using the key this property points to. The application code that receives the encrypted token must use the matching private key to decrypt the token before it can be used for the signed-in user.
        /// </summary>
        [JsonPropertyName("tokenEncryptionKeyId")]
        public Guid? TokenEncryptionKeyId { get; set; }
    
        /// <summary>
        /// Gets or sets unique name.
        /// The unique identifier that can be assigned to an application as an alternative identifier. Immutable. Read-only.
        /// </summary>
        [JsonPropertyName("uniqueName")]
        public string UniqueName { get; set; }
    
        /// <summary>
        /// Gets or sets web.
        /// Specifies settings for a web application.
        /// </summary>
        [JsonPropertyName("web")]
        public WebApplication Web { get; set; }
    
        /// <summary>
        /// Gets or sets on premises publishing.
        /// Represents the set of properties required for configuring Application Proxy for this application. Configuring these properties allows you to publish your on-premises application for secure remote access.
        /// </summary>
        [JsonPropertyName("onPremisesPublishing")]
        public OnPremisesPublishing OnPremisesPublishing { get; set; }
    
        /// <summary>
        /// Gets or sets created on behalf of.
        /// Read-only.
        /// </summary>
        [JsonPropertyName("createdOnBehalfOf")]
        public DirectoryObject CreatedOnBehalfOf { get; set; }
    
        /// <summary>
        /// Gets or sets extension properties.
        /// Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("extensionProperties")]
        public IApplicationExtensionPropertiesCollectionPage ExtensionProperties { get; set; }

        /// <summary>
        /// Gets or sets extensionPropertiesNextLink.
        /// </summary>
        [JsonPropertyName("extensionProperties@odata.nextLink")]
        public string ExtensionPropertiesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets home realm discovery policies.
        /// </summary>
        [JsonPropertyName("homeRealmDiscoveryPolicies")]
        public IApplicationHomeRealmDiscoveryPoliciesCollectionWithReferencesPage HomeRealmDiscoveryPolicies { get; set; }

        /// <summary>
        /// Gets or sets homeRealmDiscoveryPoliciesNextLink.
        /// </summary>
        [JsonPropertyName("homeRealmDiscoveryPolicies@odata.nextLink")]
        public string HomeRealmDiscoveryPoliciesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets owners.
        /// Directory objects that are owners of the application. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("owners")]
        public IApplicationOwnersCollectionWithReferencesPage Owners { get; set; }

        /// <summary>
        /// Gets or sets ownersNextLink.
        /// </summary>
        [JsonPropertyName("owners@odata.nextLink")]
        public string OwnersNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets token issuance policies.
        /// </summary>
        [JsonPropertyName("tokenIssuancePolicies")]
        public IApplicationTokenIssuancePoliciesCollectionWithReferencesPage TokenIssuancePolicies { get; set; }

        /// <summary>
        /// Gets or sets tokenIssuancePoliciesNextLink.
        /// </summary>
        [JsonPropertyName("tokenIssuancePolicies@odata.nextLink")]
        public string TokenIssuancePoliciesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets token lifetime policies.
        /// The tokenLifetimePolicies assigned to this application.
        /// </summary>
        [JsonPropertyName("tokenLifetimePolicies")]
        public IApplicationTokenLifetimePoliciesCollectionWithReferencesPage TokenLifetimePolicies { get; set; }

        /// <summary>
        /// Gets or sets tokenLifetimePoliciesNextLink.
        /// </summary>
        [JsonPropertyName("tokenLifetimePolicies@odata.nextLink")]
        public string TokenLifetimePoliciesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets connector group.
        /// The connectorGroup the application is using with Azure AD Application Proxy. Nullable.
        /// </summary>
        [JsonPropertyName("connectorGroup")]
        public ConnectorGroup ConnectorGroup { get; set; }
    
        /// <summary>
        /// Gets or sets synchronization.
        /// </summary>
        [JsonPropertyName("synchronization")]
        public Synchronization Synchronization { get; set; }
    
    }
}

