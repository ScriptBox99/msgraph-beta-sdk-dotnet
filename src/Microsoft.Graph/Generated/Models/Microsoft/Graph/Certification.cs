using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the collection of application entities.</summary>
    public class Certification : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>URL that shows certification details for the application.</summary>
        public string CertificationDetailsUrl { get; set; }
        /// <summary>The timestamp when the current certification for the application will expire.</summary>
        public DateTimeOffset? CertificationExpirationDateTime { get; set; }
        /// <summary>Indicates whether the application is certified by Microsoft.</summary>
        public bool? IsCertifiedByMicrosoft { get; set; }
        /// <summary>Indicates whether the application has been self-attested by the application developer or the publisher.</summary>
        public bool? IsPublisherAttested { get; set; }
        /// <summary>The timestamp when the certification for the application was most recently added or updated.</summary>
        public DateTimeOffset? LastCertificationDateTime { get; set; }
        /// <summary>
        /// Instantiates a new certification and sets the default values.
        /// </summary>
        public Certification() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Certification CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Certification();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"certificationDetailsUrl", (o,n) => { (o as Certification).CertificationDetailsUrl = n.GetStringValue(); } },
                {"certificationExpirationDateTime", (o,n) => { (o as Certification).CertificationExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"isCertifiedByMicrosoft", (o,n) => { (o as Certification).IsCertifiedByMicrosoft = n.GetBoolValue(); } },
                {"isPublisherAttested", (o,n) => { (o as Certification).IsPublisherAttested = n.GetBoolValue(); } },
                {"lastCertificationDateTime", (o,n) => { (o as Certification).LastCertificationDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("certificationDetailsUrl", CertificationDetailsUrl);
            writer.WriteDateTimeOffsetValue("certificationExpirationDateTime", CertificationExpirationDateTime);
            writer.WriteBoolValue("isCertifiedByMicrosoft", IsCertifiedByMicrosoft);
            writer.WriteBoolValue("isPublisherAttested", IsPublisherAttested);
            writer.WriteDateTimeOffsetValue("lastCertificationDateTime", LastCertificationDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
