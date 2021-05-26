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
    /// The type Project Participation.
    /// </summary>
    public partial class ProjectParticipation : ItemFacet
    {
    
        ///<summary>
        /// The ProjectParticipation constructor
        ///</summary>
        public ProjectParticipation()
        {
            this.ODataType = "microsoft.graph.projectParticipation";
        }
    
        /// <summary>
        /// Gets or sets categories.
        /// Contains categories a user has associated with the project (for example, digital transformation, oil rig).
        /// </summary>
        [JsonPropertyName("categories")]
        public IEnumerable<string> Categories { get; set; }
    
        /// <summary>
        /// Gets or sets client.
        /// Contains detailed information about the client the project was for.
        /// </summary>
        [JsonPropertyName("client")]
        public CompanyDetail Client { get; set; }
    
        /// <summary>
        /// Gets or sets collaboration tags.
        /// Contains experience scenario tags a user has associated with the interest. Allowed values in the collection are: askMeAbout, ableToMentor, wantsToLearn, wantsToImprove.
        /// </summary>
        [JsonPropertyName("collaborationTags")]
        public IEnumerable<string> CollaborationTags { get; set; }
    
        /// <summary>
        /// Gets or sets colleagues.
        /// Lists people that also worked on the project.
        /// </summary>
        [JsonPropertyName("colleagues")]
        public IEnumerable<RelatedPerson> Colleagues { get; set; }
    
        /// <summary>
        /// Gets or sets detail.
        /// Contains detail about the user's role on the project.
        /// </summary>
        [JsonPropertyName("detail")]
        public PositionDetail Detail { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Contains a friendly name for the project.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets sponsors.
        /// The Person or people who sponsored the project.
        /// </summary>
        [JsonPropertyName("sponsors")]
        public IEnumerable<RelatedPerson> Sponsors { get; set; }
    
        /// <summary>
        /// Gets or sets thumbnail url.
        /// </summary>
        [JsonPropertyName("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }
    
    }
}

