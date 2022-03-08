using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the planner singleton.</summary>
    public class PlannerRosterMember : Entity, IParsable {
        /// <summary>Additional roles associated with the PlannerRosterMember, which determines permissions of the member in the plannerRoster. Currently there are no available roles to assign, and every member has full control over the contents of the plannerRoster.</summary>
        public List<string> Roles { get; set; }
        /// <summary>Identifier of the tenant the user belongs to. Currently only the users from the same tenant can be added to a plannerRoster.</summary>
        public string TenantId { get; set; }
        /// <summary>Identifier of the user.</summary>
        public string UserId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PlannerRosterMember CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerRosterMember();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"roles", (o,n) => { (o as PlannerRosterMember).Roles = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"tenantId", (o,n) => { (o as PlannerRosterMember).TenantId = n.GetStringValue(); } },
                {"userId", (o,n) => { (o as PlannerRosterMember).UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("roles", Roles);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
