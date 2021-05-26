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
    /// The type Currency.
    /// </summary>
    public partial class Currency : Entity
    {
    
        /// <summary>
        /// Gets or sets amount decimal places.
        /// </summary>
        [JsonPropertyName("amountDecimalPlaces")]
        public string AmountDecimalPlaces { get; set; }
    
        /// <summary>
        /// Gets or sets amount rounding precision.
        /// </summary>
        [JsonPropertyName("amountRoundingPrecision")]
        public Decimal? AmountRoundingPrecision { get; set; }
    
        /// <summary>
        /// Gets or sets code.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets symbol.
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }
    
    }
}

