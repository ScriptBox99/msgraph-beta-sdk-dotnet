using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class DetectionRule : ProtectionRule, IParsable {
        /// <summary>The detectionAction property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Security.DetectionAction? DetectionAction {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.DetectionAction?>("detectionAction"); }
            set { BackingStore?.Set("detectionAction", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Security.DetectionAction DetectionAction {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.DetectionAction>("detectionAction"); }
            set { BackingStore?.Set("detectionAction", value); }
        }
#endif
        /// <summary>The lastRunDetails property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RunDetails? LastRunDetails {
            get { return BackingStore?.Get<RunDetails?>("lastRunDetails"); }
            set { BackingStore?.Set("lastRunDetails", value); }
        }
#nullable restore
#else
        public RunDetails LastRunDetails {
            get { return BackingStore?.Get<RunDetails>("lastRunDetails"); }
            set { BackingStore?.Set("lastRunDetails", value); }
        }
#endif
        /// <summary>The queryCondition property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Security.QueryCondition? QueryCondition {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.QueryCondition?>("queryCondition"); }
            set { BackingStore?.Set("queryCondition", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Security.QueryCondition QueryCondition {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.QueryCondition>("queryCondition"); }
            set { BackingStore?.Set("queryCondition", value); }
        }
#endif
        /// <summary>The schedule property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RuleSchedule? Schedule {
            get { return BackingStore?.Get<RuleSchedule?>("schedule"); }
            set { BackingStore?.Set("schedule", value); }
        }
#nullable restore
#else
        public RuleSchedule Schedule {
            get { return BackingStore?.Get<RuleSchedule>("schedule"); }
            set { BackingStore?.Set("schedule", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new detectionRule and sets the default values.
        /// </summary>
        public DetectionRule() : base() {
            OdataType = "#microsoft.graph.security.detectionRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DetectionRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DetectionRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"detectionAction", n => { DetectionAction = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.DetectionAction>(Microsoft.Graph.Beta.Models.Security.DetectionAction.CreateFromDiscriminatorValue); } },
                {"lastRunDetails", n => { LastRunDetails = n.GetObjectValue<RunDetails>(RunDetails.CreateFromDiscriminatorValue); } },
                {"queryCondition", n => { QueryCondition = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.QueryCondition>(Microsoft.Graph.Beta.Models.Security.QueryCondition.CreateFromDiscriminatorValue); } },
                {"schedule", n => { Schedule = n.GetObjectValue<RuleSchedule>(RuleSchedule.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.DetectionAction>("detectionAction", DetectionAction);
            writer.WriteObjectValue<RunDetails>("lastRunDetails", LastRunDetails);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.QueryCondition>("queryCondition", QueryCondition);
            writer.WriteObjectValue<RuleSchedule>("schedule", Schedule);
        }
    }
}
