using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants {
    /// <summary>Provides operations to manage the tenantRelationship singleton.</summary>
    public class ManagementTemplate : Entity, IParsable {
        /// <summary>The management category for the management template. Possible values are: custom, devices, identity, unknownFutureValue. Required. Read-only.</summary>
        public ManagementCategory? Category { get; set; }
        public string CreatedByUserId { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The description for the management template. Optional. Read-only.</summary>
        public string Description { get; set; }
        /// <summary>The display name for the management template. Required. Read-only.</summary>
        public string DisplayName { get; set; }
        public List<ActionUrl> InformationLinks { get; set; }
        public string LastActionByUserId { get; set; }
        public DateTimeOffset? LastActionDateTime { get; set; }
        public List<ManagementTemplateCollection> ManagementTemplateCollections { get; set; }
        public List<ManagementTemplateStep> ManagementTemplateSteps { get; set; }
        /// <summary>The collection of parameters used by the management template. Optional. Read-only.</summary>
        public List<TemplateParameter> Parameters { get; set; }
        public int? Priority { get; set; }
        public ManagementProvider? Provider { get; set; }
        public string UserImpact { get; set; }
        public int? Version { get; set; }
        /// <summary>The collection of workload actions associated with the management template. Optional. Read-only.</summary>
        public List<WorkloadAction> WorkloadActions { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ManagementTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagementTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"category", (o,n) => { (o as ManagementTemplate).Category = n.GetEnumValue<ManagementCategory>(); } },
                {"createdByUserId", (o,n) => { (o as ManagementTemplate).CreatedByUserId = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as ManagementTemplate).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as ManagementTemplate).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as ManagementTemplate).DisplayName = n.GetStringValue(); } },
                {"informationLinks", (o,n) => { (o as ManagementTemplate).InformationLinks = n.GetCollectionOfObjectValues<ActionUrl>(ActionUrl.CreateFromDiscriminatorValue).ToList(); } },
                {"lastActionByUserId", (o,n) => { (o as ManagementTemplate).LastActionByUserId = n.GetStringValue(); } },
                {"lastActionDateTime", (o,n) => { (o as ManagementTemplate).LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"managementTemplateCollections", (o,n) => { (o as ManagementTemplate).ManagementTemplateCollections = n.GetCollectionOfObjectValues<ManagementTemplateCollection>(ManagementTemplateCollection.CreateFromDiscriminatorValue).ToList(); } },
                {"managementTemplateSteps", (o,n) => { (o as ManagementTemplate).ManagementTemplateSteps = n.GetCollectionOfObjectValues<ManagementTemplateStep>(ManagementTemplateStep.CreateFromDiscriminatorValue).ToList(); } },
                {"parameters", (o,n) => { (o as ManagementTemplate).Parameters = n.GetCollectionOfObjectValues<TemplateParameter>(TemplateParameter.CreateFromDiscriminatorValue).ToList(); } },
                {"priority", (o,n) => { (o as ManagementTemplate).Priority = n.GetIntValue(); } },
                {"provider", (o,n) => { (o as ManagementTemplate).Provider = n.GetEnumValue<ManagementProvider>(); } },
                {"userImpact", (o,n) => { (o as ManagementTemplate).UserImpact = n.GetStringValue(); } },
                {"version", (o,n) => { (o as ManagementTemplate).Version = n.GetIntValue(); } },
                {"workloadActions", (o,n) => { (o as ManagementTemplate).WorkloadActions = n.GetCollectionOfObjectValues<WorkloadAction>(WorkloadAction.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<ManagementCategory>("category", Category);
            writer.WriteStringValue("createdByUserId", CreatedByUserId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<ActionUrl>("informationLinks", InformationLinks);
            writer.WriteStringValue("lastActionByUserId", LastActionByUserId);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteCollectionOfObjectValues<ManagementTemplateCollection>("managementTemplateCollections", ManagementTemplateCollections);
            writer.WriteCollectionOfObjectValues<ManagementTemplateStep>("managementTemplateSteps", ManagementTemplateSteps);
            writer.WriteCollectionOfObjectValues<TemplateParameter>("parameters", Parameters);
            writer.WriteIntValue("priority", Priority);
            writer.WriteEnumValue<ManagementProvider>("provider", Provider);
            writer.WriteStringValue("userImpact", UserImpact);
            writer.WriteIntValue("version", Version);
            writer.WriteCollectionOfObjectValues<WorkloadAction>("workloadActions", WorkloadActions);
        }
    }
}
