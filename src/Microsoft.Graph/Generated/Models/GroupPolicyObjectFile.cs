using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The Group Policy Object file uploaded by admin.
    /// </summary>
    public class GroupPolicyObjectFile : Entity, IParsable {
        /// <summary>The Group Policy Object file content.</summary>
        public string Content {
            get { return BackingStore?.Get<string>("content"); }
            set { BackingStore?.Set("content", value); }
        }
        /// <summary>The date and time at which the GroupPolicy was first uploaded.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The Group Policy Object GUID from GPO Xml content</summary>
        public Guid? GroupPolicyObjectId {
            get { return BackingStore?.Get<Guid?>("groupPolicyObjectId"); }
            set { BackingStore?.Set("groupPolicyObjectId", value); }
        }
        /// <summary>The date and time at which the GroupPolicyObjectFile was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The distinguished name of the OU.</summary>
        public string OuDistinguishedName {
            get { return BackingStore?.Get<string>("ouDistinguishedName"); }
            set { BackingStore?.Set("ouDistinguishedName", value); }
        }
        /// <summary>The list of scope tags for the configuration.</summary>
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new GroupPolicyObjectFile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GroupPolicyObjectFile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"content", n => { Content = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"groupPolicyObjectId", n => { GroupPolicyObjectId = n.GetGuidValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"ouDistinguishedName", n => { OuDistinguishedName = n.GetStringValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("content", Content);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteGuidValue("groupPolicyObjectId", GroupPolicyObjectId);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("ouDistinguishedName", OuDistinguishedName);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
        }
    }
}
