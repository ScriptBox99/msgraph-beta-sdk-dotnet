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
    /// The type Group Policy Definition File.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<GroupPolicyDefinitionFile>))]
    public partial class GroupPolicyDefinitionFile : Entity
    {
    
        /// <summary>
        /// Gets or sets description.
        /// The localized description of the policy settings in the ADMX file. The default value is empty.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The localized friendly name of the ADMX file.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets file name.
        /// The file name of the ADMX file without the path. For example: edge.admx
        /// </summary>
        [JsonPropertyName("fileName")]
        public string FileName { get; set; }
    
        /// <summary>
        /// Gets or sets language codes.
        /// The supported language codes for the ADMX file.
        /// </summary>
        [JsonPropertyName("languageCodes")]
        public IEnumerable<string> LanguageCodes { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// The date and time the entity was last modified.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets policy type.
        /// Specifies the type of group policy. Possible values are: admxBacked, admxIngested.
        /// </summary>
        [JsonPropertyName("policyType")]
        public GroupPolicyType? PolicyType { get; set; }
    
        /// <summary>
        /// Gets or sets revision.
        /// The revision version associated with the file.
        /// </summary>
        [JsonPropertyName("revision")]
        public string Revision { get; set; }
    
        /// <summary>
        /// Gets or sets target namespace.
        /// Specifies the URI used to identify the namespace within the ADMX file.
        /// </summary>
        [JsonPropertyName("targetNamespace")]
        public string TargetNamespace { get; set; }
    
        /// <summary>
        /// Gets or sets target prefix.
        /// Specifies the logical name that refers to the namespace within the ADMX file.
        /// </summary>
        [JsonPropertyName("targetPrefix")]
        public string TargetPrefix { get; set; }
    
        /// <summary>
        /// Gets or sets definitions.
        /// The group policy definitions associated with the file.
        /// </summary>
        [JsonPropertyName("definitions")]
        public IGroupPolicyDefinitionFileDefinitionsCollectionWithReferencesPage Definitions { get; set; }

        /// <summary>
        /// Gets or sets definitionsNextLink.
        /// </summary>
        [JsonPropertyName("definitions@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string DefinitionsNextLink { get; set; }
    
    }
}

