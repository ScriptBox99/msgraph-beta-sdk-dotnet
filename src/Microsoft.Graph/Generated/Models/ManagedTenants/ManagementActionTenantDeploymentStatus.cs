// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class ManagementActionTenantDeploymentStatus : Entity, IParsable {
        /// <summary>The collection of deployment status for each instance of a management action. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagementActionDeploymentStatus>? Statuses {
            get { return BackingStore?.Get<List<ManagementActionDeploymentStatus>?>("statuses"); }
            set { BackingStore?.Set("statuses", value); }
        }
#nullable restore
#else
        public List<ManagementActionDeploymentStatus> Statuses {
            get { return BackingStore?.Get<List<ManagementActionDeploymentStatus>>("statuses"); }
            set { BackingStore?.Set("statuses", value); }
        }
#endif
        /// <summary>The identifier for the tenant group that is associated with the management action. Required. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantGroupId {
            get { return BackingStore?.Get<string?>("tenantGroupId"); }
            set { BackingStore?.Set("tenantGroupId", value); }
        }
#nullable restore
#else
        public string TenantGroupId {
            get { return BackingStore?.Get<string>("tenantGroupId"); }
            set { BackingStore?.Set("tenantGroupId", value); }
        }
#endif
        /// <summary>The Microsoft Entra tenant identifier for the managed tenant. Required. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId {
            get { return BackingStore?.Get<string?>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#nullable restore
#else
        public string TenantId {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ManagementActionTenantDeploymentStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagementActionTenantDeploymentStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"statuses", n => { Statuses = n.GetCollectionOfObjectValues<ManagementActionDeploymentStatus>(ManagementActionDeploymentStatus.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tenantGroupId", n => { TenantGroupId = n.GetStringValue(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ManagementActionDeploymentStatus>("statuses", Statuses);
            writer.WriteStringValue("tenantGroupId", TenantGroupId);
            writer.WriteStringValue("tenantId", TenantId);
        }
    }
}
