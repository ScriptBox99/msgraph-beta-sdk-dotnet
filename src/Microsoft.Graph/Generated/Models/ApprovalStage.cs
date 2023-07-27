using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class ApprovalStage : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The number of days that a request can be pending a response before it is automatically denied.</summary>
        public int? ApprovalStageTimeOutInDays {
            get { return BackingStore?.Get<int?>("approvalStageTimeOutInDays"); }
            set { BackingStore?.Set("approvalStageTimeOutInDays", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>If escalation is enabled and the primary approvers do not respond before the escalation time, the escalationApprovers are the users who will be asked to approve requests. This can be a collection of singleUser, groupMembers, requestorManager, internalSponsors and externalSponsors.  When creating or updating a policy, if there are no escalation approvers, or escalation approvers are not required for the stage, the value of this property should be an empty collection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserSet>? EscalationApprovers {
            get { return BackingStore?.Get<List<UserSet>?>("escalationApprovers"); }
            set { BackingStore?.Set("escalationApprovers", value); }
        }
#nullable restore
#else
        public List<UserSet> EscalationApprovers {
            get { return BackingStore?.Get<List<UserSet>>("escalationApprovers"); }
            set { BackingStore?.Set("escalationApprovers", value); }
        }
#endif
        /// <summary>If escalation is required, the time a request can be pending a response from a primary approver.</summary>
        public int? EscalationTimeInMinutes {
            get { return BackingStore?.Get<int?>("escalationTimeInMinutes"); }
            set { BackingStore?.Set("escalationTimeInMinutes", value); }
        }
        /// <summary>Indicates whether the approver is required to provide a justification for approving a request.</summary>
        public bool? IsApproverJustificationRequired {
            get { return BackingStore?.Get<bool?>("isApproverJustificationRequired"); }
            set { BackingStore?.Set("isApproverJustificationRequired", value); }
        }
        /// <summary>If true, then one or more escalation approvers are configured in this approval stage.</summary>
        public bool? IsEscalationEnabled {
            get { return BackingStore?.Get<bool?>("isEscalationEnabled"); }
            set { BackingStore?.Set("isEscalationEnabled", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The users who will be asked to approve requests. A collection of singleUser, groupMembers, requestorManager, internalSponsors, externalSponsors and targetUserSponsors. When creating or updating a policy, include at least one userSet in this collection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserSet>? PrimaryApprovers {
            get { return BackingStore?.Get<List<UserSet>?>("primaryApprovers"); }
            set { BackingStore?.Set("primaryApprovers", value); }
        }
#nullable restore
#else
        public List<UserSet> PrimaryApprovers {
            get { return BackingStore?.Get<List<UserSet>>("primaryApprovers"); }
            set { BackingStore?.Set("primaryApprovers", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new approvalStage and sets the default values.
        /// </summary>
        public ApprovalStage() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ApprovalStage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApprovalStage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"approvalStageTimeOutInDays", n => { ApprovalStageTimeOutInDays = n.GetIntValue(); } },
                {"escalationApprovers", n => { EscalationApprovers = n.GetCollectionOfObjectValues<UserSet>(UserSet.CreateFromDiscriminatorValue)?.ToList(); } },
                {"escalationTimeInMinutes", n => { EscalationTimeInMinutes = n.GetIntValue(); } },
                {"isApproverJustificationRequired", n => { IsApproverJustificationRequired = n.GetBoolValue(); } },
                {"isEscalationEnabled", n => { IsEscalationEnabled = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"primaryApprovers", n => { PrimaryApprovers = n.GetCollectionOfObjectValues<UserSet>(UserSet.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("approvalStageTimeOutInDays", ApprovalStageTimeOutInDays);
            writer.WriteCollectionOfObjectValues<UserSet>("escalationApprovers", EscalationApprovers);
            writer.WriteIntValue("escalationTimeInMinutes", EscalationTimeInMinutes);
            writer.WriteBoolValue("isApproverJustificationRequired", IsApproverJustificationRequired);
            writer.WriteBoolValue("isEscalationEnabled", IsEscalationEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<UserSet>("primaryApprovers", PrimaryApprovers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
