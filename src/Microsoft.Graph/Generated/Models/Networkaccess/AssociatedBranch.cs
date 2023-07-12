using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess {
    public class AssociatedBranch : Association, IParsable {
        /// <summary>Identifier for the branch.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BranchId {
            get { return BackingStore?.Get<string?>("branchId"); }
            set { BackingStore?.Set("branchId", value); }
        }
#nullable restore
#else
        public string BranchId {
            get { return BackingStore?.Get<string>("branchId"); }
            set { BackingStore?.Set("branchId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new associatedBranch and sets the default values.
        /// </summary>
        public AssociatedBranch() : base() {
            OdataType = "#microsoft.graph.networkaccess.associatedBranch";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AssociatedBranch CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AssociatedBranch();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"branchId", n => { BranchId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("branchId", BranchId);
        }
    }
}
