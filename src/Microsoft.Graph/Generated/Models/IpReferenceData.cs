using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class IpReferenceData : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The asn property</summary>
        public long? Asn {
            get { return BackingStore?.Get<long?>("asn"); }
            set { BackingStore?.Set("asn", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The city property</summary>
        public string City {
            get { return BackingStore?.Get<string>("city"); }
            set { BackingStore?.Set("city", value); }
        }
        /// <summary>The countryOrRegionCode property</summary>
        public string CountryOrRegionCode {
            get { return BackingStore?.Get<string>("countryOrRegionCode"); }
            set { BackingStore?.Set("countryOrRegionCode", value); }
        }
        /// <summary>The organization property</summary>
        public string Organization {
            get { return BackingStore?.Get<string>("organization"); }
            set { BackingStore?.Set("organization", value); }
        }
        /// <summary>The state property</summary>
        public string State {
            get { return BackingStore?.Get<string>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>The vendor property</summary>
        public string Vendor {
            get { return BackingStore?.Get<string>("vendor"); }
            set { BackingStore?.Set("vendor", value); }
        }
        /// <summary>
        /// Instantiates a new ipReferenceData and sets the default values.
        /// </summary>
        public IpReferenceData() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static IpReferenceData CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IpReferenceData();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"asn", n => { Asn = n.GetLongValue(); } },
                {"city", n => { City = n.GetStringValue(); } },
                {"countryOrRegionCode", n => { CountryOrRegionCode = n.GetStringValue(); } },
                {"organization", n => { Organization = n.GetStringValue(); } },
                {"state", n => { State = n.GetStringValue(); } },
                {"vendor", n => { Vendor = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("asn", Asn);
            writer.WriteStringValue("city", City);
            writer.WriteStringValue("countryOrRegionCode", CountryOrRegionCode);
            writer.WriteStringValue("organization", Organization);
            writer.WriteStringValue("state", State);
            writer.WriteStringValue("vendor", Vendor);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
