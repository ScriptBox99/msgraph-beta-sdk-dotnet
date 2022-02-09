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
    /// The type Person.
    /// </summary>
    public partial class Person : Entity
    {
    
        /// <summary>
        /// Gets or sets birthday.
        /// The person's birthday.
        /// </summary>
        [JsonPropertyName("birthday")]
        public string Birthday { get; set; }
    
        /// <summary>
        /// Gets or sets company name.
        /// The name of the person's company.
        /// </summary>
        [JsonPropertyName("companyName")]
        public string CompanyName { get; set; }
    
        /// <summary>
        /// Gets or sets department.
        /// The person's department.
        /// </summary>
        [JsonPropertyName("department")]
        public string Department { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The person's display name.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets email addresses.
        /// The person's email addresses.
        /// </summary>
        [JsonPropertyName("emailAddresses")]
        public IEnumerable<RankedEmailAddress> EmailAddresses { get; set; }
    
        /// <summary>
        /// Gets or sets given name.
        /// The person's given name.
        /// </summary>
        [JsonPropertyName("givenName")]
        public string GivenName { get; set; }
    
        /// <summary>
        /// Gets or sets is favorite.
        /// true if the user has flagged this person as a favorite.
        /// </summary>
        [JsonPropertyName("isFavorite")]
        public bool? IsFavorite { get; set; }
    
        /// <summary>
        /// Gets or sets mailbox type.
        /// The type of mailbox that is represented by the person's email address.
        /// </summary>
        [JsonPropertyName("mailboxType")]
        public string MailboxType { get; set; }
    
        /// <summary>
        /// Gets or sets office location.
        /// The location of the person's office.
        /// </summary>
        [JsonPropertyName("officeLocation")]
        public string OfficeLocation { get; set; }
    
        /// <summary>
        /// Gets or sets person notes.
        /// Free-form notes that the user has taken about this person.
        /// </summary>
        [JsonPropertyName("personNotes")]
        public string PersonNotes { get; set; }
    
        /// <summary>
        /// Gets or sets person type.
        /// The type of person.
        /// </summary>
        [JsonPropertyName("personType")]
        public string PersonType { get; set; }
    
        /// <summary>
        /// Gets or sets phones.
        /// The person's phone numbers.
        /// </summary>
        [JsonPropertyName("phones")]
        public IEnumerable<Phone> Phones { get; set; }
    
        /// <summary>
        /// Gets or sets postal addresses.
        /// The person's addresses.
        /// </summary>
        [JsonPropertyName("postalAddresses")]
        public IEnumerable<Location> PostalAddresses { get; set; }
    
        /// <summary>
        /// Gets or sets profession.
        /// The person's profession.
        /// </summary>
        [JsonPropertyName("profession")]
        public string Profession { get; set; }
    
        /// <summary>
        /// Gets or sets sources.
        /// The sources the user data comes from, for example Directory or Outlook Contacts.
        /// </summary>
        [JsonPropertyName("sources")]
        public IEnumerable<PersonDataSource> Sources { get; set; }
    
        /// <summary>
        /// Gets or sets surname.
        /// The person's surname.
        /// </summary>
        [JsonPropertyName("surname")]
        public string Surname { get; set; }
    
        /// <summary>
        /// Gets or sets title.
        /// The person's title.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// The user principal name (UPN) of the person. The UPN is an Internet-style login name for the person based on the Internet standard RFC 822. By convention, this should map to the person's email name. The general format is alias@domain.
        /// </summary>
        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets websites.
        /// The person's websites.
        /// </summary>
        [JsonPropertyName("websites")]
        public IEnumerable<Website> Websites { get; set; }
    
        /// <summary>
        /// Gets or sets yomi company.
        /// The phonetic Japanese name of the person's company.
        /// </summary>
        [JsonPropertyName("yomiCompany")]
        public string YomiCompany { get; set; }
    
    }
}

