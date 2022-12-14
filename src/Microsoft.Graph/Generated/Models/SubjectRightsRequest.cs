using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SubjectRightsRequest : Entity, IParsable {
        /// <summary>Identity that the request is assigned to.</summary>
        public Identity AssignedTo {
            get { return BackingStore?.Get<Identity>("assignedTo"); }
            set { BackingStore?.Set("assignedTo", value); }
        }
        /// <summary>The date and time when the request was closed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ClosedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("closedDateTime"); }
            set { BackingStore?.Set("closedDateTime", value); }
        }
        /// <summary>KQL based content query that should be used for search. This property is defined only for APIs accessed using the /security query path and not the /privacy query path.</summary>
        public string ContentQuery {
            get { return BackingStore?.Get<string>("contentQuery"); }
            set { BackingStore?.Set("contentQuery", value); }
        }
        /// <summary>Identity information for the entity that created the request.</summary>
        public IdentitySet CreatedBy {
            get { return BackingStore?.Get<IdentitySet>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
        /// <summary>The date and time when the request was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Information about the data subject.</summary>
        public Microsoft.Graph.Beta.Models.DataSubject DataSubject {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DataSubject>("dataSubject"); }
            set { BackingStore?.Set("dataSubject", value); }
        }
        /// <summary>The type of the data subject. Possible values are: customer, currentEmployee, formerEmployee, prospectiveEmployee, student, teacher, faculty, other, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.DataSubjectType? DataSubjectType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DataSubjectType?>("dataSubjectType"); }
            set { BackingStore?.Set("dataSubjectType", value); }
        }
        /// <summary>Description for the request.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>The name of the request.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The external ID for the request that is immutable after creation and is used for tracking the request for the external system. This property is defined only for APIs accessed using the /security query path and not the /privacy query path.</summary>
        public string ExternalId {
            get { return BackingStore?.Get<string>("externalId"); }
            set { BackingStore?.Set("externalId", value); }
        }
        /// <summary>Collection of history change events.</summary>
        public List<SubjectRightsRequestHistory> History {
            get { return BackingStore?.Get<List<SubjectRightsRequestHistory>>("history"); }
            set { BackingStore?.Set("history", value); }
        }
        /// <summary>Include all versions of the documents. By default, the current copies of the documents will be returned. If SharePoint sites have versioning enabled, including all versions will include the historical copies of the documents. This property is defined only for APIs accessed using the /security query path and not the /privacy query path.</summary>
        public bool? IncludeAllVersions {
            get { return BackingStore?.Get<bool?>("includeAllVersions"); }
            set { BackingStore?.Set("includeAllVersions", value); }
        }
        /// <summary>Include content authored by the data subject. This property is defined only for APIs accessed using the /security query path and not the /privacy query path.</summary>
        public bool? IncludeAuthoredContent {
            get { return BackingStore?.Get<bool?>("includeAuthoredContent"); }
            set { BackingStore?.Set("includeAuthoredContent", value); }
        }
        /// <summary>Insight about the request.</summary>
        public SubjectRightsRequestDetail Insight {
            get { return BackingStore?.Get<SubjectRightsRequestDetail>("insight"); }
            set { BackingStore?.Set("insight", value); }
        }
        /// <summary>The date and time when the request is internally due. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? InternalDueDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("internalDueDateTime"); }
            set { BackingStore?.Set("internalDueDateTime", value); }
        }
        /// <summary>Identity information for the entity that last modified the request.</summary>
        public IdentitySet LastModifiedBy {
            get { return BackingStore?.Get<IdentitySet>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
        /// <summary>The date and time when the request was last modified. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The mailboxlocations property</summary>
        public SubjectRightsRequestMailboxLocation Mailboxlocations {
            get { return BackingStore?.Get<SubjectRightsRequestMailboxLocation>("mailboxlocations"); }
            set { BackingStore?.Set("mailboxlocations", value); }
        }
        /// <summary>List of notes associated with the request.</summary>
        public List<AuthoredNote> Notes {
            get { return BackingStore?.Get<List<AuthoredNote>>("notes"); }
            set { BackingStore?.Set("notes", value); }
        }
        /// <summary>Pause the request after estimate has finished. By default, the data estimate will run and then pause, allowing you to preview results and then select the option to retrieve data in the UI. You can set this property to false if you want it to perform the estimate and then automatically begin with the retrieval of the content. This property is defined only for APIs accessed using the /security query path and not the /privacy query path.</summary>
        public bool? PauseAfterEstimate {
            get { return BackingStore?.Get<bool?>("pauseAfterEstimate"); }
            set { BackingStore?.Set("pauseAfterEstimate", value); }
        }
        /// <summary>List of regulations that this request will fulfill.</summary>
        public List<string> Regulations {
            get { return BackingStore?.Get<List<string>>("regulations"); }
            set { BackingStore?.Set("regulations", value); }
        }
        /// <summary>The sitelocations property</summary>
        public SubjectRightsRequestSiteLocation Sitelocations {
            get { return BackingStore?.Get<SubjectRightsRequestSiteLocation>("sitelocations"); }
            set { BackingStore?.Set("sitelocations", value); }
        }
        /// <summary>Information about the different stages for the request.</summary>
        public List<SubjectRightsRequestStageDetail> Stages {
            get { return BackingStore?.Get<List<SubjectRightsRequestStageDetail>>("stages"); }
            set { BackingStore?.Set("stages", value); }
        }
        /// <summary>The status of the request. Possible values are: active, closed, unknownFutureValue.</summary>
        public SubjectRightsRequestStatus? Status {
            get { return BackingStore?.Get<SubjectRightsRequestStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>Information about the Microsoft Teams team that was created for the request.</summary>
        public Microsoft.Graph.Beta.Models.Team Team {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Team>("team"); }
            set { BackingStore?.Set("team", value); }
        }
        /// <summary>The type of the request. Possible values are: export, delete, access, tagForAction, unknownFutureValue.</summary>
        public SubjectRightsRequestType? Type {
            get { return BackingStore?.Get<SubjectRightsRequestType?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SubjectRightsRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SubjectRightsRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignedTo", n => { AssignedTo = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
                {"closedDateTime", n => { ClosedDateTime = n.GetDateTimeOffsetValue(); } },
                {"contentQuery", n => { ContentQuery = n.GetStringValue(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"dataSubject", n => { DataSubject = n.GetObjectValue<Microsoft.Graph.Beta.Models.DataSubject>(Microsoft.Graph.Beta.Models.DataSubject.CreateFromDiscriminatorValue); } },
                {"dataSubjectType", n => { DataSubjectType = n.GetEnumValue<DataSubjectType>(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"externalId", n => { ExternalId = n.GetStringValue(); } },
                {"history", n => { History = n.GetCollectionOfObjectValues<SubjectRightsRequestHistory>(SubjectRightsRequestHistory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"includeAllVersions", n => { IncludeAllVersions = n.GetBoolValue(); } },
                {"includeAuthoredContent", n => { IncludeAuthoredContent = n.GetBoolValue(); } },
                {"insight", n => { Insight = n.GetObjectValue<SubjectRightsRequestDetail>(SubjectRightsRequestDetail.CreateFromDiscriminatorValue); } },
                {"internalDueDateTime", n => { InternalDueDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"mailboxlocations", n => { Mailboxlocations = n.GetObjectValue<SubjectRightsRequestMailboxLocation>(SubjectRightsRequestMailboxLocation.CreateFromDiscriminatorValue); } },
                {"notes", n => { Notes = n.GetCollectionOfObjectValues<AuthoredNote>(AuthoredNote.CreateFromDiscriminatorValue)?.ToList(); } },
                {"pauseAfterEstimate", n => { PauseAfterEstimate = n.GetBoolValue(); } },
                {"regulations", n => { Regulations = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"sitelocations", n => { Sitelocations = n.GetObjectValue<SubjectRightsRequestSiteLocation>(SubjectRightsRequestSiteLocation.CreateFromDiscriminatorValue); } },
                {"stages", n => { Stages = n.GetCollectionOfObjectValues<SubjectRightsRequestStageDetail>(SubjectRightsRequestStageDetail.CreateFromDiscriminatorValue)?.ToList(); } },
                {"status", n => { Status = n.GetEnumValue<SubjectRightsRequestStatus>(); } },
                {"team", n => { Team = n.GetObjectValue<Microsoft.Graph.Beta.Models.Team>(Microsoft.Graph.Beta.Models.Team.CreateFromDiscriminatorValue); } },
                {"type", n => { Type = n.GetEnumValue<SubjectRightsRequestType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Identity>("assignedTo", AssignedTo);
            writer.WriteDateTimeOffsetValue("closedDateTime", ClosedDateTime);
            writer.WriteStringValue("contentQuery", ContentQuery);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DataSubject>("dataSubject", DataSubject);
            writer.WriteEnumValue<DataSubjectType>("dataSubjectType", DataSubjectType);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteCollectionOfObjectValues<SubjectRightsRequestHistory>("history", History);
            writer.WriteBoolValue("includeAllVersions", IncludeAllVersions);
            writer.WriteBoolValue("includeAuthoredContent", IncludeAuthoredContent);
            writer.WriteObjectValue<SubjectRightsRequestDetail>("insight", Insight);
            writer.WriteDateTimeOffsetValue("internalDueDateTime", InternalDueDateTime);
            writer.WriteObjectValue<IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<SubjectRightsRequestMailboxLocation>("mailboxlocations", Mailboxlocations);
            writer.WriteCollectionOfObjectValues<AuthoredNote>("notes", Notes);
            writer.WriteBoolValue("pauseAfterEstimate", PauseAfterEstimate);
            writer.WriteCollectionOfPrimitiveValues<string>("regulations", Regulations);
            writer.WriteObjectValue<SubjectRightsRequestSiteLocation>("sitelocations", Sitelocations);
            writer.WriteCollectionOfObjectValues<SubjectRightsRequestStageDetail>("stages", Stages);
            writer.WriteEnumValue<SubjectRightsRequestStatus>("status", Status);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Team>("team", Team);
            writer.WriteEnumValue<SubjectRightsRequestType>("type", Type);
        }
    }
}
