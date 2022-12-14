using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The security baseline compliance state summary for the security baseline of the account.
    /// </summary>
    public class SecurityBaselineStateSummary : Entity, IParsable {
        /// <summary>Number of conflict devices</summary>
        public int? ConflictCount {
            get { return BackingStore?.Get<int?>("conflictCount"); }
            set { BackingStore?.Set("conflictCount", value); }
        }
        /// <summary>Number of error devices</summary>
        public int? ErrorCount {
            get { return BackingStore?.Get<int?>("errorCount"); }
            set { BackingStore?.Set("errorCount", value); }
        }
        /// <summary>Number of not applicable devices</summary>
        public int? NotApplicableCount {
            get { return BackingStore?.Get<int?>("notApplicableCount"); }
            set { BackingStore?.Set("notApplicableCount", value); }
        }
        /// <summary>Number of not secure devices</summary>
        public int? NotSecureCount {
            get { return BackingStore?.Get<int?>("notSecureCount"); }
            set { BackingStore?.Set("notSecureCount", value); }
        }
        /// <summary>Number of secure devices</summary>
        public int? SecureCount {
            get { return BackingStore?.Get<int?>("secureCount"); }
            set { BackingStore?.Set("secureCount", value); }
        }
        /// <summary>Number of unknown devices</summary>
        public int? UnknownCount {
            get { return BackingStore?.Get<int?>("unknownCount"); }
            set { BackingStore?.Set("unknownCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SecurityBaselineStateSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.securityBaselineCategoryStateSummary" => new SecurityBaselineCategoryStateSummary(),
                _ => new SecurityBaselineStateSummary(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"conflictCount", n => { ConflictCount = n.GetIntValue(); } },
                {"errorCount", n => { ErrorCount = n.GetIntValue(); } },
                {"notApplicableCount", n => { NotApplicableCount = n.GetIntValue(); } },
                {"notSecureCount", n => { NotSecureCount = n.GetIntValue(); } },
                {"secureCount", n => { SecureCount = n.GetIntValue(); } },
                {"unknownCount", n => { UnknownCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("conflictCount", ConflictCount);
            writer.WriteIntValue("errorCount", ErrorCount);
            writer.WriteIntValue("notApplicableCount", NotApplicableCount);
            writer.WriteIntValue("notSecureCount", NotSecureCount);
            writer.WriteIntValue("secureCount", SecureCount);
            writer.WriteIntValue("unknownCount", UnknownCount);
        }
    }
}
