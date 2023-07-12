using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Constraint enforcing a given string length range
    /// </summary>
    public class DeviceManagementSettingStringLengthConstraint : DeviceManagementConstraint, IParsable {
        /// <summary>The maximum permitted string length</summary>
        public int? MaximumLength {
            get { return BackingStore?.Get<int?>("maximumLength"); }
            set { BackingStore?.Set("maximumLength", value); }
        }
        /// <summary>The minimum permitted string length</summary>
        public int? MinimumLength {
            get { return BackingStore?.Get<int?>("minimumLength"); }
            set { BackingStore?.Set("minimumLength", value); }
        }
        /// <summary>
        /// Instantiates a new deviceManagementSettingStringLengthConstraint and sets the default values.
        /// </summary>
        public DeviceManagementSettingStringLengthConstraint() : base() {
            OdataType = "#microsoft.graph.deviceManagementSettingStringLengthConstraint";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementSettingStringLengthConstraint CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementSettingStringLengthConstraint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"maximumLength", n => { MaximumLength = n.GetIntValue(); } },
                {"minimumLength", n => { MinimumLength = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("maximumLength", MaximumLength);
            writer.WriteIntValue("minimumLength", MinimumLength);
        }
    }
}
