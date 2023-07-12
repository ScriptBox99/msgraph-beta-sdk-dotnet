using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class RetentionDurationInDays : RetentionDuration, IParsable {
        /// <summary>Specifies the time period in days for which an item with the applied retention label will be retained for.</summary>
        public int? Days {
            get { return BackingStore?.Get<int?>("days"); }
            set { BackingStore?.Set("days", value); }
        }
        /// <summary>
        /// Instantiates a new retentionDurationInDays and sets the default values.
        /// </summary>
        public RetentionDurationInDays() : base() {
            OdataType = "#microsoft.graph.security.retentionDurationInDays";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RetentionDurationInDays CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RetentionDurationInDays();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"days", n => { Days = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("days", Days);
        }
    }
}
