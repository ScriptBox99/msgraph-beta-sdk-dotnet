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
    /// The type Learning Content.
    /// </summary>
    public partial class LearningContent : Entity
    {
    
        /// <summary>
        /// Gets or sets additional tags.
        /// Keywords, topics, and other tags associated with the learning content. Optional.
        /// </summary>
        [JsonPropertyName("additionalTags")]
        public IEnumerable<string> AdditionalTags { get; set; }
    
        /// <summary>
        /// Gets or sets content web url.
        /// The content web URL for the learning content. Required.
        /// </summary>
        [JsonPropertyName("contentWebUrl")]
        public string ContentWebUrl { get; set; }
    
        /// <summary>
        /// Gets or sets contributor.
        /// The author, creator, or contributor of the learning content. Optional.
        /// </summary>
        [JsonPropertyName("contributor")]
        public string Contributor { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// The date when the learning content was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// The description or summary for the learning content. Optional.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets duration.
        /// The duration of the learning content in seconds. Optional.
        /// </summary>
        [JsonPropertyName("duration")]
        public Duration Duration { get; set; }
    
        /// <summary>
        /// Gets or sets external id.
        /// Unique external content ID for the learning content. Required.
        /// </summary>
        [JsonPropertyName("externalId")]
        public string ExternalId { get; set; }
    
        /// <summary>
        /// Gets or sets format.
        /// The format of the learning content. For example, Course, Video, Book, Book Summary, Audiobook Summary. Optional.
        /// </summary>
        [JsonPropertyName("format")]
        public string Format { get; set; }
    
        /// <summary>
        /// Gets or sets is active.
        /// Indicates whether the content is active or not. Inactive content will not show up in the UI. The default value is true. Optional.
        /// </summary>
        [JsonPropertyName("isActive")]
        public bool? IsActive { get; set; }
    
        /// <summary>
        /// Gets or sets is premium.
        /// Indicates whether the learning content requires the user to sign-in on the learning provider platform or not. The default value is false. Optional.
        /// </summary>
        [JsonPropertyName("isPremium")]
        public bool? IsPremium { get; set; }
    
        /// <summary>
        /// Gets or sets is searchable.
        /// Indicates whether the learning content is searchable or not. The default value is true. Optional.
        /// </summary>
        [JsonPropertyName("isSearchable")]
        public bool? IsSearchable { get; set; }
    
        /// <summary>
        /// Gets or sets language tag.
        /// The language of the learning content, for example, en-us or fr-fr. Required.
        /// </summary>
        [JsonPropertyName("languageTag")]
        public string LanguageTag { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// The date when the learning content was last modified. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets number of pages.
        /// The number of pages of the learning content, for example, 9. Optional.
        /// </summary>
        [JsonPropertyName("numberOfPages")]
        public Int32? NumberOfPages { get; set; }
    
        /// <summary>
        /// Gets or sets skill tags.
        /// The skills tags associated with the learning content. Optional.
        /// </summary>
        [JsonPropertyName("skillTags")]
        public IEnumerable<string> SkillTags { get; set; }
    
        /// <summary>
        /// Gets or sets source name.
        /// The source name of the learning content, such as LinkedIn Learning or Coursera. Optional.
        /// </summary>
        [JsonPropertyName("sourceName")]
        public string SourceName { get; set; }
    
        /// <summary>
        /// Gets or sets thumbnail web url.
        /// The URL of learning content thumbnail image. Optional.
        /// </summary>
        [JsonPropertyName("thumbnailWebUrl")]
        public string ThumbnailWebUrl { get; set; }
    
        /// <summary>
        /// Gets or sets title.
        /// The title of the learning content. Required.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    
    }
}

