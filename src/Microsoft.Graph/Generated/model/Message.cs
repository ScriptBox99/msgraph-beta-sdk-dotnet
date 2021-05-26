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
    /// The type Message.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Message>))]
    public partial class Message : OutlookItem
    {
    
        ///<summary>
        /// The Message constructor
        ///</summary>
        public Message()
        {
            this.ODataType = "microsoft.graph.message";
        }
    
        /// <summary>
        /// Gets or sets bcc recipients.
        /// The Bcc: recipients for the message.
        /// </summary>
        [JsonPropertyName("bccRecipients")]
        public IEnumerable<Recipient> BccRecipients { get; set; }
    
        /// <summary>
        /// Gets or sets body.
        /// The body of the message. It can be in HTML or text format. Find out about safe HTML in a message body.
        /// </summary>
        [JsonPropertyName("body")]
        public ItemBody Body { get; set; }
    
        /// <summary>
        /// Gets or sets body preview.
        /// The first 255 characters of the message body. It is in text format. If the message contains instances of mention, this property would contain a concatenation of these mentions as well.
        /// </summary>
        [JsonPropertyName("bodyPreview")]
        public string BodyPreview { get; set; }
    
        /// <summary>
        /// Gets or sets cc recipients.
        /// The Cc: recipients for the message.
        /// </summary>
        [JsonPropertyName("ccRecipients")]
        public IEnumerable<Recipient> CcRecipients { get; set; }
    
        /// <summary>
        /// Gets or sets conversation id.
        /// The ID of the conversation the email belongs to.
        /// </summary>
        [JsonPropertyName("conversationId")]
        public string ConversationId { get; set; }
    
        /// <summary>
        /// Gets or sets conversation index.
        /// Indicates the position of the message within the conversation.
        /// </summary>
        [JsonPropertyName("conversationIndex")]
        public byte[] ConversationIndex { get; set; }
    
        /// <summary>
        /// Gets or sets flag.
        /// The flag value that indicates the status, start date, due date, or completion date for the message.
        /// </summary>
        [JsonPropertyName("flag")]
        public FollowupFlag Flag { get; set; }
    
        /// <summary>
        /// Gets or sets from.
        /// The owner of the mailbox from which the message is sent. In most cases, this value is the same as the sender property, except for sharing or delegation scenarios. The value must correspond to the actual mailbox used. Find out more about setting the from and sender properties of a message.
        /// </summary>
        [JsonPropertyName("from")]
        public Recipient From { get; set; }
    
        /// <summary>
        /// Gets or sets has attachments.
        /// Indicates whether the message has attachments. This property doesn't include inline attachments, so if a message contains only inline attachments, this property is false. To verify the existence of inline attachments, parse the body property to look for a src attribute, such as &amp;lt;IMG src='cid:image001.jpg@01D26CD8.6C05F070'&amp;gt;.
        /// </summary>
        [JsonPropertyName("hasAttachments")]
        public bool? HasAttachments { get; set; }
    
        /// <summary>
        /// Gets or sets importance.
        /// The importance of the message. The possible values are: low, normal, and high.
        /// </summary>
        [JsonPropertyName("importance")]
        public Importance? Importance { get; set; }
    
        /// <summary>
        /// Gets or sets inference classification.
        /// The classification of the message for the user, based on inferred relevance or importance, or on an explicit override. The possible values are: focused or other.
        /// </summary>
        [JsonPropertyName("inferenceClassification")]
        public InferenceClassificationType? InferenceClassification { get; set; }
    
        /// <summary>
        /// Gets or sets internet message headers.
        /// A collection of message headers defined by RFC5322. The set includes message headers indicating the network path taken by a message from the sender to the recipient. It can also contain custom message headers that hold app data for the message.  Returned only on applying a $select query option. Read-only.
        /// </summary>
        [JsonPropertyName("internetMessageHeaders")]
        public IEnumerable<InternetMessageHeader> InternetMessageHeaders { get; set; }
    
        /// <summary>
        /// Gets or sets internet message id.
        /// The message ID in the format specified by RFC2822.
        /// </summary>
        [JsonPropertyName("internetMessageId")]
        public string InternetMessageId { get; set; }
    
        /// <summary>
        /// Gets or sets is delivery receipt requested.
        /// Indicates whether a read receipt is requested for the message.
        /// </summary>
        [JsonPropertyName("isDeliveryReceiptRequested")]
        public bool? IsDeliveryReceiptRequested { get; set; }
    
        /// <summary>
        /// Gets or sets is draft.
        /// Indicates whether the message is a draft. A message is a draft if it hasn't been sent yet.
        /// </summary>
        [JsonPropertyName("isDraft")]
        public bool? IsDraft { get; set; }
    
        /// <summary>
        /// Gets or sets is read.
        /// Indicates whether the message has been read.
        /// </summary>
        [JsonPropertyName("isRead")]
        public bool? IsRead { get; set; }
    
        /// <summary>
        /// Gets or sets is read receipt requested.
        /// Indicates whether a read receipt is requested for the message.
        /// </summary>
        [JsonPropertyName("isReadReceiptRequested")]
        public bool? IsReadReceiptRequested { get; set; }
    
        /// <summary>
        /// Gets or sets mentions preview.
        /// </summary>
        [JsonPropertyName("mentionsPreview")]
        public MentionsPreview MentionsPreview { get; set; }
    
        /// <summary>
        /// Gets or sets parent folder id.
        /// The unique identifier for the message's parent mailFolder.
        /// </summary>
        [JsonPropertyName("parentFolderId")]
        public string ParentFolderId { get; set; }
    
        /// <summary>
        /// Gets or sets received date time.
        /// The date and time the message was received.  The date and time information uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        /// </summary>
        [JsonPropertyName("receivedDateTime")]
        public DateTimeOffset? ReceivedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets reply to.
        /// The email addresses to use when replying.
        /// </summary>
        [JsonPropertyName("replyTo")]
        public IEnumerable<Recipient> ReplyTo { get; set; }
    
        /// <summary>
        /// Gets or sets sender.
        /// The account that is actually used to generate the message. In most cases, this value is the same as the from property. You can set this property to a different value when sending a message from a shared mailbox, for a shared calendar, or as a delegate. In any case, the value must correspond to the actual mailbox used. Find out more about setting the from and sender properties of a message.
        /// </summary>
        [JsonPropertyName("sender")]
        public Recipient Sender { get; set; }
    
        /// <summary>
        /// Gets or sets sent date time.
        /// The date and time the message was sent.  The date and time information uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        /// </summary>
        [JsonPropertyName("sentDateTime")]
        public DateTimeOffset? SentDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets subject.
        /// The subject of the message.
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }
    
        /// <summary>
        /// Gets or sets to recipients.
        /// The To: recipients for the message.
        /// </summary>
        [JsonPropertyName("toRecipients")]
        public IEnumerable<Recipient> ToRecipients { get; set; }
    
        /// <summary>
        /// Gets or sets unique body.
        /// The part of the body of the message that is unique to the current message. uniqueBody is not returned by default but can be retrieved for a given message by use of the ?$select=uniqueBody query. It can be in HTML or text format.
        /// </summary>
        [JsonPropertyName("uniqueBody")]
        public ItemBody UniqueBody { get; set; }
    
        /// <summary>
        /// Gets or sets unsubscribe data.
        /// </summary>
        [JsonPropertyName("unsubscribeData")]
        public IEnumerable<string> UnsubscribeData { get; set; }
    
        /// <summary>
        /// Gets or sets unsubscribe enabled.
        /// </summary>
        [JsonPropertyName("unsubscribeEnabled")]
        public bool? UnsubscribeEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets web link.
        /// The URL to open the message in Outlook on the web.You can append an ispopout argument to the end of the URL to change how the message is displayed. If ispopout is not present or if it is set to 1, then the message is shown in a popout window. If ispopout is set to 0, then the browser will show the message in the Outlook on the web review pane.The message will open in the browser if you are logged in to your mailbox via Outlook on the web. You will be prompted to login if you are not already logged in with the browser.This URL cannot be accessed from within an iFrame.
        /// </summary>
        [JsonPropertyName("webLink")]
        public string WebLink { get; set; }
    
        /// <summary>
        /// Gets or sets attachments.
        /// The fileAttachment and itemAttachment attachments for the message.
        /// </summary>
        [JsonPropertyName("attachments")]
        public IMessageAttachmentsCollectionPage Attachments { get; set; }

        /// <summary>
        /// Gets or sets attachmentsNextLink.
        /// </summary>
        [JsonPropertyName("attachments@odata.nextLink")]
        public string AttachmentsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets extensions.
        /// The collection of open extensions defined for the message. Nullable.
        /// </summary>
        [JsonPropertyName("extensions")]
        public IMessageExtensionsCollectionPage Extensions { get; set; }

        /// <summary>
        /// Gets or sets extensionsNextLink.
        /// </summary>
        [JsonPropertyName("extensions@odata.nextLink")]
        public string ExtensionsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets mentions.
        /// A collection of mentions in the message, ordered by the createdDateTime from the newest to the oldest. By default, a GET /messages does not return this property unless you apply $expand on the property.
        /// </summary>
        [JsonPropertyName("mentions")]
        public IMessageMentionsCollectionPage Mentions { get; set; }

        /// <summary>
        /// Gets or sets mentionsNextLink.
        /// </summary>
        [JsonPropertyName("mentions@odata.nextLink")]
        public string MentionsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets multi value extended properties.
        /// The collection of multi-value extended properties defined for the message. Nullable.
        /// </summary>
        [JsonPropertyName("multiValueExtendedProperties")]
        public IMessageMultiValueExtendedPropertiesCollectionPage MultiValueExtendedProperties { get; set; }

        /// <summary>
        /// Gets or sets multiValueExtendedPropertiesNextLink.
        /// </summary>
        [JsonPropertyName("multiValueExtendedProperties@odata.nextLink")]
        public string MultiValueExtendedPropertiesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets single value extended properties.
        /// The collection of single-value extended properties defined for the message. Nullable.
        /// </summary>
        [JsonPropertyName("singleValueExtendedProperties")]
        public IMessageSingleValueExtendedPropertiesCollectionPage SingleValueExtendedProperties { get; set; }

        /// <summary>
        /// Gets or sets singleValueExtendedPropertiesNextLink.
        /// </summary>
        [JsonPropertyName("singleValueExtendedProperties@odata.nextLink")]
        public string SingleValueExtendedPropertiesNextLink { get; set; }
    
    }
}

