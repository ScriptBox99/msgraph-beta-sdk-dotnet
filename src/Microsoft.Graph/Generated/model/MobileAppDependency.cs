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
    /// The type Mobile App Dependency.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<MobileAppDependency>))]
    public partial class MobileAppDependency : MobileAppRelationship
    {
    
        ///<summary>
        /// The MobileAppDependency constructor
        ///</summary>
        public MobileAppDependency()
        {
            this.ODataType = "microsoft.graph.mobileAppDependency";
        }

        /// <summary>
        /// Gets or sets dependency type.
        /// The type of dependency relationship between the parent and child apps. Possible values are: detect, autoInstall.
        /// </summary>
        [JsonPropertyName("dependencyType")]
        public MobileAppDependencyType? DependencyType { get; set; }
    
        /// <summary>
        /// Gets or sets dependent app count.
        /// The total number of apps that directly or indirectly depend on the parent app.
        /// </summary>
        [JsonPropertyName("dependentAppCount")]
        public Int32? DependentAppCount { get; set; }
    
        /// <summary>
        /// Gets or sets depends on app count.
        /// The total number of apps the child app directly or indirectly depends on.
        /// </summary>
        [JsonPropertyName("dependsOnAppCount")]
        public Int32? DependsOnAppCount { get; set; }
    
    }
}

