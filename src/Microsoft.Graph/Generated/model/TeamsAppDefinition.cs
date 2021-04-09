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
    /// The type Teams App Definition.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class TeamsAppDefinition : Entity
    {
    
		///<summary>
		/// The TeamsAppDefinition constructor
		///</summary>
        public TeamsAppDefinition()
        {
            this.ODataType = "microsoft.graph.teamsAppDefinition";
        }
	
        /// <summary>
        /// Gets or sets allowed installation scopes.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowedInstallationScopes", Required = Newtonsoft.Json.Required.Default)]
        public TeamsAppInstallationScopes? AllowedInstallationScopes { get; set; }
    
        /// <summary>
        /// Gets or sets azure adapp id.
        /// The WebApplicationInfo.id from the Teams App manifest.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "azureADAppId", Required = Newtonsoft.Json.Required.Default)]
        public string AzureADAppId { get; set; }
    
        /// <summary>
        /// Gets or sets created by.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdBy", Required = Newtonsoft.Json.Required.Default)]
        public IdentitySet CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Verbose description of the application.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The name of the app provided by the app developer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets publishing state.
        /// The published status of a specific version of a Teams app. Possible values are:submitted — The specific version of the Teams app has been submitted and is under review. published  — The request to publish the specific version of the Teams app has been approved by the admin and the app is published.  rejected — The request to publish the specific version of the Teams app was rejected by the admin.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "publishingState", Required = Newtonsoft.Json.Required.Default)]
        public TeamsAppPublishingState? PublishingState { get; set; }
    
        /// <summary>
        /// Gets or sets shortdescription.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "shortdescription", Required = Newtonsoft.Json.Required.Default)]
        public string Shortdescription { get; set; }
    
        /// <summary>
        /// Gets or sets teams app id.
        /// The id from the Teams App manifest.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "teamsAppId", Required = Newtonsoft.Json.Required.Default)]
        public string TeamsAppId { get; set; }
    
        /// <summary>
        /// Gets or sets version.
        /// The version number of the application.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "version", Required = Newtonsoft.Json.Required.Default)]
        public string Version { get; set; }
    
        /// <summary>
        /// Gets or sets bot.
        /// The details of the bot specified in the Teams App manifest.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bot", Required = Newtonsoft.Json.Required.Default)]
        public TeamworkBot Bot { get; set; }
    
    }
}

