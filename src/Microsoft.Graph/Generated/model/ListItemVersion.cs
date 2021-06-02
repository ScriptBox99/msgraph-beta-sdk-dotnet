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
    /// The type List Item Version.
    /// </summary>
    public partial class ListItemVersion : BaseItemVersion
    {
    
        ///<summary>
        /// The ListItemVersion constructor
        ///</summary>
        public ListItemVersion()
        {
            this.ODataType = "microsoft.graph.listItemVersion";
        }

        /// <summary>
        /// Gets or sets fields.
        /// A collection of the fields and values for this version of the list item.
        /// </summary>
        [JsonPropertyName("fields")]
        public FieldValueSet Fields { get; set; }
    
    }
}

