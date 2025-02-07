// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class InactiveUsersMetricBase : Entity, IParsable {
        /// <summary>The factDate property</summary>
        public Date? FactDate {
            get { return BackingStore?.Get<Date?>("factDate"); }
            set { BackingStore?.Set("factDate", value); }
        }
        /// <summary>The inactive30DayCount property</summary>
        public long? Inactive30DayCount {
            get { return BackingStore?.Get<long?>("inactive30DayCount"); }
            set { BackingStore?.Set("inactive30DayCount", value); }
        }
        /// <summary>The inactive60DayCount property</summary>
        public long? Inactive60DayCount {
            get { return BackingStore?.Get<long?>("inactive60DayCount"); }
            set { BackingStore?.Set("inactive60DayCount", value); }
        }
        /// <summary>The inactive90DayCount property</summary>
        public long? Inactive90DayCount {
            get { return BackingStore?.Get<long?>("inactive90DayCount"); }
            set { BackingStore?.Set("inactive90DayCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new InactiveUsersMetricBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.dailyInactiveUsersMetric" => new DailyInactiveUsersMetric(),
                "#microsoft.graph.monthlyInactiveUsersMetric" => new MonthlyInactiveUsersMetric(),
                _ => new InactiveUsersMetricBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"factDate", n => { FactDate = n.GetDateValue(); } },
                {"inactive30DayCount", n => { Inactive30DayCount = n.GetLongValue(); } },
                {"inactive60DayCount", n => { Inactive60DayCount = n.GetLongValue(); } },
                {"inactive90DayCount", n => { Inactive90DayCount = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateValue("factDate", FactDate);
            writer.WriteLongValue("inactive30DayCount", Inactive30DayCount);
            writer.WriteLongValue("inactive60DayCount", Inactive60DayCount);
            writer.WriteLongValue("inactive90DayCount", Inactive90DayCount);
        }
    }
}
