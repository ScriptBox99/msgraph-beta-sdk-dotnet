using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the cloudCommunications singleton.</summary>
    public class OutOfOfficeSettings : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>True if either:It is currently in the out of office time window configured on the Outlook or Teams client.There is currently an event on the user's calendar that's marked as Show as Out of OfficeOtherwise, false.</summary>
        public bool? IsOutOfOffice { get; set; }
        /// <summary>The out of office message that the user configured on Outlook client (Automatic Replies (Out of Office)) or the Teams client (Schedule out of office).</summary>
        public string Message { get; set; }
        /// <summary>
        /// Instantiates a new outOfOfficeSettings and sets the default values.
        /// </summary>
        public OutOfOfficeSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static OutOfOfficeSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OutOfOfficeSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"isOutOfOffice", (o,n) => { (o as OutOfOfficeSettings).IsOutOfOffice = n.GetBoolValue(); } },
                {"message", (o,n) => { (o as OutOfOfficeSettings).Message = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isOutOfOffice", IsOutOfOffice);
            writer.WriteStringValue("message", Message);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
