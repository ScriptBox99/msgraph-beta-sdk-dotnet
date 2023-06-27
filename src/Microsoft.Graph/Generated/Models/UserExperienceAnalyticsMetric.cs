using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The user experience analytics metric contains the score and units of a metric of a user experience anlaytics category.
    /// </summary>
    public class UserExperienceAnalyticsMetric : Entity, IParsable {
        /// <summary>The unit of the user experience analytics metric. Examples: none, percentage, count, seconds, score.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Unit {
            get { return BackingStore?.Get<string?>("unit"); }
            set { BackingStore?.Set("unit", value); }
        }
#nullable restore
#else
        public string Unit {
            get { return BackingStore?.Get<string>("unit"); }
            set { BackingStore?.Set("unit", value); }
        }
#endif
        /// <summary>The value of the user experience analytics metric.</summary>
        public double? Value {
            get { return BackingStore?.Get<double?>("value"); }
            set { BackingStore?.Set("value", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserExperienceAnalyticsMetric CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsMetric();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"unit", n => { Unit = n.GetStringValue(); } },
                {"value", n => { Value = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("unit", Unit);
            writer.WriteDoubleValue("value", Value);
        }
    }
}
