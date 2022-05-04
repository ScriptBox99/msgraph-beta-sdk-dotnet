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
    /// The type Booking Business.
    /// </summary>
    public partial class BookingBusiness : BookingNamedEntity
    {
    
        ///<summary>
        /// The BookingBusiness constructor
        ///</summary>
        public BookingBusiness()
        {
            this.ODataType = "microsoft.graph.bookingBusiness";
        }

        /// <summary>
        /// Gets or sets address.
        /// The street address of the business. The address property, together with phone and webSiteUrl, appear in the footer of a business scheduling page.
        /// </summary>
        [JsonPropertyName("address")]
        public PhysicalAddress Address { get; set; }
    
        /// <summary>
        /// Gets or sets business hours.
        /// The hours of operation for the business.
        /// </summary>
        [JsonPropertyName("businessHours")]
        public IEnumerable<BookingWorkHours> BusinessHours { get; set; }
    
        /// <summary>
        /// Gets or sets business type.
        /// The type of business.
        /// </summary>
        [JsonPropertyName("businessType")]
        public string BusinessType { get; set; }
    
        /// <summary>
        /// Gets or sets default currency iso.
        /// The code for the currency that the business operates in on Microsoft Bookings.
        /// </summary>
        [JsonPropertyName("defaultCurrencyIso")]
        public string DefaultCurrencyIso { get; set; }
    
        /// <summary>
        /// Gets or sets email.
        /// The email address for the business.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }
    
        /// <summary>
        /// Gets or sets is published.
        /// The scheduling page has been made available to external customers. Use the publish and unpublish actions to set this property. Read-only.
        /// </summary>
        [JsonPropertyName("isPublished")]
        public bool? IsPublished { get; set; }
    
        /// <summary>
        /// Gets or sets phone.
        /// The telephone number for the business. The phone property, together with address and webSiteUrl, appear in the footer of a business scheduling page.
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }
    
        /// <summary>
        /// Gets or sets public url.
        /// The URL for the scheduling page, which is set after you publish or unpublish the page. Read-only.
        /// </summary>
        [JsonPropertyName("publicUrl")]
        public string PublicUrl { get; set; }
    
        /// <summary>
        /// Gets or sets scheduling policy.
        /// Specifies how bookings can be created for this business.
        /// </summary>
        [JsonPropertyName("schedulingPolicy")]
        public BookingSchedulingPolicy SchedulingPolicy { get; set; }
    
        /// <summary>
        /// Gets or sets web site url.
        /// Example: https://www.contoso.com
        /// </summary>
        [JsonPropertyName("webSiteUrl")]
        public string WebSiteUrl { get; set; }
    
        /// <summary>
        /// Gets or sets appointments.
        /// All the appointments of this business. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("appointments")]
        public IBookingBusinessAppointmentsCollectionPage Appointments { get; set; }

        /// <summary>
        /// Gets or sets appointmentsNextLink.
        /// </summary>
        [JsonPropertyName("appointments@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AppointmentsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets calendar view.
        /// The set of appointments of this business in a specified date range. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("calendarView")]
        public IBookingBusinessCalendarViewCollectionPage CalendarView { get; set; }

        /// <summary>
        /// Gets or sets calendarViewNextLink.
        /// </summary>
        [JsonPropertyName("calendarView@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string CalendarViewNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets customers.
        /// All the customers of this business. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("customers")]
        public IBookingBusinessCustomersCollectionPage Customers { get; set; }

        /// <summary>
        /// Gets or sets customersNextLink.
        /// </summary>
        [JsonPropertyName("customers@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string CustomersNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets custom questions.
        /// All the custom questions of this business. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("customQuestions")]
        public IBookingBusinessCustomQuestionsCollectionPage CustomQuestions { get; set; }

        /// <summary>
        /// Gets or sets customQuestionsNextLink.
        /// </summary>
        [JsonPropertyName("customQuestions@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string CustomQuestionsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets services.
        /// All the services offered by this business. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("services")]
        public IBookingBusinessServicesCollectionPage Services { get; set; }

        /// <summary>
        /// Gets or sets servicesNextLink.
        /// </summary>
        [JsonPropertyName("services@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ServicesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets staff members.
        /// All the staff members that provide services in this business. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("staffMembers")]
        public IBookingBusinessStaffMembersCollectionPage StaffMembers { get; set; }

        /// <summary>
        /// Gets or sets staffMembersNextLink.
        /// </summary>
        [JsonPropertyName("staffMembers@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string StaffMembersNextLink { get; set; }
    
    }
}

