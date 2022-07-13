using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceAndAppManagementRoleAssignment : RoleAssignment, IParsable {
        /// <summary>The list of ids of role member security groups. These are IDs from Azure Active Directory.</summary>
        public List<string> Members {
            get { return BackingStore?.Get<List<string>>("members"); }
            set { BackingStore?.Set("members", value); }
        }
        /// <summary>The set of Role Scope Tags defined on the Role Assignment.</summary>
        public List<RoleScopeTag> RoleScopeTags {
            get { return BackingStore?.Get<List<RoleScopeTag>>("roleScopeTags"); }
            set { BackingStore?.Set("roleScopeTags", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceAndAppManagementRoleAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceAndAppManagementRoleAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"members", n => { Members = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"roleScopeTags", n => { RoleScopeTags = n.GetCollectionOfObjectValues<RoleScopeTag>(RoleScopeTag.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("members", Members);
            writer.WriteCollectionOfObjectValues<RoleScopeTag>("roleScopeTags", RoleScopeTags);
        }
    }
}
