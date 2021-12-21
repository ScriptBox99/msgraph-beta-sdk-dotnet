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
    /// The type Meeting Registration Base.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<MeetingRegistrationBase>))]
    public partial class MeetingRegistrationBase : Entity
    {
    
        ///<summary>
        /// The internal MeetingRegistrationBase constructor
        ///</summary>
        protected internal MeetingRegistrationBase()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets allowed registrant.
        /// Specifies who can register for the meeting.
        /// </summary>
        [JsonPropertyName("allowedRegistrant")]
        public MeetingAudience? AllowedRegistrant { get; set; }
    
        /// <summary>
        /// Gets or sets registrants.
        /// Registrants of the online meeting.
        /// </summary>
        [JsonPropertyName("registrants")]
        public IMeetingRegistrationBaseRegistrantsCollectionPage Registrants { get; set; }

        /// <summary>
        /// Gets or sets registrantsNextLink.
        /// </summary>
        [JsonPropertyName("registrants@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string RegistrantsNextLink { get; set; }
    
    }
}

