using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.AverageIfs {
    public class AverageIfsRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json AverageRange { get; set; }
        public Json Values { get; set; }
        /// <summary>
        /// Instantiates a new averageIfsRequestBody and sets the default values.
        /// </summary>
        public AverageIfsRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AverageIfsRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AverageIfsRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"averageRange", (o,n) => { (o as AverageIfsRequestBody).AverageRange = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"values", (o,n) => { (o as AverageIfsRequestBody).Values = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("averageRange", AverageRange);
            writer.WriteObjectValue<Json>("values", Values);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
