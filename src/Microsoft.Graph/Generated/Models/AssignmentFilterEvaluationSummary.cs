using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Represent result summary for assignment filter evaluation
    /// </summary>
    public class AssignmentFilterEvaluationSummary : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The admin defined name for assignment filter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignmentFilterDisplayName {
            get { return BackingStore?.Get<string?>("assignmentFilterDisplayName"); }
            set { BackingStore?.Set("assignmentFilterDisplayName", value); }
        }
#nullable restore
#else
        public string AssignmentFilterDisplayName {
            get { return BackingStore?.Get<string>("assignmentFilterDisplayName"); }
            set { BackingStore?.Set("assignmentFilterDisplayName", value); }
        }
#endif
        /// <summary>Unique identifier for the assignment filter object</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignmentFilterId {
            get { return BackingStore?.Get<string?>("assignmentFilterId"); }
            set { BackingStore?.Set("assignmentFilterId", value); }
        }
#nullable restore
#else
        public string AssignmentFilterId {
            get { return BackingStore?.Get<string>("assignmentFilterId"); }
            set { BackingStore?.Set("assignmentFilterId", value); }
        }
#endif
        /// <summary>The time the assignment filter was last modified.</summary>
        public DateTimeOffset? AssignmentFilterLastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("assignmentFilterLastModifiedDateTime"); }
            set { BackingStore?.Set("assignmentFilterLastModifiedDateTime", value); }
        }
        /// <summary>Supported platform types.</summary>
        public DevicePlatformType? AssignmentFilterPlatform {
            get { return BackingStore?.Get<DevicePlatformType?>("assignmentFilterPlatform"); }
            set { BackingStore?.Set("assignmentFilterPlatform", value); }
        }
        /// <summary>Represents type of the assignment filter.</summary>
        public DeviceAndAppManagementAssignmentFilterType? AssignmentFilterType {
            get { return BackingStore?.Get<DeviceAndAppManagementAssignmentFilterType?>("assignmentFilterType"); }
            set { BackingStore?.Set("assignmentFilterType", value); }
        }
        /// <summary>A collection of filter types and their corresponding evaluation results.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AssignmentFilterTypeAndEvaluationResult>? AssignmentFilterTypeAndEvaluationResults {
            get { return BackingStore?.Get<List<AssignmentFilterTypeAndEvaluationResult>?>("assignmentFilterTypeAndEvaluationResults"); }
            set { BackingStore?.Set("assignmentFilterTypeAndEvaluationResults", value); }
        }
#nullable restore
#else
        public List<AssignmentFilterTypeAndEvaluationResult> AssignmentFilterTypeAndEvaluationResults {
            get { return BackingStore?.Get<List<AssignmentFilterTypeAndEvaluationResult>>("assignmentFilterTypeAndEvaluationResults"); }
            set { BackingStore?.Set("assignmentFilterTypeAndEvaluationResults", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The time assignment filter was evaluated.</summary>
        public DateTimeOffset? EvaluationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("evaluationDateTime"); }
            set { BackingStore?.Set("evaluationDateTime", value); }
        }
        /// <summary>Supported evaluation results for filter.</summary>
        public AssignmentFilterEvaluationResult? EvaluationResult {
            get { return BackingStore?.Get<AssignmentFilterEvaluationResult?>("evaluationResult"); }
            set { BackingStore?.Set("evaluationResult", value); }
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
        /// <summary>
        /// Instantiates a new assignmentFilterEvaluationSummary and sets the default values.
        /// </summary>
        public AssignmentFilterEvaluationSummary() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AssignmentFilterEvaluationSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AssignmentFilterEvaluationSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"assignmentFilterDisplayName", n => { AssignmentFilterDisplayName = n.GetStringValue(); } },
                {"assignmentFilterId", n => { AssignmentFilterId = n.GetStringValue(); } },
                {"assignmentFilterLastModifiedDateTime", n => { AssignmentFilterLastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"assignmentFilterPlatform", n => { AssignmentFilterPlatform = n.GetEnumValue<DevicePlatformType>(); } },
                {"assignmentFilterType", n => { AssignmentFilterType = n.GetEnumValue<DeviceAndAppManagementAssignmentFilterType>(); } },
                {"assignmentFilterTypeAndEvaluationResults", n => { AssignmentFilterTypeAndEvaluationResults = n.GetCollectionOfObjectValues<AssignmentFilterTypeAndEvaluationResult>(AssignmentFilterTypeAndEvaluationResult.CreateFromDiscriminatorValue)?.ToList(); } },
                {"evaluationDateTime", n => { EvaluationDateTime = n.GetDateTimeOffsetValue(); } },
                {"evaluationResult", n => { EvaluationResult = n.GetEnumValue<AssignmentFilterEvaluationResult>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("assignmentFilterDisplayName", AssignmentFilterDisplayName);
            writer.WriteStringValue("assignmentFilterId", AssignmentFilterId);
            writer.WriteDateTimeOffsetValue("assignmentFilterLastModifiedDateTime", AssignmentFilterLastModifiedDateTime);
            writer.WriteEnumValue<DevicePlatformType>("assignmentFilterPlatform", AssignmentFilterPlatform);
            writer.WriteEnumValue<DeviceAndAppManagementAssignmentFilterType>("assignmentFilterType", AssignmentFilterType);
            writer.WriteCollectionOfObjectValues<AssignmentFilterTypeAndEvaluationResult>("assignmentFilterTypeAndEvaluationResults", AssignmentFilterTypeAndEvaluationResults);
            writer.WriteDateTimeOffsetValue("evaluationDateTime", EvaluationDateTime);
            writer.WriteEnumValue<AssignmentFilterEvaluationResult>("evaluationResult", EvaluationResult);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
