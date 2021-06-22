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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Subscription.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Subscription : Entity
    {
    
		///<summary>
		/// The Subscription constructor
		///</summary>
        public Subscription()
        {
            this.ODataType = "microsoft.graph.subscription";
        }
	
        /// <summary>
        /// Gets or sets application id.
        /// Identifier of the application used to create the subscription. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applicationId", Required = Newtonsoft.Json.Required.Default)]
        public string ApplicationId { get; set; }
    
        /// <summary>
        /// Gets or sets change type.
        /// Required. Indicates the type of change in the subscribed resource that will raise a change notification. The supported values are: created, updated, deleted. Multiple values can be combined using a comma-separated list.Note: Drive root item and list change notifications support only the updated changeType. User and group change notifications support updated and deleted changeType.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "changeType", Required = Newtonsoft.Json.Required.Default)]
        public string ChangeType { get; set; }
    
        /// <summary>
        /// Gets or sets client state.
        /// Optional. Specifies the value of the clientState property sent by the service in each change notification. The maximum length is 128 characters. The client can check that the change notification came from the service by comparing the value of the clientState property sent with the subscription with the value of the clientState property received with each change notification.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "clientState", Required = Newtonsoft.Json.Required.Default)]
        public string ClientState { get; set; }
    
        /// <summary>
        /// Gets or sets creator id.
        /// Identifier of the user or service principal that created the subscription. If the app used delegated permissions to create the subscription, this field contains the id of the signed-in user the app called on behalf of. If the app used application permissions, this field contains the id of the service principal corresponding to the app. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "creatorId", Required = Newtonsoft.Json.Required.Default)]
        public string CreatorId { get; set; }
    
        /// <summary>
        /// Gets or sets encryption certificate.
        /// A base64-encoded representation of a certificate with a public key used to encrypt resource data in change notifications. Optional. Required when includeResourceData is true.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "encryptionCertificate", Required = Newtonsoft.Json.Required.Default)]
        public string EncryptionCertificate { get; set; }
    
        /// <summary>
        /// Gets or sets encryption certificate id.
        /// A custom app-provided identifier to help identify the certificate needed to decrypt resource data. Optional.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "encryptionCertificateId", Required = Newtonsoft.Json.Required.Default)]
        public string EncryptionCertificateId { get; set; }
    
        /// <summary>
        /// Gets or sets expiration date time.
        /// Required. Specifies the date and time when the webhook subscription expires. The time is in UTC, and can be an amount of time from subscription creation that varies for the resource subscribed to.  See the table below for maximum supported subscription length of time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "expirationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets include resource data.
        /// When set to true, change notifications include resource data (such as content of a chat message). Optional.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "includeResourceData", Required = Newtonsoft.Json.Required.Default)]
        public bool? IncludeResourceData { get; set; }
    
        /// <summary>
        /// Gets or sets latest supported tls version.
        /// Specifies the latest version of Transport Layer Security (TLS) that the notification endpoint, specified by notificationUrl, supports. The possible values are: v1_0, v1_1, v1_2, v1_3. For subscribers whose notification endpoint supports a version lower than the currently recommended version (TLS 1.2), specifying this property by a set timeline allows them to temporarily use their deprecated version of TLS before completing their upgrade to TLS 1.2. For these subscribers, not setting this property per the timeline would result in subscription operations failing. For subscribers whose notification endpoint already supports TLS 1.2, setting this property is optional. In such cases, Microsoft Graph defaults the property to v1_2.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "latestSupportedTlsVersion", Required = Newtonsoft.Json.Required.Default)]
        public string LatestSupportedTlsVersion { get; set; }
    
        /// <summary>
        /// Gets or sets lifecycle notification url.
        /// The URL of the endpoint that receives lifecycle notifications, including subscriptionRemoved and missed notifications. This URL must make use of the HTTPS protocol. Optional. Read more about how Outlook resources use lifecycle notifications.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lifecycleNotificationUrl", Required = Newtonsoft.Json.Required.Default)]
        public string LifecycleNotificationUrl { get; set; }
    
        /// <summary>
        /// Gets or sets notification content type.
        /// Desired content-type for MS Graph change notifications for supported resource types. The default content-type is the 'application/json' content-type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notificationContentType", Required = Newtonsoft.Json.Required.Default)]
        public string NotificationContentType { get; set; }
    
        /// <summary>
        /// Gets or sets notification query options.
        /// OData Query Options for specifying value for the targeting resource. Clients receive notifications when resource reaches the state matching the query options provided here. With this new property in the subscription creation payload along with all existing properties, Webhooks will deliver notifications whenever a resource reaches the desired state mentioned in the notificationQueryOptions property eg  when the print job is completed, when a print job resource isFetchable property value becomes true etc.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notificationQueryOptions", Required = Newtonsoft.Json.Required.Default)]
        public string NotificationQueryOptions { get; set; }
    
        /// <summary>
        /// Gets or sets notification url.
        /// Required. The URL of the endpoint that will receive the change notifications. This URL must make use of the HTTPS protocol.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notificationUrl", Required = Newtonsoft.Json.Required.Default)]
        public string NotificationUrl { get; set; }
    
        /// <summary>
        /// Gets or sets resource.
        /// Required. Specifies the resource that will be monitored for changes. Do not include the base URL (https://graph.microsoft.com/v1.0/). See the possible resource path values for each supported resource.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resource", Required = Newtonsoft.Json.Required.Default)]
        public string Resource { get; set; }
    
    }
}

