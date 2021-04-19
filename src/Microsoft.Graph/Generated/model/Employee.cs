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
    /// The type Employee.
    /// </summary>
    public partial class Employee : Entity
    {
    
		///<summary>
		/// The Employee constructor
		///</summary>
        public Employee()
        {
            this.ODataType = "microsoft.graph.employee";
        }
	
        /// <summary>
        /// Gets or sets address.
        /// </summary>
        [JsonPropertyName("address")]
        public PostalAddressType Address { get; set; }
    
        /// <summary>
        /// Gets or sets birth date.
        /// </summary>
        [JsonPropertyName("birthDate")]
        public Date BirthDate { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets email.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }
    
        /// <summary>
        /// Gets or sets employment date.
        /// </summary>
        [JsonPropertyName("employmentDate")]
        public Date EmploymentDate { get; set; }
    
        /// <summary>
        /// Gets or sets given name.
        /// </summary>
        [JsonPropertyName("givenName")]
        public string GivenName { get; set; }
    
        /// <summary>
        /// Gets or sets job title.
        /// </summary>
        [JsonPropertyName("jobTitle")]
        public string JobTitle { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets middle name.
        /// </summary>
        [JsonPropertyName("middleName")]
        public string MiddleName { get; set; }
    
        /// <summary>
        /// Gets or sets mobile phone.
        /// </summary>
        [JsonPropertyName("mobilePhone")]
        public string MobilePhone { get; set; }
    
        /// <summary>
        /// Gets or sets number.
        /// </summary>
        [JsonPropertyName("number")]
        public string Number { get; set; }
    
        /// <summary>
        /// Gets or sets personal email.
        /// </summary>
        [JsonPropertyName("personalEmail")]
        public string PersonalEmail { get; set; }
    
        /// <summary>
        /// Gets or sets phone number.
        /// </summary>
        [JsonPropertyName("phoneNumber")]
        public string PhoneNumber { get; set; }
    
        /// <summary>
        /// Gets or sets statistics group code.
        /// </summary>
        [JsonPropertyName("statisticsGroupCode")]
        public string StatisticsGroupCode { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    
        /// <summary>
        /// Gets or sets surname.
        /// </summary>
        [JsonPropertyName("surname")]
        public string Surname { get; set; }
    
        /// <summary>
        /// Gets or sets termination date.
        /// </summary>
        [JsonPropertyName("terminationDate")]
        public Date TerminationDate { get; set; }
    
        /// <summary>
        /// Gets or sets picture.
        /// </summary>
        [JsonPropertyName("picture")]
        public IEmployeePictureCollectionPage Picture { get; set; }

        /// <summary>
        /// Gets or sets pictureNextLink.
        /// </summary>
        [JsonPropertyName("picture@odata.nextLink")]
        public string PictureNextLink { get; set; }
    
    }
}

