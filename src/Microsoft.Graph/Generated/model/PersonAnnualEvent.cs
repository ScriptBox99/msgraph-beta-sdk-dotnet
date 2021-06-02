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
    /// The type Person Annual Event.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<PersonAnnualEvent>))]
    public partial class PersonAnnualEvent : ItemFacet
    {
    
        ///<summary>
        /// The PersonAnnualEvent constructor
        ///</summary>
        public PersonAnnualEvent()
        {
            this.ODataType = "microsoft.graph.personAnnualEvent";
        }

        /// <summary>
        /// Gets or sets date.
        /// </summary>
        [JsonPropertyName("date")]
        public Date Date { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// </summary>
        [JsonPropertyName("type")]
        public PersonAnnualEventType? Type { get; set; }
    
    }
}

