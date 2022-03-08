using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the identityGovernance singleton.</summary>
    public class ApprovalSettings : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>One of NoApproval, SingleStage or Serial. The NoApproval is used when isApprovalRequired is false.</summary>
        public string ApprovalMode { get; set; }
        /// <summary>If approval is required, the one or two elements of this collection define each of the stages of approval. An empty array if no approval is required.</summary>
        public List<ApprovalStage> ApprovalStages { get; set; }
        /// <summary>If false, then approval is not required for requests in this policy.</summary>
        public bool? IsApprovalRequired { get; set; }
        /// <summary>If false, then approval is not required for a user who already has an assignment to extend their assignment.</summary>
        public bool? IsApprovalRequiredForExtension { get; set; }
        /// <summary>Indicates whether the requestor is required to supply a justification in their request.</summary>
        public bool? IsRequestorJustificationRequired { get; set; }
        /// <summary>
        /// Instantiates a new approvalSettings and sets the default values.
        /// </summary>
        public ApprovalSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApprovalSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApprovalSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"approvalMode", (o,n) => { (o as ApprovalSettings).ApprovalMode = n.GetStringValue(); } },
                {"approvalStages", (o,n) => { (o as ApprovalSettings).ApprovalStages = n.GetCollectionOfObjectValues<ApprovalStage>(ApprovalStage.CreateFromDiscriminatorValue).ToList(); } },
                {"isApprovalRequired", (o,n) => { (o as ApprovalSettings).IsApprovalRequired = n.GetBoolValue(); } },
                {"isApprovalRequiredForExtension", (o,n) => { (o as ApprovalSettings).IsApprovalRequiredForExtension = n.GetBoolValue(); } },
                {"isRequestorJustificationRequired", (o,n) => { (o as ApprovalSettings).IsRequestorJustificationRequired = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("approvalMode", ApprovalMode);
            writer.WriteCollectionOfObjectValues<ApprovalStage>("approvalStages", ApprovalStages);
            writer.WriteBoolValue("isApprovalRequired", IsApprovalRequired);
            writer.WriteBoolValue("isApprovalRequiredForExtension", IsApprovalRequiredForExtension);
            writer.WriteBoolValue("isRequestorJustificationRequired", IsRequestorJustificationRequired);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
