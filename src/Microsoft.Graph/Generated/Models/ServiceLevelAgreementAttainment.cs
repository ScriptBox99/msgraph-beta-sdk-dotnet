using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class ServiceLevelAgreementAttainment : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The end date for the calendar month for which SLA attainment is measured.</summary>
        public Date? EndDate {
            get { return BackingStore?.Get<Date?>("endDate"); }
            set { BackingStore?.Set("endDate", value); }
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
        /// <summary>The level of SLA attainment achieved by the tenant for the calendar month identified, as described in Azure Active Directory SLA performance. Values are truncated, not rounded, so the actual value is always equal to or higher than the displayed value. Values are expressed as a percentage of availability for the tenant.</summary>
        public double? Score {
            get { return BackingStore?.Get<double?>("score"); }
            set { BackingStore?.Set("score", value); }
        }
        /// <summary>The start date for the calendar month for which SLA attainment is measured.</summary>
        public Date? StartDate {
            get { return BackingStore?.Get<Date?>("startDate"); }
            set { BackingStore?.Set("startDate", value); }
        }
        /// <summary>
        /// Instantiates a new serviceLevelAgreementAttainment and sets the default values.
        /// </summary>
        public ServiceLevelAgreementAttainment() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ServiceLevelAgreementAttainment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ServiceLevelAgreementAttainment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"endDate", n => { EndDate = n.GetDateValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"score", n => { Score = n.GetDoubleValue(); } },
                {"startDate", n => { StartDate = n.GetDateValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateValue("endDate", EndDate);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDoubleValue("score", Score);
            writer.WriteDateValue("startDate", StartDate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
