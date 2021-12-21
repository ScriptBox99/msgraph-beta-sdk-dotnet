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
    /// The type Meeting Registrant Base.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<MeetingRegistrantBase>))]
    public partial class MeetingRegistrantBase : Entity
    {
    
        ///<summary>
        /// The internal MeetingRegistrantBase constructor
        ///</summary>
        protected internal MeetingRegistrantBase()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets join web url.
        /// A unique web URL for the registrant to join the meeting. Read-only.
        /// </summary>
        [JsonPropertyName("joinWebUrl")]
        public string JoinWebUrl { get; set; }
    
    }
}

