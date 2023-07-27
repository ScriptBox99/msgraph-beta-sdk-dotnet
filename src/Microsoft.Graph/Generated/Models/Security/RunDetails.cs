using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class RunDetails : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The errorCode property</summary>
        public HuntingRuleErrorCode? ErrorCode {
            get { return BackingStore?.Get<HuntingRuleErrorCode?>("errorCode"); }
            set { BackingStore?.Set("errorCode", value); }
        }
        /// <summary>The failureReason property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FailureReason {
            get { return BackingStore?.Get<string?>("failureReason"); }
            set { BackingStore?.Set("failureReason", value); }
        }
#nullable restore
#else
        public string FailureReason {
            get { return BackingStore?.Get<string>("failureReason"); }
            set { BackingStore?.Set("failureReason", value); }
        }
#endif
        /// <summary>The lastRunDateTime property</summary>
        public DateTimeOffset? LastRunDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastRunDateTime"); }
            set { BackingStore?.Set("lastRunDateTime", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The status property</summary>
        public HuntingRuleRunStatus? Status {
            get { return BackingStore?.Get<HuntingRuleRunStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Instantiates a new runDetails and sets the default values.
        /// </summary>
        public RunDetails() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RunDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RunDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"errorCode", n => { ErrorCode = n.GetEnumValue<HuntingRuleErrorCode>(); } },
                {"failureReason", n => { FailureReason = n.GetStringValue(); } },
                {"lastRunDateTime", n => { LastRunDateTime = n.GetDateTimeOffsetValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<HuntingRuleRunStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<HuntingRuleErrorCode>("errorCode", ErrorCode);
            writer.WriteStringValue("failureReason", FailureReason);
            writer.WriteDateTimeOffsetValue("lastRunDateTime", LastRunDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<HuntingRuleRunStatus>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
