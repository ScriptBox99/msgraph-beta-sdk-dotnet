using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceAppManagement singleton.</summary>
    public class TargetedManagedAppProtection : ManagedAppProtection, IParsable {
        /// <summary>Public Apps selection: group or individual. Possible values are: selectedPublicApps, allCoreMicrosoftApps, allMicrosoftApps, allApps.</summary>
        public TargetedManagedAppGroupType? AppGroupType { get; set; }
        /// <summary>Navigation property to list of inclusion and exclusion groups to which the policy is deployed.</summary>
        public List<TargetedManagedAppPolicyAssignment> Assignments { get; set; }
        /// <summary>Indicates if the policy is deployed to any inclusion groups or not.</summary>
        public bool? IsAssigned { get; set; }
        /// <summary>The intended app management levels for this policy. Possible values are: unspecified, unmanaged, mdm, androidEnterprise.</summary>
        public AppManagementLevel? TargetedAppManagementLevels { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TargetedManagedAppProtection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TargetedManagedAppProtection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appGroupType", (o,n) => { (o as TargetedManagedAppProtection).AppGroupType = n.GetEnumValue<TargetedManagedAppGroupType>(); } },
                {"assignments", (o,n) => { (o as TargetedManagedAppProtection).Assignments = n.GetCollectionOfObjectValues<TargetedManagedAppPolicyAssignment>(TargetedManagedAppPolicyAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"isAssigned", (o,n) => { (o as TargetedManagedAppProtection).IsAssigned = n.GetBoolValue(); } },
                {"targetedAppManagementLevels", (o,n) => { (o as TargetedManagedAppProtection).TargetedAppManagementLevels = n.GetEnumValue<AppManagementLevel>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<TargetedManagedAppGroupType>("appGroupType", AppGroupType);
            writer.WriteCollectionOfObjectValues<TargetedManagedAppPolicyAssignment>("assignments", Assignments);
            writer.WriteBoolValue("isAssigned", IsAssigned);
            writer.WriteEnumValue<AppManagementLevel>("targetedAppManagementLevels", TargetedAppManagementLevels);
        }
    }
}
