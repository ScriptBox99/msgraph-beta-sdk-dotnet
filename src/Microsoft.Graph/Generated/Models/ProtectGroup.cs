using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class ProtectGroup : LabelActionBase, IParsable {
        /// <summary>The allowEmailFromGuestUsers property</summary>
        public bool? AllowEmailFromGuestUsers {
            get { return BackingStore?.Get<bool?>("allowEmailFromGuestUsers"); }
            set { BackingStore?.Set("allowEmailFromGuestUsers", value); }
        }
        /// <summary>The allowGuestUsers property</summary>
        public bool? AllowGuestUsers {
            get { return BackingStore?.Get<bool?>("allowGuestUsers"); }
            set { BackingStore?.Set("allowGuestUsers", value); }
        }
        /// <summary>The privacy property</summary>
        public GroupPrivacy? Privacy {
            get { return BackingStore?.Get<GroupPrivacy?>("privacy"); }
            set { BackingStore?.Set("privacy", value); }
        }
        /// <summary>
        /// Instantiates a new protectGroup and sets the default values.
        /// </summary>
        public ProtectGroup() : base() {
            OdataType = "#microsoft.graph.protectGroup";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ProtectGroup CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProtectGroup();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowEmailFromGuestUsers", n => { AllowEmailFromGuestUsers = n.GetBoolValue(); } },
                {"allowGuestUsers", n => { AllowGuestUsers = n.GetBoolValue(); } },
                {"privacy", n => { Privacy = n.GetEnumValue<GroupPrivacy>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowEmailFromGuestUsers", AllowEmailFromGuestUsers);
            writer.WriteBoolValue("allowGuestUsers", AllowGuestUsers);
            writer.WriteEnumValue<GroupPrivacy>("privacy", Privacy);
        }
    }
}
