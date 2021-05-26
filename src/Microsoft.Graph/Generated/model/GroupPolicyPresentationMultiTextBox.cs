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
    /// The type Group Policy Presentation Multi Text Box.
    /// </summary>
    public partial class GroupPolicyPresentationMultiTextBox : GroupPolicyPresentation
    {
    
        ///<summary>
        /// The GroupPolicyPresentationMultiTextBox constructor
        ///</summary>
        public GroupPolicyPresentationMultiTextBox()
        {
            this.ODataType = "microsoft.graph.groupPolicyPresentationMultiTextBox";
        }
    
        /// <summary>
        /// Gets or sets max length.
        /// An unsigned integer that specifies the maximum number of text characters. Default value is 1023.
        /// </summary>
        [JsonPropertyName("maxLength")]
        public Int64? MaxLength { get; set; }
    
        /// <summary>
        /// Gets or sets max strings.
        /// An unsigned integer that specifies the maximum number of strings. Default value is 0.
        /// </summary>
        [JsonPropertyName("maxStrings")]
        public Int64? MaxStrings { get; set; }
    
        /// <summary>
        /// Gets or sets required.
        /// Requirement to enter a value in the text box. Default value is false.
        /// </summary>
        [JsonPropertyName("required")]
        public bool? Required { get; set; }
    
    }
}

