using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class VppTokenRevokeLicensesActionResult : VppTokenActionResult, IParsable {
        /// <summary>Possible types of reasons for an Apple Volume Purchase Program token action failure.</summary>
        public VppTokenActionFailureReason? ActionFailureReason {
            get { return BackingStore?.Get<VppTokenActionFailureReason?>("actionFailureReason"); }
            set { BackingStore?.Set("actionFailureReason", value); }
        }
        /// <summary>A count of the number of licenses that failed to revoke.</summary>
        public int? FailedLicensesCount {
            get { return BackingStore?.Get<int?>("failedLicensesCount"); }
            set { BackingStore?.Set("failedLicensesCount", value); }
        }
        /// <summary>A count of the number of licenses that were attempted to revoke.</summary>
        public int? TotalLicensesCount {
            get { return BackingStore?.Get<int?>("totalLicensesCount"); }
            set { BackingStore?.Set("totalLicensesCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new VppTokenRevokeLicensesActionResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VppTokenRevokeLicensesActionResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"actionFailureReason", n => { ActionFailureReason = n.GetEnumValue<VppTokenActionFailureReason>(); } },
                {"failedLicensesCount", n => { FailedLicensesCount = n.GetIntValue(); } },
                {"totalLicensesCount", n => { TotalLicensesCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<VppTokenActionFailureReason>("actionFailureReason", ActionFailureReason);
            writer.WriteIntValue("failedLicensesCount", FailedLicensesCount);
            writer.WriteIntValue("totalLicensesCount", TotalLicensesCount);
        }
    }
}
