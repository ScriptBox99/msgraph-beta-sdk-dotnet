using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the print singleton.</summary>
    public class PrintUsage : Entity, IParsable {
        /// <summary>The completedBlackAndWhiteJobCount property</summary>
        public long? CompletedBlackAndWhiteJobCount {
            get { return BackingStore?.Get<long?>(nameof(CompletedBlackAndWhiteJobCount)); }
            set { BackingStore?.Set(nameof(CompletedBlackAndWhiteJobCount), value); }
        }
        /// <summary>The completedColorJobCount property</summary>
        public long? CompletedColorJobCount {
            get { return BackingStore?.Get<long?>(nameof(CompletedColorJobCount)); }
            set { BackingStore?.Set(nameof(CompletedColorJobCount), value); }
        }
        /// <summary>The incompleteJobCount property</summary>
        public long? IncompleteJobCount {
            get { return BackingStore?.Get<long?>(nameof(IncompleteJobCount)); }
            set { BackingStore?.Set(nameof(IncompleteJobCount), value); }
        }
        /// <summary>The usageDate property</summary>
        public Date? UsageDate {
            get { return BackingStore?.Get<Date?>(nameof(UsageDate)); }
            set { BackingStore?.Set(nameof(UsageDate), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PrintUsage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.printUsageByPrinter" => new PrintUsageByPrinter(),
                "#microsoft.graph.printUsageByUser" => new PrintUsageByUser(),
                _ => new PrintUsage(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"completedBlackAndWhiteJobCount", n => { CompletedBlackAndWhiteJobCount = n.GetLongValue(); } },
                {"completedColorJobCount", n => { CompletedColorJobCount = n.GetLongValue(); } },
                {"incompleteJobCount", n => { IncompleteJobCount = n.GetLongValue(); } },
                {"usageDate", n => { UsageDate = n.GetDateValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("completedBlackAndWhiteJobCount", CompletedBlackAndWhiteJobCount);
            writer.WriteLongValue("completedColorJobCount", CompletedColorJobCount);
            writer.WriteLongValue("incompleteJobCount", IncompleteJobCount);
            writer.WriteDateValue("usageDate", UsageDate);
        }
    }
}
