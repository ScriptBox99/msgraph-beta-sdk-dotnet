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
    /// The type Booking Customer.
    /// </summary>
    public partial class BookingCustomer : BookingPerson
    {
    
        /// <summary>
        /// Gets or sets addresses.
        /// </summary>
        [JsonPropertyName("addresses")]
        public IEnumerable<PhysicalAddress> Addresses { get; set; }
    
        /// <summary>
        /// Gets or sets phones.
        /// </summary>
        [JsonPropertyName("phones")]
        public IEnumerable<Phone> Phones { get; set; }
    
    }
}

