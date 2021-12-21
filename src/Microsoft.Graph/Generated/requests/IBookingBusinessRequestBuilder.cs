// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IBookingBusinessRequestBuilder.
    /// </summary>
    public partial interface IBookingBusinessRequestBuilder : IBookingNamedEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IBookingBusinessRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IBookingBusinessRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Appointments.
        /// </summary>
        /// <returns>The <see cref="IBookingBusinessAppointmentsCollectionRequestBuilder"/>.</returns>
        IBookingBusinessAppointmentsCollectionRequestBuilder Appointments { get; }

        /// <summary>
        /// Gets the request builder for CalendarView.
        /// </summary>
        /// <returns>The <see cref="IBookingBusinessCalendarViewCollectionRequestBuilder"/>.</returns>
        IBookingBusinessCalendarViewCollectionRequestBuilder CalendarView { get; }

        /// <summary>
        /// Gets the request builder for Customers.
        /// </summary>
        /// <returns>The <see cref="IBookingBusinessCustomersCollectionRequestBuilder"/>.</returns>
        IBookingBusinessCustomersCollectionRequestBuilder Customers { get; }

        /// <summary>
        /// Gets the request builder for CustomQuestions.
        /// </summary>
        /// <returns>The <see cref="IBookingBusinessCustomQuestionsCollectionRequestBuilder"/>.</returns>
        IBookingBusinessCustomQuestionsCollectionRequestBuilder CustomQuestions { get; }

        /// <summary>
        /// Gets the request builder for Services.
        /// </summary>
        /// <returns>The <see cref="IBookingBusinessServicesCollectionRequestBuilder"/>.</returns>
        IBookingBusinessServicesCollectionRequestBuilder Services { get; }

        /// <summary>
        /// Gets the request builder for StaffMembers.
        /// </summary>
        /// <returns>The <see cref="IBookingBusinessStaffMembersCollectionRequestBuilder"/>.</returns>
        IBookingBusinessStaffMembersCollectionRequestBuilder StaffMembers { get; }
    
        /// <summary>
        /// Gets the request builder for BookingBusinessPublish.
        /// </summary>
        /// <returns>The <see cref="IBookingBusinessPublishRequestBuilder"/>.</returns>
        IBookingBusinessPublishRequestBuilder Publish();

        /// <summary>
        /// Gets the request builder for BookingBusinessUnpublish.
        /// </summary>
        /// <returns>The <see cref="IBookingBusinessUnpublishRequestBuilder"/>.</returns>
        IBookingBusinessUnpublishRequestBuilder Unpublish();
    
    }
}
