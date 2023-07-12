using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Properties of the  String script parameter.
    /// </summary>
    public class DeviceHealthScriptStringParameter : DeviceHealthScriptParameter, IParsable {
        /// <summary>The default value of string param</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultValue {
            get { return BackingStore?.Get<string?>("defaultValue"); }
            set { BackingStore?.Set("defaultValue", value); }
        }
#nullable restore
#else
        public string DefaultValue {
            get { return BackingStore?.Get<string>("defaultValue"); }
            set { BackingStore?.Set("defaultValue", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new deviceHealthScriptStringParameter and sets the default values.
        /// </summary>
        public DeviceHealthScriptStringParameter() : base() {
            OdataType = "#microsoft.graph.deviceHealthScriptStringParameter";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceHealthScriptStringParameter CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceHealthScriptStringParameter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"defaultValue", n => { DefaultValue = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("defaultValue", DefaultValue);
        }
    }
}
