using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Metric snapshot value returned in response to a GetHealthMetricTimeSeries request.
    /// </summary>
    public class CertificateConnectorHealthMetricValue : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Timestamp for this metric data-point.</summary>
        public DateTimeOffset? DateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("dateTime"); }
            set { BackingStore?.Set("dateTime", value); }
        }
        /// <summary>Count of failed requests/operations.</summary>
        public long? FailureCount {
            get { return BackingStore?.Get<long?>("failureCount"); }
            set { BackingStore?.Set("failureCount", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Count of successful requests/operations.</summary>
        public long? SuccessCount {
            get { return BackingStore?.Get<long?>("successCount"); }
            set { BackingStore?.Set("successCount", value); }
        }
        /// <summary>
        /// Instantiates a new certificateConnectorHealthMetricValue and sets the default values.
        /// </summary>
        public CertificateConnectorHealthMetricValue() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CertificateConnectorHealthMetricValue CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CertificateConnectorHealthMetricValue();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"dateTime", n => { DateTime = n.GetDateTimeOffsetValue(); } },
                {"failureCount", n => { FailureCount = n.GetLongValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"successCount", n => { SuccessCount = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("dateTime", DateTime);
            writer.WriteLongValue("failureCount", FailureCount);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteLongValue("successCount", SuccessCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
