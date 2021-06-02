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
    /// The type Outlook Task.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<OutlookTask>))]
    public partial class OutlookTask : OutlookItem
    {
    
        ///<summary>
        /// The OutlookTask constructor
        ///</summary>
        public OutlookTask()
        {
            this.ODataType = "microsoft.graph.outlookTask";
        }

        /// <summary>
        /// Gets or sets assigned to.
        /// The name of the person who has been assigned the task in Outlook. Read-only.
        /// </summary>
        [JsonPropertyName("assignedTo")]
        public string AssignedTo { get; set; }
    
        /// <summary>
        /// Gets or sets body.
        /// The task body that typically contains information about the task. Note that only HTML type is supported.
        /// </summary>
        [JsonPropertyName("body")]
        public ItemBody Body { get; set; }
    
        /// <summary>
        /// Gets or sets completed date time.
        /// The date in the specified time zone that the task was finished.
        /// </summary>
        [JsonPropertyName("completedDateTime")]
        public DateTimeTimeZone CompletedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets due date time.
        /// The date in the specified time zone that the task is to be finished.
        /// </summary>
        [JsonPropertyName("dueDateTime")]
        public DateTimeTimeZone DueDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets has attachments.
        /// Set to true if the task has attachments.
        /// </summary>
        [JsonPropertyName("hasAttachments")]
        public bool? HasAttachments { get; set; }
    
        /// <summary>
        /// Gets or sets importance.
        /// </summary>
        [JsonPropertyName("importance")]
        public Importance? Importance { get; set; }
    
        /// <summary>
        /// Gets or sets is reminder on.
        /// </summary>
        [JsonPropertyName("isReminderOn")]
        public bool? IsReminderOn { get; set; }
    
        /// <summary>
        /// Gets or sets owner.
        /// </summary>
        [JsonPropertyName("owner")]
        public string Owner { get; set; }
    
        /// <summary>
        /// Gets or sets parent folder id.
        /// </summary>
        [JsonPropertyName("parentFolderId")]
        public string ParentFolderId { get; set; }
    
        /// <summary>
        /// Gets or sets recurrence.
        /// </summary>
        [JsonPropertyName("recurrence")]
        public PatternedRecurrence Recurrence { get; set; }
    
        /// <summary>
        /// Gets or sets reminder date time.
        /// </summary>
        [JsonPropertyName("reminderDateTime")]
        public DateTimeTimeZone ReminderDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets sensitivity.
        /// </summary>
        [JsonPropertyName("sensitivity")]
        public Sensitivity? Sensitivity { get; set; }
    
        /// <summary>
        /// Gets or sets start date time.
        /// </summary>
        [JsonPropertyName("startDateTime")]
        public DateTimeTimeZone StartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [JsonPropertyName("status")]
        public TaskStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets subject.
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }
    
        /// <summary>
        /// Gets or sets attachments.
        /// The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the task.  Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("attachments")]
        public IOutlookTaskAttachmentsCollectionPage Attachments { get; set; }

        /// <summary>
        /// Gets or sets attachmentsNextLink.
        /// </summary>
        [JsonPropertyName("attachments@odata.nextLink")]
        public string AttachmentsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets multi value extended properties.
        /// The collection of multi-value extended properties defined for the task. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("multiValueExtendedProperties")]
        public IOutlookTaskMultiValueExtendedPropertiesCollectionPage MultiValueExtendedProperties { get; set; }

        /// <summary>
        /// Gets or sets multiValueExtendedPropertiesNextLink.
        /// </summary>
        [JsonPropertyName("multiValueExtendedProperties@odata.nextLink")]
        public string MultiValueExtendedPropertiesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets single value extended properties.
        /// The collection of single-value extended properties defined for the task. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("singleValueExtendedProperties")]
        public IOutlookTaskSingleValueExtendedPropertiesCollectionPage SingleValueExtendedProperties { get; set; }

        /// <summary>
        /// Gets or sets singleValueExtendedPropertiesNextLink.
        /// </summary>
        [JsonPropertyName("singleValueExtendedProperties@odata.nextLink")]
        public string SingleValueExtendedPropertiesNextLink { get; set; }
    
    }
}

