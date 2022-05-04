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
    /// The type Country Named Location.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<CountryNamedLocation>))]
    public partial class CountryNamedLocation : NamedLocation
    {
    
        ///<summary>
        /// The CountryNamedLocation constructor
        ///</summary>
        public CountryNamedLocation()
        {
            this.ODataType = "microsoft.graph.countryNamedLocation";
        }

        /// <summary>
        /// Gets or sets countries and regions.
        /// List of countries and/or regions in two-letter format specified by ISO 3166-2.
        /// </summary>
        [JsonPropertyName("countriesAndRegions")]
        public IEnumerable<string> CountriesAndRegions { get; set; }
    
        /// <summary>
        /// Gets or sets country lookup method.
        /// Determines what method is used to decide which country the user is located in. Possible values are clientIpAddress (default) and authenticatorAppGps.
        /// </summary>
        [JsonPropertyName("countryLookupMethod")]
        public CountryLookupMethodType? CountryLookupMethod { get; set; }
    
        /// <summary>
        /// Gets or sets include unknown countries and regions.
        /// true if IP addresses that don't map to a country or region should be included in the named location. Optional. Default value is false.
        /// </summary>
        [JsonPropertyName("includeUnknownCountriesAndRegions")]
        public bool? IncludeUnknownCountriesAndRegions { get; set; }
    
    }
}

