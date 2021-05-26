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
    /// The type Booking Appointment.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<BookingAppointment>))]
    public partial class BookingAppointment : Entity
    {
    
        /// <summary>
        /// Gets or sets additional information.
        /// </summary>
        [JsonPropertyName("additionalInformation")]
        public string AdditionalInformation { get; set; }
    
        /// <summary>
        /// Gets or sets customer email address.
        /// The SMTP address of the bookingCustomer who is booking the appointment.
        /// </summary>
        [JsonPropertyName("customerEmailAddress")]
        public string CustomerEmailAddress { get; set; }
    
        /// <summary>
        /// Gets or sets customer id.
        /// If CustomerId is not specified when an appointment is created then a new customer is created based on the appointment customer information. Once set, the customerId should be considered immutable.
        /// </summary>
        [JsonPropertyName("customerId")]
        public string CustomerId { get; set; }
    
        /// <summary>
        /// Gets or sets customer location.
        /// Represents location information for the bookingCustomer who is booking the appointment.
        /// </summary>
        [JsonPropertyName("customerLocation")]
        public Location CustomerLocation { get; set; }
    
        /// <summary>
        /// Gets or sets customer name.
        /// The customer's name.
        /// </summary>
        [JsonPropertyName("customerName")]
        public string CustomerName { get; set; }
    
        /// <summary>
        /// Gets or sets customer notes.
        /// The value of this property is only available when reading an individual booking appointment by id. Its value can only be set when creating a new appointment with a new customer, ie, without specifying a CustomerId. After that, the property is computed from the customer represented by CustomerId.
        /// </summary>
        [JsonPropertyName("customerNotes")]
        public string CustomerNotes { get; set; }
    
        /// <summary>
        /// Gets or sets customer phone.
        /// The customer's phone number.
        /// </summary>
        [JsonPropertyName("customerPhone")]
        public string CustomerPhone { get; set; }
    
        /// <summary>
        /// Gets or sets duration.
        /// The length of the appointment, denoted in ISO8601 format.
        /// </summary>
        [JsonPropertyName("duration")]
        public Duration Duration { get; set; }
    
        /// <summary>
        /// Gets or sets end.
        /// The date, time, and time zone that the appointment ends.
        /// </summary>
        [JsonPropertyName("end")]
        public DateTimeTimeZone End { get; set; }
    
        /// <summary>
        /// Gets or sets invoice amount.
        /// The billed amount on the invoice.
        /// </summary>
        [JsonPropertyName("invoiceAmount")]
        public double? InvoiceAmount { get; set; }
    
        /// <summary>
        /// Gets or sets invoice date.
        /// The date, time, and time zone of the invoice for this appointment.
        /// </summary>
        [JsonPropertyName("invoiceDate")]
        public DateTimeTimeZone InvoiceDate { get; set; }
    
        /// <summary>
        /// Gets or sets invoice id.
        /// The ID of the invoice.
        /// </summary>
        [JsonPropertyName("invoiceId")]
        public string InvoiceId { get; set; }
    
        /// <summary>
        /// Gets or sets invoice status.
        /// The status of the invoice. Possible values are: draft, reviewing, open, canceled, paid, corrective.
        /// </summary>
        [JsonPropertyName("invoiceStatus")]
        public BookingInvoiceStatus? InvoiceStatus { get; set; }
    
        /// <summary>
        /// Gets or sets invoice url.
        /// The URL of the invoice in Microsoft Bookings.
        /// </summary>
        [JsonPropertyName("invoiceUrl")]
        public string InvoiceUrl { get; set; }
    
        /// <summary>
        /// Gets or sets is location online.
        /// </summary>
        [JsonPropertyName("isLocationOnline")]
        public bool? IsLocationOnline { get; set; }
    
        /// <summary>
        /// Gets or sets online meeting url.
        /// </summary>
        [JsonPropertyName("onlineMeetingUrl")]
        public string OnlineMeetingUrl { get; set; }
    
        /// <summary>
        /// Gets or sets opt out of customer email.
        /// True indicates that the bookingCustomer for this appointment does not wish to receive a confirmation for this appointment.
        /// </summary>
        [JsonPropertyName("optOutOfCustomerEmail")]
        public bool? OptOutOfCustomerEmail { get; set; }
    
        /// <summary>
        /// Gets or sets post buffer.
        /// The amount of time to reserve after the appointment ends, for cleaning up, as an example. The value is expressed in ISO8601 format.
        /// </summary>
        [JsonPropertyName("postBuffer")]
        public Duration PostBuffer { get; set; }
    
        /// <summary>
        /// Gets or sets pre buffer.
        /// The amount of time to reserve before the appointment begins, for preparation, as an example. The value is expressed in ISO8601 format.
        /// </summary>
        [JsonPropertyName("preBuffer")]
        public Duration PreBuffer { get; set; }
    
        /// <summary>
        /// Gets or sets price.
        /// The regular price for an appointment for the specified bookingService.
        /// </summary>
        [JsonPropertyName("price")]
        public double? Price { get; set; }
    
        /// <summary>
        /// Gets or sets price type.
        /// A setting to provide flexibility for the pricing structure of services. Possible values are: undefined, fixedPrice, startingAt, hourly, free, priceVaries, callUs, notSet.
        /// </summary>
        [JsonPropertyName("priceType")]
        public BookingPriceType? PriceType { get; set; }
    
        /// <summary>
        /// Gets or sets reminders.
        /// The value of this property is only available when reading an individual booking appointment by id.
        /// </summary>
        [JsonPropertyName("reminders")]
        public IEnumerable<BookingReminder> Reminders { get; set; }
    
        /// <summary>
        /// Gets or sets self service appointment id.
        /// An additional tracking ID for the appointment, if the appointment has been created directly by the customer on the scheduling page, as opposed to by a staff member on the behalf of the customer.
        /// </summary>
        [JsonPropertyName("selfServiceAppointmentId")]
        public string SelfServiceAppointmentId { get; set; }
    
        /// <summary>
        /// Gets or sets service id.
        /// The ID of the bookingService associated with this appointment.
        /// </summary>
        [JsonPropertyName("serviceId")]
        public string ServiceId { get; set; }
    
        /// <summary>
        /// Gets or sets service location.
        /// The location where the service is delivered.
        /// </summary>
        [JsonPropertyName("serviceLocation")]
        public Location ServiceLocation { get; set; }
    
        /// <summary>
        /// Gets or sets service name.
        /// This property is optional when creating a new appointment. If not specified, it is computed from the service associated with the appointment by the service id.
        /// </summary>
        [JsonPropertyName("serviceName")]
        public string ServiceName { get; set; }
    
        /// <summary>
        /// Gets or sets service notes.
        /// The value of this property is only available when reading an individual booking appointment by id.
        /// </summary>
        [JsonPropertyName("serviceNotes")]
        public string ServiceNotes { get; set; }
    
        /// <summary>
        /// Gets or sets staff member ids.
        /// The ID of each bookingStaffMember who is scheduled in this appointment.
        /// </summary>
        [JsonPropertyName("staffMemberIds")]
        public IEnumerable<string> StaffMemberIds { get; set; }
    
        /// <summary>
        /// Gets or sets start.
        /// The date, time, and time zone that the appointment begins.
        /// </summary>
        [JsonPropertyName("start")]
        public DateTimeTimeZone Start { get; set; }
    
    }
}

