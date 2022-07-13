using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MobileAppSupersedence : MobileAppRelationship, IParsable {
        /// <summary>The total number of apps directly or indirectly superseded by the child app.</summary>
        public int? SupersededAppCount {
            get { return BackingStore?.Get<int?>("supersededAppCount"); }
            set { BackingStore?.Set("supersededAppCount", value); }
        }
        /// <summary>Indicates the supersedence type associated with a relationship between two mobile apps.</summary>
        public MobileAppSupersedenceType? SupersedenceType {
            get { return BackingStore?.Get<MobileAppSupersedenceType?>("supersedenceType"); }
            set { BackingStore?.Set("supersedenceType", value); }
        }
        /// <summary>The total number of apps directly or indirectly superseding the parent app.</summary>
        public int? SupersedingAppCount {
            get { return BackingStore?.Get<int?>("supersedingAppCount"); }
            set { BackingStore?.Set("supersedingAppCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MobileAppSupersedence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MobileAppSupersedence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"supersededAppCount", n => { SupersededAppCount = n.GetIntValue(); } },
                {"supersedenceType", n => { SupersedenceType = n.GetEnumValue<MobileAppSupersedenceType>(); } },
                {"supersedingAppCount", n => { SupersedingAppCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("supersededAppCount", SupersededAppCount);
            writer.WriteEnumValue<MobileAppSupersedenceType>("supersedenceType", SupersedenceType);
            writer.WriteIntValue("supersedingAppCount", SupersedingAppCount);
        }
    }
}
