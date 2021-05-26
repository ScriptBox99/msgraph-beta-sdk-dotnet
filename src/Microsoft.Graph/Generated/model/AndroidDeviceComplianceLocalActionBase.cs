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
    /// The type Android Device Compliance Local Action Base.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AndroidDeviceComplianceLocalActionBase>))]
    public partial class AndroidDeviceComplianceLocalActionBase : Entity
    {
    
        ///<summary>
        /// The internal AndroidDeviceComplianceLocalActionBase constructor
        ///</summary>
        protected internal AndroidDeviceComplianceLocalActionBase()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets grace period in minutes.
        /// Number of minutes to wait till a local action is enforced. Valid values 0 to 2147483647
        /// </summary>
        [JsonPropertyName("gracePeriodInMinutes")]
        public Int32? GracePeriodInMinutes { get; set; }
    
    }
}

